
using KAF.MsgContainer.Abstract;
using KAF.MsgContainer.Concrete;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAF.MsgContainer
{
    public class _Common
    {
        private static IResourceProvider resourceProvidercommon = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_Common.xml"));//DbResourceProvider(); //  
        public static string _btnProfileUpdate
        {
            get
            {
                return resourceProvidercommon.GetResource("_btnProfileUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
              
        public static string _btnCancel
        {
            get
            {
                return resourceProvidercommon.GetResource("_btnCancel", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _btnSubmit
        {
            get
            {
                return resourceProvidercommon.GetResource("_btnSubmit", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _btnSearch
        {
            get
            {
                return resourceProvidercommon.GetResource("_btnSearch", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _btnSave
        {
            get
            {
                return resourceProvidercommon.GetResource("_btnSave", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _btnUpdate
        {
            get
            {
                return resourceProvidercommon.GetResource("_btnUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _btnDelete
        {
            get
            {
                return resourceProvidercommon.GetResource("_btnDelete", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _btnReset
        {
            get
            {
                return resourceProvidercommon.GetResource("_btnReset", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _btnClose
        {
            get
            {
                return resourceProvidercommon.GetResource("_btnClose", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _btnClear
        {
            get
            {
                return resourceProvidercommon.GetResource("_btnClear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _btnSignIn
        {
            get
            {
                return resourceProvidercommon.GetResource("_btnSignIn", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _btnSignOut
        {
            get
            {
                return resourceProvidercommon.GetResource("_btnSignOut", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _btnProcess
        {
            get
            {
                return resourceProvidercommon.GetResource("_btnProcess", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _btnDetail
        {
            get
            {
                return resourceProvidercommon.GetResource("_btnDetail", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _btnUpload
        {
            get
            {
                return resourceProvidercommon.GetResource("_btnUpload", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _btnSelect
        {
            get
            {
                return resourceProvidercommon.GetResource("_btnSelect", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _commentRequired
        {
            get
            {
                return resourceProvidercommon.GetResource("_commentRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _saveConfirmation
        {
            get
            {
                return resourceProvidercommon.GetResource("_saveConfirmation", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _saveInformation
        {
            get
            {
                return resourceProvidercommon.GetResource("_saveInformation", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _updateConfirmation
        {
            get
            {
                return resourceProvidercommon.GetResource("_updateConfirmation", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _updateInformation
        {
            get
            {
                return resourceProvidercommon.GetResource("_updateInformation", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _deleteConfirmation
        {
            get
            {
                return resourceProvidercommon.GetResource("_deleteConfirmation", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _deleteInformation
        {
            get
            {
                return resourceProvidercommon.GetResource("_deleteInformation", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _cancelConfirmation
        {
            get
            {
                return resourceProvidercommon.GetResource("_cancelConfirmation", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _cancelInformation
        {
            get
            {
                return resourceProvidercommon.GetResource("_cancelInformation", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _processConfirmation
        {
            get
            {
                return resourceProvidercommon.GetResource("_processConfirmation", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _processInformation
        {
            get
            {
                return resourceProvidercommon.GetResource("_processInformation", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _closeConfirmation
        {
            get
            {
                return resourceProvidercommon.GetResource("_closeConfirmation", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _signoutConfirmation
        {
            get
            {
                return resourceProvidercommon.GetResource("_signoutConfirmation", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _signoutInformation
        {
            get
            {
                return resourceProvidercommon.GetResource("_signoutInformation", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _messageConfirmation
        {
            get
            {
                return resourceProvidercommon.GetResource("_messageConfirmation", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _generalErrorInformation
        {
            get
            {
                return resourceProvidercommon.GetResource("_generalErrorInformation", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _modelStateInvalidInformation
        {
            get
            {
                return resourceProvidercommon.GetResource("_modelStateInvalidInformation", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _imageUploadErrorInformation
        {
            get
            {
                return resourceProvidercommon.GetResource("_imageUploadErrorInformation", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _errorTitle
        {
            get
            {
                return resourceProvidercommon.GetResource("_errorTitle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _informationTitle
        {
            get
            {
                return resourceProvidercommon.GetResource("_informationTitle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _confirmationTitle
        {
            get
            {
                return resourceProvidercommon.GetResource("_confirmationTitle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _alertTitle
        {
            get
            {
                return resourceProvidercommon.GetResource("_alertTitle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string _btnOK
        {
            get
            {
                return resourceProvidercommon.GetResource("_btnOK", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _btnNo
        {
            get
            {
                return resourceProvidercommon.GetResource("_btnNo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _btnYes
        {
            get
            {
                return resourceProvidercommon.GetResource("_btnYes", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _btnGoBackToMain
        {
            get
            {
                return resourceProvidercommon.GetResource("_btnGoBackToMain", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _btnAddMore
        {
            get
            {
                return resourceProvidercommon.GetResource("_btnAddMore", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string _btnAdd
        {
            get
            {
                return resourceProvidercommon.GetResource("_btnAdd", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _btnClearFilter
        {
            get
            {
                return resourceProvidercommon.GetResource("_btnClearFilter", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _btnViewMore
        {
            get
            {
                return resourceProvidercommon.GetResource("_btnViewMore", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string _btnMoreOption
        {
            get
            {
                return resourceProvidercommon.GetResource("_btnMoreOption", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _btnLessOption
        {
            get
            {
                return resourceProvidercommon.GetResource("_btnLessOption", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string archievedtext
        {
            get
            {
                return resourceProvidercommon.GetResource("archievedtext", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string publishtext
        {
            get
            {
                return resourceProvidercommon.GetResource("publishtext", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string reviewtext
        {
            get
            {
                return resourceProvidercommon.GetResource("reviewtext", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string createtext
        {
            get
            {
                return resourceProvidercommon.GetResource("createtext", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string updatetext
        {
            get
            {
                return resourceProvidercommon.GetResource("updatetext", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string detailstext
        {
            get
            {
                return resourceProvidercommon.GetResource("detailstext", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        public static string usercreateRoleVal
        {
            get
            {
                return resourceProvidercommon.GetResource("usercreateRoleVal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string usercreateFullNameVal
        {
            get
            {
                return resourceProvidercommon.GetResource("usercreateFullNameVal", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string emailAlreadyExist
        {
            get
            {
                return resourceProvidercommon.GetResource("emailAlreadyExist", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string _resetPasswordConfirmation
        {
            get
            {
                return resourceProvidercommon.GetResource("_resetPasswordConfirmation", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _provideAuthCode
        {
            get
            {
                return resourceProvidercommon.GetResource("_provideAuthCode", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _confirmNewPassword
        {
            get
            {
                return resourceProvidercommon.GetResource("_confirmNewPassword", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _passwordMissmatch
        {
            get
            {
                return resourceProvidercommon.GetResource("_passwordMissmatch", CultureInfo.CurrentUICulture.Name) as String;
            }
        }



        public static string _selectCategory
        {
            get
            {
                return resourceProvidercommon.GetResource("_selectCategory", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _headerText
        {
            get
            {
                return resourceProvidercommon.GetResource("_headerText", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _eventHeading
        {
            get
            {
                return resourceProvidercommon.GetResource("_eventHeading", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _newsHeading
        {
            get
            {
                return resourceProvidercommon.GetResource("_newsHeading", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _albumHeading
        {
            get
            {
                return resourceProvidercommon.GetResource("_albumHeading", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _currentactivityHeading
        {
            get
            {
                return resourceProvidercommon.GetResource("_currentactivityHeading", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _publicationHeading
        {
            get
            {
                return resourceProvidercommon.GetResource("_publicationHeading", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _faqHeading
        {
            get
            {
                return resourceProvidercommon.GetResource("_faqHeading", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _resourceHeading
        {
            get
            {
                return resourceProvidercommon.GetResource("_resourceHeading", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _publish
        {
            get
            {
                return resourceProvidercommon.GetResource("_publish", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
       
        public static string _content
        {
            get
            {
                return resourceProvidercommon.GetResource("_content", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _filesAndResources
        {
            get
            {
                return resourceProvidercommon.GetResource("_filesAndResources", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _overview
        {
            get
            {
                return resourceProvidercommon.GetResource("_overview", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _mailconfirmationTitle
        {
            get
            {
                return resourceProvidercommon.GetResource("_mailconfirmationTitle", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _contactRequired
        {
            get
            {
                return resourceProvidercommon.GetResource("_contactRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


        //Data Validation
        public static string _onlyalphanumeric
        {
            get
            {
                return resourceProvidercommon.GetResource("_onlyalphanumeric", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _onlyalphabet
        {
            get
            {
                return resourceProvidercommon.GetResource("_onlyalphabet", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _onlynumeric
        {
            get
            {
                return resourceProvidercommon.GetResource("_onlynumeric", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _onlyinteger
        {
            get
            {
                return resourceProvidercommon.GetResource("_onlyinteger", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string requiredfieldvalidation
        {
            get
            {
                return resourceProvidercommon.GetResource("requiredfieldvalidation", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fileName
        {
            get
            {
                return resourceProvidercommon.GetResource("fileName", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string sizeInKB
        {
            get
            {
                return resourceProvidercommon.GetResource("sizeInKB", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string action
        {
            get
            {
                return resourceProvidercommon.GetResource("action", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string commonFunction
        {
            get
            {
                return resourceProvidercommon.GetResource("commonFunction", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fileupload
        {
            get
            {
                return resourceProvidercommon.GetResource("fileupload", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string _uploadfiles
        {
            get
            {
                return resourceProvidercommon.GetResource("_uploadfiles", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string dataAlreadyExist
        {
            get
            {
                return resourceProvidercommon.GetResource("dataAlreadyExist", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        

    }

}
