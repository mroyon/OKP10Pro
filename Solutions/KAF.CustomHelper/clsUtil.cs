
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using KAF.WebFramework;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace KAF.CustomHelper.HelperClasses
{


    public static class clsUtil
    {

        

        public enum FolderType
        {
            Task = 1,
            Correspondance = 2
        }
        public static string GetPriorityStr(Int64 priyorityid)
        {
            string retstr = "";

            if (priyorityid == 1)
                retstr = "Low";
            if (priyorityid == 2)
                retstr = "Normal";
            if (priyorityid == 3)
                retstr = "High";
            if (priyorityid == 4)
                retstr = "URGENT";

            return retstr;
        }

        public static string GetFolderDirectory(Int64 foldertype)
        {
            string retstr = "";

            if (foldertype == 1)
                retstr = "Tasks";
            if (foldertype == 2)
                retstr = "Correspondance";

            return retstr;
        }

        public static string GetUserTypeStr(Int64 usertypeid)
        {
            string retstr = "";

            if (usertypeid == 1)
                retstr = "Approval User";
            if (usertypeid == 2)
                retstr = "CC User";
            if (usertypeid == 3)
                retstr = "Both";


            return retstr;
        }


        public static string GetFormDataValue(string inputstr, string key)
        {
            var retstr = "";
            try
            {
                var objinput = JsonConvert.DeserializeObject(inputstr);

                JObject json = JObject.Parse(objinput.ToString());

                if (objinput != null)
                {
                    retstr = json.GetValue(key).ToString();
                }

                return retstr;
            }
            catch (Exception es)
            {
                return "";
            }
        }



        public static List<KAFParamsListGeneric> ToSelectList<T>(Type type)
        {
            List<KAFParamsListGeneric> obj = new List<KAFParamsListGeneric>();
            foreach (var enumName in Enum.GetNames(type))
            {
                var idValue = ((int)Enum.Parse(type, enumName, true)).ToString();
                var displayValue = enumName;

                // get the corresponding enum field using reflection
                var field = type.GetField(enumName);
                var display = ((System.ComponentModel.DataAnnotations.DisplayAttribute[])field.GetCustomAttributes(typeof(System.ComponentModel.DataAnnotations.DisplayAttribute), false)).FirstOrDefault();
                if (display != null)
                {
                    displayValue = display.Name;
                }
                obj.Add(new KAFParamsListGeneric()
                {
                    paramname = displayValue,
                    paramvalue = idValue
                });

            }

            //ListItem items = type.GetEnumNames().Select(x => 
            //type.GetMember(x)[0].GetCustomAttributes(typeof(DescriptionAttribute), false)).
            //SelectMany(x =>x.Select(y => new ListItem(((DescriptionAttribute)y).Description))).ToList();

            return obj;
        }

        public static string GetDisplayName(long? value, Type type)
        {
            string displayValue = "";
            try
            {
                foreach (var enumName in Enum.GetNames(type))
                {
                    if (((int)Enum.Parse(type, enumName, true)) == value)
                    {
                        var field = type.GetField(enumName);
                        var display = ((System.ComponentModel.DataAnnotations.DisplayAttribute[])field.GetCustomAttributes(typeof(System.ComponentModel.DataAnnotations.DisplayAttribute), false)).FirstOrDefault();
                        if (display != null)
                        {
                            displayValue = display.Name;
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return displayValue;
        }
    }
}