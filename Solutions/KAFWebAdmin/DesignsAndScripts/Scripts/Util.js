jQuery.validator.methods["date"] = function (value, element) { return true; }

function stringToBoolean(string) {
    if (string != null && typeof string != undefined) {
        string = string.toString();
        switch (string.toLowerCase().trim()) {
            case "true": case "yes": case "1": return true;
            case "false": case "no": case "0": case null: return false;
            default: return Boolean(string);
        }
    }
}

function CalcDateDiff(date1, date2) {
    if (date1 != null && date2 != null) {
        var Difference_In_Time = new Date(date2).getTime() - new Date(date1).getTime();

        // To calculate the no. of days between two dates
        var Difference_In_Days = Difference_In_Time / (1000 * 3600 * 24);

        return Difference_In_Days;
    }
}

function GetDateFromTextBox(strdate) {
    if (strdate != "" && typeof strdate !== 'undefined') {
        if (strdate.indexOf('T') != -1)
            strdate = strdate.substring(0, strdate.indexOf('T') - 1).trim();

        var dtspl1 = strdate.split("-");
        var retdate = new Date(dtspl1[2], dtspl1[1] - 1, dtspl1[0]);
        retdate = retdate.toISOString();
        //var retdate = $(strdate).val();
        return retdate;
    }
}

function GetDateStringFromTextBox(strdate) {
    if (strdate != "" && typeof strdate !== 'undefined') {
        if (strdate.indexOf('T') != -1)
            strdate = strdate.substring(0, strdate.indexOf('T') - 1).trim();

        var dtspl1 = strdate.split("-");
        var retdate = dtspl1[1]+'-'+ dtspl1[0]+'-'+ dtspl1[2];
       
        var strretdate = "convert(datetime,'" +retdate+"', 110)"; //$(strdate).val();
        return strretdate;
    }
}

function clearAllform() {

    var str = "#" + $(".btnSearch").parent().parent().find('.select2-hidden-accessible').attr('id');
   // $(str).val('');
    //$(str).select2('destroy'); 

    //$(str).val('');
    //$(str).select2().trigger('change');

    //$(str).select2('destroy');
    $(str).val(null).trigger('change');

   
    $(".btnSearch").parent().parent().find('input').val('');

    //setTimeout(function () {
    //     loadselect2(); 
    //},300)   

    $('#txtRepLetterDate').prop('disabled', false);
    $('#replacementid').prop('disabled', false);

    $('#txtRepPassportLetterDate').prop('disabled', false);
    $('#RepPassportID').prop('disabled', false);
    $('#txtDemandLetterDate').prop('disabled', false);

    $('#txtVisaDemandLetterDate').prop('disabled', false);
    $('#VisaDemandID').prop('disabled', false);

    $('#existingflightid').prop('disabled', false);
    $('#txtFlightLetterDate').prop('disabled', false);
    
    $("#dvInfoDetail").addClass("hidden");
    $('#btnClear').hide();
}

function GetDateTimeFromTextBox(strdate) {
    if (strdate != "" && typeof strdate !== 'undefined') {
        //if (strdate.indexOf('T') != -1)
        //    strdate = strdate.substring(0, strdate.indexOf('T') - 1).trim();

        var dtspltime = strdate.split(" ");

        var dtspl1 = dtspltime[0].split("-");
        var dtspl2 = dtspltime[1].split(":");

        var retdate = new Date(dtspl1[2], dtspl1[1] - 1, dtspl1[0], dtspl2[0], dtspl2[1]);
        retdate = retdate.toISOString();

        //var retdate = $(strdate).val();
        return retdate;
    }
}
function GetDOBFromCivilID(strcivilid) {
    //291032804022
    var dob = "";
    var firstch = strcivilid.slice(0, 1);
    var strdt = strcivilid.substring(1, 7);
    var arrdt = strdt.split(/(?=(?:..)*$)/);
    var dateRegex = /^(?=\d)(?:(?:31(?!.(?:0?[2469]|11))|(?:30|29)(?!.0?2)|29(?=.0?2.(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00)))(?:\x20|$))|(?:2[0-8]|1\d|0?[1-9]))([-.\/])(?:1[012]|0?[1-9])\1(?:1[6-9]|[2-9]\d)?\d\d(?:(?=\x20\d)\x20|$))?(((0?[1-9]|1[012])(:[0-5]\d){0,2}(\x20[AP]M))|([01]\d|2[0-3])(:[0-5]\d){1,2})?$/;

    if (firstch === "2") {
        dob = arrdt[2] + "-" + arrdt[1] + "-" + "19" + arrdt[0];
    }
    else if (firstch === "3") {
        dob = arrdt[2] + "-" + arrdt[1] + "-" + "20" + arrdt[0];
    }

    if (dateRegex.test(dob)) {
        return dob;
    }
    else
        return null;

}

