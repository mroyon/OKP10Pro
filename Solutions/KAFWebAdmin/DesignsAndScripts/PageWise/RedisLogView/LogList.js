$(document).ready(function () {
    var baseurl = $('#txtBaseUrl').val();
    GetAllRedisLogData();
});

function GetAllRedisLogData() {
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
            methodname: "GetLogList",
            currenturl: window.location.href
        });
        $('#redisLog').DataTable({

            "bFilter": true,
            "columnDefs": [{
                "targets": 0,
                "searchable": true,
                "orderable": true,
            }],
            "language": {
                "processing": "<div class='overlay custom-loader-background'><i class='fa fa-cog fa-spin custom-loader-color'></i></div>"
            },
            "processing": true,
            "serverSide": true,
            "autoWidth": false,
            "responsive": true,
            "ajax": {
                "url": $('#txtBaseUrl').val() + "RedisLogView/GetLogList",
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
                    "data": "logid", "sortable": true, "orderable": true,
                    "searchable": false
                },
                {
                    "data": "logdate", "sortable": true, "orderable": true,
                    "searchable": true
                },

                {
                    "data": "logger", "sortable": true, "orderable": true,
                    "searchable": false
                },

                {
                    "data": "message", "sortable": true, "orderable": true,
                    "searchable": false
                },

                {
                    "data": "useridentity", "sortable": true, "orderable": true,
                    "searchable": false
                },

                {
                    "data": "level", "sortable": true, "orderable": true,
                    "searchable": false
                },

                {
                    "data": "organization", "sortable": true, "orderable": true,
                    "searchable": false
                },

                {
                    "data": "pageurl", "sortable": true, "orderable": true,
                    "searchable": false
                },

                {
                    "data": "username", "sortable": true, "orderable": true,
                    "searchable": false
                },

                {
                    "data": "hitfrom", "sortable": true, "orderable": true,
                    "searchable": false
                },

                {
                    "data": "machinename", "sortable": true, "orderable": true,
                    "searchable": false
                },

                {
                    "data": "tranid", "sortable": true, "orderable": true,
                    "searchable": false
                },

                {
                    "data": "sessionid", "sortable": true, "orderable": true,
                    "searchable": false
                },

                {
                    "data": "raisingevent", "sortable": true, "orderable": true,
                    "searchable": false
                }


                //{
                //    "data": "host", "sortable": true, "orderable": true,
                //    "searchable": false
                //},
                //{
                //    "data": "sysloglevel", "sortable": true, "orderable": true,
                //    "searchable": true
                //},

                //{
                //    "data": "timestamp", "sortable": true, "orderable": true,
                //    "searchable": false
                //},

                //{
                //    "data": "LoggerName", "sortable": true, "orderable": true,
                //    "searchable": false
                //},

                //{
                //    "data": "file", "sortable": true, "orderable": true,
                //    "searchable": false
                //},

                //{
                //    "data": "line", "sortable": true, "orderable": true,
                //    "searchable": false
                //},

                //{
                //    "data": "message", "sortable": true, "orderable": true,
                //    "searchable": false
                //},

                //{
                //    "data": "type", "sortable": true, "orderable": true,
                //    "searchable": false
                //},

                //{
                //    "data": "Environment", "sortable": true, "orderable": true,
                //    "searchable": false
                //},

                //{
                //    "data": "Level", "sortable": true, "orderable": true,
                //    "searchable": false
                //},

                //{
                //    "data": "FormID", "sortable": true, "orderable": true,
                //    "searchable": false
                //},

                //{
                //    "data": "IPAddress", "sortable": true, "orderable": true,
                //    "searchable": false
                //},

                //{
                //    "data": "RaisingEvent", "sortable": true, "orderable": true,
                //    "searchable": false
                //},

                //{
                //    "data": "SessionID", "sortable": true, "orderable": true,
                //    "searchable": false
                //},

                //{
                //    "data": "Message", "sortable": true, "orderable": true,
                //    "searchable": false
                //},

                //{
                //    "data": "username", "sortable": true, "orderable": true,
                //    "searchable": false
                //},
                //{
                //    "data": "hitFrom", "sortable": true, "orderable": true,
                //    "searchable": false
                //},
                //{
                //    "data": "PageURL", "sortable": true, "orderable": true,
                //    "searchable": false
                //},
                //{
                //    "data": "CreatedBy", "sortable": true, "orderable": true,
                //    "searchable": false
                //},
                //{
                //    "data": "TranID", "sortable": true, "orderable": true,
                //    "searchable": false
                //},
                //{
                //    "data": "MachineName", "sortable": true, "orderable": true,
                //    "searchable": false
                //},
                //{
                //    "data": "OrganizationKey", "sortable": true, "orderable": true,
                //    "searchable": false
                //}
            ]
        });
        //$.ajax({
        //    url: $('#txtBaseUrl').val() + "RedisLogView/GetLogList",
        //    data: input,
        //    type: 'POST',
        //    success: function (response) {
        //        if (response.data !== null) {
        //            console.log(response.data);
        //        }
        //    }

        //});
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
}       