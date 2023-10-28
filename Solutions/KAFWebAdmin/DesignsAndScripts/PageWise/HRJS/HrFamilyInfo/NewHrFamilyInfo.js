

//PN: FILE NAME: "Newhr_familyinfo.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

   


    $('body').on('click', '#btnSaveHrFamilyInfo', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmHr_FamilyInfoNew');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);

			 var kaffileUploader = $('#id').kaffileUploader();
			 var fileobjects_tbl_marriagefiledescription = $('#id').kaffileUploader.GetFilesForActions('tbl_marriagefiledescription');
			 var fileobjects_tbl_divorcefiledescription = $('#id').kaffileUploader.GetFilesForActions('tbl_divorcefiledescription');
			 var fileobjects_tbl_familydeathfiledescription = $('#id').kaffileUploader.GetFilesForActions('tbl_familydeathfiledescription');
			 var fileobjects = fileobjects_tbl_marriagefiledescription.concat(fileobjects_tbl_divorcefiledescription,fileobjects_tbl_familydeathfiledescription);

			  $.each(fileobjects, function (key, valueObj) {
					  valueObj.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
			   });



    
            if (form.valid()) {

               
                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "HrFamilyInfoCreate",
                    currenturl: window.location.href,

							 hrfamilyid: $('#hrfamilyid').val(),
							 hrbasicid: $('#hrbasicid').val(),
							 relationshipid: $('#relationshipid').val(),
							 parenthrfamilyid: $('#parenthrfamilyid').val(),
							 familycivilid: $('#familycivilid').val(),
							 familynationalid: $('#familynationalid').val(),
							 familyname1: $('#familyname1').val(),
							 familyname2: $('#familyname2').val(),
							 familyname3: $('#familyname3').val(),
							 familyname4: $('#familyname4').val(),
							 familyname5: $('#familyname5').val(),
							 familyfullname: $('#familyfullname').val(),
							 familygenderid: $('#familygenderid').val(),
							 familyreligionid: $('#familyreligionid').val(),
							 familybloodgroupid: $('#familybloodgroupid').val(),
							 familybirthdate: GetDateFromTextBox($('#familybirthdate').val()),
							 familybirthdocno: $('#familybirthdocno').val(),
							 familybirthdocdate: GetDateFromTextBox($('#familybirthdocdate').val()),
							 familycountryid: $('#familycountryid').val(),
							 familynationalityid: $('#familynationalityid').val(),
							 familymaritalstatusid: $('#familymaritalstatusid').val(),
							 familycuraddressflatno: $('#familycuraddressflatno').val(),
							 familycuraddresshouseno: $('#familycuraddresshouseno').val(),
							 familycuraddressstreet: $('#familycuraddressstreet').val(),
							 familycuradrressblock: $('#familycuradrressblock').val(),
							 familycurcountryid: $('#familycurcountryid').val(),
							 familycurgovnerid: $('#familycurgovnerid').val(),
							 familycurareaid: $('#familycurareaid').val(),
							 familymobile1: $('#familymobile1').val(),
							 familytelephone1: $('#familytelephone1').val(),
							 familyperaddressflatno: $('#familyperaddressflatno').val(),
							 familyperaddresshouseno: $('#familyperaddresshouseno').val(),
							 familyperaddressstreet: $('#familyperaddressstreet').val(),
							 familyperadrresspo: $('#familyperadrresspo').val(),
							 familyperadrressps: $('#familyperadrressps').val(),
							 familyperaddressdist: $('#familyperaddressdist').val(),
							 familyperaddresscountryid: $('#familyperaddresscountryid').val(),
							 familymarriagedate: GetDateFromTextBox($('#familymarriagedate').val()),
							 familymarriagedocno: $('#familymarriagedocno').val(),
							 familymarriagedocdate: GetDateFromTextBox($('#familymarriagedocdate').val()),
							 marriagefiledescription: $('#marriagefiledescription').val(),
							 marriagefilepath: $('#marriagefilepath').val(),
							 marriagefilename: $('#marriagefilename').val(),
							 marriagefiletype: $('#marriagefiletype').val(),
							 marriagefileextension: $('#marriagefileextension').val(),
							 marriageserialno: $('#marriageserialno').val(),
							 divorcedate: GetDateFromTextBox($('#divorcedate').val()),
							 divorcedocno: $('#divorcedocno').val(),
							 divorcedocdate: GetDateFromTextBox($('#divorcedocdate').val()),
							 divorcefiledescription: $('#divorcefiledescription').val(),
							 divorcefilepath: $('#divorcefilepath').val(),
							 divorcefilename: $('#divorcefilename').val(),
							 divorcefiletype: $('#divorcefiletype').val(),
							 divorcefileextension: $('#divorcefileextension').val(),
							 fatherstatusid: $('#fatherstatusid').val(),
							 isservedinmilitary: $('#isservedinmilitary').val(),
							 fathermilitarynokw: $('#fathermilitarynokw').val(),
							 fathermilitarynobd: $('#fathermilitarynobd').val(),
							 workplace: $('#workplace').val(),
							 workdesignation: $('#workdesignation').val(),
							 familydeathdate: GetDateFromTextBox($('#familydeathdate').val()),
							 familydeathdocno: $('#familydeathdocno').val(),
							 familydeathdocdate: GetDateFromTextBox($('#familydeathdocdate').val()),
							 familydeathfiledescription: $('#familydeathfiledescription').val(),
							 familydeathfilepath: $('#familydeathfilepath').val(),
							 familydeathfilename: $('#familydeathfilename').val(),
							 familydeathfiletype: $('#familydeathfiletype').val(),
							 familydeathfileextension: $('#familydeathfileextension').val(),
							 separetiondate: GetDateFromTextBox($('#separetiondate').val()),
							 separetionreason: $('#separetionreason').val(),
							 separetiondocno: $('#separetiondocno').val(),
							 separetiondocdate: GetDateFromTextBox($('#separetiondocdate').val()),
							 remarks: $('#remarks').val(),
							 forreview: $('#forreview').val(),
							 cor_foldercontentsList: fileobjects

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "HrFamilyInfo/HrFamilyInfoInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "HrFamilyInfo/HrFamilyInfo";
                                            $('#mcHrFamilyInfoNew').html('');
                                            $('#modal-container-HrFamilyInfoNew').modal('hide');
                                            GetAllDataHrFamilyInfo();
                                        }
                                        else
                                        {
                                            $('#mcHrFamilyInfoNew').html('');
                                            $('#modal-container-HrFamilyInfoNew').modal('hide');
                                            GetAllDataHrFamilyInfo();
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
    
    
    
    $('body').on('click', '#btnModalCloseNew', function (event) {
        try {
            event.preventDefault();
            $('#mcHrFamilyInfoNew').html('');
            $('#modal-container-HrFamilyInfoNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
  

});



