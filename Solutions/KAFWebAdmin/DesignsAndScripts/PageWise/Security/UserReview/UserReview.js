var baseurl = $('#txtBaseUrl').val();
var rev = '';
$(document).ready(function () {
    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };
});

$('body').on('click', '#btnSearch', function (event) {
    event.preventDefault();

    try {
        event.preventDefault();
        var form = $('#userReviewForm');
        jQuery.validator.unobtrusive.parse();
        jQuery.validator.unobtrusive.parse(form);

        if (form.valid()) {
            LoadUserTableByName();
        }
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
});

function LoadUserTableByName() {
    try {
        var input = AddAntiForgeryToken({
            token: $(".txtUserSTK").val(),
            userinfo: $(".txtServerUtilObj").val(),
            useripaddress: $(".txtuserip").val(),
            sessionid: $(".txtUserSes").val(),
            methodname: "GetUser",
            currenturl: window.location.href,
            username: $('#txtUsername').val(),
            password: $('#ddlIsReviewed option:selected').val()//isreviewed
        });

        var dataFoun = false;
        var dt = '';

        rev = $('#reviewTable').DataTable(
            {
                "bDestroy": true,
                "columnDefs": [{
                    "targets": 0,
                    "searchable": true,
                    "orderable": true,
                }
                ],
                "language":
                    {
                        "processing": "<div class='overlay custom-loader-background'><i class='fa fa-cog fa-spin custom-loader-color'></i></div>"
                    },
                "processing": true,
                "serverSide": true,
                "autoWidth": false,
                "responsive": true,
                "paginate": false,
                "ajax":
                    {
                        "url": baseurl + "UserReview/LoadUserDataTable"
                        , "type": "POST"
                        , "data": input
                        , "dataSrc": function (json) {
                            if (json.data.length <= 0) {
                                var table = $('#reviewTable').DataTable();

                            }
                            if (json.data.length > 0) {

                                var divtext = "";
                                $("#list-panelButtons").empty();
                                divtext += "<div class='panel-footer text-center'>"
                                divtext += "<div class='btn-group text-center'>"
                                divtext += "<div class='btn-group'>"
                                divtext += json.data[0].ex_nvarchar1
                                divtext += "</div>"
                                divtext += "<div class='btn-group'>"
                                divtext += json.data[0].ex_nvarchar2
                                divtext += "</div>"
                                divtext += "</div>"
                                divtext += "</div>"
                                $("#list-panelButtons").append(divtext);
                            }
                            return json.data;
                        }
                    },
                error: function (jqXHR, textStatus, errorThrown) {
                    $.alert({
                        title: _getCookieForLanguage("_informationTitle"),
                        content: jqXHR.responseJSON.Error,
                        type: 'red'
                    });
                },
                "columns": [
                    {
                        "data": "username", "searchable": true, "sortable": true, "orderable": true,
                        "render": function (data, type, full, meta) {
                            var userid = full.username;
                            return userid;
                        }
                    },
                    {
                        "data": "emailaddress", "searchable": true, "sortable": true, "orderable": true,
                        "render": function (data, type, full, meta) {
                            var userid = full.emailaddress + "<br/>" + full.mobilenumber;
                            return userid;
                        }
                    }, {
                        "data": "locked", "searchable": false, "sortable": false, "orderable": false,
                        "render": function (data, type, full, meta) {
                            var userid = full.locked + "<br/>" + full.approved;
                            return userid;
                        }
                    },
                    //{ "data": "emailaddress", "searchable": false, "sortable": true, "orderable": true },
                    //{ "data": "mobilenumber", "searchable": false, "sortable": true, "orderable": true },
                    //{ "data": "locked", "searchable": false, "sortable": true, "orderable": true },
                    //{ "data": "approved", "searchable": false, "sortable": true, "orderable": true },
                    {
                        "sortable": false,
                        "orderable": false,
                        "data": "isreviewed",
                        "render": function (data, type, full, meta) {
                            var chkbox = '<input type="checkbox" name="isreviewed"  value="' + $('<div/>').text(data).html() + '">';
                            if (full.isreviewed)
                                chkbox = '<input type="checkbox" name="isreviewed" checked value="' + $('<div/>').text(data).html() + '">';

                            var Comment = '<br/>' + '<input id="comment" class="form-control" name="comment"   value="" type="text">' +
                                '<input id="userid" name="userid" type="hidden" value="' + full.userid + '" />' + '<input id="masteruserid" name="masteruserid" type="hidden" value="' + full.masteruserid + '" />';
                            return chkbox + Comment;
                        }
                    },
                    {
                        "data": "revieweddate", "searchable": false, "sortable": false, "orderable": false,
                        "render": function (data, type, full, meta) {
                            var userid = full.revieweddate + "<br/>" + full.reviewedbyusername;
                            return userid;
                        }
                    }

                    //{ "data": "revieweddate", "searchable": false, "sortable": true, "orderable": true },
                    //{ "data": "reviewedbyusername", "searchable": false, "sortable": true, "orderable": true },
                    //{

                    //    "data": "comment",
                    //    "render": function (data, type, full, meta) {
                    //        var Comment = '<input id="comment" class="form-control" name="comment"   value="" type="text">';
                    //        return Comment;
                    //    }
                    //}
                ]
            });

    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
}

$('#check_all').on('click', function (e) {
    try {
        if (rev != "") {
            var rows = rev.rows({ 'search': 'applied' }).nodes();
            $('input[type="checkbox"]', rows).prop('checked', this.checked);
            $(this).prop('checked', this.checked);
        }
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
});

function clearAllForms() {
    try {
        $('#txtUsername').val('');
        var table = $('#reviewTable').DataTable();
        //table.destroy();
        table.clear().draw();
        $('#reviewTable').empty();
        $("#list-panelButtons").empty();

    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
}

$('body').on('click', '#btnProcessCancel', function (event) {
    event.preventDefault();

    try {
        confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_cancelConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
            if (answer == "true") {
                clearAllForms();
            }
        });

    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
});

$('body').on('click', '#btnProcess', function (event) {
    event.preventDefault();

    var flg = true;
    var jsonObj = [];
    //var viewport = navigator.userAgent.toLowerCase();
    //alert(viewport);
    if (navigator.userAgent.match(/Android/i) || navigator.userAgent.match(/webOS/i) || navigator.userAgent.match(/iPhone/i) || navigator.userAgent.match(/iPad/i)
        || navigator.userAgent.match(/iPod/i) || navigator.userAgent.match(/BlackBerry/i) || navigator.userAgent.match(/Windows Phone/i)) {

        $('#reviewTable input[type="checkbox"]').each(function () {
            //$('#reviewTable').DataTable().$('input[type="checkbox"]').each(function () {

            var masteruserid = $(this).closest('tr').find("#masteruserid").val();
            var userid = $(this).closest('tr').find("#userid").val();
            var comment = $(this).closest('tr').find("#comment").val();

            //var userid = $(this).parent().siblings().find("#userid").val();
            //var comment = $(this).next().closest("tr").find("#comment").val();
            //alert(userid);
            //alert(comment);



            if (comment == "") {
                $(this).closest('tr').find("#comment").css('border', '2px solid red');
                flg = false;
                return flg;
            }

            item = {}
            item["masteruserid"] = masteruserid;
            item["userid"] = userid;
            item["isreviewed"] = this.checked;
            item["ex_nvarchar2"] = comment;
            jsonObj.push(item);
        });
    }
    else {
        //$('#reviewTable input[type="checkbox"]').each(function () {
        $('#reviewTable').DataTable().$('input[type="checkbox"]').each(function () {

            var masteruserid = $(this).closest('tr').find("#masteruserid").val();
            var userid = $(this).closest('tr').find("#userid").val();
            var comment = $(this).closest('tr').find("#comment").val();

            //var userid = $(this).parent().siblings().find("#userid").val();
            //var comment = $(this).next().closest("tr").find("#comment").val();
            //alert(userid);
            //alert(comment);



            if (comment == "") {
                $(this).closest('tr').find("#comment").css('border', '2px solid red');
                flg = false;
                return flg;
            }

            item = {}
            item["masteruserid"] = masteruserid;
            item["userid"] = userid;
            item["isreviewed"] = this.checked;
            item["ex_nvarchar2"] = comment;
            jsonObj.push(item);
        });
    }



    if (!flg)
        return false;

    var input = AddAntiForgeryToken({
        token: $(".txtUserSTK").val(),
        userinfo: $(".txtServerUtilObj").val(),
        useripaddress: $(".txtuserip").val(),
        sessionid: $(".txtUserSes").val(),
        methodname: "UpdateLockStatus",
        currenturl: window.location.href,
        ex_nvarchar1: JSON.stringify(jsonObj)
    });


    try {
        confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_processConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
            if (answer == "true") {
                $.ajax({
                    url: "ReviewUserInfo",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status === "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                clearAllForms();
                            });
                        }
                    }
                });
            }
        });

    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
});
