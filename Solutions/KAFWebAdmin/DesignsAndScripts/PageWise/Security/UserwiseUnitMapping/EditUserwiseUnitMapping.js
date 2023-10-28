

//PN: FILE NAME: "Newgen_Branch.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    $('body').on('change', '#masteruserid', function (event) {
        GetRoleByUser();
    });

    $('body').on('click', '#btnUpdateUserwiseUnitMapping', function (event) {
        try {
            event.preventDefault();

            var form = $('#frmUserwiseUnitMappingEdit');
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
                    
                    userroledetentitymaplid: $('#userroledetentitymaplid').val(),
                    userroledetlid: $('#userroledetlid').val(),
                    userroleid: $('#userroleid').val(),
                    userid: $('#userid').val(),
                    masteruserid: $('#masteruserid').val(),
                    roleid: $('#roleid').val(),
                    entitykey: $('#entitykey').val(),
                    allchild: $('#allchild').is(':checked') ? true : false,
                    isunitadmin: $('#isunitadmin').is(':checked') ? true : false,
                    allunit: $('#allunit').is(':checked') ? true : false,
                    allprofile: $('#allprofile').is(':checked') ? true : false,
                    profiletypeid: $('#profiletypeid').val(),
                    remarks: $('#remarks').val()

                });

                var actionlistArray = [];
                //$(this).find('input.actionid[type="checkbox"]:checked').each(function (index) {
                //    var actionid = $(this).val();
                //    actionlistArray.push(parseInt(actionid));
                //});

                actionlistArray = $('input[name="allProfile"]:checked').map(function () {
                    return $(this).val();
                }).get().join(",");

                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "UserwiseUnitMapping/UserwiseUnitMappingUpdate",
                            data: {
                                input: input,
                                listFromAction: JSON.stringify(actionlistArray),
                                __RequestVerificationToken: $('input[name=__RequestVerificationToken]').val()
                            },
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            $('#mcUserwiseUnitMappingEdit').html('');
                                            $('#modal-container-UserwiseUnitMappingEdit').modal('hide');
                                            GetAllDataUserUnitMapping();
                                        }

                                    });

                                }

                                else {
                                    $.alert({
                                        title: _getCookieForLanguage("_informationTitle"),
                                        content: data.responsetext,
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

    $('body').on('change', '#allprofile', function (event) {
        if ($(this).is(':checked')) {
            //var t = $(this).parent().parent().parent().parent().parent();
            $(this).parent().parent().parent().parent().parent().find('input[name="allProfile"]').each(function () {
                $(this).prop('checked', true);
            })
        }
        else {
            $(this).parent().parent().parent().parent().parent().find('input[name="allProfile"]').each(function () {
                $(this).prop('checked', false);
            })
        }
    });

    $('body').on('click', '#btnModalCloseEdit', function (event) {
        try {
            event.preventDefault();
            $('#mcUserwiseUnitMappingEdit').html('');
            $('#modal-container-UserwiseUnitMappingEdit').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
    
    
});





