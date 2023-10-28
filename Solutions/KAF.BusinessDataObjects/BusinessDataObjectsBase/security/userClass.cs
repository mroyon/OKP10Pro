using System;
using System.Runtime.Serialization;
using System.Data;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using System.ComponentModel.DataAnnotations;

namespace KAF.BusinessDataObjects.BusinessDataObjectsBase.security
{
    [Serializable]
    [DataContract(Name = "owin_userEntity", Namespace = "http://www.KAF.com/types")]
    public class userEmtity
    {
        protected Guid? _userid;
        protected long? _masteruserid;
        protected string _roleid;
        protected string _username;
        protected string _emailaddress;
        protected string _loweredusername;



    }
}
