using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using KAF.WebFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace KAF.CustomHelper.HelperClasses
{
    public class clsSecurityPanel
    {

        public string genButtonPanel(long menuId, string menuName, ClaimsIdentity claimsIdentity, string actionNameEdit, string editMethodName,
            string actionNameDelete, string deleteMethodName, string actionNameView, string viewMethodName, string actionNameDownload = "", Int64? letterstatus = -99, string actionNameUpload = "", string viewMethodUpload = "")
        {
            clsPrivateKeys objClsPrivate = new clsPrivateKeys();
            string strValue = string.Empty;
            string strJson = string.Empty;
            try
            {

                if (claimsIdentity != null)
                {
                    List<Owin_ProcessGetFormActionistEntity_Ext> itemList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Owin_ProcessGetFormActionistEntity_Ext>>(HttpContext.Current.Session["jsonList"].ToString());
                    if (itemList != null && itemList.Count > 0)
                    {
                        strValue += "<div class='btn-toolbar pull-right' role='toolbar'>";
                        if (!String.IsNullOrEmpty(actionNameEdit))
                        {
                            if (itemList.Exists(p => p.ActionName.Contains(actionNameEdit)))
                            {
                                if (actionNameEdit == "GenOSInfo/GenOSInfoUpdate")
                                {
                                    strValue += "<button  data-target='#EditOSInformation' data-toggle='modal' class='btn btn-primary btn-md' data-ng-click=" + editMethodName + "(&apos;" + objClsPrivate.BuildUrlMVCOnlyParams(menuName, menuId.ToString()) + "&apos;)> <i class='fa fa-edit'> </i> " + KAF.MsgContainer._Common._btnUpdate + "</button>";
                                }

                                else
                                {
                                    strValue += "<button class='btn btn-primary btn-md' onclick ='" + editMethodName + "(&quot;" + objClsPrivate.BuildUrlMVCOnlyParams(menuName, menuId.ToString()) + "&quot;)'> <i class='fa fa-edit'> </i> " + KAF.MsgContainer._Common._btnUpdate + "</button> ";
                                }
                            }
                        }
                        if (!String.IsNullOrEmpty(actionNameDelete))
                        {
                            if (itemList.Exists(p => p.ActionName.Contains(actionNameDelete)))
                            {
                                strValue += "<button class='btn btn-danger btn-md' onclick='" + deleteMethodName + "(&quot;" + objClsPrivate.BuildUrlMVCOnlyParams(menuName, menuId.ToString()) + "&quot;)'><i class='fa fa-trash'></i> " + KAF.MsgContainer._Common._btnDelete + "</button>  ";

                            }
                        }
                        if (!String.IsNullOrEmpty(actionNameView))
                        {

                            if (itemList.Exists(p => p.ActionName.Contains(actionNameView)))
                            {
                                if (actionNameView == "GenOSInfo/GenOSInfoDetails")
                                {
                                    strValue += "<button  data-target='#DisplayOSInformation' data-toggle='modal' class='btn btn-primary btn-md' data-ng-click=" + viewMethodName + "(&apos;" + objClsPrivate.BuildUrlMVCOnlyParams(menuName, menuId.ToString()) + "&apos;)> <i class='fa fa-info-circle'> </i> " + KAF.MsgContainer._Common._btnDetail + "</button>";
                                }
                                else
                                {
                                    strValue += "<button class='btn btn-info btn-md' onclick='" + viewMethodName + "(&quot;" + objClsPrivate.BuildUrlMVCOnlyParams(menuName, menuId.ToString()) + "&quot;)'><i class='fa fa-info-circle'></i> " + KAF.MsgContainer._Common._btnDetail + "</button>";
                                }
                            }
                        }
                        if (!String.IsNullOrEmpty(actionNameDownload))
                        {

                            if (itemList.Exists(p => p.ActionName.Contains(actionNameView)))
                            {

                                strValue += "<button class='btn btn-info btn-md' onclick='DownloadData(&quot;" + menuId.ToString() + "&quot;,&quot;" + letterstatus.ToString() + "&quot;)'><i class='fa fa-info-circle'></i>Download Report</button>";

                            }
                        }
                        //"HrDocumentUpload/HrDocumentUpload", "HrDocumentUpload",
                        if (!String.IsNullOrEmpty(actionNameUpload))
                        {

                            //if (itemList.Exists(p => p.ActionName.Contains(actionNameUpload)))
                            //{
                            if (actionNameUpload == "HrDocumentUpload/HrDocumentUpload")
                            {
                                //strValue += "<button  data-target='#HrDocumentUpload' data-toggle='modal' class='btn btn-primary btn-md' data-ng-click=" + viewMethodUpload + "(&apos;" + objClsPrivate.BuildUrlMVCOnlyParams(menuName, menuId.ToString()) + "&apos;)> <i class='fa fa-info-circle'> </i> " + KAF.MsgContainer._Common.fileupload + "</button>";
                                strValue += "<button  data-target='#HrDocumentUpload' data-toggle='modal' class='btn btn-primary btn-md' onclick=" + viewMethodUpload + "(&apos;" + objClsPrivate.BuildUrlMVCOnlyParams(menuName, menuId.ToString()) + "&apos;)> <i class='fa fa-info-circle'> </i> " + KAF.MsgContainer._Common.fileupload + "</button>";
                            }
                            else
                            {
                                strValue += "<button class='btn btn-info btn-md' onclick='" + viewMethodName + "(&quot;" + objClsPrivate.BuildUrlMVCOnlyParams(menuName, menuId.ToString()) + "&quot;)'><i class='fa fa-info-circle'></i> " + KAF.MsgContainer._Common.fileupload + "</button>";
                            }
                            //}
                        }
                        strValue += "</div>";
                    }
                }
                else
                    throw new Exception("Login required");
            }
            catch (Exception ex)
            {
                strValue = ex.Message;
            }
            return strValue;
        }

        public string genButtonPanel(long[] menuId, string[] menuName, ClaimsIdentity claimsIdentity, string actionNameEdit, string editMethodName,
          string actionNameDelete, string deleteMethodName, string actionNameView, string viewMethodName)
        {
            clsPrivateKeys objClsPrivate = new clsPrivateKeys();
            string strValue = string.Empty;
            string strJson = string.Empty;
            try
            {

                if (claimsIdentity != null)
                {
                    //strJson = claimsIdentity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier").FirstOrDefault().Value;
                    //List<Owin_ProcessGetFormActionistEntity_Ext> itemList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Owin_ProcessGetFormActionistEntity_Ext>>(strJson);
                    List<Owin_ProcessGetFormActionistEntity_Ext> itemList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Owin_ProcessGetFormActionistEntity_Ext>>(HttpContext.Current.Session["jsonList"].ToString());
                    if (itemList != null && itemList.Count > 0)
                    {
                        strValue += "<div class='btn-toolbar pull-right' role='toolbar'>";

                        List<string> param = new List<string>();

                        int index = 0;

                        foreach (string str in menuName)
                        {
                            param.Add(str);
                            param.Add(menuId[index++].ToString());
                        }

                        if (!String.IsNullOrEmpty(actionNameEdit))
                        {
                            if (itemList.Exists(p => p.ActionName.Contains(actionNameEdit)))
                            {
                                if (actionNameEdit == "GenOSInfo/GenOSInfoUpdate")
                                {
                                    strValue += "<button  data-target='#EditOSInformation' data-toggle='modal' class='btn btn-primary btn-md' data-ng-click=" + editMethodName + "(&apos;" + objClsPrivate.BuildUrlMVCOnlyParams(param.ToArray()) + "&apos;)> <i class='fa fa-edit'> </i> " + KAF.MsgContainer._Common._btnUpdate + "</button>";
                                }

                                else
                                {
                                    strValue += "<button class='btn btn-primary btn-md' onclick ='" + editMethodName + "(&quot;" + objClsPrivate.BuildUrlMVCOnlyParams(param.ToArray()) + "&quot;)'> <i class='fa fa-edit'> </i> " + KAF.MsgContainer._Common._btnUpdate + "</button> ";
                                }
                            }
                        }
                        if (!String.IsNullOrEmpty(actionNameDelete))
                        {
                            if (itemList.Exists(p => p.ActionName.Contains(actionNameDelete)))
                            {
                                strValue += "<button class='btn btn-danger btn-md' onclick='" + deleteMethodName + "(&quot;" + objClsPrivate.BuildUrlMVCOnlyParams(param.ToArray()) + "&quot;)'><i class='fa fa-trash'></i> " + KAF.MsgContainer._Common._btnDelete + "</button>  ";

                            }
                        }
                        if (!String.IsNullOrEmpty(actionNameView))
                        {

                            if (itemList.Exists(p => p.ActionName.Contains(actionNameView)))
                            {
                                if (actionNameView == "GenOSInfo/GenOSInfoDetails")
                                {
                                    strValue += "<button  data-target='#DisplayOSInformation' data-toggle='modal' class='btn btn-primary btn-md' data-ng-click=" + viewMethodName + "(&apos;" + objClsPrivate.BuildUrlMVCOnlyParams(param.ToArray()) + "&apos;)> <i class='fa fa-info-circle'> </i> " + KAF.MsgContainer._Common._btnDetail + "</button>";
                                }
                                else
                                {
                                    strValue += "<button class='btn btn-info btn-md' onclick='" + viewMethodName + "(&quot;" + objClsPrivate.BuildUrlMVCOnlyParams(param.ToArray()) + "&quot;)'><i class='fa fa-info-circle'></i> " + KAF.MsgContainer._Common._btnDetail + "</button>";
                                }
                            }
                        }
                        strValue += "</div>";
                    }
                }
                else
                    throw new Exception("Login required");
            }
            catch (Exception ex)
            {
                strValue = ex.Message;
            }
            return strValue;
        }


        public string genButtonPanelForSingleForm(string[] actionName)
        {
            clsPrivateKeys objClsPrivate = new clsPrivateKeys();
            string strValue = string.Empty;
            string IsSubExists = string.Empty;
            string strJson = string.Empty;
            try
            {

                List<Owin_ProcessGetFormActionistEntity_Ext> itemList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Owin_ProcessGetFormActionistEntity_Ext>>(HttpContext.Current.Session["jsonList"].ToString());
                if (itemList != null && itemList.Count > 0)
                {
                    foreach (string str in actionName)
                    {
                        if (itemList.Exists(p => p.ActionName == str))
                        {
                            string[] ar = str.Split('/');
                            if (ar.Length > 0)
                            {
                                if (actionName.Contains("Create"))
                                    strValue += "<button type=\"submit\" id=\"btn" + actionName + "\" class=\"btn btn-primary btn-md btn" + actionName + "\"><i class=\"fa fa-save\" > </i>" + KAF.MsgContainer._Common._btnSave + "</button>";
                                else if (actionName.Contains("Update"))
                                    strValue += "<button type=\"submit\" id=\"btn" + actionName + "\" class=\"btn btn-primary btn-md btn" + actionName + "\"><i class=\"fa fa-edit\" > </i>" + KAF.MsgContainer._Common._btnUpdate + "</button>";
                                else if (actionName.Contains("Delete"))
                                    strValue += "<button type=\"submit\" id=\"btn" + actionName + "\" class=\"btn btn-primary btn-md btn" + actionName + "\"><i class=\"fa fa-remove\" > </i>" + KAF.MsgContainer._Common._btnDelete + "</button>";
                            }
                        }
                    }
                }
                else
                    strValue = string.Empty;

            }
            catch (Exception ex)
            {
                strValue = ex.Message;
                return strValue;
            }
            return strValue;
        }

        public bool checkButtonPermission(ClaimsIdentity claimsIdentity, string actionName)
        {
            bool permitted = false;
            string strJson = string.Empty;
            try
            {
                if (claimsIdentity != null)
                {
                    List<Owin_ProcessGetFormActionistEntity_Ext> itemList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Owin_ProcessGetFormActionistEntity_Ext>>(HttpContext.Current.Session["jsonList"].ToString());

                    if (itemList != null && itemList.Count > 0)
                    {
                        if (itemList.Exists(p => p.ActionName.Contains(actionName)))
                        {
                            permitted = true;
                        }
                    }
                }
                return permitted;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool checkButtonPermission(string actionName)
        {
            bool permitted = false;
            string strJson = string.Empty;
            try
            {
                List<Owin_ProcessGetFormActionistEntity_Ext> itemList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Owin_ProcessGetFormActionistEntity_Ext>>(HttpContext.Current.Session["jsonList"].ToString());

                if (itemList != null && itemList.Count > 0)
                {
                    if (itemList.Exists(p => p.ActionName.Contains(actionName)))
                    {
                        permitted = true;
                    }
                }
                return permitted;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public clsPrivateKeys objClsPrivate = new clsPrivateKeys();
    }
}