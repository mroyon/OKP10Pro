using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.MsgContainer;


namespace KAF.WebFramework
{
    public class clsMessagePerser
    {
        public clsMsgContainerHelper objContainer = new clsMsgContainerHelper();

        /// <summary>   Perse message for confirmation. </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="PerseMessageForConfirmation" type="string"> PerseMessageForConfirmation. </method>
        /// <param name="FormAction" type="clsMsgContainerHelper.FormAction">   The form action. </param>
        /// <param name="strCulture" type="string">   The culture. </param>
        /// <returns>   A string. </returns>

        public string PerseMessageForConfirmation(clsMsgContainerHelper.FormAction FormAction, string strCulture)
        {
            string msg = "";
            switch (FormAction)
            {
                case clsMsgContainerHelper.FormAction.Add:
                    {
                        msg = objContainer.PerseMessageForConfirmation(clsMsgContainerHelper.FormAction.Add, strCulture);
                        break;
                    }
                case clsMsgContainerHelper.FormAction.Edit:
                    {
                        msg = objContainer.PerseMessageForConfirmation(clsMsgContainerHelper.FormAction.Edit, strCulture);
                        break;
                    }
                case clsMsgContainerHelper.FormAction.Delete:
                    {
                        msg = objContainer.PerseMessageForConfirmation(clsMsgContainerHelper.FormAction.Delete, strCulture);
                        break;
                    }
                case clsMsgContainerHelper.FormAction.Cancel:
                    {
                        msg = objContainer.PerseMessageForConfirmation(clsMsgContainerHelper.FormAction.Cancel, strCulture);
                        break;
                    }
                case clsMsgContainerHelper.FormAction.Clear:
                    {
                        msg = objContainer.PerseMessageForConfirmation(clsMsgContainerHelper.FormAction.Clear, strCulture);
                        break;
                    }
                case clsMsgContainerHelper.FormAction.Preview:
                    {
                        msg = objContainer.PerseMessageForConfirmation(clsMsgContainerHelper.FormAction.Preview, strCulture);
                        break;
                    }
                case clsMsgContainerHelper.FormAction.Show:
                    {
                        msg = objContainer.PerseMessageForConfirmation(clsMsgContainerHelper.FormAction.Show, strCulture);
                        break;
                    }
                case clsMsgContainerHelper.FormAction.Reset:
                    {
                        msg = objContainer.PerseMessageForConfirmation(clsMsgContainerHelper.FormAction.Reset, strCulture);
                        break;
                    }
                case clsMsgContainerHelper.FormAction.Process:
                    {
                        msg = objContainer.PerseMessageForConfirmation(clsMsgContainerHelper.FormAction.Process, strCulture);
                        break;
                    }
                case clsMsgContainerHelper.FormAction.OTPRequest:
                    {
                        msg = objContainer.PerseMessageForConfirmation(clsMsgContainerHelper.FormAction.OTPRequest, strCulture);
                        break;
                    }
                case clsMsgContainerHelper.FormAction.SubmitForDraft:
                    {
                        msg = objContainer.PerseMessageForConfirmation(clsMsgContainerHelper.FormAction.SubmitForDraft, strCulture);
                        break;
                    }
                case clsMsgContainerHelper.FormAction.SubmitForReview:
                    {
                        msg = objContainer.PerseMessageForConfirmation(clsMsgContainerHelper.FormAction.SubmitForReview, strCulture);
                        break;
                    }
                case clsMsgContainerHelper.FormAction.SendMessage:
                    {
                        msg = objContainer.PerseMessageForConfirmation(clsMsgContainerHelper.FormAction.SendMessage, strCulture);
                        break;
                    }
                case clsMsgContainerHelper.FormAction.FinalSubmitSendRequest:
                    {
                        msg = objContainer.PerseMessageForConfirmation(clsMsgContainerHelper.FormAction.FinalSubmitSendRequest, strCulture);
                        break;
                    }
                default:
                    {
                        msg = "";
                        break;
                    }
            }
            return msg;
        }

        /// <summary>   Perse message for information. </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="PerseMessageForInformation" type="string">  PerseMessageForInformation. </method>
        /// <param name="FormAction" type="clsMsgContainerHelper.FormAction">   The form action. </param>
        /// <param name="strCulture" type="string">   The culture. </param>
        /// <returns>   A string. </returns>

        public string PerseMessageForInformation(clsMsgContainerHelper.FormAction FormAction, string strCulture)
        {
            string msg = "";
            switch (FormAction)
            {
                case clsMsgContainerHelper.FormAction.DeleteOrUpdateWithoutSelection:
                    {
                        msg = objContainer.PerseMessageForInformation(clsMsgContainerHelper.FormAction.DeleteOrUpdateWithoutSelection, strCulture);
                        break;
                    }
                case clsMsgContainerHelper.FormAction.DulpicateInfo:
                    {
                        msg = objContainer.PerseMessageForInformation(clsMsgContainerHelper.FormAction.DulpicateInfo, strCulture);
                        break;
                    }
                case clsMsgContainerHelper.FormAction.ReferenceConstraint:
                    {
                        msg = objContainer.PerseMessageForInformation(clsMsgContainerHelper.FormAction.ReferenceConstraint, strCulture);
                        break;
                    }
                case clsMsgContainerHelper.FormAction.SetUpAdd:
                    {
                        msg = objContainer.PerseMessageForInformation(clsMsgContainerHelper.FormAction.SetUpAdd, strCulture);
                        break;
                    }
                case clsMsgContainerHelper.FormAction.Add:
                    {
                        msg = objContainer.PerseMessageForInformation(clsMsgContainerHelper.FormAction.Add, strCulture);
                        break;
                    }
                case clsMsgContainerHelper.FormAction.Edit:
                    {
                        msg = objContainer.PerseMessageForInformation(clsMsgContainerHelper.FormAction.Edit, strCulture);
                        break;
                    }
                case clsMsgContainerHelper.FormAction.Delete:
                    {
                        msg = objContainer.PerseMessageForInformation(clsMsgContainerHelper.FormAction.Delete, strCulture);
                        break;
                    }
                case clsMsgContainerHelper.FormAction.TokenPurchase:
                    {
                        msg = objContainer.PerseMessageForInformation(clsMsgContainerHelper.FormAction.TokenPurchase, strCulture);
                        break;
                    }
                case clsMsgContainerHelper.FormAction.TokenConsumed:
                    {
                        msg = objContainer.PerseMessageForInformation(clsMsgContainerHelper.FormAction.TokenConsumed, strCulture);
                        break;
                    }
                case clsMsgContainerHelper.FormAction.SubmitForDraft:
                    {
                        msg = objContainer.PerseMessageForInformation(clsMsgContainerHelper.FormAction.SubmitForDraft, strCulture);
                        break;
                    }
                case clsMsgContainerHelper.FormAction.SubmitForReview:
                    {
                        msg = objContainer.PerseMessageForInformation(clsMsgContainerHelper.FormAction.SubmitForReview, strCulture);
                        break;
                    }
                case clsMsgContainerHelper.FormAction.SendMessage:
                    {
                        msg = objContainer.PerseMessageForInformation(clsMsgContainerHelper.FormAction.SendMessage, strCulture);
                        break;
                    }
                default:
                    {
                        msg = "";
                        break;
                    }
            }
            return msg;
        }


    }
}

