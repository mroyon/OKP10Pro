function base64ArrayBuffer(arrayBuffer) {
    var base64 = ''
    var encodings = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/'

    var bytes = new Uint8Array(arrayBuffer)
    var byteLength = bytes.byteLength
    var byteRemainder = byteLength % 3
    var mainLength = byteLength - byteRemainder

    var a, b, c, d
    var chunk

    // Main loop deals with bytes in chunks of 3
    for (var i = 0; i < mainLength; i = i + 3) {
        // Combine the three bytes into a single integer
        chunk = (bytes[i] << 16) | (bytes[i + 1] << 8) | bytes[i + 2]

        // Use bitmasks to extract 6-bit segments from the triplet
        a = (chunk & 16515072) >> 18 // 16515072 = (2^6 - 1) << 18
        b = (chunk & 258048) >> 12 // 258048   = (2^6 - 1) << 12
        c = (chunk & 4032) >> 6 // 4032     = (2^6 - 1) << 6
        d = chunk & 63               // 63       = 2^6 - 1

        // Convert the raw binary segments to the appropriate ASCII encoding
        base64 += encodings[a] + encodings[b] + encodings[c] + encodings[d]
    }

    // Deal with the remaining bytes and padding
    if (byteRemainder == 1) {
        chunk = bytes[mainLength]

        a = (chunk & 252) >> 2 // 252 = (2^6 - 1) << 2

        // Set the 4 least significant bits to zero
        b = (chunk & 3) << 4 // 3   = 2^2 - 1

        base64 += encodings[a] + encodings[b] + '=='
    } else if (byteRemainder == 2) {
        chunk = (bytes[mainLength] << 8) | bytes[mainLength + 1]

        a = (chunk & 64512) >> 10 // 64512 = (2^6 - 1) << 10
        b = (chunk & 1008) >> 4 // 1008  = (2^6 - 1) << 4

        // Set the 2 least significant bits to zero
        c = (chunk & 15) << 2 // 15    = 2^4 - 1

        base64 += encodings[a] + encodings[b] + encodings[c] + '='
    }

    return base64
}
(function ($) {

    "use strict";

    var methods = {
        init: function (options) {

        },
        show: function () { },// IS
        hide: function () { },// GOOD
        update: function (content) { }// !!!
    };

    $.fn.kaffileUploader = function (options) {

        var defaults = {
            _tableid: '_defaulttableid',
            _colname: 'null',
            _tabname: 'null',
            _modelname: 'defaultmodelname',
            _actionname: 'defaultactionname',
            _fileuploadbuttontext: 'defaultfileuploadbuttontext',
            _modelid: 'defaultmodelid',
            _modeltext: 'defaultmodeltext',
            _fileinputname: 'defaultupload',
            _containeruploadpreview: 'defaultcontainer',
            _containerdeletebuttontext: '',
            _ismultiple: true,
            //_isrequired: false,
            _uploadedfileextension: '',
            _fileobject: null
        };

        var options = $.extend({}, defaults, options);

        $.fn.kaffileUploader.GetFilesForActions = function (val) {

            var fileobjects = [];
            $('#' + val).find('tbody').find('tr').each(function (i, el) {
                var $tds = $(this).find('td');

                var filename = $(this).find('td').find('span.filename').text();
                var imgdata = $(this).find('td').find('img').attr('src');
                var filetype = $(this).find('td').find('input.filetype').val();
                var fileextension = $(this).find('td').find('input.fileextension').val();
                var filesize = $(this).find('td').find('span.filesize').text();

                var tablename = $(this).find('td').find('input.tablename').val();
                var columnname = $(this).find('td').find('input.columnname').val();
                var filepath = $(this).find('td').find('input.filepath').val();

                var columnpkid = $(this).find('td').find('input.columnpkid').val();
                var foldercontentid = $(this).find('td').find('input.foldercontentid').val();
                var folderid = $(this).find('td').find('input.folderid').val();

                var strValue1 = $(this).find('td').find('input.currentstate').val();

                if (foldercontentid > 0)
                    filename = filename;
                else
                    filename = Date.now().toString(36).toUpperCase() + (Math.random() * 100000000000000000).toString(36).toUpperCase();

                var fileobject = {
                    token: $(".txtUserSTK").val(),
                    userinfo: $(".txtServerUtilObj").val(),
                    useripaddress: $(".txtuserip").val(),
                    sessionid: $(".txtUserSes").val(),
                    methodname: "HrFamilyInfoCreate",
                    currenturl: window.location.href,

                    "columnpkid": columnpkid,
                    "tablename": tablename,
                    "coulumnname": columnname,
                    "foldercontentid": foldercontentid,
                    "folderid": folderid,
                    "filepath": filepath,
                    "userfilename": filename,
                    "filename": filename,
                    "filetype": filetype,
                    "extension": fileextension,
                    "filesize": filesize,
                    "comment": filepath,
                    "strValue1": strValue1
                };

                fileobjects.push(fileobject);
            });

            //if (val.length === 0 & options._isrequired == true) return false;
            //else return fileobjects;

            return fileobjects;
        };

        var stringbuilder = '';
        var dir = $("html").attr("dir");
        if (dir == "rtl") {
            this.initialize = function () {
                stringbuilder = '<div id="upload_button">';
                stringbuilder += '<label>';
                stringbuilder += '<label class="labelNormal  " for="' + options._modelid + '">' + options._modeltext + '</label>';
                if (options._containerdeletebuttontext != '') {

                    if (options._uploadedfileextension == '') {
                        if (options._ismultiple)
                            stringbuilder += '<input type="file" accept=".doc, .docx, .pdf, .xls, .xlsx, .jpg, .png, .jpeg, .gif, .bmp, .tif, .tiff|image/*" ngf-select ng-model="new_files" id="' + options._fileinputname + '" ng-change="fs.uploadFiles(new_files)" multiple>';
                        else
                            stringbuilder += '<input type="file" accept=".doc, .docx, .pdf, .xls, .xlsx, jpg, .png, .jpeg, .gif, .bmp, .tif, .tiff|image/*" ngf-select ng-model="new_files" id="' + options._fileinputname + '" ng-change="fs.uploadFiles(new_files)">';
                    }
                    else {
                        if (options._ismultiple)
                            stringbuilder += '<input type="file" accept="' + options._uploadedfileextension + '" ngf-select ng-model="new_files" id="' + options._fileinputname + '" ng-change="fs.uploadFiles(new_files)" multiple>';
                        else
                            stringbuilder += '<input type="file" accept="' + options._uploadedfileextension + '" ngf-select ng-model="new_files" id="' + options._fileinputname + '" ng-change="fs.uploadFiles(new_files)">';
                    }

                    stringbuilder += '<span class="btn btn-primary btnuploadcls" id="btn_' + options._fileinputname + '" >' + options._fileuploadbuttontext + '</span>';
                }
                stringbuilder += '</label>';
                stringbuilder += '</div>';
                stringbuilder += '<table class="table table-bordered table-hover footable" id="' + options._tableid + '">';
                stringbuilder += '<thead>';
                stringbuilder += '<tr>';
                stringbuilder += '<th class="footablecusheadercolor" style="width:60%;">اسم الملف</th>';
                stringbuilder += '<th class="footablecusheadercolor" style="width:20%;" data-hide="phone,tablet">الحجم بالكيلوبايت</th>';
                stringbuilder += '<th class="footablecusheadercolor" style="width:20%;" data-hide="phone,tablet">عمل<input type="hidden" value="" id="deleteditems" class="deleteditems"/></th>';
                stringbuilder += '</tr>';
                stringbuilder += '</thead>';
                stringbuilder += '<tbody id="' + options._containeruploadpreview + '"></tbody>';
                stringbuilder += '</table>';
                stringbuilder += '';

                this.append(stringbuilder);
                return this;
            };
        } else {
            this.initialize = function () {
                stringbuilder = '<div id="upload_button">';
                stringbuilder += '<label>';
                stringbuilder += '<label class="labelNormal  " for="' + options._modelid + '">' + options._modeltext + '</label>';
                if (options._containerdeletebuttontext != '') {

                    if (options._uploadedfileextension == '') {
                        if (options._ismultiple)
                            stringbuilder += '<input type="file" accept=".doc, .docx, .pdf, .xls, .xlsx, .jpg, .png, .jpeg, .gif, .bmp, .tif, .tiff|image/*" ngf-select ng-model="new_files" id="' + options._fileinputname + '" ng-change="fs.uploadFiles(new_files)" multiple>';
                        else
                            stringbuilder += '<input type="file" accept=".doc, .docx, .pdf, .xls, .xlsx, jpg, .png, .jpeg, .gif, .bmp, .tif, .tiff|image/*" ngf-select ng-model="new_files" id="' + options._fileinputname + '" ng-change="fs.uploadFiles(new_files)">';
                    }
                    else {
                        if (options._ismultiple)
                            stringbuilder += '<input type="file" accept="' + options._uploadedfileextension + '" ngf-select ng-model="new_files" id="' + options._fileinputname + '" ng-change="fs.uploadFiles(new_files)" multiple>';
                        else
                            stringbuilder += '<input type="file" accept="' + options._uploadedfileextension + '" ngf-select ng-model="new_files" id="' + options._fileinputname + '" ng-change="fs.uploadFiles(new_files)">';
                    }

                    stringbuilder += '<span class="btn btn-primary btnuploadcls" id="btn_' + options._fileinputname + '" >' + options._fileuploadbuttontext + '</span>';
                }
                stringbuilder += '</label>';
                stringbuilder += '</div>';
                stringbuilder += '<table class="table table-bordered table-hover footable" id="' + options._tableid + '">';
                stringbuilder += '<thead>';
                stringbuilder += '<tr>';
                stringbuilder += '<th class="footablecusheadercolor" style="width:60%;">File Name</th>';
                stringbuilder += '<th class="footablecusheadercolor" style="width:20%;" data-hide="phone,tablet">Size in KB</th>';
                stringbuilder += '<th class="footablecusheadercolor" style="width:20%;" data-hide="phone,tablet">Action  <input type="hidden" value="" id="deleteditems" class="deleteditems"/></th>';
                stringbuilder += '</tr>';
                stringbuilder += '</thead>';
                stringbuilder += '<tbody id="' + options._containeruploadpreview + '"></tbody>';
                stringbuilder += '</table>';
                stringbuilder += '';

                this.append(stringbuilder);
                return this;
            };
        }
        var baseurl = $('#txtBaseUrl').val();

        $(document).ready(function () {

            $('#' + options._fileinputname).change(function () {
                var fileUpload = $('#' + options._fileinputname).get(0);
                var files = fileUpload.files;
                var fileData = new FormData();
                for (var i = 0; i < files.length; i++) {

                    fileData.append(files[i].name, files[i]);
                    var filesize = files[i].size;
                    var fileName = files[i].name;
                    var fileURL = [];
                    var str = "";
                    writeDiv(files[i], $('#' + options._containeruploadpreview), options._containerdeletebuttontext);

                    if (options._ismultiple) {
                    }
                    else {
                        $('#btn_' + options._fileinputname).addClass('hidden');
                        //alert('#btn_' + options._fileinputname);
                        //.hide();
                    }

                }
            });

            function writeDiv(file, containeruploadpreview, containerdeletebuttontext) {
                var str = "";
                var reader = new FileReader();
                reader.onload = function (event) {
                    var extension = file.name.split('.').pop().toLowerCase();
                    extension = '.' + extension;
                    var cont = event.target.result
                    var base64String = cont.replace(/^[^,]*,/, '');

                    var baseurl = $('#txtBaseUrl').val();
                    var imgsource = '';

                    str = '<tr>';

                    if (extension == '.pdf')
                        imgsource = baseurl + "DesignsAndScripts/Images/pdf-icon.png";
                    else if (extension == '.jpg' || extension == '.png' || extension == '.bmp' || extension == '.gif' || extension == '.jpeg')
                        imgsource = event.target.result;
                    else if (extension == '.doc' || extension == '.docx')
                        imgsource = baseurl + "DesignsAndScripts/Images/word-icon.png";
                    else if (extension == '.xlsx' || extension == '.xls')
                        imgsource = baseurl + "DesignsAndScripts/Images/excel-icon.png";

                    str += '<td style="text-align: center" dir="ltr"><a download="' + file.name + '" target="_blank" href="' + event.target.result + '"><img src="' + imgsource + '" width="40px;" height="40px;" /></a></br><span class="filename">' + file.name + '</span></td>';
                    str += '<td style="text-align: center"><span class="filesize">' + file.size + '</span></td>';
                    str += '<td style="text-align: center">';

                    str += '<input type="hidden" value="-99" id="folderid" class="folderid"/>';
                    str += '<input type="hidden" value="-99" id="foldercontentid" class="foldercontentid"/>';
                    str += '<input type="hidden" value="-99" id="columnpkid" class="columnpkid"/>';
                    str += '<input type="hidden" value="' + file.name + '" id="filename" class="filename"/>';
                    str += '<input type="hidden" value="' + options._colname + '" id="columnname" class="columnname"/>';
                    str += '<input type="hidden" value="' + options._tabname + '" id="tablename" class="tablename"/>';
                    str += '<input type="hidden" value="' + file.type + '" id="filetype" class="filetype"/>';
                    str += '<input type="hidden" value="' + base64String + '" id="filepath" class="filepath"/>';
                    str += '<input type="hidden" value="' + extension + '" id="fileextension" class="fileextension"/>';
                    str += '<input type="hidden" value="added" id="currentstate" class="currentstate"/>';
                    if (containerdeletebuttontext != '')
                        str += '<button onclick="deletefile(this);"  class="btn btn-primary btn-md "><i class="fa fa-remove"> </i> ' + containerdeletebuttontext + '</button> ';
                    str += ' </td > ';
                    str += '</tr>';
                    $(containeruploadpreview).append(str);
                }
                reader.readAsDataURL(file);
            }

            this.deletefile = function (val) {
                try {

                    var uploadbtn = $(val).closest('div').find('.btnuploadcls');
                    //console.log(uploadbtn);
                    $(uploadbtn).removeClass('hidden'); //_fileinputname

                    var foldercontectid = $(val).siblings('input#foldercontentid').val();
                    var filename = $(val).siblings('input#filename').val();
                    var currentstate = $(val).siblings('input#currentstate').val();

                    if (foldercontectid > 0) {
                        var deletedids = $("#deleteditems").val();
                        deletedids = deletedids + "," + foldercontectid;
                        $("#deleteditems").val(deletedids);

                        var tr = $(val).parent().parent('tr');
                        $(val).siblings('input#currentstate').val('deleted');
                        $(tr).addClass('hidden');
                    }
                    else {
                        var tr = $(val).parent().parent('tr');
                        $(tr).remove();
                    }


                    //rn


                    //alert('#btn_' + options._fileinputname);
                    //.hide();


                    return;

                } catch (e) {
                    $.alert({
                        title: _getCookieForLanguage("_informationTitle"),
                        content: e.message,
                        type: 'red'
                    });
                }

            };

        });

        this.loadpreloaddata = function (_fileobjectmaster, containeruploadpreview, containerdeletebuttontext, columnname, ismultiple, fileinputname) {
            var str = "";
            var _fileobject = null;
            //var _fileobject = $.grep(_fileobjectmaster, function (element) { return element.coulumnname >= columnname; });
            //console.log(_fileobject);
            console.log(_fileobjectmaster);

            $.each(_fileobjectmaster, function (key, valueObj) {
                if (valueObj.coulumnname == columnname) {
                    //var base64String = "";
                    //var flag = 0;

                    var blob = null;
                    var xhr = new XMLHttpRequest();
                    xhr.open("GET", ftpSettingAddress + valueObj.filepath + valueObj.filename + valueObj.extension, true);
                    xhr.responseType = "blob";
                    xhr.onreadystatechange = function () {
                        if (xhr.readyState == 4) {
                            blob = xhr.response;
                            var myReader = new FileReader();
                            myReader.readAsArrayBuffer(blob);
                            myReader.addEventListener("loadend", function (e) {
                                var cont = e.srcElement.result;
                                var base64String = base64ArrayBuffer(cont);
                                //flag = 1;

                                str = '<tr>';

                                var baseurl = $('#txtBaseUrl').val();
                                var imgsource = '';

                                if (valueObj.extension == '.pdf')
                                    imgsource = baseurl + "DesignsAndScripts/Images/pdf-icon.png";
                                else if (valueObj.extension == '.jpg' || valueObj.extension == '.png' || valueObj.extension == '.bmp' || valueObj.extension == '.gif')
                                    imgsource = 'data:' + valueObj.filetype + ';base64,' + base64String;
                                else if (valueObj.extension == '.doc' || valueObj.extension == '.docx')
                                    imgsource = baseurl + "DesignsAndScripts/Images/word-icon.png";
                                else if (valueObj.extension == '.xlsx' || valueObj.extension == '.xls')
                                    imgsource = baseurl + "DesignsAndScripts/Images/excel-icon.png";

                                str += '<td style="text-align: center" dir="ltr"><a download="' + valueObj.filename + valueObj.extension + '" target="_blank" href="data:' + valueObj.filetype + ';base64,' + base64String + '"><img src="' + imgsource + '" width="40px;" height="40px;" /></a></br><span class="filename">' + valueObj.filename + '</span></td>';
                                str += '<td style="text-align: center"><span class="filesize">' + valueObj.filesize + '</span></td>';
                                str += '<td style="text-align: center">';

                                str += '<input type="hidden" value="' + valueObj.folderid + '" id="folderid" class="folderid"/>';
                                str += '<input type="hidden" value="' + valueObj.foldercontentid + '" id="foldercontentid" class="foldercontentid"/>';
                                str += '<input type="hidden" value="' + valueObj.columnpkid + '" id="columnpkid" class="columnpkid"/>';
                                str += '<input type="hidden" value="' + valueObj.filename + '" id="filename" class="filename"/>';
                                str += '<input type="hidden" value="' + options._colname + '" id="columnname" class="columnname"/>';
                                str += '<input type="hidden" value="' + options._tabname + '" id="tablename" class="tablename"/>';
                                str += '<input type="hidden" value="' + valueObj.filetype + '" id="filetype" class="filetype"/>';
                                str += '<input type="hidden" value="' + base64String + '" id="filepath" class="filepath"/>';
                                str += '<input type="hidden" value="unchanged" id="currentstate" class="currentstate"/>';
                                str += '<input type="hidden" value="' + valueObj.extension + '" id="fileextension" class="fileextension"/>';
                                if (containerdeletebuttontext != '')
                                    str += '<button onclick="deletefile(this);"  class="btn btn-primary btn-md "><i class="fa fa-remove"> </i> ' + containerdeletebuttontext + '</button> ';
                                str += ' </td > ';
                                str += '</tr>';
                                $(containeruploadpreview).append(str);


                                if (ismultiple === false) {
                                    if (base64String !== null && base64String !== "") {
                                        $('#btn_' + fileinputname).addClass('hidden');
                                    }
                                }
                            });
                        }
                    }
                    xhr.send();


                }
            });


        }

        return this.initialize();
    };

})(jQuery);


//function validate(val) {

//    if (val.length === 0) {
//        alert("Attachment Required");
//        return false;
//    }
//}


