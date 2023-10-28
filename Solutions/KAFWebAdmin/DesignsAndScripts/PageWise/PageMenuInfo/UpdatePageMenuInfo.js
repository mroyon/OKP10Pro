
$(document).ready(function () {
    var baseurl = $('#txtBaseUrl').val();
    //GetAllPublicMenu();
    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    $('body').on('click', '#btnEditPageMenuInfo', function (event) {
        try {

            event.preventDefault();

            var form = $('#frmUpdatePageMenuInfo');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "CreatePageMenuInfo",
                    currenturl: window.location.href
                     , publicmenuid: $('#publicmenuid').val()
                    , parentmenuid: $('#ddlpublicmenu').val()
                    , menucategoryid: $('#menucategoryid').val()
                    , menulevel: $('#menulevel').val()
                    , menulevelsequence: $('#menulevelsequence').val()
                    , sequence: $('#sequence').val()
                    , isdyamic: $('#isdyamic').val()
                    , isheadingtext: $('#isheadingtext').val()
                    , dynamicurl: $('#dynamicurl').val()
                    , menutitle: $('#menutitle').val()
                    , menutitlear: $('#menutitlear').val()

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_updateConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: $('#txtBaseUrl').val() + "PageMenuInfo/PageMenuInfo_Update",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        $("#PageMenuInfoDt").DataTable().ajax.reload();
                                        $('#modal-container-pagemenuinfoedit').modal('hide');
                                    });
                                }
                                else {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                            $("#PageMenuInfoDt").DataTable().ajax.reload();
                                            $('#modal-container-pagemenuinfoedit').modal('hide');
                                        }
                                    });
                                }
                            },
                            error: function (data) {
                                var tst = '';
                            }

                        });
                    }
                });
            }
            else {
                return;
            }

        } catch (e) {
            alert(e);
        }
    });


    $('body').on('click', '#btnReturn', function (event) {
        try {
            event.preventDefault();
            window.location.href = $('#txtBaseUrl').val() + "PageMenuInfo/PageMenuInfo";
        } catch (e) {

        }
    });




    $('body').on('click', '#btnLoadContent', function (event) {
        try {
            event.preventDefault();
            AddAntiForgeryToken = function (data) {
                data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
                return data;
            };

            var input = AddAntiForgeryToken({
                token: $(".txtUserSTK").val(),
                userinfo: $(".txtServerUtilObj").val(),
                useripaddress: $(".txtuserip").val(),
                sessionid: $(".txtUserSes").val(),
                methodname: "User_UpdateGet",
                currenturl: window.location.href
            });

            $.ajax({
                url: $("#txtBaseUrl").val() + "/PageMenuInfo/PageMenuInfo_LoadContent/",
                type: 'POST',
                data: input,
                success: function (response) {
                    $('#loadcontentdatacontainer').html(response);
                    $('#modal-container-loadcontent').modal({backdrop: 'static',keyboard: false});
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

    $('body').on('change', '#isdyamic', function (event) {
        try {
            if ($('#isdyamic').val()) {
                if ($("#isdyamic").val() == "true") {
                    document.getElementById("btnLoadContent").style.display = 'none';
                    $('#dynamicurl').val('');

                    GetAllDynamicContents();
                }
                else {
                    document.getElementById("lbldyn").style.display = 'none';
                    document.getElementById("ddldynamiccontent").style.display = 'none';

                    document.getElementById("btnLoadContent").style.display = 'block';
                    $('#dynamicurl').val('');
                }
            }
            else {

                document.getElementById("lbldyn").style.display = 'none';
                document.getElementById("ddldynamiccontent").style.display = 'none';

                document.getElementById("btnLoadContent").style.display = 'none';
                $('#dynamicurl').val('');
            }
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }

    });

    $('body').on('change', '#ddlcontent', function (event) {
        try {

            if ($('#ddlcontent').val() != "0") {
                GetContentCategory();
            }
            else {
                var table = $('#LoadContentDt').DataTable();
                table.destroy();
                $('#LoadContentDt').empty();
                $('#categoryDiv').css("display", "none")

                //$('#ddl_albumcategory').css("display", "none")
                //$('#ddl_currentactivitycategory').css("display", "none")
                //$('#ddl_eventcategory').css("display", "none")
                //$('#ddl_faqcategory').css("display", "none")
                //$('#ddl_newscategory').css("display", "none")
                //$('#ddl_publicationcategory').css("display", "none")
                //$('#ddl_resourcecategory').css("display", "none")
            }
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }

    });

    $('body').on('change', '#ddlcontentcategory', function (event) {
        try {
            GetAllContentWiseData();
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }

    });

   

    $('body').on('change', '#ddldynamiccontent', function (event) {
        try {
            $('#dynamicurl').val('');
            val = $('#ddldynamiccontent').val();
            if (val != "0") {
                $('#dynamicurl').val(val);
            }
            else {

            }
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }

    });


    $('body').on('change', '#ddlpublicmenu', function (event) {
        try {
            var input = AddAntiForgeryToken({
                token: $(".txtUserSTK").val(),
                userinfo: $(".txtServerUtilObj").val(),
                useripaddress: $(".txtuserip").val(),
                sessionid: $(".txtUserSes").val(),
                methodname: "ContentDetailsData",
                currenturl: window.location.href,
                publicmenuid: parseInt($("#ddlpublicmenu").val(), 10)
            });

            $("#menulevel").val("");
            $("#menulevelsequence").val("");
            console.log($("#ddlpublicmenu").val());
            if ($("#ddlpublicmenu").val() != null && $("#ddlpublicmenu").val() != "" && $("#ddlpublicmenu").val() != "0") {
                $.ajax({
                    url: $("#txtBaseUrl").val() + "/PageMenuInfo/GetMenuLevelByMenuId/",
                    type: 'POST',
                    data: input,
                    success: function (response) {
                        var data = response.data.menulevel + 1;
                        $("#menulevel").val(data);
                        var menulevelseq = "";
                        for (i = 1; i <= data; i++) {
                            menulevelseq += "1";
                            if (i != data) {
                                menulevelseq += ".";
                            }
                        }
                        $("#menulevelsequence").val(menulevelseq);
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
    });

    //$('body').on('change', '#sequence', function (event) {
    //    try {
    //        var sequence = $("#sequence").val();
    //        var menulevelseq = $("#menulevelsequence").val();
    //        var array = menulevelseq.split('.');
    //        menulevelseq = menulevelseq.slice(0, -1);
    //        menulevelseq = menulevelseq + sequence;
    //        $("#menulevelsequence").val(menulevelseq);
    //    } catch (e) {
    //        $.alert({
    //            title: _getCookieForLanguage("_informationTitle"),
    //            content: e.message,
    //            type: 'red'
    //        });
    //    }
    //});

    $('body').on('change', '#chkparentmenu', function (event) {
        try {

            if ($(this).is(':checked')) {
                document.getElementById("divparentmenu").style.display = 'block';
                document.getElementById("divIsdyn").style.display = 'none';
                //document.getElementById("divdynCont").style.display = 'none';
                //document.getElementById("divloadcont").style.display = 'none';

                document.getElementById("lbldyn").style.display = 'none';
                document.getElementById("ddldynamiccontent").style.display = 'none';
                document.getElementById("btnLoadContent").style.display = 'none';
                $('#dynamicurl').val('');
            }
            else {
                document.getElementById("divparentmenu").style.display = 'none';
                document.getElementById("divIsdyn").style.display = 'block';
                //document.getElementById("divdynCont").style.display = 'none';
                //document.getElementById("divloadcont").style.display = 'none';
            }

        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });

    $('body').on('change', '#ddlparentmenulink', function (event) {
        try {
            $('#dynamicurl').val('');
            val = $('#ddlparentmenulink').val();
            if (val != "0") {
                $('#dynamicurl').val(val);
            }
            else {

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

function GenerateUrl(val) {
    try {
        $('#dynamicurl').val(val);
        $('#modal-container-loadcontent').modal("hide");
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
}

function GetAllContentWiseData() {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };
    try {

        var input = AddAntiForgeryToken({
            token: $(".txtUserSTK").val(),
            userinfo: $(".txtServerUtilObj").val(),
            useripaddress: $(".txtuserip").val(),
            sessionid: $(".txtUserSes").val(),
            methodname: "ContentDetailsData",
            currenturl: window.location.href,
            ex_bigint1: $("#ddlcontentcategory").val()
        });
        var serviceUrl = "";

        if ($("#ddlcontent").val() == "1") {
            serviceUrl = $('#txtBaseUrl').val() + "/PageMenuInfo/" + "GetAlbumInfoData"
        }
        else if ($("#ddlcontent").val() == "2") {
            serviceUrl = $('#txtBaseUrl').val() + "/PageMenuInfo/" + "GetCurrentActivityData"
        }
        else if ($("#ddlcontent").val() == "3") {
            serviceUrl = $('#txtBaseUrl').val() + "/PageMenuInfo/" + "GetEventData"
        }
        else if ($("#ddlcontent").val() == "4") {
            serviceUrl = $('#txtBaseUrl').val() + "/PageMenuInfo/" + "GetFaqData"
        }
        else if ($("#ddlcontent").val() == "5") {
            serviceUrl = $('#txtBaseUrl').val() + "/PageMenuInfo/" + "GetNewsData"
        }
        else if ($("#ddlcontent").val() == "6") {
            serviceUrl = $('#txtBaseUrl').val() + "/PageMenuInfo/" + "GetPublicationData"
        }
        else if ($("#ddlcontent").val() == "7") {
            serviceUrl = $('#txtBaseUrl').val() + "/PageMenuInfo/" + "GetResourceData"
        }


        $('#LoadContentDt').DataTable({
            "bDestroy": true,
            "bFilter": true,
            "columnDefs": [{
                "targets": 0,
                "searchable": true,
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
            "ajax": {
                "url": serviceUrl
                , "type": "POST"
                , "data": input
            }
            ,
            "columns": [
              { "data": "strValue2", "searchable": true }
                ,
                {
                    "data": "ex_nvarchar1",
                    "render": function (data, type, full, meta) {
                        return data;
                    }
                }
            ]
        });

    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
}

function GetContentCategory() {

    try {
        $('#categoryDiv').css("display", "block")

        AddAntiForgeryToken = function (data) {
            data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
            return data;
        };
        document.getElementById("ddlcontentcategory").style.display = 'block';
        document.getElementById("categoryDiv").style.display = 'block';

        var input = AddAntiForgeryToken({
            token: $(".txtUserSTK").val(),
            userinfo: $(".txtServerUtilObj").val(),
            useripaddress: $(".txtuserip").val(),
            sessionid: $(".txtUserSes").val(),
            methodname: "GetContentCategory",
            currenturl: window.location.href,
            ex_nvarchar1: $("#ddlcontent").val()
        });
        $('#ddlcontentcategory').html('');
        var options = '';
        options = '<option value="0"> select </option>'
        $.ajax({
            url: $("#txtBaseUrl").val() + "/PageMenuInfo/GetContentCategory/",
            type: 'POST',
            data: input,
            success: function (response) {
                var data = response.data;
                for (var i = 0; i < data.length; i++) {
                    options += '<option value="' + data[i].id + '">' + data[i].text + '</option>';
                }
                
                $('#ddlcontentcategory').append(options);
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

function GetAllDynamicContents() {
    try {
        AddAntiForgeryToken = function (data) {
            data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
            return data;
        };
        document.getElementById("ddldynamiccontent").style.display = 'block';
        document.getElementById("lbldyn").style.display = 'block';

        var input = AddAntiForgeryToken({
            token: $(".txtUserSTK").val(),
            userinfo: $(".txtServerUtilObj").val(),
            useripaddress: $(".txtuserip").val(),
            sessionid: $(".txtUserSes").val(),
            methodname: "ContentDetailsData",
            currenturl: window.location.href
        });
        $('#ddldynamiccontent').html('');
        var options = '';
        options = '<option value="0"> select </option>'
        $.ajax({
            url: $("#txtBaseUrl").val() + "/PageMenuInfo/GetAllDynamicContents/",
            type: 'POST',
            data: input,
            success: function (response) {
                var data = response.data;
                for (var i = 0; i < data.length; i++) {
                    options += '<option value="' + data[i].id + '">' + data[i].text + '</option>';
                }
                
                $('#ddldynamiccontent').append(options);
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

//function GetAllPublicMenu() {
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
//            methodname: "GetAllPublicMenu",
//            currenturl: window.location.href
//        });
//        $('#ddlpublicmenu').html('');
//        var options = '';
//        options = '<option value="0"> select </option>'
//        $.ajax({
//            url: $("#txtBaseUrl").val() + "/PageMenuInfo/GetAllPublicMenu/",
//            type: 'POST',
//            data: input,
//            success: function (response) {
//                var data = response.data;
//                for (var i = 0; i < data.length; i++) {
//                    options += '<option value="' + data[i].id + '">' + data[i].text + '</option>';
//                }
//                $('#ddlpublicmenu').append(options);
//            }
//        });
//    } catch (e) {
//        $.alert({
//            title: _getCookieForLanguage("_informationTitle"),
//            content: e.message,
//            type: 'red'
//        });
//    }
//}