

//PN: FILE NAME: "Newhr_promotioninfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    

    $('body').on('click', '#btnUpdateHrPromotionInfo', function (event) {
        try {
            event.preventDefault();

            var form = $('#frmHr_PromotionInfoEdit');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

			 var kaffileUploader = $('#id').kaffileUploader();
			 var fileobjects_tbl_orderfiledescription = $('#id').kaffileUploader.GetFilesForActions('tbl_orderfiledescription');
			 var fileobjects = fileobjects_tbl_orderfiledescription;

			  $.each(fileobjects, function (key, valueObj) {
					  valueObj.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
			   });



            
            if (form.valid()) {

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "HrFamilyInfoCreate",
                    currenturl: window.location.href,

							 promotionid: $('#promotionid').val(),
							 hrbasicid: $('#hrbasicid').val(),
							 promotiondate: GetDateFromTextBox($('#promotiondate').val()),
							 promotiontypeid: $('#promotiontypeid').val(),
							 torankid: $('#torankid').val(),
							 promotionno: $('#promotionno').val(),
							 promotiondesignation: $('#promotiondesignation').val(),
							 promotiondelayreason: $('#promotiondelayreason').val(),
							 promotiondelaydocno: $('#promotiondelaydocno').val(),
							 promotiondelaydocdate: GetDateFromTextBox($('#promotiondelaydocdate').val()),
							 promotiondelaystartdate: GetDateFromTextBox($('#promotiondelaystartdate').val()),
							 promotiondelayperiod: $('#promotiondelayperiod').val(),
							 orderno: $('#orderno').val(),
							 orderdate: GetDateFromTextBox($('#orderdate').val()),
							 orderfiledescription: $('#orderfiledescription').val(),
							 orderfilepath: $('#orderfilepath').val(),
							 orderfilename: $('#orderfilename').val(),
							 orderfiletype: $('#orderfiletype').val(),
							 orderextension: $('#orderextension').val(),
							 orderfileno: $('#orderfileno').val(),
							 remarks: $('#remarks').val(),
							 cor_foldercontentsList: fileobjects


                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrPromotionInfo/HrPromotionInfoUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "HrPromotionInfo/HrPromotionInfo";
                                            $('#mcHrPromotionInfoEdit').html('');
                                            $('#modal-container-HrPromotionInfoEdit').modal('hide');
                                            GetAllDataHrPromotionInfo();
                                        }

                                    });

                                }

                                else {
                                    return;
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
            $('#mcHrPromotionInfoEdit').html('');
            $('#modal-container-HrPromotionInfoEdit').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    

});






