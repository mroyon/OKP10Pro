using System;
            using System.Runtime.Serialization;
            using System.Data;
            using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects.BusinessDataObjectsPartials
{

[Serializable]
	public class rpt_GetCuttingInfo_ExtEntity:  BaseEntity
	{
		protected Int64? _okpid;
		protected Int64? _monthid;
		protected Int64? _year;
		protected DateTime? _processdate;
		protected Boolean? _isreviewed;
		protected DateTime? _reviewdate;
		protected Int64? _reviewedby;
		protected String _reviewremarks;
		protected Boolean? _isapproved;
		protected DateTime? _approvedate;
		protected Int64? _approveby;
		protected String _approveremarks;
		protected String _okpname;
		protected String _month;
		protected Int64? _milnokw;
		protected String _passportno;
		protected DateTime? _joindatekw;
		protected DateTime? _expectedretiredatekw;
		protected Int64? _groupid;
		protected String _GroupName;
		protected String _rankname;
		protected String _ranktype;
		protected String _fullname;
		protected Int64? _civilid;
		protected Decimal? _prevbalgovtcutting;
		protected Decimal? _BasicSalary;
		protected Decimal? _govtcutting;
		protected String _remarks;
		protected Boolean? _ispaid;
		protected DateTime? _paiddate;
		protected String _unpaidremarks;
		protected Int64? _CuttingInfoDetlID;
		protected String _itemname;
		
		protected Int64? _cuttingid;
		

		[DataMember]
		public Int64? okpid
		{
			get { return _okpid; }
			set {_okpid=value; }
		}
		[DataMember]
		public Int64? monthid
		{
			get { return _monthid; }
			set {_monthid=value; }
		}
		[DataMember]
		public Int64? year
		{
			get { return _year; }
			set {_year=value; }
		}
		[DataMember]
		public DateTime? processdate
		{
			get { return _processdate; }
			set {_processdate=value; }
		}
		[DataMember]
		public Boolean? isreviewed
		{
			get { return _isreviewed; }
			set {_isreviewed=value; }
		}
		[DataMember]
		public DateTime? reviewdate
		{
			get { return _reviewdate; }
			set {_reviewdate=value; }
		}
		[DataMember]
		public Int64? reviewedby
		{
			get { return _reviewedby; }
			set {_reviewedby=value; }
		}
		[DataMember]
		public String reviewremarks
		{
			get { return _reviewremarks; }
			set {_reviewremarks=value; }
		}
		[DataMember]
		public Boolean? isapproved
		{
			get { return _isapproved; }
			set {_isapproved=value; }
		}
		[DataMember]
		public DateTime? approvedate
		{
			get { return _approvedate; }
			set {_approvedate=value; }
		}
		[DataMember]
		public Int64? approveby
		{
			get { return _approveby; }
			set {_approveby=value; }
		}
		[DataMember]
		public String approveremarks
		{
			get { return _approveremarks; }
			set {_approveremarks=value; }
		}
		[DataMember]
		public String okpname
		{
			get { return _okpname; }
			set {_okpname=value; }
		}
		[DataMember]
		public String month
		{
			get { return _month; }
			set {_month=value; }
		}
		[DataMember]
		public Int64? milnokw
		{
			get { return _milnokw; }
			set {_milnokw=value; }
		}
		[DataMember]
		public String passportno
		{
			get { return _passportno; }
			set {_passportno=value; }
		}
		[DataMember]
		public DateTime? joindatekw
		{
			get { return _joindatekw; }
			set {_joindatekw=value; }
		}
		[DataMember]
		public DateTime? expectedretiredatekw
		{
			get { return _expectedretiredatekw; }
			set {_expectedretiredatekw=value; }
		}
		[DataMember]
		public Int64? groupid
		{
			get { return _groupid; }
			set {_groupid=value; }
		}
		[DataMember]
		public String GroupName
		{
			get { return _GroupName; }
			set {_GroupName=value; }
		}
		[DataMember]
		public String rankname
		{
			get { return _rankname; }
			set {_rankname=value; }
		}
		[DataMember]
		public String ranktype
		{
			get { return _ranktype; }
			set {_ranktype=value; }
		}
		[DataMember]
		public String fullname
		{
			get { return _fullname; }
			set {_fullname=value; }
		}
		[DataMember]
		public Int64? civilid
		{
			get { return _civilid; }
			set {_civilid=value; }
		}
		[DataMember]
		public Decimal? prevbalgovtcutting
		{
			get { return _prevbalgovtcutting; }
			set {_prevbalgovtcutting=value; }
		}
		[DataMember]
		public Decimal? BasicSalary
		{
			get { return _BasicSalary; }
			set {_BasicSalary=value; }
		}
		[DataMember]
		public Decimal? govtcutting
		{
			get { return _govtcutting; }
			set {_govtcutting=value; }
		}
		[DataMember]
		public String remarks
		{
			get { return _remarks; }
			set {_remarks=value; }
		}
		[DataMember]
		public Boolean? ispaid
		{
			get { return _ispaid; }
			set {_ispaid=value; }
		}
		[DataMember]
		public DateTime? paiddate
		{
			get { return _paiddate; }
			set {_paiddate=value; }
		}
		[DataMember]
		public String unpaidremarks
		{
			get { return _unpaidremarks; }
			set {_unpaidremarks=value; }
		}
		[DataMember]
		public Int64? CuttingInfoDetlID
		{
			get { return _CuttingInfoDetlID; }
			set {_CuttingInfoDetlID=value; }
		}
		[DataMember]
		public String itemname
		{
			get { return _itemname; }
			set {_itemname=value; }
		}
		
		[DataMember]
		public Int64? cuttingid
		{
			get { return _cuttingid; }
			set {_cuttingid=value; }
		}
		
		public rpt_GetCuttingInfo_ExtEntity():base()
		{

		}

		public rpt_GetCuttingInfo_ExtEntity(IDataReader reader)
		{
			this.LoadFromReader(reader);
		}

		protected void LoadFromReader(IDataReader reader)
		{
			if (!reader.IsDBNull(reader.GetOrdinal("okpid"))) _okpid = reader.GetInt64(reader.GetOrdinal("okpid"));
			if (!reader.IsDBNull(reader.GetOrdinal("monthid"))) _monthid = reader.GetInt64(reader.GetOrdinal("monthid"));
			if (!reader.IsDBNull(reader.GetOrdinal("year"))) _year = reader.GetInt64(reader.GetOrdinal("year"));
			if (!reader.IsDBNull(reader.GetOrdinal("processdate"))) _processdate = reader.GetDateTime(reader.GetOrdinal("processdate"));
			if (!reader.IsDBNull(reader.GetOrdinal("isreviewed"))) _isreviewed = reader.GetBoolean(reader.GetOrdinal("isreviewed"));
			if (!reader.IsDBNull(reader.GetOrdinal("reviewdate"))) _reviewdate = reader.GetDateTime(reader.GetOrdinal("reviewdate"));
			if (!reader.IsDBNull(reader.GetOrdinal("reviewedby"))) _reviewedby = reader.GetInt64(reader.GetOrdinal("reviewedby"));
			if (!reader.IsDBNull(reader.GetOrdinal("reviewremarks"))) _reviewremarks = reader.GetString(reader.GetOrdinal("reviewremarks"));
			if (!reader.IsDBNull(reader.GetOrdinal("isapproved"))) _isapproved = reader.GetBoolean(reader.GetOrdinal("isapproved"));
			if (!reader.IsDBNull(reader.GetOrdinal("approvedate"))) _approvedate = reader.GetDateTime(reader.GetOrdinal("approvedate"));
			if (!reader.IsDBNull(reader.GetOrdinal("approveby"))) _approveby = reader.GetInt64(reader.GetOrdinal("approveby"));
			if (!reader.IsDBNull(reader.GetOrdinal("approveremarks"))) _approveremarks = reader.GetString(reader.GetOrdinal("approveremarks"));
			if (!reader.IsDBNull(reader.GetOrdinal("okpname"))) _okpname = reader.GetString(reader.GetOrdinal("okpname"));
			if (!reader.IsDBNull(reader.GetOrdinal("month"))) _month = reader.GetString(reader.GetOrdinal("month"));
			if (!reader.IsDBNull(reader.GetOrdinal("milnokw"))) _milnokw = reader.GetInt64(reader.GetOrdinal("milnokw"));
			if (!reader.IsDBNull(reader.GetOrdinal("passportno"))) _passportno = reader.GetString(reader.GetOrdinal("passportno"));
			if (!reader.IsDBNull(reader.GetOrdinal("joindatekw"))) _joindatekw = reader.GetDateTime(reader.GetOrdinal("joindatekw"));
			if (!reader.IsDBNull(reader.GetOrdinal("expectedretiredatekw"))) _expectedretiredatekw = reader.GetDateTime(reader.GetOrdinal("expectedretiredatekw"));
			if (!reader.IsDBNull(reader.GetOrdinal("groupid"))) _groupid = reader.GetInt64(reader.GetOrdinal("groupid"));
			if (!reader.IsDBNull(reader.GetOrdinal("GroupName"))) _GroupName = reader.GetString(reader.GetOrdinal("GroupName"));
			if (!reader.IsDBNull(reader.GetOrdinal("rankname"))) _rankname = reader.GetString(reader.GetOrdinal("rankname"));
			if (!reader.IsDBNull(reader.GetOrdinal("ranktype"))) _ranktype = reader.GetString(reader.GetOrdinal("ranktype"));
			if (!reader.IsDBNull(reader.GetOrdinal("fullname"))) _fullname = reader.GetString(reader.GetOrdinal("fullname"));
			if (!reader.IsDBNull(reader.GetOrdinal("civilid"))) _civilid = reader.GetInt64(reader.GetOrdinal("civilid"));
			if (!reader.IsDBNull(reader.GetOrdinal("prevbalgovtcutting"))) _prevbalgovtcutting = reader.GetDecimal(reader.GetOrdinal("prevbalgovtcutting"));
			if (!reader.IsDBNull(reader.GetOrdinal("BasicSalary"))) _BasicSalary = reader.GetDecimal(reader.GetOrdinal("BasicSalary"));
			if (!reader.IsDBNull(reader.GetOrdinal("govtcutting"))) _govtcutting = reader.GetDecimal(reader.GetOrdinal("govtcutting"));
			if (!reader.IsDBNull(reader.GetOrdinal("remarks"))) _remarks = reader.GetString(reader.GetOrdinal("remarks"));
			if (!reader.IsDBNull(reader.GetOrdinal("ispaid"))) _ispaid = reader.GetBoolean(reader.GetOrdinal("ispaid"));
			if (!reader.IsDBNull(reader.GetOrdinal("paiddate"))) _paiddate = reader.GetDateTime(reader.GetOrdinal("paiddate"));
			if (!reader.IsDBNull(reader.GetOrdinal("unpaidremarks"))) _unpaidremarks = reader.GetString(reader.GetOrdinal("unpaidremarks"));
			if (!reader.IsDBNull(reader.GetOrdinal("CuttingInfoDetlID"))) _CuttingInfoDetlID = reader.GetInt64(reader.GetOrdinal("CuttingInfoDetlID"));
			if (!reader.IsDBNull(reader.GetOrdinal("itemname"))) _itemname = reader.GetString(reader.GetOrdinal("itemname"));
			
		}
	}
}

