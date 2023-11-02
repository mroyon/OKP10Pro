using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;



namespace KAFWebAdmin.HelperClasses
{
    public class clsReportingEntity
    {
		
		public List<KAF_GetNewDemandInfoEntity> KAF_GetNewDemandInfoEntity()
		{
			List<KAF_GetNewDemandInfoEntity> db = new List<KAF_GetNewDemandInfoEntity>();
			return db.ToList();
		}

		
		public List<KAF_GetReplacementInfoEntity> Get_KAF_GetReplacementInfo()
		{
			List<KAF_GetReplacementInfoEntity> db = new List<KAF_GetReplacementInfoEntity>();
			return db.ToList();
		}

		public List<KAF_GetProfileInfoEntity> Get_KAF_GetProfileInfo()
		{
			List<KAF_GetProfileInfoEntity> db = new List<KAF_GetProfileInfoEntity>();
			return db.ToList();
		}

        public List<KAF_GetReplacementListByREplacementIDEntity> KAF_GetReplacementListByREplacementIDEntity()
        {
            List<KAF_GetReplacementListByREplacementIDEntity> db = new List<KAF_GetReplacementListByREplacementIDEntity>();
            return db.ToList();
        }

        public List<KAF_GetRepPassportListByRepPassportIDEntity> KAF_GetRepPassportListByRepPassportIDList()
        {
            List<KAF_GetRepPassportListByRepPassportIDEntity> db = new List<KAF_GetRepPassportListByRepPassportIDEntity>();
            return db.ToList();
        }

        public List<KAF_GetDemandListByDemandIDEntity> KAF_GetDemandListByDemandIDEntity()
        {
            List<KAF_GetDemandListByDemandIDEntity> db = new List<KAF_GetDemandListByDemandIDEntity>();
            return db.ToList();
        }

        public List<KAF_GetVisaIssueListByVisaIssueIDEntity> KAF_GetVisaIssueListByVisaIssueIDList()
        {
            List<KAF_GetVisaIssueListByVisaIssueIDEntity> db = new List<KAF_GetVisaIssueListByVisaIssueIDEntity>();
            return db.ToList();
        }

        public List<KAF_GetVisaSentListByVisaSentIDEntity> KAF_GetVisaSentListByVisaSentIDList()
        {
            List<KAF_GetVisaSentListByVisaSentIDEntity> db = new List<KAF_GetVisaSentListByVisaSentIDEntity>();
            return db.ToList();
        }

        public List<KAF_GetPTADemandListByPTADemandIDEntity> KAF_GetPTADemandListByPTADemandIDList()
        {
            List<KAF_GetPTADemandListByPTADemandIDEntity> db = new List<KAF_GetPTADemandListByPTADemandIDEntity>();
            return db.ToList();
        }

        public List<KAF_GetPTAReceivedListByPTAReceiveIDEntity> KAF_GetPTAReceivedListByPTAReceiveIDList()
        {
            List<KAF_GetPTAReceivedListByPTAReceiveIDEntity> db = new List<KAF_GetPTAReceivedListByPTAReceiveIDEntity>();
            return db.ToList();
        }

        public List<KAF_GetFlightListByFlightIDEntity> KAF_GetFlightListByFlightIDList()
        {
            List<KAF_GetFlightListByFlightIDEntity> db = new List<KAF_GetFlightListByFlightIDEntity>();
            return db.ToList();
        }

        public List<KAF_GetNewDemandInfoEntity> KAF_GetNewDemandInfoList()
        {
            List<KAF_GetNewDemandInfoEntity> db = new List<KAF_GetNewDemandInfoEntity>();
            return db.ToList();
        }

		public List<rpt_GetReplacementPassportInfoEntity> Get_rpt_GetReplacementPassportInfo()
		{
			List<rpt_GetReplacementPassportInfoEntity> db = new List<rpt_GetReplacementPassportInfoEntity>();
			return db.ToList();
		}

		public List<rpt_issueofvisaandptaEntity> Get_rpt_issueofvisaandpta()
		{
			List<rpt_issueofvisaandptaEntity> db = new List<rpt_issueofvisaandptaEntity>();
			return db.ToList();
		}

		public List<rpt_visareceivedpersonnelEntity> Get_rpt_visareceivedpersonnel()
		{
			List<rpt_visareceivedpersonnelEntity> db = new List<rpt_visareceivedpersonnelEntity>();
			return db.ToList();
		}

		public List<rpt_newdemanddetailsEntity> Get_rpt_newdemanddetails()
		{
			List<rpt_newdemanddetailsEntity> db = new List<rpt_newdemanddetailsEntity>();
			return db.ToList();
		}

		public List<rpt_arrivalreportEntity> Get_rpt_arrivalreport()
		{
			List<rpt_arrivalreportEntity> db = new List<rpt_arrivalreportEntity>();
			return db.ToList();
		}

		public List<rpt_ptareceivedwithflightinfoEntity> Get_rpt_ptareceivedwithflightinfo()
		{
			List<rpt_ptareceivedwithflightinfoEntity> db = new List<rpt_ptareceivedwithflightinfoEntity>();
			return db.ToList();
		}

		public List<rpt_OkpSummaryOkpwiseEntity> Get_rpt_OkpSummaryOkpwiseEntity()
		{
			List<rpt_OkpSummaryOkpwiseEntity> db = new List<rpt_OkpSummaryOkpwiseEntity>();
			return db.ToList();
		}

		public List<rpt_BMCStrengthSummaryEntity> Get_rpt_BMCStrengthSummary()
		{
			List<rpt_BMCStrengthSummaryEntity> db = new List<rpt_BMCStrengthSummaryEntity>();
			return db.ToList();
		}

