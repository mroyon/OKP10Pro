

//PN: FILE NAME: "Newhr_newdemand.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    

    $('body').on('click', '#btnUpdateHrNewDemand', function (event) {
        try {
            event.preventDefault();

            var form = $('#frmHr_NewDemandEdit');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            var i = 1;
            var trDemand = $('#NewDemandDtNew').parent().parent();
            $("#NewDemandDtNew .newdemanddetlid").each(function (index) {
                if (!$(this).closest('tr').hasClass('hidden')) {
                    if (parseInt(trDemand.find('#noofvacancies' + i).attr("min")) > parseInt(trDemand.find('#noofvacancies' + i).val())) {
                        trDemand.find('#noofvacancies' + i).css("border", "1px solid red");
                        isOutOfRange = true;
                    };
                }
                i++;
            });

            if (isOutOfRange) {
                $.alert({
                    title: _getCookieForLanguage("_informationTitle"),
                    content: "Input is out of range",
                    type: 'red'
                });
                return false;
            }
            
            if (form.valid()) {
                var isvalid = true;
                var isOutOfRange = false;
                var hasData = false;
                var indexes = 1;
                var strValue = "";
                var trDemand = $('#NewDemandDtNew').parent().parent();
                $("#NewDemandDtNew .newdemanddetlid").each(function (index) {

                    //console.log(trDemand.find('#noofvacancies' + indexes).html());
                    trDemand.find('#noofvacancies' + indexes).css("border", "1px solid #aaa");

                    //if (!$("#NewDemandDtNew tbody tr").hasClass('hidden')) {
                    if (!$(this).closest('tr').hasClass('hidden')) {
                        if (trDemand.find('#noofvacancies' + indexes).val().length == 0) {
                            trDemand.find('#noofvacancies' + indexes).css("border", "1px solid red");
                            isvalid = false;
                        };

                        if (parseInt(trDemand.find('#noofvacancies' + indexes).val()) <= 0) {
                            trDemand.find('#noofvacancies' + indexes).css("border", "1px solid red");
                            isvalid = false;
                        };

                       
                    }
                    
                    if (!$(this).hasClass('hidden')) {
                        if ($(this).attr("operation") == "delete") {
                            if ($('#newdemanddetlid' + indexes).val() != "") { strValue += $('#newdemanddetlid' + indexes).val() + "|0|0|0|0|0,"; }}
                        else {
                            var rankidkw = trDemand.find('#rankidkw' + indexes).val();
                            var tradeidkw = trDemand.find('#tradeidkw' + indexes).val();
                            var groupid = trDemand.find('#groupid' + indexes).val();
                            var okpid = trDemand.find('#okpid' + indexes).val();
                            var noofvacancies = trDemand.find('#noofvacancies' + indexes).val();

                            strValue += $('#newdemanddetlid' + indexes).val() + "|" + rankidkw + "|" + tradeidkw + "|" + groupid + "|" + okpid + "|" + noofvacancies + ",";
                            hasData = true;
                        }
                    }
                    indexes++;
                });

                if (!isvalid) {
                    $.alert({
                        title: _getCookieForLanguage("_informationTitle"),
                        content: "No of vacancies must be greater than 0",
                        type: 'red'
                    });
                    return false;
                }
                
                //console.log(strValue);

                if (hasData == false) {
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
                            url: baseurl + "HrNewDemand/HrNewDemandUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "HrNewDemand/HrNewDemand";
                                            $('#mcHrNewDemandEdit').html('');
                                            $('#modal-container-HrNewDemandEdit').modal('hide');
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
    
    $('body').on('click', '#btnModalCloseEdit', function (event) {
        try {
            event.preventDefault();
            $('#mcHrNewDemandEdit').html('');
            $('#modal-container-HrNewDemandEdit').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
    //function ValidateInput(rankid, tradeid, groupid, okpid) {
    //    var ret = 0;
    //    $("#NewDemandDtNew .newdemanddetlid").each(function (index, element) {
    //        if (curr_index != index && $(element).val().toLowerCase() == passportnumber.toLowerCase()) {
    //            ret = 1;
    //            return false;
    //        }

    //    });

    //    return ret;
    //}
});






