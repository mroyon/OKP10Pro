

//PN: FILE NAME: "Loadhr_personalinfo.js"
var baseurl = $("#txtBaseUrl").val();

$(document).ready(function () {
    
    $('body').on('hidden.bs.modal', function () {
        if ($('.modal.in').length > 0) {
            $('body').addClass('modal-open');
        }
    });

    $('.btnNewHrPersonalInfo').hide();
    $('.btnClearLandingSearch').hide();


    $('#militarynokw').keypress(function (e) {
        var key = e.which;
        if (key == 13)  // the enter key code
        {
            $('#btnLandingSearch').trigger('click');
            return false;
        }
    }); 

});

$('body').on('click', '#btnLandingSearch', function (event) {
    try {
        
        if ($.trim($("#militarynokw").val()) == '') {
            isValid = false;

            $('#militarynokw').each(function () {
                $(this).css({
                    "border": "1px solid red"
                });
            });

            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: "Please enter Military No (KW).",
                type: 'red'
            });
            return;
        }
        else {
            isValid = true;
            $('#militarynokw').each(function () {
                $(this).css({
                    "border": ""
                });
            });

            $('#militarynokw').attr('disabled', 'disabled');
            $('.btnClearLandingSearch').show();

            GetDataHrBasicProfile();
            GetAllDataHrPersonalInfo();   
            

        }
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
});
function GetDataHrBasicProfile() {
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
            methodname: "HrPersonalInfoTableData",
            currenturl: window.location.href,
            militarynokw: $('#militarynokw').val()
        });
        $.ajax({
            url: baseurl + "HrPersonalInfo/GetAllHrBasicProfileData?militaryno=" + $('#militarynokw').val(),
            type: 'POST',
            data: null,
            success: function (response) {
                var data = response.data;
                var status = response.status;
                var msg = response.responsetext;

                if (data != "" && status== 'success') {
                    $('#militarynobd').val(data[0].militarynobd);
                    $('#civilid').val(data[0].civilid);
                    $('#passportno').val(data[0].passportno);
                    $('#fullname').val(data[0].fullname);
                }
                else {
                    $.alert({
                        title: _getCookieForLanguage("_informationTitle"),
                        content: msg,
                        type: 'red'
                    });
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

$('body').on('click', '#btnClearLandingSearch', function (event) {
    $('#militarynokw').val('');
    $('#militarynobd').val('');
    $('#civilid').val('');
    $('#passportno').val('');
    $('#fullname').val('');
    $('#HrPersonalInfoDt').empty();
    $('#militarynokw').prop('disabled', false);
    $('.btnClearLandingSearch').hide();
    $('.btnNewHrPersonalInfo').hide();
});

function GetAllDataHrPersonalInfo() {
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
            methodname: "HrPersonalInfoTableData",
            currenturl: window.location.href,
            militarynokw: $('#militarynokw').val()
        });

        $('#HrPersonalInfoDt').DataTable({
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
                "url": baseurl + "HrPersonalInfo/HrPersonalInfoTableData",
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

                { "data": "militarynokw", "searchable": true, "sortable": true, "orderable": true },
                { "data": "strstatus", "searchable": true, "sortable": true, "orderable": true },
                {
                    "data": "ex_nvarchar1",
                    "render": function (data, type, full, meta) {
                        return data;
                    }
                }
            ],
            "drawCallback": function (settings) {
                var rowCount = $('#HrPersonalInfoDt').DataTable().rows().count();
                if (rowCount == 0) $('.btnNewHrPersonalInfo').show();
                    else $('.btnNewHrPersonalInfo').hide();
                /*show pager if only necessary
                console.log(this.fnSettings());*/
                if (Math.ceil((this.fnSettings().fnRecordsDisplay()) / this.fnSettings()._iDisplayLength) > 1) {
                    $('#HrPersonalInfoDt_paginate').css("display", "block");
                } else {
                    $('#HrPersonalInfoDt_paginate').css("display", "none");
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

$('body').on('click', '#btnNewHrPersonalInfo', function (event) {
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
            methodname: "HrPersonalInfoNew",
            currenturl: window.location.href,
            militarynokw: $('#militarynokw').val()
        });
        
        $.ajax({
            url: baseurl + "HrPersonalInfo/HrPersonalInfoNew",
            type: 'POST',
            data: input,
            success: function (response) {

                if (response != null && response.status == "failed") {
                    $.alert({
                        title: _getCookieForLanguage("_informationTitle"),
                        content: "Invalid Military Number. Please try again.",
                        type: 'red'
                    });  
                }
                else {
                    $('#mcHrPersonalInfoNew').html('');
                    $('#mcHrPersonalInfoNew').html(response);
                    $('#modal-container-HrPersonalInfoNew').modal({ backdrop: 'static', keyboard: false });
                   
                }
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



$('body').on('click', '#btnDeleteHrPersonalInfo', function (event) {
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
                    methodname: "HrPersonalInfoDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: $("#strModelPrimaryKey").val(),
                });


                $.ajax({
                    url: baseurl + "HrPersonalInfo/HrPersonalInfoDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                //window.location.href = baseurl + "HrPersonalInfo/HrPersonalInfo";
                                GetAllDataHrPersonalInfo();
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



function HrPersonalInfoEdit(val) {
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
            methodname: "HrPersonalInfoEdit",
            currenturl: window.location.href,
            strModelPrimaryKey: val,
            militarynokw: $('#militarynokw').val()
        });
        
        $.ajax({
            url: baseurl + "HrPersonalInfo/HrPersonalInfoEdit",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrPersonalInfoEdit').html('');
                $('#mcHrPersonalInfoEdit').html(response);
                $('#modal-container-HrPersonalInfoEdit').modal({backdrop: 'static',keyboard: false});
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

function HrPersonalInfoDelete(val) {
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
                    methodname: "HrPersonalInfoDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: val
                });


                $.ajax({
                    url: baseurl + "HrPersonalInfo/HrPersonalInfoDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                GetAllDataHrPersonalInfo();
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

function HrPersonalInfoDetail(val) {
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
            methodname: "HrPersonalInfoDetail",
            currenturl: window.location.href,
            strModelPrimaryKey: val,
            militarynokw: $('#militarynokw').val()
        });
        console.log(input);
        $.ajax({
            url: baseurl +  "HrPersonalInfo/HrPersonalInfoDetail",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrPersonalInfoDetail').html('');
                $('#mcHrPersonalInfoDetail').html(response);
                $('#modal-container-HrPersonalInfoDetail').modal({backdrop: 'static',keyboard: false});
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


function HrDocumentUpload(val) {
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
            methodname: "HrDocumentUpload",
            strModelPrimaryKey: val,
            currenturl: window.location.href
        });

        $.ajax({
            url: baseurl + "HrDocumentUpload/HrDocumentUpload",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrDocumentUploadLanding').html('');
                $('#mcHrDocumentUploadLanding').html(response);
                $('#modal-container-HrDocumentUploadLanding').modal({ backdrop: 'static', keyboard: false, class:".modal-lg" });

                GetAllDataHrDocumentUpload();
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