		public List<KAF_GetChildUnitsEntity> Get_KAF_GetChildUnits()
		{
			List<KAF_GetChildUnitsEntity> db = new List<KAF_GetChildUnitsEntity>();
			return db.ToList();
		}

		public List<KAF_CuttingInsertEntity> Get_KAF_CuttingInsert()
		{
			List<KAF_CuttingInsertEntity> db = new List<KAF_CuttingInsertEntity>();
			return db.ToList();
		}

		public List<rpt_GetCuttingInfoEntity> Get_rpt_GetCuttingInfo()
		{
			List<rpt_GetCuttingInfoEntity> db = new List<rpt_GetCuttingInfoEntity>();
			return db.ToList();
		}

		public List<KAF_GetRankByGroupEntity> Get_KAF_GetRankByGroup()
		{
			List<KAF_GetRankByGroupEntity> db = new List<KAF_GetRankByGroupEntity>();
			return db.ToList();
		}

		public List<tran_cuttinginfodetl_GAPgListView_ExtEntity> Get_tran_cuttinginfodetl_GAPgListView_Ext()
		{
			List<tran_cuttinginfodetl_GAPgListView_ExtEntity> db = new List<tran_cuttinginfodetl_GAPgListView_ExtEntity>();
			return db.ToList();
		}

		public List<rpt_GetCuttingInfo_ExtEntity> Get_rpt_GetCuttingInfo_Ext()
		{
			List<rpt_GetCuttingInfo_ExtEntity> db = new List<rpt_GetCuttingInfo_ExtEntity>();
			return db.ToList();
		}

		public List<rpt_GetTotalApplicableEntity> Get_rpt_GetTotalApplicable()
		{
			List<rpt_GetTotalApplicableEntity> db = new List<rpt_GetTotalApplicableEntity>();
			return db.ToList();
		}

		public List<rpt_CuttingSummaryEntity> Get_rpt_CuttingSummary()
		{
			List<rpt_CuttingSummaryEntity> db = new List<rpt_CuttingSummaryEntity>();
			return db.ToList();
		}

		public List<rpt_CuttingSummeryIndividualEntity> Get_rpt_CuttingSummeryIndividualList()
		{
			List<rpt_CuttingSummeryIndividualEntity> db = new List<rpt_CuttingSummeryIndividualEntity>();
			return db.ToList();
		}

		public List<KAF_GetLeaveBalanceEntity> Get_KAF_GetLeaveBalance()
		{
			List<KAF_GetLeaveBalanceEntity> db = new List<KAF_GetLeaveBalanceEntity>();
			return db.ToList();
		}

		public List<KAFProcess_ManpoewrStateEntity> Get_KAFProcess_ManpoewrState()
		{
			List<KAFProcess_ManpoewrStateEntity> db = new List<KAFProcess_ManpoewrStateEntity>();
			return db.ToList();
		}

		public List<rpt_ManpoewrStateEntity> Get_rpt_ManpoewrState()
		{
			List<rpt_ManpoewrStateEntity> db = new List<rpt_ManpoewrStateEntity>();
			return db.ToList();
		}

		public List<Kaf_tran_cuttinginfo_ProcessCountEntity> Get_Kaf_tran_cuttinginfo_ProcessCount()
		{
			List<Kaf_tran_cuttinginfo_ProcessCountEntity> db = new List<Kaf_tran_cuttinginfo_ProcessCountEntity>();
			return db.ToList();
		}

		public List<rpt_OkpWiseManpowerStateHeldEntity> Get_rpt_OkpWiseManpowerStateHeld()
		{
			List<rpt_OkpWiseManpowerStateHeldEntity> db = new List<rpt_OkpWiseManpowerStateHeldEntity>();
			return db.ToList();
		}

		public List<rpt_OkpWiseManpowerStateEntity> Get_rpt_OkpWiseManpowerState()
		{
			List<rpt_OkpWiseManpowerStateEntity> db = new List<rpt_OkpWiseManpowerStateEntity>();
			return db.ToList();
		}

		public List<rpt_CampWiseManpowerStateHeldEntity> Get_rpt_CampWiseManpowerStateHeld()
		{
			List<rpt_CampWiseManpowerStateHeldEntity> db = new List<rpt_CampWiseManpowerStateHeldEntity>();
			return db.ToList();
		}

		public List<rpt_LeaveInfoEntity> Get_rpt_LeaveInfo()
		{
			List<rpt_LeaveInfoEntity> db = new List<rpt_LeaveInfoEntity>();
			return db.ToList();
		}

		public List<rpt_RepatriationInfoEntity> Get_rpt_RepatriationInfo()
		{
			List<rpt_RepatriationInfoEntity> db = new List<rpt_RepatriationInfoEntity>();
			return db.ToList();
		}

		public List<rpt_HospitalInfoEntity> Get_rpt_HospitalInfo()
		{
			List<rpt_HospitalInfoEntity> db = new List<rpt_HospitalInfoEntity>();
			return db.ToList();
		}

		public List<rpt_DeploymentStateEntity> Get_rpt_DeploymentState()
		{
			List<rpt_DeploymentStateEntity> db = new List<rpt_DeploymentStateEntity>();
			return db.ToList();
		}

		public List<rpt_OkpWiseManpowerStateHeldAuthEntity> Get_rpt_OkpWiseManpowerStateHeldAuth()
		{
			List<rpt_OkpWiseManpowerStateHeldAuthEntity> db = new List<rpt_OkpWiseManpowerStateHeldAuthEntity>();
			return db.ToList();
		}

		public List<EmployeeDocumentInfoEntity> OfficerPassportInfoExpire()
		{
			List<EmployeeDocumentInfoEntity> db = new List<EmployeeDocumentInfoEntity>();
			return db.ToList();
		}
	}
}
