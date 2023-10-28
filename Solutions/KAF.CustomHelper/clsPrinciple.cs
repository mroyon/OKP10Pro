using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace KAF.CustomHelper.HelperClasses
{
    public class clsPrinciple : ClaimsPrincipal
    {
        public clsPrinciple(clsIdentity identity)
            : base(identity)
        {

        }

        public clsPrinciple(ClaimsPrincipal claimsPrincipal)
            : base(claimsPrincipal)
        {

        }
    }
}