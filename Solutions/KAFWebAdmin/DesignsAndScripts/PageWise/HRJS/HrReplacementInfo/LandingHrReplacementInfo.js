

//PN: FILE NAME: "Loadhr_replacementinfo.js"
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

    GetAllDataHrReplacementInfo();
});

function GetAllDataHrReplacementInfo() {
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
            methodname: "HrReplacementInfoTableData",
            currenturl: window.location.href
        });

        $('#HrReplacementInfoDt').DataTable({
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
                "url": baseurl + "HrReplacementInfo/HrReplacementInfoTableData",
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

                { "data": "letterno", "searchable": true, "sortable": true, "orderable": true },
                {
                    "data": "letterdate",
                    "render": function (data, type, full, meta) {
                        return datetoStr(data);
                    }
                },
                { "data": "totalperson", "searchable": true, "sortable": true, "orderable": true },
                { "data": "ex_nvarchar2", "searchable": true, "sortable": true, "orderable": true },
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
                    $('#HrReplacementInfoDt_paginate').css("display", "block");
                } else {
                    $('#HrReplacementInfoDt_paginate').css("display", "none");
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


function DownloadData(val,letterstatus) {
    try {
        var searchText = "&letterstatus=" + letterstatus + "&masterid=" + val;

        var src = '../Reports/DownloadReportPhaseWise.aspx?';
        //We can add parameters here
        src = src + searchText

        var iframe = '<iframe id="myReportFrame" width="100%" height="800px" scrolling="no" frameborder="0" src="' + src + '" allowfullscreen></iframe>';
      //  $("#divReport").html(iframe);

        $('#mcHrReplacementInfoDetail').html('');
        $('#mcHrReplacementInfoDetail').html(iframe);
        $('#modal-container-HrReplacementInfoDetail').modal({ backdrop: 'static', keyboard: false });

    }
    catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
}


$('body').on('click', '#btnNewHrReplacementInfo', function (event) {
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
            methodname: "HrReplacementInfoNew",
            currenturl: window.location.href
        });

        $.ajax({
            url: baseurl + "HrReplacementInfo/HrReplacementInfoNew",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrReplacementInfoNew').html('');
                $('#mcHrReplacementInfoNew').html(response);
                $('#modal-container-HrReplacementInfoNew').modal({ backdrop: 'static', keyboard: false });
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

$('body').on('click', '#btnDeleteHrReplacementInfo', function (event) {
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
                    methodname: "HrReplacementInfoDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: $("#strModelPrimaryKey").val(),
                });


                $.ajax({
                    url: baseurl + "HrReplacementInfo/HrReplacementInfoDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                //window.location.href = baseurl + "HrReplacementInfo/HrReplacementInfo";
                                GetAllDataHrReplacementInfo();
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

function HrReplacementInfoEdit(val) {
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
            methodname: "HrReplacementInfoEdit",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });

        $.ajax({
            url: baseurl + "HrReplacementInfo/HrReplacementInfoEdit",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrReplacementInfoEdit').html('');
                $('#mcHrReplacementInfoEdit').html(response);
                $('#modal-container-HrReplacementInfoEdit').modal({ backdrop: 'static', keyboard: false });
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

function HrReplacementInfoDelete(val) {
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
                    methodname: "HrReplacementInfoDelete",
                    currenturl: window.location.href,
                    strModelPrimaryKey: val
                });


                $.ajax({
                    url: baseurl + "HrReplacementInfo/HrReplacementInfoDelete",
                    data: input,
                    type: 'POST',
                    success: function (response) {
                        if (response.status == "success") {
                            inforamtionDialog(response.title, response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                GetAllDataHrReplacementInfo();
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

function HrReplacementInfoDetail(val) {
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
            methodname: "HrReplacementInfoDetail",
            currenturl: window.location.href,
            strModelPrimaryKey: val
        });

        $.ajax({
            url: baseurl + "HrReplacementInfo/HrReplacementInfoDetail",
            type: 'POST',
            data: input,
            success: function (response) {
                $('#mcHrReplacementInfoDetail').html('');
                $('#mcHrReplacementInfoDetail').html(response);
                $('#modal-container-HrReplacementInfoDetail').modal({ backdrop: 'static', keyboard: false });
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

function datetoStr(data) {
    if (data != null) {
        var regex = /-?\d+/;
        var match = regex.exec(data);
        var pubdate = new Date(parseInt(match[0]));

        var dd = pubdate.getDate(); var mm = pubdate.getMonth() + 1;
        var yyyy = pubdate.getFullYear();

        if (dd < 10) { dd = '0' + dd }

        if (mm < 10) { mm = '0' + mm }

        var today = dd + '/' + mm + '/' + yyyy;// + ' ' + pubdate.getHours() + ':' + pubdate.getMinutes() + ':' + pubdate.getSeconds();
        return today;
    }
    else {
        return "";
    }
}

function getMilPersonalInfo(currentcntl) {
    try {

        if ($(currentcntl).val().length == 0) {
            return;
        }

        // $("#GenReplacementDt").find(".btn-danger").attr("disabled", "disabled");

        AddAntiForgeryToken = function (data) {
            data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
            return data;
        };
        var input = AddAntiForgeryToken({
            token: $(".txtUserSTK").val(),
            userinfo: $(".txtServerUtilObj").val(),
            useripaddress: $(".txtuserip").val(),
            sessionid: $(".txtUserSes").val(),
            methodname: "HrReplacementInfoNew",
            currenturl: window.location.href,
            milnokw: $(currentcntl).val(),
            IsAll: 1
        });


        var currentrowindex = $(currentcntl).parent().parent().index() - 1;

        var isDublicate = 0;

        $("#GenReplacementDt .txtMilNo").each(function (index) {
            //console.log(index + ": " + $(this).text());
            if (index != currentrowindex && !$(this).parent().parent().hasClass("hidden")) {

                if ($(currentcntl).val() == $(this).val() && $(this).val().length > 0) {
                    isDublicate = 1;
                    return false;
                }
            }

        });

        if (isDublicate == 1) {
            inforamtionDialog("Alert", "Military Number Already Exists", _getCookieForLanguage("_btnOK")).then(function (answer) {
                if (answer == "true") {
                    setTimeout(function () { $(currentcntl).focus(); $(currentcntl).val(''); }, 300);

                }
            });
        }
        else {
            $.ajax({
                url: $("#txtBaseUrl").val() + "Common/GetReplacementListByReplacementID",
                type: 'POST',
                data: input,
                success: function (response) {
                    if (response.status = "success" && response.totalrows > 0) {

                        $(currentcntl).parent().parent().find('.lblRankName').text(response.data[0].KuwaitiRank);
                        $(currentcntl).parent().parent().find(".lblName").text(response.data[0].fullname);
                        $(currentcntl).parent().parent().find(".lblAppt").text(response.data[0].KuwaitiTrade);
                        $(currentcntl).parent().parent().find(".lblOKP").text(response.data[0].OkpName);
                        $(currentcntl).parent().parent().find(".btn-danger").removeClass("hidden");
                        $("#GenReplacementDt").find(".btn-danger").removeAttr("disabled");

                        $(currentcntl).attr("hrbasicid", response.data[0].HRBasicID);
                        $(currentcntl).attr("hrsvcid", response.data[0].HrSvcID);

                        $(currentcntl).attr("operation", typeof $(currentcntl).attr("operation") == 'undefined' ? "added" : "changed");

                        //if ($(currentcntl).parent().parent().index() == ($(currentcntl).parent().parent().parent().find('tr').length-1))
                        if ($("#GenReplacementDt tr").length == 1 || ($("#GenReplacementDt tr").length > 1 && $("#GenReplacementDt tr").last().find('.txtMilNo').val().length > 0))
                            HrReplacementNewRow();
                    }
                    else {
                        $(currentcntl).parent().parent().find(".btn-danger").addClass("hidden");
                        $(currentcntl).parent().parent().find(".btn-danger").attr("disabled", "disabled");
                        $(currentcntl).parent().parent().find('.lblRankName').text('');
                        $(currentcntl).parent().parent().find(".lblName").text('');
                        $(currentcntl).parent().parent().find(".lblAppt").text('');
                        $(currentcntl).parent().parent().find(".lblOKP").text('');

                        $(currentcntl).attr("hrbasicid", '');
                        $(currentcntl).attr("hrsvcid", '');
                        $(currentcntl).attr("operation", "");

                        inforamtionDialog("Alert", "Invalid Military Number", _getCookieForLanguage("_btnOK")).then(function (answer) {
                            if (answer == "true") {
                                setTimeout(function () { $(currentcntl).focus(); $(currentcntl).val(''); }, 300);
                            }
                        });
                    }
                }
            });
        }

    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
}

function HrReplacementNewRow() {
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
            methodname: "HrReplacementInfoEdit",
            currenturl: window.location.href
        });

        $.ajax({
            url: baseurl + "HrReplacementInfo/HrReplacementSignleRow",
            type: 'POST',
            data: input,
            success: function (response) {

                $('#GenReplacementDt tr:last').after(response);
                $('#GenReplacementDt tr:last').find('.txtMilNo').focus();


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

function getMilPersonalList(type) {
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
            methodname: "HrReplacementInfoNew",
            currenturl: window.location.href,
            replacementid: $("#replacementid").val(),
            IsAll: 1
        });



        $.ajax({
            url: $("#txtBaseUrl").val() + "Common/GetReplacementListByReplacementID",
            type: 'POST',
            data: input,
            success: function (response) {
                if (response.status = "success" && response.totalrows > 0) {

                    $(response.data).each(function (index) {
                        // console.log(index + ": " + $(this).text());
                        var strdisabled = $(response.data[index].LetterStatus).attr("leterstatusid") != 1 ? "disabled='disabled'" : "";

                        $('#GenReplacementDt tr:last').after("<tr role='row'>" +
                            "<td><input value='" + response.data[index].milnokw + "' detailid='" + response.data[index].ReplacementDetlID + "'  type='text' class='form-control txtMilNo' onchange='getMilPersonalInfo(this)' hrbasicid='" + response.data[index].hrbasicid + "' hrsvcid='" + response.data[index].hrsvcid + "'  hrbasicid_prev='" + response.data[index].hrbasicid + "' hrsvcid_prev='" + response.data[index].hrsvcid + "'></td>" +
                            "<td class='lblRankName'>" + response.data[index].KuwaitiRank + "</td>" +
                            "<td class='lblName'>" + response.data[index].fullname + "</td>" +
                            "<td class='lblAppt'>" + response.data[index].KuwaitiTrade + "</td>" +
                            "<td class='lblOKP'>" + response.data[index].OkpName + "</td>" +
                            "<td class='lblletterstatus'>" + response.data[index].LetterStatus + "</td>" +
                            
                            "<td>" +
                            "<div class='btn-toolbar pull-right' role='toolbar'>" +
                            "<button class='btn btn-danger btn-md' onclick='HrReplacementDeleteDetail(this)' " + strdisabled+"><i class='fa fa-trash'></i> Delete</button>" +
                            "</div>" +
                            "</td > " +
                            "</tr>");
                    });


                    if (type == 1)
                        HrReplacementNewRow();
                }
                else {
                    if (type == 1)
                        HrReplacementNewRow();
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
}

function HrReplacementDeleteDetail(cntl) {
    try {

        $(cntl).parent().parent().parent().addClass("hidden");

        $(cntl).parent().parent().parent().find(".txtMilNo").attr("operation", "delete");


    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
}

