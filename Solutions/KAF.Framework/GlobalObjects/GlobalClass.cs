using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Data;
using System.Threading;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.WebFramework
{

    public class GlobalClass
    {

        public static void SetSessionName(string sessionName)
        {
            //_useraccprofile_ShortEntity = sessionName;
        }

        private const string _KAF_GetUserInfoByCredentialEntity = "_KAF_GetUserInfoByCredentialEntity";
        public static KAF_GetUserInfoByCredentialEntity useraccprofileEntity
        {
            get
            {
                if (HttpContext.Current.Session[GlobalClass._KAF_GetUserInfoByCredentialEntity] == null)
                { return null; }
                else
                { return (KAF_GetUserInfoByCredentialEntity)HttpContext.Current.Session[GlobalClass._KAF_GetUserInfoByCredentialEntity]; }
            }
            set
            { HttpContext.Current.Session[GlobalClass._KAF_GetUserInfoByCredentialEntity] = value; }
        }

        private static Thread _executor;
        public static Thread Executor
        {
            get { return GlobalClass._executor; }
            set { GlobalClass._executor = value; }
        }


        private const string  _longVal1 = "longVal1";
        public static long? longVal1
        {
            get
            {
                if (HttpContext.Current.Session[_longVal1] == null)
                { return null; }
                else
                { return long.Parse(HttpContext.Current.Session[_longVal1].ToString()); }
            }
            set
            { HttpContext.Current.Session[_longVal1] = value; }
        }

        private const string _menuCache = "menuCache";
        public static List<KAF_GetMenuHierarchyEntity> menuCache
        {
            get
            {
                if (HttpContext.Current.Session[_menuCache] == null)
                { return null; }
                else
                { return (List<KAF_GetMenuHierarchyEntity>)HttpContext.Current.Session[_menuCache]; }
            }
            set
            { HttpContext.Current.Session[_menuCache] = value; }
        }

        private const string _formCache = "formCache";
        public static List<KAF_LoadMenuByUserIDEntity> formCache
        {
            get
            {
                if (HttpContext.Current.Session[_formCache] == null)
                { return null; }
                else
                { return (List<KAF_LoadMenuByUserIDEntity>)HttpContext.Current.Session[_formCache]; }
            }
            set
            { HttpContext.Current.Session[_formCache] = value; }
        }

       


        

        private const string  _CultureInfo = "CultureInfo";
        public static string CultureInfo
        {
            get
            {
                if (HttpContext.Current.Session[_CultureInfo] == null)
                {
                    //return null;
                    HttpContext.Current.Session[_CultureInfo] = "ar-KW";
                    return HttpContext.Current.Session[_CultureInfo].ToString();
                }
                else
                { return HttpContext.Current.Session[_CultureInfo].ToString(); }
            }
            set
            { HttpContext.Current.Session[_CultureInfo] = value; }
        }

      

        private const string  _CurrentYear = "CurrentYear";
        public static long? CurrentYear
        {
            get
            {
                if (HttpContext.Current.Session[_CurrentYear] == null)
                { return null; }
                else
                { return long.Parse(HttpContext.Current.Session[_CurrentYear].ToString()); }
            }
            set
            { HttpContext.Current.Session[_CurrentYear] = value; }
        }


    }
}
