using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.IBusinessFacadeObjects.IBusinessFacadeObjectsPartial;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using System.Data;
using KAF.DataAccessObjects;
using System.Diagnostics;
using KAF.AppConfiguration.Configuration;
using KAF.BusinessDataObjects;


namespace KAF.BusinessFacadeObjects.BusinessFacadeObjectsPartial
{
    public sealed class ReportExtensionFacade : BaseFacade, IReportExtensionFacade
    {
        #region Instance Variables
        private string ClassName = "ReportExtensionFacade";
        private bool _isDisposed;
        private Context _currentContext;

        private BaseDataAccessFactory _dataAccessFactory;

        #endregion

        #region Private Properties

        private Context CurrentContext
        {
            [DebuggerStepThrough()]
            get
            {
                if (_currentContext == null)
                {
                    _currentContext = new Context();
                }

                return _currentContext;
            }
        }

        private BaseDataAccessFactory DataAccessFactory
        {
            [DebuggerStepThrough()]
            get
            {
                if (_dataAccessFactory == null)
                {
                    _dataAccessFactory = BaseDataAccessFactory.Create(CurrentContext);
                }

                return _dataAccessFactory;
            }
        }

        #endregion

        #region Constructer & Destructor

        public ReportExtensionFacade()
            : base()
        {
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    if (_currentContext != null)
                    {
                        _currentContext.Dispose();
                    }
                }
            }

