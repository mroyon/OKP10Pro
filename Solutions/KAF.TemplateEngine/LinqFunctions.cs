#region Imports

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using CodeSmith.Engine;
using SchemaExplorer;
using System.Text;

#endregion

public class btentity
{
    #region Properties

    protected string _referenced_table_name;
    protected string _referenced_table_column_name;

    public string referenced_table_name
    {
        get { return _referenced_table_name; }
        set { _referenced_table_name = value; }
    }
    public string referenced_table_column_name
    {
        get { return _referenced_table_column_name; }
        set { _referenced_table_column_name = value; }
    }
    #endregion

    #region Constructor

    public btentity() : base()
    {
    }

    public btentity(IDataReader reader)
    {
        this.LoadFromReader(reader);
    }

    protected void LoadFromReader(IDataReader reader)
    {
        if (reader != null && !reader.IsClosed)
        {
            if (!reader.IsDBNull(reader.GetOrdinal("referenced_table_name"))) _referenced_table_name = reader.GetString(reader.GetOrdinal("referenced_table_name"));
            if (!reader.IsDBNull(reader.GetOrdinal("referenced_column_name"))) _referenced_table_column_name = reader.GetString(reader.GetOrdinal("referenced_column_name"));
        }
    }
    #endregion
}

public class LinqFunctions : CodeTemplate
{
    //public const string _strConnection = @"Data Source=192.168.200.202;Initial Catalog=KAF_HR_V1.0;User ID=sa;Password=Asdf1234";
 public const string _strConnection = @"Data Source=10.76.10.51;Initial Catalog=BMC_Automation_V1.0_Test;User ID=sa;Password=Asdf1234";
    #region Naming

    public string drawHTMLExcluded(TableSchema table, string readonlyYN)
    {
        List<ColumnSchema> objColumnList = new List<ColumnSchema>();
        string divRowStart = "\t\t\t\t\t <div class=\"row \">";
        string divColumnStart = "\t\t\t\t\t\t <div class=\"col-md-6\">";
        string divClose = "</div>";
        string div = string.Empty;
        bool flgHasFileControl = false;
        ColumnSchema fileControlColumn = null;

        foreach (ColumnSchema column in table.Columns)
        {
            if (!ShouldExcludeColumn(column.Name))
                objColumnList.Add(column);
        }

        if (objColumnList != null && objColumnList.Count > 0)
        {
            for (int i = 0; i < objColumnList.Count; i = i + 2)
            {
                div += divRowStart + Environment.NewLine;
                //div += divColumnStart + Environment.NewLine;
                var items = objColumnList.Skip(i).Take(2);

                foreach (ColumnSchema st in items)
                {
                    if (st.IsPrimaryKeyMember)
                        continue;
                    else if ((st.Name.ToLower().Contains("eng")) || (st.Name.ToLower().Contains("oracle")) || (st.Name.ToLower().Contains("priority")))
                    {
                        continue;
                    }
                    else
                    {

                        div += divColumnStart + Environment.NewLine;
                        div += "\t\t\t\t\t\t\t <div class=\"form-group\">" + Environment.NewLine; ;

                        if (st.IsForeignKeyMember)
                            div += drawForeignKeyHTML(st, table, readonlyYN);
                        else
                        {
                            if ((st.NativeType.ToUpper() == "VARCHAR") || (st.NativeType.ToUpper() == "NVARCHAR") || (st.NativeType.ToLower() == "uniqueidentifier") || (st.NativeType.ToUpper() == "NCHAR"))
                            {
                                div += drawTextFldHTML(st, table, readonlyYN);
                                if (st.Description.ToLower() == "ftp")
                                {
                                    fileControlColumn = st;
                                    flgHasFileControl = true;
                                }
                            }
                            else if ((st.NativeType == "int") || (st.NativeType == "bigint") || (st.NativeType == "decimal") || (st.NativeType == "numeric"))
                            {
                                div += drawNumericFldHTML(st, table, readonlyYN);
                            }
                            else if ((st.NativeType.ToUpper() == "NTEXT"))
                            {
                                div += drawNTextFldHTML(st, table, readonlyYN);
                            }
                            else if ((st.NativeType == "bit"))
                            {
                                div += drawBitFldHTML(st, table, readonlyYN);
                            }
                            else if ((st.NativeType == "datetime") || (st.NativeType == "date"))
                            {
                                div += drawDateFldHTML(st, table, readonlyYN);
                            }
                        }

                        div += "\t\t\t\t\t\t\t" + divClose + Environment.NewLine;
                        div += "\t\t\t\t\t\t" + divClose + Environment.NewLine;
                    }
                }
                div += "\t\t\t\t\t" + divClose + Environment.NewLine;
                if (flgHasFileControl)
                {
                    div += drawFileContolsforCHTML(table, fileControlColumn);
                    flgHasFileControl = false;
                    fileControlColumn = null;
                }
            }
        }

        return div;
    }
    private string drawFileContolsforCHTML(TableSchema table, ColumnSchema fileControlColumn)
    {
        string div = string.Empty + Environment.NewLine;
        div += "\t\t\t\t\t <div class=\"row\">" + Environment.NewLine;
        div += "\t\t\t\t\t\t <div class=\"col-md-12\">" + Environment.NewLine;
        div += "\t\t\t\t\t\t\t <div class=\"form-group\">" + Environment.NewLine;
        div += "\t\t\t\t\t\t\t\t <div id=\"" + fileControlColumn.Name.ToLower() + "\"></div>" + Environment.NewLine;
        div += "\t\t\t\t\t\t\t</div>" + Environment.NewLine;
        div += "\t\t\t\t\t\t</div>" + Environment.NewLine;
        div += "\t\t\t\t\t</div>" + Environment.NewLine; ;
        div += Environment.NewLine;
        return div;
    }

    #region File CONTROL
    public string drawFileContolsforScriptInsert_01(TableSchema table)
    {
        string div = string.Empty;
        bool fileControlrequired = false;
        foreach (ColumnSchema col in table.Columns)
        {
            if (col.Description.ToLower() == "ftp")
            {
                fileControlrequired = true;
                break;
            }
        }
        if (fileControlrequired)
        {
            div += " var fileobject = @Html.Raw(Json.Encode(Model.cor_foldercontentsList));" + Environment.NewLine;
            div += "" + Environment.NewLine;
            div += "" + Environment.NewLine;
            div += "$('.footable').footable({" + Environment.NewLine;
            div += "\t calculateWidthOverride: function () {" + Environment.NewLine;
            div += "\t\t return { width: $(window).width() };" + Environment.NewLine;
            div += "\t }" + Environment.NewLine;
            div += "});" + Environment.NewLine;
        }
        div += "" + Environment.NewLine;
        div += "" + Environment.NewLine;

        div += Environment.NewLine;
        return div;
    }
    public string drawFileContolsforScriptInsert_02(TableSchema table, bool isEdit = false, bool isDelete = false)
    {
        string div = string.Empty;
        // div += "<script>";
        foreach (ColumnSchema col in table.Columns)
        {
            if (col.Description.ToLower() == "ftp")
            {
                string substring = "FileDescription";
                int indexOfSubString = col.Name.IndexOf(substring);
                string withoutSubString = col.Name.Remove(indexOfSubString, substring.Length);


                div += "$(document).ready(function () {" + Environment.NewLine;
                if (isEdit)
                    div += "\t var _" + col.Name.ToLower() + "upld = $('#" + col.Name.ToLower() + "upld').kaffileUploader({" + Environment.NewLine;
                else
                    div += "\t $('#" + col.Name.ToLower() + "upld').kaffileUploader({" + Environment.NewLine;

                div += "\t\t _tableid: 'tbl_" + col.Name.ToLower() + "', " + Environment.NewLine;
                div += "\t\t _colname: '" + col.Name.ToLower() + "'," + Environment.NewLine;
                div += "\t\t _tabname: '" + table.Name + "'," + Environment.NewLine;
                div += "\t\t _fileuploadbuttontext: 'Upload files'," + Environment.NewLine;
                div += "\t\t _modelid: 'File_upload_for_" + withoutSubString + "_Document'," + Environment.NewLine;
                div += "\t\t _modeltext: 'File upload for " + withoutSubString + " Document'," + Environment.NewLine;
                div += "\t\t _fileinputname: 'inpfile" + col.Name.ToLower() + "'," + Environment.NewLine;
                div += "\t\t _containeruploadpreview: '" + col.Name.ToLower() + "uploadpreview'," + Environment.NewLine;
                if (isDelete)
                    div += "\t\t _containerdeletebuttontext: ''," + Environment.NewLine;
                else
                    div += "\t\t _containerdeletebuttontext: '@KAF.MsgContainer._Common._btnDelete'," + Environment.NewLine;

                div += "\t\t _ismultiple: true," + Environment.NewLine;
                div += "\t\t _fileobject: fileobject" + Environment.NewLine;
                div += "" + Environment.NewLine;
                if (isEdit)
                {
                    if (isDelete)
                        div += "\t\t _" + col.Name.ToLower() + "upld.loadpreloaddata(fileobject, $(\"#" + col.Name.ToLower() + "uploadpreview\"), '', '" + col.Name.ToLower() + "');" + Environment.NewLine;
                    else
                        div += "\t\t _" + col.Name.ToLower() + "upld.loadpreloaddata(fileobject, $(\"#" + col.Name.ToLower() + "uploadpreview\"), '@KAF.MsgContainer._Common._btnDelete', '" + col.Name.ToLower() + "');" + Environment.NewLine;
                    div += "" + Environment.NewLine;
                }

                div += "});" + Environment.NewLine;


            }
        }
        div += Environment.NewLine;
        return div;
    }


