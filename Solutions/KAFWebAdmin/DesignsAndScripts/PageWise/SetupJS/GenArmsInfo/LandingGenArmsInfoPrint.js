

//PN: FILE NAME: "Loadgen_armsinfo.js"
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

    GetAllDataGenArmsInfo();

    $("#btnPrint").click(function () {
        $("#GenArmsInfoDt").printThis({
           
        });
    });
});

function GetAllDataGenArmsInfo() {
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
            methodname: "GenArmsInfoTableData",
            currenturl: window.location.href
        });
        
        $('#GenArmsInfoDt').DataTable({
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
                "url": baseurl + "GenArmsInfo/GenArmsInfoTableDataWithQRCode",
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
            
                { "data": "armsname", "searchable": true, "sortable": true, "orderable": true },
                { "data": "armscode", "searchable": true, "sortable": true, "orderable": true },
                { "data": "ism16", "searchable": true, "sortable": true, "orderable": true },
                {
                    data: "ex_nvarchar2", name: "ex_nvarchar2",
                    render: function (data, type, row, meta) {
                       // var imgsrc = 'data:image/png;base64,' + data; // here data should be in base64 string
                        return '<img class="img-responsive" src="' + data + '" alt="Qr Code" height="150px" width="150px">';
                    }
                }
            ],
            "drawCallback": function (settings) {

                /*show pager if only necessary
                console.log(this.fnSettings());*/
                if (Math.ceil((this.fnSettings().fnRecordsDisplay()) / this.fnSettings()._iDisplayLength) > 1) {
                    $('#GenArmsInfoDt_paginate').css("display", "block");
                } else {
                    $('#GenArmsInfoDt_paginate').css("display", "none");
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






