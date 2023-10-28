
var baseurl = $('#txtBaseUrl').val();
$(document).ready(function () {
    //$('.combodate select').each(function (index, item) {
    //    $(item).addClass('form-control');
    //    $(item).css('display', 'inline');
    //});
    

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    

    $('#btnCreateStpOrganizationEntity').on('click', function (event) {
        try {
            event.preventDefault();

            var form = $('#frmCreateStpOrgEntity');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "StpOrganizationEntityCreate",
                    currenturl: window.location.href,
                    organizationkey: $('#organizationkey').val(),

                    parentkey: $('#hidParent2').val(),
                    entirytypekey: $('#ddl_entirytypekey2').val(),
                    entitylevel: parseInt($('#txtentitylevel2').val()) + 1,
                    //seqfirstindex: $('#seqfirstindex').val(),
                    //seqfullindex: $('#seqfullindex').val(),
                    //entitycpde: $('#entitycpde').val(),
                    entityname: $('#txtentityname2').val(),
                    description: $('#txtdescription2').val(),
                    isactive: $('#txtisactive2').val()

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "StpOrganizationEntity/StpOrganizationEntityCreate",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            document.getElementById("frmCreateStpOrgEntity").reset();

                                            clearvalues();
                                            $("#treeview_all_unit").jstree("refresh");
                                            $("#orgunitContent1").html('');
                                            $('.nav-tabs a[href="#orgunitContent2"]').tab('show');
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
        $("#treeview_all_unit").jstree().deselect_all(true);

        $("#orgunitContent1").html('');
        $('.nav-tabs a[href="#orgunitContent2"]').tab('show');
        $('#frmCreateStpOrgEntity')[0].reset();
    });
});
//$("#jsTree").jstree().deselect_all(true);
function clearvalues() {
    $("#hidParentKey").val('');
    $('#txtParent2').val('');

    $('#txtParent1').val('');
    $('#txtentitylevel2').val('2');
    $("#treeview_all_unit").jstree().deselect_all(true);
}

function afterselectunit(currentnode, parentnode) {

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
            methodname: "StpOrganizationEntityUpdate",
            currenturl: window.location.href,

            entitykey: currentnode.id
        });


        $.ajax({
            url: baseurl + "StpOrganizationEntity/GetSingleDetails",
            data: input,
            type: 'POST',
            success: function (response) {

                $('#orgunitContent1').html('');
                $('#orgunitContent1').html(response);
                $('.nav-tabs a[href="#orgunitContent1"]').tab('show');


                $("#hidParent2").val(currentnode.id);
                $('#txtParent2').val(currentnode.text);

                $('#txtParent1').val(parentnode.text);

                $('#txtentitylevel2').val(currentnode.parents.length);
                $('#entitylevel').val(currentnode.parents.length);

               
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


