$(document).ready(function () {

    $(".btn-slidesearchbasic").click(function () {
        $("#panelsearchbasic").slideToggle("slow");
        $(this).toggleClass("activesearchbasic"); return false;
    });

});

$(function () {
    $("#profilesearchpaneltabs").tabs();
});


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    $('#txtmilitarysearch_name').on('input', function (e) {
        $('#txtmilitarysearch_civilid,#txtmilitarysearch_militaryid,#txtmilitarysearch_name').each(function () {
            $(this).css({
                "border": "",
            });
        });
    });

    $('#txtmilitarysearch_militaryid').on('input', function (e) {
        $('#txtmilitarysearch_civilid,#txtmilitarysearch_militaryid,#txtmilitarysearch_name').each(function () {
            $(this).css({
                "border": "",
            });
        });
    });

    $('#txtmilitarysearch_name').on('input', function (e) {
        $('#txtmilitarysearch_civilid,#txtmilitarysearch_militaryid,#txtmilitarysearch_name').each(function () {
            $(this).css({
                "border": "",
            });
        });
    });

    $('body').on('click', '#btnmilitarysearch', function (event) {
        try {

            var isValid = true;

            if (($.trim($("#txtmilitarysearch_name").val()) == '') &&
                ($.trim($("#txtmilitarysearch_militaryid").val()) == '') &&
                ($.trim($("#txtmilitarysearch_civilid").val()) == '')) {
                isValid = false;

                $('#txtmilitarysearch_civilid,#txtmilitarysearch_militaryid,#txtmilitarysearch_name').each(function () {
                    $(this).css({
                        "border": "1px solid red",
                    });
                });

                $.alert({
                    title: _getCookieForLanguage("_informationTitle"),
                    content: "Please enter any one of the criteria.",
                    type: 'red'
                });
                return;
            }
            else {
                isValid = true;
                $('#txtmilitarysearch_civilid,#txtmilitarysearch_militaryid,#txtmilitarysearch_name').each(function () {
                    $(this).css({
                        "border": "",
                    });
                });
                $('#milsearchresult').empty();
                var str = '<table id="searchResultDt" class="table table-striped table-bordered searchResultDt" style="width:100%;"> </table>';
                $("#milsearchresult").append(str);
                GetSearchResultData();
            }
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }       
    });

    $('body').on('click', '#btnmilitarysearchclear', function (event) {
        try {
            //$('#searchResultDt tbody').empty();

            $("#txtmilitarysearch_name").val('');
            $("#txtmilitarysearch_militaryid").val('');
            $("#txtmilitarysearch_civilid").val('');
            $("#searchResultDt").DataTable().destroy(true);
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });



    $('body').on('click', '#btndelegatesearch', function (event) {
        try {

            var isValid = true;

            if (($.trim($("#txtdelegatesearch_name").val()) == '') &&
                ($.trim($("#txtdelegatesearch_civilid").val()) == '') &&
                ($.trim($("#txtdelegatesearch_militaryid").val()) == '')) {
                isValid = false;

                $('#txtdelegatesearch_civilid,#txtdelegatesearch_militaryid,#txtdelegatesearch_name').each(function () {
                    $(this).css({
                        "border": "1px solid red",
                    });
                });

                $.alert({
                    title: _getCookieForLanguage("_informationTitle"),
                    content: "Please enter any one of the criteria.",
                    type: 'red'
                });
                return;
            }
            else {
                isValid = true;
                $('#txtdelegatesearch_civilid,#txtdelegatesearch_militaryid,#txtdelegatesearch_name').each(function () {
                    $(this).css({
                        "border": "",
                    });
                });
                $('#milsearchresultDG').empty();
                var str = '<table id="searchResultDtDG" class="table table-striped table-bordered searchResultDtDG" style="width:100%;"> </table>';
                $("#milsearchresultDG").append(str);
                GetSearchResultDataDelegate();
            }
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });

    $('body').on('click', '#btndelegatesearchclear', function (event) {
        try {
            //$('#searchResultDt tbody').empty();

            $("#txtdelegatesearch_civilid").val('');
            $("#txtdelegatesearch_militaryid").val('');
            $("#txtdelegatesearch_name").val('');
            $("#searchResultDt").DataTable().destroy(true);
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });




    $('body').on('click', '#btncivilsearch', function (event) {
        try {

            var isValid = true;

            if (($.trim($("#txtcivilsearch_civilid").val()) == '') &&
                ($.trim($("#txtcivilsearch_name").val()) == '') && ($.trim($("#txtcivilsearch_empno").val()) == '') ) {
                isValid = false;

                $('#txtcivilsearch_civilid,#txtcivilsearch_name,#txtcivilsearch_empno').each(function () {
                    $(this).css({
                        "border": "1px solid red",
                    });
                });

                $.alert({
                    title: _getCookieForLanguage("_informationTitle"),
                    content: "Please enter any one of the criteria.",
                    type: 'red'
                });
                return;
            }
            else {
                isValid = true;
                $('#txtcivilsearch_civilid,#txtcivilsearch_name,#txtcivilsearch_empno').each(function () {
                    $(this).css({
                        "border": "",
                    });
                });
                $('#milsearchresultCV').empty();
                var str = '<table id="searchResultDtCV" class="table table-striped table-bordered searchResultDtCV" style="width:100%;"> </table>';
                $("#milsearchresultCV").append(str);
                GetSearchResultDataCivil();
            }
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });

    $('body').on('click', '#btncivilsearchclear', function (event) {
        try {
            //$('#searchResultDt tbody').empty();

            $("#txtcivilsearch_civilid").val('');
            $("#txtcivilsearch_name").val('');
            $("#milsearchresultCV").DataTable().destroy(true);
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });

    $('body').on('click', '#btnrecruitsearch', function (event) {
        try {

            var isValid = true;

            if (($.trim($("#txtrecruitsearch_civilid").val()) == '') &&
                ($.trim($("#txtrecruitsearch_name").val()) == '')) {
                isValid = false;

                $('#txtrecruitsearch_civilid,#txtrecruitsearch_name').each(function () {
                    $(this).css({
                        "border": "1px solid red",
                    });
                });

                $.alert({
                    title: _getCookieForLanguage("_informationTitle"),
                    content: "Please enter any one of the criteria.",
                    type: 'red'
                });
                return;
            }
            else {
                isValid = true;
                $('#txtrecruitsearch_civilid,#txtrecruitsearch_name').each(function () {
                    $(this).css({
                        "border": "",
                    });
                });
                $('#milsearchresultRec').empty();
                var str = '<table id="searchResultDtRec" class="table table-striped table-bordered searchResultDtRec" style="width:100%;"> </table>';
                $("#milsearchresultRec").append(str);
                GetSearchResultDataRecruitment();
            }
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });

    $('body').on('click', '#btnrecruitsearchclear', function (event) {
        try {
            //$('#searchResultDt tbody').empty();

            $("#txtrecruitsearch_civilid").val('');
            $("#txtrecruitsearch_name").val('');
            $("#milsearchresultRec").DataTable().destroy(true);
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });

    $('body').on('click', '#btnvolunteersearch', function (event) {
        try {

            var isValid = true;

            if (($.trim($("#txtvolunteersearch_civilid").val()) == '') &&
                ($.trim($("#txtvolunteersearch_name").val()) == '')) {
                isValid = false;

                $('#txtvolunteersearch_civilid,#txtvolunteersearch_name').each(function () {
                    $(this).css({
                        "border": "1px solid red",
                    });
                });

                $.alert({
                    title: _getCookieForLanguage("_informationTitle"),
                    content: "Please enter any one of the criteria.",
                    type: 'red'
                });
                return;
            }
            else {
                isValid = true;
                $('#txtvolunteersearch_civilid,#txtvolunteersearch_name').each(function () {
                    $(this).css({
                        "border": "",
                    });
                });
                $('#milsearchresultVol').empty();
                var str = '<table id="searchResultDtVol" class="table table-striped table-bordered searchResultDtVol" style="width:100%;"> </table>';
                $("#milsearchresultVol").append(str);
                GetSearchResultDataVolunteer();
            }
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });

    $('body').on('click', '#btnvolunteersearchclear', function (event) {
        try {
            //$('#searchResultDt tbody').empty();

            $("#txtvolunteersearch_civilid").val('');
            $("#txtvolunteersearch_name").val('');
            $("#milsearchresultRec").DataTable().destroy(true);
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });

});

function EditHRBasicProfile(val) {
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
            methodname: "MilitarySearch_TableData",
            currenturl: window.location.href,

            fullname: val
        });

        $.ajax({
            type: "POST",
            url: baseurl + "HRBasicProfile/HRBasicProfileUpdateIDSetAndLoad",
            data: input,
            success: function (response) {
                //console.log(response);
                window.location.href = baseurl + "home/hrOffIndex";
            },
            failure: function (response) {
                $.alert({
                    title: _getCookieForLanguage("_informationTitle"),
                    content: response.responseText,
                    type: 'red'
                });
            },
            error: function (response) {
                $.alert({
                    title: _getCookieForLanguage("_informationTitle"),
                    content: response.responseText,
                    type: 'red'
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
function EditHRBasicProfileCivil(val) {
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
            methodname: "MilitarySearch_TableData",
            currenturl: window.location.href,

            fullname: val
        });

        $.ajax({
            type: "POST",
            url: baseurl + "HRBasicProfile/HRBasicProfileUpdateIDSetAndLoadCivil",
            data: input,
            success: function (response) {
                //console.log(response);
                window.location.href = baseurl + "home/hrOffIndex";
            },
            failure: function (response) {
                $.alert({
                    title: _getCookieForLanguage("_informationTitle"),
                    content: response.responseText,
                    type: 'red'
                });
            },
            error: function (response) {
                $.alert({
                    title: _getCookieForLanguage("_informationTitle"),
                    content: response.responseText,
                    type: 'red'
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

function EditHRBasicProfileRecruitment(val) {
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
            methodname: "MilitarySearch_TableData",
            currenturl: window.location.href,

            fullname: val
        });

        $.ajax({
            type: "POST",
            url: baseurl + "HRBasicProfile/HRBasicProfileUpdateIDSetAndLoadRecruitment",
            data: input,
            success: function (response) {
                //console.log(response);
                window.location.href = baseurl + "home/hrOffIndex";
            },
            failure: function (response) {
                $.alert({
                    title: _getCookieForLanguage("_informationTitle"),
                    content: response.responseText,
                    type: 'red'
                });
            },
            error: function (response) {
                $.alert({
                    title: _getCookieForLanguage("_informationTitle"),
                    content: response.responseText,
                    type: 'red'
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

function EditHRBasicProfileVolunteer(val) {
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
            methodname: "MilitarySearch_TableData",
            currenturl: window.location.href,

            fullname: val
        });

        $.ajax({
            type: "POST",
            url: baseurl + "HRBasicProfile/HRBasicProfileUpdateIDSetAndLoadVolunteer",
            data: input,
            success: function (response) {
                //console.log(response);
                window.location.href = baseurl + "home/hrOffIndex";
            },
            failure: function (response) {
                $.alert({
                    title: _getCookieForLanguage("_informationTitle"),
                    content: response.responseText,
                    type: 'red'
                });
            },
            error: function (response) {
                $.alert({
                    title: _getCookieForLanguage("_informationTitle"),
                    content: response.responseText,
                    type: 'red'
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
function GetSearchResultData() {
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
            methodname: "MilitarySearch_TableData",
            currenturl: window.location.href,

            civilid: $("#txtmilitarysearch_civilid").val(),
            militaryno: $("#txtmilitarysearch_militaryid").val(),
            fullname: $("#txtmilitarysearch_name").val()
        });


        $('#searchResultDt').DataTable({
            "destroy": true,
            "bFilter": true,
            "columnDefs": [{
                "targets": 0,
                "searchable": false,
                "orderable": true,
            }],
            "language":
                {
                    "processing": "<div class='overlay custom-loader-background'><i class='fa fa-cog fa-spin custom-loader-color'></i></div>"
                },
            "processing": true,
            "serverSide": true,
            "autoWidth": false,
            "responsive": true,
            "searching": false,
            "ajax": {
                "url": baseurl + "HRBasicProfile/MilitarySearch_TableData",
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
            "columnDefs": [
                { "width": "auto", "targets": 0 },
                { "width": "auto", "targets": 1 },
                { "width": "auto", "targets": 2 },
                { "width": "20%", "targets": 3 }
            ],
            "columns": [
                { "title": searchedfullname, "data": "fullname", "searchable": false, "sortable": true, "orderable": true },
                { "title": searchedcivilid, "data": "civilid", "searchable": false, "sortable": true, "orderable": true },
                { "title": searchedmilitaryno, "data": "militaryno", "searchable": false, "sortable": true, "orderable": true },
                {
                    "title": "action",
                    "data": "ex_nvarchar1",
                    "sortable": false,
                    "orderable": false,
                    "render": function (data, type, full, meta) {
                        return data;
                    }
                }
            ],
            "drawCallback": function (settings) {

                /*show pager if only necessary
                console.log(this.fnSettings());*/
                if (Math.ceil((this.fnSettings().fnRecordsDisplay()) / this.fnSettings()._iDisplayLength) > 1) {
                    $('#GenBloodGroupdt_paginate').css("display", "block");
                } else {
                    $('#GenBloodGroupdt_paginate').css("display", "none");
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

function GetSearchResultDataDelegate() {
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
            methodname: "MilitarySearch_TableData",
            currenturl: window.location.href,

            civilid: $("#txtdelegatesearch_civilid").val(),
            militaryno: $("#txtdelegatesearch_militaryid").val(),
            fullname: $("#txtdelegatesearch_name").val()
        });


        $('#searchResultDtDG').DataTable({
            "destroy": true,
            "bFilter": true,
            "columnDefs": [{
                "targets": 0,
                "searchable": false,
                "orderable": true,
            }],
            "language":
                {
                    "processing": "<div class='overlay custom-loader-background'><i class='fa fa-cog fa-spin custom-loader-color'></i></div>"
                },
            "processing": true,
            "serverSide": true,
            "autoWidth": false,
            "responsive": true,
            "searching": false,
            "ajax": {
                "url": baseurl + "HRBasicProfile/MilitaryDelegateSearch_TableData",
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
            "columnDefs": [
                { "width": "auto", "targets": 0 },
                { "width": "auto", "targets": 1 },
                { "width": "auto", "targets": 2 },
                { "width": "20%", "targets": 3 }
            ],
            "columns": [
                { "title": searchedfullname, "data": "fullname", "searchable": false, "sortable": true, "orderable": true },
                { "title": searchedcivilid, "data": "civilid", "searchable": false, "sortable": true, "orderable": true },
                { "title": searchedmilitaryno, "data": "militaryno", "searchable": false, "sortable": true, "orderable": true },
                {
                    "title": "action",
                    "data": "ex_nvarchar1",
                    "sortable": false,
                    "orderable": false,
                    "render": function (data, type, full, meta) {
                        return data;
                    }
                }
            ],
            "drawCallback": function (settings) {

                /*show pager if only necessary
                console.log(this.fnSettings());*/
                if (Math.ceil((this.fnSettings().fnRecordsDisplay()) / this.fnSettings()._iDisplayLength) > 1) {
                    $('#GenBloodGroupdt_paginate').css("display", "block");
                } else {
                    $('#GenBloodGroupdt_paginate').css("display", "none");
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

function GetSearchResultDataCivil() {
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
            methodname: "MilitarySearch_TableData",
            currenturl: window.location.href,

            civilid: $("#txtcivilsearch_civilid").val(),
            svcno: $("#txtcivilsearch_empno").val(),
            fullname: $("#txtcivilsearch_name").val()
        });
        

        $('#searchResultDtCV').DataTable({
            "destroy": true,
            "bFilter": true,
            "columnDefs": [{
                "targets": 0,
                "searchable": false,
                "orderable": true,
            }],
            "language":
                {
                    "processing": "<div class='overlay custom-loader-background'><i class='fa fa-cog fa-spin custom-loader-color'></i></div>"
                },
            "processing": true,
            "serverSide": true,
            "autoWidth": false,
            "responsive": true,
            "searching": false,
            "ajax": {
                "url": baseurl + "HRBasicProfile/MilitaryCivilSearch_TableData",
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
                { "title": searchedfullname, "data": "fullname", "searchable": false, "sortable": true, "orderable": true },
                { "title": searchedcivilid, "data": "civilid", "searchable": false, "sortable": true, "orderable": true },
                { "title": searchedmilitaryno, "data": "svcno", "searchable": false, "sortable": true, "orderable": true },
                {
                    "title": "action",
                    "data": "ex_nvarchar1",
                    "sortable": false,
                    "orderable": false,
                    "render": function (data, type, full, meta) {
                        return data;
                    }
                }
            ],
            "drawCallback": function (settings) {

                /*show pager if only necessary
                console.log(this.fnSettings());*/
                if (Math.ceil((this.fnSettings().fnRecordsDisplay()) / this.fnSettings()._iDisplayLength) > 1) {
                    $('#GenBloodGroupdt_paginate').css("display", "block");
                } else {
                    $('#GenBloodGroupdt_paginate').css("display", "none");
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

function GetSearchResultDataRecruitment() {
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
            methodname: "MilitaryRecruitmentSearch_TableData",
            currenturl: window.location.href,

            civilid: $("#txtrecruitsearch_civilid").val(),
            fullname: $("#txtrecruitsearch_name").val()
        });


        $('#searchResultDtRec').DataTable({
            "destroy": true,
            "bFilter": true,
            "columnDefs": [{
                "targets": 0,
                "searchable": false,
                "orderable": true,
            }],
            "language":
            {
                "processing": "<div class='overlay custom-loader-background'><i class='fa fa-cog fa-spin custom-loader-color'></i></div>"
            },
            "processing": true,
            "serverSide": true,
            "autoWidth": false,
            "responsive": true,
            "searching": false,
            "ajax": {
                "url": baseurl + "HRBasicProfile/MilitaryRecruitmentSearch_TableData",
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
                { "title": searchedfullname, "data": "fullname", "searchable": false, "sortable": true, "orderable": true },
                { "title": searchedcivilid, "data": "civilid", "searchable": false, "sortable": true, "orderable": true },
                {
                    "title": "action",
                    "data": "ex_nvarchar1",
                    "sortable": false,
                    "orderable": false,
                    "render": function (data, type, full, meta) {
                        return data;
                    }
                }
            ],
            "drawCallback": function (settings) {

                /*show pager if only necessary
                console.log(this.fnSettings());*/
                if (Math.ceil((this.fnSettings().fnRecordsDisplay()) / this.fnSettings()._iDisplayLength) > 1) {
                    $('#GenBloodGroupdt_paginate').css("display", "block");
                } else {
                    $('#GenBloodGroupdt_paginate').css("display", "none");
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

function GetSearchResultDataVolunteer() {
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
            methodname: "MilitaryVolunteerSearch_TableData",
            currenturl: window.location.href,

            civilid: $("#txtvolunteersearch_civilid").val(),
            fullname: $("#txtvolunteersearch_name").val()
        });


        $('#searchResultDtVol').DataTable({
            "destroy": true,
            "bFilter": true,
            "columnDefs": [{
                "targets": 0,
                "searchable": false,
                "orderable": true,
            }],
            "language":
            {
                "processing": "<div class='overlay custom-loader-background'><i class='fa fa-cog fa-spin custom-loader-color'></i></div>"
            },
            "processing": true,
            "serverSide": true,
            "autoWidth": false,
            "responsive": true,
            "searching": false,
            "ajax": {
                "url": baseurl + "HRBasicProfile/MilitaryVolunteerSearch_TableData",
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
                { "title": searchedfullname, "data": "fullname", "searchable": false, "sortable": true, "orderable": true },
                { "title": searchedcivilid, "data": "civilid", "searchable": false, "sortable": true, "orderable": true },
                {
                    "title": "action",
                    "data": "ex_nvarchar1",
                    "sortable": false,
                    "orderable": false,
                    "render": function (data, type, full, meta) {
                        return data;
                    }
                }
            ],
            "drawCallback": function (settings) {

                /*show pager if only necessary
                console.log(this.fnSettings());*/
                if (Math.ceil((this.fnSettings().fnRecordsDisplay()) / this.fnSettings()._iDisplayLength) > 1) {
                    $('#GenBloodGroupdt_paginate').css("display", "block");
                } else {
                    $('#GenBloodGroupdt_paginate').css("display", "none");
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