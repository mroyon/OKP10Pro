using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class rpt_GetReplacementPassportInfoEntity:  BaseEntity
	{
		protected Int64? _milnokw;
		protected Int64? _HRBasicID;
		protected Int64? _HrSvcID;
		protected Int64? _civilid;
		protected String _fullname;
		protected DateTime? _dateofbirth;
		protected Int64? _religionid;
		protected Int64? _bloodgroupid;
		protected Int64? _maritalstatusid;
		protected Int64? _genderid;
		protected Int64? _nationalityid;
		protected Int64? _kwgovid;
		protected Int64? _buildingid;
		protected Int64? _kwareaid;
		protected String _kwblockno;
		protected String _kwstreet;
		protected String _kwhouseno;
		protected String _kwflatno;
		protected String _kwmobile;
		protected String _kwviber;
		protected String _personalemail;
		protected String _officialemail;
		protected Int64? _bdcurdivid;
		protected Int64? _bdcurcityid;
		protected Int64? _bdcurthanaid;
		protected String _bdcurpostoffice;
		protected String _bdcurroad;
		protected String _bdcurflatno;
		protected String _bdcurhouse;
		protected String _bdmob1;
		protected String _bdmob2;
		protected String _bdhomephone;
		protected Int64? _bdperdivid;
		protected Int64? _bdpercityid;
		protected Int64? _bdperthanaid;
		protected String _bdperpostoffice;
		protected String _bdperroad;
		protected String _bdperhouse;
		protected String _bdperflatno;
		protected Int64? _RankIDKW;
		protected String _KuwaitiRank;
		protected Int64? _TradeIDKW;
		protected String _KuwaitiTrade;
		protected Int64? _OkpID;
		protected String _OkpName;
		protected Int64? _ReplacementDetlID;
		protected Int64? _RepPassportDetlID;
		protected String _newName1;
		protected String _newName2;
		protected String _newFullName;
		protected String _newPassportno;
		protected Int64? _NewHrBasicID;
		protected Int64? _NewHrSvcID;
		protected String _LetterStatus;
		protected string _MilNoBD;
		protected String _RankName;
		protected String _TradeName;
		protected String _ArmsName;
		protected DateTime? _TOD;
		protected DateTime? _PassportRecvDate;
		protected String _PassportLetterNo;
		protected DateTime? _PassportLetterDate;
		protected String _GroupName;
		protected Int64? _RepPassportID;

		[DataMember]
		public Int64? milnokw
		{
			get { return _milnokw; }
			set {_milnokw=value; }
		}
		[DataMember]
		public Int64? HRBasicID
		{
			get { return _HRBasicID; }
			set {_HRBasicID=value; }
		}
		[DataMember]
		public Int64? HrSvcID
		{
			get { return _HrSvcID; }
			set {_HrSvcID=value; }
		}
		[DataMember]
		public Int64? civilid
		{
			get { return _civilid; }
			set {_civilid=value; }
		}
		[DataMember]
		public String fullname
		{
			get { return _fullname; }
			set {_fullname=value; }
		}
		[DataMember]
		public DateTime? dateofbirth
		{
			get { return _dateofbirth; }
			set {_dateofbirth=value; }
		}
		[DataMember]
		public Int64? religionid
		{
			get { return _religionid; }
			set {_religionid=value; }
		}
		[DataMember]
		public Int64? bloodgroupid
		{
			get { return _bloodgroupid; }
			set {_bloodgroupid=value; }
		}
		[DataMember]
		public Int64? maritalstatusid
		{
			get { return _maritalstatusid; }
			set {_maritalstatusid=value; }
		}
		[DataMember]
		public Int64? genderid
		{
			get { return _genderid; }
			set {_genderid=value; }
		}
		[DataMember]
		public Int64? nationalityid
		{
			get { return _nationalityid; }
			set {_nationalityid=value; }
		}
		[DataMember]
		public Int64? kwgovid
		{
			get { return _kwgovid; }
			set {_kwgovid=value; }
		}
		[DataMember]
		public Int64? buildingid
		{
			get { return _buildingid; }
			set {_buildingid=value; }
		}
		[DataMember]
		public Int64? kwareaid
		{
			get { return _kwareaid; }
			set {_kwareaid=value; }
		}
		[DataMember]
		public String kwblockno
		{
			get { return _kwblockno; }
			set {_kwblockno=value; }
		}
		[DataMember]
		public String kwstreet
		{
			get { return _kwstreet; }
			set {_kwstreet=value; }
		}
		[DataMember]
		public String kwhouseno
		{
			get { return _kwhouseno; }
			set {_kwhouseno=value; }
		}
		[DataMember]
		public String kwflatno
		{
			get { return _kwflatno; }
			set {_kwflatno=value; }
		}
		[DataMember]
		public String kwmobile
		{
			get { return _kwmobile; }
			set {_kwmobile=value; }
		}
		[DataMember]
		public String kwviber
		{
			get { return _kwviber; }
			set {_kwviber=value; }
		}
		[DataMember]
		public String personalemail
		{
			get { return _personalemail; }
			set {_personalemail=value; }
		}
		[DataMember]
		public String officialemail
		{
			get { return _officialemail; }
			set {_officialemail=value; }
		}
		[DataMember]
		public Int64? bdcurdivid
		{
			get { return _bdcurdivid; }
			set {_bdcurdivid=value; }
		}
		[DataMember]
		public Int64? bdcurcityid
		{
			get { return _bdcurcityid; }
			set {_bdcurcityid=value; }
		}
		[DataMember]
		public Int64? bdcurthanaid
		{
			get { return _bdcurthanaid; }
			set {_bdcurthanaid=value; }
		}
		[DataMember]
		public String bdcurpostoffice
		{
			get { return _bdcurpostoffice; }
			set {_bdcurpostoffice=value; }
		}
		[DataMember]
		public String bdcurroad
		{
			get { return _bdcurroad; }
			set {_bdcurroad=value; }
		}
		[DataMember]
		public String bdcurflatno
		{
			get { return _bdcurflatno; }
			set {_bdcurflatno=value; }
		}
		[DataMember]
		public String bdcurhouse
		{
			get { return _bdcurhouse; }
			set {_bdcurhouse=value; }
		}
		[DataMember]
		public String bdmob1
		{
			get { return _bdmob1; }
			set {_bdmob1=value; }
		}
		[DataMember]
		public String bdmob2
		{
			get { return _bdmob2; }
			set {_bdmob2=value; }
		}
		[DataMember]
		public String bdhomephone
		{
			get { return _bdhomephone; }
			set {_bdhomephone=value; }
		}
		[DataMember]
		public Int64? bdperdivid
		{
			get { return _bdperdivid; }
			set {_bdperdivid=value; }
		}
		[DataMember]
		public Int64? bdpercityid
		{
			get { return _bdpercityid; }
			set {_bdpercityid=value; }
		}
		[DataMember]
		public Int64? bdperthanaid
		{
			get { return _bdperthanaid; }
			set {_bdperthanaid=value; }
		}
		[DataMember]
		public String bdperpostoffice
		{
			get { return _bdperpostoffice; }
			set {_bdperpostoffice=value; }
		}
		[DataMember]
		public String bdperroad
		{
			get { return _bdperroad; }
			set {_bdperroad=value; }
		}
		[DataMember]
		public String bdperhouse
		{
			get { return _bdperhouse; }
			set {_bdperhouse=value; }
		}
		[DataMember]
		public String bdperflatno
		{
			get { return _bdperflatno; }
			set {_bdperflatno=value; }
		}
		[DataMember]
		public Int64? RankIDKW
		{
			get { return _RankIDKW; }
			set {_RankIDKW=value; }
		}
		[DataMember]
		public String KuwaitiRank
		{
			get { return _KuwaitiRank; }
			set {_KuwaitiRank=value; }
		}
		[DataMember]
		public Int64? TradeIDKW
		{
			get { return _TradeIDKW; }
			set {_TradeIDKW=value; }
		}
		[DataMember]
		public String KuwaitiTrade
		{
			get { return _KuwaitiTrade; }
			set {_KuwaitiTrade=value; }
		}
		[DataMember]
		public Int64? OkpID
		{
			get { return _OkpID; }
			set {_OkpID=value; }
		}
		[DataMember]
		public String OkpName
		{
			get { return _OkpName; }
			set {_OkpName=value; }
		}
		[DataMember]
		public Int64? ReplacementDetlID
		{
			get { return _ReplacementDetlID; }
			set {_ReplacementDetlID=value; }
		}
		[DataMember]
		public Int64? RepPassportDetlID
		{
			get { return _RepPassportDetlID; }
			set {_RepPassportDetlID=value; }
		}
		[DataMember]
		public String newName1
		{
			get { return _newName1; }
			set {_newName1=value; }
		}
		[DataMember]
		public String newName2
		{
			get { return _newName2; }
			set {_newName2=value; }
		}
		[DataMember]
		public String newFullName
		{
			get { return _newFullName; }
			set {_newFullName=value; }
		}
		[DataMember]
		public String newPassportno
		{
			get { return _newPassportno; }
			set {_newPassportno=value; }
		}
		[DataMember]
		public Int64? NewHrBasicID
		{
			get { return _NewHrBasicID; }
			set {_NewHrBasicID=value; }
		}
		[DataMember]
		public Int64? NewHrSvcID
		{
			get { return _NewHrSvcID; }
			set {_NewHrSvcID=value; }
		}
		[DataMember]
		public String LetterStatus
		{
			get { return _LetterStatus; }
			set {_LetterStatus=value; }
		}
		[DataMember]
		public string MilNoBD
		{
			get { return _MilNoBD; }
			set {_MilNoBD=value; }
		}
		[DataMember]
		public String RankName
		{
			get { return _RankName; }
			set {_RankName=value; }
		}
		[DataMember]
		public String TradeName
		{
			get { return _TradeName; }
			set {_TradeName=value; }
		}
		[DataMember]
		public String ArmsName
		{
			get { return _ArmsName; }
			set {_ArmsName=value; }
		}
		[DataMember]
		public DateTime? TOD
		{
			get { return _TOD; }
			set {_TOD=value; }
		}
		[DataMember]
		public DateTime? PassportRecvDate
		{
			get { return _PassportRecvDate; }
			set {_PassportRecvDate=value; }
		}
		[DataMember]
		public String PassportLetterNo
		{
			get { return _PassportLetterNo; }
			set {_PassportLetterNo=value; }
		}
		[DataMember]
		public DateTime? PassportLetterDate
		{
			get { return _PassportLetterDate; }
			set {_PassportLetterDate=value; }
		}
		[DataMember]
		public String GroupName
		{
			get { return _GroupName; }
			set {_GroupName=value; }
		}
		[DataMember]
		public Int64? RepPassportID
		{
			get { return _RepPassportID; }
			set {_RepPassportID=value; }
		}
		public rpt_GetReplacementPassportInfoEntity():base()
		{

		}

		public rpt_GetReplacementPassportInfoEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (!reader.IsDBNull(reader.GetOrdinal("milnokw"))) _milnokw = reader.GetInt64(reader.GetOrdinal("milnokw"));
			if (!reader.IsDBNull(reader.GetOrdinal("HRBasicID"))) _HRBasicID = reader.GetInt64(reader.GetOrdinal("HRBasicID"));
			if (!reader.IsDBNull(reader.GetOrdinal("HrSvcID"))) _HrSvcID = reader.GetInt64(reader.GetOrdinal("HrSvcID"));
			if (!reader.IsDBNull(reader.GetOrdinal("civilid"))) _civilid = reader.GetInt64(reader.GetOrdinal("civilid"));
			if (!reader.IsDBNull(reader.GetOrdinal("fullname"))) _fullname = reader.GetString(reader.GetOrdinal("fullname"));
			if (!reader.IsDBNull(reader.GetOrdinal("dateofbirth"))) _dateofbirth = reader.GetDateTime(reader.GetOrdinal("dateofbirth"));
			if (!reader.IsDBNull(reader.GetOrdinal("religionid"))) _religionid = reader.GetInt64(reader.GetOrdinal("religionid"));
			if (!reader.IsDBNull(reader.GetOrdinal("bloodgroupid"))) _bloodgroupid = reader.GetInt64(reader.GetOrdinal("bloodgroupid"));
			if (!reader.IsDBNull(reader.GetOrdinal("maritalstatusid"))) _maritalstatusid = reader.GetInt64(reader.GetOrdinal("maritalstatusid"));
			if (!reader.IsDBNull(reader.GetOrdinal("genderid"))) _genderid = reader.GetInt64(reader.GetOrdinal("genderid"));
			if (!reader.IsDBNull(reader.GetOrdinal("nationalityid"))) _nationalityid = reader.GetInt64(reader.GetOrdinal("nationalityid"));
			if (!reader.IsDBNull(reader.GetOrdinal("kwgovid"))) _kwgovid = reader.GetInt64(reader.GetOrdinal("kwgovid"));
			if (!reader.IsDBNull(reader.GetOrdinal("buildingid"))) _buildingid = reader.GetInt64(reader.GetOrdinal("buildingid"));
			if (!reader.IsDBNull(reader.GetOrdinal("kwareaid"))) _kwareaid = reader.GetInt64(reader.GetOrdinal("kwareaid"));
			if (!reader.IsDBNull(reader.GetOrdinal("kwblockno"))) _kwblockno = reader.GetString(reader.GetOrdinal("kwblockno"));
			if (!reader.IsDBNull(reader.GetOrdinal("kwstreet"))) _kwstreet = reader.GetString(reader.GetOrdinal("kwstreet"));
			if (!reader.IsDBNull(reader.GetOrdinal("kwhouseno"))) _kwhouseno = reader.GetString(reader.GetOrdinal("kwhouseno"));
			if (!reader.IsDBNull(reader.GetOrdinal("kwflatno"))) _kwflatno = reader.GetString(reader.GetOrdinal("kwflatno"));
			if (!reader.IsDBNull(reader.GetOrdinal("kwmobile"))) _kwmobile = reader.GetString(reader.GetOrdinal("kwmobile"));
			if (!reader.IsDBNull(reader.GetOrdinal("kwviber"))) _kwviber = reader.GetString(reader.GetOrdinal("kwviber"));
			if (!reader.IsDBNull(reader.GetOrdinal("personalemail"))) _personalemail = reader.GetString(reader.GetOrdinal("personalemail"));
			if (!reader.IsDBNull(reader.GetOrdinal("officialemail"))) _officialemail = reader.GetString(reader.GetOrdinal("officialemail"));
			if (!reader.IsDBNull(reader.GetOrdinal("bdcurdivid"))) _bdcurdivid = reader.GetInt64(reader.GetOrdinal("bdcurdivid"));
			if (!reader.IsDBNull(reader.GetOrdinal("bdcurcityid"))) _bdcurcityid = reader.GetInt64(reader.GetOrdinal("bdcurcityid"));
			if (!reader.IsDBNull(reader.GetOrdinal("bdcurthanaid"))) _bdcurthanaid = reader.GetInt64(reader.GetOrdinal("bdcurthanaid"));
			if (!reader.IsDBNull(reader.GetOrdinal("bdcurpostoffice"))) _bdcurpostoffice = reader.GetString(reader.GetOrdinal("bdcurpostoffice"));
			if (!reader.IsDBNull(reader.GetOrdinal("bdcurroad"))) _bdcurroad = reader.GetString(reader.GetOrdinal("bdcurroad"));
			if (!reader.IsDBNull(reader.GetOrdinal("bdcurflatno"))) _bdcurflatno = reader.GetString(reader.GetOrdinal("bdcurflatno"));
			if (!reader.IsDBNull(reader.GetOrdinal("bdcurhouse"))) _bdcurhouse = reader.GetString(reader.GetOrdinal("bdcurhouse"));
			if (!reader.IsDBNull(reader.GetOrdinal("bdmob1"))) _bdmob1 = reader.GetString(reader.GetOrdinal("bdmob1"));
			if (!reader.IsDBNull(reader.GetOrdinal("bdmob2"))) _bdmob2 = reader.GetString(reader.GetOrdinal("bdmob2"));
			if (!reader.IsDBNull(reader.GetOrdinal("bdhomephone"))) _bdhomephone = reader.GetString(reader.GetOrdinal("bdhomephone"));
			if (!reader.IsDBNull(reader.GetOrdinal("bdperdivid"))) _bdperdivid = reader.GetInt64(reader.GetOrdinal("bdperdivid"));
			if (!reader.IsDBNull(reader.GetOrdinal("bdpercityid"))) _bdpercityid = reader.GetInt64(reader.GetOrdinal("bdpercityid"));
			if (!reader.IsDBNull(reader.GetOrdinal("bdperthanaid"))) _bdperthanaid = reader.GetInt64(reader.GetOrdinal("bdperthanaid"));
			if (!reader.IsDBNull(reader.GetOrdinal("bdperpostoffice"))) _bdperpostoffice = reader.GetString(reader.GetOrdinal("bdperpostoffice"));
			if (!reader.IsDBNull(reader.GetOrdinal("bdperroad"))) _bdperroad = reader.GetString(reader.GetOrdinal("bdperroad"));
			if (!reader.IsDBNull(reader.GetOrdinal("bdperhouse"))) _bdperhouse = reader.GetString(reader.GetOrdinal("bdperhouse"));
			if (!reader.IsDBNull(reader.GetOrdinal("bdperflatno"))) _bdperflatno = reader.GetString(reader.GetOrdinal("bdperflatno"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankIDKW"))) _RankIDKW = reader.GetInt64(reader.GetOrdinal("RankIDKW"));
			if (!reader.IsDBNull(reader.GetOrdinal("KuwaitiRank"))) _KuwaitiRank = reader.GetString(reader.GetOrdinal("KuwaitiRank"));
			if (!reader.IsDBNull(reader.GetOrdinal("TradeIDKW"))) _TradeIDKW = reader.GetInt64(reader.GetOrdinal("TradeIDKW"));
			if (!reader.IsDBNull(reader.GetOrdinal("KuwaitiTrade"))) _KuwaitiTrade = reader.GetString(reader.GetOrdinal("KuwaitiTrade"));
			if (!reader.IsDBNull(reader.GetOrdinal("OkpID"))) _OkpID = reader.GetInt64(reader.GetOrdinal("OkpID"));
			if (!reader.IsDBNull(reader.GetOrdinal("OkpName"))) _OkpName = reader.GetString(reader.GetOrdinal("OkpName"));
			if (!reader.IsDBNull(reader.GetOrdinal("ReplacementDetlID"))) _ReplacementDetlID = reader.GetInt64(reader.GetOrdinal("ReplacementDetlID"));
			if (!reader.IsDBNull(reader.GetOrdinal("RepPassportDetlID"))) _RepPassportDetlID = reader.GetInt64(reader.GetOrdinal("RepPassportDetlID"));
			if (!reader.IsDBNull(reader.GetOrdinal("newName1"))) _newName1 = reader.GetString(reader.GetOrdinal("newName1"));
			if (!reader.IsDBNull(reader.GetOrdinal("newName2"))) _newName2 = reader.GetString(reader.GetOrdinal("newName2"));
			if (!reader.IsDBNull(reader.GetOrdinal("newFullName"))) _newFullName = reader.GetString(reader.GetOrdinal("newFullName"));
			if (!reader.IsDBNull(reader.GetOrdinal("newPassportno"))) _newPassportno = reader.GetString(reader.GetOrdinal("newPassportno"));
			if (!reader.IsDBNull(reader.GetOrdinal("NewHrBasicID"))) _NewHrBasicID = reader.GetInt64(reader.GetOrdinal("NewHrBasicID"));
			if (!reader.IsDBNull(reader.GetOrdinal("NewHrSvcID"))) _NewHrSvcID = reader.GetInt64(reader.GetOrdinal("NewHrSvcID"));
			if (!reader.IsDBNull(reader.GetOrdinal("LetterStatus"))) _LetterStatus = reader.GetString(reader.GetOrdinal("LetterStatus"));
			if (!reader.IsDBNull(reader.GetOrdinal("MilNoBD"))) _MilNoBD = reader.GetString(reader.GetOrdinal("MilNoBD"));
			if (!reader.IsDBNull(reader.GetOrdinal("RankName"))) _RankName = reader.GetString(reader.GetOrdinal("RankName"));
			if (!reader.IsDBNull(reader.GetOrdinal("TradeName"))) _TradeName = reader.GetString(reader.GetOrdinal("TradeName"));
			if (!reader.IsDBNull(reader.GetOrdinal("ArmsName"))) _ArmsName = reader.GetString(reader.GetOrdinal("ArmsName"));
			if (!reader.IsDBNull(reader.GetOrdinal("TOD"))) _TOD = reader.GetDateTime(reader.GetOrdinal("TOD"));
			if (!reader.IsDBNull(reader.GetOrdinal("PassportRecvDate"))) _PassportRecvDate = reader.GetDateTime(reader.GetOrdinal("PassportRecvDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("PassportLetterNo"))) _PassportLetterNo = reader.GetString(reader.GetOrdinal("PassportLetterNo"));
			if (!reader.IsDBNull(reader.GetOrdinal("PassportLetterDate"))) _PassportLetterDate = reader.GetDateTime(reader.GetOrdinal("PassportLetterDate"));
			if (!reader.IsDBNull(reader.GetOrdinal("GroupName"))) _GroupName = reader.GetString(reader.GetOrdinal("GroupName"));
		}
	}
}

