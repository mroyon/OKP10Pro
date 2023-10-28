
var baseurl = $("#txtBaseUrl").val();
$(document).ready(function () {
    GetAllStpOrganizationEntityData();
});

function datetoStr(data) {
    var regex = /-?\d+/;
    var match = regex.exec(data);
    var pubdate = new Date(parseInt(match[0]));

    var dd = pubdate.getDate(); var mm = pubdate.getMonth() + 1;
    var yyyy = pubdate.getFullYear(); if (dd < 10) { dd = '0' + dd } if (mm < 10) { mm = '0' + mm }
    var today = dd + '/' + mm + '/' + yyyy;
    return today;
}

function GetAllStpOrganizationEntityData() {
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
            methodname: "StpOrganizationEntityTableData",
            currenturl: window.location.href
        });
        $('#StpOrganizationEntityDt').DataTable({

            "bFilter": true,
            "columnDefs": [{
                "targets": 0,
                "searchable": true,
                "orderable": true,
            }],
            "language":
            {
                "processing": "<div class='overlay custom-loader-background'><i class='fa fa-cog fa-spin custom-loader-color'></i></div>"
            },
            "processing": true,
            "serverSide": true,
            "autoWidth": false,
            "responsive": true,
            "ajax": {
                "url": baseurl + "StpOrganizationEntity/StpOrganizationEntityTableData",
                "type": "POST",
                "data": input
            },
            error: function (jqXHR, textStatus, errorThrown) {
                $.alert({
                    title: _getCookieForLanguage("_informationTitle"),
                    content: jqXHR.responseJSON.Error,
                    type: 'red'
                });
            },
            "columns": [
                { "data": "entityname", "searchable": true, "sortable": true, "orderable": true },
                { "data": "organizationkey", "searchable": true, "sortable": true, "orderable": true },
                { "data": "parentkey", "searchable": true, "sortable": true, "orderable": true },
                { "data": "entirytypekey", "searchable": true, "sortable": true, "orderable": true },
                { "data": "entitylevel", "searchable": true, "sortable": true, "orderable": true },
               // { "data": "seqfirstindex", "searchable": true, "sortable": true, "orderable": true },
                //{ "data": "seqfullindex", "searchable": true, "sortable": true, "orderable": true },
                //{ "data": "entitycpde", "searchable": true, "sortable": true, "orderable": true },
                //{ "data": "description", "searchable": true, "sortable": true, "orderable": true },
                { "data": "isactive", "searchable": true, "sortable": true, "orderable": true },
                {
                    "data": "ex_nvarchar1",
                    "render": function (data, type, full, meta) {
                        return data;
                    }
                }
            ],

            "drawCallback": function (settings) {

                /*show pager if only necessary
                console.log(this.fnSettings());*/
                if (Math.ceil((this.fnSettings().fnRecordsDisplay()) / this.fnSettings()._iDisplayLength) > 1) {
                    $('#StpOrganizationEntitydt_paginate').css("display", "block");
                } else {
                    $('#StpOrganizationEntitydt_paginate').css("display", "none");
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
function EditStpOrganizationEntity(val) {
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
            methodname: "StpOrganizationEntityGet",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });
        $.ajax({
            url: baseurl + "StpOrganizationEntity/StpOrganizationEntityUpdateGet",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#StpOrganizationEntityeditdatacontainer').html('');
                $('#StpOrganizationEntityeditdatacontainer').html(response);
                $('#modal-container-StpOrganizationEntityedit').modal({backdrop: 'static',keyboard: false});
            }
        });
        //window.location.href = baseurl + "CurrentActivity/CurrentActivityUpdate?input=" + val;

    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
}
function DeleteStpOrganizationEntity(val) {
    try {
        confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_deleteConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
            if (answer == "true") {

                AddAntiForgeryToken = function (data) {
                    data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
                    return data;
                };

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "StpOrganizationEntityDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: val
                });


                $.ajax({
                    url: baseurl + "StpOrganizationEntity/StpOrganizationEntityDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                $("#StpOrganizationEntityDt").DataTable().ajax.reload();
                            });
                        }
                        else {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
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
}
function StpOrganizationEntityDetails(val) {
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
            methodname: "StpOrganizationEntityDetails",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });

        $.ajax({
            url: $("#txtBaseUrl").val() + "/StpOrganizationEntity/StpOrganizationEntityDetails",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#StpOrganizationEntityviewdatacontainer').html('');
                $('#StpOrganizationEntityviewdatacontainer').html(response);

                $('#modal-container-StpOrganizationEntityview').modal('show');
            }
        });
    }
    catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
}

$('body').on('click', '#btnCreateStpOrganizationEntity', function (event) {
    try {
        event.preventDefault();
        window.location.href = baseurl + "StpOrganizationEntity/StpOrganizationEntityCreate";
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
});

