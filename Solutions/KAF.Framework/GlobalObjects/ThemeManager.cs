using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections;
using System.Collections.Generic;
using System.IO;


namespace KAF.WebFramework.GlobalObjects
{
    public class ThemeManager
    {
        #region Theme-Related Method

        /// <summary>   Gets the themes. </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="GetThemes" type="List<Theme>">   GetThemes. </method>
        /// <returns>   The themes. </returns>

        public static List<Theme> GetThemes()
        {
            DirectoryInfo dInfo = new DirectoryInfo(System.Configuration.ConfigurationManager.AppSettings["ThemeDirectory"].ToString());
            DirectoryInfo[] dArrInfo = dInfo.GetDirectories();
            List<Theme> list = new List<Theme>();
            foreach (DirectoryInfo sDirectory in dArrInfo)
            {
                Theme temp = new Theme(sDirectory.Name);
                list.Add(temp);
            }
            return list;
        }

        public string GetTest()
        {
            string nm= "3";
            return nm;
        }
        #endregion
    }
}