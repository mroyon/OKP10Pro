using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using KAF.BusinessDataObjects;
using System.Data;


namespace KAF.IDataAccessObjects.IDataAccessObjectsPartial
{
    public interface IReportExtensionDataAccess
    {
        
		IList<KAF_GetReplacementListByREplacementIDEntity> Get_KAF_GetReplacementListByREplacementID(KAF_GetReplacementListByREplacementIDEntity KAF_GetMilitaryPersonalInfoEntity);

		IList<KAF_GetReplacementPassportListByRepPassportIDEntity> Get_KAF_GetReplacementPassportListByRepPassportID(KAF_GetReplacementPassportListByRepPassportIDEntity KAF_GetReplacementPassportListByRepPassportIDEntity);

		IList<KAF_GetVisaDemandListByVisaDemandIDEntity> Get_KAF_GetVisaDemandListByVisaDemandID(KAF_GetVisaDemandListByVisaDemandIDEntity KAF_GetVisaDemandListByVisaDemandIDEntity);

		IList<KAF_GetRepPassportListByRepPassportIDEntity> Get_KAF_GetRepPassportListByRepPassportID(KAF_GetRepPassportListByRepPassportIDEntity KAF_GetRepPassportListByRepPassportIDEntity);

		IList<KAF_GetDemandListByDemandIDEntity> Get_KAF_GetDemandListByDemandID(KAF_GetDemandListByDemandIDEntity KAF_GetDemandListByDemandIDEntity);

		IList<KAF_GetVisaIssueListByVisaIssueIDEntity> Get_KAF_GetVisaIssueListByVisaIssueID(KAF_GetVisaIssueListByVisaIssueIDEntity KAF_GetVisaIssueListByVisaIssueIDEntity);

		IList<KAF_GetVisaSentListByVisaSentIDEntity> Get_KAF_GetVisaSentListByVisaSentID(KAF_GetVisaSentListByVisaSentIDEntity KAF_GetVisaSentListByVisaSentIDEntity);

		IList<KAF_GetPTADemandListByPTADemandIDEntity> Get_KAF_GetPTADemandListByPTADemandID(KAF_GetPTADemandListByPTADemandIDEntity KAF_GetPTADemandListByPTADemandIDEntity);

		IList<KAF_GetFlightListByFlightIDEntity> Get_KAF_GetFlightListByFlightID(KAF_GetFlightListByFlightIDEntity KAF_GetFlightListByFlightIDEntity);

		IList<KAF_GetNewDemandInfoEntity> Get_KAF_GetNewDemandInfo(KAF_GetNewDemandInfoEntity KAF_GetNewDemandInfoEntity);

		IList<KAF_GetReplacementInfoEntity> Get_KAF_GetReplacementInfo(KAF_GetReplacementInfoEntity KAF_GetReplacementInfoEntity);

		IList<KAF_GetProfileInfoEntity> Get_KAF_GetProfileInfo(KAF_GetProfileInfoEntity KAF_GetProfileInfoEntity);

		long Get_KAFProcess_UpdateLetterStatus(KAFProcess_UpdateLetterStatusEntity KAFProcess_UpdateLetterStatusEntity);

		IList<hr_flightcancelinfo_GAPgListView_ExtEntity> Get_hr_flightcancelinfo_GAPgListView_Ext(hr_flightcancelinfo_GAPgListView_ExtEntity hr_flightcancelinfo_GAPgListView_ExtEntity);

		IList<hr_flightinfodetlEntity> Get_hr_flightinfodetl_GAPgListView_Select2(hr_flightinfodetlEntity hr_flightinfodetlEntity);

		IList<KAF_GetPTAReceivedListByPTAReceiveIDEntity> Get_KAF_GetPTAReceivedListByPTAReceiveID(KAF_GetPTAReceivedListByPTAReceiveIDEntity KAF_GetPTAReceivedListByPTAReceiveIDEntity);

		IList<rpt_GetReplacementPassportInfoEntity> Get_rpt_GetReplacementPassportInfo(rpt_GetReplacementPassportInfoEntity rpt_GetReplacementPassportInfoEntity);

		IList<rpt_issueofvisaandptaEntity> Get_rpt_issueofvisaandpta(rpt_issueofvisaandptaEntity rpt_issueofvisaandptaEntity);

		IList<rpt_visareceivedpersonnelEntity> Get_rpt_visareceivedpersonnel(rpt_visareceivedpersonnelEntity rpt_visareceivedpersonnelEntity);

		IList<rpt_newdemanddetailsEntity> Get_rpt_newdemanddetails(rpt_newdemanddetailsEntity rpt_newdemanddetailsEntity);

		IList<rpt_arrivalreportEntity> Get_rpt_arrivalreport(rpt_arrivalreportEntity rpt_arrivalreportEntity);

		IList<rpt_ptareceivedwithflightinfoEntity> Get_rpt_ptareceivedwithflightinfo(rpt_ptareceivedwithflightinfoEntity rpt_ptareceivedwithflightinfoEntity);

		IList<rpt_passportheldbyspabEntity> Get_rpt_passportheldbyspab(rpt_passportheldbyspabEntity rpt_passportheldbyspabEntity);

		IList<rpt_OkpSummaryOkpwiseEntity> Get_rpt_OkpSummaryOkpwise(rpt_OkpSummaryOkpwiseEntity rpt_OkpSummaryOkpwiseEntity);

