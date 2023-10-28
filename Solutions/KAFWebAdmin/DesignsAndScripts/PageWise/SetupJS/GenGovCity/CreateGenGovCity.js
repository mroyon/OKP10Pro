
var baseurl = $('#txtBaseUrl').val();
$(document).ready(function () {
    $('#txtgovcityname').val('');
    $('#txtdescription2').val('');
    
    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };


    $('body').on('click', '#btnCreateGenGovCity', function (event) {
        try {
            event.preventDefault();

            var form = $('#frmCreateGenGovCity');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "GenGovCityCreate",
                    currenturl: window.location.href,
                    parentid: $('#hidParent2').val(),
                    cityname: $('#txtgovcityname').val(),
                    //citynameend: $('#citynameend').val(),
                    //isgov: $('#isgov').val(),
                    //countryid: $('#ddl_country option:selected').val(),
                    remarks: $('#txtdescription2').val()

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "GenGovCity/GenGovCityCreate",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    confirmationDialog(data.title, data.responsetext, _getCookieForLanguage("_btnAddMore"), _getCookieForLanguage("_btnGoBackToMain")).then(function (answer) {
                                        if (answer == "true") {
                                            document.getElementById("frmCreateGenGovCity").reset();
                                            clearvalues();
                                            $("#treeview_all_govcity").jstree("refresh");
                                            $("#govcityContent1").html('');
                                            $('.nav-tabs a[href="#govcityContent2"]').tab('show');
                                        }
                                        else if (answer == "false") {
                                            window.location.href = data.redirectUrl;
                                        }
                                    });
                                }
                                else {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                        }
                                    });
                                }
                            }
                        });
                    }
                });
            }
            else {
                return;
            }

        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });


    $('#btnCreateCancel').on('click', function (event) {
        $("#treeview_all_govcity").jstree().deselect_all(true);

        $("#govcityContent1").html('');
        $('.nav-tabs a[href="#govcityContent2"]').tab('show');
        $('#frmCreateGenCivilJob')[0].reset();
    });
});
function clearvalues() {
    $("#hidParentId").val('');
    $('#txtParent2').val('');
    $('#txtgovcityname').val('');
    $('#txtParent1').val('');
    $('#txtgovcityname').val('');
    $("#treeview_all_govcity").jstree().deselect_all(true);
}
function afterselectgovcity(currentnode, parentnode) {

    try {
        event.preventDefault();

        AddAntiForgeryToken = function (data) {
            data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
            return data;
        };

        var input = AddAntiForgeryToken({
            token: $(".txtUserSTK").val(),
            userinfo: $(".txtServerUtilObj").val(),
            useripaddress: $(".txtuserip").val(),
            sessionid: $(".txtUserSes").val(),
            methodname: "GetSingleDetails",
            currenturl: window.location.href,

            cityid: currentnode.id
        });


        $.ajax({
            url: baseurl + "GenGovCity/GetSingleDetails",
            data: input,
            type: 'POST',
            success: function (response) {

                $('#govcityContent1').html('');
                $('#govcityContent1').html(response);
                $('.nav-tabs a[href="#govcityContent1"]').tab('show');


                $("#hidParent2").val(currentnode.id);
                $('#txtParent2').val(currentnode.text);

                $('#txtParent1').val(parentnode.text);
                $('#hidParentid').val(parentnode.id);

                $('#txtentitylevel2').val(currentnode.parents.length);
                $('#parentid').val(currentnode.parents.length);
                // clearvalues();
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

