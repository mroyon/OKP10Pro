var baseurl = $('#txtBaseUrl').val();
$(document).ready(function () {
    $(".reveal").on('click', function () {

        if ($(".pwd").attr('type') === 'password') {
            $(".pwd").attr('type', 'text');
        } else {
            $(".pwd").attr('type', 'password');
        }
    });
});

$(document).ready(function () {
    //$.getJSON('https://api.ipify.org/?format=json', function (data) {
    //    $('.txtuserip').val(data.ip);
    //   // $('.LoginForm').captcha();
    //    LoadQuestionCombo();
    //});

    //$.getJSON('https://ipapi.co/json/', function (data) {
    //    $('.txtuserip').val(data.ip);
    //    $('.LoginForm').captcha();
    //    LoadQuestionCombo();
    //});

    //$.ajax({
    //    url: baseurl + "home/GetClientIPAddress",
    //    //data: input,
    //    type: 'POST',
    //    async: false,
    //    success: function (data) {
    //        //console.log(data);
    //        $('.txtuserip').val(data.data);
    //    }
    //});
    //LoadQuestionCombo();

   
});


$('body').on('click', '#btnLogin', function (event) {
    try {
       
        $("#modal-container-Login").modal("show");
       

    } catch (e) {
        
    }
});

