


$(document).ready(function () {
    loadUserDataTable()
    var baseurl = $('#txtBaseUrl').val();
    $('body').on('click', '#btnCreateUser', function (event) {
        try {
            event.preventDefault();
            window.location.href = baseurl + "UserManagement/CreateUser";
        } catch (e) {
        }
    });
}
);

function loadUserDataTable() {
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
            methodname: "LoadUserDataTable",
            currenturl: window.location.href
        });


        $('#TableId').DataTable(
        {

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
            "ajax":
                {
                    "url": $('#txtBaseUrl').val() + "/UserManagement/LoadUserDataTable",
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
                        { "data": "username", "searchable": true, "sortable": true, "orderable": true },
                        { "data": "mobilenumber", "sortable": true, "orderable": true },
                        { "data": "emailaddress", "sortable": true, "orderable": true },
                        {
                            "data": "ex_nvarchar1",
                            "render": function (data, type, full, meta) {
                                //    var editurl = $('#txtBaseUrl').val() + "UserManagement/Role_Update/" + data;
                                //    var detailsurl = $('#txtBaseUrl').val() + "UserManagement/Role_Details/" + data;
                                //    var deleteurl = $('#txtBaseUrl').val() + "UserManagement/Role_Delete/" + data;
                                //    return "<button onclick='EditUser(&quot;" + data + "&quot;)'>Edit</button> <button onclick='DeleteUser(&quot;" + data + "&quot;)'>Delete</button>  <button onclick='UserDetails(&quot;" + data + "&quot;)'>Details</button>";
                                return data;
                            }
                        }
            ]
        });
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e,
            type: 'red'
        });
    }
}

function EditUser(val) {
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
            username: val
        });

        $.ajax({
            url: $("#txtBaseUrl").val() + "/UserManagement/EditUser_Get/",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#usereditdatacontainer').html(response);
                $('#modal-container-useredit').modal({backdrop: 'static',keyboard: false});
            }
        });

        //window.location.href = $('#txtBaseUrl').val() + "UserManagement/EditUser_Get?input=" + val;

    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
}

function DeleteUser(val) {
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
                    methodname: "User_Delete",
                    currenturl: window.location.href,
                    username: val
                });

                $.ajax({
                    url: $('#txtBaseUrl').val() + "UserManagement/DeleteUser",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                $("#TableId").DataTable().ajax.reload();
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

function UserDetails(val) {
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
            username: val
        });

        $.ajax({
            url: $("#txtBaseUrl").val() + "/UserManagement/User_Get/",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#userviewdatacontainer').html(response);
                $('#modal-container-userview').modal({backdrop: 'static',keyboard: false});
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

$('body').on('click', '#btnCreateUser', function (event) {
    try {
        event.preventDefault();
        window.location.href = $('#txtBaseUrl').val() + "UserManagement/CreateUser";
    } catch (e) {
    }
});
