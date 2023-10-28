

//PN: FILE NAME: "Newcnf_rankpayconfig.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };




    $('body').on('click', '#btnSaveCnfRankPayConfig', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmRankPayConfigNew');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            var countentry = 1;
            $.each($("#CnfRankGroupDt tbody tr"), function (val, element) {

                $(element).find(".txtamount").css("border-color", "#d2d6de");

                if ($(element).find(".txtamount").val().trim() == "") {
                    $(element).find(".txtamount").css("border-color", "red");
                    countentry = 0;
                    return;
                }
            })

            if (countentry == 0) {
                $.alert({
                    title: _getCookieForLanguage("_informationTitle"),
                    content: "Please provide all the fields",
                    type: 'red'
                });
            }

            if (form.valid()) {

                var list = [];
                $.each($("#CnfRankGroupDt tbody tr"), function (val, element)
                {
                    var objsingle = AddAntiForgeryToken({
                        token: $(".txtUserSTK").val(),
                        userinfo: $(".txtServerUtilObj").val(),
                        useripaddress: $(".txtuserip").val(),
                        sessionid: $(".txtUserSes").val(),
                        methodname: "HrFamilyInfoCreate",
                        currenturl: window.location.href,

                        payallceid: $("#payallceid").val(),
                        rankid: $(element).find(".txtamount").attr('rankid'),
                        groupid: $("#groupid").val(), 
                        ex_decimal1: $(element).find(".txtamount").val()
                    });
                    list.push(objsingle);
                    //console.log($(element).find(".txtamount").val());
                })

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "HrFamilyInfoCreate",
                    currenturl: window.location.href,

                    
                    groupid: $('#groupid').val(),
                    payallceid: $("#payallceid").val(),
                    RankByGroupList: list

                   

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "CnfRankPayConfig/CnfRankPayConfigInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            //window.location.href =  baseurl + "CnfRankPayConfig/CnfRankPayConfig";
                                            $('#mcCnfRankPayConfigNew').html('');
                                            $('#modal-container-CnfRankPayConfigNew').modal('hide');
                                            GetAllDataCnfRankPayConfig();
                                        }
                                        else {
                                            $('#mcCnfRankPayConfigNew').html('');
                                            $('#modal-container-CnfRankPayConfigNew').modal('hide');
                                            GetAllDataCnfRankPayConfig();
                                        }
                                    });
                                }

                                else {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            
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



    $('body').on('click', '#btnModalCloseNew', function (event) {
        try {
            event.preventDefault();
            $('#mcCnfRankPayConfigNew').html('');
            $('#modal-container-CnfRankPayConfigNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });



});



