

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

            //var kaffileUploader = $('#id').kaffileUploader();
            //var fileobjects_tbl_marriagefiledescription = $('#id').kaffileUploader.GetFilesForActions('tbl_marriagefiledescription');
            //var fileobjects_tbl_divorcefiledescription = $('#id').kaffileUploader.GetFilesForActions('tbl_divorcefiledescription');
            //var fileobjects_tbl_familydeathfiledescription = $('#id').kaffileUploader.GetFilesForActions('tbl_familydeathfiledescription');
            //var fileobjects = fileobjects_tbl_marriagefiledescription.concat(fileobjects_tbl_divorcefiledescription,fileobjects_tbl_familydeathfiledescription);

            // $.each(fileobjects, function (key, valueObj) {
            //	  valueObj.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
            //  });




            if (form.valid()) {

                var input_familyPassport = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "HrFamilyInfoCreate",
                    currenturl: window.location.href,

                    familypassportid: $('#hr_familypassportinfo_familypassportid').val(),
                    hrfamilyid: $('#hr_familypassportinfo_hrfamilyid').val(),
                    hrbasicid: $('#hrbasicid').val(),
                    familypassportno: $('#hr_familypassportinfo_familypassportno').val(),
                    familypassportissuedate: GetDateFromTextBox($('#hr_familypassportinfo_familypassportissuedate').val()),
                    familypassportexpirydate: GetDateFromTextBox($('#hr_familypassportinfo_familypassportexpirydate').val()),
                    familypassportissuecountryid: $('#hr_familypassportinfo_familypassportissuecountryid').val(),
                    isfamilyfamilypassport: $('#hr_familypassportinfo_isfamilyfamilypassport').val(),
                    familypassportfiledescription: $('#hr_familypassportinfo_familypassportfiledescription').val(),
                    familypassportfilepath: $('#hr_familypassportinfo_familypassportfilepath').val(),
                    familypassportfilename: $('#hr_familypassportinfo_familypassportfilename').val(),
                    familypassportfiletype: $('#hr_familypassportinfo_familypassportfiletype').val(),
                    familypassportextension: $('#hr_familypassportinfo_familypassportextension').val(),
                    familypassportfileid: $('#hr_familypassportinfo_familypassportfileid').val(),
                    remarks: $('#hr_familypassportinfo_remarks').val(),
                    forreview: $('#hr_familypassportinfo_forreview').val(),
                    iscurrent: $('#hr_familypassportinfo_iscurrent').val(),
                    //cor_foldercontentsList: fileobjects

                });

                var input_familycivilid = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "HrFamilyInfoCreate",
                    currenturl: window.location.href,

                    familycivilid: $('#hr_familycivilidinfo_familycivilid').val(),
                    hrfamilyid: $('#hrfamilyid').val(),
                    hrbasicid: $('#hrbasicid').val(),
                    familycivilidno: $('#hr_familycivilidinfo_familycivilidno').val(),
                    serialno: $('#hr_familycivilidinfo_serialno').val(),
                    familycivilidissuedate: GetDateFromTextBox($('#hr_familycivilidinfo_familycivilidissuedate').val()),
                    familycivilidexpirydate: GetDateFromTextBox($('#hr_familycivilidinfo_familycivilidexpirydate').val()),
                    familycivilidfiledescription: $('#hr_familycivilidinfo_familycivilidfiledescription').val(),
                    familycivilidfilepath: $('#hr_familycivilidinfo_familycivilidfilepath').val(),
                    familycivilidfilename: $('#hr_familycivilidinfo_familycivilidfilename').val(),
                    familycivilidfiletype: $('#hr_familycivilidinfo_familycivilidfiletype').val(),
                    familycivilidextension: $('#hr_familycivilidinfo_familycivilidextension').val(),
                    familycivilidfileid: $('#hr_familycivilidinfo_familycivilidfileid').val(),
                    remarks: $('#hr_familycivilidinfo_remarks').val(),
                    forreview: $('#hr_familycivilidinfo_forreview').val(),
                    iscurrent: $('#hr_familycivilidinfo_iscurrent').val(),

                });

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
                    hr_familypassportinfo: input_familyPassport,
                    hr_familycivilidinfo: input_familycivilid

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
                                        else {
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



