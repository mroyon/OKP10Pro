using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace KAF.BusinessDataObjects
{
    [Serializable()]
    [DataContract(Name = "TransMessegeEntity", Namespace = "http://www.KAF.com/types")]
    public class TransMessegeEntity : ICloneable
    {
        [DataContract]
        public enum eMessageType
        {
            [EnumMember]
            Info = 0,

            [EnumMember]
            Error = 1,

            [EnumMember]
            Warning = 2,

            [EnumMember]
            Undefined = 3,

            [EnumMember]
            SaveSuccess = 4,

            [EnumMember]
            SaveFail = 5,

            [EnumMember]
            UpdateSuccess = 6,

            [EnumMember]
            UpdateFail = 7,

            [EnumMember]
            DeleteSuccess = 8,

            [EnumMember]
            DeleteFail = 9,
        }

        private eMessageType cMessageType = eMessageType.Info;

        [DataMember]
        public eMessageType MessageType
        {
            get { return cMessageType; }
            set
            {
                cMessageType = value;
                OnChnaged();
            }
        }

        [DataMember]
        public string MessegeTypeName
        {
            get;
            set;
        }

        [DataMember]
        public string Messege
        {
            get;
            set;
        }

        [DataMember]
        public long ReturnCode
        {
            get;
            set;
        }

        [DataMember]
        public long ReturnKey
        {
            get;
            set;
        }

        protected void OnChnaged()
        {
            if (this.cMessageType == eMessageType.Info)
            {
                this.MessegeTypeName = "Information";
            }
            else if (this.cMessageType == eMessageType.Error)
            {
                this.MessegeTypeName = "Error";
            }
            else if (this.cMessageType == eMessageType.Warning)
            {
                this.MessegeTypeName = "Warning";
            }
            else if (this.cMessageType == eMessageType.Undefined)
            {
                this.MessegeTypeName = "Undefined";
            }
            else if (this.cMessageType == eMessageType.SaveSuccess)
            {
                this.MessegeTypeName = "Save Success";
                this.Messege = "Data saved successfully.";
            }
            else if (this.cMessageType == eMessageType.SaveFail)
            {
                this.MessegeTypeName = "Save Failed";
                this.Messege = "Unable to save data.";
            }
            else if (this.cMessageType == eMessageType.UpdateSuccess)
            {
                this.MessegeTypeName = "Update Success";
                this.Messege = "Data Update successfully.";
            }
            else if (this.cMessageType == eMessageType.UpdateFail)
            {
                this.MessegeTypeName = "Update Failed";
                this.Messege = "Unable to update data.";
            }
            else if (this.cMessageType == eMessageType.DeleteSuccess)
            {
                this.MessegeTypeName = "Delete Success";
                this.Messege = "Data deleted successfully.";
            }
            else if (this.cMessageType == eMessageType.DeleteFail)
            {
                this.MessegeTypeName = "Delete Failed";
                this.Messege = "Unable to deleted data.";
            }
        }

        object ICloneable.Clone()
        {
            return Clone();
        }

        public virtual TransMessegeEntity Clone()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                (new BinaryFormatter()).Serialize(ms, this);

                ms.Seek(0, SeekOrigin.Begin);

                return (new BinaryFormatter()).Deserialize(ms) as TransMessegeEntity;
            }
        }
    }
}