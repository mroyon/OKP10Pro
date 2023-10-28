

//PN: FILE NAME: "Edithr_svcinfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    $('body').on('click', '#btnUpdateHrSvcInfo', function (event) {
        try {
            event.preventDefault();

            var form = $('#frmHr_SvcInfoEdit');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);



            //Validation :: End

            if (form.valid()) {

                //Validatio :: Start
                var dob = new Date(GetDateFromTextBox($('#dateofbirth').val()));
                var today = new Date();
                today = today.setDate(today.getDate() + 1);
                var age = Math.floor((today - dob) / (365.25 * 24 * 60 * 60 * 1000));
                if (age < 18) {
                    $('#dateofbirth').css("border", "1px solid red");
                    $.alert({
                        title: _getCookieForLanguage("_informationTitle"),
                        content: "Current age must be equal or greater than 18",
                        type: 'red'
                    });
                    return false;
                }

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "HrFamilyInfoCreate",
                    currenturl: window.location.href,

                    hrsvcid: $('#hrsvcid').val(),
                    hrbasicid: $('#hrbasicid').val(),
                    //passportno: $('#passportno').val(),
                    //joindatekw: GetDateFromTextBox($('#joindatekw').val()),
                    //expectedretiredatekw: GetDateFromTextBox($('#expectedretiredatekw').val()),
                    //userid: $('#userid').val(),
                    //entitykey: $('#entitykey').val(),
                    //armsid: $('#armsid').val(),
                    //okpid: $('#okpid').val(),
                    //rankidkw: $('#rankidkw').val(),
                    //rankidbd: $('#rankidbd').val(),
                    //tradeidbd: $('#tradeidbd').val(),
                    //tradeidkw: $('#tradeidkw').val(),
                    //groupid: $('#groupid').val(),
                    //status: $('#status').val(),
                    //remarks: $('#remarks').val(),
                    //Basic Profile Start
                    militarynokw: $('.militarynokw').val(),
                    militarynobd: $('.militarynobd').val(),
                    civilid: $('.civilid').val(),
                    name1: $('#name1').val(),
                    name2: $('#name2').val(),
                    name3: $('#name3').val(),
                    fullname: $('.fullname').val(),
                    dateofbirth: GetDateFromTextBox($('#dateofbirth').val()),
                    //joindatebd: GetDateFromTextBox($('#joindatebd').val()),
                    // End

                    passportno: $('.passportno').val(),
                    joindatekw: GetDateFromTextBox($('#joindatekw').val()),
                    expectedretiredatekw: GetDateFromTextBox($('#expectedretiredatekw').val()),
                    //userid: $('#userid').val(),
                    organizationkey: $('#organizationkey').val(),
                    entitykey: $('#entitykey').val(),
                    armsid: $('#armsid').val(),
                    okpid: $('#okpid').val(),
                    rankidkw: $('#rankidkw').val(),
                    rankidbd: $('#rankidbd').val(),
                    tradeidbd: $('#tradeidbd').val(),
                    tradeidkw: $('#tradeidkw').val(),
                    groupid: $('#groupid').val(),
                    status: ($('#status').val() == 5 ? 3 : $('#status').val()),

                    subunitid: $('#subunitid').val(),
                    campid: $('#campid').val(),
                    //remarks: $('#remarks').val(),
                    profilephotofilepath: $("#imgprofile").attr("src"),
                    godate: GetDateFromTextBox($('#godate').val()),
                    goexpdate: GetDateFromTextBox($('#goexpdate').val()),
                    civilidexpiredate: GetDateFromTextBox($('#civilidexpiredate').val()),
                    goletterno: $('#goletterno').val()
                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrSvcInfo/HrSvcInfoUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            window.location.href = baseurl + "HrSvcInfo/HrSvcInfo";
                                            $('#mcHrSvcInfoEdit').html('');
                                            $('#modal-container-HrSvcInfoEdit').modal('hide');
                                            //GetAllDataHrSvcInfo();
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
            $('#mcHrSvcInfoEdit').html('');
            $('#modal-container-HrSvcInfoEdit').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });


});