//function populateCalendarWithTime(item) {
//    $(item).datetimepicker({
//        //dateFormat: 'dd-mm-yy',
//        //showButtonPanel: true,
//        //closeText: 'Clear',
//        //changeMonth: true,
//        //changeYear: true,
//        //onClose: function () {
//        //    //var event = arguments.callee.caller.caller.arguments[0];
//        //    //if ($(event.delegateTarget).hasClass('ui-datepicker-close')) {
//        //    //    $(this).val('');
//        //    //}
//        //}


//        controlType: 'select',
//        oneLine: true,
//        timeFormat: 'hh:mm tt'
//        //,
//        //onClose: function () {
//        //    var event = arguments.callee.caller.caller.arguments[0];
//        //    if ($(event.delegateTarget).hasClass('ui-datepicker-close')) {
//        //        $(this).val('');
//        //    }
//        //}
//    });

//    //$.validator.methods["date"] = function (value, element) { return true; };
//}
//function populateCalendar(item) {
//    $(item).datepicker({
//        dateFormat: 'dd-mm-yy',
//        showButtonPanel: true,
//        closeText: 'Clear',
//        changeMonth: true,
//        changeYear: true,
//        onClose: function () {
//            var event = arguments.callee.caller.caller.arguments[0];
//            if ($(event.delegateTarget).hasClass('ui-datepicker-close')) {
//                $(this).val('');
//            }
//        }
//    });

//    $.validator.methods["date"] = function (value, element) { return true; }
//}
//function checkformdatevalidation() {
//    $(".datefield").each(function (index) {
//        var comparewith = $(this).attr('comparewith');
//        if (typeof comparewith != 'undefined' && comparewith.length > 0) {
//            datevalidation($(this), $('#' + comparewith));
//        }
//    });

//    $(".datetimefield").each(function (index) {
//        var comparewith = $(this).attr('comparewith');
//        if (typeof comparewith != 'undefined' && comparewith.length > 0) {
//            datetimevalidation($(this), $('#' + comparewith));
//        }
//    });
//}

//function datevalidation(startdate, enddate) {
//    $(startdate).change(function (e) {
//        $(enddate).datepicker("option", "minDate", new Date(GetDateFromTextBox($(startdate).val())));
//    });

//    $(enddate).change(function (e) {
//        $(startdate).datepicker("option", "maxDate", new Date(GetDateFromTextBox($(enddate).val())));
//    });
//}
//function datetimevalidation(startdate, enddate) {
//    $(startdate).change(function (e) {
//        //console.log(new Date(GetDateTimeFromTextBox(startdate)));
//        //console.log(GetDateTimeFromTextBox(startdate));
//        $(enddate).datetimepicker("option", "minDate", GetDateTimeFromTextBox(startdate));
//        //$(enddate).datetimepicker("option", "minTime", '18:00');
//    });

//    $(enddate).change(function (e) {
//        //console.log(GetDateTimeFromTextBox(startdate));
//        $(startdate).datetimepicker("option", "maxDate", GetDateTimeFromTextBox(enddate));
//    });
//}
//var setMin = function (currentDateTime) {
//    this.setOptions({
//        minDate: '-1970/01/02'
//    });
//    this.setOptions({
//        minTime: '11:00'
//    });
//};

//console.log($().jquery);
//console.log($j().jquery);

//********************************************** For Date & Time ********************************************************
//      'L' for date only
//      'LT' for time only
//      'L LT' for date and time
function initiateCheckAll() {

    $("#chkAll").change(function () {
        if ($(this).prop('checked') == true) {
            $(".chkSelect:not(:disabled)").prop('checked', true);
        }
        else {
            $(".chkSelect:not(:disabled)").prop('checked', false);
        }
    });

    $('.chkAssign').click(function () {
        if ($(this).prop("checked") == true)
            $('.chkAssign').not(this).prop('checked', false);
        else
            $('.chkAssign').not(this).prop('checked', true);
    });

}