    public string drawFileContolsforScriptInsertJS_01(TableSchema table)
    {
        string div = string.Empty;
        List<string> fileControl = new List<string>();
        bool hasmorecontrols = false;
        foreach (ColumnSchema col in table.Columns)
        {
            if (col.Description.ToLower() == "ftp")
            {
                fileControl.Add(col.Name.ToLower());
            }
        }
        if (fileControl.Count > 0)
        {

            div += "\t\t\t var kaffileUploader = $('#id').kaffileUploader();" + Environment.NewLine;

            foreach (string str in fileControl)
            {
                div += "\t\t\t var fileobjects_tbl_" + str + " = $('#id').kaffileUploader.GetFilesForActions('tbl_" + str + "');" + Environment.NewLine;

                if (fileControl.Count == 1)
                {
                    div += "\t\t\t var fileobjects = fileobjects_tbl_" + str + ";" + Environment.NewLine;
                }
                else if (fileControl.Count > 1)
                {
                    hasmorecontrols = true;

                    //var fileobjects = fileobjects_tbl_salarystopfileno.concat(fileobjects_tbl_escapefileno, fileobjects_tbl_rejoinfileno);
                }
            }
            if (hasmorecontrols)
            {
                string parentfileControl = string.Empty;
                List<string> childfileControl = new List<string>();
                for (int i = 0; i <= fileControl.Count - 1; i++)
                {
                    if (i == 0)
                        parentfileControl = fileControl[i];
                    else
                        childfileControl.Add("fileobjects_tbl_" + fileControl[i]);
                }

                div += "\t\t\t var fileobjects = fileobjects_tbl_" + parentfileControl + ".concat(" + string.Join(",", childfileControl) + ");" + Environment.NewLine;
            }
            div += "" + Environment.NewLine;
            div += "\t\t\t  $.each(fileobjects, function (key, valueObj) {" + Environment.NewLine;
            div += "\t\t\t\t\t  valueObj.__RequestVerificationToken = $('input[name=__RequestVerificationToken]').val();" + Environment.NewLine;
            div += "\t\t\t   });" + Environment.NewLine;
        }
        div += "" + Environment.NewLine;
        div += "" + Environment.NewLine;

        div += Environment.NewLine;
        return div;
    }
    public string drawFileContolsforScriptInsertJS_02(TableSchema table)
    {
        string div = string.Empty;
        List<string> fileControl = new List<string>();
        bool hasmorecontrols = false;
        foreach (ColumnSchema col in table.Columns)
        {
            if (col.Description.ToLower() == "ftp")
            {
                fileControl.Add(col.Name.ToLower());
                break;
            }
        }
        if (fileControl.Count > 0)
        {

            div += "\t\t\t\t\t\t\t cor_foldercontentsList: fileobjects" + Environment.NewLine;
        }
        div += Environment.NewLine;
        return div;
    }

    public string new_Addons_fileControl(TableSchema table)
    {
        string div = string.Empty;
        bool hasfilecontrol = false;
        foreach (ColumnSchema col in table.Columns)
        {
            if (col.Description.ToLower() == "ftp")
            {
                hasfilecontrol = true;
                break;
            }
        }
        if (hasfilecontrol)
            div += "\t\t\t\tmodel.cor_foldercontentsList = new List<cor_foldercontentsEntity>();" + Environment.NewLine;
        return div;
    }

    public string insert_Addons_fileControl(TableSchema table)
    {
        string div = string.Empty;
        bool hasfilecontrol = false;
        foreach (ColumnSchema col in table.Columns)
        {
            if (col.Description.ToLower() == "ftp")
            {
                hasfilecontrol = true;
                break;
            }
        }
        if (hasfilecontrol)
        {
            div += "\t\t\t\t\t//START OF NO CHANGE REGION" + Environment.NewLine;
            div += "\t\t\t\t\t string userid = Session[\"selectedprofile\"] != null ? ((hr_basicprofileEntity)Session[\"selectedprofile\"]).userid.GetValueOrDefault().ToString() : \"\";" + Environment.NewLine;
            div += "\t\t\t\t\t input.strValue6 = userid;" + Environment.NewLine;
            div += "\t\t\t\t\t input.strValue5 = Session[\"selectedprofile\"] != null ? ((hr_basicprofileEntity)Session[\"selectedprofile\"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : \"\";" + Environment.NewLine;
            div += "\t\t\t\t\t Int64 ret = 0;" + Environment.NewLine;
            div += "\t\t\t\t\t List<cor_foldercontentsEntity> objFileList = new List<cor_foldercontentsEntity>();" + Environment.NewLine;
            div += "\t\t\t\t\t objFileList = input.cor_foldercontentsList;" + Environment.NewLine;
            div += "\t\t\t\t\t List<KAFGenericComboEntity> retArray = new List<KAFGenericComboEntity>();" + Environment.NewLine;
            div += "\t\t\t\t\t //END OF NO CHANGE REGION" + Environment.NewLine;
            div += "\t\t\t\t\t // CHANGE ThiS LINE TO MAKE A SAVE" + Environment.NewLine;
            div += "\t\t\t\t\t //retArray = KAF.FacadeCreatorObjects." + table.Name.ToLower() + "FCC.GetFacadeCreate().Add_WithFiles(input).ToList();" + Environment.NewLine;

            div += "\t\t\t\t\t " + Environment.NewLine;
            div += "\t\t\t\t\t //START OF NO CHANGE REGION" + Environment.NewLine;
            div += "\t\t\t\t\t  if (retArray != null && retArray.Count > 0)" + Environment.NewLine;
            div += "\t\t\t\t\t {" + Environment.NewLine;
            div += "\t\t\t\t\t\t ret = 0;" + Environment.NewLine;
            div += "\t\t\t\t\t\t KAF.AppConfiguration.Configuration.FileHandler objFTP = new KAF.AppConfiguration.Configuration.FileHandler();" + Environment.NewLine;
            div += "\t\t\t\t\t\t if (objFileList != null && objFileList.Count > 0)" + Environment.NewLine;
            div += "\t\t\t\t\t\t {" + Environment.NewLine;
            div += "\t\t\t\t\t\t\t foreach (cor_foldercontentsEntity file in objFileList)" + Environment.NewLine;
            div += "\t\t\t\t\t\t\t {" + Environment.NewLine;
            div += "\t\t\t\t\t\t\t\t byte[] imageBytes = Convert.FromBase64String(file.comment);" + Environment.NewLine;
            div += "\t\t\t\t\t\t\t\t objFTP.UploadFileFTP(imageBytes, userid + \"/Upload/\", file.filename, file.extension);" + Environment.NewLine;
            div += "\t\t\t\t\t\t\t }" + Environment.NewLine;
            div += "\t\t\t\t\t\t }" + Environment.NewLine;
            div += "\t\t\t\t\t ret = 1;" + Environment.NewLine;
            div += "\t\t\t\t\t }" + Environment.NewLine;
            div += "\t\t\t\t\t //END OF NO CHANGE REGION" + Environment.NewLine;
            div += "\t\t\t\t\t " + Environment.NewLine;


        }
        return div;
    }

    public string edit_Addons_fileControl(TableSchema table)
    {
        string div = string.Empty;
        bool hasfilecontrol = false;
        foreach (ColumnSchema col in table.Columns)
        {
            if (col.Description.ToLower() == "ftp")
            {
                hasfilecontrol = true;
                break;
            }
        }
        if (hasfilecontrol)
        {
            div += "\t\t\t\t\t string userid = Session[\"selectedprofile\"] != null ? ((hr_basicprofileEntity)Session[\"selectedprofile\"]).userid.GetValueOrDefault().ToString() : \"\";" + Environment.NewLine;
            div += "\t\t\t\t\t model.strValue6 = userid;" + Environment.NewLine;
            div += "\t\t\t\t\t model.strValue5 = Session[\"selectedprofile\"] != null ? ((hr_basicprofileEntity)Session[\"selectedprofile\"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : \"\";" + Environment.NewLine;
            div += "\t\t\t\t\t model.cor_foldercontentsList = new List<cor_foldercontentsEntity>();" + Environment.NewLine;
            div += "\t\t\t\t\t model.cor_foldercontentsList = KAF.FacadeCreatorObjects.cor_foldercontentsFCC.GetFacadeCreate().GetAll(new cor_foldercontentsEntity" + Environment.NewLine;
            div += "\t\t\t\t\t {" + Environment.NewLine;
            div += "\t\t\t\t\t      tablename = \"" + table.Name + "\"," + Environment.NewLine;
            div += "\t\t\t\t\t      folderid = long.Parse(model.strValue5)," + Environment.NewLine;
            div += "\t\t\t\t\t      columnpkid = model." + getPrimaryKeyColumnName(table) + "" + Environment.NewLine;
            div += "\t\t\t\t\t }).ToList();" + Environment.NewLine;
            div += "\t\t\t\t\t //END OF NO CHANGE REGION" + Environment.NewLine;
        }
        return div;
    }

