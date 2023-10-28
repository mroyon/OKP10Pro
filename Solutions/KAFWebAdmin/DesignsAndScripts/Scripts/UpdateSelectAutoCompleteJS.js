$(document).ready(function () {
    $(".generat_AutoComplte_unit").each(function () {
       // console.log($(this)[0])
        generateAutoCompleteUnitControl($(this)[0])
    });

    $(".generat_AutoComplte_user").each(function () {
       // console.log($(this)[0])
        generateAutoCompleteUserControl($(this)[0]);
    })
})