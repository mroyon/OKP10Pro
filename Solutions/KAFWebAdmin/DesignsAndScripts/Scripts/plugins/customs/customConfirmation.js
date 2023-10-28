function confirmationDialogWithContinue(title, msg, buttonConfText, buttonCancText, buttonContText) {
    var defer = $.Deferred();
    try {
        $.confirm({
            title: title,
            content: msg,
            icon: 'fa fa-question-circle',
            animation: 'scale',
            closeAnimation: 'scale',
            opacity: 0.5,
            buttons: {
                'confirm': {
                    text: buttonConfText,
                    btnClass: 'btn-blue ',
                    action: function () {
                        defer.resolve("true");//this text 'true' can be anything. But for this usage, it should be true or false.
                    }
                },
                'cancel': {
                    text: buttonCancText,
                    action: function () {
                        defer.resolve("false");//this text 'true' can be anything. But for this usage, it should be true or false.
                    }
                },
                'continue': {
                    text: buttonContText,
                    action: function () {
                        defer.resolve("none");//this text 'true' can be anything. But for this usage, it should be true or false.
                    }
                },
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
    return defer.promise();
}

function confirmationDialog(title, msg, buttonConText, buttonCanText) {
    var defer = $.Deferred();
    try {
        $.confirm({
            title: title,
            content: msg,
            icon: 'fa fa-question-circle',
            animation: 'scale',
            closeAnimation: 'scale',
            opacity: 0.5,
            buttons: {
                'confirm': {
                    text: buttonConText,
                    btnClass: 'btn-blue',
                    action: function () {
                        defer.resolve("true");//this text 'true' can be anything. But for this usage, it should be true or false.
                    }
                },
                'cancel': {
                    text: buttonCanText,
                    action: function () {
                        defer.resolve("false");//this text 'true' can be anything. But for this usage, it should be true or false.
                    }
                },
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
    return defer.promise();
}

function inforamtionDialog(title, msg, buttonOKText) {
    var defer = $.Deferred();
    try {
        $.confirm({
            title: title,
            content: msg,
            icon: 'fa fa-info-circle',
            animation: 'scale',
            closeAnimation: 'scale',
            opacity: 0.5,
            buttons: {
                'confirm': {
                    text: buttonOKText,
                    btnClass: 'btn-blue',
                    action: function () {
                        defer.resolve("true");//this text 'true' can be anything. But for this usage, it should be true or false.
                    }
                },
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
    return defer.promise();
}

function errorDialog(msg, buttonOKText) {
    var defer = $.Deferred();
    try {
        $.confirm({
            title: "Error!",
            content: msg,
            icon: 'fa fa-exclamation-circle',
            animation: 'scale',
            closeAnimation: 'scale',
            opacity: 0.5,
            buttons: {
                'confirm': {
                    text: buttonOKText,
                    btnClass: 'btn-blue',
                    action: function () {
                        defer.resolve("true");//this text 'true' can be anything. But for this usage, it should be true or false.
                    }
                },
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
    return defer.promise();
}