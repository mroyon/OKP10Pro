

//PN: FILE NAME: "Loadgen_authorizestrength.js"
var baseurl = $("#txtBaseUrl").val();

$(document).ready(function () {

    //$(".modal").on("hidden.bs.modal", function () {
    //    $(".modal-body").html("");
    //});
    $('body').on('hidden.bs.modal', function () {
        if ($('.modal.in').length > 0) {
            $('body').addClass('modal-open');
        }
    });

    GetAllDataGenAuthorizeStrength();

    
});

function GetAllDataGenAuthorizeStrength() {
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
            methodname: "GenAuthorizeStrengthTableData",
            currenturl: window.location.href
        });
        
        $('#GenAuthorizeStrengthDt').DataTable({
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
                "url": baseurl + "GenAuthorizeStrength/GenAuthorizeStrengthTableData",
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
            
                { "data": "okpName", "searchable": true, "sortable": true, "orderable": true },                {
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
                    $('#GenAuthorizeStrengthDt_paginate').css("display", "block");
                } else {
                    $('#GenAuthorizeStrengthDt_paginate').css("display", "none");
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

$('body').on('click', '#btnNewGenAuthorizeStrength', function (event) {
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
            methodname: "GenAuthorizeStrengthNew",
            currenturl: window.location.href
        });
        
        $.ajax({
            url: baseurl + "GenAuthorizeStrength/GenAuthorizeStrengthNew",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcGenAuthorizeStrengthNew').html('');
                $('#mcGenAuthorizeStrengthNew').html(response);
                $('#modal-container-GenAuthorizeStrengthNew').modal({ backdrop: 'static', keyboard: false });
               
                GenAuthorizeStrengthNewRow(null);
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



$('body').on('click', '#btnDeleteGenAuthorizeStrength', function (event) {
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
                    methodname: "GenAuthorizeStrengthDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: $("#strModelPrimaryKey").val(),
                });


                $.ajax({
                    url: baseurl + "GenAuthorizeStrength/GenAuthorizeStrengthDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                //window.location.href = baseurl + "GenAuthorizeStrength/GenAuthorizeStrength";
                                GetAllDataGenAuthorizeStrength();
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



function GenAuthorizeStrengthEdit(val) {
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
            methodname: "GenAuthorizeStrengthEdit",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });
        
        $.ajax({
            url: baseurl + "GenAuthorizeStrength/GenAuthorizeStrengthEdit",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcGenAuthorizeStrengthEdit').html('');
                $('#mcGenAuthorizeStrengthEdit').html(response);
                $('#modal-container-GenAuthorizeStrengthEdit').modal({ backdrop: 'static', keyboard: false });
                console.log($('#okpid').val());

                GetAllDataAuthStrengthDetailsByOKPID(val);

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

function GenAuthorizeStrengthDelete(val) {
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
                    methodname: "GenAuthorizeStrengthDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: val
                });


                $.ajax({
                    url: baseurl + "GenAuthorizeStrength/GenAuthorizeStrengthDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                GetAllDataGenAuthorizeStrength();
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

function GenAuthorizeStrengthDetail(val) {
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
            methodname: "GenAuthorizeStrengthDetail",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });

        $.ajax({
            url: baseurl +  "GenAuthorizeStrength/GenAuthorizeStrengthDetail",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcGenAuthorizeStrengthDetail').html('');
                $('#mcGenAuthorizeStrengthDetail').html(response);
                $('#modal-container-GenAuthorizeStrengthDetail').modal({backdrop: 'static',keyboard: false});
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



function GenAuthorizeStrengthNewRow(cntl) {
    try {
        AddAntiForgeryToken = function (data) {
            data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
            return data;
        };

        var currentrowindex = $("#GenAuthorizeStrengthDtNew tr").length;
        //console.log(currentrowindex);
        //alert(currentrowindex);
        $(cntl).parent().find('.btnadd').addClass('hidden');

        //if (currentrowindex < 2) $(cntl).parent().find('.btndelete').addClass('hidden');
        //else $(cntl).parent().find('.btndelete').removeClass('hidden');

        var input = AddAntiForgeryToken({
            token: $(".txtUserSTK").val(),
            userinfo: $(".txtServerUtilObj").val(),
            useripaddress: $(".txtuserip").val(),
            sessionid: $(".txtUserSes").val(),
            methodname: "GenAuthorizeStrengthEdit",
            currenturl: window.location.href,
            authstrengthid: currentrowindex
        });

        $.ajax({
            url: baseurl + "GenAuthorizeStrength/GenAuthorizeStrengthSignleRow",
            type: 'POST',
            data: input,
            success: function (response) {

                $('#GenAuthorizeStrengthDtNew tbody').append(response);
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

function GetAllDataAuthStrengthDetailsByOKPID(val) {
    try {
        AddAntiForgeryToken = function (data) {
            data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
            return data;
        };
        //console.log($('#okpid').val());
        //console.log($('.okpid').val());

        //if (val != null) {
        //    $('#GenAuthorizeStrengthDtNew tbody').addClass("hidden");
        //}

        var input = AddAntiForgeryToken({
            token: $(".txtUserSTK").val(),
            userinfo: $(".txtServerUtilObj").val(),
            useripaddress: $(".txtuserip").val(),
            sessionid: $(".txtUserSes").val(),
            methodname: "GenAuthorizeStrengthDetailsByOKPID",
            currenturl: window.location.href,
            strModelPrimaryKey: val,
            okpid: $('#okpid').val()
        });

        $.ajax({
            url: baseurl + "GenAuthorizeStrength/GenAuthorizeStrengthDetailsByOKPID",
            type: 'POST',
            data: input,
            success: function (response) {
                if (response != null) {
                    var data = response.data;
                    var i = 0;
                    var index = 1;

                    if (response.data.length > 0) $('#GenAuthorizeStrengthDtNew tbody tr').remove();;

                    for (var rowIndex = 1; rowIndex <= response.data.length; rowIndex++) {
                        //console.log(response.data[i].rankid);

                        var input = AddAntiForgeryToken({
                            token: $(".txtUserSTK").val(),
                            userinfo: $(".txtServerUtilObj").val(),
                            useripaddress: $(".txtuserip").val(),
                            sessionid: $(".txtUserSes").val(),
                            methodname: "GenAuthorizeStrengthSignleRow",
                            currenturl: window.location.href,
                            authstrengthid: rowIndex,
                            rankid: response.data[i].rankid,
                            groupid: response.data[i].groupid,
                            authstrength: response.data[i].authstrength,
                        });


                        $.ajax({
                            url: baseurl + "GenAuthorizeStrength/GenAuthorizeStrengthSignleRow",
                            type: 'POST',
                            data: input,
                            success: function (response) {
                                $('#GenAuthorizeStrengthDtNew tbody').append(response);
                                //$(".btnnerow").css("display", "none");
                            }
                        });

                        i++;
                        index++;
                    }
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

function AuthorizeStrengthRowDelete(cntl) {
    try {
        //console.log($(cntl).parent().prev('tr').find('.btnadd'));
        //console.log($(cntl));
        //console.log($(cntl).parent().closest('tr').prev('.btnadd'));

        $(cntl).parent().parent().parent().prev('tr').find('.btnadd').removeClass('hidden');
        //alert($(cntl).parent().parent().parent().prev('tr').find('.btnadd').length);
        //console.log($(cntl).parent().closest('tr').prev('.btnadd').text());
        //$(cntl).parent().find('.btnadd').removeClass('hidden');
        $(cntl).parent().parent().parent().addClass("hidden");
        $(cntl).parent().parent().parent().find(".authstrengthid").attr("operation", "delete");
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
}



