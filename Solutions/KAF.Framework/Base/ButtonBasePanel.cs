using System;
using System.Diagnostics;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Collections;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web;
using System.Data;
using System.Web.UI.HtmlControls;
//using DevExpress.Web;

namespace KAF.WebFramework
{
    public class ButtonBasePanel
    {
        protected bool _AccFlag = true;
        protected bool _AddFlag = true;
        protected bool _EditFlag = true;
        protected bool _DeleteFlag = true;
        protected bool _PrintFlag = true;

        public bool AccFlag
        {
            get { return _AccFlag; }
            set { _AccFlag = value; }
        }
        public bool AddFlag
        {
            get { return _AddFlag; }
            set { _AddFlag = value; }
        }
        public bool EditFlag
        {
            get { return _EditFlag; }
            set { _EditFlag = value; }
        }
        public bool DeleteFlag
        {
            get { return _DeleteFlag; }
            set { _DeleteFlag = value; }
        }
        public bool PrintFlag
        {
            get { return _PrintFlag; }
            set { _PrintFlag = value; }
        }

        /// <summary>   Gets user per. </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="GetUserPer" type="void">  GetUserPer. </method>
        /// <param name="FormID" type="string">       Identifier for the form. </param>
        /// <param name="MasterUserID" type="string"> Identifier for the master user. </param>

        public void GetUserPer(string FormID, string MasterUserID)
        {

            //BLL.AccessControl obj = new BLL.AccessControl();
            //DataTable dtPermission = obj.CheckPermission(FormName, ModuleName);
            //if (dtPermission.Rows.Count > 0)
            //{
            //    DataRow oRow = null;
            //    oRow = dtPermission.Rows[0];
            //    AccFlag = bool.Parse(oRow["FrmAccess"].ToString());
            //    AddFlag = bool.Parse(oRow["AddPM"].ToString());
            //    EditFlag = bool.Parse(oRow["EditPM"].ToString());
            //    DeleteFlag = bool.Parse(oRow["DeletePM"].ToString());
            //    PrintFlag = bool.Parse(oRow["PrintPM"].ToString());
            //}
        }

        public ButtonBasePanel()
        {
            //
            // TODO: Add constructor logic here
            //
        }



        #region MS BUTTON PANEL

        /// <summary>   Manage CSS for mode. </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="ManageCSSForMode" type="void">    ManageCSSForMode. </method>
        /// <param name="ButtonPanel" type="Panel">  The button panel. </param>

        public void ManageCSSForMode(Panel ButtonPanel)
        {
            foreach (System.Web.UI.Control ctl in ButtonPanel.Controls)
            {
                if (ctl.GetType().ToString() == "System.Web.UI.WebControls.Button")
                {
                    Button btn = (Button)ctl;
                    if (!btn.Enabled)
                    {
                        //btn.Attributes.Remove("class");
                        string tempClass = btn.CssClass;
                        if (tempClass != "KAFButtonDisable")
                        {
                            tempClass = tempClass.Replace("KAFButton", "KAFButtonDisable");
                            btn.CssClass = tempClass;
                        }
                    }
                    else
                    {
                        string tempClass = btn.CssClass;
                        if (tempClass != "KAFButton")
                        {
                            tempClass = tempClass.Replace("KAFButtonDisable", "KAFButton");
                            btn.CssClass = tempClass;
                        }
                    }
                }
            }
        }

        /// <summary>   Button load. </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="BtnLoad" type="void"> BtnLoad. </method>
        /// <param name="ButtonPanel" type="Panel">  The button panel. </param>

