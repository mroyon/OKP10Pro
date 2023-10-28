$(document).ready(function () {
    var baseurl = $('#txtBaseUrl').val();

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };
    GetAllMenuWiseFormAndAction();

});

function GetAllMenuWiseFormAndAction() {
    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };
    var input = AddAntiForgeryToken({
        token: 'uGif4d7lgjD11QVz8IhNKYTzXhBOyzFlicZQ9uIKxKnZ1hTra84eyw==',// $(".txtUserSTK").val(),
        userinfo: $(".txtServerUtilObj").val(),
        useripaddress: $(".txtuserip").val(),
        sessionid: $(".txtUserSes").val(),
        methodname: "GetAllMenuWiseFormAndAction",
        currenturl: window.location.href,
        roleid: $("#ddl_role").val()
    });
    var htm = "";

    try {
        //event.preventDefault();
        $.ajax({
            url: $("#txtBaseUrl").val() + "/RolePermissionManagement/GetAllMenuWiseFormAndAction",
            data: input,
            type: 'POST',
            success: function (data) {
                if (data.status === "success") {

                    var res = data.data;

                    //var d = "";
                    var root = 0;
                    for (i = 0; i < res.length; i++) {
                        var rootname = res[i].formname;
                        var d = "<div class='collapse-group'> " +
                            "<div class='controls'>" +
                            "<a role='button' data-toggle='collapse' href='#root" + root + "' aria-expanded='true' aria-controls='collapseOne' class='root collapsed'>" +
                            "<label id='' class='h4'>" + rootname + "</label>" +
                            "</a>" +
                            "</div>";
                        d += "<div class='collapse-group collapse' id='root" + root++ + "'> ";

                        var formlist = res[i].formList;
                        for (j = 0; j < formlist.length; j++) {
                            var formname = formlist[j].formname;
                            var formid = formlist[j].appformid;
                            d += "<div class='panel panel-default'>" +
                                "<div class='panel-heading' role='tab' id='headingOne'>" +
                                "<h4 class='panel-title'>" +
                                "<a role='button' data-toggle='collapse' href='#collapse" + formid + "' aria-expanded='true' aria-controls='collapseOne' class='trigger collapsed col-md-4'>";
                            d += "<label class='formid' data-val='" + formid + "'>" + formname + "</label>";
                            d += "</a> <p><label><input type='checkbox' id='checkAll' /> Check all</label></p>" +
                                "</h4> " +
                                "</div>";
                            d += " <div id='collapse" + formid + "' class='panel-collapse collapse' role='tabpanel' aria-labelledby='headingOne'>" +
                                "<div class='panel-body'><div class='row'>";
                            var formActionList = formlist[j].formActionList;
                            for (k = 0; k < formActionList.length; k++) {
                                var actionname = formActionList[k].action;
                                var actionid = formActionList[k].formactionid;
                                //var rolepremissionid = formActionList[k].rolepremissionid;
                                //var view = (formActionList[k].isview);

                                var isview = (formActionList[k].isview) ? "checked" : "";
                                d += "<div class='col-md-4'><label><input type='checkbox' class='actionid' value='" + actionid + "'   " + isview + " >" + actionname + "</label></div>";
                            }
                            d += "</div></div></div></div>";
                        }
                        d += "</div></div>";
                        $('.divMenu').append(d);
                    }

                }
            },
            error: function (er) {

                window.location.href = er.responseJSON.redirectUrl;
            }
        });
    } catch (e) {
        $("#divjobapply_loader").hide();
        //alert("WPCMS_CurrentActivityDetails.js: " + e.message)
    }
}




$('body').on('click', '#btnRolePerSave', function (event) {
    event.preventDefault();
    var ddlrole = $('#ddl_role').val();
    if (ddlrole == "" || ddlrole == null) {
        $('#ddlroleVal').prop("visible", true);
        $('#ddlroleVal').text(_getCookieForLanguage("usercreateRoleVal"));
        $('#ddl_role').css('border-color', 'red');
        return;
    }
    else {
        $('#ddl_role').css('border-color', '');
    }
    //var form = $('#roleForm');
    //jQuery.validator.unobtrusive.parse();
    //jQuery.validator.unobtrusive.parse(form);

    try {
        var buttontxt = $("#btnRolePerSave").val();
        var rolewithpermission = [];
        var actionlistArray = [];
        $("div[class*='collapse-group']").each(function () {
            $(this).find("div[class*='panel-default']").each(function () {
                var formid = $(this).find(".formid").attr("data-val");

                $(this).find('input.actionid[type="checkbox"]:checked').each(function (index) {
                    var actionid = $(this).val();
                    //var rolepremissionid = $(this).attr("data-rolepermissionid");
                    //var status = $(this).is(':checked') ? "True" : "False";

                    //Objrolepermission = {
                    //    rolepremissionid: rolepremissionid,
                    //    roleid: $('#ddl_role').val(),
                    //    appformid: formid,
                    //    formactionid: actionid,
                    //    status: status
                    //};
                    //rolewithpermission.push(Objrolepermission);
                    actionlistArray.push(parseInt(actionid));
                });
            });
        });
        //var input = AddAntiForgeryToken(
        var input = {
            token: $(".txtUserSTK").val(),
            userinfo: $(".txtServerUtilObj").val(),
            useripaddress: $(".txtuserip").val(),
            sessionid: $(".txtUserSes").val(),
            methodname: "AssignPermission",
            currenturl: window.location.href,
            roleid: $('#ddl_role').val()
        }
        //);
        var Objrolepermission = "";
        //Objrolepermission = actionlistArray.map(actionlistArray, function (n, i) {
        //    return (n + i);
        //})
        //Objrolepermission = actionlistArray.toArray().reverse()




        confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
            if (answer == "true") {
                $.ajax({
                    url: $("#txtBaseUrl").val() + "/RolePermissionManagement/AssignPermission",
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
                                    window.location.href = data.redirectUrl;
                                }
                            });
                        }
                    },
                    failure: function (response) {
                        alert(response.responseText);
                    },
                    error: function (response) {
                        alert(response.responseText);
                    }
                });
            }
        });
    } catch (e) {
    }
});

//$('body').on('click', '.open-button', function (event) {
//    event.preventDefault();
//    $(this).closest('.collapse-group').find('.collapse').collapse('show');
//});

//$('body').on('click', '.close-button', function (event) {
//    $(this).closest('.collapse-group').find('.collapse').collapse('hide');
//});

$('body').on('change', '#ddl_role', function (event) {

    var ddlrole = $(this).val();
    if (ddlrole == "" || ddlrole == null) {
        $('#ddlroleVal').prop("visible", true);
        $('#ddlroleVal').text(_getCookieForLanguage("usercreateRoleVal"));
        $('#ddl_role').css('border-color', 'red');
        return;
    }
    else {
        $('#ddl_role').css('border-color', '');
        $('#ddlroleVal').text("");
        $('#ddlroleVal').prop("visible", false);
    }
    $('.divMenu').html('')
    GetAllMenuWiseFormAndAction();
});

$('body').on('change', '#checkAll', function (event) {
    if ($(this).is(':checked')) {
        //var t = $(this).parent().parent().parent().parent().parent();
        $(this).parent().parent().parent().parent().parent().find('input[type="checkbox"]').each(function () {
            $(this).prop('checked', true);
        })
    }
    else {
        $(this).parent().parent().parent().parent().parent().find('input[type="checkbox"]').each(function () {
            $(this).prop('checked', false);
        })

    }
});