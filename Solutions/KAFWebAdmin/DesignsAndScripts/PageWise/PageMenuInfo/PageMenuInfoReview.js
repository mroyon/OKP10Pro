
var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {
    $('#ex_date1').combodate({
        customClass: 'form-control2'
    });
    $('#ex_date2').combodate({
        customClass: 'form-control2'
    });
    checkForm();
});


function checkForm() {
    if ($('#ddlUserType option:selected').val() == "-99")
        $("#txtreviewedbyusername").addClass("hidden");
    else
        $("#txtreviewedbyusername").removeClass("hidden");

    if ($('#ddlDateFor option:selected').val() == "-99")
        $("#combodates").addClass("hidden");
    else
        $("#combodates").removeClass("hidden");
}


$(document).ready(function () {
    checkForm();
    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    $('body').on('change', '#ddlUserType', function (event) {
        try {
            checkForm();
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });

    $('body').on('change', '#ddlDateFor', function (event) {
        try {
            checkForm();
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });

    $('body').on('click', '#btnSearch', function (event) {
        try {
          
            event.preventDefault();
            GetAllPageMenuInfoData(GetInput());
           
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });

});
function GetInput() {
    try {
        var UserTypeUserName = '';

        if ($('#ddlUserType option:selected').val() != "-99") {
            UserTypeUserName = $('#txtcreatedbyusername').val();
        }
        else
            UserTypeUserName = '';

        var datefrom = "";
        var dateto = "";
        var dtspl = "";
        if ($('#ddlDateFor option:selected').val() != "-99") {
            if ($('#ex_date1').val() != "") {
                dtspl = $('#ex_date1').val().split("-");
                datefrom = new Date(dtspl[2], dtspl[1] - 1, dtspl[0]);
            }
            if ($('#ex_date2').val() != "") {
                dtspl = $('#ex_date2').val().split("-");
                dateto = new Date(dtspl[2], dtspl[1] - 1, dtspl[0]);
            }
        }
        else {
            datefrom = '';
            dateto = '';
        }


        var input = AddAntiForgeryToken({
            token: $(".txtUserSTK").val(),
            userinfo: $(".txtServerUtilObj").val(),
            useripaddress: $(".txtuserip").val(),
            sessionid: $(".txtUserSes").val(),
            methodname: "CreatePageMenuInfo",
            currenturl: window.location.href,
            // faqcategoryid: $('#ddl_faqcategory').val() != "" ? parseInt($('#ddl_faqcategory').val()) : -99,
            menutitlear: $('#txtmenutitle').val(),
            reviewedby: $('#ddlUserType option:selected').val(),
            ex_nvarchar2: $('#txtreviewedbyusername').val(),
            ex_nvarchar1: $('#ddlDateFor option:selected').val(),
            ex_date1: datefrom != "" ? new Date(datefrom).toISOString() : null,
            ex_date2: dateto != "" ? new Date(dateto).toISOString() : null,
            isreviewed: $('#ddlIsReviewed option:selected').val() == "-99" ? null : $('#ddlIsReviewed option:selected').val() == "1" ? true : false
        });
        return input;

    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
}
function datetoStr(data) {
    if (data != null) {
        var regex = /-?\d+/;
        var match = regex.exec(data);
        var pubdate = new Date(parseInt(match[0]));

        var dd = pubdate.getDate(); var mm = pubdate.getMonth() + 1;
        var yyyy = pubdate.getFullYear(); if (dd < 10) { dd = '0' + dd } if (mm < 10) { mm = '0' + mm }
        var today = dd + '/' + mm + '/' + yyyy;
        return today;
    }
    else
        return '';
}

function GetAllPageMenuInfoData(input) {
    try {
        //$.fn.dataTable.ext.errMode = 'none';
        //    function (settings, helpPage, message) {
        //    console.log(message);
        //};
        rev = $('#reviewTable').DataTable(
            {
                "bDestroy": true,
                "columnDefs": [{
                    "targets": 0,
                    "searchable": true,
                    "orderable": true,
                }
                ],
                "language":
                    {
                        "processing": "<div class='overlay custom-loader-background'><i class='fa fa-cog fa-spin custom-loader-color'></i></div>"
                    },
                "processing": true,
                "serverSide": true,
                "autoWidth": false,
                "responsive": true,
                "paginate": true,
                "ajax":
                    {
                        "url": baseurl + "PageMenuInfo/GetPageMenuInfoDataForReviewPublishArchive"
                        , "type": "POST"
                        , "data": input
                        , "dataSrc": function (json) {


                            if (json.data.length <= 0) {
                                var table = $('#reviewTable').DataTable();

                            }
                            if (json.data.length > 0) {

                                var divtext = "";
                                $("#list-panelButtons").empty();
                                divtext += "<div class='panel-footer text-center'>"
                                divtext += "<div class='btn-group text-center'>"
                                divtext += "<div class='btn-group'>"
                                divtext += json.data[0].ex_nvarchar2
                                divtext += "</div>"
                                divtext += "</div>"
                                divtext += "</div>"
                                $("#list-panelButtons").append(divtext);
                            }
                            return json.data;
                        },
                        error: function (jqXHR, textStatus, errorThrown) {
                            $.alert({
                                title: _getCookieForLanguage("_informationTitle"),
                                content: jqXHR.responseJSON.Error,
                                type: 'red'
                            });
                        }
                    },
                "columns": [
                    {
                        "data": "menutitlear", "searchable": true, "sortable": true, "orderable": true,
                        "render": function (data, type, full, meta) {
                            var userid = full.menutitlear + '<input id="tablepublicmenuid" name="tablepublicmenuid" type="hidden" value="' + full.publicmenuid + '" />';
                            return userid;
                        }
                    },
                    { "data": "menutitle", "searchable": false, "sortable": true, "orderable": true },
                    {
                        "data": "createddate",
                        "render": function (data, type, full, meta) {
                            return datetoStr(data);
                        }
                    },
                    { "data": "isreviewed", "searchable": false, "sortable": true, "orderable": true },
                    { "data": "ispublished", "searchable": false, "sortable": true, "orderable": true },
                    {

                        "data": "ex_nvarchar1",
                        "render": function (data, type, full, meta) {
                            return data;
                        }
                    }
                ]
            });

    } catch (e) {
       
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
}

$('body').on('click', '#btnProcessCancel', function (event) {
    event.preventDefault();

    try {
        confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_cancelConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
            if (answer == "true") {
                clearAllForms();
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

function clearAllForms() {
    try {
        var table = $('#reviewTable').DataTable();
        table.destroy();
        $('#reviewTable').empty();

        //$('#ddl_faqcategory').val('');
        $('#txtmenutitle').val('');
        $('#txtcreatedbyusername').val('');
        $('#ex_date1').combodate('clearValue');
        $('#ex_date2').combodate('clearValue');

        $('#ddlIsReviewed').val('-99');
        $('#ddlUserType').val('-99');
        $('#ddlDateFor').val('-99');

        $("#list-panelButtons").empty();

    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
}


function ReviewPageMenuInfo(val) {
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
            menutitle: val,
            strValue1: "FROMREVIEW"
        });

        $.ajax({
            url: $("#txtBaseUrl").val() + "/PageMenuInfo/PageMenuInfo_Details",
            type: 'POST',
            data: input,
            async: false,
            success: function (response) {
                $('#pagemenuinfoviewdatacontainer').html('');
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


