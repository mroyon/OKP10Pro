using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{
    [Serializable]
    [DataContract(Name = "KAFGenericComboEntity", Namespace = "http://www.KAF.com/types")]
    public partial class KAFGenericComboEntity
    {
        #region Properties

        protected long _comId;
        protected string _comText;
        protected string _comText2;
        protected string _comText3;


        [DataMember]
        public long comId
        {
            get { return _comId; }
            set { _comId = value;  }
        }

        [DataMember]
        public string comText
        {
            get { return _comText; }
            set { _comText = value; }
        }
        [DataMember]
        public string comText2
        {
            get { return _comText2; }
            set { _comText2 = value; }
        }
        [DataMember]
        public string comText3
        {
            get { return _comText3; }
            set { _comText3 = value; }
        }

        #endregion

        #region Constructor

        public KAFGenericComboEntity() : base()
        {
        }

      

       
        #endregion
    }
}
