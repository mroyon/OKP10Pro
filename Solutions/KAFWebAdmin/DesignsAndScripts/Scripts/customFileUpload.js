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
            _divid: '_defaultdivid',
            _controllername: '_defaultcontrollername',
            _actionname: '_defaultactionname',
            _modelname: '_defaultmodelname',
            _primaryid: '-99',
            _uploadedfileextension: '',
            _fileinputname: '_defaultfileinputname',
            _lnkuploadfile: '_defaultlnkuploadfile',
            _fileuploadbuttontext: '_fileuploadbuttontext'
        };

        var options = $.extend({}, defaults, options);

        var blankimageurl = $('.txtBaseUrl').val() + 'DesignsAndScripts/Images/blankProfile.png';
        var stringbuilder = '';
        //$.fn.kaffileUploader.GetFilesForActions

        this.initialize = function () {
            stringbuilder = '<div id="upload_button">';
            stringbuilder += '<label>';


            if (options._uploadedfileextension != '') {
                stringbuilder += '<input type="file" accept="' + options._uploadedfileextension + '" ngf-select ng-model="new_files" id="' + options._fileinputname + '" ng-change="fs.uploadFiles(new_files)">';
            }
            else
                stringbuilder += '<input type="file" accept=".doc, .docx, .pdf, .xls, .xlsx, jpg, .png, .jpeg, .gif, .bmp, .tif, .tiff|image/*" ngf-select ng-model="new_files" id="' + options._fileinputname + '" ng-change="fs.uploadFiles(new_files)">';

            stringbuilder += '<img src="' + blankimageurl + '" style="cursor: pointer;" id="btnuploadcls" class=" btnuploadcls" width="120px" height="131px" />';


            stringbuilder += '</label>';
            stringbuilder += '</div>';
            stringbuilder += '<br /><span class="btn btn-primary hidden " id="btn_removeimage" >Remove Photo</span>';
            stringbuilder += '<input type="hidden" id="TMPFilePath" />';
            stringbuilder += '<input type="hidden" id="TMPFileName" />';
            stringbuilder += '<input type="hidden" id="TMPFileType" />';
            stringbuilder += '<input type="hidden" id="TMPExtension" />';
            stringbuilder += '<input type="hidden" id="TMPFileSize" />';

            stringbuilder += '';

            this.append(stringbuilder);
            return this;
        };

        var baseurl = $('#txtBaseUrl').val();

        $(document).ready(function () {

            $('#btn_removeimage').on('click', function (event) {
                $('#btnuploadcls').attr('src', blankimageurl);
                $('#btn_removeimage').addClass("hidden");
                $('#TMPFileType').val('');
                $('#TMPExtension').val('');
                $('#TMPFileSize').val('');
                $('#TMPFilePath').val();
                $('#TMPFileName').val('');
            });


            $('#' + options._fileinputname).change(function () {
                var fileUpload = $('#' + options._fileinputname).get(0);
                var files = fileUpload.files;
                var fileData = new FormData();
                for (var i = 0; i < files.length; i++) {

                    fileData.append(files[i].name, files[i]);
                    var filesize = files[i].size;
                    var fileName = files[i].name;
                    var filetype = files[i].type;
                    var fileURL = [];
                    var str = "";

                    $('#btn_removeimage').removeClass("hidden");

                    var reader = new FileReader();
                    reader.onload = function (event) {
                        var extension = fileName.split('.').pop().toLowerCase();
                        extension = '.' + extension;
                        var cont = event.target.result
                        var base64String = cont.replace(/^[^,]*,/, '');

                        var baseurl = $('#txtBaseUrl').val();
                        var imgsource = '';


                        if (extension == '.jpg' || extension == '.png' || extension == '.bmp' || extension == '.gif' || extension == '.jpeg')
                            imgsource = event.target.result;


                        $('#btnuploadcls').attr('src', imgsource);
                        $('#TMPFilePath').val(base64String);
                        $('#TMPFileName').val(fileName);
                        $('#TMPFileType').val(filetype);
                        $('#TMPExtension').val(extension);
                        $('#TMPFileSize').val(filesize);

                    }
                    reader.readAsDataURL(files[i]);

                }
            });

        });


        this.loadpreloaddata = function (_filepath, _filename, _filetype, _extension, _filesize, _controlid) {

            //var base64String = "";
            //var flag = 0;
            var str = 'blankProfile';
            str.toLowerCase().indexOf(_filename);
            var blankimageurl = $('.txtBaseUrl').val() + 'DesignsAndScripts/Images/blankProfile.png';

            if (_filepath == '' && _filepath == NULL) {
                $('#btn_removeimage').addClass("hidden");
                $('#btnuploadcls').attr('src', blankimageurl);
            }

            if (_filename.indexOf(str) != -1) {
                $('#btn_removeimage').addClass("hidden");
            }
            else {

                $('#TMPFilePath').val(_filepath);
                $('#TMPFileName').val(_filename);
                $('#TMPFileType').val(_filetype);
                $('#TMPExtension').val(_extension);
                $('#TMPFileSize').val(_filesize);

                $('#btnuploadcls').attr('src', _filepath + _filename);
                $('#btn_removeimage').removeClass("hidden");
            }
        }

        return this.initialize();
    };

})(jQuery);