$(document).ready(function () {

    $("#chkAll").change(function () {
            if ($(this).prop('checked') == true) {
                $(".chkSelect:not(:disabled)").prop('checked', true);
            }
            else {
                $(".chkSelect:not(:disabled)").prop('checked', false);
            }
        });

    initializedatetimepicker();
    if (dir == "rtl") {
        $.extend(true, $.fn.dataTable.defaults, {
            oLanguage: {
                oAria: {
                    sSortAscending: ": activate to sort column ascending",
                    sSortDescending: ": activate to sort column descending"
                },
                oPaginate: {
                    sFirst: "الأول",
                    sLast: "الأخير",
                    sNext: "التالي",
                    sPrevious: "السابق"
                },
                sEmptyTable: "لا توجد بيانات متاحة في الجدول",
                sInfo: "إظهار _START_ إلى _END_ من أصل _TOTAL_ مُدخل",
                sInfoEmpty: "يعرض 0 إلى 0 من أصل 0 سجلّ",
                sInfoFiltered: "(منتقاة من مجموع _MAX_ مُدخل)",
                sInfoPostFix: "",
                sDecimal: "",
                sThousands: ",",
                sLengthMenu: "أظهر مُدخلات _MENU_",
                sLoadingRecords: "Loading...",
                sProcessing: "جاري التحميل...",
                sSearch: "ابحث:",
                sSearchPlaceholder: "",
                sUrl: "",
                sZeroRecords: "لم يُعثر على أية سجلات"
            }
        });
    }
    else {
        $.extend(true, $.fn.dataTable.defaults, {
            oLanguage: {
                oAria: {
                    sSortAscending: ": activate to sort column ascending",
                    sSortDescending: ": activate to sort column descending"
                },
                oPaginate: {
                    sFirst: "First",
                    sLast: "Last",
                    sNext: "Next",
                    sPrevious: "Previous"
                },
                sEmptyTable: "No data available in table",
                sInfo: "Showing _START_ to _END_ of _TOTAL_ entries",
                sInfoEmpty: "Showing 0 to 0 of 0 entries",
                sInfoFiltered: "(filtered from _MAX_ total entries)",
                sInfoPostFix: "",
                sDecimal: "",
                sThousands: ",",
                sLengthMenu: "Show _MENU_ entries",
                sLoadingRecords: "Loading...",
                sProcessing: "Processing...",
                sSearch: "Search:",
                sSearchPlaceholder: "",
                sUrl: "",
                sZeroRecords: "No matching records found"
            
            }
        });
    }
});

