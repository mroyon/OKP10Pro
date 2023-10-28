﻿

//PN: FILE NAME: "Newgen_building.js"


var baseurl = $('#txtBaseUrl').val();

$(document).ready(function () {

    AddAntiForgeryToken = function (data) {
        data.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();
        return data;
    };

   


    $('body').on('click', '#btnSaveGenBuilding', function (event) {
        try {
            event.preventDefault();
            var form = $('#frmGen_BuildingNew');
            jQuery.validator.unobtrusive.parse();
            jQuery.validator.unobtrusive.parse(form);




    
            if (form.valid()) {

               
                var input = AddAntiForgeryToken({
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "HrFamilyInfoCreate",
                    currenturl: window.location.href,

							 buildingid: $('#buildingid').val(),
							 buildingname: $('#buildingname').val(),
							 kwgovid: $('#kwgovid').val(),
							 kwareaid: $('#kwareaid').val(),
							 kwblockno: $('#kwblockno').val(),
							 kwstreet: $('#kwstreet').val(),
							 kwhouseno: $('#kwhouseno').val(),
							 isactive: $('#isactive').val(),
							 remarks: $('#remarks').val(),

                });


                confirmationDialog(_getCookieForLanguage("_confirmationTitle"), _getCookieForLanguage("_saveConfirmation"), _getCookieForLanguage("_btnYes"), _getCookieForLanguage("_btnNo")).then(function (answer) {
                    if (answer == "true") {

                        $.ajax({
                            url: baseurl + "GenBuilding/GenBuildingInsert",
                            data: input,
                            type: 'POST',
                            success: function (data) {
                                if (data.status === "success") {
                                    inforamtionDialog(data.title, data.responsetext, _getCookieForLanguage("_btnOK")).then(function (answer) {
                                        if (answer == "true") {
                                           //window.location.href =  baseurl + "GenBuilding/GenBuilding";
                                            $('#mcGenBuildingNew').html('');
                                            $('#modal-container-GenBuildingNew').modal('hide');
                                            GetAllDataGenBuilding();
                                        }
                                        else
                                        {
                                            $('#mcGenBuildingNew').html('');
                                            $('#modal-container-GenBuildingNew').modal('hide');
                                            GetAllDataGenBuilding();
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
            $('#mcGenBuildingNew').html('');
            $('#modal-container-GenBuildingNew').modal('hide');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });
    
  

});



