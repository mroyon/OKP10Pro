
var baseurl = $("#txtBaseUrl").val();
$(document).ready(function () {
    GetAllWorkFlowTempletsDetlDelayInfoData();
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

function GetAllWorkFlowTempletsDetlDelayInfoData() {
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
            methodname: "WorkFlowTempletsDetlDelayInfoTableData",
            currenturl: window.location.href
        });
        $('#WorkFlowTempletsDetlDelayInfoDt').DataTable({

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
                "url": baseurl + "WorkFlowTempletsDetlDelayInfo/WorkFlowTempletsDetlDelayInfoTableData",
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
                                                      { "data": "templetdetdelayguid", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "templetdetlid", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "notifytouser", "searchable": true, "sortable": true, "orderable": true },
                                                      { "data": "noofdays", "searchable": true, "sortable": true, "orderable": true },
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
                    $('#WorkFlowTempletsDetlDelayInfodt_paginate').css("display", "block");
                } else {
                    $('#WorkFlowTempletsDetlDelayInfodt_paginate').css("display", "none");
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
function EditWorkFlowTempletsDetlDelayInfo(val) {
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
            methodname: "WorkFlowTempletsDetlDelayInfoGet",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });
        $.ajax({
            url: baseurl + "WorkFlowTempletsDetlDelayInfo/WorkFlowTempletsDetlDelayInfoUpdateGet",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#WorkFlowTempletsDetlDelayInfoeditdatacontainer').html('');
                $('#WorkFlowTempletsDetlDelayInfoeditdatacontainer').html(response);
                $('#modal-container-WorkFlowTempletsDetlDelayInfoedit').modal("show");
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
function DeleteWorkFlowTempletsDetlDelayInfo(val) {
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
                    methodname: "WorkFlowTempletsDetlDelayInfoDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: val
                });


                $.ajax({
                    url: baseurl + "WorkFlowTempletsDetlDelayInfo/WorkFlowTempletsDetlDelayInfoDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                $("#WorkFlowTempletsDetlDelayInfoDt").DataTable().ajax.reload();
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
function WorkFlowTempletsDetlDelayInfoDetails(val) {
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
            methodname: "WorkFlowTempletsDetlDelayInfoDetails",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });

        $.ajax({
            url: $("#txtBaseUrl").val() + "/WorkFlowTempletsDetlDelayInfo/WorkFlowTempletsDetlDelayInfoDetails",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#WorkFlowTempletsDetlDelayInfoviewdatacontainer').html('');
                $('#WorkFlowTempletsDetlDelayInfoviewdatacontainer').html(response);

                $('#modal-container-WorkFlowTempletsDetlDelayInfoview').modal('show');
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

$('body').on('click', '#btnCreateWorkFlowTempletsDetlDelayInfo', function (event) {
    try {
        event.preventDefault();
        window.location.href = baseurl + "WorkFlowTempletsDetlDelayInfo/WorkFlowTempletsDetlDelayInfoCreate";
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
});
	
	