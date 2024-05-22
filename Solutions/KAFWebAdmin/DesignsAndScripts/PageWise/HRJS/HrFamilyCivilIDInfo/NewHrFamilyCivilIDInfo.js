

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
            //var form = $('#frmHr_FamilyCivilIDInfoNew');
            //jQuery.validator.unobtrusive.parse();
            //jQuery.validator.unobtrusive.parse(form);




    
            //if (form.valid()) {

               
        //        var input = AddAntiForgeryToken({
        //            token: $(".txtUserSTK").val(),
        //            userinfo: $(".txtServerUtilObj").val(),
        //            useripaddress: $(".txtuserip").val(),
        //            sessionid: $(".txtUserSes").val(),
        //            methodname: "HrFamilyInfoCreate",
        //            currenturl: window.location.href,

							 //familycivilid: $('#familycivilid').val(),
							 //hrfamilyid: $('#hrfamilyid').val(),
							 //hrbasicid: $('#hrbasicid').val(),
							 //familycivilidno: $('#familycivilidno').val(),
							 //serialno: $('#serialno').val(),
							 //familycivilidissuedate: GetDateFromTextBox($('#familycivilidissuedate').val()),
							 //familycivilidexpirydate: GetDateFromTextBox($('#familycivilidexpirydate').val()),
							 //familycivilidfiledescription: $('#familycivilidfiledescription').val(),
							 //familycivilidfilepath: $('#familycivilidfilepath').val(),
							 //familycivilidfilename: $('#familycivilidfilename').val(),
							 //familycivilidfiletype: $('#familycivilidfiletype').val(),
							 //familycivilidextension: $('#familycivilidextension').val(),
							 //familycivilidfileid: $('#familycivilidfileid').val(),
							 //remarks: $('#remarks').val(),
							 //forreview: true,
							 //iscurrent: true,

        //        });

                var form = new FormData();

                form.append("token", $(".txtUserSTK").val());
                form.append("userinfo", $(".txtServerUtilObj").val());
                form.append("useripaddress", $(".txtuserip").val());
                form.append("sessionid", $(".txtUserSes").val());
                form.append("methodname", "HrFamilyInfoCreate");
                form.append("currenturl", window.location.href);
                form.append("__RequestVerificationToken", $('input[name=__RequestVerificationToken]').val());

                form.append("familycivilid", $('#familycivilid').val());
            form.append("hrfamilyid", $('#hrfamilyid').val());
                form.append("hrbasicid", $('#hrbasicid').val());
                form.append("familycivilidno", $('#familycivilidno').val());
                form.append("serialno", $('#serialno').val());
            form.append("familycivilidissuedate", GetDateFromTextBox($('#familycivilidissuedate').val()));
            form.append("familycivilidexpirydate", GetDateFromTextBox($('#familycivilidexpirydate').val()));
                form.append("remarks", $('#remarks').val());
                form.append("forreview", $('#forreview').val());
                form.append("iscurrent", true);

                form.append("formfile1", $("#fileInput")[0].files[0]);
                form.append("formfile2", $("#fileInput2")[0].files[0]);
                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrFamilyCivilIDInfo/HrFamilyCivilIDInfoInsert",
                            data: form,
                            type: 'POST',
                            processData: false,
                            contentType: false,
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "HrFamilyCivilIDInfo/HrFamilyCivilIDInfo";
                                            $('#mcHrFamilyCivilIDInfoNew').html('');
                                            $('#modal-container-HrFamilyCivilIDInfoNew').modal('hide');
                                            GetAllDataHrFamilyInfo($('#hrbasicid').val())
                                            //GetAllDataHrFamilyCivilIDInfo();
                                        }
                                        else
                                        {
                                            $('#mcHrFamilyCivilIDInfoNew').html('');
                                            $('#modal-container-HrFamilyCivilIDInfoNew').modal('hide');
                                            GetAllDataHrFamilyInfo($('#hrbasicid').val())
                                            //GetAllDataHrFamilyCivilIDInfo();
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
            //}
            //else {
            //    return;
            //}

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



