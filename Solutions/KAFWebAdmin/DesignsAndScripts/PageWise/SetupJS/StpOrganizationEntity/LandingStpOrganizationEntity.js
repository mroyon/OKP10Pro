

//PN: FILE NAME: "Loadstp_organizationentity.js"
var baseurl = $("#txtBaseUrl").val();

$(document).ready(function () {

    //$(".modal").on("hidden.bs.modal", function () {
    //    $(".modal-body").html("");
    //});
    $('body').on('hidden.bs.modal', function () {
        if ($('.modal.in').length > 0) {
            $('body').addClass('modal-open');
        }
    });

    GetAllDataStpOrganizationEntity();
});

function GetAllDataStpOrganizationEntity() {
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
            "destroy": true,
            "bFilter": true,
            "columnDefs": [{
                "targets": 0,
                "searchable": true,
                "orderable": true
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
                //{ "data": "organizationkey", "searchable": true, "sortable": true, "orderable": true },
                //{ "data": "parentkey", "searchable": true, "sortable": true, "orderable": true },
                //{ "data": "entirytypekey", "searchable": true, "sortable": true, "orderable": true },
                //{ "data": "entitylevel", "searchable": true, "sortable": true, "orderable": true },                {
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
                    $('#StpOrganizationEntityDt_paginate').css("display", "block");
                } else {
                    $('#StpOrganizationEntityDt_paginate').css("display", "none");
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

$('body').on('click', '#btnNewStpOrganizationEntity', function (event) {
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
            methodname: "StpOrganizationEntityNew",
            currenturl: window.location.href
        });
        
        $.ajax({
            url: baseurl + "StpOrganizationEntity/StpOrganizationEntityNew",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcStpOrganizationEntityNew').html('');
                $('#mcStpOrganizationEntityNew').html(response);
                $('#modal-container-StpOrganizationEntityNew').modal({backdrop: 'static',keyboard: false});
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



$('body').on('click', '#btnDeleteStpOrganizationEntity', function (event) {
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
                    strModelPrimaryKey: $("#strModelPrimaryKey").val(),
                });


                $.ajax({
                    url: baseurl + "StpOrganizationEntity/StpOrganizationEntityDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                //window.location.href = baseurl + "StpOrganizationEntity/StpOrganizationEntity";
                                GetAllDataStpOrganizationEntity();
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
});



function StpOrganizationEntityEdit(val) {
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
            methodname: "StpOrganizationEntityEdit",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });
        
        $.ajax({
            url: baseurl + "StpOrganizationEntity/StpOrganizationEntityEdit",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcStpOrganizationEntityEdit').html('');
                $('#mcStpOrganizationEntityEdit').html(response);
                $('#modal-container-StpOrganizationEntityEdit').modal({backdrop: 'static',keyboard: false});
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

function StpOrganizationEntityDelete(val) {
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
                                GetAllDataStpOrganizationEntity();
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

function StpOrganizationEntityDetail(val) {
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
            methodname: "StpOrganizationEntityDetail",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });

        $.ajax({
            url: baseurl +  "StpOrganizationEntity/StpOrganizationEntityDetail",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcStpOrganizationEntityDetail').html('');
                $('#mcStpOrganizationEntityDetail').html(response);
                $('#modal-container-StpOrganizationEntityDetail').modal({backdrop: 'static',keyboard: false});
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


