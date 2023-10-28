

//PN: FILE NAME: "Loadarms_disbursementinfo.js"
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
    $("#txtStudentID").on('keyup', function (e) {
        if (e.keyCode === 13) {
            RegBasicInfoDetail($("#txtStudentID").val());
        }
    });
    $("#txtArmsCode").on('keyup', function (e) {
        if (e.keyCode === 13) {
            GenArmsInfoDetail($("#txtArmsCode").val());
        }
    });


   // GetAllDataArmsDisbursementInfo();

    $('#btnAssignArmsReturn').click( function (event) {
        try {
            event.preventDefault();
            var form = $('#frmArms_DisbursementInfoCustom');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);


            if (form.valid()) {


                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "ArmsDisbursementInfoUpdate",
                    currenturl: window.location.href,

                    armsdisbursementid: $('#armsdisbursementid').val(),
                    basicinfoid: $('#basicinfoid').val(),
                    armsid: $('#armsid').val(),
                    receivenote: $('#receivenote').val()
                    //issuedate: GetDateFromTextBox($('#issuedate').val()),
                    //issuedby: $('#issuedby').val(),
                    //returndate: GetDateFromTextBox($('#returndate').val()),
                    //returnby: $('#returnby').val(),
                    //issuenote: $('#issuenote').val(),
                    //receivenote: $('#receivenote').val(),


                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"),"Are you sure to Return this Arm?", _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "ArmsDisbursementInfo/ArmsDisbursementInfoUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            $("#txtStudentID").val('');
                                            $("#txtArmsCode").val('');
                                            $('#ArmsDisbursementInfoDt').empty();
                                            $('#mcGenArmsInfoDetail').html('');
                                            $('#mcRegBasicInfoDetail').html('');
                                            $('#mcRegBasicInfoDetail').addClass("hidden");
                                            $("#btnAssignArmsReturn").attr('disabled', 'disabled');
                                            $(".dvarmshistory").addClass('hidden');
                                            $('#receivenote').val('');
                                            $('#basicinfoid').val('');
                                            $('#armsid').val('');
                                        }

                                    });
                                }

                                else {
                                    return;
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
});

function GetAllDataArmsDisbursementInfo() {
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
            methodname: "ArmsDisbursementInfoTableData",
            currenturl: window.location.href,

            basicinfoid: $('#basicinfoid').val(),
            armsid: $('#armsid').val(),
            ex_bigint1: 1
        });

        $('#ArmsDisbursementInfoDt').DataTable({
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
                "url": baseurl + "ArmsDisbursementInfo/ArmsDisbursementInfoTableData",
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
               
                {
                    "data": "armsdisbursementid",
                    "className": "hidden"
                },
                { "data": "studentid", "searchable": true, "sortable": true, "orderable": true },
                { "data": "studentfullname", "searchable": true, "sortable": true, "orderable": true },
                { "data": "armsname", "searchable": true, "sortable": true, "orderable": true },
                {
                    "data": "armscode",
                    "className": "hidden"
                },
                { "data": "isM16", "searchable": true, "sortable": true, "orderable": true },
                { "data": "issuedbyusername", "searchable": true, "sortable": true, "orderable": true },
                {
                    "data": "issuedate",
                    "render": function (data, type, full, meta) {
                        return datetoStr(data);
                    }
                }
               
                //{
                //    "data": "ex_nvarchar1",
                //    "render": function (data, type, full, meta) {
                //        return data;
                //    }
                //}
            ],
            "drawCallback": function (settings) {

                /*show pager if only necessary
                console.log(this.fnSettings());*/
                if (Math.ceil((this.fnSettings().fnRecordsDisplay()) / this.fnSettings()._iDisplayLength) > 1) {
                    $('#ArmsDisbursementInfoDt_paginate').css("display", "block");
                } else {
                    $('#ArmsDisbursementInfoDt_paginate').css("display", "none");
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


function RegBasicInfoDetail(val) {
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
            methodname: "RegBasicInfoDetailByStudentID",
            currenturl: window.location.href,
            strModelPrimaryKey: val,
            ex_bigint1: 2//check student already has arms or not
        });

        $.ajax({
            url: baseurl + "RegBasicInfo/RegBasicInfoDetailByStudentID",
            type: 'POST',
            data: input,
            success: function (response) {
                if (response.status != null) {
                    inforamtionDialog("Error", response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                        if (answer == "true") {
                            $('#mcRegBasicInfoDetail').html('');
                            $("#btnAssignArms").attr('disabled', 'disabled');
                            $("#txtStudentID").val('');
                            $("#txtStudentID").focus();
                        }
                    });
                }
                else {
                    $('#mcRegBasicInfoDetail').removeClass('hidden');
                    $('#mcRegBasicInfoDetail').html('');
                    $('#mcRegBasicInfoDetail').html(response);
                    $("#txtArmsCode").focus();
                }
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


function GenArmsInfoDetail(val) {
    try {

        GetAllDataArmsDisbursementInfo();

       

        AddAntiForgeryToken = function (data) {
            data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
            return data;
        };

        var input = AddAntiForgeryToken({
            token: $(".txtUserSTK").val(),
            userinfo: $(".txtServerUtilObj").val(),
            useripaddress: $(".txtuserip").val(),
            sessionid: $(".txtUserSes").val(),
            methodname: "GenArmsInfoDetailByArmsCode",
            currenturl: window.location.href,
            strModelPrimaryKey: val,
            ex_bigint1: 1 //check isAvailed=null or false
        });

        $.ajax({
            url: baseurl + "GenArmsInfo/GenArmsInfoDetailByArmsCode",
            type: 'POST',
            data: input,
            success: function (response) {

                if (response.status != null) {
                    inforamtionDialog("Error", response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {

                        if (answer == "true") {
                            $('#mcGenArmsInfoDetail').html('');
                            $("#btnAssignArmsReturn").attr('disabled', 'disabled');
                            $(".dvarmshistory").addClass('hidden');
                            $("#txtStudentID").val('');
                            $("#txtArmsCode").val('');
                        }
                    });
                }
                else {

                    $('#mcGenArmsInfoDetail').html('');
                    $('#mcGenArmsInfoDetail').html(response);
                    $('#mcRegBasicInfoDetail').removeClass("hidden");
                    $("#btnAssignArmsReturn").removeAttr('disabled');
                    $(".dvarmshistory").removeClass('hidden');

                    if ($('#ArmsDisbursementInfoDt').DataTable().rows(0).data()[0].armscode != $("#txtArmsCode").val()) {

                        inforamtionDialog("Error", "This Arm was not Issued for this Student", _getCookieForLanguage("_btnOK")).then(function (answer) {

                            if (answer == "true") {
                                $("#txtArmsCode").val('');
                                $('#ArmsDisbursementInfoDt').empty();
                                $('#mcGenArmsInfoDetail').html('');
                            }
                        });
                    }
                    else {
                        $("#armsdisbursementid").val($('#ArmsDisbursementInfoDt').DataTable().rows(0).data()[0].armsdisbursementid);
                    }
                }
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




