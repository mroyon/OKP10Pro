

$(document).ready(function () {
    var baseurl = $('#txtBaseUrl').val();

    GetAllPageInfoData();
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

function GetAllPageInfoData() {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    var input = AddAntiForgeryToken({
        token: $(".txtUserSTK").val(),
        userinfo: $(".txtServerUtilObj").val(),
        useripaddress: $(".txtuserip").val(),
        sessionid: $(".txtUserSes").val(),
        methodname: "PageInfo_GetAllData",
        currenturl: window.location.href
    });



    $('#PageInfoDt').DataTable({


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
            "url": $('#txtBaseUrl').val() + "/PageInfo/" + "GetPageInfoData"
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


          { "data": "pagetitlear", "searchable": true }
            ,
              { "data": "pagetitle", "searchable": true },
            {

                "data": "ex_nvarchar1",
                "render": function (data, type, full, meta) {
                    return data;
                }
            }
        ]
    });
}

function EditPageInfo(val) {
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
            methodname: "PageInfo_UpdateGet",
            currenturl: window.location.href,
            pagetitlear: val
        });

        // window.location.href = $('#txtBaseUrl').val() + "PageInfo/PageInfo_UpdateGet?input=" + val;

        $.ajax({
            url: $("#txtBaseUrl").val() + "/PageInfo/PageInfo_UpdateGet/",
            type: 'POST',
            data: input,
            async: false,
            success: function (response) {

                $('#pageinfoeditdatacontainer').html(response);

                if (typeof CKEDITOR.instances['pagecontentar'] != 'undefined') {
                    CKEDITOR.instances['pagecontent'].setData($('#pagecontent').val());
                    CKEDITOR.instances['pagecontentar'].setData($('#pagecontentar').val());
                }
                $('#modal-container-pageinfoedit').modal({backdrop: 'static',keyboard: false});

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
function DeletePageInfo(val) {
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
                    methodname: "PageInfo_Delete",
                    currenturl: window.location.href,
                    pagetitlear: val
                });


                $.ajax({
                    url: $('#txtBaseUrl').val() + "PageInfo/PageInfo_Delete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                $("#PageInfoDt").DataTable().ajax.reload();
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
function PageInfoDetails(val) {



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
            pagetitlear: val
        });

        $.ajax({
            url: $("#txtBaseUrl").val() + "/PageInfo/PageInfo_Details/",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#pageinfoviewdatacontainer').html(response);
                $('#modal-container-pageinfoview').modal({backdrop: 'static',keyboard: false});
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

$('body').on('click', '#btnAddPageInfo', function (event) {
    try {
        event.preventDefault();
        window.location.href = $('#txtBaseUrl').val() + "PageInfo/CreatePageInfo";
    } catch (e) {
    }
});

