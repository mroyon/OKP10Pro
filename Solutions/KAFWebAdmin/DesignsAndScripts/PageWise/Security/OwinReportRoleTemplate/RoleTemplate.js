
var baseurl = $("#txtBaseUrl").val();
$(document).ready(function () {
    //AddAntiForgeryToken = function (data) {
    //    data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
    //    return data;
    //};
    //GetAllReportsWithPermission();

});

function GetAllReportsWithPermission() {

    //console.log("aise");

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    var input = AddAntiForgeryToken({
        token: $(".txtUserSTK").val(),
        userinfo: $(".txtServerUtilObj").val(),
        useripaddress: $(".txtuserip").val(),
        sessionid: $(".txtUserSes").val(),
        methodname: "HrFamilyInfoCreate",
        currenturl: window.location.href,
        reportroleid: $("#reportroleid").val()
    });
    var htm = "";
    var d = "";
    try {

        $.ajax({
            url: baseurl + "OwinReportRoleTemplate/GetAllReportsWithPermission",
            data: input,
            type: 'POST',
            success: function (data) {
                if (data.status === "success") {
                    var res = data.data;
                    //console.log(res);
                    //for (i = 0; i < res.length; i++) {
                    //var rootname = res[i].modulename;
                    var d = "<div class='collapse-group'> " +
                        "<div class='controls'>" +
                        "<label class=''>" + "Report List" + "</label>";


                    //var formlist = res[i].reportlist;
                    t = 1;

                    for (j = 0; j < res.length; j++) {
                        var modulename = res[j].modulename;
                        var reportActionList = res[j].reportlist;


                        d += "<div class='panel panel-default'>" +
                            "<div class='panel-heading' role='tab' id='headingOne'>" +
                            "<h4 class='panel-title'>" +
                            "<a role='button' data-toggle='collapse' href='#collapse" + t + "' aria-expanded='true' aria-controls='collapseOne' class='trigger collapsed col-md-4'>";
                        d += "<label class='reportid' data-val='" + j + "'>" + modulename + "</label>";
                        d += "</a> <p><label><input type='checkbox' id='checkAll' /> Check all</label></p>" +
                            "</h4> " +
                            "</div>";
                        d += " <div id='collapse" + t + "' class='panel-collapse collapse' role='tabpanel' aria-labelledby='headingOne'>" +
                            "<div class='panel-body'><div class='row'>";
                        for (k = 0; k < reportActionList.length; k++) {
                            var reportname = reportActionList[k].reportname;
                            var reportid = reportActionList[k].reportid;

                            var isview = (reportActionList[k].ex_bigint1) ? "checked" : "";
                            //console.log(isview);

                            d += "<div class='col-md-4'><label><input type='checkbox' class='reportid' value='" + reportid + "'   " + isview + " >" + reportname + "</label></div>";
                        }
                        d += "</div></div></div></div>";
                        //}

                        t++;
                    }
                    d += "</div></div>";
                    $('.divMenu').append(d);
                }
            },
            error: function (er) {
                //console.log(er);
            }
        });


    } catch (e) {
        $("#divjobapply_loader").hide();
        //alert("WPCMS_CurrentActivityDetails.js: " + e.message)
    }
}

$('body').on('click', '#btnsearch', function (event) {
    try {
        event.preventDefault();
        $('.divMenu').html('');
        var ddlrole = $('#reportroleid').val();
        if (ddlrole == "" || ddlrole == null) {
            $('#ddlroleVal').prop("visible", true);
            $('#ddlroleVal').text(_getCookieForLanguage("usercreateRoleVal"));
            $('#reportroleid').css('border-color', 'red');
            return;
        }
        else {
            $('#reportroleid').css('border-color', '');
            $('#ddlroleVal').prop("visible", false);
            $('#ddlroleVal').text('');
        }


        GetAllReportsWithPermission();

    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
});


$('body').on('click', '#btnRolePerSave', function (event) {
    event.preventDefault();
    var ddlrole = $('#reportroleid').val();
    if (ddlrole == "" || ddlrole == null) {
        $('#ddlroleVal').prop("visible", true);
        $('#ddlroleVal').text(_getCookieForLanguage("usercreateRoleVal"));
        $('#reportroleid').css('border-color', 'red');
        return;
    }
    else {
        $('#reportroleid').css('border-color', '');
        $('#ddlroleVal').prop("visible", false);
        $('#ddlroleVal').text('');
    }
    //var form = $('#roleForm');
    //jQuery.validator.unobtrusive.parse();
    //jQuery.validator.unobtrusive.parse(form);

    try {
        //if (form.valid()) {
            var buttontxt = $("#btnRolePerSave").val();
            var rolewithpermission = [];
            var actionlistArray = [];
            var listreportid = "";
            $("div[class*='collapse-group']").each(function () {
                $(this).find("div[class*='panel-default']").each(function () {
                    var formid = $(this).find(".reportid").attr("data-val");

                    $(this).find('input.reportid[type="checkbox"]:checked').each(function (index) {
                        var actionid = $(this).val();
                        listreportid += actionid + ",";
                        // actionlistArray.push(parseInt(actionid));
                    });
                });
            });

            var input = AddAntiForgeryToken({
                token: $(".txtUserSTK").val(),
                userinfo: $(".txtServerUtilObj").val(),
                useripaddress: $(".txtuserip").val(),
                sessionid: $(".txtUserSes").val(),
                methodname: "HrFamilyInfoCreate",
                currenturl: window.location.href,
                reportroleid: $("#reportroleid").val(),
                ex_nvarchar1: listreportid.substring(0, listreportid.length - 1)
            });
            confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                if (answer == "true") {
                    $.ajax({
                        url: baseurl + "OwinReportRoleTemplate/SetReportRolePermission",
                        data: input,
                        type: 'POST',
                        success: function (data) {
                            if (data.status === "success") {
                                location.reload();
                            }
                        },
                        error: function (er) {
                            //console.log(er);
                        }
                    });
                }
            });
        //}
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
});


$('body').on('change', '#checkAll', function (event) {
    if ($(this).is(':checked')) {
        //var t = $(this).parent().parent().parent().parent().parent();
        $(this).parent().parent().parent().parent().parent().find('input[type="checkbox"]').each(function () {
            $(this).prop('checked', true);
        });
    }
    else {
        $(this).parent().parent().parent().parent().parent().find('input[type="checkbox"]').each(function () {
            $(this).prop('checked', false);
        });
    }
});