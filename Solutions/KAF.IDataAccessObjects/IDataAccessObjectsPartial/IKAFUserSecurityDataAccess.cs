using System;
using System.Collections.Generic;
using KAF.BusinessDataObjects;
using System.Data;
using System.Data.SqlClient;

using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;


namespace KAF.IDataAccessObjects.IDataAccessObjectsPartial
{
    public interface IKAFUserSecurityDataAccess
    {
        #region SELECTED METHODS

        KAF_LoadPermissionToUseEntity LoadNewGetFromDB(SecurityCapsule securityCapsule);
        IList<clsUserNameAndNumberEntity> GetUserNameAndIDByCatetory(clsUserNameAndNumberEntity entity);


        #endregion

        long UpdateEmailAddress(List<KAF_GetUserInfoByCredentialEntity> objEn);

        // long ResetPassword(UserProfileShortViewEntity objEn, bool? byUser = null);


        KAF_GetUserInfoByCredentialEntity GetUserByName(string UserName);

        IList<KAF_GetMenuHierarchyEntity> LoadMenuHierarchyList(long BankKey);


        int SaveUpdatePreference(long FormID, long MasterUserID, int PrePageSize, SecurityCapsule Sec);

        KAF_GetUserInfoByCredentialEntity UserProfileShortView(KAF_GetUserInfoByCredentialEntity objEntity);

        IList<KAF_LoadMenuByUserIDEntity> LoadMenuByMasterUserID(long MasterUserID, long BankKey);

        KAF_GetUserInfoByCredentialEntity ValidateInfoByUserNameAndPassword_Ext(string UserName, string SessionID, long LoginSerial);

        KAF_GetUserInfoByCredentialEntity ValidateInfoByUserNameAndPassword(string UserName, string Password, string BankToken);

        KAF_GetUserInfoByCredentialEntity GetUserInfoByMsterUserIDShortProfile(long MasterUserID);

        KAF_GetUserInfoByCredentialEntity GetUserNameAndPasswordByMasterUserID(long? MasterUserID, string TokenKey);

        IList<Owin_ProcessGetFormActionistEntity> GetOwin_ProcessGetFormActionistEntity(long? RoleID);
        IList<Owin_ProcessGetFormActionistEntity_Ext> GetOwin_ProcessGetFormActionistEntityExt(long? MasterUserID);

        long Owin_UserPasswordChange(owin_userEntity objEntity);

        long Owin_UserProfileUpdate(owin_userEntity objEntity);
        long ForgetPasswordRequest(owin_userEntity objEntity);
        long ForgetPasswordRequestProcess(owin_userEntity objEntity);

        long AssignRolePermission(owin_rolepermissionEntity objEntity);

        long CreateUser(owin_userEntity objEntity);
        long UpdateUser(owin_userEntity objEntity);
        long DeleteUser(owin_userEntity objEntity);


        long UserStatusLockUpdate(owin_userEntity objEntity);
        long UserApproveUpdate(owin_userEntity objEntity);
        long UserReviewedUpdate(owin_userEntity objEntity);

        IList<owin_userEntity> UserReviewGet(owin_userEntity objEntity);

        long UserReviewedByGroupUpdate(owin_userEntity objEntity);
        IList<owin_userEntity> GetUserReviewByGroupData(owin_userEntity objEntity);

        long UserPasswordResetUpdate(owin_userEntity objEntity);
        long UserEmailUpdate(owin_userEntity objEntity);

        long CreateRole_Ext(owin_roleEntity owin_role);
        long UpdateRole_Ext(owin_roleEntity owin_role);
        long DeleteRole_Ext(owin_roleEntity owin_role);

        long SetReportRolePermission(owin_reportroletemplateEntity objEntity);

        IList<rptm_allreportinfoEntity> LoadReportMenu(long MasterUserID);


        IList<owin_roleEntity> GetRoleByUser(owin_userEntity objEntity);
    }
}
