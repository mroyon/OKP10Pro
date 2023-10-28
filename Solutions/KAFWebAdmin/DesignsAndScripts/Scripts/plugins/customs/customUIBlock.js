function DisplayProgressMessage(ctl, msg) {
    // Turn off the "Save" button and change text
    $(ctl).prop("disabled", true).text(msg);
    // Gray out background on page
    $("body").addClass("submit-progress-bg");
    // Wrap in setTimeout so the UI can update the spinners
    setTimeout(function () {
        $(".submit-progress").removeClass("hidden");
    }, 6);
    return true;
}

function RemoveProgressMessage(ctl) {
    // Turn off the "Save" button and change text
    $(ctl).remove();
    // Gray out background on page
    $("body").removeClass("submit-progress-bg");
    // Wrap in setTimeout so the UI can update the spinners
    setTimeout(function () {
        $(".submit-progress").addClass("hidden");
    }, 6);
    return true;
}