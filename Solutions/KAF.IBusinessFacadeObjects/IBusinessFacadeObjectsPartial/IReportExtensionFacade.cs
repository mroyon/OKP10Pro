using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using KAF.BusinessDataObjects;
using System.Data;


namespace KAF.IBusinessFacadeObjects.IBusinessFacadeObjectsPartial
{
    [ServiceContract(Name = "IReportExtensionFacade")]
    public interface IReportExtensionFacade : IDisposable
    {
		
		[OperationContract]
		IList<KAF_GetReplacementListByREplacementIDEntity> Get_KAF_GetReplacementListByREplacementID(KAF_GetReplacementListByREplacementIDEntity KAF_GetMilitaryPersonalInfoEntity);

		[OperationContract]
		IList<KAF_GetReplacementPassportListByRepPassportIDEntity> GET_KAF_GetReplacementPassportListByRepPassportID(KAF_GetReplacementPassportListByRepPassportIDEntity KAF_GetReplacementPassportListByRepPassportIDEntity);

		[OperationContract]
		IList<KAF_GetVisaDemandListByVisaDemandIDEntity> GET_KAF_GetVisaDemandListByVisaDemandID(KAF_GetVisaDemandListByVisaDemandIDEntity KAF_GetVisaDemandListByVisaDemandIDEntity);

		[OperationContract]
		IList<KAF_GetRepPassportListByRepPassportIDEntity> GET_KAF_GetRepPassportListByRepPassportID(KAF_GetRepPassportListByRepPassportIDEntity KAF_GetRepPassportListByRepPassportIDEntity);

		[OperationContract]
		IList<KAF_GetDemandListByDemandIDEntity> GET_KAF_GetDemandListByDemandID(KAF_GetDemandListByDemandIDEntity KAF_GetDemandListByDemandIDEntity);

		[OperationContract]
		IList<KAF_GetVisaIssueListByVisaIssueIDEntity> GET_KAF_GetVisaIssueListByVisaIssueID(KAF_GetVisaIssueListByVisaIssueIDEntity KAF_GetVisaIssueListByVisaIssueIDEntity);

		[OperationContract]
		IList<KAF_GetVisaSentListByVisaSentIDEntity> GET_KAF_GetVisaSentListByVisaSentID(KAF_GetVisaSentListByVisaSentIDEntity KAF_GetVisaSentListByVisaSentIDEntity);

		[OperationContract]
		IList<KAF_GetPTADemandListByPTADemandIDEntity> GET_KAF_GetPTADemandListByPTADemandID(KAF_GetPTADemandListByPTADemandIDEntity KAF_GetPTADemandListByPTADemandIDEntity);

		[OperationContract]
		IList<KAF_GetFlightListByFlightIDEntity> GET_KAF_GetFlightListByFlightID(KAF_GetFlightListByFlightIDEntity KAF_GetFlightListByFlightIDEntity);

		[OperationContract]
		IList<KAF_GetNewDemandInfoEntity> GET_KAF_GetNewDemandInfo(KAF_GetNewDemandInfoEntity KAF_GetNewDemandInfoEntity);

		[OperationContract]
		IList<KAF_GetReplacementInfoEntity> GET_KAF_GetReplacementInfo(KAF_GetReplacementInfoEntity KAF_GetReplacementInfoEntity);

		[OperationContract]
		IList<KAF_GetProfileInfoEntity> GET_KAF_GetProfileInfo(KAF_GetProfileInfoEntity KAF_GetProfileInfoEntity);

		[OperationContract]
		long GET_KAFProcess_UpdateLetterStatus(KAFProcess_UpdateLetterStatusEntity KAFProcess_UpdateLetterStatusEntity);

		[OperationContract]
		IList<hr_flightcancelinfo_GAPgListView_ExtEntity> GET_hr_flightcancelinfo_GAPgListView_Ext(hr_flightcancelinfo_GAPgListView_ExtEntity hr_flightcancelinfo_GAPgListView_ExtEntity);

		[OperationContract]
		IList<hr_flightinfodetlEntity> GET_hr_flightinfodetl_GAPgListView_Select2(hr_flightinfodetlEntity hr_flightinfodetlEntity);

