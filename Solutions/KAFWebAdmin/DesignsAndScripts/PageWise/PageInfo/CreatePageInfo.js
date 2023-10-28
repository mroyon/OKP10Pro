Dropzone.autoDiscover = false;

$(document).ready(function () {
    var baseurl = $('#txtBaseUrl').val();

    $.get("/DesignsAndScripts/HtmlTemplate/TemplateWithImageAndLink.html", function (data) {
        CKEDITOR.instances['pagecontent'].setData(data);
    });
    $.get("/DesignsAndScripts/HtmlTemplate/TemplateWithImageAndLinkAR.html", function (data) {
        CKEDITOR.instances['pagecontentar'].setData(data);
    });

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    $('body').on('click', '#btnReturn', function (event) {
        try {
            event.preventDefault();
            window.location.href = $('#txtBaseUrl').val()  + "PageInfo/PageInfo";
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });

    $('body').on('click', '#btnCreatePageInfo', function (event) {
        try {
         
            event.preventDefault();

            var form = $('#frmCreatePageInfo');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

            if (form.valid()) {

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "CreatePageInfo",
                    currenturl: window.location.href
                 
                    ,pagetitle:  $('#pagetitle').val()
                    ,pagedescription:  $('#pagedescription').val()
                    ,pagecontent:CKEDITOR.instances['pagecontent'].getData()  
                    ,pagetitlear:  $('#pagetitlear').val()
                    ,pagedescriptionar:  $('#pagedescriptionar').val()
                    ,pagecontentar:  CKEDITOR.instances['pagecontentar'].getData()

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: $('#txtBaseUrl').val() + "PageInfo/CreatePageInfo",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    confirmationDialog(data.title, data.responsetext, _getCookieForLanguage("_btnAddMore"), _getCookieForLanguage("_btnGoBackToMain")).then(function (answer) {
                                        if (answer == "true") {
                                            document.getElementById("frmCreatePageInfo").reset();
                                           
                                            return
                                        }
                                        else if (answer == "false") {
                                            window.location.href = data.redirectUrl;
                                        }
                                    });
                                }
                                else {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                        }
                                    });
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

$(document).ready(function () {
    try {
        var token = $('input[name="__RequestVerificationToken"]').val();
        var UrlUpload = "/PageInfo/UploadPageImage";
        var myDropzone = new Dropzone("#dZUpload", {
            url: UrlUpload,
            headers: { "__RequestVerificationToken": token },
            maxFiles: 20,
            addRemoveLinks: true,
            url: $('#txtBaseUrl').val() + "PageInfo/UploadImage",
            maxFilesize: 2,
            acceptedFiles: "image/jpeg, image/jpg, image/png,.pdf",
            autoProcessQueue: true,
            parallelUploads: 1,
            init: function () {
                var myDropzone = this;

                myDropzone.on("sending", function (file, xhr, formData) {
                    formData.append("__RequestVerificationToken", $('input[name=__RequestVerificationToken]').val());
                    formData.append("attachment", file);
                    formData.append("token", $(".txtUserSTK").val());
                    formData.append("userinfo", $(".txtServerUtilObj").val());
                    formData.append("useripaddress", $(".txtuserip").val());
                    formData.append("sessionid", $(".txtUserSes").val());
                    formData.append("methodname", "Update_Profile");
                    formData.append("currenturl", window.location.href);
                });

                this.on("processing", function (file) {
                    myDropzone.options.url = $('#txtBaseUrl').val() + "PageInfo/UploadImage";
                });

                this.on("success", function (file, serverResponse) {
                    myDropzone.options.autoProcessQueue = true;
                    //alert(serverResponse.Name);
                    var fileuploded = file.previewElement.querySelector("[data-dz-name]");
                    fileuploded.innerHTML = serverResponse.Name;

                    var fileuploded2 = file.previewElement.querySelector("[data-dz-name]");
                    fileuploded2.innerHTML = serverResponse.Name;

                });

                this.on("queuecomplete", function () {
                    //setTimeout(function () {
                    //    myDropzone.options.autoProcessQueue = false;
                    //    myDropzone.removeAllFiles(true);
                    //}, 3000);
                });
            },
            success: function (file, response) {
                file.previewElement.classList.add("dz-success");
            },
            removedfile: function (file) {

                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_deleteConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {
                        AddAntiForgeryToken = function (data) {
                            data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
                            return data;
                        };

                        var filename = file.previewElement.querySelector('[data-dz-name]').innerHTML;

                        var input = AddAntiForgeryToken({
                            token: $(".txtUserSTK").val(),
                            userinfo: $(".txtServerUtilObj").val(),
                            useripaddress: $(".txtuserip").val(),
                            sessionid: $(".txtUserSes").val(),
                            methodname: "Page_Delete",
                            currenturl: window.location.href,
                            filename: filename
                        });

                        $.ajax({
                            url: $('#txtBaseUrl').val() + "PageInfo/DeleteImage",
                            data: input,
                            type: 'POST',
                            success: function (response) {
                                if (response.status == "success") {
                                    inforamtionDialog(_getCookieForLanguage("_informationTitle"), response.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        file.previewElement.parentNode.removeChild(file.previewElement);
                                    });
                                }
                            }
                        });

                    }
                });
            },
            error: function (file, response) {
                file.previewElement.classList.add("dz-error");
                $(file.previewElement).find('.dz-error-message').text(response);
                
            }
        });
    } catch (e) {
        $.alert({
            title: _getCookieForLanguage("_informationTitle"),
            content: e.message,
            type: 'red'
        });
    }
    $('#btnSubmit').click(function () {
        myDropzone.processQueue();
    });
});