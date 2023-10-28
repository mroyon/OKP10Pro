using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Data;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    public partial class gen_govcityEntity
    {
        protected string _parentgovcity;
        protected string _country;
        public bool isSearch { get; set; }
        [DataMember]
        public String parentgovcity
        {
            get { return _parentgovcity; }
            set { _parentgovcity = value; }
        }

        [DataMember]
        public String country
        {
            get { return _country; }
            set { _country = value; }
        }
    }
}
