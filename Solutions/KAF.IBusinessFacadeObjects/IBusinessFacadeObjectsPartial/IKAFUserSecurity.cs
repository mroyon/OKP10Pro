using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.ServiceModel;
using KAF.BusinessDataObjects;

using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects.IBusinessFacadeObjectsPartial
{
    [ServiceContract(Name = "IKAFUserSecurity")]
    public interface IKAFUserSecurity : IDisposable
    {
        #region

        [OperationContract]
        KAF_LoadPermissionToUseEntity LoadNewGetFromDB(SecurityCapsule securityCapsule);
        [OperationContract]
        IList<clsUserNameAndNumberEntity> GetUserNameAndIDByCatetory(clsUserNameAndNumberEntity entity);

        #endregion
        [OperationContract]
        long UpdateEmailAddress(List<KAF_GetUserInfoByCredentialEntity> objEn);

        [OperationContract]
        KAF_GetUserInfoByCredentialEntity GetUserInfoByMsterUserIDShortProfile(long MasterUserID);

        [OperationContract]
        KAF_GetUserInfoByCredentialEntity GetUserByName(string UserName);

        [OperationContract]
        KAF_GetUserInfoByCredentialEntity ValidateInfoByUserNameAndPassword_Ext(string UserName, string SessionID, long LoginSerial);
        [OperationContract]
        KAF_GetUserInfoByCredentialEntity ValidateInfoByUserNameAndPassword(string UserName, string Password, string BankToken);

        

        [OperationContract]
        IList<KAF_GetMenuHierarchyEntity> LoadMenuHierarchyList(long BankKey);


        [OperationContract]
        int SaveUpdatePreference(long FormID, long MasterUserID, int PrePageSize, SecurityCapsule Sec);




        [OperationContract]
        KAF_GetUserInfoByCredentialEntity UserProfileShortView(KAF_GetUserInfoByCredentialEntity objEntity);


        [OperationContract]
        IList<KAF_LoadMenuByUserIDEntity> LoadMenuByMasterUserID(long MasterUserID, long BankKey);



        [OperationContract]
        KAF_GetUserInfoByCredentialEntity GetUserNameAndPasswordByMasterUserID(long? MasterUserID, string TokenKey);

        [OperationContract]
        IList<Owin_ProcessGetFormActionistEntity> GetOwin_ProcessGetFormActionistEntity(long? RoleID);

        [OperationContract]
        IList<Owin_ProcessGetFormActionistEntity_Ext> GetOwin_ProcessGetFormActionistEntityExt(long? MasterUserID);

        [OperationContract]
        long Owin_UserPasswordChange(owin_userEntity objEntity);

        [OperationContract]
        long Owin_UserProfileUpdate(owin_userEntity objEntity);
        [OperationContract]
        long ForgetPasswordRequest(owin_userEntity objEntity);
        [OperationContract]
        long ForgetPasswordRequestProcess(owin_userEntity objEntity);

        [OperationContract]
        long AssignRolePermission(owin_rolepermissionEntity objEntity);

        [OperationContract]
        long CreateUser(owin_userEntity objEntity);
        [OperationContract]
        long UpdateUser(owin_userEntity objEntity);
        [OperationContract]
        long DeleteUser(owin_userEntity objEntity);


        [OperationContract]
        long UserStatusLockUpdate(owin_userEntity objEntity);
        [OperationContract]
        long UserApproveUpdate(owin_userEntity objEntity);
        [OperationContract]
        long UserReviewedUpdate(owin_userEntity objEntity);

        [OperationContract]
        IList<owin_userEntity> UserReviewGet(owin_userEntity objEntity);

        [OperationContract]
        IList<owin_userEntity> GetUserReviewByGroupData(owin_userEntity objEntity);

        long UserReviewedByGroupUpdate(owin_userEntity objEntity);

        [OperationContract]
        long UserPasswordResetUpdate(owin_userEntity objEntity);
        [OperationContract]
        long UserEmailUpdate(owin_userEntity objEntity);


        [OperationContract]
        long CreateRole_Ext(owin_roleEntity owin_role);
        [OperationContract]
        long UpdateRole_Ext(owin_roleEntity owin_role);
        [OperationContract]
        long DeleteRole_Ext(owin_roleEntity owin_role);


        [OperationContract]
        long SetReportRolePermission(owin_reportroletemplateEntity objEntity);

        [OperationContract]
        IList<rptm_allreportinfoEntity> LoadReportMenu(long MasterUserID);


    }
}
