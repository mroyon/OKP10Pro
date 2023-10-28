$(document).ready(function () {
    var baseurl = $('#txtBaseUrl').val();

    GetAllPageMenuInfoData();
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

function GetAllPageMenuInfoData() {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    var input = AddAntiForgeryToken({
        token: $(".txtUserSTK").val(),
        userinfo: $(".txtServerUtilObj").val(),
        useripaddress: $(".txtuserip").val(),
        sessionid: $(".txtUserSes").val(),
        methodname: "PageMenuInfo_GetAllData",
        currenturl: window.location.href
    });



    $('#PageMenuInfoDt').DataTable({


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
            "url": $('#txtBaseUrl').val() + "/PageMenuInfo/" + "GetPageMenuInfoData"
            , "type": "POST"
            , "data": input

        },
        error: function (jqXHR, textStatus, errorThrown) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: jqXHR.responseJSON.Error,
                type: 'red'
            });
        },
        
        "columns": [
          { "data": "menutitle", "searchable": true },
          { "data": "menutitlear", "searchable": true }
            ,
            {

                "data": "ex_nvarchar1",
                "render": function (data, type, full, meta) {
                    return data;
                }
            }
        ]
    });
}

function EditPageMenuInfo(val) {
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
            methodname: "PageMenuInfo_UpdateGet",
            currenturl: window.location.href,
            menutitle: val
        });

        // window.location.href = $('#txtBaseUrl').val() + "PageInfo/PageInfo_UpdateGet?input=" + val;

        $.ajax({
            url: $("#txtBaseUrl").val() + "/PageMenuInfo/PageMenuInfo_UpdateGet/",
            type: 'POST',
            data: input,
            async: false,
            success: function (response) {

                $('#pagemenuinfoeditdatacontainer').html(response);


                $('#modal-container-pagemenuinfoedit').modal({backdrop: 'static',keyboard: false});

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
function DeletePageMenuInfo(val) {
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
                    methodname: "PageMenuInfo_Delete",
                    currenturl: window.location.href,
                    menutitle: val
                });


                $.ajax({
                    url: $('#txtBaseUrl').val() + "PageMenuInfo/PageMenuInfo_Delete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                $("#PageMenuInfoDt").DataTable().ajax.reload();
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
    }
}
function PageMenuInfoDetails(val) {



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
            methodname: "User_UpdateGet",
            currenturl: window.location.href,
            menutitle: val
        });

        $.ajax({
            url: $("#txtBaseUrl").val() + "/PageMenuInfo/PageMenuInfo_Details/",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#pagemenuinfoviewdatacontainer').html(response);
                $('#modal-container-pagemenuinfoview').modal({backdrop: 'static',keyboard: false});
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

$('body').on('click', '#btnAddPageMenuInfo', function (event) {
    try {
        event.preventDefault();
        window.location.href = $('#txtBaseUrl').val() + "PageMenuInfo/CreatePageMenuInfo";
    } catch (e) {
    }
});