    public string update_Addons_fileControl(TableSchema table)
    {
        string div = string.Empty;
        bool hasfilecontrol = false;
        foreach (ColumnSchema col in table.Columns)
        {
            if (col.Description.ToLower() == "ftp")
            {
                hasfilecontrol = true;
                break;
            }
        }
        if (hasfilecontrol)
        {
            div += "\t\t\t\t\t//START OF NO CHANGE REGION" + Environment.NewLine;
            div += "\t\t\t\t\t string userid = Session[\"selectedprofile\"] != null ? ((hr_basicprofileEntity)Session[\"selectedprofile\"]).userid.GetValueOrDefault().ToString() : \"\";" + Environment.NewLine;
            div += "\t\t\t\t\t input.strValue6 = userid;" + Environment.NewLine;
            div += "\t\t\t\t\t input.strValue5 = Session[\"selectedprofile\"] != null ? ((hr_basicprofileEntity)Session[\"selectedprofile\"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : \"\";" + Environment.NewLine;
            div += "\t\t\t\t\t Int64 ret = 0;" + Environment.NewLine;
            div += "\t\t\t\t\t List<cor_foldercontentsEntity> objFileList = new List<cor_foldercontentsEntity>();" + Environment.NewLine;
            div += "\t\t\t\t\t objFileList = input.cor_foldercontentsList.Where(p=> p.strValue1 == \"deleted\" || p.strValue1 == \"added\").ToList();" + Environment.NewLine;
            div += "\t\t\t\t\t input.cor_foldercontentsList = objFileList;" + Environment.NewLine;

            div += "\t\t\t\t\t List<KAFGenericComboEntity> retArray = new List<KAFGenericComboEntity>();" + Environment.NewLine;
            div += "\t\t\t\t\t //END OF NO CHANGE REGION" + Environment.NewLine;
            div += "\t\t\t\t\t // CHANGE ThiS LINE TO MAKE A SAVE" + Environment.NewLine;
            div += "\t\t\t\t\t //retArray = KAF.FacadeCreatorObjects." + table.Name.ToLower() + "FCC.GetFacadeCreate().Update_WithFiles(input).ToList();" + Environment.NewLine;

            div += "\t\t\t\t\t " + Environment.NewLine;
            div += "\t\t\t\t\t //START OF NO CHANGE REGION" + Environment.NewLine;
            div += "\t\t\t\t\t  if (retArray != null && retArray.Count > 0)" + Environment.NewLine;
            div += "\t\t\t\t\t {" + Environment.NewLine;
            div += "\t\t\t\t\t\t ret = 0;" + Environment.NewLine;
            div += "\t\t\t\t\t\t KAF.AppConfiguration.Configuration.FileHandler objFTP = new KAF.AppConfiguration.Configuration.FileHandler();" + Environment.NewLine;
            div += "\t\t\t\t\t\t if (objFileList != null && objFileList.Count > 0)" + Environment.NewLine;
            div += "\t\t\t\t\t\t {" + Environment.NewLine;

            div += "\t\t\t\t\t\t List<cor_foldercontentsEntity> objFileDeleteList = new List<cor_foldercontentsEntity>();" + Environment.NewLine;
            div += "\t\t\t\t\t\t List<cor_foldercontentsEntity> objFileAddList = new List<cor_foldercontentsEntity>();" + Environment.NewLine;
            div += "\t\t\t\t\t\t objFileDeleteList = objFileList.Where(p => p.strValue1 == \"deleted\").ToList();" + Environment.NewLine;
            div += "\t\t\t\t\t\t objFileAddList = objFileList.Where(p => p.strValue1 == \"added\").ToList();" + Environment.NewLine;
            div += "\t\t\t\t\t\t foreach (cor_foldercontentsEntity file in objFileAddList)" + Environment.NewLine;
            div += "\t\t\t\t\t\t {" + Environment.NewLine;
            div += "\t\t\t\t\t\t    byte[] imageBytes = Convert.FromBase64String(file.comment);" + Environment.NewLine;
            div += "\t\t\t\t\t\t    objFTP.UploadFileFTP(imageBytes, userid + \"/Upload/\", file.filename, file.extension);" + Environment.NewLine;
            div += "\t\t\t\t\t\t }" + Environment.NewLine;
            div += "\t\t\t\t\t\t " + Environment.NewLine;
            div += "\t\t\t\t\t\t " + Environment.NewLine;

            div += "\t\t\t\t\t\t foreach (cor_foldercontentsEntity file in objFileDeleteList)" + Environment.NewLine;
            div += "\t\t\t\t\t\t {" + Environment.NewLine;
            div += "\t\t\t\t\t\t objFTP.DeleteFileFTP(userid + \"/Upload/\", file.filename, file.extension);" + Environment.NewLine;
            div += "\t\t\t\t\t\t }" + Environment.NewLine;



            div += "\t\t\t\t\t\t }" + Environment.NewLine;
            div += "\t\t\t\t\t ret = 1;" + Environment.NewLine;
            div += "\t\t\t\t\t }" + Environment.NewLine;
            div += "\t\t\t\t\t //END OF NO CHANGE REGION" + Environment.NewLine;
            div += "\t\t\t\t\t " + Environment.NewLine;


        }
        return div;
    }

    public string delete_Addons_fileControl(TableSchema table)
    {
        string div = string.Empty;
        bool hasfilecontrol = false;
        foreach (ColumnSchema col in table.Columns)
        {
            if (col.Description.ToLower() == "ftp")
            {
                hasfilecontrol = true;
                break;
            }
        }
        if (hasfilecontrol)
        {
            div += "\t\t\t\t\t//START OF NO CHANGE REGION" + Environment.NewLine;
            div += "\t\t\t\t\t string userid = Session[\"selectedprofile\"] != null ? ((hr_basicprofileEntity)Session[\"selectedprofile\"]).userid.GetValueOrDefault().ToString() : \"\";" + Environment.NewLine;
            div += "\t\t\t\t\t input.strValue6 = userid;" + Environment.NewLine;
            div += "\t\t\t\t\t input.strValue5 = Session[\"selectedprofile\"] != null ? ((hr_basicprofileEntity)Session[\"selectedprofile\"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : \"\";" + Environment.NewLine;
            div += "\t\t\t\t\t input.cor_foldercontentsList = new List<cor_foldercontentsEntity>();" + Environment.NewLine;
            div += "\t\t\t\t\t input.cor_foldercontentsList = KAF.FacadeCreatorObjects.cor_foldercontentsFCC.GetFacadeCreate().GetAll(new cor_foldercontentsEntity" + Environment.NewLine;
            div += "\t\t\t\t\t {" + Environment.NewLine;
            div += "\t\t\t\t\t  tablename = \"" + table.Name + "\"," + Environment.NewLine;
            div += "\t\t\t\t\t  folderid = long.Parse(input.strValue5)," + Environment.NewLine;
            div += "\t\t\t\t\t  columnpkid = input.qualificationid" + Environment.NewLine;
            div += "\t\t\t\t\t }).ToList();" + Environment.NewLine;
            div += "\t\t\t\t\t " + Environment.NewLine;

            div += "\t\t\t\t\t List<KAFGenericComboEntity> retArray = new List<KAFGenericComboEntity>();" + Environment.NewLine;
            div += "\t\t\t\t\t //END OF NO CHANGE REGION" + Environment.NewLine;
            div += "\t\t\t\t\t // CHANGE ThiS LINE TO MAKE A SAVE" + Environment.NewLine;
            div += "\t\t\t\t\t //retArray = KAF.FacadeCreatorObjects." + table.Name.ToLower() + "FCC.GetFacadeCreate().Delete_WithFiles(input).ToList();" + Environment.NewLine;

            div += "\t\t\t\t\t " + Environment.NewLine;
            div += "\t\t\t\t\t //START OF NO CHANGE REGION" + Environment.NewLine;
            div += "\t\t\t\t\t  if (retArray != null && retArray.Count > 0)" + Environment.NewLine;
            div += "\t\t\t\t\t {" + Environment.NewLine;
            div += "\t\t\t\t\t\t ret = 0;" + Environment.NewLine;
            div += "\t\t\t\t\t\t KAF.AppConfiguration.Configuration.FileHandler objFTP = new KAF.AppConfiguration.Configuration.FileHandler();" + Environment.NewLine;
            div += "\t\t\t\t\t\t if (input.cor_foldercontentsList != null && input.cor_foldercontentsList.Count > 0)" + Environment.NewLine;
            div += "\t\t\t\t\t\t {" + Environment.NewLine;

            div += "\t\t\t\t\t\t  List<cor_foldercontentsEntity> objFileDeleteList = new List<cor_foldercontentsEntity>();" + Environment.NewLine;
            div += "\t\t\t\t\t\t objFileDeleteList = input.cor_foldercontentsList;" + Environment.NewLine;
            div += "\t\t\t\t\t\t " + Environment.NewLine;

            div += "\t\t\t\t\t\t foreach (cor_foldercontentsEntity file in objFileDeleteList)" + Environment.NewLine;
            div += "\t\t\t\t\t\t {" + Environment.NewLine;
            div += "\t\t\t\t\t\t objFTP.DeleteFileFTP(userid + \"/Upload/\", file.filename, file.extension);" + Environment.NewLine;
            div += "\t\t\t\t\t\t }" + Environment.NewLine;

            div += "\t\t\t\t\t\t }" + Environment.NewLine;
            div += "\t\t\t\t\t ret = 1;" + Environment.NewLine;
            div += "\t\t\t\t\t }" + Environment.NewLine;
            div += "\t\t\t\t\t //END OF NO CHANGE REGION" + Environment.NewLine;
            div += "\t\t\t\t\t " + Environment.NewLine;

        }
        return div;
    }

