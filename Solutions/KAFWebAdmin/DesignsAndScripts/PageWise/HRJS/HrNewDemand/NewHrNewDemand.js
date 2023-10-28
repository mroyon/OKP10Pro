

//PN: FILE NAME: "Newhr_newdemand.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    //HrNewDemandNewRow();

    $('body').on('click', '#btnSaveHrNewDemand', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmHr_NewDemandNew');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            var indexes = 1;
            var strValue = "";
            var isvalid = true;

            var trDemand = $('#NewDemandDtNew').parent().parent();
            $("#NewDemandDtNew tbody tr").each(function (index) {

                
                trDemand.find('#noofvacancies' + indexes).css("border", "1px solid #aaa");

                if (!$(this).hasClass('hidden') && (trDemand.find('#noofvacancies' + indexes).val().length == 0 || parseInt(trDemand.find('#noofvacancies' + indexes).val()) <= 0)) {
                    //console.log(trDemand.find('#noofvacancies' + indexes).val());
                    trDemand.find('#noofvacancies' + indexes).css("border", "1px solid red");
                    isvalid = false;
                };

                if (!$(this).hasClass('hidden')) {
                    var rankidkw = trDemand.find('#rankidkw' + indexes).val();
                    var tradeidkw = trDemand.find('#tradeidkw' + indexes).val();
                    var groupid = trDemand.find('#groupid' + indexes).val();
                    var okpid = trDemand.find('#okpid' + indexes).val();
                    var noofvacancies = trDemand.find('#noofvacancies' + indexes).val();
                    strValue += "|" + rankidkw + "|" + tradeidkw + "|" + groupid + "|" + okpid + "|" + noofvacancies + ",";
                }
                indexes++;
            });

            

            if (form.valid()) {


                if (!isvalid) {
                    $.alert({
                        title: _getCookieForLanguage("_informationTitle"),
                        content: "No of vacancies must be greater than 0",
                        type: 'red'
                    });
                    return;
                }
                console.log(strValue);

                if (strValue == "") {
                    $.alert({
                        title: _getCookieForLanguage("_informationTitle"),
                        content: "No data found",
                        type: 'red'
                    });
                    return;
                }


                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "HrFamilyInfoCreate",
                    currenturl: window.location.href,

					newdemandid: $('#newdemandid').val(),
					demandletterno: $('#demandletterno').val(),
					demandletterdate: GetDateFromTextBox($('#demandletterdate').val()),
                    remarks: $('#remarks').val(),
                    strValue1: strValue
                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrNewDemand/HrNewDemandInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "HrNewDemand/HrNewDemand";
                                            $('#mcHrNewDemandNew').html('');
                                            $('#modal-container-HrNewDemandNew').modal('hide');
                                            GetAllDataHrNewDemand();
                                        }
                                        else
                                        {
                                            $('#mcHrNewDemandNew').html('');
                                            $('#modal-container-HrNewDemandNew').modal('hide');
                                            GetAllDataHrNewDemand();
                                        }
                                    });
                                }

                                else {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            //window.location.href =  baseurl + "HrReplacementInfo/HrReplacementInfo";
                                            //$('#mcHrReplacementInfoNew').html('');
                                            //$('#modal-container-HrReplacementInfoNew').modal('hide');

                                        }
                                    });
                                }
                            }
                        });
                    }
                });
            }
            else {
                return;
            }

        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
    
    
    $('body').on('click', '#btnModalCloseNew', function (event) {
        try {
            event.preventDefault();
            $('#mcHrNewDemandNew').html('');
            $('#modal-container-HrNewDemandNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
  

});




