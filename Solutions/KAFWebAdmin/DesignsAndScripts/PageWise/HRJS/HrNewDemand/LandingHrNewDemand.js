

//PN: FILE NAME: "Loadhr_newdemand.js"
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

    //$('.btnReportClose').click('click', '', function (event) {
    //    try {
    //        event.preventDefault();

    //        $('.reportmodal').modal('hide');
    //    } catch (e) {
    //        $.alert({
    //            title: _getCookieForLanguage("_informationTitle"),
    //            content: e.message,
    //            type: 'red'
    //        });
    //    }
    //});

    GetAllDataHrNewDemand();
    
});

function GetAllDataHrNewDemand() {
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
            methodname: "HrNewDemandTableData",
            currenturl: window.location.href
        });
        
        $('#HrNewDemandDt').DataTable({
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
                "url": baseurl + "HrNewDemand/HrNewDemandTableData",
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
            
                { "data": "demandletterno", "searchable": true, "sortable": true, "orderable": true },
                {
                    "data": "demandletterdate",
                    "render": function (data, type, full, meta) {
                        return datetoStr(data);
                    }
                },
                { "data": "totalperson", "searchable": true, "sortable": true, "orderable": true },
                { "data": "LetterStatus", "searchable": true, "sortable": true, "orderable": true }, 
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
                    $('#HrNewDemandDt_paginate').css("display", "block");
                } else {
                    $('#HrNewDemandDt_paginate').css("display", "none");
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

$('body').on('click', '#btnNewHrNewDemand', function (event) {
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
            methodname: "HrNewDemandNew",
            currenturl: window.location.href
        });
        
        $.ajax({
            url: baseurl + "HrNewDemand/HrNewDemandNew",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrNewDemandNew').html('');
                $('#mcHrNewDemandNew').html(response);
                $('#modal-container-HrNewDemandNew').modal({ backdrop: 'static', keyboard: false });

                HrNewDemandNewRow();


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



$('body').on('click', '#btnDeleteHrNewDemand', function (event) {
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
                    methodname: "HrNewDemandDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: $("#strModelPrimaryKey").val(),
                });


                $.ajax({
                    url: baseurl + "HrNewDemand/HrNewDemandDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                //window.location.href = baseurl + "HrNewDemand/HrNewDemand";
                                GetAllDataHrNewDemand();
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



function HrNewDemandEdit(val) {
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
            methodname: "HrNewDemandEdit",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });
        
        $.ajax({
            url: baseurl + "HrNewDemand/HrNewDemandEdit",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrNewDemandEdit').html('');
                $('#mcHrNewDemandEdit').html(response);
                $('#modal-container-HrNewDemandEdit').modal({ backdrop: 'static', keyboard: false });
                
                GetAllDataHrNewDemandDetails($('#newdemandid').val());
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

function HrNewDemandDelete(val) {
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
                    methodname: "HrNewDemandDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: val
                });


                $.ajax({
                    url: baseurl + "HrNewDemand/HrNewDemandDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                GetAllDataHrNewDemand();
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
function DownloadData(val, letterstatus) {
    try {
        var searchText = "&letterstatus=" + letterstatus + "&masterid=" + val;

        var src = '../Reports/DownloadReportPhaseWise.aspx?';
        //We can add parameters here
        src = src + searchText

        var iframe = '<iframe id="myReportFrame" width="100%" height="800px" scrolling="no" frameborder="0" src="' + src + '" allowfullscreen></iframe>';
        //  $("#divReport").html(iframe);

        $('#mcHrNewDemandDetail').html('');
        $('#mcHrNewDemandDetail').html(iframe);
        $('#modal-container-HrNewDemandDetail').modal({ backdrop: 'static', keyboard: false });

    }
    catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
}

function HrNewDemandDetail(val) {
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
            methodname: "HrNewDemandDetail",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });

        $.ajax({
            url: baseurl +  "HrNewDemand/HrNewDemandDetail",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrNewDemandDetail').html('');
                $('#mcHrNewDemandDetail').html(response);
                $('#modal-container-HrNewDemandDetail').modal({ backdrop: 'static', keyboard: false });
                GetAllDataHrNewDemandDetails($('#newdemandid').val());

                
                var indexes = 1;
                var trDemand = $('#NewDemandDtNew').parent().parent();

                $("#NewDemandDtNew .newdemanddetlid").each(function (index) {
                    trDemand.find('#rankidkw' + indexes).prop('disabled', true);
                    trDemand.find('#noofvacancies' + indexes).prop('disabled', true);
                    indexes++;
                });
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

function HrNewDemandNewRow(val) {
    try {

        AddAntiForgeryToken = function (data) {
            data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
            return data;
        };

        var currentrowindex = $("#NewDemandDtNew tr").length;

        var input = AddAntiForgeryToken({
            token: $(".txtUserSTK").val(),
            userinfo: $(".txtServerUtilObj").val(),
            useripaddress: $(".txtuserip").val(),
            sessionid: $(".txtUserSes").val(),
            methodname: "HrNewDemandEdit",
            currenturl: window.location.href,
            newdemandid: currentrowindex
        });

        $.ajax({
            url: baseurl + "HrNewDemand/HrNewDemandSignleRow",
            type: 'POST',
            data: input,
            success: function (response) {
               
                $('#NewDemandDtNew tbody').append(response);
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

function GetAllDataHrNewDemandDetails(val) {
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
            methodname: "HrNewDemandDetlTableData",
            currenturl: window.location.href,
            newdemandid: val
        });

        $.ajax({
            url: baseurl + "HrNewDemand/GetAllDataHrNewDemandDetails",
            type: 'POST',
            data: input,
            success: function (response) {
                if (response != null) {
                    var data = response.data;
                    var i = 0;
                    var index = 1;
                    for (var rowIndex = 1; rowIndex <= response.data.length; rowIndex++) {

                        var myData = [];
                        var inputdetl = AddAntiForgeryToken({
                            token: $(".txtUserSTK").val(),
                            userinfo: $(".txtServerUtilObj").val(),
                            useripaddress: $(".txtuserip").val(),
                            sessionid: $(".txtUserSes").val(),
                            methodname: "HrFamilyInfoCreate",
                            currenturl: window.location.href,

                            rankid: response.data[i].rankid,
                            tradeid: response.data[i].tradeid,
                            groupid: response.data[i].groupid,
                            okpid: response.data[i].okpid,
                            newdemanddetlid: response.data[i].newdemanddetlid,
                            hrbasicid: response.data[i].hrbasicid,
                            totalperson: response.data[i].totalperson,
                            noofvacancies: response.data[i].noofvacancies,
                            ex_nvarchar2: response.data[i].ex_nvarchar2
                        });

                        var input = AddAntiForgeryToken({
                            token: $(".txtUserSTK").val(),
                            userinfo: $(".txtServerUtilObj").val(),
                            useripaddress: $(".txtuserip").val(),
                            sessionid: $(".txtUserSes").val(),
                            methodname: "HrNewDemandEdit",
                            currenturl: window.location.href,
                            newdemandid: rowIndex,
                            hr_newdemanddetl: inputdetl
                        });
                        

                        $.ajax({
                            url: baseurl + "HrNewDemand/HrNewDemandSignleRow",
                            type: 'POST',
                            data: input,
                            success: function (response) {
                                $('#NewDemandDtNew tbody').append(response);
                                $(".btnnerow").css("display", "none");
                            }
                        });

                        $('#NewDemandDtNew tr').find("#newdemanddetlid" + index).val(data[i].newdemanddetlid);
                        //$('#NewDemandDtNew tr').find("#noofvacancies" + index).attr("min", data[i].totalperson);
                        //alert($('#NewDemandDtNew tr').find("#noofvacancies" + index).html());
                        //alert($('#NewDemandDtNew tr').find("#noofvacancies" + index).html());
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

function HrDemandDeleteDetail(cntl) {
    try {
        $(cntl).parent().parent().parent().addClass("hidden");
        $(cntl).parent().parent().parent().find(".newdemanddetlid").attr("operation", "delete");
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
    else {
        return "";
    }
}