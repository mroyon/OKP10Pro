using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;


namespace KAF.AppConfiguration.Configuration
{
    public class WorkFlowMailHelper
    {
        #region Member Variables



        #endregion Member Variables

        #region Properties


        public string ApplicantName
        {
            get;
            set;
        }

        public string ApplicantEmail
        {
            get;
            set;
        }

        public string ApplicantPassword
        {
            get;
            set;
        }

        public string HotListName
        {
            get;
            set;
        }

        public string ApplicantAvailability
        {
            get;
            set;
        }

        public string TestName
        {
            get;
            set;
        }

        public string TestScore
        {
            get;
            set;
        }

        #endregion Properties

        #region Methods

        /// <summary>   Sends the alert by SMS. </summary>
        ///<method name="SendAlertBySMS" type="void"></method>
        /// <remarks>   User, 2/1/2017. </remarks>

        public void SendAlertBySMS()
        {
        }





        #region Common

        /// <summary>   Gets the style. </summary>
        ///<method name="GetStyle" type="string"></method>
        /// <remarks>   User, 2/1/2017. </remarks>
        ///
        /// <returns>   The style. </returns>

        private string GetStyle()
        {
            StringBuilder strStyle = new StringBuilder();
            strStyle.Append(@"  <link href=http://www.delphistaffing.net/StyleSheets/Client/styles.css rel=stylesheet type=text/css />
                                <style type=text/css>
                                TD.JSBorderLine
                                {
                                    background-color:#D3D3D3;
                                }
                                TD.JSFormHeading
                                {
                                    BACKGROUND-COLOR: #006699; font-weight:bold; Color:white;font-family:Verdana; 
                                    text-align:left;
                                    font-size:12px;
                                }
                                .JSFormHeading
                                {
                                    BACKGROUND-COLOR: #006699; font-weight:bold; Color:white;font-family:Verdana; 
                                    text-align:center;
                                    font-size:12px;
                                }
                                TD.NewFormValue
                                {
                                    BACKGROUND-COLOR: white;
                                    font-weight:normal;
                                    color:Black;
                                    font-family:Verdana; 
                                    font-size:11px;
                                }
                                .NewFormValue
                                {
                                    BACKGROUND-COLOR: white;
                                    font-weight:normal;
                                    color:Black;
                                    font-family:Verdana; 
                                    font-size:11px;
                                }
                                .NewFormValue1
                                {
                                    BACKGROUND-COLOR: #aa97f0;
                                    font-weight:normal;
                                    color:Black;
                                    font-family:Verdana; 
                                    font-size:11px;
                                }
                                .NewFormValue2
                                {
                                    BACKGROUND-COLOR: #cce599
                                    font-weight:normal;
                                    color:Black;
                                    font-family:Verdana; 
                                    font-size:11px;
                                }
                                .AlternateItem
                                {
                                    BACKGROUND-COLOR: #e1f2fb;
                                    font-weight:normal; 
                                    color:Black;
                                    font-family:Verdana; 
                                    font-size:11px;
                                }
                                TD.JSFormField
                                {
                                    BACKGROUND-COLOR: #e1f2fb;
                                    font-weight:bold; 
                                    color:Black;
                                    font-family:Verdana; 
                                    font-size:11px;
                                }
                                .JSFormField
                                {
                                    BACKGROUND-COLOR: #e1f2fb;
                                    font-weight:normal; 
                                    color:Black;
                                    font-family:Verdana; 
                                    font-size:11px;
                                }
                                </style>");
            return strStyle.ToString();
        }

        #endregion

        #region Cosultant Alert

        /// <summary>   Gets alert consultant created. </summary>
        ///<method name="GetAlertConsultantCreated" type="string"></method>
        /// <remarks>   User, 2/1/2017. </remarks>
        ///
        /// <returns>   The alert consultant created. </returns>

        public String GetAlertConsultantCreated()
        {
            StringBuilder strHTMLText = new StringBuilder();
            //strHTMLText.Append(GetStyle());

            strHTMLText.Append("<table width=780px border=0 align=center cellpadding=0 cellspacing=0>");
            strHTMLText.Append("    <tr>");
            strHTMLText.Append("        <td colspan=4>");
            strHTMLText.Append("            <table width=100% border=0 cellspacing=0 cellpadding=5>");
            strHTMLText.Append("                <tr>");
            strHTMLText.Append("                    <td class=JSFormHeading>Application Work Flow Alert</td>");
            strHTMLText.Append("                </tr>");
            strHTMLText.Append("                <tr>");
            strHTMLText.Append("                    <td height=5 bgcolor=#FFCC00><SPACER height=1 width=1 type=block></td>");
            strHTMLText.Append("		        </tr>");
            strHTMLText.Append("            </table>");
            strHTMLText.Append("        </td>");
            strHTMLText.Append("    </tr>");
            strHTMLText.Append("    <tr>");
            strHTMLText.Append("        <td>");
            strHTMLText.Append("            <table width=100% border=0 cellspacing=1 cellpadding=0>");
            strHTMLText.Append("                <tr>");
            strHTMLText.Append("                    <td valign=top align=left width=100%>");
            strHTMLText.Append("                        <table width=100% border=0 cellspacing=1 cellpadding=5>");

            strHTMLText.Append("                            <tr>");
            strHTMLText.Append("                                <td width=100% nowrap>Alert Type</td>");
            strHTMLText.Append("                                <td>Consultant Created</td>");
            strHTMLText.Append("                            </tr>");

            strHTMLText.Append("                            <tr>");
            strHTMLText.Append("                                <td width=100% nowrap>Alert Time</td>");
            strHTMLText.Append("                                <td>" + DateTime.Now.ToLongDateString() + "</td>");
            strHTMLText.Append("                            </tr>");

            strHTMLText.Append("                            <tr>");
            strHTMLText.Append("                                <td width=100% nowrap>Name</td>");
            strHTMLText.Append("                                <td>" + ApplicantName + "</td>");
            strHTMLText.Append("                            </tr>");

            strHTMLText.Append("                            <tr>");
            strHTMLText.Append("                                <td width=100% nowrap>User Id</td>");
            strHTMLText.Append("                                <td>" + ApplicantEmail + "</td>");
            strHTMLText.Append("                            </tr>");


            strHTMLText.Append("                            <tr>");
            strHTMLText.Append("                                <td width=100% nowrap>Password</td>");
            strHTMLText.Append("                                <td>" + ApplicantPassword + "</td>");
            strHTMLText.Append("                            </tr>");

            strHTMLText.Append("                        </table>");
            strHTMLText.Append("                    </td>");
            strHTMLText.Append("                </tr>");
            strHTMLText.Append("            </table>");
            strHTMLText.Append("        </td>");
            strHTMLText.Append("    </tr>");

            strHTMLText.Append("</table>");

            return strHTMLText.ToString();
        }

        #endregion Cosultant Alert

        #region ATS Alerts


        #endregion ATS Alerts

        #region Requisition Email Alerts

        /// <summary>   Gets alert for un assign employee from requisition. </summary>
        ///<method name="GetAlertForUnAssignEmployeeFromRequisition" type="string"></method>
        /// <remarks>   User, 2/1/2017. </remarks>
        ///
        /// <returns>   The alert for un assign employee from requisition. </returns>

        public string GetAlertForUnAssignEmployeeFromRequisition()
        {
            StringBuilder strHTMLText = new StringBuilder();
            strHTMLText.Append("<table width=780px border=0 align=center cellpadding=0 cellspacing=0>");
            strHTMLText.Append("    <tr>");
            strHTMLText.Append("        <td colspan=4>");
            strHTMLText.Append("            <table width=100% border=0 cellspacing=0 cellpadding=5>");
            strHTMLText.Append("                <tr>");
            strHTMLText.Append("                    <td class=JSFormHeading>Application Work Flow Alert</td>");
            strHTMLText.Append("                </tr>");
            strHTMLText.Append("                <tr>");
            strHTMLText.Append("                    <td height=5 bgcolor=#FFCC00><SPACER height=1 width=1 type=block></td>");
            strHTMLText.Append("		        </tr>");
            strHTMLText.Append("            </table>");
            strHTMLText.Append("        </td>");
            strHTMLText.Append("    </tr>");
            strHTMLText.Append("    <tr>");
            strHTMLText.Append("        <td>");
            strHTMLText.Append("            <table width=100% border=0 cellspacing=1 cellpadding=0>");
            strHTMLText.Append("                <tr>");
            strHTMLText.Append("                    <td valign=top align=left width=100%>");
            strHTMLText.Append("                        <table width=100% border=0 cellspacing=1 cellpadding=5>");

            strHTMLText.Append("                            <tr>");
            strHTMLText.Append("                                <td width=100% nowrap>Alert Type</td>");
            strHTMLText.Append("                                <td>Unassigned employee from requisition</td>");
            strHTMLText.Append("                            </tr>");

            strHTMLText.Append("                            <tr>");
            strHTMLText.Append("                                <td width=100% nowrap>Alert Time</td>");
            strHTMLText.Append("                                <td>" + DateTime.Now.ToLongDateString() + "</td>");
            strHTMLText.Append("                            </tr>");

            strHTMLText.Append("                            <tr>");
            strHTMLText.Append("                                <td width=100% nowrap>Name</td>");
            strHTMLText.Append("                                <td>" + ApplicantName + "</td>");
            strHTMLText.Append("                            </tr>");

            strHTMLText.Append("                            <tr>");
            strHTMLText.Append("                                <td width=100% nowrap>User Id</td>");
            strHTMLText.Append("                                <td>" + ApplicantEmail + "</td>");
            strHTMLText.Append("                            </tr>");

            strHTMLText.Append("                        </table>");
            strHTMLText.Append("                    </td>");
            strHTMLText.Append("                </tr>");
            strHTMLText.Append("            </table>");
            strHTMLText.Append("        </td>");
            strHTMLText.Append("    </tr>");

            strHTMLText.Append("</table>");

            return strHTMLText.ToString();
        }

        /// <summary>   Gets alert applicant submitted. </summary>
        ///<method name="GetAlertApplicantSubmitted" type="string"></method>
        /// <remarks>   User, 2/1/2017. </remarks>
        ///
        /// <returns>   The alert applicant submitted. </returns>

        public String GetAlertApplicantSubmitted()
        {
            StringBuilder strHTMLText = new StringBuilder();
            strHTMLText.Append("<table width=780px border=0 align=center cellpadding=0 cellspacing=0>");
            strHTMLText.Append("    <tr>");
            strHTMLText.Append("        <td colspan=4>");
            strHTMLText.Append("            <table width=100% border=0 cellspacing=0 cellpadding=5>");
            strHTMLText.Append("                <tr>");
            strHTMLText.Append("                    <td class=JSFormHeading>Application Work Flow Alert</td>");
            strHTMLText.Append("                </tr>");
            strHTMLText.Append("                <tr>");
            strHTMLText.Append("                    <td height=5 bgcolor=#FFCC00><SPACER height=1 width=1 type=block></td>");
            strHTMLText.Append("		        </tr>");
            strHTMLText.Append("            </table>");
            strHTMLText.Append("        </td>");
            strHTMLText.Append("    </tr>");
            strHTMLText.Append("    <tr>");
            strHTMLText.Append("        <td>");
            strHTMLText.Append("            <table width=100% border=0 cellspacing=1 cellpadding=0>");
            strHTMLText.Append("                <tr>");
            strHTMLText.Append("                    <td valign=top align=left width=100%>");
            strHTMLText.Append("                        <table width=100% border=0 cellspacing=1 cellpadding=5>");

            strHTMLText.Append("                            <tr>");
            strHTMLText.Append("                                <td width=100% nowrap>Alert Type</td>");
            strHTMLText.Append("                                <td>Applicant Submitted</td>");
            strHTMLText.Append("                            </tr>");

            strHTMLText.Append("                            <tr>");
            strHTMLText.Append("                                <td width=100% nowrap>Alert Time</td>");
            strHTMLText.Append("                                <td>" + DateTime.Now.ToLongDateString() + "</td>");
            strHTMLText.Append("                            </tr>");

            strHTMLText.Append("                            <tr>");
            strHTMLText.Append("                                <td width=100% nowrap>Name</td>");
            strHTMLText.Append("                                <td>" + ApplicantName + "</td>");
            strHTMLText.Append("                            </tr>");

            strHTMLText.Append("                            <tr>");
            strHTMLText.Append("                                <td width=100% nowrap>User Id</td>");
            strHTMLText.Append("                                <td>" + ApplicantEmail + "</td>");
            strHTMLText.Append("                            </tr>");

            strHTMLText.Append("                        </table>");
            strHTMLText.Append("                    </td>");
            strHTMLText.Append("                </tr>");
            strHTMLText.Append("            </table>");
            strHTMLText.Append("        </td>");
            strHTMLText.Append("    </tr>");

            strHTMLText.Append("</table>");

            return strHTMLText.ToString();
        }

        /// <summary>   Gets alert applicant completes initial interview. </summary>
        ///<method name="GetAlertApplicantCompletesInitialInterview" type="string"></method>
        /// <remarks>   User, 2/1/2017. </remarks>
        ///
        /// <returns>   The alert applicant completes initial interview. </returns>

        public string GetAlertApplicantCompletesInitialInterview()
        {
            StringBuilder strHTMLText = new StringBuilder();
            strHTMLText.Append("<table width=780px border=0 align=center cellpadding=0 cellspacing=0>");
            strHTMLText.Append("    <tr>");
            strHTMLText.Append("        <td colspan=4>");
            strHTMLText.Append("            <table width=100% border=0 cellspacing=0 cellpadding=5>");
            strHTMLText.Append("                <tr>");
            strHTMLText.Append("                    <td class=JSFormHeading>Application Work Flow Alert</td>");
            strHTMLText.Append("                </tr>");
            strHTMLText.Append("                <tr>");
            strHTMLText.Append("                    <td height=5 bgcolor=#FFCC00><SPACER height=1 width=1 type=block></td>");
            strHTMLText.Append("		        </tr>");
            strHTMLText.Append("            </table>");
            strHTMLText.Append("        </td>");
            strHTMLText.Append("    </tr>");
            strHTMLText.Append("    <tr>");
            strHTMLText.Append("        <td>");
            strHTMLText.Append("            <table width=100% border=0 cellspacing=1 cellpadding=0>");
            strHTMLText.Append("                <tr>");
            strHTMLText.Append("                    <td valign=top align=left width=100%>");
            strHTMLText.Append("                        <table width=100% border=0 cellspacing=1 cellpadding=5>");

            strHTMLText.Append("                            <tr>");
            strHTMLText.Append("                                <td width=100% nowrap>Alert Type</td>");
            strHTMLText.Append("                                <td>Applicant completes the Initial Interview for a requisition</td>");
            strHTMLText.Append("                            </tr>");

            strHTMLText.Append("                            <tr>");
            strHTMLText.Append("                                <td width=100% nowrap>Alert Time</td>");
            strHTMLText.Append("                                <td>" + DateTime.Now.ToLongDateString() + "</td>");
            strHTMLText.Append("                            </tr>");

            strHTMLText.Append("                        </table>");
            strHTMLText.Append("                    </td>");
            strHTMLText.Append("                </tr>");
            strHTMLText.Append("            </table>");
            strHTMLText.Append("        </td>");
            strHTMLText.Append("    </tr>");

            strHTMLText.Append("</table>");

            return strHTMLText.ToString();
        }

        /// <summary>   Gets alert requisition final hire date within next day. </summary>
        ///<method name="GetAlertRequisitionFinalHireDateWithinNextDay" type="string"></method>
        /// <remarks>   User, 2/1/2017. </remarks>
        ///
        /// <returns>   The alert requisition final hire date within next day. </returns>

        public string GetAlertRequisitionFinalHireDateWithinNextDay()
        {
            StringBuilder strHTMLText = new StringBuilder();
            strHTMLText.Append("<table width=780px border=0 align=center cellpadding=0 cellspacing=0>");
            strHTMLText.Append("    <tr>");
            strHTMLText.Append("        <td colspan=4>");
            strHTMLText.Append("            <table width=100% border=0 cellspacing=0 cellpadding=5>");
            strHTMLText.Append("                <tr>");
            strHTMLText.Append("                    <td class=JSFormHeading>Application Work Flow Alert</td>");
            strHTMLText.Append("                </tr>");
            strHTMLText.Append("                <tr>");
            strHTMLText.Append("                    <td height=5 bgcolor=#FFCC00><SPACER height=1 width=1 type=block></td>");
            strHTMLText.Append("		        </tr>");
            strHTMLText.Append("            </table>");
            strHTMLText.Append("        </td>");
            strHTMLText.Append("    </tr>");
            strHTMLText.Append("    <tr>");
            strHTMLText.Append("        <td>");
            strHTMLText.Append("            <table width=100% border=0 cellspacing=1 cellpadding=0>");
            strHTMLText.Append("                <tr>");
            strHTMLText.Append("                    <td valign=top align=left width=100%>");
            strHTMLText.Append("                        <table width=100% border=0 cellspacing=1 cellpadding=5>");

            strHTMLText.Append("                            <tr>");
            strHTMLText.Append("                                <td width=100% nowrap>Alert Type</td>");
            strHTMLText.Append("                                <td>Requisition Final Hire to be Completed by Date is within the next day</td>");
            strHTMLText.Append("                            </tr>");

            strHTMLText.Append("                            <tr>");
            strHTMLText.Append("                                <td width=100% nowrap>Alert Time</td>");
            strHTMLText.Append("                                <td>" + DateTime.Now.ToLongDateString() + "</td>");
            strHTMLText.Append("                            </tr>");

            strHTMLText.Append("                        </table>");
            strHTMLText.Append("                    </td>");
            strHTMLText.Append("                </tr>");
            strHTMLText.Append("            </table>");
            strHTMLText.Append("        </td>");
            strHTMLText.Append("    </tr>");

            strHTMLText.Append("</table>");

            return strHTMLText.ToString();
        }

        /// <summary>   Gets alert requisition final hire date has passed. </summary>
        ///<method name="GetAlertRequisitionFinalHireDateHasPassed"></method>
        /// <remarks>   User, 2/1/2017. </remarks>
        ///
        /// <returns>   The alert requisition final hire date has passed. </returns>

        public string GetAlertRequisitionFinalHireDateHasPassed()
        {
            StringBuilder strHTMLText = new StringBuilder();
            strHTMLText.Append("<table width=780px border=0 align=center cellpadding=0 cellspacing=0>");
            strHTMLText.Append("    <tr>");
            strHTMLText.Append("        <td colspan=4>");
            strHTMLText.Append("            <table width=100% border=0 cellspacing=0 cellpadding=5>");
            strHTMLText.Append("                <tr>");
            strHTMLText.Append("                    <td class=JSFormHeading>Application Work Flow Alert</td>");
            strHTMLText.Append("                </tr>");
            strHTMLText.Append("                <tr>");
            strHTMLText.Append("                    <td height=5 bgcolor=#FFCC00><SPACER height=1 width=1 type=block></td>");
            strHTMLText.Append("		        </tr>");
            strHTMLText.Append("            </table>");
            strHTMLText.Append("        </td>");
            strHTMLText.Append("    </tr>");
            strHTMLText.Append("    <tr>");
            strHTMLText.Append("        <td>");
            strHTMLText.Append("            <table width=100% border=0 cellspacing=1 cellpadding=0>");
            strHTMLText.Append("                <tr>");
            strHTMLText.Append("                    <td valign=top align=left width=100%>");
            strHTMLText.Append("                        <table width=100% border=0 cellspacing=1 cellpadding=5>");

            strHTMLText.Append("                            <tr>");
            strHTMLText.Append("                                <td width=100% nowrap>Alert Type</td>");
            strHTMLText.Append("                                <td>Requisition Final Hire to be Completed by Date has passed</td>");
            strHTMLText.Append("                            </tr>");

            strHTMLText.Append("                            <tr>");
            strHTMLText.Append("                                <td width=100% nowrap>Alert Time</td>");
            strHTMLText.Append("                                <td>" + DateTime.Now.ToLongDateString() + "</td>");
            strHTMLText.Append("                            </tr>");

            strHTMLText.Append("                        </table>");
            strHTMLText.Append("                    </td>");
            strHTMLText.Append("                </tr>");
            strHTMLText.Append("            </table>");
            strHTMLText.Append("        </td>");
            strHTMLText.Append("    </tr>");

            strHTMLText.Append("</table>");

            return strHTMLText.ToString();
        }

        /// <summary>   Gets alert requisition recruiter add applicant to hiring matrix. </summary>
        ///<method name="GetAlertRequisitionRecruiterAddApplicantToHiringMatrix" type="string"></method>
        /// <remarks>   User, 2/1/2017. </remarks>
        ///
        /// <returns>   The alert requisition recruiter add applicant to hiring matrix. </returns>

        public string GetAlertRequisitionRecruiterAddApplicantToHiringMatrix()
        {
            StringBuilder strHTMLText = new StringBuilder();
            strHTMLText.Append("<table width=780px border=0 align=center cellpadding=0 cellspacing=0>");
            strHTMLText.Append("    <tr>");
            strHTMLText.Append("        <td colspan=4>");
            strHTMLText.Append("            <table width=100% border=0 cellspacing=0 cellpadding=5>");
            strHTMLText.Append("                <tr>");
            strHTMLText.Append("                    <td class=JSFormHeading>Application Work Flow Alert</td>");
            strHTMLText.Append("                </tr>");
            strHTMLText.Append("                <tr>");
            strHTMLText.Append("                    <td height=5 bgcolor=#FFCC00><SPACER height=1 width=1 type=block></td>");
            strHTMLText.Append("		        </tr>");
            strHTMLText.Append("            </table>");
            strHTMLText.Append("        </td>");
            strHTMLText.Append("    </tr>");
            strHTMLText.Append("    <tr>");
            strHTMLText.Append("        <td>");
            strHTMLText.Append("            <table width=100% border=0 cellspacing=1 cellpadding=0>");
            strHTMLText.Append("                <tr>");
            strHTMLText.Append("                    <td valign=top align=left width=100%>");
            strHTMLText.Append("                        <table width=100% border=0 cellspacing=1 cellpadding=5>");

            strHTMLText.Append("                            <tr>");
            strHTMLText.Append("                                <td width=100% nowrap>Alert Type</td>");
            strHTMLText.Append("                                <td>Recruiter added applicant to the Hiring Matrix</td>");
            strHTMLText.Append("                            </tr>");

            strHTMLText.Append("                            <tr>");
            strHTMLText.Append("                                <td width=100% nowrap>Alert Time</td>");
            strHTMLText.Append("                                <td>" + DateTime.Now.ToLongDateString() + "</td>");
            strHTMLText.Append("                            </tr>");

            strHTMLText.Append("                        </table>");
            strHTMLText.Append("                    </td>");
            strHTMLText.Append("                </tr>");
            strHTMLText.Append("            </table>");
            strHTMLText.Append("        </td>");
            strHTMLText.Append("    </tr>");

            strHTMLText.Append("</table>");

            return strHTMLText.ToString();
        }

        #endregion

        #endregion Methods
    }
}