            _isDisposed = true;
        }

        ~ReportExtensionFacade()
        {
            Dispose(false);
        }

        private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        #endregion

		
		IList<KAF_GetReplacementListByREplacementIDEntity> IReportExtensionFacade.Get_KAF_GetReplacementListByREplacementID(KAF_GetReplacementListByREplacementIDEntity KAF_GetMilitaryPersonalInfoEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_KAF_GetReplacementListByREplacementID(KAF_GetMilitaryPersonalInfoEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<KAF_GetMilitaryPersonalInfoEntity> IReportExtensionFacade.rpt_KAF_GetMilitaryPersonalInfo"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<KAF_GetReplacementPassportListByRepPassportIDEntity> IReportExtensionFacade.GET_KAF_GetReplacementPassportListByRepPassportID(KAF_GetReplacementPassportListByRepPassportIDEntity KAF_GetReplacementPassportListByRepPassportIDEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_KAF_GetReplacementPassportListByRepPassportID(KAF_GetReplacementPassportListByRepPassportIDEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<KAF_GetReplacementPassportListByRepPassportIDEntity> IReportExtensionFacade.rpt_KAF_GetReplacementPassportListByRepPassportID"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<KAF_GetVisaDemandListByVisaDemandIDEntity> IReportExtensionFacade.GET_KAF_GetVisaDemandListByVisaDemandID(KAF_GetVisaDemandListByVisaDemandIDEntity KAF_GetVisaDemandListByVisaDemandIDEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_KAF_GetVisaDemandListByVisaDemandID(KAF_GetVisaDemandListByVisaDemandIDEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<KAF_GetVisaDemandListByVisaDemandIDEntity> IReportExtensionFacade.rpt_KAF_GetVisaDemandListByVisaDemandID"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<KAF_GetRepPassportListByRepPassportIDEntity> IReportExtensionFacade.GET_KAF_GetRepPassportListByRepPassportID(KAF_GetRepPassportListByRepPassportIDEntity KAF_GetRepPassportListByRepPassportIDEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_KAF_GetRepPassportListByRepPassportID(KAF_GetRepPassportListByRepPassportIDEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<KAF_GetRepPassportListByRepPassportIDEntity> IReportExtensionFacade.rpt_KAF_GetRepPassportListByRepPassportID"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<KAF_GetDemandListByDemandIDEntity> IReportExtensionFacade.GET_KAF_GetDemandListByDemandID(KAF_GetDemandListByDemandIDEntity KAF_GetDemandListByDemandIDEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_KAF_GetDemandListByDemandID(KAF_GetDemandListByDemandIDEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<KAF_GetDemandListByDemandIDEntity> IReportExtensionFacade.rpt_KAF_GetDemandListByDemandID"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<KAF_GetVisaIssueListByVisaIssueIDEntity> IReportExtensionFacade.GET_KAF_GetVisaIssueListByVisaIssueID(KAF_GetVisaIssueListByVisaIssueIDEntity KAF_GetVisaIssueListByVisaIssueIDEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_KAF_GetVisaIssueListByVisaIssueID(KAF_GetVisaIssueListByVisaIssueIDEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<KAF_GetVisaIssueListByVisaIssueIDEntity> IReportExtensionFacade.rpt_KAF_GetVisaIssueListByVisaIssueID"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<KAF_GetVisaSentListByVisaSentIDEntity> IReportExtensionFacade.GET_KAF_GetVisaSentListByVisaSentID(KAF_GetVisaSentListByVisaSentIDEntity KAF_GetVisaSentListByVisaSentIDEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_KAF_GetVisaSentListByVisaSentID(KAF_GetVisaSentListByVisaSentIDEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<KAF_GetVisaSentListByVisaSentIDEntity> IReportExtensionFacade.rpt_KAF_GetVisaSentListByVisaSentID"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<KAF_GetPTADemandListByPTADemandIDEntity> IReportExtensionFacade.GET_KAF_GetPTADemandListByPTADemandID(KAF_GetPTADemandListByPTADemandIDEntity KAF_GetPTADemandListByPTADemandIDEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_KAF_GetPTADemandListByPTADemandID(KAF_GetPTADemandListByPTADemandIDEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<KAF_GetPTADemandListByPTADemandIDEntity> IReportExtensionFacade.rpt_KAF_GetPTADemandListByPTADemandID"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<KAF_GetFlightListByFlightIDEntity> IReportExtensionFacade.GET_KAF_GetFlightListByFlightID(KAF_GetFlightListByFlightIDEntity KAF_GetFlightListByFlightIDEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_KAF_GetFlightListByFlightID(KAF_GetFlightListByFlightIDEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<KAF_GetFlightListByFlightIDEntity> IReportExtensionFacade.rpt_KAF_GetFlightListByFlightID"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<KAF_GetNewDemandInfoEntity> IReportExtensionFacade.GET_KAF_GetNewDemandInfo(KAF_GetNewDemandInfoEntity KAF_GetNewDemandInfoEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_KAF_GetNewDemandInfo(KAF_GetNewDemandInfoEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<KAF_GetNewDemandInfoEntity> IReportExtensionFacade.rpt_KAF_GetNewDemandInfo"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<KAF_GetReplacementInfoEntity> IReportExtensionFacade.GET_KAF_GetReplacementInfo(KAF_GetReplacementInfoEntity KAF_GetReplacementInfoEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_KAF_GetReplacementInfo(KAF_GetReplacementInfoEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<KAF_GetReplacementInfoEntity> IReportExtensionFacade.rpt_KAF_GetReplacementInfo"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<KAF_GetProfileInfoEntity> IReportExtensionFacade.GET_KAF_GetProfileInfo(KAF_GetProfileInfoEntity KAF_GetProfileInfoEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_KAF_GetProfileInfo(KAF_GetProfileInfoEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<KAF_GetProfileInfoEntity> IReportExtensionFacade.rpt_KAF_GetProfileInfo"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		long IReportExtensionFacade.GET_KAFProcess_UpdateLetterStatus(KAFProcess_UpdateLetterStatusEntity KAFProcess_UpdateLetterStatusEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_KAFProcess_UpdateLetterStatus(KAFProcess_UpdateLetterStatusEntity);
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("long IReportExtensionFacade.rpt_KAFProcess_UpdateLetterStatus"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<hr_flightcancelinfo_GAPgListView_ExtEntity> IReportExtensionFacade.GET_hr_flightcancelinfo_GAPgListView_Ext(hr_flightcancelinfo_GAPgListView_ExtEntity hr_flightcancelinfo_GAPgListView_ExtEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_hr_flightcancelinfo_GAPgListView_Ext(hr_flightcancelinfo_GAPgListView_ExtEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<hr_flightcancelinfo_GAPgListView_ExtEntity> IReportExtensionFacade.rpt_hr_flightcancelinfo_GAPgListView_Ext"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<hr_flightinfodetlEntity> IReportExtensionFacade.GET_hr_flightinfodetl_GAPgListView_Select2(hr_flightinfodetlEntity hr_flightinfodetlEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_hr_flightinfodetl_GAPgListView_Select2(hr_flightinfodetlEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<hr_flightinfodetlEntity> IReportExtensionFacade.rpt_hr_flightinfodetl_GAPgListView_Select2"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<KAF_GetPTAReceivedListByPTAReceiveIDEntity> IReportExtensionFacade.GET_KAF_GetPTAReceivedListByPTAReceiveID(KAF_GetPTAReceivedListByPTAReceiveIDEntity KAF_GetPTAReceivedListByPTAReceiveIDEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_KAF_GetPTAReceivedListByPTAReceiveID(KAF_GetPTAReceivedListByPTAReceiveIDEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<KAF_GetPTAReceivedListByPTAReceiveIDEntity> IReportExtensionFacade.rpt_KAF_GetPTAReceivedListByPTAReceiveID"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<rpt_GetReplacementPassportInfoEntity> IReportExtensionFacade.GET_rpt_GetReplacementPassportInfo(rpt_GetReplacementPassportInfoEntity rpt_GetReplacementPassportInfoEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_rpt_GetReplacementPassportInfo(rpt_GetReplacementPassportInfoEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<rpt_GetReplacementPassportInfoEntity> IReportExtensionFacade.rpt_rpt_GetReplacementPassportInfo"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<rpt_issueofvisaandptaEntity> IReportExtensionFacade.GET_rpt_issueofvisaandpta(rpt_issueofvisaandptaEntity rpt_issueofvisaandptaEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_rpt_issueofvisaandpta(rpt_issueofvisaandptaEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<rpt_issueofvisaandptaEntity> IReportExtensionFacade.rpt_rpt_issueofvisaandpta"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<rpt_visareceivedpersonnelEntity> IReportExtensionFacade.GET_rpt_visareceivedpersonnel(rpt_visareceivedpersonnelEntity rpt_visareceivedpersonnelEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_rpt_visareceivedpersonnel(rpt_visareceivedpersonnelEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<rpt_visareceivedpersonnelEntity> IReportExtensionFacade.rpt_rpt_visareceivedpersonnel"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<rpt_newdemanddetailsEntity> IReportExtensionFacade.GET_rpt_newdemanddetails(rpt_newdemanddetailsEntity rpt_newdemanddetailsEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_rpt_newdemanddetails(rpt_newdemanddetailsEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<rpt_newdemanddetailsEntity> IReportExtensionFacade.rpt_rpt_newdemanddetails"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<rpt_arrivalreportEntity> IReportExtensionFacade.GET_rpt_arrivalreport(rpt_arrivalreportEntity rpt_arrivalreportEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_rpt_arrivalreport(rpt_arrivalreportEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<rpt_arrivalreportEntity> IReportExtensionFacade.rpt_rpt_arrivalreport"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<rpt_ptareceivedwithflightinfoEntity> IReportExtensionFacade.GET_rpt_ptareceivedwithflightinfo(rpt_ptareceivedwithflightinfoEntity rpt_ptareceivedwithflightinfoEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_rpt_ptareceivedwithflightinfo(rpt_ptareceivedwithflightinfoEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<rpt_ptareceivedwithflightinfoEntity> IReportExtensionFacade.rpt_rpt_ptareceivedwithflightinfo"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<rpt_passportheldbyspabEntity> IReportExtensionFacade.GET_rpt_passportheldbyspab(rpt_passportheldbyspabEntity rpt_passportheldbyspabEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_rpt_passportheldbyspab(rpt_passportheldbyspabEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<rpt_passportheldbyspabEntity> IReportExtensionFacade.rpt_rpt_passportheldbyspab"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<rpt_OkpSummaryOkpwiseEntity> IReportExtensionFacade.GET_rpt_OkpSummaryOkpwise(rpt_OkpSummaryOkpwiseEntity rpt_OkpSummaryOkpwiseEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_rpt_OkpSummaryOkpwise(rpt_OkpSummaryOkpwiseEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<rpt_OkpSummaryOkpwiseEntity> IReportExtensionFacade.rpt_rpt_OkpSummaryOkpwise"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<rpt_BMCStrengthSummaryEntity> IReportExtensionFacade.GET_rpt_BMCStrengthSummary(rpt_BMCStrengthSummaryEntity rpt_BMCStrengthSummaryEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_rpt_BMCStrengthSummary(rpt_BMCStrengthSummaryEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<rpt_BMCStrengthSummaryEntity> IReportExtensionFacade.rpt_rpt_BMCStrengthSummary"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<KAF_GetChildUnitsEntity> IReportExtensionFacade.GET_KAF_GetChildUnits(KAF_GetChildUnitsEntity KAF_GetChildUnitsEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_KAF_GetChildUnits(KAF_GetChildUnitsEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<KAF_GetChildUnitsEntity> IReportExtensionFacade.rpt_KAF_GetChildUnits"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		long IReportExtensionFacade.GET_KAF_CuttingInsert(KAF_CuttingInsertEntity KAF_CuttingInsertEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_KAF_CuttingInsert(KAF_CuttingInsertEntity);
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<KAF_CuttingInsertEntity> IReportExtensionFacade.rpt_KAF_CuttingInsert"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<rpt_GetCuttingInfoEntity> IReportExtensionFacade.GET_rpt_GetCuttingInfo(rpt_GetCuttingInfoEntity rpt_GetCuttingInfoEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_rpt_GetCuttingInfo(rpt_GetCuttingInfoEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<rpt_GetCuttingInfoEntity> IReportExtensionFacade.rpt_rpt_GetCuttingInfo"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<KAF_GetRankByGroupEntity> IReportExtensionFacade.GET_KAF_GetRankByGroup(KAF_GetRankByGroupEntity KAF_GetRankByGroupEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_KAF_GetRankByGroup(KAF_GetRankByGroupEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<KAF_GetRankByGroupEntity> IReportExtensionFacade.rpt_KAF_GetRankByGroup"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<tran_cuttinginfo_GAPgListView_ExtEntity> IReportExtensionFacade.GET_tran_cuttinginfo_GAPgListView_Ext(tran_cuttinginfo_GAPgListView_ExtEntity tran_cuttinginfo_GAPgListView_ExtEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_tran_cuttinginfo_GAPgListView_Ext(tran_cuttinginfo_GAPgListView_ExtEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<tran_cuttinginfo_GAPgListView_ExtEntity> IReportExtensionFacade.rpt_tran_cuttinginfo_GAPgListView_Ext"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<tran_cuttinginfodetl_GAPgListView_ExtEntity> IReportExtensionFacade.GET_tran_cuttinginfodetl_GAPgListView_Ext(tran_cuttinginfodetl_GAPgListView_ExtEntity tran_cuttinginfodetl_GAPgListView_ExtEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_tran_cuttinginfodetl_GAPgListView_Ext(tran_cuttinginfodetl_GAPgListView_ExtEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<tran_cuttinginfodetl_GAPgListView_ExtEntity> IReportExtensionFacade.rpt_tran_cuttinginfodetl_GAPgListView_Ext"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<rpt_GetCuttingInfo_ExtEntity> IReportExtensionFacade.GET_rpt_GetCuttingInfo_Ext(rpt_GetCuttingInfo_ExtEntity rpt_GetCuttingInfo_ExtEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_rpt_GetCuttingInfo_Ext(rpt_GetCuttingInfo_ExtEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<rpt_GetCuttingInfo_ExtEntity> IReportExtensionFacade.rpt_rpt_GetCuttingInfo_Ext"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<rpt_GetTotalApplicableEntity> IReportExtensionFacade.GET_rpt_GetTotalApplicable(rpt_GetTotalApplicableEntity rpt_GetTotalApplicableEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_rpt_GetTotalApplicable(rpt_GetTotalApplicableEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<rpt_GetTotalApplicableEntity> IReportExtensionFacade.rpt_rpt_GetTotalApplicable"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<rpt_GetTotalApplicable_DetailEntity> IReportExtensionFacade.GET_rpt_GetTotalApplicable_Detail(rpt_GetTotalApplicable_DetailEntity rpt_GetTotalApplicable_DetailEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_rpt_GetTotalApplicable_Detail(rpt_GetTotalApplicable_DetailEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<rpt_GetTotalApplicable_DetailEntity> IReportExtensionFacade.rpt_rpt_GetTotalApplicable_Detail"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<rpt_CuttingSummaryEntity> IReportExtensionFacade.GET_rpt_CuttingSummary(rpt_CuttingSummaryEntity rpt_CuttingSummaryEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_rpt_CuttingSummary(rpt_CuttingSummaryEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<rpt_CuttingSummaryEntity> IReportExtensionFacade.rpt_rpt_CuttingSummary"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<rpt_CuttingSummeryIndividualEntity> IReportExtensionFacade.GET_rpt_CuttingSummeryIndividual(rpt_CuttingSummeryIndividualEntity rpt_CuttingSummeryIndividualEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_rpt_CuttingSummeryIndividual(rpt_CuttingSummeryIndividualEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<rpt_CuttingSummeryIndividualEntity> IReportExtensionFacade.rpt_rpt_CuttingSummeryIndividual"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<KAF_GetLeaveBalanceEntity> IReportExtensionFacade.GET_KAF_GetLeaveBalance(KAF_GetLeaveBalanceEntity KAF_GetLeaveBalanceEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_KAF_GetLeaveBalance(KAF_GetLeaveBalanceEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<KAF_GetLeaveBalanceEntity> IReportExtensionFacade.rpt_KAF_GetLeaveBalance"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<KAFProcess_ManpoewrStateEntity> IReportExtensionFacade.GET_KAFProcess_ManpoewrState(KAFProcess_ManpoewrStateEntity KAFProcess_ManpoewrStateEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_KAFProcess_ManpoewrState(KAFProcess_ManpoewrStateEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("Int64 IReportExtensionFacade.rpt_KAFProcess_ManpoewrState"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<rpt_ManpoewrStateByStatusEntity> IReportExtensionFacade.GET_rpt_ManpoewrStateByStatus(rpt_ManpoewrStateByStatusEntity rpt_ManpoewrStateByStatusEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_rpt_ManpoewrStateByStatus(rpt_ManpoewrStateByStatusEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<rpt_ManpoewrStateByStatusEntity> IReportExtensionFacade.rpt_rpt_ManpoewrStateByStatus"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<rpt_ManpoewrStateEntity> IReportExtensionFacade.GET_rpt_ManpoewrState(rpt_ManpoewrStateEntity rpt_ManpoewrStateEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_rpt_ManpoewrState(rpt_ManpoewrStateEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<rpt_ManpoewrStateEntity> IReportExtensionFacade.rpt_rpt_ManpoewrState"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<Kaf_tran_cuttinginfo_ProcessCountEntity> IReportExtensionFacade.GET_Kaf_tran_cuttinginfo_ProcessCount(Kaf_tran_cuttinginfo_ProcessCountEntity Kaf_tran_cuttinginfo_ProcessCountEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_Kaf_tran_cuttinginfo_ProcessCount(Kaf_tran_cuttinginfo_ProcessCountEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<Kaf_tran_cuttinginfo_ProcessCountEntity> IReportExtensionFacade.rpt_Kaf_tran_cuttinginfo_ProcessCount"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<rpt_OkpWiseManpowerStateHeldEntity> IReportExtensionFacade.GET_rpt_OkpWiseManpowerStateHeld(rpt_OkpWiseManpowerStateHeldEntity rpt_OkpWiseManpowerStateHeldEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_rpt_OkpWiseManpowerStateHeld(rpt_OkpWiseManpowerStateHeldEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<rpt_OkpWiseManpowerStateHeldEntity> IReportExtensionFacade.rpt_rpt_OkpWiseManpowerStateHeld"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<rpt_OkpWiseManpowerStateEntity> IReportExtensionFacade.GET_rpt_OkpWiseManpowerState(rpt_OkpWiseManpowerStateEntity rpt_OkpWiseManpowerStateEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_rpt_OkpWiseManpowerState(rpt_OkpWiseManpowerStateEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<rpt_OkpWiseManpowerStateEntity> IReportExtensionFacade.rpt_rpt_OkpWiseManpowerState"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<rpt_CampWiseManpowerStateHeldEntity> IReportExtensionFacade.GET_rpt_CampWiseManpowerStateHeld(rpt_CampWiseManpowerStateHeldEntity rpt_CampWiseManpowerStateHeldEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_rpt_CampWiseManpowerStateHeld(rpt_CampWiseManpowerStateHeldEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<rpt_CampWiseManpowerStateHeldEntity> IReportExtensionFacade.rpt_rpt_CampWiseManpowerStateHeld"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<rpt_LeaveInfoEntity> IReportExtensionFacade.GET_rpt_LeaveInfo(rpt_LeaveInfoEntity rpt_LeaveInfoEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_rpt_LeaveInfo(rpt_LeaveInfoEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<rpt_LeaveInfoEntity> IReportExtensionFacade.rpt_rpt_LeaveInfo"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<rpt_RepatriationInfoEntity> IReportExtensionFacade.GET_rpt_RepatriationInfo(rpt_RepatriationInfoEntity rpt_RepatriationInfoEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_rpt_RepatriationInfo(rpt_RepatriationInfoEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<rpt_RepatriationInfoEntity> IReportExtensionFacade.rpt_rpt_RepatriationInfo"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<rpt_HospitalInfoEntity> IReportExtensionFacade.GET_rpt_HospitalInfo(rpt_HospitalInfoEntity rpt_HospitalInfoEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_rpt_HospitalInfo(rpt_HospitalInfoEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<rpt_HospitalInfoEntity> IReportExtensionFacade.rpt_rpt_HospitalInfo"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<rpt_DeploymentStateEntity> IReportExtensionFacade.GET_rpt_DeploymentState(rpt_DeploymentStateEntity rpt_DeploymentStateEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_rpt_DeploymentState(rpt_DeploymentStateEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<rpt_DeploymentStateEntity> IReportExtensionFacade.rpt_rpt_DeploymentState"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<rpt_OkpWiseManpowerStateHeldAuthEntity> IReportExtensionFacade.GET_rpt_OkpWiseManpowerStateHeldAuth(rpt_OkpWiseManpowerStateHeldAuthEntity rpt_OkpWiseManpowerStateHeldAuthEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().Get_rpt_OkpWiseManpowerStateHeldAuth(rpt_OkpWiseManpowerStateHeldAuthEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<rpt_OkpWiseManpowerStateHeldAuthEntity> IReportExtensionFacade.rpt_rpt_OkpWiseManpowerStateHeldAuth"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<EmployeeDocumentInfoEntity> IReportExtensionFacade.FamilyPassportInfoExpire(EmployeeDocumentInfoEntity FamilyPassportInfoEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().FamilyPassportInfoExpire(FamilyPassportInfoEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<rpt_OkpWiseManpowerStateHeldAuthEntity> IReportExtensionFacade.rpt_rpt_OkpWiseManpowerStateHeldAuth"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<EmployeeDocumentInfoEntity> IReportExtensionFacade.OfficerPassportInfoExpire(EmployeeDocumentInfoEntity FamilyPassportInfoEntity)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().OfficerPassportInfoExpire(FamilyPassportInfoEntity).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<rpt_OkpWiseManpowerStateHeldAuthEntity> IReportExtensionFacade.rpt_rpt_OkpWiseManpowerStateHeldAuth"));
			}
			catch (Exception exx)
			{  
				throw exx;
			}
		}

		IList<rptOfficersExpiryInfoEntity> IReportExtensionFacade.OfficersExpiryInfoData(rptOfficersExpiryInfoEntity rptOfficersExpiryInfo)
		{
			try
			{
				return DataAccessFactory.CreateReportExtensionDataAccess().OfficersExpiryInfoData(rptOfficersExpiryInfo).ToList();
			}
			catch (DataException ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<rpt_OkpWiseManpowerStateHeldAuthEntity> IReportExtensionFacade.OfficersExpiryInfoData"));
			}
			catch (Exception exx)
			{
				throw exx;
			}
		}
	}
}
