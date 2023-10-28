using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KAF.CustomHelper.HelperClasses
{
    public class clsRoleBasedUserControl
    {
        public int User_Id { get; set; }
        public bool IsSysAdmin { get; set; }
        public string Username { get; set; }
        //private List<UserRole> Roles = new List<UserRole>();


    }
}