    public string detail_Addons_fileControl(TableSchema table)
    {
        string div = string.Empty;
        bool hasfilecontrol = false;
        foreach (ColumnSchema col in table.Columns)
        {
            if (col.Description.ToLower() == "ftp")
            {
                hasfilecontrol = true;
                break;
            }
        }
        if (hasfilecontrol)
        {
            div += "\t\t\t\t\t string userid = Session[\"selectedprofile\"] != null ? ((hr_basicprofileEntity)Session[\"selectedprofile\"]).userid.GetValueOrDefault().ToString() : \"\";" + Environment.NewLine;
            div += "\t\t\t\t\t model.strValue6 = userid;" + Environment.NewLine;
            div += "\t\t\t\t\t model.strValue5 = Session[\"selectedprofile\"] != null ? ((hr_basicprofileEntity)Session[\"selectedprofile\"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : \"\";" + Environment.NewLine;
            div += "\t\t\t\t\t model.cor_foldercontentsList = new List<cor_foldercontentsEntity>();" + Environment.NewLine;
            div += "\t\t\t\t\t model.cor_foldercontentsList = KAF.FacadeCreatorObjects.cor_foldercontentsFCC.GetFacadeCreate().GetAll(new cor_foldercontentsEntity" + Environment.NewLine;
            div += "\t\t\t\t\t {" + Environment.NewLine;
            div += "\t\t\t\t\t      tablename = \"" + table.Name + "\"," + Environment.NewLine;
            div += "\t\t\t\t\t      folderid = long.Parse(model.strValue5)," + Environment.NewLine;
            div += "\t\t\t\t\t      columnpkid = model." + getPrimaryKeyColumnName(table) + "" + Environment.NewLine;
            div += "\t\t\t\t\t }).ToList();" + Environment.NewLine;
            div += "\t\t\t\t\t //END OF NO CHANGE REGION" + Environment.NewLine;
        }
        return div;
    }
    #endregion File CONTROL


    public string drawModelBuildForJSExcluded(TableSchema table, bool includeprimarykey = true)
    {
        List<ColumnSchema> objColumnList = new List<ColumnSchema>();

        string div = string.Empty;

        foreach (ColumnSchema column in table.Columns)
        {
            if (!ShouldExcludeColumn(column.Name))
                objColumnList.Add(column);
        }

        int i = 0;
        if (objColumnList != null && objColumnList.Count > 0)
        {
            foreach (ColumnSchema st in objColumnList)
            {
                if ((!includeprimarykey) && (st.IsPrimaryKeyMember))
                    continue;
                else if ((st.Name.ToLower().Contains("eng")) || (st.Name.ToLower().Contains("oracle")) || (st.Name.ToLower().Contains("priority")) || (st.Name.ToLower().Contains("_")))
                {
                    continue;
                }
                else
                {
                    if ((st.NativeType == "datetime") || (st.NativeType == "date"))
                        div += "\t\t\t\t\t\t\t " + st.Name.ToLower() + ": GetDateFromTextBox($('#" + st.Name.ToLower() + "').val())," + Environment.NewLine;
                    else
                        div += "\t\t\t\t\t\t\t " + st.Name.ToLower() + ": $('#" + st.Name.ToLower() + "').val()," + Environment.NewLine;
                }

            }
        }
        return div;
    }
    public string GetDateTimeFromToJS(TableSchema table)
    {
        string div = string.Empty;
        List<ColumnSchema> objColumnList = new List<ColumnSchema>();

        foreach (ColumnSchema column in table.Columns)
        {
            if (!ShouldExcludeColumn(column.Name))
                objColumnList.Add(column);
        }

        if (objColumnList != null && objColumnList.Count > 0)
        {
            foreach (ColumnSchema col in objColumnList)
            {
                if ((col.NativeType == "datetime") || (col.NativeType == "date"))
                {
                    div += "$(\"input." + col.Name.ToLower() + "\").datepicker({" + Environment.NewLine;
                    div += "    dateFormat: 'dd-mm-yy', changeMonth: true, changeYear: true, yearRange: '1930:' + nextYear, onSelect: function (selected) {" + Environment.NewLine;
                    div += "        $(\".dateto\").datepicker(\"option\", \"minDate\", selected)" + Environment.NewLine;
                    div += "    }" + Environment.NewLine;
                    div += "}" + Environment.NewLine;
                    div += Environment.NewLine;
                }
            }
        }

        return div;
    }


    public string drawDetailEntityFiller(TableSchema table, string prefix)
    {
        string div = string.Empty;
        List<ColumnSchema> objColumnList = new List<ColumnSchema>();
        foreach (ColumnSchema column in table.Columns)
        {
            if (column.IsPrimaryKeyMember)
                continue;
            else if (column.IsForeignKeyMember)
                continue;
            else if (!ShouldExcludeColumn(column.Name))
                objColumnList.Add(column);
        }

        foreach (ColumnSchema col in objColumnList)
        {
            div += "\t\t\t\t\t " + prefix + GetClassName(table) + "." + col.Name.ToLower() + " = input." + col.Name.ToLower() + ";" + Environment.NewLine;
        }

        return div;
    }
    public string drawModelBuildForJS(TableSchema table, bool includeprimarykey = true)
    {
        List<ColumnSchema> objColumnList = new List<ColumnSchema>();

        string div = string.Empty;

        foreach (ColumnSchema column in table.Columns)
        {
            if (!ShouldExcludeColumn(column.Name))
                objColumnList.Add(column);
        }

        int i = 0;
        if (objColumnList != null && objColumnList.Count > 0)
        {
            foreach (ColumnSchema st in objColumnList)
            {
                if ((!includeprimarykey) && (st.IsPrimaryKeyMember))
                    continue;
                else
                {
                    if ((st.NativeType == "datetime") || (st.NativeType == "date"))
                        div += "\t\t\t\t\t\t\t " + st.Name.ToLower() + ": GetDateFromTextBox($('#" + st.Name.ToLower() + "').val())," + Environment.NewLine;
                    else
                        div += "\t\t\t\t\t\t\t " + st.Name.ToLower() + ": $('#" + st.Name.ToLower() + "').val()," + Environment.NewLine;
                }

            }
        }
        return div;
    }

    public string drawFormFillerForJS(TableSchema table, bool includeprimarykey = true)
    {
        List<ColumnSchema> objColumnList = new List<ColumnSchema>();

        string div = string.Empty;

        foreach (ColumnSchema column in table.Columns)
        {
            if (!ShouldExcludeColumn(column.Name))
                objColumnList.Add(column);
        }

        int i = 0;
        if (objColumnList != null && objColumnList.Count > 0)
        {
            foreach (ColumnSchema st in objColumnList)
            {
                if ((!includeprimarykey) && (st.IsPrimaryKeyMember))
                    continue;
                else
                {
                    if ((st.NativeType == "datetime") || (st.NativeType == "date"))
                        div += "\t\t\t\t\t\t\t $(\"#" + st.Name.ToLower() + "\").val(moment(res." + st.Name.ToLower() + ").format('DD-MM-YYYY'));" + Environment.NewLine;
                    else
                        div += "\t\t\t\t\t\t\t $(\"#" + st.Name.ToLower() + "\").val(res." + st.Name.ToLower() + ");" + Environment.NewLine;
                }

            }
        }
        return div;
    }


    public string drawClearFormForJS(TableSchema table, bool includeprimarykey = true)
    {
        List<ColumnSchema> objColumnList = new List<ColumnSchema>();

        string div = string.Empty;

        foreach (ColumnSchema column in table.Columns)
        {
            if (!ShouldExcludeColumn(column.Name))
                objColumnList.Add(column);
        }

        int i = 0;
        if (objColumnList != null && objColumnList.Count > 0)
        {
            foreach (ColumnSchema st in objColumnList)
            {
                if ((!includeprimarykey) && (st.IsPrimaryKeyMember))
                    continue;
                else
                {
                    div += "\t\t\t\t\t\t\t $(\"#" + st.Name.ToLower() + "\").val('');" + Environment.NewLine;
                }

            }
        }
        return div;
    }

