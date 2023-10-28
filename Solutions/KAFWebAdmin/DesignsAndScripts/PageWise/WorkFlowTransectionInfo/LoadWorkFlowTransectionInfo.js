
var baseurl = $("#txtBaseUrl").val();
$(document).ready(function () {
    GetAllWorkFlowTransectionInfoData();
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

function GetAllWorkFlowTransectionInfoData() {
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
            methodname: "WorkFlowTransectionInfoTableData",
            currenturl: window.location.href
        });
        $('#WorkFlowTransectionInfoDt').DataTable({

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
                "url": baseurl + "WorkFlowTransectionInfo/WorkFlowTransectionInfoTableData",
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
                                                      { "data": "pkid", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "tablename", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "pkcolumnname", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "status", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "isclosed", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "isnew", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "description", "searchable": true, "sortable": true, "orderable": true },
                                    					{
                                                        "data": "transdate", "sortable": true, "orderable": true,"searchable": false,
                                                        "render": function (data, type, full, meta){
                                                            return datetoStr(data);
                                                        }
                                                        },
                                    					{
                                                        "data": "closeddate", "sortable": true, "orderable": true,"searchable": false,
                                                        "render": function (data, type, full, meta){
                                                            return datetoStr(data);
                                                        }
                                                        },
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
                    $('#WorkFlowTransectionInfodt_paginate').css("display", "block");
                } else {
                    $('#WorkFlowTransectionInfodt_paginate').css("display", "none");
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
function EditWorkFlowTransectionInfo(val) {
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
            methodname: "WorkFlowTransectionInfoGet",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });
        $.ajax({
            url: baseurl + "WorkFlowTransectionInfo/WorkFlowTransectionInfoUpdateGet",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#WorkFlowTransectionInfoeditdatacontainer').html('');
                $('#WorkFlowTransectionInfoeditdatacontainer').html(response);
                $('#modal-container-WorkFlowTransectionInfoedit').modal("show");
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
function DeleteWorkFlowTransectionInfo(val) {
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
                    methodname: "WorkFlowTransectionInfoDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: val
                });


                $.ajax({
                    url: baseurl + "WorkFlowTransectionInfo/WorkFlowTransectionInfoDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                $("#WorkFlowTransectionInfoDt").DataTable().ajax.reload();
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
function WorkFlowTransectionInfoDetails(val) {
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
            methodname: "WorkFlowTransectionInfoDetails",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });

        $.ajax({
            url: $("#txtBaseUrl").val() + "/WorkFlowTransectionInfo/WorkFlowTransectionInfoDetails",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#WorkFlowTransectionInfoviewdatacontainer').html('');
                $('#WorkFlowTransectionInfoviewdatacontainer').html(response);

                $('#modal-container-WorkFlowTransectionInfoview').modal('show');
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

$('body').on('click', '#btnCreateWorkFlowTransectionInfo', function (event) {
    try {
        event.preventDefault();
        window.location.href = baseurl + "WorkFlowTransectionInfo/WorkFlowTransectionInfoCreate";
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
});
	
	