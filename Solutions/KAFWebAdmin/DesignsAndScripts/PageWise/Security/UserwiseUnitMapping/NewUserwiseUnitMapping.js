

//PN: FILE NAME: "Newgen_acrgrade.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    $('body').on('change', '#masteruserid', function (event) {
        GetRoleByUser();
    });

    //$('body').on('change', '#entitykey', function (event) {
    //    $('input[name="allunit"]').prop('checked', false).prop("disabled", true);
    //});

    $('body').on('click', '#btnSaveUserwiseUnitMapping', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmUserwiseUnitMappingNew');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {

               
                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "UserwiseUnitMappingInsert",
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
                            url: baseurl + "UserwiseUnitMapping/UserwiseUnitMappingInsert",
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
                                           //window.location.href =  baseurl + "GenBranch/GenBranch";
                                            $('#mcUserwiseUnitMappingNew').html('');
                                            $('#modal-container-UserwiseUnitMappingNew').modal('hide');
                                            GetAllDataUserUnitMapping();
                                        }
                                        else
                                        {
                                            $('#mcUserwiseUnitMappingNew').html('');
                                            $('#modal-container-UserwiseUnitMappingNew').modal('hide');
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
    
    
    
    $('body').on('click', '#btnModalCloseNew', function (event) {
        try {
            event.preventDefault();
            $('#mcUserwiseUnitMappingNew').html('');
            $('#modal-container-UserwiseUnitMappingNew').modal('hide');
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
    
    $('body').on('change', '#allunit', function (event) {

        if ($(this).is(':checked')) {
            $('input[name="allchild"]').prop('checked', false).prop("disabled", true);
            $('input[name="isunitadmin"]').prop('checked', false).prop("disabled", true);
            $('#entitykey').prop("disabled", true);
        }
        else {
            $('input[name="allchild"]').prop('disabled', false);
            $('input[name="isunitadmin"]').prop('disabled', false);
            $('#entitykey').prop("disabled", false);
        }
    });
});


function GetRoleByUser() {
    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };
    var input = AddAntiForgeryToken({
        token: 'uGif4d7lgjD11QVz8IhNKYTzXhBOyzFlicZQ9uIKxKnZ1hTra84eyw==',
        userinfo: $(".txtServerUtilObj").val(),
        useripaddress: $(".txtuserip").val(),
        sessionid: $(".txtUserSes").val(),
        methodname: "GetAllMenuWiseFormAndAction",
        currenturl: window.location.href,
        masteruserid: $("#masteruserid").val()
    });

    try {
        $.ajax({
            url: $("#txtBaseUrl").val() + "/UserwiseUnitMapping/GetRoleByUser",
            data: input,
            type: 'POST',
            success: function (data) {
                if (data.status === "success") {
                    var res = data.data;
                    $('#rolename').val(res[0].comText).prop("disabled", true);
                }
            },
            error: function (er) {
                window.location.href = er.responseJSON.redirectUrl;
            }
        });
    } catch (e) {
    }
}