    public string drawHTMLForDataTable(TableSchema table)
    {
        List<ColumnSchema> objColumnList = new List<ColumnSchema>();
        string div = string.Empty;

        foreach (ColumnSchema column in table.Columns)
        {
            if (!ShouldExcludeColumn(column.Name))
                objColumnList.Add(column);
        }

        if (objColumnList != null && objColumnList.Count > 0)
        {
            foreach (ColumnSchema st in objColumnList)
            {
                if (st.IsPrimaryKeyMember)
                    div += "\t\t\t\t\t\t\t @*<th>@KAF.MsgContainer._" + table.Name.ToLower() + "." + st.Name.ToLower() + "</th>*@" + Environment.NewLine;
                else
                    div += "\t\t\t\t\t\t\t <th>@KAF.MsgContainer._" + table.Name.ToLower() + "." + st.Name.ToLower() + "</th>" + Environment.NewLine;
            }
            div = div.Remove(div.Length - 1);
        }

        return div;
    }
    public string drawHTMLForDataTableShort(TableSchema table)
    {
        List<ColumnSchema> objColumnList = new List<ColumnSchema>();
        string div = string.Empty;

        foreach (ColumnSchema column in table.Columns)
        {
            if (!ShouldExcludeColumn(column.Name))
                objColumnList.Add(column);
        }

        if (objColumnList != null && objColumnList.Count > 0)
        {
            foreach (ColumnSchema st in objColumnList)
            {
                if (st.IsPrimaryKeyMember)
                    continue;
                else if (st.IsForeignKeyMember)
                    continue;
                else
                {
                    if ((st.NativeType.ToUpper() == "VARCHAR") || (st.NativeType.ToUpper() == "NVARCHAR") || (st.NativeType.ToLower() == "uniqueidentifier") || (st.NativeType.ToUpper() == "NCHAR"))
                    {
                        div += "\t\t\t\t\t\t\t <th>@KAF.MsgContainer._" + table.Name.ToLower() + "." + st.Name.ToLower() + "</th>" + Environment.NewLine;
                        break;
                    }
                }
            }
            div = div.Remove(div.Length - 1);
        }

        return div;
    }
    public string drawHTMLForDataTableJS(TableSchema table)
    {
        List<ColumnSchema> objColumnList = new List<ColumnSchema>();
        string div = string.Empty;

        foreach (ColumnSchema column in table.Columns)
        {
            if (!ShouldExcludeColumn(column.Name))
                objColumnList.Add(column);
        }

        if (objColumnList != null && objColumnList.Count > 0)
        {
            foreach (ColumnSchema st in objColumnList)
            {
                if ((st.NativeType == "datetime") || (st.NativeType == "date"))
                {
                    div += "\t\t\t\t { \"data\": \"" + st.Name.ToLower() + "\", \"searchable\": true, \"sortable\": true, \"orderable\": true, " + Environment.NewLine;
                    div += "\t\t\t\t \"render\": function(data, type, full, meta) { return datetoStr(data); }  " + Environment.NewLine;
                    div += "\t\t\t\t }, " + Environment.NewLine;
                }
                else
                    div += "\t\t\t\t { \"data\": \"" + st.Name.ToLower() + "\", \"searchable\": true, \"sortable\": true, \"orderable\": true }," + Environment.NewLine;
            }
            div = div.Remove(div.Length - 1);
        }

        return div;
    }
    public string drawHTMLForDataTableJSShort(TableSchema table)
    {
        List<ColumnSchema> objColumnList = new List<ColumnSchema>();
        string div = string.Empty;

        foreach (ColumnSchema column in table.Columns)
        {
            if (!ShouldExcludeColumn(column.Name))
                objColumnList.Add(column);
        }

        if (objColumnList != null && objColumnList.Count > 0)
        {
            foreach (ColumnSchema st in objColumnList)
            {
                if (st.IsPrimaryKeyMember)
                    continue;
                else if (st.IsForeignKeyMember)
                    continue;
                else
                {
                    if ((st.NativeType.ToUpper() == "VARCHAR") || (st.NativeType.ToUpper() == "NVARCHAR") || (st.NativeType.ToLower() == "uniqueidentifier") || (st.NativeType.ToUpper() == "NCHAR"))
                    {
                        div += "\t\t\t\t { \"data\": \"" + st.Name.ToLower() + "\", \"searchable\": true, \"sortable\": true, \"orderable\": true }," + Environment.NewLine;
                        break;
                    }
                }
            }
            div = div.Remove(div.Length - 1);
        }

        return div;
    }

