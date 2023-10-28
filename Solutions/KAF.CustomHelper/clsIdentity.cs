using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace KAF.CustomHelper.HelperClasses
{
    public class clsIdentity : ClaimsIdentity
    {
        public const string RolesClaimType = "http://{}/CuttingEdge.Security.Role";
        public const string GroupClaimType = "http://{}/CuttingEdge.Security.Group";
        public const string IPClaimType = "http://{}/CuttingEdge.Security.IP";
        public const string IdClaimType = "http://{}/CuttingEdge.Security.Id";

        public clsIdentity(IEnumerable<Claim> claims, string authenticationType)
            : base(claims, authenticationType: authenticationType)
        {
            AddClaims(from @group in claims where @group.Type == GroupClaimType select @group);
            AddClaims(from role in claims where role.Type == RoleClaimType select role);
            AddClaims(from id in claims where id.Type == IdClaimType select id);
            AddClaims(from ip in claims where ip.Type == IPClaimType select ip);
        }
       

        public IEnumerable<string> Roles
        {
            get
            {
                return from claim in FindAll(RolesClaimType) select claim.Value;
            }
        }

        public IEnumerable<string> Groups { get { return from claim in FindAll(GroupClaimType) select claim.Value; } }

        public int Id { get { return Convert.ToInt32(FindFirst(IdClaimType).Value); } }
        public string IP { get { return FindFirst(IPClaimType).Value; } }

    }
}