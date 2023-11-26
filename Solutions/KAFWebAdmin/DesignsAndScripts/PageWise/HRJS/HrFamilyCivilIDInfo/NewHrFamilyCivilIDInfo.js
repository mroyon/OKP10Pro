﻿

//PN: FILE NAME: "Newhr_familycivilidinfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

   


    $('body').on('click', '#btnSaveHrFamilyCivilIDInfo', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmHr_FamilyCivilIDInfoNew');
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

							 familycivilid: $('#familycivilid').val(),
							 hrfamilyid: $('#hrfamilyid').val(),
							 hrbasicid: $('#hrbasicid').val(),
							 familycivilidno: $('#familycivilidno').val(),
							 serialno: $('#serialno').val(),
							 familycivilidissuedate: GetDateFromTextBox($('#familycivilidissuedate').val()),
							 familycivilidexpirydate: GetDateFromTextBox($('#familycivilidexpirydate').val()),
							 familycivilidfiledescription: $('#familycivilidfiledescription').val(),
							 familycivilidfilepath: $('#familycivilidfilepath').val(),
							 familycivilidfilename: $('#familycivilidfilename').val(),
							 familycivilidfiletype: $('#familycivilidfiletype').val(),
							 familycivilidextension: $('#familycivilidextension').val(),
							 familycivilidfileid: $('#familycivilidfileid').val(),
							 remarks: $('#remarks').val(),
							 forreview: $('#forreview').val(),
							 iscurrent: $('#iscurrent').val(),

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrFamilyCivilIDInfo/HrFamilyCivilIDInfoInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "HrFamilyCivilIDInfo/HrFamilyCivilIDInfo";
                                            $('#mcHrFamilyCivilIDInfoNew').html('');
                                            $('#modal-container-HrFamilyCivilIDInfoNew').modal('hide');
                                            GetAllDataHrFamilyCivilIDInfo();
                                        }
                                        else
                                        {
                                            $('#mcHrFamilyCivilIDInfoNew').html('');
                                            $('#modal-container-HrFamilyCivilIDInfoNew').modal('hide');
                                            GetAllDataHrFamilyCivilIDInfo();
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
            $('#mcHrFamilyCivilIDInfoNew').html('');
            $('#modal-container-HrFamilyCivilIDInfoNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
  

});



