

//PN: FILE NAME: "Newreg_basicinfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };




    $('body').on('click', '#btnSaveRegBasicInfo', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmReg_BasicInfoNew');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            var kaffileUploader = $('#id').kaffileUploader();
            var fileobjects_tbl_filedescription = $('#id').kaffileUploader.GetFilesForActions('BasicInfoID');
            var fileobjects = fileobjects_tbl_filedescription;

            if (form.valid()) {

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "HrFamilyInfoCreate",
                    currenturl: window.location.href,

                    basicinfoid: $('#basicinfoid').val(),
                    civilid: $('#civilid').val(),
                    passportno: $('#passportno').val(),
                    fullname: $('#fullname').val(),
                    name1: $('#name1').val(),
                    name2: $('#name2').val(),
                    name3: $('#name3').val(),
                    name4: $('#name4').val(),
                    name5: $('#name5').val(),
                    dob: GetDateFromTextBox($('#dob').val()),
                    joindate: GetDateFromTextBox($('#joindate').val()),
                    mob1: $('#mob1').val(),
                    mob2: $('#mob2').val(),
                    email: $('#email').val(),
                    studentid: $('#studentid').val(),
                    studentcode: $('#studentcode').val(),

                    filepath: $('#id').kaffileUploader.GetFilesForActions('BasicInfoID').length > 0 ? $('#id').kaffileUploader.GetFilesForActions('BasicInfoID')[0].filepath : '',
                    filename: $('#id').kaffileUploader.GetFilesForActions('BasicInfoID').length > 0 ? $('#id').kaffileUploader.GetFilesForActions('BasicInfoID')[0].filename : '',
                    filetype: $('#id').kaffileUploader.GetFilesForActions('BasicInfoID').length > 0 ? $('#id').kaffileUploader.GetFilesForActions('BasicInfoID')[0].filetype : '',
                    extension: $('#id').kaffileUploader.GetFilesForActions('BasicInfoID').length > 0 ? $('#id').kaffileUploader.GetFilesForActions('BasicInfoID')[0].extension : '',

                    batchid: $('#batchid').val(),
                    platoonid: $('#platoonid').val(),
                    armsid: $('#armsid').val(),
                    isgraduated: $('#isgraduated').val(),
                    graduationdate: GetDateFromTextBox($('#graduationdate').val()),
                    filedescription: $('#filedescription').val(),
                    filepath1: $('#filepath1').val(),
                    filename1: $('#filename1').val(),
                    filetype1: $('#filetype1').val(),
                    extension1: $('#extension1').val()

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "RegBasicInfo/RegBasicInfoInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            //window.location.href =  baseurl + "RegBasicInfo/RegBasicInfo";
                                            $('#mcRegBasicInfoNew').html('');
                                            $('#modal-container-RegBasicInfoNew').modal('hide');
                                            GetAllDataRegBasicInfo();
                                        }
                                        else {
                                            $('#mcRegBasicInfoNew').html('');
                                            $('#modal-container-RegBasicInfoNew').modal('hide');
                                            GetAllDataRegBasicInfo();
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
            $('#mcRegBasicInfoNew').html('');
            $('#modal-container-RegBasicInfoNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });



});



