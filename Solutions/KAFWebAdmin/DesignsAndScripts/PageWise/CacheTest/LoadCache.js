
var baseurl = $("#txtBaseUrl").val();
$(document).ready(function () {
    $(".modal").on("hidden.bs.modal", function () {
        $(".modal-body").html("");
    });
    HRCacheDataForRole();
    HRCacheDataForgen_acrgrade();
    HRCacheDataForgen_branch();
    HRCacheDataForgen_certificate();
    HRCacheDataForgen_contracttype();
    HRCacheDataForgen_course();
    HRCacheDataForgen_coursegrade();
    HRCacheDataForgen_delayrequestlevel();
    HRCacheDataForgen_delayrequesttype();
    HRCacheDataForgen_educationtype();
});


function HRCacheDataForRole() {
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
            methodname: "HRCacheDataForRole",
            currenturl: window.location.href
        });


        $('#HrCacheRoledt').DataTable({
            //"bFilter": true,
            //"columnDefs": [{
            //    "targets": 0,
            //    "searchable": true,
            //    "orderable": true
            //}],
            //"language":
            //{
            //    "processing": "<div class='overlay custom-loader-background'><i class='fa fa-cog fa-spin custom-loader-color'></i></div>"
            //},
            //"processing": true,
            //"serverSide": true,
            //"autoWidth": false,
            //"responsive": true,
            "ajax": {
                "url": baseurl + "CacheTest/HRCacheDataForRole",
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
                { "data": "comId", "searchable": true, "sortable": true, "orderable": true },
                { "data": "comText", "searchable": true, "sortable": true, "orderable": true }
            ]
            //,"drawCallback": function (settings) {

            //    /*show pager if only necessary
            //    console.log(this.fnSettings());*/
            //    if (Math.ceil((this.fnSettings().fnRecordsDisplay()) / this.fnSettings()._iDisplayLength) > 1) {
            //        $('#HrCacheRoledt_paginate').css("display", "block");
            //    } else {
            //        $('#HrCacheRoledt_paginate').css("display", "none");
            //    }

            //}
        });
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e,
            type: 'red'
        });
    }
}
function HRCacheDataForgen_acrgrade() {
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
            methodname: "HRCacheDataForRole",
            currenturl: window.location.href
        });


        $('#HrCachegradedt').DataTable({
            //"bFilter": true,
            //"columnDefs": [{
            //    "targets": 0,
            //    "searchable": true,
            //    "orderable": true
            //}],
            //"language":
            //{
            //    "processing": "<div class='overlay custom-loader-background'><i class='fa fa-cog fa-spin custom-loader-color'></i></div>"
            //},
            //"processing": true,
            //"serverSide": true,
            //"autoWidth": false,
            //"responsive": true,
            "ajax": {
                "url": baseurl + "CacheTest/HRCacheDataForgen_acrgrade",
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
                { "data": "comId", "searchable": true, "sortable": true, "orderable": true },
                { "data": "comText", "searchable": true, "sortable": true, "orderable": true }
            ]

            //,"drawCallback": function (settings) {

            //    /*show pager if only necessary
            //    console.log(this.fnSettings());*/
            //    if (Math.ceil((this.fnSettings().fnRecordsDisplay()) / this.fnSettings()._iDisplayLength) > 1) {
            //        $('#HrCachegradedt_paginate').css("display", "block");
            //    } else {
            //        $('#HrCachegradedt_paginate').css("display", "none");
            //    }

            //}
        });
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e,
            type: 'red'
        });
    }
}
function HRCacheDataForgen_branch() {
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
            methodname: "HRCacheDataForRole",
            currenturl: window.location.href
        });


        $('#HrCachebranchdt').DataTable({
            //"bFilter": true,
            //"columnDefs": [{
            //    "targets": 0,
            //    "searchable": true,
            //    "orderable": true
            //}],
            //"language":
            //{
            //    "processing": "<div class='overlay custom-loader-background'><i class='fa fa-cog fa-spin custom-loader-color'></i></div>"
            //},
            //"processing": true,
            //"serverSide": true,
            //"autoWidth": false,
            //"responsive": true,
            "ajax": {
                "url": baseurl + "CacheTest/HRCacheDataForgen_branch",
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
                { "data": "comId", "searchable": true, "sortable": true, "orderable": true },
                { "data": "comText", "searchable": true, "sortable": true, "orderable": true }
            ]

            //,"drawCallback": function (settings) {

            //    /*show pager if only necessary
            //    console.log(this.fnSettings());*/
            //    if (Math.ceil((this.fnSettings().fnRecordsDisplay()) / this.fnSettings()._iDisplayLength) > 1) {
            //        $('#HrCachegradedt_paginate').css("display", "block");
            //    } else {
            //        $('#HrCachegradedt_paginate').css("display", "none");
            //    }

            //}
        });
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e,
            type: 'red'
        });
    }
}
function HRCacheDataForgen_certificate() {
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
            methodname: "HRCacheDataForRole",
            currenturl: window.location.href
        });


        $('#HrCachecertificatedt').DataTable({
            //"bFilter": true,
            //"columnDefs": [{
            //    "targets": 0,
            //    "searchable": true,
            //    "orderable": true
            //}],
            //"language":
            //{
            //    "processing": "<div class='overlay custom-loader-background'><i class='fa fa-cog fa-spin custom-loader-color'></i></div>"
            //},
            //"processing": true,
            //"serverSide": true,
            //"autoWidth": false,
            //"responsive": true,
            "ajax": {
                "url": baseurl + "CacheTest/HRCacheDataForgen_certificate",
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
                { "data": "comId", "searchable": true, "sortable": true, "orderable": true },
                { "data": "comText", "searchable": true, "sortable": true, "orderable": true }
            ]

            //,"drawCallback": function (settings) {

            //    /*show pager if only necessary
            //    console.log(this.fnSettings());*/
            //    if (Math.ceil((this.fnSettings().fnRecordsDisplay()) / this.fnSettings()._iDisplayLength) > 1) {
            //        $('#HrCachegradedt_paginate').css("display", "block");
            //    } else {
            //        $('#HrCachegradedt_paginate').css("display", "none");
            //    }

            //}
        });
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e,
            type: 'red'
        });
    }
}
function HRCacheDataForgen_contracttype() {
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
            methodname: "HRCacheDataForRole",
            currenturl: window.location.href
        });


        $('#HrCachecontracttypedt').DataTable({
            //"bFilter": true,
            //"columnDefs": [{
            //    "targets": 0,
            //    "searchable": true,
            //    "orderable": true
            //}],
            //"language":
            //{
            //    "processing": "<div class='overlay custom-loader-background'><i class='fa fa-cog fa-spin custom-loader-color'></i></div>"
            //},
            //"processing": true,
            //"serverSide": true,
            //"autoWidth": false,
            //"responsive": true,
            "ajax": {
                "url": baseurl + "CacheTest/HRCacheDataForgen_contracttype",
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
                { "data": "comId", "searchable": true, "sortable": true, "orderable": true },
                { "data": "comText", "searchable": true, "sortable": true, "orderable": true }
            ]

            //,"drawCallback": function (settings) {

            //    /*show pager if only necessary
            //    console.log(this.fnSettings());*/
            //    if (Math.ceil((this.fnSettings().fnRecordsDisplay()) / this.fnSettings()._iDisplayLength) > 1) {
            //        $('#HrCachegradedt_paginate').css("display", "block");
            //    } else {
            //        $('#HrCachegradedt_paginate').css("display", "none");
            //    }

            //}
        });
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e,
            type: 'red'
        });
    }
}
function HRCacheDataForgen_course() {
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
            methodname: "HRCacheDataForRole",
            currenturl: window.location.href
        });


        $('#HrCachecoursedt').DataTable({
            //"bFilter": true,
            //"columnDefs": [{
            //    "targets": 0,
            //    "searchable": true,
            //    "orderable": true
            //}],
            //"language":
            //{
            //    "processing": "<div class='overlay custom-loader-background'><i class='fa fa-cog fa-spin custom-loader-color'></i></div>"
            //},
            //"processing": true,
            //"serverSide": true,
            //"autoWidth": false,
            //"responsive": true,
            "ajax": {
                "url": baseurl + "CacheTest/HRCacheDataForgen_course",
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
                { "data": "comId", "searchable": true, "sortable": true, "orderable": true },
                { "data": "comText", "searchable": true, "sortable": true, "orderable": true }
            ]

            //,"drawCallback": function (settings) {

            //    /*show pager if only necessary
            //    console.log(this.fnSettings());*/
            //    if (Math.ceil((this.fnSettings().fnRecordsDisplay()) / this.fnSettings()._iDisplayLength) > 1) {
            //        $('#HrCachegradedt_paginate').css("display", "block");
            //    } else {
            //        $('#HrCachegradedt_paginate').css("display", "none");
            //    }

            //}
        });
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e,
            type: 'red'
        });
    }
}
function HRCacheDataForgen_coursegrade() {
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
            methodname: "HRCacheDataForRole",
            currenturl: window.location.href
        });


        $('#HrCachecoursegradedt').DataTable({
            //"bFilter": true,
            //"columnDefs": [{
            //    "targets": 0,
            //    "searchable": true,
            //    "orderable": true
            //}],
            //"language":
            //{
            //    "processing": "<div class='overlay custom-loader-background'><i class='fa fa-cog fa-spin custom-loader-color'></i></div>"
            //},
            //"processing": true,
            //"serverSide": true,
            //"autoWidth": false,
            //"responsive": true,
            "ajax": {
                "url": baseurl + "CacheTest/HRCacheDataForgen_coursegrade",
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
                { "data": "comId", "searchable": true, "sortable": true, "orderable": true },
                { "data": "comText", "searchable": true, "sortable": true, "orderable": true }
            ]

            //,"drawCallback": function (settings) {

            //    /*show pager if only necessary
            //    console.log(this.fnSettings());*/
            //    if (Math.ceil((this.fnSettings().fnRecordsDisplay()) / this.fnSettings()._iDisplayLength) > 1) {
            //        $('#HrCachegradedt_paginate').css("display", "block");
            //    } else {
            //        $('#HrCachegradedt_paginate').css("display", "none");
            //    }

            //}
        });
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e,
            type: 'red'
        });
    }
}
function HRCacheDataForgen_delayrequestlevel() {
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
            methodname: "HRCacheDataForRole",
            currenturl: window.location.href
        });


        $('#HrCachedelayrequestleveldt').DataTable({
            //"bFilter": true,
            //"columnDefs": [{
            //    "targets": 0,
            //    "searchable": true,
            //    "orderable": true
            //}],
            //"language":
            //{
            //    "processing": "<div class='overlay custom-loader-background'><i class='fa fa-cog fa-spin custom-loader-color'></i></div>"
            //},
            //"processing": true,
            //"serverSide": true,
            //"autoWidth": false,
            //"responsive": true,
            "ajax": {
                "url": baseurl + "CacheTest/HRCacheDataForgen_delayrequestlevel",
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
                { "data": "comId", "searchable": true, "sortable": true, "orderable": true },
                { "data": "comText", "searchable": true, "sortable": true, "orderable": true }
            ]

            //,"drawCallback": function (settings) {

            //    /*show pager if only necessary
            //    console.log(this.fnSettings());*/
            //    if (Math.ceil((this.fnSettings().fnRecordsDisplay()) / this.fnSettings()._iDisplayLength) > 1) {
            //        $('#HrCachegradedt_paginate').css("display", "block");
            //    } else {
            //        $('#HrCachegradedt_paginate').css("display", "none");
            //    }

            //}
        });
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e,
            type: 'red'
        });
    }
}
function HRCacheDataForgen_delayrequesttype() {
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
            methodname: "HRCacheDataForRole",
            currenturl: window.location.href
        });


        $('#HrCachedelayrequesttypedt').DataTable({
            //"bFilter": true,
            //"columnDefs": [{
            //    "targets": 0,
            //    "searchable": true,
            //    "orderable": true
            //}],
            //"language":
            //{
            //    "processing": "<div class='overlay custom-loader-background'><i class='fa fa-cog fa-spin custom-loader-color'></i></div>"
            //},
            //"processing": true,
            //"serverSide": true,
            //"autoWidth": false,
            //"responsive": true,
            "ajax": {
                "url": baseurl + "CacheTest/HRCacheDataForgen_delayrequesttype",
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
                { "data": "comId", "searchable": true, "sortable": true, "orderable": true },
                { "data": "comText", "searchable": true, "sortable": true, "orderable": true }
            ]

            //,"drawCallback": function (settings) {

            //    /*show pager if only necessary
            //    console.log(this.fnSettings());*/
            //    if (Math.ceil((this.fnSettings().fnRecordsDisplay()) / this.fnSettings()._iDisplayLength) > 1) {
            //        $('#HrCachegradedt_paginate').css("display", "block");
            //    } else {
            //        $('#HrCachegradedt_paginate').css("display", "none");
            //    }

            //}
        });
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e,
            type: 'red'
        });
    }
}
function HRCacheDataForgen_educationtype() {
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
            methodname: "HRCacheDataForRole",
            currenturl: window.location.href
        });


        $('#HrCacheeducationtypedt').DataTable({
            //"bFilter": true,
            //"columnDefs": [{
            //    "targets": 0,
            //    "searchable": true,
            //    "orderable": true
            //}],
            //"language":
            //{
            //    "processing": "<div class='overlay custom-loader-background'><i class='fa fa-cog fa-spin custom-loader-color'></i></div>"
            //},
            //"processing": true,
            //"serverSide": true,
            //"autoWidth": false,
            //"responsive": true,
            "ajax": {
                "url": baseurl + "CacheTest/HRCacheDataForgen_educationtype",
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
                { "data": "comId", "searchable": true, "sortable": true, "orderable": true },
                { "data": "comText", "searchable": true, "sortable": true, "orderable": true }
            ]

            //,"drawCallback": function (settings) {

            //    /*show pager if only necessary
            //    console.log(this.fnSettings());*/
            //    if (Math.ceil((this.fnSettings().fnRecordsDisplay()) / this.fnSettings()._iDisplayLength) > 1) {
            //        $('#HrCachegradedt_paginate').css("display", "block");
            //    } else {
            //        $('#HrCachegradedt_paginate').css("display", "none");
            //    }

            //}
        });
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e,
            type: 'red'
        });
    }
}