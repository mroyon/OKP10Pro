

//PN: FILE NAME: "Newhr_rewardinfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

   


    $('body').on('click', '#btnSaveHrRewardInfo', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmHr_RewardInfoNew');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);




    
            if (form.valid()) {

               
                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "HrFamilyInfoCreate",
                    currenturl: window.location.href,

							 hrrewardid: $('#hrrewardid').val(),
							 hrbasicid: $('#hrbasicid').val(),
							 rewarddate: GetDateFromTextBox($('#rewarddate').val()),
							 rewardevent: $('#rewardevent').val(),
							 reward: $('#reward').val(),
							 rewardcountryid: $('#rewardcountryid').val(),
							 description: $('#description').val(),
							 remarks: $('#remarks').val(),

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrRewardInfo/HrRewardInfoInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "HrRewardInfo/HrRewardInfo";
                                            $('#mcHrRewardInfoNew').html('');
                                            $('#modal-container-HrRewardInfoNew').modal('hide');
                                            GetAllDataHrRewardInfo();
                                        }
                                        else
                                        {
                                            $('#mcHrRewardInfoNew').html('');
                                            $('#modal-container-HrRewardInfoNew').modal('hide');
                                            GetAllDataHrRewardInfo();
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
    
    
    
    $('body').on('click', '#btnModalCloseNew', function (event) {
        try {
            event.preventDefault();
            $('#mcHrRewardInfoNew').html('');
            $('#modal-container-HrRewardInfoNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
  

});