function initializedatetimepicker() {

    $j('#fromdatetime').datetimepicker(
        {
            format: 'DD-MM-YYYY HH:mm'
        });
    $j('#todatetime').datetimepicker({
        useCurrent: false, //Important! See issue #1075
        format: 'DD-MM-YYYY HH:mm'
    });
    $j("#fromdatetime").on("dp.change", function (e) {
        $j('#todatetime').data("DateTimePicker").minDate(e.date);
    });
    $j("#todatetime").on("dp.change", function (e) {
        $j('#fromdatetime').data("DateTimePicker").maxDate(e.date);
    });
    $j('#datetimeonly').datetimepicker(
        {
            //format: 'L'
            format: 'DD-MM-YYYY HH:mm:ss'
        });
    $j('.datetimeonly').datetimepicker(
        {
            //format: 'L'
            format: 'DD-MM-YYYY HH:mm:ss'
        });

    //********************************************** For Date only ********************************************************
    //      'L' for date only
    //      'LT' for time only
    //      'L LT' for date and time

    $j('#fromdate').datetimepicker(
        {
            //format: 'L'
            format: 'DD-MM-YYYY'
        });
    $j('#todate').datetimepicker({
        useCurrent: false, //Important! See issue #1075
        //format: 'L'
        format: 'DD-MM-YYYY'
    });
    $j("#fromdate").on("dp.change", function (e) {
        $j('#todate').data("DateTimePicker").minDate(e.date);
    });
    $j("#todate").on("dp.change", function (e) {
        $j('#fromdate').data("DateTimePicker").maxDate(e.date);
    });

    // If any form has formdate todate  set

    $j('.fromdate').datetimepicker(
        {
            //format: 'L'
            format: 'DD-MM-YYYY'
        });
    $j('.todate').datetimepicker({
        useCurrent: false, //Important! See issue #1075
        //format: 'L'
        format: 'DD-MM-YYYY'
    });
    $j(".fromdate").on("dp.change", function (e) {
        $j(this).parent().parent().find('.todate').data("DateTimePicker").minDate(e.date);
    });
    $j(".todate").on("dp.change", function (e) {
        $j(this).parent().parent().find('.fromdate').data("DateTimePicker").maxDate(e.date);
    });

    // If any form has multiple formdate todate  set

    $j('.fromdate1').datetimepicker(
        {
            //format: 'L'
            format: 'DD-MM-YYYY'
        });
    $j('.todate1').datetimepicker({
        useCurrent: false, //Important! See issue #1075
        //format: 'L'
        format: 'DD-MM-YYYY'
    });
    $j(".fromdate1").on("dp.change", function (e) {
        $j('.todate1').data("DateTimePicker").minDate(e.date);
    });
    $j(".todate1").on("dp.change", function (e) {
        $j('.fromdate1').data("DateTimePicker").maxDate(e.date);
    });

    $j('.fromdate2').datetimepicker(
        {
            //format: 'L'
            format: 'DD-MM-YYYY'
        });
    $j('.todate2').datetimepicker({
        useCurrent: false, //Important! See issue #1075
        //format: 'L'
        format: 'DD-MM-YYYY'
    });
    $j(".fromdate2").on("dp.change", function (e) {
        $j('.todate2').data("DateTimePicker").minDate(e.date);
    });
    $j(".todate2").on("dp.change", function (e) {
        $j('.fromdate2').data("DateTimePicker").maxDate(e.date);
    });

    $j('.fromdate3').datetimepicker(
        {
            //format: 'L'
            format: 'DD-MM-YYYY'
        });
    $j('.todate3').datetimepicker({
        useCurrent: false, //Important! See issue #1075
        //format: 'L'
        format: 'DD-MM-YYYY'
    });
    $j('.fromdate4').datetimepicker(
        {
            //format: 'L'
            format: 'DD-MM-YYYY'
        });
    $j('.todate4').datetimepicker({
        useCurrent: false, //Important! See issue #1075
        //format: 'L'
        format: 'DD-MM-YYYY'
    });
    $j(".fromdate3").on("dp.change", function (e) {
        $j('.todate3').data("DateTimePicker").minDate(e.date);
    });
    $j(".todate3").on("dp.change", function (e) {
        $j('.fromdate3').data("DateTimePicker").maxDate(e.date);
    });
    $j(".fromdate4").on("dp.change", function (e) {
        $j('.todate4').data("DateTimePicker").minDate(e.date);
    });
    $j(".todate4").on("dp.change", function (e) {
        $j('.fromdate4').data("DateTimePicker").maxDate(e.date);
    });

    //--------------------------------
    $j('#dateonly').datetimepicker(
        {
            // format: 'L'
            format: 'DD-MM-YYYY'
        });
    $j('#dateonly input').attr('placeholder', 'DD-MM-YYYY');

    $j('.dateonly').datetimepicker(
        {
            // format: 'L'
            format: 'DD-MM-YYYY'
        });
    $j('.dateonly input').attr('placeholder', 'DD-MM-YYYY');

    $j('.dateonlytextbox').datetimepicker(
        {
            // format: 'L'
            format: 'DD-MM-YYYY'
        });
    // For 18yrs ago date use birthdateonly
    $j('.birthdateonly').datetimepicker(
        {
            // format: 'L'
            format: 'DD-MM-YYYY',
            defaultDate: moment().subtract(18, 'years'),
            useCurrent: false,
            maxDate: moment().subtract(18, 'years')
        });

    // For disable future date use pastdateonly
    $j('.pastdateonly').datetimepicker(
        {
            // format: 'L'
            format: 'DD-MM-YYYY',
            useCurrent: false,
            maxDate: moment()
        });


}
function removeA(arr) {
    var what, a = arguments, L = a.length, ax;
    while (L > 1 && arr.length) {
        what = a[--L];
        while ((ax = arr.indexOf(what)) != -1) {
            arr.splice(ax, 1);
        }
    }
    return arr;
}

function getDateIfDate(d) {
    var m = d.match(/\/Date\((\d+)\)\//);
    var retstr = m ? (new Date(+m[1])).toLocaleDateString('en-US', { month: '2-digit', day: '2-digit', year: 'numeric' }) : d;

    if (retstr.indexOf(' ') > -1)
        retstr = retstr.substring(0, retstr.indexOf(' ') - 1);

    return retstr;
}

$.fn.serializeFormToObject = function () {
    var obj = {};
    var serializedArr = this.serializeArray();
    $.each(serializedArr, function () {
        if (this.name === "notifyifpendingforlong") {
            console.log("")
        }
        if (obj[this.name] !== undefined) {
            if (!obj[this.name].push) {
                obj[this.name] = [obj[this.name]];
            }
            obj[this.name].push(this.value || '');
        } else {
            obj[this.name] = this.value || '';
        }
    });

    return obj;
};

function datetoStr(data) {
    if (data != null) {
        var regex = /-?\d+/;
        var match = regex.exec(data);
        var pubdate = new Date(parseInt(match[0]));

        var dd = pubdate.getDate(); var mm = pubdate.getMonth() + 1;
        var yyyy = pubdate.getFullYear();

        if (dd < 10) { dd = '0' + dd }

        if (mm < 10) { mm = '0' + mm }

        var today = dd + '/' + mm + '/' + yyyy;// + ' ' + pubdate.getHours() + ':' + pubdate.getMinutes() + ':' + pubdate.getSeconds();
        return today;
    }
    else {
        return "";
    }
}