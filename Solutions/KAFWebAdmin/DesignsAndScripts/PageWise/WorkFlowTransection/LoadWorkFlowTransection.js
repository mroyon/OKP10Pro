
var baseurl = $("#txtBaseUrl").val();
$(document).ready(function () {
    GetAllWorkFlowTransectionData();
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

function GetAllWorkFlowTransectionData() {
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
            methodname: "WorkFlowTransectionTableData",
            currenturl: window.location.href
        });
        $('#WorkFlowTransectionDt').DataTable({

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
                "url": baseurl + "WorkFlowTransection/WorkFlowTransectionTableData",
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
                                                      { "data": "processid", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "pkid", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "templetid", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "templetname", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "levelid", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "levelname", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "userid", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "username", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "notificationid", "searchable": true, "sortable": true, "orderable": true },
                                    					{
                                                        "data": "notificationdate", "sortable": true, "orderable": true,"searchable": false,
                                                        "render": function (data, type, full, meta){
                                                            return datetoStr(data);
                                                        }
                                                        },
                                                      { "data": "approvedby", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "statusid", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "statusname", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "comments", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "isviewed", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "codedtext", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "remarks", "searchable": true, "sortable": true, "orderable": true },
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
                    $('#WorkFlowTransectiondt_paginate').css("display", "block");
                } else {
                    $('#WorkFlowTransectiondt_paginate').css("display", "none");
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
function EditWorkFlowTransection(val) {
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
            methodname: "WorkFlowTransectionGet",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });
        $.ajax({
            url: baseurl + "WorkFlowTransection/WorkFlowTransectionUpdateGet",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#WorkFlowTransectioneditdatacontainer').html('');
                $('#WorkFlowTransectioneditdatacontainer').html(response);
                $('#modal-container-WorkFlowTransectionedit').modal("show");
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
function DeleteWorkFlowTransection(val) {
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
                    methodname: "WorkFlowTransectionDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: val
                });


                $.ajax({
                    url: baseurl + "WorkFlowTransection/WorkFlowTransectionDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                $("#WorkFlowTransectionDt").DataTable().ajax.reload();
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
function WorkFlowTransectionDetails(val) {
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
            methodname: "WorkFlowTransectionDetails",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });

        $.ajax({
            url: $("#txtBaseUrl").val() + "/WorkFlowTransection/WorkFlowTransectionDetails",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#WorkFlowTransectionviewdatacontainer').html('');
                $('#WorkFlowTransectionviewdatacontainer').html(response);

                $('#modal-container-WorkFlowTransectionview').modal('show');
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

$('body').on('click', '#btnCreateWorkFlowTransection', function (event) {
    try {
        event.preventDefault();
        window.location.href = baseurl + "WorkFlowTransection/WorkFlowTransectionCreate";
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
});
	
	