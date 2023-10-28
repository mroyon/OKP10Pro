var baseurl = $("#txtBaseUrl").val();
var editor;

$(document).ready(function () {


    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };
    $("#strValue1").keypress(function (e) {
        if (e.which == 13) {
            e.preventDefault();
            $("#btnSearchADEmailReset").click();
        }

    });
    $('body').on('click', '#btnSearchADEmailReset', function (event) {
        try {
            event.preventDefault();
            //var form = $('#frmADEmailResetSearch');
            //jQuery.validator.unobtrusive.parse();
            //jQuery.validator.unobtrusive.parse(form);

            //var newRowContent = "";
            var isValid = true;

            if (($.trim($("#strValue1").val()) == '') &&
                ($.trim($("#entitykey").val()) == '') ) {
                isValid = false;

                //$('#strValue1,#entitykey').each(function () {
                //    $(this).css({
                //        "border": "1px solid red",
                //    });
                //});

                $.alert({
                    title: _getCookieForLanguage("_informationTitle"),
                    content: "Please enter any one of the criteria.",
                    type: 'red'
                });
                return;
            }

        
            else {
                isValid = true;
                $('#strValue1,#entitykey').each(function () {
                    $(this).css({
                        "border": "",
                    });
                });

            //if (form.valid()) {

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "GetUser",
                    currenturl: window.location.href,
                    strValue1: $('#strValue1').val(),
                    entitykey: $('#entitykey').val()//isreviewed
                });




                $('#candidateDt').DataTable({
                    "destroy": true,
                    "bFilter": true,
                    "columnDefs": [{
                        "targets": 0,
                        "searchable": true,
                        "orderable": true
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
                        "url": baseurl + "ADEmailReset/ADEmailResetTableData",
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

                        { "data": "militaryno", "searchable": true, "sortable": true, "orderable": true },
                        { "data": "loweredusername", "searchable": true, "sortable": true, "orderable": true },
                        { "data": "rankname", "searchable": true, "sortable": true, "orderable": true },
                        { "data": "entityname", "searchable": true, "sortable": true, "orderable": true },
                        { "data": "possitionname", "searchable": true, "sortable": true, "orderable": true },
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
                            $('#candidateDt_paginate').css("display", "block");
                        } else {
                            $('#candidateDt_paginate').css("display", "none");
                        }

                    }
                });

            }
        }
    
     catch (e) {
    $.alert({
        title: _getCookieForLanguage("_informationTitle"),
        content: e.message,
        type: 'red'
    });
}
});


   


});
function ADEmailResetEdit(val) {
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
            methodname: "ADEmailResetEdit",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });

        $.ajax({
            url: baseurl + "ADEmailReset/ADEmailResetEdit",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcADEmailResetEdit').html('');
                $('#mcADEmailResetEdit').html(response);
                $('#modal-container-ADEmailResetEdit').modal({ backdrop: 'static', keyboard: false });
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
