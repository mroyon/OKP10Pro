

//PN: FILE NAME: "Newgen_okpco.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    $('body').on('click', '#btnLandingSearch', function (event) {
        try {
            
            if ($.trim($("#hr_svcinfo_militarynokw").val()) == '') {
                isValid = false;

                $('#hr_svcinfo_militarynokw').each(function () {
                    $(this).css({
                        "border": "1px solid red"
                    });
                });

                $.alert({
                    title: _getCookieForLanguage("_informationTitle"),
                    content: "Please enter Military No (KW).",
                    type: 'red'
                });
                return;
            }
            else {
                isValid = true;
                $('#hr_svcinfo_militarynokw').each(function () {
                    $(this).css({
                        "border": ""
                    });
                });

                $('#hr_svcinfo_militarynokw').attr('disabled', 'disabled');
                $('.btnClearLandingSearch').show();

                GetDataHrBasicProfile();                
            }
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });   
    function GetDataHrBasicProfile() {
        try {
            AddAntiForgeryToken = function (data) {
                data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
                return data;
            };

            var input = AddAntiForgeryToken({
                token: $(".txtUserSTK").val(),
                userinfo: $(".txtServerUtilObj").val(),
                useripaddress: $(".txtuserip").val(),
                sessionid: $(".txtUserSes").val(),
                methodname: "HrPersonalInfoTableData",
                currenturl: window.location.href,
                militarynokw: $('#hr_svcinfo_militarynokw').val()
            });
            $.ajax({
                url: baseurl + "HrPersonalInfo/GetAllHrBasicProfileData?militaryno=" + $('#hr_svcinfo_militarynokw').val(),
                type: 'POST',
                data: null,
                success: function (response) {
                    var data = response.data;
                    if (data != "") {
                        $('#hr_svcinfo_militarynobd').val(data[0].militarynobd);
                        $('#hr_svcinfo_civilid').val(data[0].civilid);
                        $('#hr_svcinfo_passportno').val(data[0].passportno);
                        $('#hr_svcinfo_fullname').val(data[0].fullname);
                        $('#hrbasicid').val(data[0].hrbasicid);
                    }
                    else {
                        $.alert({
                            title: _getCookieForLanguage("_informationTitle"),
                            content: "Data not found",
                            type: 'red'
                        });
                    }
                }
            });
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e,
                type: 'red'
            });
        }
    }
    $('body').on('click', '#btnClearLandingSearch', function (event) {
        $('#hr_svcinfo_militarynokw').val('');
        $('#hr_svcinfo_militarynobd').val('');
        $('#hr_svcinfo_civilid').val('');
        $('#hr_svcinfo_passportno').val('');
        $('#hr_svcinfo_fullname').val('');
        $('#HrPassportInfoDt').empty();
        $('#hr_svcinfo_militarynokw').prop('disabled', false);
        $('.btnClearLandingSearch').hide();
    });
    $('body').on('click', '#btnSaveGenOkpCo', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmGen_OkpCoNew');
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

					okpcoid: $('#okpcoid').val(),
					okpid: $('#okpid').val(),
                    hrbasicid: $('#hrbasicid').val(),
					fromdate: GetDateFromTextBox($('#fromdate').val()),
					todate: GetDateFromTextBox($('#todate').val()),
					iscurrent: $('#iscurrent').val(),
					remarks: $('#remarks').val(),

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "GenOkpCo/GenOkpCoInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "GenOkpCo/GenOkpCo";
                                            $('#mcGenOkpCoNew').html('');
                                            $('#modal-container-GenOkpCoNew').modal('hide');
                                            GetAllDataGenOkpCo();
                                        }
                                        else
                                        {
                                            $('#mcGenOkpCoNew').html('');
                                            $('#modal-container-GenOkpCoNew').modal('hide');
                                            GetAllDataGenOkpCo();
                                        }
                                    });
                                }

                                else {
                                    $.alert({
                                        title: _getCookieForLanguage("_informationTitle"),
                                        content: "Data already exists",
                                        type: 'red'
                                    });
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
            $('#mcGenOkpCoNew').html('');
            $('#modal-container-GenOkpCoNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
  

});



