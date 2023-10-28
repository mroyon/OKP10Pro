

//PN: FILE NAME: "Newstp_organizationentity.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

    

    $('body').on('click', '#btnUpdateStpOrganizationEntity', function (event) {
        try {
            event.preventDefault();

            var form = $('#frmStp_OrganizationEntityEdit');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

			 //var kaffileUploader = $('#id').kaffileUploader();
			 //var fileobjects_tbl_entitylogofiledescription = $('#id').kaffileUploader.GetFilesForActions('tbl_entitylogofiledescription');
			 //var fileobjects = fileobjects_tbl_entitylogofiledescription;

			 // $.each(fileobjects, function (key, valueObj) {
				//	  valueObj.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
			 //  });



            
            if (form.valid()) {

                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "HrFamilyInfoCreate",
                    currenturl: window.location.href,

							 entitykey: $('#entitykey').val(),
							 organizationkey: $('#organizationkey').val(),
							 //parentkey: $('#parentkey').val(),
							 //entirytypekey: $('#entirytypekey').val(),
							 entitylevel: 1,
							 //seqfirstindex: $('#seqfirstindex').val(),
							 //seqfullindex: $('#seqfullindex').val(),
							 //entitycode: $('#entitycode').val(),
							 entityname: $('#entityname').val(),
							 //entitynamear: $('#entitynamear').val(),
							 description: $('#description').val(),
							 isactive: $('#isactive').val(),
							 //entitystatus: $('#entitystatus').val(),
							 //entityseniority: $('#entityseniority').val(),
							 //entityidentitycode: $('#entityidentitycode').val(),
							 //adidentitycode: $('#adidentitycode').val(),
							 //remarks: $('#remarks').val(),
							 //entitylogo: $('#entitylogo').val(),
							 //entitylogofiledescription: $('#entitylogofiledescription').val(),
							 //entitylogofilepath: $('#entitylogofilepath').val(),
							 //entitylogofilename: $('#entitylogofilename').val(),
							 //entitylogofiletype: $('#entitylogofiletype').val(),
							 //entitylogoextension: $('#entitylogoextension').val(),
							 //entitylogofileno: $('#entitylogofileno').val()
							 ////cor_foldercontentsList: fileobjects


                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "StpOrganizationEntity/StpOrganizationEntityUpdate",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "StpOrganizationEntity/StpOrganizationEntity";
                                            $('#mcStpOrganizationEntityEdit').html('');
                                            $('#modal-container-StpOrganizationEntityEdit').modal('hide');
                                            GetAllDataStpOrganizationEntity();
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
    
    $('body').on('click', '#btnModalCloseEdit', function (event) {
        try {
            event.preventDefault();
            $('#mcStpOrganizationEntityEdit').html('');
            $('#modal-container-StpOrganizationEntityEdit').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    

});