		[OperationContract]
		IList<KAF_GetPTAReceivedListByPTAReceiveIDEntity> GET_KAF_GetPTAReceivedListByPTAReceiveID(KAF_GetPTAReceivedListByPTAReceiveIDEntity KAF_GetPTAReceivedListByPTAReceiveIDEntity);

		[OperationContract]
		IList<rpt_GetReplacementPassportInfoEntity> GET_rpt_GetReplacementPassportInfo(rpt_GetReplacementPassportInfoEntity rpt_GetReplacementPassportInfoEntity);

		[OperationContract]
		IList<rpt_issueofvisaandptaEntity> GET_rpt_issueofvisaandpta(rpt_issueofvisaandptaEntity rpt_issueofvisaandptaEntity);

		[OperationContract]
		IList<rpt_visareceivedpersonnelEntity> GET_rpt_visareceivedpersonnel(rpt_visareceivedpersonnelEntity rpt_visareceivedpersonnelEntity);

		[OperationContract]
		IList<rpt_newdemanddetailsEntity> GET_rpt_newdemanddetails(rpt_newdemanddetailsEntity rpt_newdemanddetailsEntity);

		[OperationContract]
		IList<rpt_arrivalreportEntity> GET_rpt_arrivalreport(rpt_arrivalreportEntity rpt_arrivalreportEntity);

		[OperationContract]
		IList<rpt_ptareceivedwithflightinfoEntity> GET_rpt_ptareceivedwithflightinfo(rpt_ptareceivedwithflightinfoEntity rpt_ptareceivedwithflightinfoEntity);

		[OperationContract]
		IList<rpt_passportheldbyspabEntity> GET_rpt_passportheldbyspab(rpt_passportheldbyspabEntity rpt_passportheldbyspabEntity);

		[OperationContract]
		IList<rpt_OkpSummaryOkpwiseEntity> GET_rpt_OkpSummaryOkpwise(rpt_OkpSummaryOkpwiseEntity rpt_OkpSummaryOkpwiseEntity);

		[OperationContract]
		IList<rpt_BMCStrengthSummaryEntity> GET_rpt_BMCStrengthSummary(rpt_BMCStrengthSummaryEntity rpt_BMCStrengthSummaryEntity);

		[OperationContract]
		IList<KAF_GetChildUnitsEntity> GET_KAF_GetChildUnits(KAF_GetChildUnitsEntity KAF_GetChildUnitsEntity);

		[OperationContract]
		long GET_KAF_CuttingInsert(KAF_CuttingInsertEntity KAF_CuttingInsertEntity);

		[OperationContract]
		IList<rpt_GetCuttingInfoEntity> GET_rpt_GetCuttingInfo(rpt_GetCuttingInfoEntity rpt_GetCuttingInfoEntity);

		[OperationContract]
		IList<KAF_GetRankByGroupEntity> GET_KAF_GetRankByGroup(KAF_GetRankByGroupEntity KAF_GetRankByGroupEntity);

		[OperationContract]
		IList<tran_cuttinginfo_GAPgListView_ExtEntity> GET_tran_cuttinginfo_GAPgListView_Ext(tran_cuttinginfo_GAPgListView_ExtEntity tran_cuttinginfo_GAPgListView_ExtEntity);

		[OperationContract]
		IList<tran_cuttinginfodetl_GAPgListView_ExtEntity> GET_tran_cuttinginfodetl_GAPgListView_Ext(tran_cuttinginfodetl_GAPgListView_ExtEntity tran_cuttinginfodetl_GAPgListView_ExtEntity);

		[OperationContract]
		IList<rpt_GetCuttingInfo_ExtEntity> GET_rpt_GetCuttingInfo_Ext(rpt_GetCuttingInfo_ExtEntity rpt_GetCuttingInfo_ExtEntity);

		[OperationContract]
		IList<rpt_GetTotalApplicableEntity> GET_rpt_GetTotalApplicable(rpt_GetTotalApplicableEntity rpt_GetTotalApplicableEntity);

