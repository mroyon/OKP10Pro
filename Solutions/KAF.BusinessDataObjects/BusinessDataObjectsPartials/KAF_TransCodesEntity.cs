using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{


    /// <summary>
    /// This object represents the properties and methods of a KAF_TransCodesEntity.
    /// </summary>
    [Serializable]
    [DataContract(Name = "KAF_TransCodesEntity", Namespace = "http://www.KAF.com/types")]
    public class KAF_TransCodesEntity : BaseEntity
    {

        public KAF_TransCodesEntity()
        {
        }


     
        protected stp_organizationEntity _Stp_Organization;
        [DataMember]
        public stp_organizationEntity Stp_Organization
        {
            get { return _Stp_Organization; }
            set { _Stp_Organization = value; }
        }

    }

    


}