        public void BtnLoad(Panel ButtonPanel)
        {

            foreach (System.Web.UI.Control ctl in ButtonPanel.Controls)
            {

                if (ctl.GetType().ToString() == "System.Web.UI.WebControls.Button")
                {
                    Button btn = (Button)ctl;
                    if (btn.ID == "btnSave")
                    {
                        btn.Enabled = AddFlag;
                        btn.Text = "Save";
                        if (KAF.WebFramework.GlobalClass.CultureInfo == "ar-KW")
                        {
                            btn.Text = "حفظ";
                        }
                    }
                    else if (btn.ID == "btnDelete")
                    {
                        btn.Visible = false;
                        btn.Text = "Delete";
                        if (KAF.WebFramework.GlobalClass.CultureInfo == "ar-KW")
                        {
                            btn.Text = "حذف";
                        }
                    }
                    else if (btn.ID == "btnCancel")
                    {
                        btn.Visible = false;
                        btn.Text = "Cancel";
                        if (KAF.WebFramework.GlobalClass.CultureInfo == "ar-KW")
                        {
                            btn.Text = "الغاء";
                        }
                    }
                    else if (btn.ID == "btnPrint")
                    {
                        btn.Visible = false;
                        btn.Text = "Print";
                        if (KAF.WebFramework.GlobalClass.CultureInfo == "ar-KW")
                        {
                            btn.Text = "حذف";
                        }
                    }
                    else if (btn.ID == "btnClear")
                    {
                        btn.Visible = false;
                        btn.Text = "Clear";
                        if (KAF.WebFramework.GlobalClass.CultureInfo == "ar-KW")
                        {
                            btn.Text = "مسح";
                        }
                    }
                    else if (btn.ID == "btnProcess")
                    {
                        btn.Visible = AddFlag;
                        btn.Enabled = AddFlag;
                    }
                    else if (btn.ID == "bthPreView")
                    {
                        btn.Visible = AddFlag;
                        btn.Enabled = AddFlag;
                    }
                    else if (btn.ID == "btnUpdate")
                    {
                        btn.Visible = false;
                        btn.Enabled = false;
                    }

                    #region BUTTON DETAIL
                    else if (btn.ID == "btnDetSave")
                    {
                        btn.Enabled = AddFlag;
                        btn.Text = "Save";
                        if (KAF.WebFramework.GlobalClass.CultureInfo == "ar-KW")
                        {
                            btn.Text = "حفظ";
                        }
                    }
                    else if (btn.ID == "btnDetDelete")
                    {
                        btn.Visible = false;
                        btn.Text = "Delete";
                        if (KAF.WebFramework.GlobalClass.CultureInfo == "ar-KW")
                        {
                            btn.Text = "حذف";
                        }
                    }
                    else if (btn.ID == "btnDetCancel")
                    {
                        btn.Visible = false;
                        btn.Text = "Cancel";
                        if (KAF.WebFramework.GlobalClass.CultureInfo == "ar-KW")
                        {
                            btn.Text = "الغاء";
                        }
                    }
                    #endregion



                    #region PSY
                    else if (btn.ID == "btnpsySave")
                    {
                        btn.Enabled = AddFlag;
                        btn.Text = "Save";
                        if (KAF.WebFramework.GlobalClass.CultureInfo == "ar-KW")
                        {
                            btn.Text = "حفظ";
                        }
                    }
                    else if (btn.ID == "btnpsyPrint")
                    {
                        btn.Visible = false;
                        btn.Text = "Print";
                        if (KAF.WebFramework.GlobalClass.CultureInfo == "ar-KW")
                        {
                            btn.Text = "حذف";
                        }
                    }
                    else if (btn.ID == "btnpsyClear")
                    {
                        btn.Visible = false;
                        btn.Text = "Clear";
                        if (KAF.WebFramework.GlobalClass.CultureInfo == "ar-KW")
                        {
                            btn.Text = "مسح";
                        }
                    }


                    else if (btn.ID == "btnmedSave")
                    {
                        btn.Enabled = AddFlag;
                        btn.Text = "Save";
                        if (KAF.WebFramework.GlobalClass.CultureInfo == "ar-KW")
                        {
                            btn.Text = "حفظ";
                        }
                    }
                    else if (btn.ID == "btnmedPrint")
                    {
                        btn.Visible = false;
                        btn.Text = "Print";
                        if (KAF.WebFramework.GlobalClass.CultureInfo == "ar-KW")
                        {
                            btn.Text = "حذف";
                        }
                    }
                    else if (btn.ID == "btnmedClear")
                    {
                        btn.Visible = false;
                        btn.Text = "Clear";
                        if (KAF.WebFramework.GlobalClass.CultureInfo == "ar-KW")
                        {
                            btn.Text = "مسح";
                        }
                    }
                    #endregion
                }
            }
        }

