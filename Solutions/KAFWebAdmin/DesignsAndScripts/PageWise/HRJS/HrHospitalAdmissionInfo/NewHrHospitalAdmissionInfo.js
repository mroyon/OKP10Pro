

//PN: FILE NAME: "Newhr_hospitaladmissioninfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };




    $('body').on('click', '#btnSaveHrHospitalAdmissionInfo', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmHospitalAdmissionInfoNew');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);





            if (form.valid()) {


                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "HrHospitalAdmissionInfoInsert",
                    currenturl: window.location.href,

                    hospitaladmissionid: $('#hospitaladmissionid').val(),
                    hrbasicid: $('#hrbasicid').val(),
                    hospitalname: $('#hospitalname').val(),
                    diseasename: $('#diseasename').val(),
                    hospitaladmissiondate: GetDateFromTextBox($('#new_hospitaladmissiondate').val()),
                    //hospitalreleasedate: GetDateFromTextBox($('#hospitalreleasedate').val()),
                    hospitalcountryid: $('#hospitalcountryid').val(),
                    description: $('#description').val(),
                    releasenote: $('#releasenote').val(),
                    remarks: $('#remarks').val(),

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrHospitalAdmissionInfo/HrHospitalAdmissionInfoInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {

                                        //window.location.href =  baseurl + "HrHospitalAdmissionInfo/HrHospitalAdmissionInfo";
                                        $('#mcHrHospitalAdmissionInfoNew').html('');
                                        $('#modal-container-HrHospitalAdmissionInfoNew').modal('hide');
                                        GetAllDataHrHospitalAdmissionInfo($('#militarynokw').val());

                                        if ((data[0].hospitaladmissionid > 0) && (data[0].hospitalreleasedate == undefined || data[0].hospitalreleasedate == null)) {
                                            $("#btnNewHrHospitalAdmissionInfo").hide();
                                        } else {
                                            $('#btnNewHrHospitalAdmissionInfo').show();
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
            $('#mcHrHospitalAdmissionInfoNew').html('');
            $('#modal-container-HrHospitalAdmissionInfoNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });



});



