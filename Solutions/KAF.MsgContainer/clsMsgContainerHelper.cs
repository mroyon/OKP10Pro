using KAF.MsgContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KAF.MsgContainer
{
    public class clsMsgContainerHelper
    {
        public enum FormAction
        {
            Add = 1,
            Delete = 2,
            Edit = 3,
            Cancel = 4,
            Clear = 5,
            Print = 6,
            SetUpAdd = 7,
            DulpicateInfo = 8,
            ReferenceConstraint = 9,
            DeleteOrUpdateWithoutSelection = 10,
            Close = 11,
            Reset = 12,
            SyncReset = 13,
            SyncAllFromDB = 14,
            Preview = 15,
            Process = 16,
            Show = 17,
            ReportShow = 18,
            RequestSubmitted = 19,
            OTPRequest = 20,
            TokenPurchase = 21,
            TokenConsumed = 22,
            SubmitForReview = 23,
            SubmitForDraft = 24,
            SendMessage = 25,
            FinalSubmitSendRequest = 26
        }

        /// <summary>   Perse message for confirmation. </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="PerseMessageForConfirmation" type="string"> PerseMessageForConfirmation. </method>
        /// <param name="act" type="FormAction">  The act. </param>
        /// <returns>   A string. </returns>


        public const string strLangArabic = "ar-KW";
        public const string strLangEnglish = "en-GB";

        /// <summary>   Perse message for confirmation. </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="PerseMessageForConfirmation" type="string"> PerseMessageForConfirmation. </method>
        /// <param name="act" type="FormAction">          The act. </param>
        /// <param name="strCulture" type="string">   The culture. </param>
        /// <returns>   A string. </returns>

        public string PerseMessageForConfirmation(FormAction act, string strCulture)
        {
            string msg = "";
            switch (strCulture)
            {
                case strLangArabic:
                {                        
                    switch (act)
                    {
                        case FormAction.Add:
                            {
                                msg = OperationMessagesArabic.SaveConfirmation;
                                break;
                            }
                        case FormAction.Edit:
                            {
                                msg = OperationMessagesArabic.UpdateConfirmation;
                                break;
                            }
                        case FormAction.Delete:
                            {
                                msg = OperationMessagesArabic.DeleteConfirmation;
                                break;
                            }
                        case FormAction.Cancel:
                            {
                                msg = OperationMessagesArabic.CancelConfirmation;
                                break;
                            }
                        case FormAction.Clear:
                            {
                                msg = OperationMessagesArabic.ClearConfirmation;
                                break;
                            }
                        case FormAction.Close:
                            {
                                msg = OperationMessagesArabic.CloseConfirmation;
                                break;
                            }
                        case FormAction.Reset:
                            {
                                msg = OperationMessagesArabic.ResetConfirmation;
                                break;
                            }
                        case FormAction.SyncReset:
                            {
                                msg = OperationMessagesArabic.SyncReset;
                                break;
                            }
                        case FormAction.SyncAllFromDB:
                            {
                                msg = OperationMessagesArabic.SyncAllFromDB;
                                break;
                            }
                        case FormAction.Preview:
                            {
                                msg = OperationMessagesArabic.PreviewConfirmation;
                                break;
                            }
                        case FormAction.Process:
                            {
                                msg = OperationMessagesArabic.ProcessConfirmation;
                                break;
                            }
                        case FormAction.Show:
                            {
                                msg = OperationMessagesArabic.ShowOperation;
                                break;
                            }
                        case FormAction.ReportShow:
                            {
                                msg = OperationMessagesArabic.ShowOperation;
                                break;
                            }
                        case FormAction.RequestSubmitted:
                            {
                                msg = OperationMessagesArabic.RequestHasbeenSubmitted;
                                break;
                            }
                        case FormAction.OTPRequest:
                            {
                                msg = OperationMessagesArabic.OTPRequest;
                                break;
                            }
                        case FormAction.TokenPurchase:
                            {
                                msg = OperationMessagesArabic.TokenPurchase;
                                break;
                            }
                        case FormAction.SubmitForReview:
                            {
                                msg = OperationMessagesArabic.SubmitForReview;
                                break;
                            }
                        case FormAction.SubmitForDraft:
                            {
                                msg = OperationMessagesArabic.SubmitForDraft;
                                break;
                            }
                        case FormAction.SendMessage:
                            {
                                msg = OperationMessagesArabic.SendMessage;
                                break;
                            }
                        case FormAction.FinalSubmitSendRequest:
                            {
                                msg = OperationMessagesArabic.FinalSubmitStudent;
                                break;
                            }
                        default:
                            {
                                msg = "";
                                break;
                            }
                    }
                    break;
                }
                case strLangEnglish:
                {
                    switch (act)
                    {
                        case FormAction.Add:
                            {
                                msg = OperationMessages.SaveConfirmation;
                                break;
                            }
                        case FormAction.Edit:
                            {
                                msg = OperationMessages.UpdateConfirmation;
                                break;
                            }
                        case FormAction.Delete:
                            {
                                msg = OperationMessages.DeleteConfirmation;
                                break;
                            }
                        case FormAction.Cancel:
                            {
                                msg = OperationMessages.CancelConfirmation;
                                break;
                            }
                        case FormAction.Clear:
                            {
                                msg = OperationMessages.ClearConfirmation;
                                break;
                            }
                        case FormAction.Close:
                            {
                                msg = OperationMessages.CloseConfirmation;
                                break;
                            }
                        case FormAction.Reset:
                            {
                                msg = OperationMessages.ResetConfirmation;
                                break;
                            }
                        case FormAction.SyncReset:
                            {
                                msg = OperationMessages.SyncReset;
                                break;
                            }
                        case FormAction.SyncAllFromDB:
                            {
                                msg = OperationMessages.SyncAllFromDB;
                                break;
                            }
                        case FormAction.Preview:
                            {
                                msg = OperationMessages.PreviewConfirmation;
                                break;
                            }
                        case FormAction.Process:
                            {
                                msg = OperationMessages.ProcessConfirmation;
                                break;
                            }
                        case FormAction.Show:
                            {
                                msg = OperationMessages.ShowOperation;
                                break;
                            }
                        case FormAction.ReportShow:
                            {
                                msg = OperationMessages.ShowOperation;
                                break;
                            }
                        case FormAction.RequestSubmitted:
                            {
                                msg = OperationMessages.RequestHasbeenSubmitted;
                                break;
                            }
                        case FormAction.OTPRequest:
                            {
                                msg = OperationMessages.OTPRequest;
                                break;
                            }
                        case FormAction.TokenPurchase:
                            {
                                msg = OperationMessages.TokenPurchase;
                                break;
                            }
                        case FormAction.SubmitForReview:
                            {
                                msg = OperationMessages.SubmitForReview;
                                break;
                            }
                        case FormAction.SubmitForDraft:
                            {
                                msg = OperationMessages.SubmitForDraft;
                                break;
                            }
                        case FormAction.SendMessage:
                            {
                                msg = OperationMessages.SendMessage;
                                break;
                            }
                        case FormAction.FinalSubmitSendRequest:
                            {
                                msg = OperationMessages.FinalSubmitStudent;
                                break;
                            }
                        default:
                            {
                                msg = "";
                                break;
                            }
                    }
                    break;
                }
                default:
                    {
                        break;
                    }
            }
            return msg;
        }

        /// <summary>   Perse message for information. </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="PerseMessageForInformation" type="string">  PerseMessageForInformation. </method>
        /// <param name="act" type="FormAction">          The act. </param>
        /// <param name="strCulture" type="string">   The culture. </param>
        /// <returns>   A string. </returns>

        public string PerseMessageForInformation(FormAction act, string strCulture)
        {
            string msg = "";
            switch (strCulture)
            {
                case strLangArabic:
                    {
                        switch (act)
                        {
                            case FormAction.DeleteOrUpdateWithoutSelection:
                                {
                                    msg = OperationMessagesArabic.DeleteOrUpdateWithoutSelection;
                                    break;
                                }
                            case FormAction.DulpicateInfo:
                                {
                                    msg = OperationMessagesArabic.DuplicateInformation;
                                    break;
                                }
                            case FormAction.ReferenceConstraint:
                                {
                                    msg = OperationMessagesArabic.ReferenceConstraint;
                                    break;
                                }
                            case FormAction.SetUpAdd:
                                {
                                    msg = OperationMessagesArabic.SetUpSaveOperation;
                                    break;
                                }
                            case FormAction.Add:
                                {
                                    msg = OperationMessagesArabic.SaveOperation;
                                    break;
                                }
                            case FormAction.Edit:
                                {
                                    msg = OperationMessagesArabic.UpdateOperation;
                                    break;
                                }
                            case FormAction.Delete:
                                {
                                    msg = OperationMessagesArabic.DeleteOperation;
                                    break;
                                }
                            case FormAction.RequestSubmitted:
                                {
                                    msg = OperationMessagesArabic.RequestHasbeenSubmitted;
                                    break;
                                }
                            case FormAction.TokenPurchase:
                                {
                                    msg = OperationMessagesArabic.TokenPurchase;
                                    break;
                                }
                            case FormAction.TokenConsumed:
                                {
                                    msg = OperationMessagesArabic.TokenConsumed;
                                    break;
                                }
                            case FormAction.SubmitForReview:
                                {
                                    msg = OperationMessagesArabic.SubmitForReview;
                                    break;
                                }
                            case FormAction.SubmitForDraft:
                                {
                                    msg = OperationMessagesArabic.SubmitForDraft;
                                    break;
                                }
                            case FormAction.SendMessage:
                                {
                                    msg = OperationMessagesArabic.SendMessage;
                                    break;
                                }
                            default:
                                {
                                    msg = "";
                                    break;
                                }
                        }
                        break;
                    }
                case strLangEnglish:
                    {
                        switch (act)
                        {
                            case FormAction.DeleteOrUpdateWithoutSelection:
                                {
                                    msg = OperationMessages.DeleteOrUpdateWithoutSelection;
                                    break;
                                }
                            case FormAction.DulpicateInfo:
                                {
                                    msg = OperationMessages.DuplicateInformation;
                                    break;
                                }
                            case FormAction.ReferenceConstraint:
                                {
                                    msg = OperationMessages.ReferenceConstraint;
                                    break;
                                }
                            case FormAction.SetUpAdd:
                                {
                                    msg = OperationMessages.SetUpSaveOperation;
                                    break;
                                }
                            case FormAction.Add:
                                {
                                    msg = OperationMessages.SaveOperation;
                                    break;
                                }
                            case FormAction.Edit:
                                {
                                    msg = OperationMessages.UpdateOperation;
                                    break;
                                }
                            case FormAction.Delete:
                                {
                                    msg = OperationMessages.DeleteOperation;
                                    break;
                                }
                            case FormAction.RequestSubmitted:
                                {
                                    msg = OperationMessages.RequestHasbeenSubmitted;
                                    break;
                                }
                            case FormAction.TokenPurchase:
                                {
                                    msg = OperationMessages.TokenPurchase;
                                    break;
                                }
                            case FormAction.TokenConsumed:
                                {
                                    msg = OperationMessages.TokenConsumed;
                                    break;
                                }
                            case FormAction.SubmitForReview:
                                {
                                    msg = OperationMessages.SubmitForReview;
                                    break;
                                }
                            case FormAction.SubmitForDraft:
                                {
                                    msg = OperationMessages.SubmitForDraft;
                                    break;
                                }
                            case FormAction.SendMessage:
                                {
                                    msg = OperationMessages.SendMessage;
                                    break;
                                }
                            default:
                                {
                                    msg = "";
                                    break;
                                }
                        }
                        break;
                    }
                default:
                    {
                        switch (act)
                        {
                            case FormAction.DeleteOrUpdateWithoutSelection:
                                {
                                    msg = OperationMessages.DeleteOrUpdateWithoutSelection;
                                    break;
                                }
                            case FormAction.DulpicateInfo:
                                {
                                    msg = OperationMessages.DuplicateInformation;
                                    break;
                                }
                            case FormAction.ReferenceConstraint:
                                {
                                    msg = OperationMessages.ReferenceConstraint;
                                    break;
                                }
                            case FormAction.SetUpAdd:
                                {
                                    msg = OperationMessages.SetUpSaveOperation;
                                    break;
                                }
                            case FormAction.Add:
                                {
                                    msg = OperationMessages.SaveOperation;
                                    break;
                                }
                            case FormAction.Edit:
                                {
                                    msg = OperationMessages.UpdateOperation;
                                    break;
                                }
                            case FormAction.Delete:
                                {
                                    msg = OperationMessages.DeleteOperation;
                                    break;
                                }
                            case FormAction.RequestSubmitted:
                                {
                                    msg = OperationMessages.RequestHasbeenSubmitted;
                                    break;
                                }
                            case FormAction.TokenPurchase:
                                {
                                    msg = OperationMessages.TokenPurchase;
                                    break;
                                }
                            case FormAction.TokenConsumed:
                                {
                                    msg = OperationMessages.TokenConsumed;
                                    break;
                                }
                            case FormAction.SubmitForReview:
                                {
                                    msg = OperationMessages.SubmitForReview;
                                    break;
                                }
                            case FormAction.SubmitForDraft:
                                {
                                    msg = OperationMessages.SubmitForDraft;
                                    break;
                                }
                            case FormAction.SendMessage:
                                {
                                    msg = OperationMessages.SendMessage;
                                    break;
                                }
                            default:
                                {
                                    msg = "";
                                    break;
                                }
                        }
                        break;
                    }
            }
            return msg;
        }
    }
}
