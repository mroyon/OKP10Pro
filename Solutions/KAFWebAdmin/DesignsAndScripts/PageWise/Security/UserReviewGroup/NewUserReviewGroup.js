var baseurl = $("#txtBaseUrl").val();
var editor;

$(document).ready(function () {

    function datetoStr(data) {
        var regex = /-?\d+/;
        var match = regex.exec(data);
        var pubdate = new Date(parseInt(match[0]));

        var dd = pubdate.getDate(); var mm = pubdate.getMonth() + 1;
        var yyyy = pubdate.getFullYear(); if (dd < 10) { dd = '0' + dd } if (mm < 10) { mm = '0' + mm }
        var today = dd + '/' + mm + '/' + yyyy;
        return today;
    }
    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    $('body').on('click', '#btnSearchUserReviewGroup', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmUserReviewGroupSearch');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            var newRowContent = "";

            if (form.valid()) {
                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "GetUser",
                    currenturl: window.location.href,
                    username: $('#txtUsername').val(),
                    password: $('#ddlIsReviewed option:selected').val()//isreviewed
                });


                $('#candidateDt').DataTable({
                    "destroy": true,
                    //"stateSave": true,
                   // "lengthMenu": [[5, 10, 25, 50, -1], [5, 10, 25, 50, "All"]],
                    "columnDefs": [
                        {
                            "targets": 0,
                            "width": "5px",
                            "checkboxes": {
                                "selectRow": true
                            }
                        },
                        {
                            "targets": 1,
                            "data": "img"
                            
                        }

                    ],

                    "select": {
                        "style": "multi",
                        "selector": 'td:first-child'
                    },
                    "autoWidth": false,
                    "serverSide": true,
                    "responsive": true,
                    "ajax": {
                        "url": baseurl + "UserReviewByGroup/UserReviewByGroupTableData",
                        "data": input,
                        "type": 'POST',
                        "datatype": "json"
                    },
                    "columns": [
                        {
                            data: "masteruserid",
                            className: "dt-body-center"
                        },
                        {
                            "data": "UserProfilePhoto", "searchable": true, "sortable": true, "orderable": false,
                            "render": function (data, type, full, meta) {
                                //console.log(data);
                                if (!data) {
                                    return '<img height="45px" width="45px" src="' + baseurl+'DesignsAndScripts/Images/NoProfileImage.png"/>';
                                } else {
                                    
                                    return '<img height="45px" width="45px" src="' + data + '"/>';
                                }
                            }
                        },

                        {
                            "data": "username", "searchable": true, "sortable": true, "orderable": true
                        },
                        {
                            "data": "mobilenumber", "searchable": true, "sortable": true, "orderable": true
                        },
                        {
                            "data": "emailaddress", "searchable": true, "sortable": true, "orderable": true
                        },
                        {
                            "data": "locked", "searchable": true, "sortable": true, "orderable": true
                        }

                    ]
                });

            }
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });

    $('body').on('click', '#btnSaveUserReviewGroup', function (event) {
        try {
            event.preventDefault();
            var selectedData;
            var strinput = "";

            

            

                //var kaffileUploader = $('#id').kaffileUploader();
                //var fileobjects_tbl_recruitmentbatchid = $('#id').kaffileUploader.GetFilesForActions('tbl_recruitmentbatchid');
                //$.each(fileobjects_tbl_recruitmentbatchid, function (key, valueObj) {
                //    valueObj.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
                //    //console.log(valueObj);
                //});



                //var employeeorderno = $('#employeeorderno').val();
                //var employeeorderdate = GetDateFromTextBox($('#employeeorderdate').val());

                //var table = $('#candidateDt').DataTable();

                //var res = $('#candidateDt').DataTable().column(0).checkboxes.selected(); 
                var selectedIndex = $('#candidateDt').DataTable().rows({ selected: true }).indexes();

                $.each(selectedIndex, function (index, rowId) {
                    selectedData = $('#candidateDt').DataTable().rows(rowId).data();

                    //console.log(selectedData[0]);

                    var masteruserid = selectedData[0].masteruserid;
                 
                    strinput += masteruserid +",";


                });
            mString = strinput.substring(0, strinput.length - 1);
            
                
                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "HRBatchRecruitmentTableData",
                    currenturl: window.location.href,
                    //educationtypeid: $('#educationtypeid').val(),
                    //invitationdate: $('#invitationdate').val(),
                    //birthdatefrom: $('#birthdatefrom').val(),
                    //birthdateto: $('#birthdateto').val(),
                    //startinginducteeno: $('#startinginducteeno').val(),
                    //batchorderno: $('#batchorderno').val(),
                    //batchorderdate: $('#batchorderdate').val(),
                    strValue1: mString
                });
                $.ajax({
                    url: baseurl + "UserReviewByGroup/UserReviewByGroupInsert",
                    data: input,
                    type: 'POST',
                    success: function (data) {
                        if (data.status === "success") {
                            inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                if (answer == "true") {
                                    location.reload();
                                }
                                else {
                                    location.reload();
                                }
                            });
                        }

                        else {
                            return;
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
    });


    $(document).on('change', '.militaryno', function (event) {

        var upvalue = $(this).val();
        //$(this).removeAttr("value");
        //$(this).attr("value", upvalue);

        var pageinformation = $('#candidateDt').DataTable().page.info();
        var tableRowNo = parseInt($(this).closest('tr').index());
        var currentPage = parseInt(pageinformation.page);
        var pageLength = parseInt(pageinformation.length);

        var dtRowNumber = (currentPage * pageLength) + tableRowNo;
        $('#candidateDt').DataTable().cell(dtRowNumber, 3).data(upvalue).draw(false);
    });
    $(document).on('change', '.ddlmilitaryentitykey', function (event) {
        //event.preventDefault();

        var upvalue = $(this).find("option:selected").val();
        $(this).find("option").removeAttr("selected");
        $(this).find("option:selected").attr("selected", "selected");

        var pageinformation = $('#candidateDt').DataTable().page.info();
        var tableRowNo = parseInt($(this).closest('tr').index());
        var currentPage = parseInt(pageinformation.page);
        var pageLength = parseInt(pageinformation.length);

        var dtRowNumber = (currentPage * pageLength) + tableRowNo;

        //console.log("current page:" + parseInt(pageinformation.page), "page length:" + pageinformation.length, "table row:" + tableRowNo, "DataTable Row No:" + dtRowNumber);
        //console.log("current page:" + currentPage, "page length:" + pageLength, "table row:" + tableRowNo, "DataTable Row No:" + dtRowNumber);

        $('#candidateDt').DataTable().cell(dtRowNumber, 4).data($(this).parent().html()).draw(false);

    });






});

function LoadDataTableEditor(input) {

}
//$.ajax({
//    url: baseurl + "HRBatchRecruitment/HRBatchRecruitmentTableData",
//    type: 'POST',
//    data: input,
//    success: function (response) {

//    }
//});