        /// <summary>   Button delete. </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="BtnDelete" type="void">   BtnDelete. </method>
        /// <param name="ButtonPanel" type="Panel">  The button panel. </param>
        /// <param name="str" type="string">          The string. </param>

        public void BtnDelete(Panel ButtonPanel, string str)
        {
            if (str == "Delete")
                BtnLoad(ButtonPanel);
        }

        /// <summary>   Button cancel. </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="BtnCancel" type="void">   BtnCancel. </method>
        /// <param name="ButtonPanel" type="Panel">  The button panel. </param>

        public void BtnCancel(Panel ButtonPanel)
        {
            BtnLoad(ButtonPanel);
        }

        /// <summary>   Button edit. </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="BtnEdit" type="void"> BtnEdit. </method>
        /// <param name="ButtonPanel" type="Panel">  The button panel. </param>

        public void BtnEdit(Panel ButtonPanel)
        {
            foreach (System.Web.UI.Control ctl in ButtonPanel.Controls)
            {
                if (ctl.GetType().ToString() == "System.Web.UI.WebControls.Button")
                {
                    Button btn = (Button)ctl;
                    if (btn.ID == "btnSave")
                    {
                        btn.Enabled = EditFlag;
                        btn.Text = "Update";
                        if (KAF.WebFramework.GlobalClass.CultureInfo == "ar-KW")
                        {
                            btn.Text = "تحديث";
                        }
                    }
                    else if (btn.ID == "btnDelete")
                    {
                        btn.Visible = true;
                        btn.Enabled = DeleteFlag;
                        btn.Text = "Delete";
                        if (KAF.WebFramework.GlobalClass.CultureInfo == "ar-KW")
                        {
                            btn.Text = "حذف";
                        }
                    }
                    else if (btn.ID == "btnPrint")
                    {
                        btn.Visible = true;
                        btn.Enabled = DeleteFlag;// PrintFlag;
                        btn.Text = "Delete";
                        if (KAF.WebFramework.GlobalClass.CultureInfo == "ar-KW")
                        {
                            btn.Text = "حذف";
                        }
                    }
                    else if (btn.ID == "btnCancel")
                    {
                        btn.Visible = true;
                        btn.Enabled = true;
                    }
                    else if (btn.ID == "btnClear")
                    {
                        btn.Text = "Reset";
                        if (KAF.WebFramework.GlobalClass.CultureInfo == "ar-KW")
                        {
                            btn.Text = "مسح الكل";
                        }
                    }
                    else if (btn.ID == "btnUpdate")
                    {
                        btn.Visible = true;
                        btn.Enabled = EditFlag;
                    }
                    else if (btn.ID == "btnProcess")
                    {
                        btn.Visible = true;
                        btn.Enabled = EditFlag;
                    }

                    #region DETAIL BUTTON
                    else if (btn.ID == "btnDetSave")
                    {
                        btn.Enabled = EditFlag;
                        btn.Text = "Update";
                        if (KAF.WebFramework.GlobalClass.CultureInfo == "ar-KW")
                        {
                            btn.Text = "تحديث";
                        }
                    }
                    else if (btn.ID == "btnDetDelete")
                    {
                        btn.Visible = true;
                        btn.Enabled = DeleteFlag;
                        btn.Text = "Delete";
                        if (KAF.WebFramework.GlobalClass.CultureInfo == "ar-KW")
                        {
                            btn.Text = "حذف";
                        }
                    }
                    else if (btn.ID == "btnDetCancel")
                    {
                        btn.Visible = true;
                        btn.Enabled = true;
                    }
                    #endregion

                    #region PSY
                    else if (btn.ID == "btnpsySave")
                    {
                        btn.Enabled = EditFlag;
                        btn.Text = "Update";
                        if (KAF.WebFramework.GlobalClass.CultureInfo == "ar-KW")
                        {
                            btn.Text = "تحديث";
                        }
                    }
                    else if (btn.ID == "btnmedSave")
                    {
                        btn.Enabled = EditFlag;
                        btn.Text = "Update";
                        if (KAF.WebFramework.GlobalClass.CultureInfo == "ar-KW")
                        {
                            btn.Text = "تحديث";
                        }
                    }
                    #endregion
                }
            }
        }