		IList<rpt_BMCStrengthSummaryEntity> Get_rpt_BMCStrengthSummary(rpt_BMCStrengthSummaryEntity rpt_BMCStrengthSummaryEntity);

		IList<KAF_GetChildUnitsEntity> Get_KAF_GetChildUnits(KAF_GetChildUnitsEntity KAF_GetChildUnitsEntity);

		long Get_KAF_CuttingInsert(KAF_CuttingInsertEntity KAF_CuttingInsertEntity);

		IList<rpt_GetCuttingInfoEntity> Get_rpt_GetCuttingInfo(rpt_GetCuttingInfoEntity rpt_GetCuttingInfoEntity);

		IList<KAF_GetRankByGroupEntity> Get_KAF_GetRankByGroup(KAF_GetRankByGroupEntity KAF_GetRankByGroupEntity);

		IList<tran_cuttinginfo_GAPgListView_ExtEntity> Get_tran_cuttinginfo_GAPgListView_Ext(tran_cuttinginfo_GAPgListView_ExtEntity tran_cuttinginfo_GAPgListView_ExtEntity);

		IList<tran_cuttinginfodetl_GAPgListView_ExtEntity> Get_tran_cuttinginfodetl_GAPgListView_Ext(tran_cuttinginfodetl_GAPgListView_ExtEntity tran_cuttinginfodetl_GAPgListView_ExtEntity);

		IList<rpt_GetCuttingInfo_ExtEntity> Get_rpt_GetCuttingInfo_Ext(rpt_GetCuttingInfo_ExtEntity rpt_GetCuttingInfo_ExtEntity);

		IList<rpt_GetTotalApplicableEntity> Get_rpt_GetTotalApplicable(rpt_GetTotalApplicableEntity rpt_GetTotalApplicableEntity);

		IList<rpt_GetTotalApplicable_DetailEntity> Get_rpt_GetTotalApplicable_Detail(rpt_GetTotalApplicable_DetailEntity rpt_GetTotalApplicable_DetailEntity);

		IList<rpt_CuttingSummaryEntity> Get_rpt_CuttingSummary(rpt_CuttingSummaryEntity rpt_CuttingSummaryEntity);

		IList<rpt_CuttingSummeryIndividualEntity> Get_rpt_CuttingSummeryIndividual(rpt_CuttingSummeryIndividualEntity rpt_CuttingSummeryIndividualEntity);

		IList<KAF_GetLeaveBalanceEntity> Get_KAF_GetLeaveBalance(KAF_GetLeaveBalanceEntity KAF_GetLeaveBalanceEntity);

		IList<KAFProcess_ManpoewrStateEntity> Get_KAFProcess_ManpoewrState(KAFProcess_ManpoewrStateEntity KAFProcess_ManpoewrStateEntity);

		IList<rpt_ManpoewrStateByStatusEntity> Get_rpt_ManpoewrStateByStatus(rpt_ManpoewrStateByStatusEntity rpt_ManpoewrStateByStatusEntity);

		IList<rpt_ManpoewrStateEntity> Get_rpt_ManpoewrState(rpt_ManpoewrStateEntity rpt_ManpoewrStateEntity);

		IList<Kaf_tran_cuttinginfo_ProcessCountEntity> Get_Kaf_tran_cuttinginfo_ProcessCount(Kaf_tran_cuttinginfo_ProcessCountEntity Kaf_tran_cuttinginfo_ProcessCountEntity);

		IList<rpt_OkpWiseManpowerStateHeldEntity> Get_rpt_OkpWiseManpowerStateHeld(rpt_OkpWiseManpowerStateHeldEntity rpt_OkpWiseManpowerStateHeldEntity);

		IList<rpt_OkpWiseManpowerStateEntity> Get_rpt_OkpWiseManpowerState(rpt_OkpWiseManpowerStateEntity rpt_OkpWiseManpowerStateEntity);

		IList<rpt_CampWiseManpowerStateHeldEntity> Get_rpt_CampWiseManpowerStateHeld(rpt_CampWiseManpowerStateHeldEntity rpt_CampWiseManpowerStateHeldEntity);

		IList<rpt_LeaveInfoEntity> Get_rpt_LeaveInfo(rpt_LeaveInfoEntity rpt_LeaveInfoEntity);

		IList<rpt_RepatriationInfoEntity> Get_rpt_RepatriationInfo(rpt_RepatriationInfoEntity rpt_RepatriationInfoEntity);

		IList<rpt_HospitalInfoEntity> Get_rpt_HospitalInfo(rpt_HospitalInfoEntity rpt_HospitalInfoEntity);

		IList<rpt_DeploymentStateEntity> Get_rpt_DeploymentState(rpt_DeploymentStateEntity rpt_DeploymentStateEntity);

		IList<rpt_OkpWiseManpowerStateHeldAuthEntity> Get_rpt_OkpWiseManpowerStateHeldAuth(rpt_OkpWiseManpowerStateHeldAuthEntity rpt_OkpWiseManpowerStateHeldAuthEntity);
		IList<EmployeeDocumentInfoEntity> FamilyPassportInfoExpire(EmployeeDocumentInfoEntity FamilyPassportInfo);
		IList<EmployeeDocumentInfoEntity> OfficerPassportInfoExpire(EmployeeDocumentInfoEntity FamilyPassportInfo);

		
	}
}
