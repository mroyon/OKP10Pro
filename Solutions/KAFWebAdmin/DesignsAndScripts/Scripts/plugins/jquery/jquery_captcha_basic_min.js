﻿/**
 * jQuery Captcha Basic
 *
 * @fileoverview  Plugin object
 * @link          https://github.com/pemre/jquery-captcha-basic/
 * @author        Emre Piskin (http://rencs.com/)
 * @requires      jQuery 1.12.4+
 */

(function ($) {
    "use strict";

    $.fn.captcha = function (param) {

        // DEFAULT VARIABLES
        var params = $.extend({
            idCaptchaText: 'captchaText',   // The ID for the captcha text. Default is 'captchaText'.
            idCaptchaInput: 'captchaInput', // The ID for the captcha input. Default is 'captchaInput'.
            class: ''                       // Class name for the submit button toggle. Default is ''.
        }, param);

        // Find and disable the submit button
        var submit = $(".btnhascaptcha");
        submit.attr('disabled', 'disabled');

        $(".divcaptcha").empty();

        
        $(".divcaptcha").append($('<label id="' + params.idCaptchaText + '"></label>'));
        $(".divcaptcha").append($('<input id="' + params.idCaptchaInput + '" aria-label="Captcha Input" type="text" required class="form-control text-box single-line" placeholder="Please enter the above result"  autocomplete="off" >'));

        var $input = $('<input type="button" value="Reload Captcha" class="button-flat-primary button button-medium" />');

        var $lnk = $('<a href=\"#\">Reload Captcha</a>');

        //$input.click(function () { myFunction(); }).appendTo($(".divcaptcha"));
        $lnk.click(function () { $('.appregform').captcha(); }).appendTo($(".divcaptcha"));

        // Insert captcha text and input before the submit button with the given ID's
        //.insertBefore(submit);
        //.insertBefore(submit);

        // Select text and input elements to fill
        var label = $('#' + params.idCaptchaText);
        var input = $('#' + params.idCaptchaInput);


        // Generate random numbers and the sum of them
        var rndmNr1 = Math.floor(Math.random() * 10),
            rndmNr2 = Math.floor(Math.random() * 10),
            totalNr = rndmNr1 + rndmNr2;
        var tex = rndmNr1 + '+' + rndmNr2 + '=';

        // Print the numbers to screen
        $(label).text(tex);

        // Check the input value, enable it if the sum is correct
        $(input).keyup(function () {
            if ($(this).val() == totalNr)
                submit.removeAttr('disabled').addClass(params.class);
            else
                submit.attr('disabled', 'disabled').removeClass(params.class);
        });

        // Don't breake jQuery chain!
        return this;
    }
})(jQuery);
