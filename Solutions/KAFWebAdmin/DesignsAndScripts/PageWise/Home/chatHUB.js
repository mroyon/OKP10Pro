startChartHub();
$('#chatlog').slimscroll();


function startChartHub() {

    var chat = $.connection.chatHub;

    // Get the user name.
    $('#nickname').val($('#txtUserNameSTK').val());

    chat.client.differentName = function (name) {
        try {
            //showModalUserNickName();
            return false;
            // Prompts for different user name
            $('#nickname').val($('#txtUserNameSTK').val());
            chat.server.notify($('#nickname').val(), $.connection.hub.id);
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    };

    chat.client.online = function (name) {
        try {
            // Update list of users
            if (name != $('#nickname').val()) {                
                $("#users").append('<option value="' + name + '">' + name + '</option>');
            }
            else
                $('#onlineusers').append('<div >' + name + '</div>'); 
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    };

    chat.client.reloadmsg = function (msglist) {
        try {
            var li = JSON.parse(msglist)
            for (var i = 0; i < li.length; i++) {
                var obj = li[i];

                if (obj.fromUserName == $('#txtUserNameSTK').val())
                    $('#chatlog').append('<div class="message-orange"><p class="message-content">' + obj.msg + '</p></div>');
                else
                    $('#chatlog').append('<div class="message-blue"><p class="message-content">' + obj.msg + '</p><div class="message-timestamp-right">' + obj.fromUserName + '</div></div>');
            }

            $("#chatlog").animate({ scrollTop: $('#chatlog').prop("scrollHeight") }, 1000);
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    };

    chat.client.enters = function (name) {
        try {
            $('#chatlog').append('<div style="font-style:italic;"><i>' + name + ' joins the conversation</i></div>');
            $("#users").append('<option value="' + name + '">' + name + '</option>');
            $('#onlineusers').append('<div class="border">' + name + '</div>');
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    };
    // Create a function that the hub can call to broadcast chat messages.
    chat.client.broadcastMessage = function (name, message) {
        try {
            //Interpret smileys
            message = message.replace(":)", "<img src=\"/images/smile.gif\" class=\"smileys\" />");
            message = message.replace("lol", "<img src=\"/images/laugh.gif\" class=\"smileys\" />");
            message = message.replace(":o", "<img src=\"/images/cool.gif\" class=\"smileys\" />");

            //display the message
            if (name == $('#txtUserNameSTK').val())
                $('#chatlog').append('<div class="message-orange"><p class="message-content">' + message + '</p></div>');
            else
                $('#chatlog').append('<div class="message-blue"><p class="message-content">' + message + '</p><div class="message-timestamp-right">' + name + '</div></div>');

            $("#chatlog").animate({ scrollTop: $('#chatlog').prop("scrollHeight") }, 1000);

            //bell show
            if (name != $('#txtUserNameSTK').val()) {
                if ($("#control-sidebar-settings-tab").is(":visible")) {

                    $('#cogsnotification').removeClass("badge badge-danger");
                    $('#cogsnotification').css('background-color', '');
                    $('#cogsnotification').html("");
                    $('#cogsnotification').append("");
                }
                else {

                    $('#cogsnotification').addClass("badge badge-danger");
                    $('#cogsnotification').css('background-color', 'red');
                    $('#cogsnotification').html("");
                    $('#cogsnotification').append("<i class='fa fa-bell'></i>");
                }
            }

        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    };

    chat.client.disconnected = function (name) {
        try {
            //Calls when someone leaves the page
            $('#chatlog').append('<div style="font-style:italic;"><i>' + name + ' leaves the conversation</i></div>');
            $('#onlineusers div').remove(":contains('" + name + "')");
            $("#users option").remove(":contains('" + name + "')");
        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    }

    $.connection.hub.start().done(function () {
        try {
            //Calls the notify method of the server
            chat.server.notify($('#nickname').val(), $.connection.hub.id);
            chat.server.newContosoChatMessage($('#nickname').val());

            $('#btnsend').click(function () {

                if ($("#users").val() == "All") {
                    // Call the Send method on the hub.
                    chat.server.send($('#nickname').val(), $('#message').val());
                }
                else {
                    chat.server.sendToSpecific($('#nickname').val(), $('#message').val(), $("#users").val());
                }
                // Clear text box and reset focus for next comment.
                $('#message').val('').focus();
            });

            $.connection.hub.logging = true;

        } catch (e) {
            $.alert({
                title: _getCookieForLanguage("_informationTitle"),
                content: e.message,
                type: 'red'
            });
        }
    });

}