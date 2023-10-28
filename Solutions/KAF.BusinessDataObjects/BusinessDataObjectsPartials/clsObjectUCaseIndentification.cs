using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{
    #region clsObjectUCaseIndentification
    /// <summary>
    /// This object represents the properties and methods of a GetPublicMenuParam.
    /// </summary>
    [Serializable]
    [DataContract(Name = "clsObjectUCaseIndentification", Namespace = "http://www.KAF.com/types")]
    public class clsObjectUCaseIndentification
    {
        [DataMember]
        public Guid? _userid { get; set; }

        [DataMember]
        public string _stkn { get; set; }

        [DataMember]
        public string _emailaddress { get; set; }

        [DataMember]
        public string _username { get; set; }

        [DataMember]
        public DateTime? _logdate { get; set; }

        [DataMember]
        public string _ipaddress { get; set; }
    }

    #endregion
}