    public string DrawPrpLoadedDropDownCS(TableSchema table)
    {
        string div = string.Empty;

        foreach (ColumnSchema col in table.ForeignKeyColumns)
        {
            string connetionString = _strConnection;
            List<btentity> itemList = new List<btentity>();

            string sqlstring = "SELECT OBJECT_NAME (f.referenced_object_id) referenced_table_name, COL_NAME(fc.referenced_object_id, fc.referenced_column_id) referenced_column_name FROM sys.foreign_keys AS f INNER JOIN sys.foreign_key_columns AS fc ON f.object_id = fc.constraint_object_id ";
            sqlstring += " where OBJECT_NAME(f.parent_object_id)='" + table.Name + "' and COL_NAME(fc.parent_object_id, fc.parent_column_id)='" + col.Name + "'";

            using (SqlConnection connection = new SqlConnection(connetionString))
            using (SqlCommand command = new SqlCommand(sqlstring, connection))
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        itemList.Add(new btentity(reader));
                    }
                }
                connection.Close();
                command.Dispose();
            }


            string strfldname = getForeignKeyTableTextFeildToShow(itemList[0].referenced_table_name.ToLower());


            if (ShouldCacheTable(table.Name))
            {
                div += "\t\t\t\t\t List<" + itemList[0].referenced_table_name.ToLower() + "Entity> list" + itemList[0].referenced_table_name.ToLower() + " = KAF.FacadeCreatorObjects." + itemList[0].referenced_table_name.ToLower() + "FCC.GetFacadeCreate().GetAll(new " + itemList[0].referenced_table_name.ToLower() + "Entity { " + itemList[0].referenced_table_column_name.ToLower() + " = model." + col.Name.ToLower() + " }).ToList();" + Environment.NewLine;
                div += "\t\t\t\t\t var obj" + itemList[0].referenced_table_name.ToLower() + " = (from t in list" + itemList[0].referenced_table_name.ToLower() + "" + Environment.NewLine;
                div += "\t\t\t\t\t select new" + Environment.NewLine;
                div += "\t\t\t\t\t {" + Environment.NewLine;
                div += "\t\t\t\t\t\t\t\t comId = t." + itemList[0].referenced_table_column_name.ToLower() + " ," + Environment.NewLine;
                div += "\t\t\t\t\t\t\t\t comText = t." + strfldname.ToLower() + " " + Environment.NewLine;
                div += "\t\t\t\t\t  }).ToList();" + Environment.NewLine;
                div += "\t\t\t\t\t ViewBag.preloaded" + itemList[0].referenced_table_name + " = JsonConvert.SerializeObject(obj" + itemList[0].referenced_table_name.ToLower() + ");" + Environment.NewLine;
                div += "" + Environment.NewLine;
            }
            else
            {
                div += "\t\t\t\t\t List<" + itemList[0].referenced_table_name.ToLower() + "Entity> list" + itemList[0].referenced_table_name.ToLower() + " = KAF.FacadeCreatorObjects." + itemList[0].referenced_table_name.ToLower() + "FCC.GetFacadeCreate().GetAll(new " + itemList[0].referenced_table_name.ToLower() + "Entity { " + itemList[0].referenced_table_column_name.ToLower() + " = model." + col.Name.ToLower() + " }).ToList();" + Environment.NewLine;
                div += "\t\t\t\t\t var obj" + itemList[0].referenced_table_name.ToLower() + " = (from t in list" + itemList[0].referenced_table_name.ToLower() + "" + Environment.NewLine;
                div += "\t\t\t\t\t select new" + Environment.NewLine;
                div += "\t\t\t\t\t {" + Environment.NewLine;
                div += "\t\t\t\t\t\t\t\t Id = t." + itemList[0].referenced_table_column_name.ToLower() + " ," + Environment.NewLine;
                div += "\t\t\t\t\t\t\t\t Text = t." + strfldname.ToLower() + " " + Environment.NewLine;
                div += "\t\t\t\t\t  }).ToList();" + Environment.NewLine;
                div += "\t\t\t\t\t ViewBag.preloaded" + itemList[0].referenced_table_name + " = JsonConvert.SerializeObject(obj" + itemList[0].referenced_table_name.ToLower() + ");" + Environment.NewLine;
                div += "" + Environment.NewLine;
            }

        }

        return div;
    }

    private string getForeignKeyTableTextFeildToShow(string table)
    {
        string name = string.Empty;
        string connetionString = _strConnection;
        List<btentity> itemList = new List<btentity>();

        string sqlstring = "SELECT COLUMN_NAME as referenced_column_name, DATA_TYPE as referenced_table_name FROM [KAF_HR_V1.0].INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'" + table + "' and DATA_TYPE = 'nvarchar'";

        using (SqlConnection connection = new SqlConnection(connetionString))
        using (SqlCommand command = new SqlCommand(sqlstring, connection))
        {
            connection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    itemList.Add(new btentity(reader));
                }
            }
            connection.Close();
            command.Dispose();
        }

        if (itemList != null && itemList.Count > 0)
        {
            name = itemList[0].referenced_table_column_name;
        }

        return name;
    }

    public string drawHTML(TableSchema table, string readonlyYN)
    {
        List<ColumnSchema> objColumnList = new List<ColumnSchema>();
        string divRowStart = "\t\t\t\t\t <div class=\"row \">";
        string divColumnStart = "\t\t\t\t\t\t <div class=\"col-md-6\">";
        string divClose = "</div>";
        string div = string.Empty;

        foreach (ColumnSchema column in table.Columns)
        {
            if (!ShouldExcludeColumn(column.Name))
                objColumnList.Add(column);
        }

        if (objColumnList != null && objColumnList.Count > 0)
        {
            for (int i = 0; i < objColumnList.Count; i = i + 2)
            {
                div += divRowStart + Environment.NewLine;
                //div += divColumnStart + Environment.NewLine;
                var items = objColumnList.Skip(i).Take(2);

                foreach (ColumnSchema st in items)
                {
                    if (st.IsPrimaryKeyMember)
                        continue;
                    div += divColumnStart + Environment.NewLine;
                    div += "\t\t\t\t\t\t\t <div class=\"form-group\">" + Environment.NewLine; ;

                    if (st.IsForeignKeyMember)
                        div += drawForeignKeyHTML(st, table, readonlyYN);
                    else
                    {
                        if ((st.NativeType.ToUpper() == "VARCHAR") || (st.NativeType.ToUpper() == "NVARCHAR") || (st.NativeType.ToLower() == "uniqueidentifier") || (st.NativeType.ToUpper() == "NCHAR"))
                        {
                            div += drawTextFldHTML(st, table, readonlyYN);
                        }
                        else if ((st.NativeType == "int") || (st.NativeType == "bigint") || (st.NativeType == "decimal"))
                        {
                            div += drawNumericFldHTML(st, table, readonlyYN);
                        }
                        else if ((st.NativeType.ToUpper() == "NTEXT"))
                        {
                            div += drawNTextFldHTML(st, table, readonlyYN);
                        }
                        else if ((st.NativeType == "bit"))
                        {
                            div += drawBitFldHTML(st, table, readonlyYN);
                        }
                        else if ((st.NativeType == "datetime") || (st.NativeType == "date"))
                        {
                            div += drawDateFldHTML(st, table, readonlyYN);
                        }
                    }

                    div += "\t\t\t\t\t\t\t" + divClose + Environment.NewLine;
                    div += "\t\t\t\t\t\t\t" + divClose + Environment.NewLine;
                }
                div += "\t\t\t\t\t\t\t" + divClose + Environment.NewLine;
            }
        }

        return div;
    }

    public string WriteDataTableViewColumns(TableSchema table)
    {
        List<ColumnSchema> objColumnList = new List<ColumnSchema>();

        string div = string.Empty;

        foreach (ColumnSchema column in table.Columns)
        {
            if (!ShouldExcludeColumn(column.Name))
                objColumnList.Add(column);
        }

        if (objColumnList != null && objColumnList.Count > 0)
        {
            foreach (ColumnSchema st in objColumnList)
            {
                div += "\t\t\t\t\t\t\t\t\t t." + st.Name.ToLower() + "," + Environment.NewLine;
            }
            div = div.Remove(div.Length - 1);
        }

        return div;
    }
    public string WriteDataTableSortViewColumns(TableSchema table)
    {
        List<ColumnSchema> objColumnList = new List<ColumnSchema>();

        string div = string.Empty;

        foreach (ColumnSchema column in table.Columns)
        {
            if (!ShouldExcludeColumn(column.Name))
                objColumnList.Add(column);
        }

        int i = 0;
        if (objColumnList != null && objColumnList.Count > 0)
        {
            foreach (ColumnSchema st in objColumnList)
            {
                div += "\t\t\t\t\t case " + "\"" + i++ + "\":" + Environment.NewLine;
                div += "\t\t\t\t\t\t\t sortingVal = \"" + st.Name.ToLower() + "\" + \" \" + orderDir;" + Environment.NewLine;
                div += "\t\t\t\t\t\t\t break;" + Environment.NewLine;
            }
            div += "\t\t\t\t\t\t default:" + Environment.NewLine;
            div += "\t\t\t\t\t\t\t sortingVal = \"" + objColumnList[0].Name.ToLower() + "\" + \" \" + orderDir;" + Environment.NewLine;
            div += "\t\t\t\t\t\t\t break;" + Environment.NewLine;

        }

        return div;
    }

    public string WriteDataModalStateRemove(TableSchema table)
    {
        List<ColumnSchema> objColumnList = new List<ColumnSchema>();

        string div = string.Empty;
        div = "/*";

        foreach (ColumnSchema column in table.Columns)
        {
            if (!ShouldExcludeColumn(column.Name))
                objColumnList.Add(column);
        }

        int i = 0;
        if (objColumnList != null && objColumnList.Count > 0)
        {
            foreach (ColumnSchema st in objColumnList)
            {
                div += "\t\t\t\t ModelState.Remove(\"" + st.Name.ToLower().Trim() + "\");" + Environment.NewLine;
            }
        }
        div += "*/";
        return div;
    }
    public string WriteDataModalStateRemoveForDelete(TableSchema table)
    {
        List<ColumnSchema> objColumnList = new List<ColumnSchema>();

        string div = string.Empty;
        div = "";

        foreach (ColumnSchema column in table.Columns)
        {
            if (!ShouldExcludeColumn(column.Name))
                objColumnList.Add(column);
        }

        int i = 0;
        if (objColumnList != null && objColumnList.Count > 0)
        {
            foreach (ColumnSchema st in objColumnList)
            {
                if (st.IsPrimaryKeyMember)
                    div += "\t\t\t\t /* ModelState.Remove(\"" + st.Name.ToLower().Trim() + "\"); */" + Environment.NewLine;
                else
                    div += "\t\t\t\t ModelState.Remove(\"" + st.Name.ToLower().Trim() + "\");" + Environment.NewLine;
            }
        }
        div += "";
        return div;
    }

    public string drawForeignKeyHTML(ColumnSchema column, TableSchema table, string readonlyYes)
    {
        string div = string.Empty;
        string isReqBool = "false";
        string isReqText = " ";
        if (!column.AllowDBNull)
        {
            isReqBool = "true";
            isReqText = "required";
        }

        string referenced_table_name = string.Empty;
        referenced_table_name = GetTableNameByForeignKey(column.Name, table.Name);

        if (ShouldCacheTable(referenced_table_name))
        {
            div += "\t\t\t\t\t\t\t\t @Html.LabelFor(model => model." + column.Name.ToLower() + ",  htmlAttributes: new { @class = \"labelNormal   " + isReqText + " \" })" + Environment.NewLine;
            div += "\t\t\t\t\t\t\t\t @{Html.RenderAction(\"LoadComboBox\", \"DataCache\", new { EntityName = KAF.CustomHelper.HelperClasses.clsDataCache." + GetTableNameByForeignKey(column.Name, table.Name).ToLower() + "[0].ToString(), selectid = \"" + column.Name.ToLower() + "\", minimumInputLength = 0, delay = 250, preloaded = ViewBag.preloaded" + GetTableNameByForeignKey(column.Name, table.Name) + ", multiple = false, isReadOnly = " + readonlyYes + ", IsRequired = " + isReqBool + ", isStatic = false });}" + Environment.NewLine;
        }
        else
        {
            div += "\t\t\t\t\t\t\t\t @Html.LabelFor(model => model." + column.Name.ToLower() + ",  htmlAttributes: new { @class = \"labelNormal   " + isReqText + " \" })" + Environment.NewLine;
            div += "\t\t\t\t\t\t\t\t @{Html.RenderAction(\"Load" + GetTableNamesWithoutPrefix(GetTableNameByForeignKey(column.Name, table.Name)) + "Search\", \"Common\", new { area = \"\", selectid = \"" + column.Name.ToLower() + "\", minimumInputLength = 0, delay = 250, preloaded = ViewBag.pre" + GetTableNameByForeignKey(column.Name, table.Name) + ", multiple = false, isReadOnly = " + readonlyYes + ", IsRequired = " + isReqBool + " });}" + Environment.NewLine;
        }
        return div;
    }
    public string drawTextFldHTML(ColumnSchema column, TableSchema table, string readonlyYes)
    {
        string isReqBool = "false";
        string ReadonlyTag = "";

        if (readonlyYes == "true")
            ReadonlyTag = " @readonly = \"readonly\", ";


        string isReqText = "";
        if (!column.AllowDBNull)
        {
            isReqBool = "true";
            isReqText = "required";
        }
        string div = string.Empty;

        div += "\t\t\t\t\t\t\t\t @Html.LabelFor(model => model." + column.Name.ToLower() + ", htmlAttributes: new { @class = \"labelNormal " + isReqText + " \" })" + Environment.NewLine;
        div += "\t\t\t\t\t\t\t\t @Html.EditorFor(model => model." + column.Name.ToLower() + ", new { htmlAttributes = new {  " + ReadonlyTag + " @class = \" form-control\" } })" + Environment.NewLine;
        div += "\t\t\t\t\t\t\t\t @Html.ValidationMessageFor(model => model." + column.Name.ToLower() + ", \"\", new { @class = \"text-danger\" })" + Environment.NewLine;

        return div;
    }
    public string drawDateFldHTML(ColumnSchema column, TableSchema table, string readonlyYes)
    {
        string isReqBool = "false";
        string ReadonlyTag = "";

        if (readonlyYes == "true")
            ReadonlyTag = " @readonly = \"readonly\", ";

        string isReqText = "";
        if (!column.AllowDBNull)
        {
            isReqBool = "true";
            isReqText = "required";
        }
        string div = string.Empty;

        div += "\t\t\t\t\t\t\t @Html.LabelFor(model => model." + column.Name.ToLower() + ", htmlAttributes: new { @class = \"labelNormal  " + isReqText + " \" }) " + Environment.NewLine;
        div += "\t\t\t\t\t\t\t <div class='input-group date dateonly' id='' style=\"width: 100 %; \">" + Environment.NewLine;
        div += "\t\t\t\t\t\t\t @Html.EditorFor(model => model." + column.Name.ToLower() + ", new {  htmlAttributes = new { " + ReadonlyTag + " @Value = Model." + column.Name.ToLower() + " != null ? Convert.ToDateTime(Model." + column.Name.ToLower() + ").ToString(\"dd-MM-yyyy\") : null, @class = \"form-control\", @type = \"text\" } })" + Environment.NewLine;
        //div += "\t\t\t\t\t\t\t\t\t\t\t\t\t\t <span class=\"input-group-addon\">" + Environment.NewLine;
        //div += "\t\t\t\t\t\t\t\t\t\t\t\t\t\t <span class=\"glyphicon glyphicon-calendar\"></span>" + Environment.NewLine;
        //div += "\t\t\t\t\t\t\t\t\t\t\t\t\t\t </span>" + Environment.NewLine;
        div += "\t\t\t\t\t\t\t\t\t\t\t\t\t\t </div>" + Environment.NewLine;
        div += "\t\t\t\t\t\t\t @Html.ValidationMessageFor(m => m." + column.Name.ToLower() + ", \"\", new { @class = \"text-danger \" })" + Environment.NewLine;
        return div;
    }
    public string drawNTextFldHTML(ColumnSchema column, TableSchema table, string readonlyYes)
    {
        string div = string.Empty;

        div += "\t\t\t\t\t\t\t @Html.LabelFor(model => model." + column.Name.ToLower() + ", htmlAttributes: new { @class = \"labelNormal\" })" + Environment.NewLine; ;
        div += "\t\t\t\t\t\t\t @Html.EditorFor(model => model." + column.Name.ToLower() + ", new { htmlAttributes = new { @class = \"form-control\" } })" + Environment.NewLine; ;
        div += "\t\t\t\t\t\t\t @Html.ValidationMessageFor(model => model." + column.Name.ToLower() + ", \"\", new { @class = \"text-danger\" })" + Environment.NewLine; ;
        div += "\t\t\t\t\t\t\t\t\t\t\t\t\t\t <script>" + Environment.NewLine;
        div += "\t\t\t\t\t\t\t\t\t\t\t\t\t\t CKEDITOR.replace(\"" + column.Name.ToLower() + "\", {" + Environment.NewLine;
        div += "\t\t\t\t\t\t\t\t\t\t\t\t\t\t allowedContent: true, " + Environment.NewLine;
        div += "\t\t\t\t\t\t\t\t\t\t\t\t\t\t extraAllowedContent: 'div;span;ul;li;table;td;style;*[id];*(*);*{*}', " + Environment.NewLine;
        div += "\t\t\t\t\t\t\t\t\t\t\t\t\t\t toolbarCanCollapse: true, " + Environment.NewLine;
        div += "\t\t\t\t\t\t\t\t\t\t\t\t\t\t language: 'ar', " + Environment.NewLine;
        div += "\t\t\t\t\t\t\t\t\t\t\t\t\t\t extraPlugins: 'uploadimage,uploadwidget,image2,widget', " + Environment.NewLine;
        div += "\t\t\t\t\t\t\t\t\t\t\t\t\t\t height: 300, " + Environment.NewLine;
        div += "\t\t\t\t\t\t\t\t\t\t\t\t\t\t filebrowserBrowseUrl: '/" + GetTableNamesWithoutPrefix(table) + "/_" + GetTableNamesWithoutPrefix(table) + "ImageBrowser?type=Files&tk=' + GetUserToken(), " + Environment.NewLine;
        div += "\t\t\t\t\t\t\t\t\t\t\t\t\t\t filebrowserImageBrowseUrl: '/" + GetTableNamesWithoutPrefix(table) + "/_" + GetTableNamesWithoutPrefix(table) + "ImageBrowser?type=Images&tk=' + GetUserToken(), " + Environment.NewLine;
        div += "\t\t\t\t\t\t\t\t\t\t\t\t\t\t stylesSet: [ " + Environment.NewLine;
        div += "\t\t\t\t\t\t\t\t\t\t\t\t\t\t { name: 'Narrow image', type: 'widget', widget: 'image', attributes: { 'class': 'image-narrow' } }, " + Environment.NewLine;
        div += "{ name: 'Wide image', type: 'widget', widget: 'image', attributes: { 'class': 'image-wide' } } " + Environment.NewLine;
        div += "\t\t\t\t\t\t\t\t\t\t\t\t\t\t ], " + Environment.NewLine;
        div += "\t\t\t\t\t\t\t\t\t\t\t\t\t\t contentsCss: [CKEDITOR.basePath + 'contents.css', 'https://sdk.ckeditor.com/samples/assets/css/widgetstyles.css'], " + Environment.NewLine;
        div += "\t\t\t\t\t\t\t\t\t\t\t\t\t\t image2_alignClasses: ['image-align-left', 'image-align-center', 'image-align-right'], " + Environment.NewLine;
        div += "\t\t\t\t\t\t\t\t\t\t\t\t\t\t image2_disableResizer: true " + Environment.NewLine;
        div += "\t\t\t\t\t\t\t\t\t\t\t\t\t\t }); " + Environment.NewLine;
        div += "\t\t\t\t\t\t\t\t\t\t\t\t\t\t </script>" + Environment.NewLine;

        return div;
    }
    public string drawNumericFldHTML(ColumnSchema column, TableSchema table, string readonlyYes)
    {
        string isReqBool = "false";
        string ReadonlyTag = "";
        if (readonlyYes == "true")
            ReadonlyTag = " @readonly = \"readonly\", ";

        string isReqText = "";
        if (!column.AllowDBNull)
        {
            isReqBool = "true";
            isReqText = "required";
        }
        string div = string.Empty;
        div += "\t\t\t\t\t\t\t @Html.LabelFor(model => model." + column.Name.ToLower() + ", htmlAttributes: new { @class = \"labelNormal " + isReqText + " \" })" + Environment.NewLine;
        div += "\t\t\t\t\t\t\t @Html.EditorFor(model => model." + column.Name.ToLower() + ", new { htmlAttributes = new { " + ReadonlyTag + " @class = \"form-control\" } })" + Environment.NewLine;
        div += "\t\t\t\t\t\t\t @Html.ValidationMessageFor(model => model." + column.Name.ToLower() + ", \"\", new { @class = \"text-danger\" })" + Environment.NewLine;
        return div;
    }
    public string drawBitFldHTML(ColumnSchema column, TableSchema table, string readonlyYes)
    {
        string isReqBool = "false"; string ReadonlyTag = "";
        if (readonlyYes == "true")
            ReadonlyTag = " @readonly = \"readonly\", ";
        string isReqText = "";
        if (!column.AllowDBNull)
        {
            isReqBool = "true";
            isReqText = "required";
        }
        string div = string.Empty;
        div += "\t\t\t\t\t\t\t @Html.LabelFor(model => model." + column.Name.ToLower() + ", htmlAttributes: new { @class = \"labelNormal " + isReqText + " \" })" + Environment.NewLine;
        div += "\t\t\t\t\t\t\t @Html.EditorFor(model => model." + column.Name.ToLower() + ", new { htmlAttributes = new { " + ReadonlyTag + " @class = \"form-control\" } })" + Environment.NewLine;
        div += "\t\t\t\t\t\t\t @Html.ValidationMessageFor(model => model." + column.Name.ToLower() + ", \"\", new { @class = \"text-danger\" })" + Environment.NewLine;
        return div;
    }

    public bool ShouldExcludeColumn(string columnName)
    {
        bool flg = false;
        #region Excl Columns
        List<string> ExcludedColumnsName = new List<string>();
        ExcludedColumnsName.Add("formid");
        ExcludedColumnsName.Add("ts");
        ExcludedColumnsName.Add("createdby");
        ExcludedColumnsName.Add("createdbyusername");
        ExcludedColumnsName.Add("createddate");
        ExcludedColumnsName.Add("updatedby");
        ExcludedColumnsName.Add("updatedbyusername");
        ExcludedColumnsName.Add("updateddate");
        ExcludedColumnsName.Add("ex_date1");
        ExcludedColumnsName.Add("ex_date2");
        ExcludedColumnsName.Add("ex_nvarchar1");
        ExcludedColumnsName.Add("ex_nvarchar2");
        ExcludedColumnsName.Add("ex_bigint1");
        ExcludedColumnsName.Add("ex_bigint2");
        ExcludedColumnsName.Add("ex_decimal1");
        ExcludedColumnsName.Add("ex_decimal2");
        ExcludedColumnsName.Add("transid");
        ExcludedColumnsName.Add("userentitykey");
        ExcludedColumnsName.Add("userorganizationkey");
        ExcludedColumnsName.Add("ipaddress");
        ExcludedColumnsName.Add("eventguid");
        ExcludedColumnsName.Add("eventtags");
        ExcludedColumnsName.Add("vulnarebilitytags");
        ExcludedColumnsName.Add("alerttags");
        ExcludedColumnsName.Add("cwetags");
        ExcludedColumnsName.Add("capectags");
        ExcludedColumnsName.Add("isreviewed");
        ExcludedColumnsName.Add("reviewedby");
        ExcludedColumnsName.Add("reviewedbyusername");
        ExcludedColumnsName.Add("reviewedcomment");
        ExcludedColumnsName.Add("revieweddate");
        ExcludedColumnsName.Add("ispublished");
        ExcludedColumnsName.Add("publishedby");
        ExcludedColumnsName.Add("publishedbyusername");
        ExcludedColumnsName.Add("publishedcomment");
        ExcludedColumnsName.Add("publisheddate");
        ExcludedColumnsName.Add("isarchived");
        ExcludedColumnsName.Add("archivedate");
        ExcludedColumnsName.Add("archivedby");
        ExcludedColumnsName.Add("archivedbyusername");
        ExcludedColumnsName.Add("publisheddate");
        ExcludedColumnsName.Add("archivedcomment");
        #endregion Excl Columns

        if (ExcludedColumnsName.Exists(p => p.ToLower() == columnName.ToLower()))
            flg = true;
        else
            flg = false;

        return flg;
    }


    public string GetTableNamesWithPrefix(TableSchema table)
    {
        string result = "";
        foreach (char c in table.Name)
        {
            if ('_' == c)
                continue;
            else
                result += c;
        }
        return result;
    }
    public string getPrimaryKeyColumnName(TableSchema table)
    {
        string PrimaryKeyColumnName = string.Empty;

        PrimaryKeyColumnName = table.PrimaryKey.MemberColumns[0].Name.ToLower();

        return PrimaryKeyColumnName;
    }
    public string GetClassName(TableSchema table)
    {
        string ClassName = table.Name.Substring(0, 1).ToLower() + table.Name.Substring(1, table.Name.Length - 1);
        if (table.Name.EndsWith("s"))
        {
            return ClassName.ToLower(); //table.Name.Substring(0, table.Name.Length - 1);
        }
        else
        {

            return ClassName.ToLower();
        }
    }

    public string GetTableNamesWithoutPrefix(TableSchema table)
    {
        return table.Name.Split('_')[1];
    }
    public string GetTableNamesWithoutPrefix(string tablename)
    {
        return tablename.Split('_')[1];
    }
    public string GetTableNameByForeignKey(string columnName, string tableName)
    {
        string str = string.Empty;
        string connetionString = _strConnection;
        List<btentity> itemList = new List<btentity>();

        string sqlstring = "SELECT OBJECT_NAME (f.referenced_object_id) referenced_table_name, COL_NAME(fc.referenced_object_id, fc.referenced_column_id) referenced_column_name FROM sys.foreign_keys AS f INNER JOIN sys.foreign_key_columns AS fc ON f.object_id = fc.constraint_object_id ";
        sqlstring += " where OBJECT_NAME(f.parent_object_id)='" + tableName + "' and COL_NAME(fc.parent_object_id, fc.parent_column_id)='" + columnName + "'";
        try
        {
            using (SqlConnection connection = new SqlConnection(connetionString))
            using (SqlCommand command = new SqlCommand(sqlstring, connection))
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        itemList.Add(new btentity(reader));
                    }
                }
                connection.Close();
                command.Dispose();
            }
        }
        catch (Exception ex)
        {
            str = ex.Message.ToString();
        }


        if (itemList != null && itemList.Count > 0)
            str = itemList[0].referenced_table_name;
        else
            str = "None";

        return str;
    }


    public string PropertyName(ColumnSchema column)
    {
        string propertyName = PascalCase(column.Name);
        if (propertyName == EntityName(column.Table)) // .NET does not allow class to have property of same name
            propertyName += "1"; // Append 1 as this is what LinqToSql does
        return propertyName;
    }

    public string ParameterName(ColumnSchema column)
    {
        string parameterName = PascalCase(column.Name);
        return Char.ToLower(parameterName[0]) + parameterName.Substring(1);
    }

    public string TableName(TableSchema table)
    {
        return (table.Name.EndsWith("s")) ? PascalCase(table.Name) : PascalCase(table.Name) + "s";
    }

    public string EntityName(TableSchema table)
    {
        if (table.Name.EndsWith("ies"))
            return PascalCase(table.Name.Substring(0, table.Name.Length - 3)) + "y";

        if (table.Name.EndsWith("s"))
            return PascalCase(table.Name.Substring(0, table.Name.Length - 1));

        return table.Name.Substring(0, table.Name.Length - 0);//PascalCase(table.Name);
    }

    public string DatabaseName(DatabaseSchema database)
    {
        return PascalCase(database.Name);
    }

    private string PascalCase(string text)
    {
        string newText = "";
        bool nextUpper = true;
        for (int i = 0; i < text.Length; i++)
            switch (text[i])
            {
                case '_':
                case '-':
                case ' ':
                    {
                        nextUpper = true;
                        break;
                    }
                default:
                    {
                        if (nextUpper)
                            newText += char.ToUpper(text[i]);
                        else
                            newText += text[i];
                        nextUpper = false;
                        break;
                    }
            }
        return newText;
    }

    public string CurrentUserName()
    {
        string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString();
        return (userName.IndexOf("\\") > 0) ? userName.Remove(0, userName.IndexOf("\\") + 1) : userName;
    }

    #endregion

    #region Attribute generation

    public string AttributeColumnDbType(ColumnSchema column)
    {
        string columnDbType = column.NativeType.ToString();
        if (column.NativeType.Contains("char"))
            columnDbType += String.Format("({0})", column.Size);
        if (!column.AllowDBNull)
            columnDbType += " NOT NULL";
        if ((bool)column.ExtendedProperties["CS_IsIdentity"].Value)
            columnDbType += " IDENTITY";
        return columnDbType;
    }

    public string AttributeColumnList(MemberColumnSchemaCollection columns)
    {
        List<string> list = new List<string>();
        foreach (ColumnSchema column in columns)
            list.Add(column.Name);
        return String.Join(", ", list.ToArray());
    }

    #endregion

    #region .NET mapping

    public string MethodParametersDefinition(ColumnSchemaCollection columns)
    {
        List<String> parameters = new List<String>();
        foreach (ColumnSchema column in columns)
            parameters.Add(SystemType(column) + " " + ParameterName(column));
        return String.Join(", ", parameters.ToArray());
    }

    public string MethodArguments(ColumnSchemaCollection columns)
    {
        List<String> parameters = new List<String>();
        foreach (ColumnSchema column in columns)
            if ((column.AllowDBNull) && (column.SystemType.ToString() != "System.String"))
                parameters.Add(PropertyName(column) + ".Value");
            else
                parameters.Add(PropertyName(column));
        return String.Join(", ", parameters.ToArray());
    }

    public string NullableSystemType(ColumnSchema column)
    {
        string systemType = SystemType(column);
        if ((!column.AllowDBNull) || (systemType == "String") || (systemType == "Object"))
            return systemType;
        else
            return "global::System.Nullable<" + systemType + ">";
    }

    public string SystemType(ColumnSchema column)
    {
        return column.SystemType.ToString().Replace("System.", "global::System.");
    }


    public bool ShouldCacheTable(string tablename)
    {
        bool flg = false;
        #region Redis Cached  tablename
        List<string> ExcludedColumnsName = new List<string>();
        ExcludedColumnsName.Add("owin_role");
        ExcludedColumnsName.Add("owin_formaction");
        ExcludedColumnsName.Add("owin_forminfo");
        ExcludedColumnsName.Add("gen_acrgrade");
        ExcludedColumnsName.Add("gen_acrgradedescription");
        ExcludedColumnsName.Add("gen_birthdoctype");
        ExcludedColumnsName.Add("gen_bloodgroup");
        ExcludedColumnsName.Add("gen_branch");
        ExcludedColumnsName.Add("gen_certificate");
        ExcludedColumnsName.Add("gen_certificatelevel");
        ExcludedColumnsName.Add("gen_certificateprof");
        ExcludedColumnsName.Add("gen_certificatetype");
        ExcludedColumnsName.Add("gen_contracttype");
        ExcludedColumnsName.Add("gen_course");
        ExcludedColumnsName.Add("gen_coursegrade");
        ExcludedColumnsName.Add("gen_coursegroup");
        ExcludedColumnsName.Add("gen_coursestatus");
        ExcludedColumnsName.Add("gen_delayrequestlevel");
        ExcludedColumnsName.Add("gen_delayrequesttype");
        ExcludedColumnsName.Add("gen_educationtype");
        ExcludedColumnsName.Add("gen_edugrade");
        ExcludedColumnsName.Add("gen_employmenttype");
        ExcludedColumnsName.Add("gen_fatherstatus");
        ExcludedColumnsName.Add("gen_filetype");
        ExcludedColumnsName.Add("gen_freedomfighttype");
        ExcludedColumnsName.Add("gen_gender");
        ExcludedColumnsName.Add("gen_govoffice");
        ExcludedColumnsName.Add("gen_identificationcolor");
        ExcludedColumnsName.Add("gen_institute");
        ExcludedColumnsName.Add("gen_institutetype");
        ExcludedColumnsName.Add("gen_interviewcommdesc");
        ExcludedColumnsName.Add("gen_issuetype");
        ExcludedColumnsName.Add("gen_jobdegree");
        ExcludedColumnsName.Add("gen_jobpenalties");
        ExcludedColumnsName.Add("gen_kuwaiticlass");
        ExcludedColumnsName.Add("gen_language");
        ExcludedColumnsName.Add("gen_languageproficiency");
        ExcludedColumnsName.Add("gen_laststatus");
        ExcludedColumnsName.Add("gen_maritalstatus");
        ExcludedColumnsName.Add("gen_medicalcause");
        ExcludedColumnsName.Add("gen_medicallaststatus");
        ExcludedColumnsName.Add("gen_medicalresultgrade");
        ExcludedColumnsName.Add("gen_millcoursetype");
        ExcludedColumnsName.Add("gen_movementtype");
        ExcludedColumnsName.Add("gen_nationalityclassification");
        ExcludedColumnsName.Add("gen_nationalitydegree");
        ExcludedColumnsName.Add("gen_nationalityproofdocumenttype");
        ExcludedColumnsName.Add("gen_nationaltype");
        ExcludedColumnsName.Add("gen_officertype");
        ExcludedColumnsName.Add("gen_penaltytype");
        ExcludedColumnsName.Add("gen_permissiontype");
        ExcludedColumnsName.Add("gen_promotiontype");
        ExcludedColumnsName.Add("gen_rank");
        ExcludedColumnsName.Add("gen_rankjoinlist");
        ExcludedColumnsName.Add("gen_ranktype");
        ExcludedColumnsName.Add("gen_refusereason");
        ExcludedColumnsName.Add("gen_religion");
        ExcludedColumnsName.Add("gen_relationship");
        ExcludedColumnsName.Add("gen_reportlist");
        ExcludedColumnsName.Add("gen_reservicecause");
        ExcludedColumnsName.Add("gen_retirecause");
        ExcludedColumnsName.Add("gen_servicestatus");
        ExcludedColumnsName.Add("gen_socialstatus");
        ExcludedColumnsName.Add("gen_trailtype");
        ExcludedColumnsName.Add("gen_trainingcentre");
        ExcludedColumnsName.Add("gen_vacationdeductionreason");
        ExcludedColumnsName.Add("gen_vacationtype");
        ExcludedColumnsName.Add("stp_color");
        ExcludedColumnsName.Add("workflow_colorcode");
        ExcludedColumnsName.Add("workflow_emailtemplets");
        ExcludedColumnsName.Add("workflow_processinfo");
        ExcludedColumnsName.Add("workflow_processlevel");
        ExcludedColumnsName.Add("workflow_processstatus");
        ExcludedColumnsName.Add("workflow_smstemplets");
        ExcludedColumnsName.Add("workflow_templets");

        #endregion Excl Columns

        if (ExcludedColumnsName.Exists(p => p.ToLower() == tablename.ToLower()))
            flg = true;
        else
            flg = false;

        return flg;
    }

    #endregion
}