using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{

	public partial class hr_svcinfoEntity
	{
		#region Properties

		protected string _name1;
		protected string _name2;
		protected string _name3;
		protected string _fullname;
		protected DateTime? _dateofbirth;
		protected DateTime? _joindatebd;
		protected long? _civilid;
		protected string _militarynobd;

		protected string _profilephoto;
		protected string _profilephotofilepath;
		protected string _profilephotofilename;
		protected string _profilephotofiletype;
		protected string _profilephotofileextension;
		private string residencyNumber;

		public string goletterno { get; set; }
		public DateTime? godate { get; set; }

		public DateTime? goexpdate { get; set; }

		public DateTime? civilidexpiredate { get; set; }

		[DataMember]
		[MaxLength(150)]
		[Display(Name = "name1", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
		[Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_basicprofile), ErrorMessageResourceName = "name1Required")]
		public string name1
		{
			get { return _name1; }
			set { _name1 = value; this.OnChnaged(); }
		}

		[DataMember]
		[MaxLength(150)]
		[Display(Name = "name2", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
		[Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_basicprofile), ErrorMessageResourceName = "name2Required")]
		public string name2
		{
			get { return _name2; }
			set { _name2 = value; this.OnChnaged(); }
		}

		[DataMember]
		[MaxLength(150)]
		[Display(Name = "name3", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
		public string name3
		{
			get { return _name3; }
			set { _name3 = value; this.OnChnaged(); }
		}

		[DataMember]
		[MaxLength(550)]
		[Display(Name = "fullname", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
		[Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_basicprofile), ErrorMessageResourceName = "fullnameRequired")]
		public string fullname
		{
			get { return _fullname; }
			set { _fullname = value; this.OnChnaged(); }
		}
		[DataMember]
		[Display(Name = "dateofbirth", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
		public DateTime? dateofbirth
		{
			get { return _dateofbirth; }
			set { _dateofbirth = value; this.OnChnaged(); }
		}

		[DataMember]
		[Display(Name = "joindatebd", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
		public DateTime? joindatebd
		{
			get { return _joindatebd; }
			set { _joindatebd = value; this.OnChnaged(); }
		}

		[DataMember]
		[Display(Name = "civilid", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
		[RegularExpression("^[0-9]{12}$", ErrorMessage = "Civil ID length must be 12")]
		public long? civilid
		{
			get { return _civilid; }
			set { _civilid = value; this.OnChnaged(); }
		}


		[DataMember]
		//[Display(Name = "militaryno", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
		public string militarynobd
		{
			get { return _militarynobd; }
			set { _militarynobd = value; this.OnChnaged(); }
		}

		[DataMember]
		[MaxLength(150)]
		[Display(Name = "profilephoto", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
		public string profilephoto
		{
			get { return _profilephoto; }
			set { _profilephoto = value; this.OnChnaged(); }
		}

		[DataMember]
		[MaxLength(250)]
		[Display(Name = "profilephotofilepath", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
		public string profilephotofilepath
		{
			get { return _profilephotofilepath; }
			set { _profilephotofilepath = value; this.OnChnaged(); }
		}

		[DataMember]
		[MaxLength(250)]
		[Display(Name = "profilephotofilename", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
		public string profilephotofilename
		{
			get { return _profilephotofilename; }
			set { _profilephotofilename = value; this.OnChnaged(); }
		}

		[DataMember]
		[MaxLength(250)]
		[Display(Name = "profilephotofiletype", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
		public string profilephotofiletype
		{
			get { return _profilephotofiletype; }
			set { _profilephotofiletype = value; this.OnChnaged(); }
		}

		[DataMember]
		[MaxLength(250)]
		[Display(Name = "profilephotofileextension", ResourceType = typeof(KAF.MsgContainer._hr_basicprofile))]
		public string profilephotofileextension
		{
			get { return _profilephotofileextension; }
			set { _profilephotofileextension = value; this.OnChnaged(); }
		}

		[DataMember]
		public string ResidencyNumber { get => residencyNumber; set => residencyNumber = value; }

		public hr_svcinfoEntity(IDataReader reader, bool IsExt, bool IsGetAllData)
		{
			this.LoadFromReader_Ext(reader);
		}
		#endregion

		#region Constructor


		protected void LoadFromReader_Ext(IDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{
				this.BaseSecurityParam = new SecurityCapsule();
				if (!reader.IsDBNull(reader.GetOrdinal("HrSvcID"))) _hrsvcid = reader.GetInt64(reader.GetOrdinal("HrSvcID"));
				if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) _civilid = reader.GetInt64(reader.GetOrdinal("CivilID"));
				if (!reader.IsDBNull(reader.GetOrdinal("goletterno"))) goletterno = reader.GetString(reader.GetOrdinal("goletterno"));
				if (!reader.IsDBNull(reader.GetOrdinal("MilNoKW"))) _militarynokw = reader.GetInt64(reader.GetOrdinal("MilNoKW"));
				if (!reader.IsDBNull(reader.GetOrdinal("MilNoBD"))) _militarynobd = reader.GetString(reader.GetOrdinal("MilNoBD"));
				if (!reader.IsDBNull(reader.GetOrdinal("Name1"))) _name1 = reader.GetString(reader.GetOrdinal("Name1"));
				if (!reader.IsDBNull(reader.GetOrdinal("Name2"))) _name2 = reader.GetString(reader.GetOrdinal("Name2"));
				if (!reader.IsDBNull(reader.GetOrdinal("Name3"))) _name3 = reader.GetString(reader.GetOrdinal("Name3"));
				if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
				if (!reader.IsDBNull(reader.GetOrdinal("DateofBirth"))) _dateofbirth = reader.GetDateTime(reader.GetOrdinal("DateofBirth"));
				if (!reader.IsDBNull(reader.GetOrdinal("JoinDateBD"))) _joindatebd = reader.GetDateTime(reader.GetOrdinal("JoinDateBD"));
				if (!reader.IsDBNull(reader.GetOrdinal("HRBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HRBasicID"));
				if (!reader.IsDBNull(reader.GetOrdinal("PassportNo"))) _passportno = reader.GetString(reader.GetOrdinal("PassportNo"));
				if (!reader.IsDBNull(reader.GetOrdinal("JoinDateKw"))) _joindatekw = reader.GetDateTime(reader.GetOrdinal("JoinDateKw"));
				if (!reader.IsDBNull(reader.GetOrdinal("ExpectedRetireDateKw"))) _expectedretiredatekw = reader.GetDateTime(reader.GetOrdinal("ExpectedRetireDateKw"));
				if (!reader.IsDBNull(reader.GetOrdinal("UserID"))) _userid = reader.GetGuid(reader.GetOrdinal("UserID"));
				if (!reader.IsDBNull(reader.GetOrdinal("EntityKey"))) _entitykey = reader.GetInt64(reader.GetOrdinal("EntityKey"));
				if (!reader.IsDBNull(reader.GetOrdinal("ArmsID"))) _armsid = reader.GetInt64(reader.GetOrdinal("ArmsID"));
				if (!reader.IsDBNull(reader.GetOrdinal("OkpID"))) _okpid = reader.GetInt64(reader.GetOrdinal("OkpID"));
				if (!reader.IsDBNull(reader.GetOrdinal("RankIDKW"))) _rankidkw = reader.GetInt64(reader.GetOrdinal("RankIDKW"));
				if (!reader.IsDBNull(reader.GetOrdinal("RankIDBD"))) _rankidbd = reader.GetInt64(reader.GetOrdinal("RankIDBD"));
				if (!reader.IsDBNull(reader.GetOrdinal("TradeIDBD"))) _tradeidbd = reader.GetInt64(reader.GetOrdinal("TradeIDBD"));
				if (!reader.IsDBNull(reader.GetOrdinal("TradeIDKW"))) _tradeidkw = reader.GetInt64(reader.GetOrdinal("TradeIDKW"));
				if (!reader.IsDBNull(reader.GetOrdinal("GroupID"))) _groupid = reader.GetInt64(reader.GetOrdinal("GroupID"));
				if (!reader.IsDBNull(reader.GetOrdinal("OrganizationKey"))) _organizationkey = reader.GetInt64(reader.GetOrdinal("OrganizationKey"));
				if (!reader.IsDBNull(reader.GetOrdinal("ProfilePhoto"))) _profilephoto = reader.GetString(reader.GetOrdinal("ProfilePhoto"));
				if (!reader.IsDBNull(reader.GetOrdinal("ProfilePhotoFilePath"))) _profilephotofilepath = reader.GetString(reader.GetOrdinal("ProfilePhotoFilePath"));
				if (!reader.IsDBNull(reader.GetOrdinal("ProfilePhotoFileName"))) _profilephotofilename = reader.GetString(reader.GetOrdinal("ProfilePhotoFileName"));
				if (!reader.IsDBNull(reader.GetOrdinal("ProfilePhotoFileType"))) _profilephotofiletype = reader.GetString(reader.GetOrdinal("ProfilePhotoFileType"));
				if (!reader.IsDBNull(reader.GetOrdinal("ProfilePhotoFileExtension"))) _profilephotofileextension = reader.GetString(reader.GetOrdinal("ProfilePhotoFileExtension"));

				if (!reader.IsDBNull(reader.GetOrdinal("SubUnitID"))) _subunitid = reader.GetInt64(reader.GetOrdinal("SubUnitID"));
				if (!reader.IsDBNull(reader.GetOrdinal("CampID"))) _campid = reader.GetInt64(reader.GetOrdinal("CampID"));

				if (!reader.IsDBNull(reader.GetOrdinal("civilidexpiredate"))) civilidexpiredate = reader.GetDateTime(reader.GetOrdinal("civilidexpiredate"));
				if (!reader.IsDBNull(reader.GetOrdinal("godate"))) godate = reader.GetDateTime(reader.GetOrdinal("godate"));
				if (!reader.IsDBNull(reader.GetOrdinal("goexpdate"))) goexpdate = reader.GetDateTime(reader.GetOrdinal("goexpdate"));

				if (!reader.IsDBNull(reader.GetOrdinal("Status"))) _status = reader.GetInt64(reader.GetOrdinal("Status"));
				if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
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

		protected void LoadFromReader_Ext2(IDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{
				this.BaseSecurityParam = new SecurityCapsule();
				if (!reader.IsDBNull(reader.GetOrdinal("HrSvcID"))) _hrsvcid = reader.GetInt64(reader.GetOrdinal("HrSvcID"));
				if (!reader.IsDBNull(reader.GetOrdinal("CivilID"))) _civilid = reader.GetInt64(reader.GetOrdinal("CivilID"));
				if (!reader.IsDBNull(reader.GetOrdinal("MilNoKW"))) _militarynokw = reader.GetInt64(reader.GetOrdinal("MilNoKW"));
				if (!reader.IsDBNull(reader.GetOrdinal("MilNoBD"))) _militarynobd = reader.GetString(reader.GetOrdinal("MilNoBD")); if (!reader.IsDBNull(reader.GetOrdinal("Name1"))) _name1 = reader.GetString(reader.GetOrdinal("Name1"));
				if (!reader.IsDBNull(reader.GetOrdinal("Name2"))) _name2 = reader.GetString(reader.GetOrdinal("Name2"));
				if (!reader.IsDBNull(reader.GetOrdinal("Name3"))) _name3 = reader.GetString(reader.GetOrdinal("Name3"));
				if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) _fullname = reader.GetString(reader.GetOrdinal("FullName"));
				if (!reader.IsDBNull(reader.GetOrdinal("DateofBirth"))) _dateofbirth = reader.GetDateTime(reader.GetOrdinal("DateofBirth"));
				if (!reader.IsDBNull(reader.GetOrdinal("JoinDateBD"))) _joindatebd = reader.GetDateTime(reader.GetOrdinal("JoinDateBD"));
				if (!reader.IsDBNull(reader.GetOrdinal("HRBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HRBasicID"));
				if (!reader.IsDBNull(reader.GetOrdinal("PassportNo"))) _passportno = reader.GetString(reader.GetOrdinal("PassportNo"));
				if (!reader.IsDBNull(reader.GetOrdinal("JoinDateKw"))) _joindatekw = reader.GetDateTime(reader.GetOrdinal("JoinDateKw"));
				if (!reader.IsDBNull(reader.GetOrdinal("ExpectedRetireDateKw"))) _expectedretiredatekw = reader.GetDateTime(reader.GetOrdinal("ExpectedRetireDateKw"));
				if (!reader.IsDBNull(reader.GetOrdinal("UserID"))) _userid = reader.GetGuid(reader.GetOrdinal("UserID"));
				if (!reader.IsDBNull(reader.GetOrdinal("EntityKey"))) _entitykey = reader.GetInt64(reader.GetOrdinal("EntityKey"));
				if (!reader.IsDBNull(reader.GetOrdinal("ArmsID"))) _armsid = reader.GetInt64(reader.GetOrdinal("ArmsID"));
				if (!reader.IsDBNull(reader.GetOrdinal("OkpID"))) _okpid = reader.GetInt64(reader.GetOrdinal("OkpID"));
				if (!reader.IsDBNull(reader.GetOrdinal("RankIDKW"))) _rankidkw = reader.GetInt64(reader.GetOrdinal("RankIDKW"));
				if (!reader.IsDBNull(reader.GetOrdinal("RankIDBD"))) _rankidbd = reader.GetInt64(reader.GetOrdinal("RankIDBD"));
				if (!reader.IsDBNull(reader.GetOrdinal("TradeIDBD"))) _tradeidbd = reader.GetInt64(reader.GetOrdinal("TradeIDBD"));
				if (!reader.IsDBNull(reader.GetOrdinal("TradeIDKW"))) _tradeidkw = reader.GetInt64(reader.GetOrdinal("TradeIDKW"));
				if (!reader.IsDBNull(reader.GetOrdinal("GroupID"))) _groupid = reader.GetInt64(reader.GetOrdinal("GroupID"));
				if (!reader.IsDBNull(reader.GetOrdinal("OrganizationKey"))) _organizationkey = reader.GetInt64(reader.GetOrdinal("OrganizationKey"));
				if (!reader.IsDBNull(reader.GetOrdinal("Status"))) _status = reader.GetInt64(reader.GetOrdinal("Status"));
				if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));

				if (!reader.IsDBNull(reader.GetOrdinal("ProfilePhoto"))) _profilephoto = reader.GetString(reader.GetOrdinal("ProfilePhoto"));
				if (!reader.IsDBNull(reader.GetOrdinal("ProfilePhotoFilePath"))) _profilephotofilepath = reader.GetString(reader.GetOrdinal("ProfilePhotoFilePath"));
				if (!reader.IsDBNull(reader.GetOrdinal("ProfilePhotoFileName"))) _profilephotofilename = reader.GetString(reader.GetOrdinal("ProfilePhotoFileName"));
				if (!reader.IsDBNull(reader.GetOrdinal("ProfilePhotoFileType"))) _profilephotofiletype = reader.GetString(reader.GetOrdinal("ProfilePhotoFileType"));
				if (!reader.IsDBNull(reader.GetOrdinal("ProfilePhotoFileExtension"))) _profilephotofileextension = reader.GetString(reader.GetOrdinal("ProfilePhotoFileExtension"));

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
