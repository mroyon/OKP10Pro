using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    public partial class hr_personalinfoEntity 
    {
        #region Properties

        protected long? _militarynokw;
        public long? SvcStatus { get; set; }

        [DataMember]
        //[Display(Name = "militaryno", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
        public long? militarynokw
        {
            get { return _militarynokw; }
            set { _militarynokw = value; this.OnChnaged(); }
        }

        #endregion

        #region Constructor



        public hr_personalinfoEntity(IDataReader reader, bool IsListViewShow, bool isExtension)
        {
            this.LoadFromReader_Ext(reader, IsListViewShow, isExtension);
        }
        
        protected void LoadFromReader_Ext(IDataReader reader, bool IsListViewShow, bool isExtension)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("HrPersonalInfoID"))) _hrpersonalinfoid = reader.GetInt64(reader.GetOrdinal("HrPersonalInfoID"));
                if (!reader.IsDBNull(reader.GetOrdinal("MilNoKW"))) _militarynokw = reader.GetInt64(reader.GetOrdinal("MilNoKW"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ReligionID"))) _religionid = reader.GetInt64(reader.GetOrdinal("ReligionID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BloodGroupId"))) _bloodgroupid = reader.GetInt64(reader.GetOrdinal("BloodGroupId"));
                if (!reader.IsDBNull(reader.GetOrdinal("MaritalStatusID"))) _maritalstatusid = reader.GetInt64(reader.GetOrdinal("MaritalStatusID"));
                if (!reader.IsDBNull(reader.GetOrdinal("GenderID"))) _genderid = reader.GetInt64(reader.GetOrdinal("GenderID"));
                if (!reader.IsDBNull(reader.GetOrdinal("NationalityID"))) _nationalityid = reader.GetInt64(reader.GetOrdinal("NationalityID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BuildingID"))) _buildingid = reader.GetInt64(reader.GetOrdinal("BuildingID"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWGovID"))) _kwgovid = reader.GetInt64(reader.GetOrdinal("KWGovID"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWAreaID"))) _kwareaid = reader.GetInt64(reader.GetOrdinal("KWAreaID"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWBlockNo"))) _kwblockno = reader.GetString(reader.GetOrdinal("KWBlockNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWStreet"))) _kwstreet = reader.GetString(reader.GetOrdinal("KWStreet"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWHouseNo"))) _kwhouseno = reader.GetString(reader.GetOrdinal("KWHouseNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWFlatNo"))) _kwflatno = reader.GetString(reader.GetOrdinal("KWFlatNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWMobile"))) _kwmobile = reader.GetString(reader.GetOrdinal("KWMobile"));
                if (!reader.IsDBNull(reader.GetOrdinal("KWViber"))) _kwviber = reader.GetString(reader.GetOrdinal("KWViber"));
                if (!reader.IsDBNull(reader.GetOrdinal("PersonalEmail"))) _personalemail = reader.GetString(reader.GetOrdinal("PersonalEmail"));
                if (!reader.IsDBNull(reader.GetOrdinal("OfficialEmail"))) _officialemail = reader.GetString(reader.GetOrdinal("OfficialEmail"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDCurDivID"))) _bdcurdivid = reader.GetInt64(reader.GetOrdinal("BDCurDivID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDCurCityID"))) _bdcurcityid = reader.GetInt64(reader.GetOrdinal("BDCurCityID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDCurThanaID"))) _bdcurthanaid = reader.GetInt64(reader.GetOrdinal("BDCurThanaID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDCurPostOffice"))) _bdcurpostoffice = reader.GetString(reader.GetOrdinal("BDCurPostOffice"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDCurRoad"))) _bdcurroad = reader.GetString(reader.GetOrdinal("BDCurRoad"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDCurHouse"))) _bdcurhouse = reader.GetString(reader.GetOrdinal("BDCurHouse"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDCurFlatNo"))) _bdcurflatno = reader.GetString(reader.GetOrdinal("BDCurFlatNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDMob1"))) _bdmob1 = reader.GetString(reader.GetOrdinal("BDMob1"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDMob2"))) _bdmob2 = reader.GetString(reader.GetOrdinal("BDMob2"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDHomePhone"))) _bdhomephone = reader.GetString(reader.GetOrdinal("BDHomePhone"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDPerDivID"))) _bdperdivid = reader.GetInt64(reader.GetOrdinal("BDPerDivID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDPerCityID"))) _bdpercityid = reader.GetInt64(reader.GetOrdinal("BDPerCityID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDPerThanaID"))) _bdperthanaid = reader.GetInt64(reader.GetOrdinal("BDPerThanaID"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDPerPostOffice"))) _bdperpostoffice = reader.GetString(reader.GetOrdinal("BDPerPostOffice"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDPerRoad"))) _bdperroad = reader.GetString(reader.GetOrdinal("BDPerRoad"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDPerHouse"))) _bdperhouse = reader.GetString(reader.GetOrdinal("BDPerHouse"));
                if (!reader.IsDBNull(reader.GetOrdinal("BDPerFlatNo"))) _bdperflatno = reader.GetString(reader.GetOrdinal("BDPerFlatNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("Status"))) SvcStatus = reader.GetInt64(reader.GetOrdinal("Status"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Date1"))) _ex_date1 = reader.GetDateTime(reader.GetOrdinal("Ex_Date1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Date2"))) _ex_date2 = reader.GetDateTime(reader.GetOrdinal("Ex_Date2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Nvarchar1"))) _ex_nvarchar1 = reader.GetString(reader.GetOrdinal("Ex_Nvarchar1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Nvarchar2"))) _ex_nvarchar2 = reader.GetString(reader.GetOrdinal("Ex_Nvarchar2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Bigint1"))) _ex_bigint1 = reader.GetInt64(reader.GetOrdinal("Ex_Bigint1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Bigint2"))) _ex_bigint2 = reader.GetInt64(reader.GetOrdinal("Ex_Bigint2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Decimal1"))) _ex_decimal1 = reader.GetDecimal(reader.GetOrdinal("Ex_Decimal1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Decimal2"))) _ex_decimal2 = reader.GetDecimal(reader.GetOrdinal("Ex_Decimal2"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserOrganizationKey"))) this.BaseSecurityParam.userorganizationkey = reader.GetInt64(reader.GetOrdinal("UserOrganizationKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserEntityKey"))) this.BaseSecurityParam.userentitykey = reader.GetInt64(reader.GetOrdinal("UserEntityKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedBy"))) this.BaseSecurityParam.createdby = reader.GetInt64(reader.GetOrdinal("CreatedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) _createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedBy"))) this.BaseSecurityParam.updatedby = reader.GetInt64(reader.GetOrdinal("UpdatedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) _updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("FormID"))) this.BaseSecurityParam.appformid = reader.GetInt64(reader.GetOrdinal("FormID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }
        
        #endregion
    }
}
