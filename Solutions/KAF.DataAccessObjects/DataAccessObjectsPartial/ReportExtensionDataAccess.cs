using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IDataAccessObjects.IDataAccessObjectsPartial;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using System.Data.Common;
using System.Data;
using KAF.AppConfiguration.Configuration;
using KAF.BusinessDataObjects;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace KAF.DataAccessObjects.DataAccessObjectsPartial
{
    internal sealed class ReportExtensionDataAccess : BaseDataAccess, IReportExtensionDataAccess
    {
        #region Constructors
        private string ClassName = "ReportExtensionDataAccess";
        public ReportExtensionDataAccess(Context context)
            : base(context)
        {
        }

        private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        #endregion


        IList<KAF_GetReplacementListByREplacementIDEntity> IReportExtensionDataAccess.Get_KAF_GetReplacementListByREplacementID(KAF_GetReplacementListByREplacementIDEntity KAF_GetMilitaryPersonalInfoEntity)
        {
            IList<KAF_GetReplacementListByREplacementIDEntity> itemList = new List<KAF_GetReplacementListByREplacementIDEntity>();
            try
            {
                const string SP = "KAF_GetReplacementListByREplacementID";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    if (KAF_GetMilitaryPersonalInfoEntity.milnokw.HasValue)
                        Database.AddInParameter(cmd, "@MilNoKW", DbType.Int64, KAF_GetMilitaryPersonalInfoEntity.milnokw);

                    if (KAF_GetMilitaryPersonalInfoEntity.ReplacementID.HasValue)
                        Database.AddInParameter(cmd, "@ReplacementID", DbType.Int64, KAF_GetMilitaryPersonalInfoEntity.ReplacementID);

                    if (KAF_GetMilitaryPersonalInfoEntity.RepPassportID.HasValue)
                        Database.AddInParameter(cmd, "@RepPassportID", DbType.Int64, KAF_GetMilitaryPersonalInfoEntity.RepPassportID);


                    Database.AddInParameter(cmd, "@IsAll", DbType.Int64, KAF_GetMilitaryPersonalInfoEntity.IsAll);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new KAF_GetReplacementListByREplacementIDEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_KAF_GetMilitaryPersonalInfo"));
            }
            return itemList;
        }

        IList<KAF_GetReplacementPassportListByRepPassportIDEntity> IReportExtensionDataAccess.Get_KAF_GetReplacementPassportListByRepPassportID(KAF_GetReplacementPassportListByRepPassportIDEntity KAF_GetReplacementPassportListByRepPassportIDEntity)
        {
            IList<KAF_GetReplacementPassportListByRepPassportIDEntity> itemList = new List<KAF_GetReplacementPassportListByRepPassportIDEntity>();
            try
            {
                const string SP = "KAF_GetReplacementPassportListByRepPassportID";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    if (KAF_GetReplacementPassportListByRepPassportIDEntity.ReplacementID.HasValue)
                        Database.AddInParameter(cmd, "@ReplacementID", DbType.Int64, KAF_GetReplacementPassportListByRepPassportIDEntity.ReplacementID);
                    if (KAF_GetReplacementPassportListByRepPassportIDEntity.RepPassportID.HasValue)
                        Database.AddInParameter(cmd, "@RepPassportID", DbType.Int64, KAF_GetReplacementPassportListByRepPassportIDEntity.RepPassportID);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new KAF_GetReplacementPassportListByRepPassportIDEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_KAF_GetReplacementPassportListByRepPassportID"));
            }
            return itemList;
        }

        IList<KAF_GetVisaDemandListByVisaDemandIDEntity> IReportExtensionDataAccess.Get_KAF_GetVisaDemandListByVisaDemandID(KAF_GetVisaDemandListByVisaDemandIDEntity KAF_GetVisaDemandListByVisaDemandIDEntity)
        {
            IList<KAF_GetVisaDemandListByVisaDemandIDEntity> itemList = new List<KAF_GetVisaDemandListByVisaDemandIDEntity>();
            try
            {
                const string SP = "KAF_GetVisaDemandListByVisaDemandID";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@VisaDemandID", DbType.Int64, KAF_GetVisaDemandListByVisaDemandIDEntity.VisaDemandID);
                    if (KAF_GetVisaDemandListByVisaDemandIDEntity.VisaIssueID.HasValue)
                        Database.AddInParameter(cmd, "@VisaIssueID", DbType.Int64, KAF_GetVisaDemandListByVisaDemandIDEntity.VisaIssueID);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new KAF_GetVisaDemandListByVisaDemandIDEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_KAF_GetVisaDemandListByVisaDemandID"));
            }
            return itemList;
        }

        IList<KAF_GetRepPassportListByRepPassportIDEntity> IReportExtensionDataAccess.Get_KAF_GetRepPassportListByRepPassportID(KAF_GetRepPassportListByRepPassportIDEntity KAF_GetRepPassportListByRepPassportIDEntity)
        {
            IList<KAF_GetRepPassportListByRepPassportIDEntity> itemList = new List<KAF_GetRepPassportListByRepPassportIDEntity>();
            try
            {
                const string SP = "KAF_GetRepPassportListByRepPassportID";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    if (KAF_GetRepPassportListByRepPassportIDEntity.RepPassportID.HasValue)
                        Database.AddInParameter(cmd, "@RepPassportID", DbType.Int64, KAF_GetRepPassportListByRepPassportIDEntity.RepPassportID);
                    if (KAF_GetRepPassportListByRepPassportIDEntity.DemandID.HasValue)
                        Database.AddInParameter(cmd, "@DemandID", DbType.Int64, KAF_GetRepPassportListByRepPassportIDEntity.DemandID);

                    Database.AddInParameter(cmd, "@DemandTypeID", DbType.Int64, KAF_GetRepPassportListByRepPassportIDEntity.DemandTypeID);

                    Database.AddInParameter(cmd, "@IsAll", DbType.Int64, KAF_GetRepPassportListByRepPassportIDEntity.IsAll);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new KAF_GetRepPassportListByRepPassportIDEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_KAF_GetRepPassportListByRepPassportID"));
            }
            return itemList;
        }

        IList<KAF_GetDemandListByDemandIDEntity> IReportExtensionDataAccess.Get_KAF_GetDemandListByDemandID(KAF_GetDemandListByDemandIDEntity KAF_GetDemandListByDemandIDEntity)
        {
            IList<KAF_GetDemandListByDemandIDEntity> itemList = new List<KAF_GetDemandListByDemandIDEntity>();
            try
            {
                const string SP = "KAF_GetDemandListByDemandID";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@VisaIssueID", DbType.Int64, KAF_GetDemandListByDemandIDEntity.VisaIssueID);
                    Database.AddInParameter(cmd, "@DemandID", DbType.Int64, KAF_GetDemandListByDemandIDEntity.DemandID);
                    Database.AddInParameter(cmd, "@IsAll", DbType.Int64, KAF_GetDemandListByDemandIDEntity.IsAll);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new KAF_GetDemandListByDemandIDEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_KAF_GetDemandListByDemandID"));
            }
            return itemList;
        }

        IList<KAF_GetPTAReceivedListByPTAReceiveIDEntity> IReportExtensionDataAccess.Get_KAF_GetPTAReceivedListByPTAReceiveID(KAF_GetPTAReceivedListByPTAReceiveIDEntity KAF_GetPTAReceivedListByPTAReceiveIDEntity)
        {
            IList<KAF_GetPTAReceivedListByPTAReceiveIDEntity> itemList = new List<KAF_GetPTAReceivedListByPTAReceiveIDEntity>();
            try
            {
                const string SP = "KAF_GetPTAReceivedListByPTAReceiveID";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@PTIID", DbType.Int64, KAF_GetPTAReceivedListByPTAReceiveIDEntity.PTIID);
                    Database.AddInParameter(cmd, "@FlightID", DbType.Int64, KAF_GetPTAReceivedListByPTAReceiveIDEntity.FlightID);
                    Database.AddInParameter(cmd, "@IsAll", DbType.Int64, KAF_GetPTAReceivedListByPTAReceiveIDEntity.IsAll);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new KAF_GetPTAReceivedListByPTAReceiveIDEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_KAF_GetPTAReceivedListByPTAReceiveID"));
            }
            return itemList;
        }

        IList<KAF_GetVisaIssueListByVisaIssueIDEntity> IReportExtensionDataAccess.Get_KAF_GetVisaIssueListByVisaIssueID(KAF_GetVisaIssueListByVisaIssueIDEntity KAF_GetVisaIssueListByVisaIssueIDEntity)
        {
            IList<KAF_GetVisaIssueListByVisaIssueIDEntity> itemList = new List<KAF_GetVisaIssueListByVisaIssueIDEntity>();
            try
            {
                const string SP = "KAF_GetVisaIssueListByVisaIssueID";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@VisaIssueID", DbType.Int64, KAF_GetVisaIssueListByVisaIssueIDEntity.VisaIssueID);
                    Database.AddInParameter(cmd, "@VisaSentID", DbType.Int64, KAF_GetVisaIssueListByVisaIssueIDEntity.VisaSentID);
                    Database.AddInParameter(cmd, "@IsAll", DbType.Int64, KAF_GetVisaIssueListByVisaIssueIDEntity.IsAll);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new KAF_GetVisaIssueListByVisaIssueIDEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_KAF_GetVisaIssueListByVisaIssueID"));
            }
            return itemList;
        }

        IList<KAF_GetVisaSentListByVisaSentIDEntity> IReportExtensionDataAccess.Get_KAF_GetVisaSentListByVisaSentID(KAF_GetVisaSentListByVisaSentIDEntity KAF_GetVisaSentListByVisaSentIDEntity)
        {
            IList<KAF_GetVisaSentListByVisaSentIDEntity> itemList = new List<KAF_GetVisaSentListByVisaSentIDEntity>();
            try
            {
                const string SP = "KAF_GetVisaSentListByVisaSentID";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@PTIID", DbType.Int64, KAF_GetVisaSentListByVisaSentIDEntity.PTIID);
                    Database.AddInParameter(cmd, "@VisaSentID", DbType.Int64, KAF_GetVisaSentListByVisaSentIDEntity.VisaSentID);
                    Database.AddInParameter(cmd, "@IsAll", DbType.Int64, KAF_GetVisaSentListByVisaSentIDEntity.IsAll);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new KAF_GetVisaSentListByVisaSentIDEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_KAF_GetVisaSentListByVisaSentID"));
            }
            return itemList;
        }

        IList<KAF_GetPTADemandListByPTADemandIDEntity> IReportExtensionDataAccess.Get_KAF_GetPTADemandListByPTADemandID(KAF_GetPTADemandListByPTADemandIDEntity KAF_GetPTADemandListByPTADemandIDEntity)
        {
            IList<KAF_GetPTADemandListByPTADemandIDEntity> itemList = new List<KAF_GetPTADemandListByPTADemandIDEntity>();
            try
            {
                const string SP = "KAF_GetPTADemandListByPTADemandID";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@PTIDemandID", DbType.Int64, KAF_GetPTADemandListByPTADemandIDEntity.PTADemandID);
                    Database.AddInParameter(cmd, "@PTARecivedID", DbType.Int64, KAF_GetPTADemandListByPTADemandIDEntity.PTIID);
                    Database.AddInParameter(cmd, "@IsAll", DbType.Int64, KAF_GetPTADemandListByPTADemandIDEntity.IsAll);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new KAF_GetPTADemandListByPTADemandIDEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_KAF_GetPTADemandListByPTADemandID"));
            }
            return itemList;
        }

        IList<KAF_GetFlightListByFlightIDEntity> IReportExtensionDataAccess.Get_KAF_GetFlightListByFlightID(KAF_GetFlightListByFlightIDEntity KAF_GetFlightListByFlightIDEntity)
        {
            IList<KAF_GetFlightListByFlightIDEntity> itemList = new List<KAF_GetFlightListByFlightIDEntity>();
            try
            {
                const string SP = "KAF_GetFlightListByFlightID";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    if (KAF_GetFlightListByFlightIDEntity.ArrivalID.HasValue)
                        Database.AddInParameter(cmd, "@ArrivalID", DbType.Int64, KAF_GetFlightListByFlightIDEntity.ArrivalID);

                    if (KAF_GetFlightListByFlightIDEntity.FlightID.HasValue)
                        Database.AddInParameter(cmd, "@FlightID", DbType.Int64, KAF_GetFlightListByFlightIDEntity.FlightID);

                    Database.AddInParameter(cmd, "@IsAll", DbType.Int64, KAF_GetFlightListByFlightIDEntity.IsAll);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new KAF_GetFlightListByFlightIDEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_KAF_GetFlightListByFlightID"));
            }
            return itemList;
        }

        IList<KAF_GetNewDemandInfoEntity> IReportExtensionDataAccess.Get_KAF_GetNewDemandInfo(KAF_GetNewDemandInfoEntity KAF_GetNewDemandInfoEntity)
        {
            IList<KAF_GetNewDemandInfoEntity> itemList = new List<KAF_GetNewDemandInfoEntity>();
            try
            {
                const string SP = "KAF_GetNewDemandInfo";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    if (KAF_GetNewDemandInfoEntity.NewDemandID.HasValue && KAF_GetNewDemandInfoEntity.NewDemandID.Value != 0)
                    {
                        Database.AddInParameter(cmd, "@NewDemandID", DbType.Int64, KAF_GetNewDemandInfoEntity.NewDemandID.Value);
                    }

                    else
                    {
                        if (!string.IsNullOrEmpty(KAF_GetNewDemandInfoEntity.DemandLetterNo))
                            Database.AddInParameter(cmd, "@DemandLetterNo", DbType.String, KAF_GetNewDemandInfoEntity.DemandLetterNo);

                    }

                    if (KAF_GetNewDemandInfoEntity.MilNoKW.HasValue && KAF_GetNewDemandInfoEntity.MilNoKW.Value != 0)
                    {
                        Database.AddInParameter(cmd, "@MilNoKW", DbType.Int64, KAF_GetNewDemandInfoEntity.MilNoKW.Value);
                    }

                    if (!string.IsNullOrEmpty(KAF_GetNewDemandInfoEntity.PassportNo))
                        Database.AddInParameter(cmd, "@PassportNo", DbType.String, KAF_GetNewDemandInfoEntity.PassportNo);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new KAF_GetNewDemandInfoEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_KAF_GetNewDemandInfo"));
            }
            return itemList;
        }

        IList<KAF_GetReplacementInfoEntity> IReportExtensionDataAccess.Get_KAF_GetReplacementInfo(KAF_GetReplacementInfoEntity KAF_GetReplacementInfoEntity)
        {
            IList<KAF_GetReplacementInfoEntity> itemList = new List<KAF_GetReplacementInfoEntity>();
            try
            {
                const string SP = "KAF_GetReplacementInfo";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    if (!string.IsNullOrEmpty(KAF_GetReplacementInfoEntity.NewPassportNo))
                        Database.AddInParameter(cmd, "@PassportNo", DbType.String, KAF_GetReplacementInfoEntity.NewPassportNo);

                    if (KAF_GetReplacementInfoEntity.ReplacementID.HasValue && KAF_GetReplacementInfoEntity.ReplacementID.Value != 0)
                        Database.AddInParameter(cmd, "@ReplacementID", DbType.Int64, KAF_GetReplacementInfoEntity.ReplacementID.Value);
                    else
                    {
                        if (!string.IsNullOrEmpty(KAF_GetReplacementInfoEntity.ReplacementLetterNo))
                            Database.AddInParameter(cmd, "@ReplacementLetterNo", DbType.String, KAF_GetReplacementInfoEntity.ReplacementLetterNo);

                    }

                    if (KAF_GetReplacementInfoEntity.MilNoKW.HasValue)
                        Database.AddInParameter(cmd, "@MilNoKW", DbType.Int64, KAF_GetReplacementInfoEntity.MilNoKW);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new KAF_GetReplacementInfoEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_KAF_GetReplacementInfo"));
            }
            return itemList;
        }

        IList<KAF_GetProfileInfoEntity> IReportExtensionDataAccess.Get_KAF_GetProfileInfo(KAF_GetProfileInfoEntity KAF_GetProfileInfoEntity)
        {
            IList<KAF_GetProfileInfoEntity> itemList = new List<KAF_GetProfileInfoEntity>();
            try
            {
                const string SP = "KAF_GetProfileInfo";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    if (!String.IsNullOrEmpty(KAF_GetProfileInfoEntity.PassportNo))
                        Database.AddInParameter(cmd, "@PassportNo", DbType.String, KAF_GetProfileInfoEntity.PassportNo);
                    if (!string.IsNullOrEmpty(KAF_GetProfileInfoEntity.MilNoBD))
                        Database.AddInParameter(cmd, "@MilNoBD", DbType.String, KAF_GetProfileInfoEntity.MilNoBD);
                    if (KAF_GetProfileInfoEntity.MilNoKW.HasValue)
                        Database.AddInParameter(cmd, "@MilNoKW", DbType.Int64, KAF_GetProfileInfoEntity.MilNoKW);

                    if (KAF_GetProfileInfoEntity.OKPID.HasValue)
                        Database.AddInParameter(cmd, "@OKPID", DbType.Int64, KAF_GetProfileInfoEntity.OKPID);

                    if (!String.IsNullOrEmpty(KAF_GetProfileInfoEntity.strStartus))
                        Database.AddInParameter(cmd, "@StrStatus", DbType.String, KAF_GetProfileInfoEntity.strStartus);

                    if (!String.IsNullOrEmpty(KAF_GetProfileInfoEntity.BasePath))
                        Database.AddInParameter(cmd, "@BasePath", DbType.String, KAF_GetProfileInfoEntity.BasePath);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new KAF_GetProfileInfoEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_KAF_GetProfileInfo"));
            }
            return itemList;
        }

        long IReportExtensionDataAccess.Get_KAFProcess_UpdateLetterStatus(KAFProcess_UpdateLetterStatusEntity KAFProcess_UpdateLetterStatusEntity)
        {
            long returnCode = -99;
            try
            {
                const string SP = "KAFProcess_UpdateLetterStatus";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@LetterID", DbType.Int64, KAFProcess_UpdateLetterStatusEntity.LetterID);
                    Database.AddInParameter(cmd, "@LetterType", DbType.Int64, KAFProcess_UpdateLetterStatusEntity.LetterType);
                    Database.AddInParameter(cmd, "@LetterStatus", DbType.Int64, KAFProcess_UpdateLetterStatusEntity.LetterStatus);
                    Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, KAFProcess_UpdateLetterStatusEntity.Ex_Date1);
                    Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, KAFProcess_UpdateLetterStatusEntity.Ex_Date2);
                    Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, KAFProcess_UpdateLetterStatusEntity.Ex_Nvarchar1);
                    Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, KAFProcess_UpdateLetterStatusEntity.Ex_Nvarchar2);
                    Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, KAFProcess_UpdateLetterStatusEntity.Ex_Bigint1);
                    Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, KAFProcess_UpdateLetterStatusEntity.Ex_Bigint2);
                    Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, KAFProcess_UpdateLetterStatusEntity.Ex_Decimal1);
                    Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, KAFProcess_UpdateLetterStatusEntity.Ex_Decimal2);
                    Database.AddInParameter(cmd, "@RETURN_KEY", DbType.Int64, KAFProcess_UpdateLetterStatusEntity.RETURN_KEY);
                    Database.AddInParameter(cmd, "@CreatedBy", DbType.Int64, KAFProcess_UpdateLetterStatusEntity.CreatedBy);
                    Database.AddInParameter(cmd, "@CreatedByUserName", DbType.String, KAFProcess_UpdateLetterStatusEntity.CreatedByUserName);
                    Database.AddInParameter(cmd, "@UpdatedBy", DbType.Int64, KAFProcess_UpdateLetterStatusEntity.UpdatedBy);
                    Database.AddInParameter(cmd, "@UpdatedByUserName", DbType.String, KAFProcess_UpdateLetterStatusEntity.UpdatedByUserName);
                    Database.AddInParameter(cmd, "@CreatedDate", DbType.DateTime, KAFProcess_UpdateLetterStatusEntity.CreatedDate);
                    Database.AddInParameter(cmd, "@UpdatedDate", DbType.DateTime, KAFProcess_UpdateLetterStatusEntity.UpdatedDate);
                    Database.AddInParameter(cmd, "@FormID", DbType.Int64, KAFProcess_UpdateLetterStatusEntity.FormID);
                    Database.AddInParameter(cmd, "@IPAddress", DbType.String, KAFProcess_UpdateLetterStatusEntity.IPAddress);
                    Database.AddInParameter(cmd, "@TransID", DbType.String, KAFProcess_UpdateLetterStatusEntity.TransID);
                    Database.AddInParameter(cmd, "@UserOrganizationKey", DbType.Int64, KAFProcess_UpdateLetterStatusEntity.UserOrganizationKey);
                    Database.AddInParameter(cmd, "@UserEntityKey", DbType.Int64, KAFProcess_UpdateLetterStatusEntity.UserEntityKey);
                    Database.AddInParameter(cmd, "@Ts", DbType.Int64, KAFProcess_UpdateLetterStatusEntity.Ts);
                    try
                    {
                        returnCode = Database.ExecuteNonQuery(cmd);
                    }
                    catch (Exception ex)
                    {
                        throw GetDataAccessException(ex, SourceOfException("Ihr_flightinfoDataAccess.Deletehr_flightinfo"));
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_KAFProcess_UpdateLetterStatus"));
            }
            return returnCode;
        }


        public long KAFProcess_UpdateLetterStatus(Database db, DbTransaction transaction, KAFProcess_UpdateLetterStatusEntity KAFProcess_UpdateLetterStatusEntity)
        {
            long returnCode = -99;
            try
            {
                const string SP = "KAFProcess_UpdateLetterStatus";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    db.AddInParameter(cmd, "@LetterID", DbType.Int64, KAFProcess_UpdateLetterStatusEntity.LetterID);
                    db.AddInParameter(cmd, "@LetterType", DbType.Int64, KAFProcess_UpdateLetterStatusEntity.LetterType);
                    db.AddInParameter(cmd, "@LetterStatus", DbType.Int64, KAFProcess_UpdateLetterStatusEntity.LetterStatus);

                    try
                    {
                        returnCode = db.ExecuteNonQuery(cmd, transaction);
                    }
                    catch (Exception ex)
                    {
                        throw GetDataAccessException(ex, SourceOfException("Ihr_flightinfoDataAccess.Deletehr_flightinfo"));
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_KAFProcess_UpdateLetterStatus"));
            }
            return returnCode;
        }

        IList<hr_flightcancelinfo_GAPgListView_ExtEntity> IReportExtensionDataAccess.Get_hr_flightcancelinfo_GAPgListView_Ext(hr_flightcancelinfo_GAPgListView_ExtEntity hr_flightcancelinfo_GAPgListView_ExtEntity)
        {
            IList<hr_flightcancelinfo_GAPgListView_ExtEntity> itemList = new List<hr_flightcancelinfo_GAPgListView_ExtEntity>();
            try
            {
                const string SP = "hr_flightcancelinfo_GAPgListView_Ext";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    if (!string.IsNullOrEmpty(hr_flightcancelinfo_GAPgListView_ExtEntity.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, hr_flightcancelinfo_GAPgListView_ExtEntity.strCommonSerachParam);


                    if (!string.IsNullOrEmpty(hr_flightcancelinfo_GAPgListView_ExtEntity.SortExpression))
                        Database.AddInParameter(cmd, "@SortExpression", DbType.String, hr_flightcancelinfo_GAPgListView_ExtEntity.SortExpression);

                    Database.AddInParameter(cmd, "@CurrentPage", DbType.Int32, hr_flightcancelinfo_GAPgListView_ExtEntity.CurrentPage);
                    Database.AddInParameter(cmd, "@PageSize", DbType.Int32, hr_flightcancelinfo_GAPgListView_ExtEntity.PageSize);
                    Database.AddOutParameter(cmd, "@TotalRecord", DbType.Int64, 8);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new hr_flightcancelinfo_GAPgListView_ExtEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_hr_flightcancelinfo_GAPgListView_Ext"));
            }
            return itemList;
        }

        IList<hr_flightinfodetlEntity> IReportExtensionDataAccess.Get_hr_flightinfodetl_GAPgListView_Select2(hr_flightinfodetlEntity hr_flightinfodetlEntity)
        {
            IList<hr_flightinfodetlEntity> itemList = new List<hr_flightinfodetlEntity>();
            try
            {
                const string SP = "hr_flightinfodetl_GAPgListView_Select2";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    if (!string.IsNullOrEmpty(hr_flightinfodetlEntity.cancelletterno))
                        Database.AddInParameter(cmd, "@cancelletterno", DbType.String, hr_flightinfodetlEntity.cancelletterno);

                    if (hr_flightinfodetlEntity.cancelletterdate.HasValue)
                        Database.AddInParameter(cmd, "@CancelLetterDate", DbType.DateTime, hr_flightinfodetlEntity.cancelletterdate);

                    Database.AddInParameter(cmd, "@CurrentPage", DbType.Int32, hr_flightinfodetlEntity.CurrentPage);
                    Database.AddInParameter(cmd, "@PageSize", DbType.Int32, hr_flightinfodetlEntity.PageSize);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new hr_flightinfodetlEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }

            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_hr_flightinfodetl_GAPgListView_Select2"));
            }
            return itemList;
        }



        IList<rpt_GetReplacementPassportInfoEntity> IReportExtensionDataAccess.Get_rpt_GetReplacementPassportInfo(rpt_GetReplacementPassportInfoEntity rpt_GetReplacementPassportInfoEntity)
        {
            IList<rpt_GetReplacementPassportInfoEntity> itemList = new List<rpt_GetReplacementPassportInfoEntity>();
            try
            {
                const string SP = "rpt_GetReplacementPassportInfo";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@RepPassportID", DbType.Int64, rpt_GetReplacementPassportInfoEntity.RepPassportID);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new rpt_GetReplacementPassportInfoEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_rpt_GetReplacementPassportInfo"));
            }
            return itemList;
        }

        IList<rpt_issueofvisaandptaEntity> IReportExtensionDataAccess.Get_rpt_issueofvisaandpta(rpt_issueofvisaandptaEntity rpt_issueofvisaandptaEntity)
        {
            IList<rpt_issueofvisaandptaEntity> itemList = new List<rpt_issueofvisaandptaEntity>();
            try
            {
                const string SP = "rpt_issueofvisaandpta";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@VisaIssueID", DbType.Int64, rpt_issueofvisaandptaEntity.VisaIssueID);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new rpt_issueofvisaandptaEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_rpt_issueofvisaandpta"));
            }
            return itemList;
        }

        IList<rpt_visareceivedpersonnelEntity> IReportExtensionDataAccess.Get_rpt_visareceivedpersonnel(rpt_visareceivedpersonnelEntity rpt_visareceivedpersonnelEntity)
        {
            IList<rpt_visareceivedpersonnelEntity> itemList = new List<rpt_visareceivedpersonnelEntity>();
            try
            {
                const string SP = "rpt_visareceivedpersonnel";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@VisaSentID", DbType.Int64, rpt_visareceivedpersonnelEntity.VisaSentID);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new rpt_visareceivedpersonnelEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_rpt_visareceivedpersonnel"));
            }
            return itemList;
        }

        IList<rpt_newdemanddetailsEntity> IReportExtensionDataAccess.Get_rpt_newdemanddetails(rpt_newdemanddetailsEntity rpt_newdemanddetailsEntity)
        {
            IList<rpt_newdemanddetailsEntity> itemList = new List<rpt_newdemanddetailsEntity>();
            try
            {
                const string SP = "rpt_newdemanddetails";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@NewDemandID", DbType.Int64, rpt_newdemanddetailsEntity.NewDemandID);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new rpt_newdemanddetailsEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_rpt_newdemanddetails"));
            }
            return itemList;
        }

        IList<rpt_arrivalreportEntity> IReportExtensionDataAccess.Get_rpt_arrivalreport(rpt_arrivalreportEntity rpt_arrivalreportEntity)
        {
            IList<rpt_arrivalreportEntity> itemList = new List<rpt_arrivalreportEntity>();
            try
            {
                const string SP = "rpt_arrivalreport";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@ArrivalID", DbType.Int64, rpt_arrivalreportEntity.ArrivalID);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new rpt_arrivalreportEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_rpt_arrivalreport"));
            }
            return itemList;
        }

        IList<rpt_ptareceivedwithflightinfoEntity> IReportExtensionDataAccess.Get_rpt_ptareceivedwithflightinfo(rpt_ptareceivedwithflightinfoEntity rpt_ptareceivedwithflightinfoEntity)
        {
            IList<rpt_ptareceivedwithflightinfoEntity> itemList = new List<rpt_ptareceivedwithflightinfoEntity>();
            try
            {
                const string SP = "rpt_ptareceivedwithflightinfo";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@PTAReceivedID", DbType.Int64, rpt_ptareceivedwithflightinfoEntity.PTAReceivedID);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new rpt_ptareceivedwithflightinfoEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_rpt_ptareceivedwithflightinfo"));
            }
            return itemList;
        }

        IList<rpt_passportheldbyspabEntity> IReportExtensionDataAccess.Get_rpt_passportheldbyspab(rpt_passportheldbyspabEntity rpt_passportheldbyspabEntity)
        {
            IList<rpt_passportheldbyspabEntity> itemList = new List<rpt_passportheldbyspabEntity>();
            try
            {
                const string SP = "rpt_passportheldbyspab";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@FromDate", DbType.DateTime, rpt_passportheldbyspabEntity.FromDate);
                    Database.AddInParameter(cmd, "@ToDate", DbType.DateTime, rpt_passportheldbyspabEntity.ToDate);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new rpt_passportheldbyspabEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_rpt_passportheldbyspab"));
            }
            return itemList;
        }

        IList<rpt_OkpSummaryOkpwiseEntity> IReportExtensionDataAccess.Get_rpt_OkpSummaryOkpwise(rpt_OkpSummaryOkpwiseEntity rpt_OkpSummaryOkpwiseEntity)
        {
            IList<rpt_OkpSummaryOkpwiseEntity> itemList = new List<rpt_OkpSummaryOkpwiseEntity>();
            try
            {
                const string SP = "rpt_OkpSummaryOkpwise";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@okpid", DbType.Int64, rpt_OkpSummaryOkpwiseEntity.okpid);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new rpt_OkpSummaryOkpwiseEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_rpt_OkpSummaryOkpwise"));
            }
            return itemList;
        }

        IList<rpt_BMCStrengthSummaryEntity> IReportExtensionDataAccess.Get_rpt_BMCStrengthSummary(rpt_BMCStrengthSummaryEntity rpt_BMCStrengthSummaryEntity)
        {
            IList<rpt_BMCStrengthSummaryEntity> itemList = new List<rpt_BMCStrengthSummaryEntity>();
            try
            {
                const string SP = "rpt_BMCStrengthSummary";


                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    if (rpt_BMCStrengthSummaryEntity.okpid.HasValue)
                        Database.AddInParameter(cmd, "@okpid", DbType.Int64, rpt_BMCStrengthSummaryEntity.okpid.Value);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new rpt_BMCStrengthSummaryEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_rpt_BMCStrengthSummary"));
            }
            return itemList;
        }

        IList<KAF_GetChildUnitsEntity> IReportExtensionDataAccess.Get_KAF_GetChildUnits(KAF_GetChildUnitsEntity KAF_GetChildUnitsEntity)
        {
            IList<KAF_GetChildUnitsEntity> itemList = new List<KAF_GetChildUnitsEntity>();
            try
            {
                const string SP = "KAF_GetChildUnits";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@EntityKey", DbType.Int64, KAF_GetChildUnitsEntity.EntityKey);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new KAF_GetChildUnitsEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_KAF_GetChildUnits"));
            }
            return itemList;
        }

        long IReportExtensionDataAccess.Get_KAF_CuttingInsert(KAF_CuttingInsertEntity KAF_CuttingInsertEntity)
        {
            IList<KAF_CuttingInsertEntity> itemList = new List<KAF_CuttingInsertEntity>();
            long ret = -1;
            try
            {
                const string SP = "KAF_CuttingInsert_Ext";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddOutParameter(cmd, "@RETURN_KEY", DbType.Int64, 8);
                    Database.AddInParameter(cmd, "@OkpID", DbType.Int64, KAF_CuttingInsertEntity.OkpID);
                    Database.AddInParameter(cmd, "@MonthID", DbType.Int64, KAF_CuttingInsertEntity.MonthID);
                    Database.AddInParameter(cmd, "@Year", DbType.Int64, KAF_CuttingInsertEntity.Year);

                    Database.AddInParameter(cmd, "@PayAllceID", DbType.Int64, KAF_CuttingInsertEntity.PayAllceID);
                    Database.AddInParameter(cmd, "@GroupID", DbType.Int64, KAF_CuttingInsertEntity.GroupID);
                    Database.AddInParameter(cmd, "@MilNoKW", DbType.Int64, KAF_CuttingInsertEntity.MilNoKW);
                    Database.AddInParameter(cmd, "@RankID", DbType.Int64, KAF_CuttingInsertEntity.RankID);

                    Database.AddInParameter(cmd, "@ProcessDate", DbType.DateTime, KAF_CuttingInsertEntity.ProcessDate);

                    Database.AddInParameter(cmd, "@PaidBy", DbType.Int64, KAF_CuttingInsertEntity.PaidBy);

                    Database.AddInParameter(cmd, "@CreatedBy", DbType.Int64, KAF_CuttingInsertEntity.BaseSecurityParam.createdby);
                    Database.AddInParameter(cmd, "@CreatedByUserName", DbType.String, KAF_CuttingInsertEntity.BaseSecurityParam.createdbyusername);
                    Database.AddInParameter(cmd, "@UpdatedBy", DbType.Int64, KAF_CuttingInsertEntity.BaseSecurityParam.updatedby);
                    Database.AddInParameter(cmd, "@UpdatedByUserName", DbType.String, KAF_CuttingInsertEntity.BaseSecurityParam.updatedbyusername);
                    Database.AddInParameter(cmd, "@CreatedDate", DbType.DateTime, KAF_CuttingInsertEntity.BaseSecurityParam.createddate.GetValueOrDefault(DateTime.Now));
                    Database.AddInParameter(cmd, "@UpdatedDate", DbType.DateTime, KAF_CuttingInsertEntity.BaseSecurityParam.updateddate.GetValueOrDefault(DateTime.Now));
                    Database.AddInParameter(cmd, "@FormID", DbType.Int64, KAF_CuttingInsertEntity.BaseSecurityParam.appformid);
                    Database.AddInParameter(cmd, "@IPAddress", DbType.String, KAF_CuttingInsertEntity.BaseSecurityParam.ipaddress);
                    Database.AddInParameter(cmd, "@TransID", DbType.String, KAF_CuttingInsertEntity.BaseSecurityParam.transid);
                    Database.AddInParameter(cmd, "@UserOrganizationKey", DbType.Int64, KAF_CuttingInsertEntity.BaseSecurityParam.userorganizationkey.GetValueOrDefault(0));
                    Database.AddInParameter(cmd, "@UserEntityKey", DbType.Int64, KAF_CuttingInsertEntity.BaseSecurityParam.userentitykey.GetValueOrDefault(0));
                    Database.AddInParameter(cmd, "@Ts", DbType.String, KAF_CuttingInsertEntity.BaseSecurityParam.ts);


                    ret = Database.ExecuteNonQuery(cmd);
                    ret = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);

                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_KAF_CuttingInsert"));
            }
            return ret;
        }

        IList<rpt_GetCuttingInfoEntity> IReportExtensionDataAccess.Get_rpt_GetCuttingInfo(rpt_GetCuttingInfoEntity rpt_GetCuttingInfoEntity)
        {
            IList<rpt_GetCuttingInfoEntity> itemList = new List<rpt_GetCuttingInfoEntity>();
            try
            {
                const string SP = "rpt_GetCuttingInfo";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    if (rpt_GetCuttingInfoEntity.cuttingid.HasValue)
                        Database.AddInParameter(cmd, "@cuttingid", DbType.Int64, rpt_GetCuttingInfoEntity.cuttingid);

                    if (rpt_GetCuttingInfoEntity.PayAllceID.HasValue)
                        Database.AddInParameter(cmd, "@PayAllceID", DbType.Int64, rpt_GetCuttingInfoEntity.PayAllceID);

                    if (rpt_GetCuttingInfoEntity.OkpID.HasValue)
                        Database.AddInParameter(cmd, "@OkpID", DbType.Int64, rpt_GetCuttingInfoEntity.OkpID);

                    if (rpt_GetCuttingInfoEntity.MonthID.HasValue)
                        Database.AddInParameter(cmd, "@MonthID", DbType.Int64, rpt_GetCuttingInfoEntity.MonthID);

                    if (rpt_GetCuttingInfoEntity.Year.HasValue)
                        Database.AddInParameter(cmd, "@Year", DbType.Int64, rpt_GetCuttingInfoEntity.Year);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new rpt_GetCuttingInfoEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_rpt_GetCuttingInfo"));
            }
            return itemList;
        }

        IList<KAF_GetRankByGroupEntity> IReportExtensionDataAccess.Get_KAF_GetRankByGroup(KAF_GetRankByGroupEntity KAF_GetRankByGroupEntity)
        {
            IList<KAF_GetRankByGroupEntity> itemList = new List<KAF_GetRankByGroupEntity>();
            try
            {
                const string SP = "KAF_GetRankByGroup";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@GroupID", DbType.Int64, KAF_GetRankByGroupEntity.GroupID);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new KAF_GetRankByGroupEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_KAF_GetRankByGroup"));
            }
            return itemList;
        }

        IList<tran_cuttinginfo_GAPgListView_ExtEntity> IReportExtensionDataAccess.Get_tran_cuttinginfo_GAPgListView_Ext(tran_cuttinginfo_GAPgListView_ExtEntity tran_cuttinginfo_GAPgListView_ExtEntity)
        {
            IList<tran_cuttinginfo_GAPgListView_ExtEntity> itemList = new List<tran_cuttinginfo_GAPgListView_ExtEntity>();
            try
            {
                const string SP = "tran_cuttinginfo_GAPgListView_Ext";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@CuttingInfoID", DbType.Int64, tran_cuttinginfo_GAPgListView_ExtEntity.CuttingInfoID);
                    Database.AddInParameter(cmd, "@PayAllceID", DbType.Int64, tran_cuttinginfo_GAPgListView_ExtEntity.PayAllceID);
                    Database.AddInParameter(cmd, "@OkpID", DbType.Int64, tran_cuttinginfo_GAPgListView_ExtEntity.OkpID);
                    Database.AddInParameter(cmd, "@MonthID", DbType.Int64, tran_cuttinginfo_GAPgListView_ExtEntity.MonthID);
                    Database.AddInParameter(cmd, "@Year", DbType.Int64, tran_cuttinginfo_GAPgListView_ExtEntity.Year);
                    Database.AddInParameter(cmd, "@ProcessDate", DbType.DateTime, tran_cuttinginfo_GAPgListView_ExtEntity.ProcessDate);
                    Database.AddInParameter(cmd, "@IsReviewed", DbType.Boolean, tran_cuttinginfo_GAPgListView_ExtEntity.IsReviewed);
                    Database.AddInParameter(cmd, "@IsRollback ", DbType.Boolean, tran_cuttinginfo_GAPgListView_ExtEntity.isrollback);
                    Database.AddInParameter(cmd, "@ReviewDate", DbType.DateTime, tran_cuttinginfo_GAPgListView_ExtEntity.ReviewDate);
                    Database.AddInParameter(cmd, "@ReviewedBy", DbType.Int64, tran_cuttinginfo_GAPgListView_ExtEntity.ReviewedBy);
                    Database.AddInParameter(cmd, "@ReviewRemarks", DbType.String, tran_cuttinginfo_GAPgListView_ExtEntity.ReviewRemarks);
                    Database.AddInParameter(cmd, "@IsApproved", DbType.Boolean, tran_cuttinginfo_GAPgListView_ExtEntity.IsApproved);
                    Database.AddInParameter(cmd, "@ApproveDate", DbType.DateTime, tran_cuttinginfo_GAPgListView_ExtEntity.ApproveDate);
                    Database.AddInParameter(cmd, "@ApproveBy", DbType.Int64, tran_cuttinginfo_GAPgListView_ExtEntity.ApproveBy);
                    Database.AddInParameter(cmd, "@ApproveRemarks", DbType.String, tran_cuttinginfo_GAPgListView_ExtEntity.ApproveRemarks);
                    Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, tran_cuttinginfo_GAPgListView_ExtEntity.CommonSerachParam);
                    Database.AddOutParameter(cmd, "@TotalRecord", DbType.Int64, 8);
                    Database.AddInParameter(cmd, "@SortExpression", DbType.String, tran_cuttinginfo_GAPgListView_ExtEntity.SortExpression);
                    Database.AddInParameter(cmd, "@PageSize", DbType.Int64, tran_cuttinginfo_GAPgListView_ExtEntity.PageSize);
                    Database.AddInParameter(cmd, "@CurrentPage", DbType.Int64, tran_cuttinginfo_GAPgListView_ExtEntity.CurrentPage);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_cuttinginfo_GAPgListView_ExtEntity(reader));
                        }
                        reader.Dispose();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        tran_cuttinginfo_GAPgListView_ExtEntity.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_tran_cuttinginfo_GAPgListView_Ext"));
            }
            return itemList;
        }

        IList<tran_cuttinginfodetl_GAPgListView_ExtEntity> IReportExtensionDataAccess.Get_tran_cuttinginfodetl_GAPgListView_Ext(tran_cuttinginfodetl_GAPgListView_ExtEntity tran_cuttinginfodetl_GAPgListView_ExtEntity)
        {
            IList<tran_cuttinginfodetl_GAPgListView_ExtEntity> itemList = new List<tran_cuttinginfodetl_GAPgListView_ExtEntity>();
            try
            {
                const string SP = "tran_cuttinginfodetl_GAPgListView_Ext";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@CuttingInfoID", DbType.Int64, tran_cuttinginfodetl_GAPgListView_ExtEntity.CuttingInfoID);
                    Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, tran_cuttinginfodetl_GAPgListView_ExtEntity.CommonSerachParam);
                    Database.AddOutParameter(cmd, "@TotalRecord", DbType.Int64, 8);
                    Database.AddInParameter(cmd, "@SortExpression", DbType.String, tran_cuttinginfodetl_GAPgListView_ExtEntity.SortExpression);
                    Database.AddInParameter(cmd, "@PageSize", DbType.Int64, tran_cuttinginfodetl_GAPgListView_ExtEntity.PageSize);
                    Database.AddInParameter(cmd, "@CurrentPage", DbType.Int64, tran_cuttinginfodetl_GAPgListView_ExtEntity.CurrentPage);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new tran_cuttinginfodetl_GAPgListView_ExtEntity(reader));
                        }
                        reader.Dispose();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        tran_cuttinginfodetl_GAPgListView_ExtEntity.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_tran_cuttinginfodetl_GAPgListView_Ext"));
            }
            return itemList;
        }

        IList<rpt_GetCuttingInfo_ExtEntity> IReportExtensionDataAccess.Get_rpt_GetCuttingInfo_Ext(rpt_GetCuttingInfo_ExtEntity rpt_GetCuttingInfo_ExtEntity)
        {
            IList<rpt_GetCuttingInfo_ExtEntity> itemList = new List<rpt_GetCuttingInfo_ExtEntity>();
            try
            {
                const string SP = "rpt_GetCuttingInfo_Ext";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@cuttingid", DbType.Int64, rpt_GetCuttingInfo_ExtEntity.cuttingid);
                    Database.AddInParameter(cmd, "@ispaid", DbType.Boolean, rpt_GetCuttingInfo_ExtEntity.ispaid);
                    Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, rpt_GetCuttingInfo_ExtEntity.strCommonSerachParam);
                    Database.AddOutParameter(cmd, "@TotalRecord", DbType.Int64, 8);
                    Database.AddInParameter(cmd, "@SortExpression", DbType.String, rpt_GetCuttingInfo_ExtEntity.SortExpression);
                    Database.AddInParameter(cmd, "@PageSize", DbType.Int64, rpt_GetCuttingInfo_ExtEntity.PageSize);
                    Database.AddInParameter(cmd, "@CurrentPage", DbType.Int64, rpt_GetCuttingInfo_ExtEntity.CurrentPage);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new rpt_GetCuttingInfo_ExtEntity(reader));
                        }
                        reader.Dispose();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        rpt_GetCuttingInfo_ExtEntity.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_rpt_GetCuttingInfo_Ext"));
            }
            return itemList;
        }

        IList<rpt_GetTotalApplicableEntity> IReportExtensionDataAccess.Get_rpt_GetTotalApplicable(rpt_GetTotalApplicableEntity rpt_GetTotalApplicableEntity)
        {
            IList<rpt_GetTotalApplicableEntity> itemList = new List<rpt_GetTotalApplicableEntity>();
            try
            {
                const string SP = "rpt_GetTotalApplicable";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@OKPID", DbType.Int64, rpt_GetTotalApplicableEntity.OKPID);
                    Database.AddInParameter(cmd, "@PayAllceID", DbType.Int64, rpt_GetTotalApplicableEntity.PayAllceID);
                    Database.AddInParameter(cmd, "@ProcessDate", DbType.DateTime, rpt_GetTotalApplicableEntity.ProcessDate);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new rpt_GetTotalApplicableEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_rpt_GetTotalApplicable"));
            }
            return itemList;
        }

        IList<rpt_GetTotalApplicable_DetailEntity> IReportExtensionDataAccess.Get_rpt_GetTotalApplicable_Detail(rpt_GetTotalApplicable_DetailEntity rpt_GetTotalApplicable_DetailEntity)
        {
            IList<rpt_GetTotalApplicable_DetailEntity> itemList = new List<rpt_GetTotalApplicable_DetailEntity>();
            try
            {
                const string SP = "rpt_GetTotalApplicable_Detail";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@OKPID", DbType.Int64, rpt_GetTotalApplicable_DetailEntity.OKPID);
                    Database.AddInParameter(cmd, "@PayAllceID", DbType.Int64, rpt_GetTotalApplicable_DetailEntity.PayAllceID);
                    Database.AddInParameter(cmd, "@ProcessDate", DbType.DateTime, rpt_GetTotalApplicable_DetailEntity.ProcessDate);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new rpt_GetTotalApplicable_DetailEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_rpt_GetTotalApplicable_Detail"));
            }
            return itemList;
        }

        IList<rpt_CuttingSummaryEntity> IReportExtensionDataAccess.Get_rpt_CuttingSummary(rpt_CuttingSummaryEntity rpt_CuttingSummaryEntity)
        {
            IList<rpt_CuttingSummaryEntity> itemList = new List<rpt_CuttingSummaryEntity>();
            try
            {
                const string SP = "rpt_CuttingSummary";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@PayAllceID", DbType.Int64, rpt_CuttingSummaryEntity.PayAllceID);
                    Database.AddInParameter(cmd, "@MonthID", DbType.Int64, rpt_CuttingSummaryEntity.MonthID);
                    Database.AddInParameter(cmd, "@Year", DbType.Int64, rpt_CuttingSummaryEntity.Year);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new rpt_CuttingSummaryEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_rpt_CuttingSummary"));
            }
            return itemList;
        }

        IList<rpt_CuttingSummeryIndividualEntity> IReportExtensionDataAccess.Get_rpt_CuttingSummeryIndividual(rpt_CuttingSummeryIndividualEntity rpt_CuttingSummeryIndividualEntity)
        {
            IList<rpt_CuttingSummeryIndividualEntity> itemList = new List<rpt_CuttingSummeryIndividualEntity>();
            try
            {
                const string SP = "rpt_CuttingSummeryIndividual";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@MilitaryNoKW", DbType.Int64, rpt_CuttingSummeryIndividualEntity.MilitaryNoKW);
                    Database.AddInParameter(cmd, "@PayAllceID", DbType.Int64, rpt_CuttingSummeryIndividualEntity.PayAllceID);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new rpt_CuttingSummeryIndividualEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_rpt_CuttingSummeryIndividual"));
            }
            return itemList;
        }

        IList<KAF_GetLeaveBalanceEntity> IReportExtensionDataAccess.Get_KAF_GetLeaveBalance(KAF_GetLeaveBalanceEntity KAF_GetLeaveBalanceEntity)
        {
            IList<KAF_GetLeaveBalanceEntity> itemList = new List<KAF_GetLeaveBalanceEntity>();
            try
            {
                const string SP = "KAF_GetLeaveBalance";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@HRBasicID", DbType.Int64, KAF_GetLeaveBalanceEntity.HRBasicID);
                    Database.AddInParameter(cmd, "@LeaveTypeID", DbType.Int64, KAF_GetLeaveBalanceEntity.LeaveTypeID);
                    Database.AddInParameter(cmd, "@LeaveStartDate", DbType.DateTime, KAF_GetLeaveBalanceEntity.LeaveStartDate);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new KAF_GetLeaveBalanceEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_KAF_GetLeaveBalance"));
            }
            return itemList;
        }

        IList<KAFProcess_ManpoewrStateEntity> IReportExtensionDataAccess.Get_KAFProcess_ManpoewrState(KAFProcess_ManpoewrStateEntity KAFProcess_ManpoewrStateEntity)
        {
            List<KAFProcess_ManpoewrStateEntity> itemList = new List<KAFProcess_ManpoewrStateEntity>();
            try
            {
                const string SP = "KAFProcess_ManpoewrState";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@IsProcess", DbType.Int64, KAFProcess_ManpoewrStateEntity.IsProcess);
                    Database.AddInParameter(cmd, "@OkpID", DbType.Int64, KAFProcess_ManpoewrStateEntity.OkpID);
                    Database.AddInParameter(cmd, "@ManpowerStateDate", DbType.DateTime, KAFProcess_ManpoewrStateEntity.ManpowerStateDate);
                    Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, KAFProcess_ManpoewrStateEntity.ex_date1);
                    Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, KAFProcess_ManpoewrStateEntity.ex_date2);
                    Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, KAFProcess_ManpoewrStateEntity.ex_nvarchar1);
                    Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, KAFProcess_ManpoewrStateEntity.ex_nvarchar2);
                    Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, KAFProcess_ManpoewrStateEntity.ex_bigint1);
                    Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, KAFProcess_ManpoewrStateEntity.ex_bigint2);
                    Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, KAFProcess_ManpoewrStateEntity.ex_decimal1);
                    Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, KAFProcess_ManpoewrStateEntity.ex_decimal2);
                    //Database.AddInParameter(cmd, "@RETURN_KEY", DbType.Int64, KAFProcess_ManpoewrStateEntity.RETURN_KEY);
                    Database.AddInParameter(cmd, "@CreatedBy", DbType.Int64, KAFProcess_ManpoewrStateEntity.BaseSecurityParam.createdby);
                    Database.AddInParameter(cmd, "@CreatedByUserName", DbType.String, KAFProcess_ManpoewrStateEntity.BaseSecurityParam.createdbyusername);
                    Database.AddInParameter(cmd, "@UpdatedBy", DbType.Int64, KAFProcess_ManpoewrStateEntity.BaseSecurityParam.updatedby);
                    Database.AddInParameter(cmd, "@UpdatedByUserName", DbType.String, KAFProcess_ManpoewrStateEntity.BaseSecurityParam.updatedbyusername);
                    Database.AddInParameter(cmd, "@CreatedDate", DbType.DateTime, KAFProcess_ManpoewrStateEntity.BaseSecurityParam.createddate);
                    Database.AddInParameter(cmd, "@UpdatedDate", DbType.DateTime, KAFProcess_ManpoewrStateEntity.BaseSecurityParam.updateddate);
                    Database.AddInParameter(cmd, "@FormID", DbType.Int64, KAFProcess_ManpoewrStateEntity.BaseSecurityParam.appformid);
                    Database.AddInParameter(cmd, "@IPAddress", DbType.String, KAFProcess_ManpoewrStateEntity.BaseSecurityParam.ipaddress);
                    Database.AddInParameter(cmd, "@TransID", DbType.String, KAFProcess_ManpoewrStateEntity.BaseSecurityParam.transid);
                    Database.AddInParameter(cmd, "@UserOrganizationKey", DbType.Int64, KAFProcess_ManpoewrStateEntity.BaseSecurityParam.userorganizationkey);
                    Database.AddInParameter(cmd, "@UserEntityKey", DbType.Int64, KAFProcess_ManpoewrStateEntity.BaseSecurityParam.userentitykey);
                    Database.AddInParameter(cmd, "@Ts", DbType.Int64, KAFProcess_ManpoewrStateEntity.BaseSecurityParam.ts);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new KAFProcess_ManpoewrStateEntity(reader));

                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_KAFProcess_ManpoewrState"));
            }
            return itemList;
        }

        IList<rpt_ManpoewrStateByStatusEntity> IReportExtensionDataAccess.Get_rpt_ManpoewrStateByStatus(rpt_ManpoewrStateByStatusEntity rpt_ManpoewrStateByStatusEntity)
        {
            IList<rpt_ManpoewrStateByStatusEntity> itemList = new List<rpt_ManpoewrStateByStatusEntity>();
            try
            {
                const string SP = "rpt_ManpoewrStateByStatus";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@ManpowerStateID", DbType.Int64, rpt_ManpoewrStateByStatusEntity.ManpowerStateID);
                    Database.AddInParameter(cmd, "@ManpowerStatusID", DbType.Int64, rpt_ManpoewrStateByStatusEntity.ManpowerStatusID);


                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new rpt_ManpoewrStateByStatusEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_rpt_ManpoewrStateByStatus"));
            }
            return itemList;
        }

        IList<rpt_ManpoewrStateEntity> IReportExtensionDataAccess.Get_rpt_ManpoewrState(rpt_ManpoewrStateEntity rpt_ManpoewrStateEntity)
        {
            IList<rpt_ManpoewrStateEntity> itemList = new List<rpt_ManpoewrStateEntity>();
            try
            {
                const string SP = "rpt_ManpoewrState";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@ManpowerStateID", DbType.Int64, rpt_ManpoewrStateEntity.ManpowerStateID);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new rpt_ManpoewrStateEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_rpt_ManpoewrState"));
            }
            return itemList;
        }

        IList<Kaf_tran_cuttinginfo_ProcessCountEntity> IReportExtensionDataAccess.Get_Kaf_tran_cuttinginfo_ProcessCount(Kaf_tran_cuttinginfo_ProcessCountEntity Kaf_tran_cuttinginfo_ProcessCountEntity)
        {
            IList<Kaf_tran_cuttinginfo_ProcessCountEntity> itemList = new List<Kaf_tran_cuttinginfo_ProcessCountEntity>();
            try
            {
                const string SP = "Kaf_tran_cuttinginfo_ProcessCount";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@CuttingInfoID", DbType.Int64, Kaf_tran_cuttinginfo_ProcessCountEntity.CuttingInfoID);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new Kaf_tran_cuttinginfo_ProcessCountEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_Kaf_tran_cuttinginfo_ProcessCount"));
            }
            return itemList;
        }

        IList<rpt_OkpWiseManpowerStateHeldEntity> IReportExtensionDataAccess.Get_rpt_OkpWiseManpowerStateHeld(rpt_OkpWiseManpowerStateHeldEntity rpt_OkpWiseManpowerStateHeldEntity)
        {
            IList<rpt_OkpWiseManpowerStateHeldEntity> itemList = new List<rpt_OkpWiseManpowerStateHeldEntity>();
            try
            {
                const string SP = "rpt_OkpWiseManpowerStateHeld";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@StateDate", DbType.DateTime, rpt_OkpWiseManpowerStateHeldEntity.StateDate);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new rpt_OkpWiseManpowerStateHeldEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_rpt_OkpWiseManpowerStateHeld"));
            }
            return itemList;
        }

        IList<rpt_OkpWiseManpowerStateEntity> IReportExtensionDataAccess.Get_rpt_OkpWiseManpowerState(rpt_OkpWiseManpowerStateEntity rpt_OkpWiseManpowerStateEntity)
        {
            IList<rpt_OkpWiseManpowerStateEntity> itemList = new List<rpt_OkpWiseManpowerStateEntity>();
            try
            {
                const string SP = "rpt_OkpWiseManpowerState";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@StateDate", DbType.DateTime, rpt_OkpWiseManpowerStateEntity.StateDate);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new rpt_OkpWiseManpowerStateEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_rpt_OkpWiseManpowerState"));
            }
            return itemList;
        }

        IList<rpt_CampWiseManpowerStateHeldEntity> IReportExtensionDataAccess.Get_rpt_CampWiseManpowerStateHeld(rpt_CampWiseManpowerStateHeldEntity rpt_CampWiseManpowerStateHeldEntity)
        {
            IList<rpt_CampWiseManpowerStateHeldEntity> itemList = new List<rpt_CampWiseManpowerStateHeldEntity>();
            try
            {
                const string SP = "rpt_CampWiseManpowerStateHeld";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@StateDate", DbType.DateTime, rpt_CampWiseManpowerStateHeldEntity.StateDate);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new rpt_CampWiseManpowerStateHeldEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_rpt_CampWiseManpowerStateHeld"));
            }
            return itemList;
        }

        IList<rpt_LeaveInfoEntity> IReportExtensionDataAccess.Get_rpt_LeaveInfo(rpt_LeaveInfoEntity rpt_LeaveInfoEntity)
        {
            IList<rpt_LeaveInfoEntity> itemList = new List<rpt_LeaveInfoEntity>();
            try
            {
                const string SP = "rpt_LeaveInfo";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@okpid", DbType.Int64, rpt_LeaveInfoEntity.OkpID);
                    Database.AddInParameter(cmd, "@InLeave", DbType.Boolean, rpt_LeaveInfoEntity.InLeave);
                    Database.AddInParameter(cmd, "@LeaveTypeID", DbType.Int64, rpt_LeaveInfoEntity.LeaveTypeID);
                    Database.AddInParameter(cmd, "@LeaveStartFromDate", DbType.DateTime, rpt_LeaveInfoEntity.LeaveStartFromDate);
                    Database.AddInParameter(cmd, "@LeaveStartToDate", DbType.DateTime, rpt_LeaveInfoEntity.LeaveStartToDate);
                    Database.AddInParameter(cmd, "@LeaveEndFromDate", DbType.DateTime, rpt_LeaveInfoEntity.LeaveEndFromDate);
                    Database.AddInParameter(cmd, "@LeaveEndToDate", DbType.DateTime, rpt_LeaveInfoEntity.LeaveEndToDate);
                    Database.AddInParameter(cmd, "@LeaveReturnFromDate", DbType.DateTime, rpt_LeaveInfoEntity.LeaveReturnFromDate);
                    Database.AddInParameter(cmd, "@LeaveReturnToDate", DbType.DateTime, rpt_LeaveInfoEntity.LeaveReturnToDate);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new rpt_LeaveInfoEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_rpt_LeaveInfo"));
            }
            return itemList;
        }

        IList<rpt_RepatriationInfoEntity> IReportExtensionDataAccess.Get_rpt_RepatriationInfo(rpt_RepatriationInfoEntity rpt_RepatriationInfoEntity)
        {
            IList<rpt_RepatriationInfoEntity> itemList = new List<rpt_RepatriationInfoEntity>();
            try
            {
                const string SP = "rpt_RepatriationInfo";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@okpid", DbType.Int64, rpt_RepatriationInfoEntity.OkpID);
                    Database.AddInParameter(cmd, "@InLeave", DbType.Boolean, rpt_RepatriationInfoEntity.InLeave);
                    Database.AddInParameter(cmd, "@LeaveTypeID", DbType.Int64, rpt_RepatriationInfoEntity.LeaveTypeID);
                    Database.AddInParameter(cmd, "@SODFromDate", DbType.DateTime, rpt_RepatriationInfoEntity.SODFromDate);
                    Database.AddInParameter(cmd, "@SODToDate", DbType.DateTime, rpt_RepatriationInfoEntity.SODToDate);
                    Database.AddInParameter(cmd, "@FlightFromDate", DbType.DateTime, rpt_RepatriationInfoEntity.FlightFromDate);
                    Database.AddInParameter(cmd, "@FlightToDate", DbType.DateTime, rpt_RepatriationInfoEntity.FlightToDate);
                    Database.AddInParameter(cmd, "@SalaryReceivedFromDate", DbType.DateTime, rpt_RepatriationInfoEntity.SalaryReceivedFromDate);
                    Database.AddInParameter(cmd, "@SalaryReceivedToDate", DbType.DateTime, rpt_RepatriationInfoEntity.SalaryReceivedToDate);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new rpt_RepatriationInfoEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_rpt_RepatriationInfo"));
            }
            return itemList;
        }

        IList<rpt_HospitalInfoEntity> IReportExtensionDataAccess.Get_rpt_HospitalInfo(rpt_HospitalInfoEntity rpt_HospitalInfoEntity)
        {
            IList<rpt_HospitalInfoEntity> itemList = new List<rpt_HospitalInfoEntity>();
            try
            {
                const string SP = "rpt_HospitalInfo";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@okpid", DbType.Int64, rpt_HospitalInfoEntity.OkpID);
                    Database.AddInParameter(cmd, "@IsAdmitted", DbType.Boolean, rpt_HospitalInfoEntity.IsAdmitted);
                    Database.AddInParameter(cmd, "@CountryID", DbType.Int64, rpt_HospitalInfoEntity.CountryID);
                    Database.AddInParameter(cmd, "@AdmissionFromDate", DbType.DateTime, rpt_HospitalInfoEntity.AdmissionFromDate);
                    Database.AddInParameter(cmd, "@AdmissionToDate", DbType.DateTime, rpt_HospitalInfoEntity.AdmissionToDate);
                    Database.AddInParameter(cmd, "@ReleaseFromDate", DbType.DateTime, rpt_HospitalInfoEntity.ReleaseFromDate);
                    Database.AddInParameter(cmd, "@ReleaseToDate", DbType.DateTime, rpt_HospitalInfoEntity.ReleaseToDate);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new rpt_HospitalInfoEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_rpt_HospitalInfo"));
            }
            return itemList;
        }

        IList<rpt_DeploymentStateEntity> IReportExtensionDataAccess.Get_rpt_DeploymentState(rpt_DeploymentStateEntity rpt_DeploymentStateEntity)
        {
            IList<rpt_DeploymentStateEntity> itemList = new List<rpt_DeploymentStateEntity>();
            try
            {
                const string SP = "rpt_DeploymentState";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@OkpID", DbType.Int64, rpt_DeploymentStateEntity.OkpID);
                    Database.AddInParameter(cmd, "@IsDeployed", DbType.Boolean, rpt_DeploymentStateEntity.IsDeployed);
                    Database.AddInParameter(cmd, "@DeployedSubUNitID", DbType.Int64, rpt_DeploymentStateEntity.DeployedSubUNitID);
                    Database.AddInParameter(cmd, "@DeployedCampID", DbType.Int64, rpt_DeploymentStateEntity.DeployedCampID);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new rpt_DeploymentStateEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_rpt_DeploymentState"));
            }
            return itemList;
        }

		IList<rpt_OkpWiseManpowerStateHeldAuthEntity> IReportExtensionDataAccess.Get_rpt_OkpWiseManpowerStateHeldAuth(rpt_OkpWiseManpowerStateHeldAuthEntity rpt_OkpWiseManpowerStateHeldAuthEntity)
		{
			IList<rpt_OkpWiseManpowerStateHeldAuthEntity> itemList = new List<rpt_OkpWiseManpowerStateHeldAuthEntity>();
			try
			{
				const string SP = "rpt_OkpWiseManpowerStateHeldAuth";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
				Database.AddInParameter(cmd, "@StateDate", DbType.DateTime, rpt_OkpWiseManpowerStateHeldAuthEntity.StateDate);
				Database.AddInParameter(cmd, "@OkpID", DbType.Int64, rpt_OkpWiseManpowerStateHeldAuthEntity.OkpID);
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
					while (reader.Read())
					{
						itemList.Add(new rpt_OkpWiseManpowerStateHeldAuthEntity(reader));
					}reader.Dispose();
					}
				cmd.Dispose();
			}
			}
			catch (Exception ex)
			{
				throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_rpt_OkpWiseManpowerStateHeldAuth"));
			} 
		return itemList; 
		}

        public IList<FamilyPassportInfoEntity> FamilyPassportInfoExpire(FamilyPassportInfoEntity FamilyPassportInfo)
        {
            IList<FamilyPassportInfoEntity> itemList = new List<FamilyPassportInfoEntity>();
            try
            {
                const string SP = "FamilyPassportInfoExpireReport";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@CivilID", DbType.String, FamilyPassportInfo.FamilyCivilID);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new FamilyPassportInfoEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IReportExtensionDataAccess.Get_rpt_ptareceivedwithflightinfo"));
            }
            return itemList;
        }
    }
 }