        /// <summary>   Button add edit. </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="BtnAddEdit" type="void">  BtnAddEdit. </method>
        /// <param name="ButtonPanel" type="Panel">  The button panel. </param>
        /// <param name="str" type="string">          The string. </param>

        public void BtnAddEdit(Panel ButtonPanel, string str)
        {
            if (str == "New")
            {
                foreach (System.Web.UI.Control ctl in ButtonPanel.Controls)
                {
                    if (ctl.GetType().ToString() == "System.Web.UI.WebControls.Button")
                    {
                        Button btn = (Button)ctl;
                        if (btn.ID == "btnSave")
                        {
                            btn.Enabled = AddFlag;
                            btn.Text = "Save";
                            if (KAF.WebFramework.GlobalClass.CultureInfo == "ar-KW")
                            {
                                btn.Text = "حفظ";
                            }
                        }
                        else if (btn.ID == "btnDelete")
                        {
                            btn.Enabled = false;
                            btn.Text = "Delete";
                            if (KAF.WebFramework.GlobalClass.CultureInfo == "ar-KW")
                            {
                                btn.Text = "حذف";
                            }
                        }
                        else if (btn.ID == "btnCancel")
                            btn.Enabled = true;
                        else if (btn.ID == "btnPrint")
                            btn.Enabled = false;
                    }
                }
            }
            else
            {
                foreach (System.Web.UI.Control ctl in ButtonPanel.Controls)
                {
                    if (ctl.GetType().ToString() == "System.Web.UI.WebControls.Button")
                    {
                        Button btn = (Button)ctl;
                        if (btn.ID == "btnSave")
                        {
                            btn.Enabled = EditFlag;
                            btn.Text = "Update";
                            if (KAF.WebFramework.GlobalClass.CultureInfo == "ar-KW")
                            {
                                btn.Text = "تحديث";
                            }
                        }
                        else if (btn.ID == "btnDelete")
                        {
                            btn.Enabled = DeleteFlag;
                            btn.Text = "Delete";
                            if (KAF.WebFramework.GlobalClass.CultureInfo == "ar-KW")
                            {
                                btn.Text = "حذف";
                            }
                        }
                        else if (btn.ID == "btnCancel")
                            btn.Enabled = true;
                    }
                }
            }
        }

        #endregion


















        /*
        private KAF.IBusinessFacade.IuserSecUserInfoFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            KAF.IBusinessFacade.IuserSecUserInfoFacade facade = context.Items["IuserSecUserInfoFacade"] as KAF.IBusinessFacade.IuserSecUserInfoFacade;

            if (facade == null)
            {
                facade = new KAF.BusinessFacade.userSecUserInfoFacade();
                context.Items["IuserSecUserInfoFacade"] = facade;
            }
            return facade;
        }

        */
        //public DataTable GetByUserNameAndPageTitle(string UserName, string PageTitle)
        //{
        //    DataSet ds = GetFacadeCreate().userSecUserInfoGetAllByUserNameAndPageTitle(KAF.BusinessDataObjects.userSecUserInfoEntity.LoadByUserNamePageTitle, UserName, PageTitle);
        //    if (ds.Tables.Count > 0)
        //    {
        //        if (ds.Tables[0].Rows.Count > 0)
        //        {
        //            if (bool.Parse((ds.Tables[0].Rows[0]["AccessPermission"].ToString())))
        //            {
        //                return ds.Tables[1];
        //            }
        //        } 
        //    }
        //    return null;
        //}

