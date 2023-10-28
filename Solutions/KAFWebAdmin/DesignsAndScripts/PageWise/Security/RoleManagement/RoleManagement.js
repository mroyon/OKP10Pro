

$(document).ready(function () {
    var baseurl = $('#txtBaseUrl').val();

    GetAllUserRoleData();
});

function GetAllUserRoleData() {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    var input = AddAntiForgeryToken({
        token: $(".txtUserSTK").val(),
        userinfo: $(".txtServerUtilObj").val(),
        useripaddress: $(".txtuserip").val(),
        sessionid: $(".txtUserSes").val(),
        methodname: "Role_GetAllData",
        currenturl: window.location.href
    });


    $('#Rolesdt').DataTable({
        //"columnDefs": [
        //    { "targets": [0] },
        //    { "searchable": false, "orderable": false, "targets": [2] },
        //    { "targets": [0, 1, 2] },
        //],
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
            "url": baseurl + "/RoleManagement/GetRoleData",
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
            { "data": "rolename", "searchable": true, "sortable": true, "orderable": true },
            { "data": "description", "sortable": false, "orderable": false }
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

function EditRole(val) {
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
            methodname: "Role_UpdateGet",
            currenturl: window.location.href,
            rolename: val
        });

        $.ajax({
            url: $("#txtBaseUrl").val() + "RoleManagement/Role_UpdateGet/",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#roleeditdatacontainer').html(response);
                $('#modal-container-roleedit').modal({backdrop: 'static',keyboard: false});
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
function DeleteRole(val) {
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
                    methodname: "Role_Delete",
                    currenturl: window.location.href,
                    rolename: val
                });


                $.ajax({
                    url: $('#txtBaseUrl').val() + "RoleManagement/Role_Delete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response != null) {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                if (answer == "true") {
                                    window.location.href = response.redirectUrl;
                                }
                            });
                        }
                    }
                });
            }
        });

    } catch (e) {
    }
}
function RoleDetails(val) {
    try {
        // window.location.href 
        var url = $('#txtBaseUrl').val() + "RoleManagement/Role_Details?input=" + val;

        $.get(url, function (data) {
            $('#detailsRoleContainer').html(data);

            $('#detailsRoleModal').modal('show');
        });
    }
    catch (e) {
    }
}

$('body').on('click', '#btnCreateRole', function (event) {
    try {
        event.preventDefault();
        window.location.href = $('#txtBaseUrl').val() + "RoleManagement/CreateRole";
    } catch (e) {
    }
});
