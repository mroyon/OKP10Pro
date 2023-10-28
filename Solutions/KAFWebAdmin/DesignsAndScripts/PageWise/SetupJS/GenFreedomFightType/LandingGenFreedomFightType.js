

//PN: FILE NAME: "Loadgen_freedomfighttype.js"
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

    GetAllDataGenFreedomFightType();
});
function GetAllDataGenFreedomFightType() {
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
            methodname: "GenBatchTableData",
            currenturl: window.location.href
        });

        $('#GenFreedomFightTypeDt').DataTable({
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
                "url": baseurl + "GenFreedomFightType/GenFreedomFightTypeTableData",
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

                { "data": "freedomfight", "searchable": true, "sortable": true, "orderable": true },
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
                    $('#GenFreedomFightTypeDt_paginate').css("display", "block");
                } else {
                    $('#GenFreedomFightTypeDt_paginate').css("display", "none");
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
//function GetAllDataGenFreedomFightType() {
//    try {
//        AddAntiForgeryToken = function (data) {
//            data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
//            return data;
//        };

//        var input = AddAntiForgeryToken({
//            token: $(".txtUserSTK").val(),
//            userinfo: $(".txtServerUtilObj").val(),
//            useripaddress: $(".txtuserip").val(),
//            sessionid: $(".txtUserSes").val(),
//            methodname: "GenFreedomFightTypeTableData",
//            currenturl: window.location.href
//        });
        
//        $('#GenFreedomFightTypeDt').DataTable({
//            "destroy": true,
//            "bFilter": true,
//            "columnDefs": [{
//                "targets": 0,
//                "searchable": true,
//                "orderable": true
//            }],
//            "language":
//            {
//                "processing": "<div class='overlay custom-loader-background'><i class='fa fa-cog fa-spin custom-loader-color'></i></div>"
//            },
//            "processing": true,
//            "serverSide": true,
//            "autoWidth": false,
//            "responsive": true,
//            "ajax": {
//                "url": baseurl + "GenFreedomFightType/GenFreedomFightTypeTableData",
//                "type": "POST",
//                "data": input
//            },
//            error: function (jqXHR, textStatus, errorThrown) {
//                $.alert({
//                    title: _getCookieForLanguage("_informationTitle"),
//                    content: jqXHR.responseJSON.Error,
//                    type: 'red'
//                });
//            },
//            "columns": [
            
//				 { "data": "freedomfight", "searchable": true, "sortable": true, "orderable": true },//                {
//                    "data": "ex_nvarchar1",
//                    "render": function (data, type, full, meta) {
//                        return data;
//                    }
//                }
//            ],
//            "drawCallback": function (settings) {

//                /*show pager if only necessary
//                console.log(this.fnSettings());*/
//                if (Math.ceil((this.fnSettings().fnRecordsDisplay()) / this.fnSettings()._iDisplayLength) > 1) {
//                    $('#GenFreedomFightTypeDt_paginate').css("display", "block");
//                } else {
//                    $('#GenFreedomFightTypeDt_paginate').css("display", "none");
//                }

//            }
//        });
//    } catch (e) {
//        $.alert({
//            title: _getCookieForLanguage("_informationTitle"),
//            content: e,
//            type: 'red'
//        });
//    }
//}

$('body').on('click', '#btnNewGenFreedomFightType', function (event) {
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
            methodname: "GenFreedomFightTypeNew",
            currenturl: window.location.href
        });
        
        $.ajax({
            url: baseurl + "GenFreedomFightType/GenFreedomFightTypeNew",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcGenFreedomFightTypeNew').html('');
                $('#mcGenFreedomFightTypeNew').html(response);
                $('#modal-container-GenFreedomFightTypeNew').modal({backdrop: 'static',keyboard: false});
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



$('body').on('click', '#btnDeleteGenFreedomFightType', function (event) {
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
                    methodname: "GenFreedomFightTypeDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: $("#strModelPrimaryKey").val(),
                });


                $.ajax({
                    url: baseurl + "GenFreedomFightType/GenFreedomFightTypeDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                //window.location.href = baseurl + "GenFreedomFightType/GenFreedomFightType";
                                GetAllDataGenFreedomFightType();
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



function GenFreedomFightTypeEdit(val) {
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
            methodname: "GenFreedomFightTypeEdit",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });
        
        $.ajax({
            url: baseurl + "GenFreedomFightType/GenFreedomFightTypeEdit",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcGenFreedomFightTypeEdit').html('');
                $('#mcGenFreedomFightTypeEdit').html(response);
                $('#modal-container-GenFreedomFightTypeEdit').modal({backdrop: 'static',keyboard: false});
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

function GenFreedomFightTypeDelete(val) {
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
                    methodname: "GenFreedomFightTypeDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: val
                });


                $.ajax({
                    url: baseurl + "GenFreedomFightType/GenFreedomFightTypeDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                GetAllDataGenFreedomFightType();
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

function GenFreedomFightTypeDetail(val) {
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
            methodname: "GenFreedomFightTypeDetail",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });

        $.ajax({
            url: baseurl +  "GenFreedomFightType/GenFreedomFightTypeDetail",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcGenFreedomFightTypeDetail').html('');
                $('#mcGenFreedomFightTypeDetail').html(response);
                $('#modal-container-GenFreedomFightTypeDetail').modal({backdrop: 'static',keyboard: false});
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


