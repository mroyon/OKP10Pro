function generateAutoCompleteUserControl(txtid) {
    var path = $('#txtBaseUrl').val() + '/Common/SearchUser';
    $("#" + txtid.id).tokenInput(path, {
        preventDuplicates: true,
        hintText: txtid.getAttribute('hintText'),
        minChars: txtid.getAttribute('minchar'),
        tokenLimit: txtid.getAttribute('maxlength'),
        onAdd: function (item) {
            //alert("Added " + item.name);
            if (stringToBoolean(txtid.getAttribute('hasCallback')) == true)
                afteradd(item);
          
            
        },
        onDelete: function (item) {
            if (stringToBoolean(txtid.getAttribute('hasCallback')) == true)
                afterdelete(item);
        }
    });

    if (stringToBoolean(txtid.getAttribute('SetData')) == true) {
        var data = JSON.parse(JSON.parse(txtid.getAttribute('jsondata')));
        if (data != null) {
            var i;
            for (i = 0; i < data.length; i++) {
                $("#" + txtid.id).tokenInput("add", { id: data[i].itemid, name: data[i].itemname });
            }
        }
    }


    if (stringToBoolean(txtid.getAttribute('isreadonly')) == true) {
        $('#token-input-' + txtid.id).attr('disabled', 'disabled');
        $('#token-input-' + txtid.id).parent().parent().find('.token-input-delete-token').remove();
        //$(txtid).parent().parent().find('.token-input-list').css('background-color', '#eee');
        //$('#token-input-' + txtid.id).css('background-color', '#eee');
    }
    else   if (stringToBoolean(txtid.getAttribute('hasCheckLoadedItem')) == true)
        checkloadeditem();



    $(".token-input-dropdown").css("z-index", "9999");

    $("#" + txtid.id).removeClass('generat_AutoComplte_user');
};



function generateAutoCompleteUnitControl(txtid) {
    var path = $('#txtBaseUrl').val() + '/Common/SearchUnit';

    $("#" + txtid.id).tokenInput(path, {
        preventDuplicates: true,
        hintText: txtid.getAttribute('hintText'),
        minChars: txtid.getAttribute('minchar'),
        tokenLimit: txtid.getAttribute('maxlength')
    });

    if (stringToBoolean(txtid.getAttribute('SetData')) == true) {
        var data = JSON.parse(JSON.parse(txtid.getAttribute('jsondata')));
        if (data != null) {
            var i;
            for (i = 0; i < data.length; i++) {
                $("#" + txtid.id).tokenInput("add", { id: data[i].itemid, name: data[i].itemname });
            }
        }
    }

    if (stringToBoolean(txtid.getAttribute('@isreadonly')) == true) {
        $('#token-input-' + txtid.id).attr('disabled', 'disabled');
        $('#token-input-' + txtid.id).parent().parent().find('.token-input-delete-token').remove();
    }

    $(".token-input-dropdown").css("z-index", "9999");
    $("#" + txtid.id).removeClass('generat_AutoComplte_unit');
};


window.onload = function () {
    $(".generat_AutoComplte_unit").each(function () {
        generateAutoCompleteUnitControl($(this)[0])
    });

    $(".generat_AutoComplte_user").each(function () {
        generateAutoCompleteUserControl($(this)[0]);
    })
}




