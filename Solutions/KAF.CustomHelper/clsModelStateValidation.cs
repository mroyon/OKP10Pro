using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KAF.CustomHelper.HelperClasses
{
    public class clsModelStateValidation
    {
        public string GetModelStateValidate(System.Web.Mvc.ModelStateDictionary ModelState)
        {
            string str = string.Empty;
            try
            {
                foreach (var item in ModelState)
                {
                    foreach (var error in item.Value.Errors)
                    {
                        str += error.ErrorMessage  + "<br/>";
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return str;
        }


    }
}