		[OperationContract]
		IList<rpt_GetTotalApplicable_DetailEntity> GET_rpt_GetTotalApplicable_Detail(rpt_GetTotalApplicable_DetailEntity rpt_GetTotalApplicable_DetailEntity);

		[OperationContract]
		IList<rpt_CuttingSummaryEntity> GET_rpt_CuttingSummary(rpt_CuttingSummaryEntity rpt_CuttingSummaryEntity);

		[OperationContract]
		IList<rpt_CuttingSummeryIndividualEntity> GET_rpt_CuttingSummeryIndividual(rpt_CuttingSummeryIndividualEntity rpt_CuttingSummeryIndividualEntity);

		[OperationContract]
		IList<KAF_GetLeaveBalanceEntity> GET_KAF_GetLeaveBalance(KAF_GetLeaveBalanceEntity KAF_GetLeaveBalanceEntity);

		[OperationContract]
		IList<KAFProcess_ManpoewrStateEntity> GET_KAFProcess_ManpoewrState(KAFProcess_ManpoewrStateEntity KAFProcess_ManpoewrStateEntity);

		[OperationContract]
		IList<rpt_ManpoewrStateByStatusEntity> GET_rpt_ManpoewrStateByStatus(rpt_ManpoewrStateByStatusEntity rpt_ManpoewrStateByStatusEntity);

		[OperationContract]
		IList<rpt_ManpoewrStateEntity> GET_rpt_ManpoewrState(rpt_ManpoewrStateEntity rpt_ManpoewrStateEntity);

		[OperationContract]
		IList<Kaf_tran_cuttinginfo_ProcessCountEntity> GET_Kaf_tran_cuttinginfo_ProcessCount(Kaf_tran_cuttinginfo_ProcessCountEntity Kaf_tran_cuttinginfo_ProcessCountEntity);

		[OperationContract]
		IList<rpt_OkpWiseManpowerStateHeldEntity> GET_rpt_OkpWiseManpowerStateHeld(rpt_OkpWiseManpowerStateHeldEntity rpt_OkpWiseManpowerStateHeldEntity);

		[OperationContract]
		IList<rpt_OkpWiseManpowerStateEntity> GET_rpt_OkpWiseManpowerState(rpt_OkpWiseManpowerStateEntity rpt_OkpWiseManpowerStateEntity);

		[OperationContract]
		IList<rpt_CampWiseManpowerStateHeldEntity> GET_rpt_CampWiseManpowerStateHeld(rpt_CampWiseManpowerStateHeldEntity rpt_CampWiseManpowerStateHeldEntity);

		[OperationContract]
		IList<rpt_LeaveInfoEntity> GET_rpt_LeaveInfo(rpt_LeaveInfoEntity rpt_LeaveInfoEntity);

		[OperationContract]
		IList<rpt_RepatriationInfoEntity> GET_rpt_RepatriationInfo(rpt_RepatriationInfoEntity rpt_RepatriationInfoEntity);

		[OperationContract]
		IList<rpt_HospitalInfoEntity> GET_rpt_HospitalInfo(rpt_HospitalInfoEntity rpt_HospitalInfoEntity);

		[OperationContract]
		IList<rpt_DeploymentStateEntity> GET_rpt_DeploymentState(rpt_DeploymentStateEntity rpt_DeploymentStateEntity);

		[OperationContract]
		IList<rpt_OkpWiseManpowerStateHeldAuthEntity> GET_rpt_OkpWiseManpowerStateHeldAuth(rpt_OkpWiseManpowerStateHeldAuthEntity rpt_OkpWiseManpowerStateHeldAuthEntity);
		[OperationContract]
        IList<EmployeeDocumentInfoEntity> FamilyPassportInfoExpire(EmployeeDocumentInfoEntity FamilyPassportInfo);
		[OperationContract]
        IList<EmployeeDocumentInfoEntity> OfficerPassportInfoExpire(EmployeeDocumentInfoEntity FamilyPassportInfo);

		[OperationContract]
		IList<rptOfficersExpiryInfoEntity> OfficersExpiryInfoData(rptOfficersExpiryInfoEntity rptOfficersExpiryInfo);
	}
}
