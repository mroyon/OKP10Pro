

//PN: FILE NAME: "Loadhr_svcinfo.js"
var baseurl = $("#txtBaseUrl").val();

$(document).ready(function () {
    
    $('body').on('hidden.bs.modal', function () {
        if ($('.modal.in').length > 0) {
            $('body').addClass('modal-open');
        }
    });
    $('#btnClear').hide();

    $('.militarynokwT,.militarynobdT,.civilidT,.passportnoT,.fullnameT').keypress(function (e) {
        var key = e.which;
        if (key == 13)
        {
            $('#btnLandingSearch').trigger('click');
            return false;
        }
    }); 
});


$('body').on('click', '#btnLandingSearch', function (event) {
    try {
      
        $('#btnClear').show();
        //var isValid = true;

        if (($.trim($("#militarynokw").val()) == '') &&
            ($.trim($("#militarynobd").val()) == '') &&
            ($.trim($("#civilid").val()) == '') &&
            ($.trim($("#passportno").val()) == '') &&
            ($.trim($("#fullname").val()) == '')) {
            isValid = false;

            $('.searchtext').each(function () {
                $(this).css({
                    "border": "1px solid red"
                });
            });

            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: "Please enter any one of the criteria",
                type: 'red'
            });
            return;
        }
        else {
            isValid = true;
            $('.searchtext').each(function () {
                $(this).css({
                    "border": ""
                });
            });

            GetAllDataHrSvcInfo();
        }
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
});

$('body').on('click', '.btnClear', function (event) {
    try {
        event.preventDefault();
        //$('#HrSvcInfoDt').DataTable().clear().draw();
        //$('#HrSvcInfoDt').empty();
        $('#HrSvcInfoDt tbody').empty();
        $('#militarynokw').val('');
        $('#militarynobd').val('');
        $('#civilid').val('');
        $('#passportno').val('');
        $('#fullname').val('');
        $('.btnClear').hide();

    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
});

function GetAllDataHrSvcInfo() {
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
            methodname: "HrSvcInfoTableData",
            currenturl: window.location.href,

            militarynokw: $('#militarynokw').val(),
            militarynobd: $('#militarynobd').val(),
            civilid: $('#civilid').val(),
            passportno: $('#passportno').val(),
            fullname: $('#fullname').val()
        });
        
        $('#HrSvcInfoDt').DataTable({
            "destroy": true,
            "bFilter": false,
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
            "bPaginate": false,
            "bInfo": false,
            "ajax": {
                "url": baseurl + "HrSvcInfo/HrSvcInfoTableData",
                "type": "POST",
                "data": input,
                "dataFilter": function (data) {
                    var json = jQuery.parseJSON(data);
                    if (json.status == "failed") {
                        $.alert({
                            title: _getCookieForLanguage("_informationTitle"),
                            content: json.responsetext,
                            type: 'red'
                        });
                    }
                    //alert("rony");
                    return JSON.stringify(json); // return JSON string                    
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                $.alert({
                    title: _getCookieForLanguage("_informationTitle"),
                    content: jqXHR.responseJSON.Error,
                    type: 'red'
                });
            },
            "columns": [
                { "data": "militarynokw", "searchable": false, "sortable": false, "orderable": false },
                { "data": "fullname", "searchable": false, "sortable": false, "orderable": false },
                { "data": "passportno", "searchable": false, "sortable": false, "orderable": false },
                { "data": "statusStr", "searchable": false, "sortable": false, "orderable": false },

                {
                    "data": "ex_nvarchar1",
                    "render": function (data, type, full, meta) {
                        return data;
                    }
                }
            ],
            "drawCallback": function (settings) {

                ///*show pager if only necessary
                //console.log(this.fnSettings());*/
                //if (Math.ceil((this.fnSettings().fnRecordsDisplay()) / this.fnSettings()._iDisplayLength) > 1) {
                //    $('#HrSvcInfoDt_paginate').css("display", "block");
                //} else {
                //    $('#HrSvcInfoDt_paginate').css("display", "none");
                //}

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

$('body').on('click', '#btnNewHrSvcInfo', function (event) {
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
            methodname: "HrSvcInfoNew",
            currenturl: window.location.href
        });
        
        $.ajax({
            url: baseurl + "HrSvcInfo/HrSvcInfoNew",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrSvcInfoNew').html('');
                $('#mcHrSvcInfoNew').html(response);
                $('#modal-container-HrSvcInfoNew').modal({ backdrop: 'static', keyboard: false });

                $('#btnRemoveImage').hide();
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

$('body').on('click', '#btnDeleteHrSvcInfo', function (event) {
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
                    methodname: "HrSvcInfoDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: $("#strModelPrimaryKey").val(),
                });


                $.ajax({
                    url: baseurl + "HrSvcInfo/HrSvcInfoDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                //window.location.href = baseurl + "HrSvcInfo/HrSvcInfo";
                                GetAllDataHrSvcInfo();
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
});

function updatecampsubunit(val) {
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
            methodname: "HrSvcInfoEdit",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });

        $.ajax({
            url: baseurl + "HrSvcInfo/HrSvcInfoEdit_Temp",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrSvcInfoEdit').html('');
                $('#mcHrSvcInfoEdit').html(response);
                $('#modal-container-HrSvcInfoEdit').modal({ backdrop: 'static', keyboard: false });
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

function HrSvcInfoEdit(val) {
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
            methodname: "HrSvcInfoEdit",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });
        
        $.ajax({
            url: baseurl + "HrSvcInfo/HrSvcInfoEdit",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrSvcInfoEdit').html('');
                $('#mcHrSvcInfoEdit').html(response);
                $('#modal-container-HrSvcInfoEdit').modal({backdrop: 'static',keyboard: false});
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


function HrSvcInfoDelete(val) {
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
                    methodname: "HrSvcInfoDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: val
                });


                $.ajax({
                    url: baseurl + "HrSvcInfo/HrSvcInfoDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                GetAllDataHrSvcInfo();
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

function HrSvcInfoDetail(val) {
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
            methodname: "HrSvcInfoDetail",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });

        $.ajax({
            url: baseurl +  "HrSvcInfo/HrSvcInfoDetail",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrSvcInfoDetail').html('');
                $('#mcHrSvcInfoDetail').html(response);
                $('#modal-container-HrSvcInfoDetail').modal({backdrop: 'static',keyboard: false});
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


