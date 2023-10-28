

//PN: FILE NAME: "Newhr_hospitaladmissioninfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };



    $('body').on('click', '#btnUpdateHrHospitalAdmissionInfo', function (event) {
        try {
            event.preventDefault();

            var form = $('#frmHospitalAdmissionInfoEdit');
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

                    hospitaladmissionid: $('#hddhospitaladmissionid').val(),
                    hrbasicid: $('#hrbasicid').val(),
                    hospitalname: $('#hospitalname').val(),
                    diseasename: $('#diseasename').val(),
                    hospitaladmissiondate: GetDateFromTextBox($('#modal_hospitaladmissiondate').val()),
                    hospitalreleasedate: GetDateFromTextBox($('#modal_hospitalreleasedate').val()),
                    hospitalcountryid: $('#hospitalcountryid').val(),
                    description: $('#description').val(),
                    releasenote: $('#releasenote').val(),
                    remarks: $('#remarks').val(),
                    strModelPrimaryKey: $('#strModelPrimaryKey').val()

                });
                console.log(input);
                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrHospitalAdmissionInfo/HrHospitalAdmissionInfoUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {

                                        //window.location.href =  baseurl + "HrHospitalAdmissionInfo/HrHospitalAdmissionInfo";
                                        $('#mcHrHospitalAdmissionInfoEdit').html('');
                                        $('#modal-container-HrHospitalAdmissionInfoEdit').modal('hide');
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

    $('body').on('click', '#btnModalCloseEdit', function (event) {
        try {
            event.preventDefault();
            $('#mcHrHospitalAdmissionInfoEdit').html('');
            $('#modal-container-HrHospitalAdmissionInfoEdit').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });


});