        /*
        #region DEV BUTTON PANEL
        public void BtnLoadDEV(DevExpress.Web.ASPxRoundPanel.ASPxRoundPanel ButtonPanel)
        {
            foreach (Control ctl in ButtonPanel.Controls)
            {
                if (ctl.GetType().Equals(typeof(DevExpress.Web.ASPxEditors.ASPxButton)))
                {
                    DevExpress.Web.ASPxEditors.ASPxButton btn = (DevExpress.Web.ASPxEditors.ASPxButton)ctl;
                    if (btn.ID == "btnSave")
                    {
                        btn.Enabled = AddFlag;
                        btn.Text = "Save";
                        //btn. = "confirm('Do you want to continue?');";
                    }
                    else if (btn.ID == "btnClear")
                    {
                        btn.Enabled = false;
                        btn.Text = "Clear";
                    }
                    else if (btn.ID == "btnCancel")
                    {
                        btn.Enabled = true;
                        btn.Text = "Cancel";
                    }
                    else if (btn.ID == "btnPrint")
                        btn.Enabled = false;
                }
            }
        }

        public void BtnDeleteDEV(DevExpress.Web.ASPxRoundPanel.ASPxRoundPanel ButtonPanel, string str)
        {
            if (str == "Delete")
                BtnLoadDEV(ButtonPanel);
        }

        public void BtnCancelDEV(DevExpress.Web.ASPxRoundPanel.ASPxRoundPanel ButtonPanel)
        {
            BtnLoadDEV(ButtonPanel);
        }

        public void BtnEditDEV(DevExpress.Web.ASPxRoundPanel.ASPxRoundPanel ButtonPanel)
        {
            foreach (Control ctl in ButtonPanel.Controls)
            {
                if (ctl.GetType().Equals(typeof(DevExpress.Web.ASPxEditors.ASPxButton)))
                {
                    DevExpress.Web.ASPxEditors.ASPxButton btn = (DevExpress.Web.ASPxEditors.ASPxButton)ctl;
                    if (btn.ID == "btnSave")
                    {
                        btn.Enabled = EditFlag;
                        btn.Text = "Update";
                    }
                    else if (btn.ID == "btnClear")
                    {
                        btn.Enabled = DeleteFlag;
                        btn.Text = "Clear";
                    }
                    else if (btn.ID == "btnPrint")
                    {
                        btn.Enabled = DeleteFlag;
                        btn.Text = "Delete";
                    }
                    else if (btn.ID == "btnCancel")
                        btn.Enabled = true;
                }
            }
        }

        public void BtnAddEditDEV(DevExpress.Web.ASPxRoundPanel.ASPxRoundPanel ButtonPanel, string str)
        {
            if (str == "New")
            {
                foreach (Control ctl in ButtonPanel.Controls)
                {
                    if (ctl.GetType().Equals(typeof(DevExpress.Web.ASPxEditors.ASPxButton)))
                    {
                        DevExpress.Web.ASPxEditors.ASPxButton btn = (DevExpress.Web.ASPxEditors.ASPxButton)ctl;
                        if (btn.ID == "btnSave")
                        {
                            btn.Enabled = AddFlag;
                            btn.Text = "Save";
                        }
                        else if (btn.ID == "btnDelete")
                        {
                            btn.Enabled = false;
                            btn.Text = "Delete";
                        }
                        else if (btn.ID == "btnCancel")
                            btn.Enabled = true;
                        else if (btn.ID == "cmdPrint")
                            btn.Enabled = false;
                    }
                }
            }
            else
            {
                foreach (Control ctl in ButtonPanel.Controls)
                {
                    if (ctl.GetType().Equals(typeof(DevExpress.Web.ASPxEditors.ASPxButton)))
                    {
                        DevExpress.Web.ASPxEditors.ASPxButton btn = (DevExpress.Web.ASPxEditors.ASPxButton)ctl;
                        if (btn.ID == "btnSave")
                        {
                            btn.Text = "Update";
                            btn.Enabled = EditFlag;
                        }
                        else if (btn.ID == "btnDelete")
                        {
                            btn.Enabled = DeleteFlag;
                            btn.Text = "Delete";
                        }
                        else if (btn.ID == "btnCancel")
                            btn.Enabled = true;
                    }
                }
            }
        }
        #endregion
*/
    }
}
