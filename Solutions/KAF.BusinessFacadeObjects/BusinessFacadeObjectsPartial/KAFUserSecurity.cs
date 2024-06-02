using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using KAF.BusinessDataObjects;
using KAF.AppConfiguration;
using KAF.DataAccessObjects;
using KAF.IBusinessFacadeObjects;
using KAF.AppConfiguration.Configuration;

using KAF.IBusinessFacadeObjects.IBusinessFacadeObjectsPartial;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessFacadeObjects.BusinessFacadeObjectsPartial
{
    public sealed class KAFUserSecurity : BaseFacade, IKAFUserSecurity
    {

        #region Instance Variables
        private string ClassName = "KAFUserSecurity";
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

        public KAFUserSecurity()
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

        ~KAFUserSecurity()
        {
            Dispose(false);
        }

        private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        #endregion


        #region SELECTED METHODS

        KAF_LoadPermissionToUseEntity IKAFUserSecurity.LoadNewGetFromDB(SecurityCapsule securityCapsule)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().LoadNewGetFromDB(securityCapsule);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("KAF_LoadPermissionToUseEntity IKAFUserSecurity.LoadNewGetFromDB"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }
        IList<clsUserNameAndNumberEntity> IKAFUserSecurity.GetUserNameAndIDByCatetory(clsUserNameAndNumberEntity entity)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().GetUserNameAndIDByCatetory(entity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException(" List<clsUserNameAndNumberEntity> IKAFUserSecurity.GetUserNameAndIDByCatetory"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        #endregion 
        /// <remarks>Validate Info ByUser Name And Password </remarks>
        KAF_GetUserInfoByCredentialEntity IKAFUserSecurity.GetUserByName(string UserName)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().GetUserByName(UserName);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("KAF_GetUserInfoByCredentialEntity IKAFUserSecurity.ValidateInfoByUserNameAndPassword"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }
        /// <summary>
        /// To Update Email Address  
        /// </summary> 
        /// <method name="UpdateEmailAddress" type="long"></param>
        /// <param name= "objEn" type="List<UserProfileShortViewEntity>"></param>
        /// <remarks>Get Update Email Address </remarks>
        long IKAFUserSecurity.UpdateEmailAddress(List<KAF_GetUserInfoByCredentialEntity> objEn)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().UpdateEmailAddress(objEn);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("long IKAFUserSecurity.UpdateEmailAddress"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }


        /// <summary>
        /// To Validate Info By Use rName And Password
        /// </summary> 
        /// <method name="ValidateInfoByUserNameAndPassword" type="  KAF_GetUserInfoByCredentialEntity"></param>
        /// <param name= "UserName" type="string"></param>
        /// <param name= "SessionID" type="string"></param>
        /// <param name= "LoginSerial" type="long"></param>
        /// <remarks> Get User Name And ID By Catetory</remarks>
        KAF_GetUserInfoByCredentialEntity IKAFUserSecurity.ValidateInfoByUserNameAndPassword_Ext(string UserName, string SessionID, long LoginSerial)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().ValidateInfoByUserNameAndPassword_Ext(UserName, SessionID, LoginSerial);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("KAF_GetUserInfoByCredentialEntity IKAFUserSecurity.ValidateInfoByUserNameAndPassword_Ext"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }
        /// <summary>
        /// To Validate Info ByUser Name And Password 
        /// </summary> 
        /// <method name="ValidateInfoByUserNameAndPassword" type="KAF_GetUserInfoByCredentialEntity"></param>
        /// <param name= "UserName" type="string"></param>
        /// <param name= "SessionID" type="string"></param>
        /// <param name= "LoginSerial" type="long"></param>
        /// <remarks>Validate Info ByUser Name And Password </remarks>
        KAF_GetUserInfoByCredentialEntity IKAFUserSecurity.ValidateInfoByUserNameAndPassword(string UserName, string Password, string BankToken)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().ValidateInfoByUserNameAndPassword(UserName, Password, BankToken);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("KAF_GetUserInfoByCredentialEntity IKAFUserSecurity.ValidateInfoByUserNameAndPassword"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        /// <summary>
        /// To Get User Info By Mster User ID 
        /// </summary> 
        /// <method name="GetUserInfoByMsterUserIDShortProfile" type="KAF_GetUserInfoByCredentialRefEntity"></param>
        /// <param name= "MasterUserID" type="long"></param>
        /// <remarks>Get User Info By Mster User ID  </remarks>
        KAF_GetUserInfoByCredentialEntity IKAFUserSecurity.GetUserInfoByMsterUserIDShortProfile(long MasterUserID)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().GetUserInfoByMsterUserIDShortProfile(MasterUserID);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("KAF_GetUserInfoByCredentialEntity IKAFUserSecurity.GetUserInfoByMsterUserIDShortProfile"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }



        /// <summary>
        /// To Reset Password 
        /// </summary> 
        /// <method name="LoadMenuHierarchyList" type="IList<KAF_GetMenuHierarchyEntity>"></param>
        /// <param name= "BankKey" type="long"></param>
        /// <remarks>Reset Password </remarks>
        IList<KAF_GetMenuHierarchyEntity> IKAFUserSecurity.LoadMenuHierarchyList(long BankKey)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().LoadMenuHierarchyList(BankKey);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<KAF_GetMenuHierarchyEntity> IKAFUserSecurity.LoadMenuHierarchyList"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }


        /// <summary>
        /// To Save Update Preference
        /// </summary> 
        /// <method name="SaveUpdatePreference" type="IList<KAF_GetMenuHierarchyEntity>"></param>
        /// <param name= "FormID" type="long"></param>
        /// <param name= "MasterUserID" type="long"></param>
        /// <param name= "PrePageSize" type="int"></param>
        /// <param name= "Sec" type="SecurityCapsule"></param>
        /// <remarks>Save Update Preference </remarks>
        int IKAFUserSecurity.SaveUpdatePreference(long FormID, long MasterUserID, int PrePageSize, SecurityCapsule Sec)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().SaveUpdatePreference(FormID, MasterUserID, PrePageSize, Sec);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("long IKAFUserSecurity.SaveUpdatePreference"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }



        KAF_GetUserInfoByCredentialEntity IKAFUserSecurity.UserProfileShortView(KAF_GetUserInfoByCredentialEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().UserProfileShortView(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("KAF_GetUserInfoByCredentialEntity IKAFUserSecurity.UserProfileShortView"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }




        IList<KAF_LoadMenuByUserIDEntity> IKAFUserSecurity.LoadMenuByMasterUserID(Int64 MasterUserID, long BankKey)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().LoadMenuByMasterUserID(MasterUserID, BankKey);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<KAF_LoadMenuByUserIDEntity> IKAFUserSecurity.LoadMenuByMasterUserID"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }




        KAF_GetUserInfoByCredentialEntity IKAFUserSecurity.GetUserNameAndPasswordByMasterUserID(long? MasterUserID, string TokenKey)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().GetUserNameAndPasswordByMasterUserID(MasterUserID, TokenKey);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("long IKAFUserSecurity.GetUserNameAndPasswordByMasterUserID"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }


        IList<Owin_ProcessGetFormActionistEntity> IKAFUserSecurity.GetOwin_ProcessGetFormActionistEntity(long? RoleID)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().GetOwin_ProcessGetFormActionistEntity(RoleID);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurity.GetOwin_ProcessGetFormActionistEntity"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        IList<Owin_ProcessGetFormActionistEntity_Ext> IKAFUserSecurity.GetOwin_ProcessGetFormActionistEntityExt(long? MasterUserID)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().GetOwin_ProcessGetFormActionistEntityExt(MasterUserID);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurity.GetOwin_ProcessGetFormActionistEntityExt"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        long IKAFUserSecurity.Owin_UserPasswordChange(owin_userEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().Owin_UserPasswordChange(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurity.Owin_UserPasswordChange"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }


        long IKAFUserSecurity.Owin_UserProfileUpdate(owin_userEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().Owin_UserProfileUpdate(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurity.Owin_UserProfileUpdate"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }
        long IKAFUserSecurity.ForgetPasswordRequest(owin_userEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().ForgetPasswordRequest(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurity.ForgetPasswordRequest"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }


        long IKAFUserSecurity.ForgetPasswordRequestProcess(owin_userEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().ForgetPasswordRequestProcess(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurity.ForgetPasswordRequestProcess"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        long IKAFUserSecurity.AssignRolePermission(owin_rolepermissionEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().AssignRolePermission(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurityDataAccess.AssignRolePermission"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }




        long IKAFUserSecurity.CreateUser(owin_userEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().CreateUser(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurityDataAccess.CreateUser"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }
        long IKAFUserSecurity.UpdateUser(owin_userEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().UpdateUser(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurityDataAccess.UpdateUser"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }
        long IKAFUserSecurity.DeleteUser(owin_userEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().DeleteUser(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurityDataAccess.DeleteUser"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        long IKAFUserSecurity.UserStatusLockUpdate(owin_userEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().UserStatusLockUpdate(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurityDataAccess.UserStatusLockUpdate"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        long IKAFUserSecurity.UserApproveUpdate(owin_userEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().UserApproveUpdate(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurityDataAccess.UserApproveUpdate"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }
        long IKAFUserSecurity.UserReviewedUpdate(owin_userEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().UserReviewedUpdate(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurityDataAccess.UserReviewedUpdate"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }
        IList<owin_userEntity> IKAFUserSecurity.UserReviewGet(owin_userEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().UserReviewGet(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurityDataAccess.UserReviewGet"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }
        IList<owin_userEntity> IKAFUserSecurity.GetUserReviewByGroupData(owin_userEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().GetUserReviewByGroupData(objEntity);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userEntity> IKAFUserSecurity.GetUserReviewByGroupData"));
            }
        }

        long IKAFUserSecurity.UserReviewedByGroupUpdate(owin_userEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().UserReviewedByGroupUpdate(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurityDataAccess.UserReviewedByGroupUpdate"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }
        long IKAFUserSecurity.UserPasswordResetUpdate(owin_userEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().UserPasswordResetUpdate(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurityDataAccess.UserPasswordResetUpdate"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }
        long IKAFUserSecurity.UserEmailUpdate(owin_userEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().UserEmailUpdate(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurityDataAccess.UserEmailUpdate"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }




        long IKAFUserSecurity.CreateRole_Ext(owin_roleEntity owin_role)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().CreateRole_Ext(owin_role);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurity.CreateRole_Ext"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }


        long IKAFUserSecurity.UpdateRole_Ext(owin_roleEntity owin_role)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().UpdateRole_Ext(owin_role);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurity.UpdateRole_Ext"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }


        long IKAFUserSecurity.DeleteRole_Ext(owin_roleEntity owin_role)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().DeleteRole_Ext(owin_role);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurity.DeleteRole_Ext"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        long IKAFUserSecurity.SetReportRolePermission(owin_reportroletemplateEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().SetReportRolePermission(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurityDataAccess.SetReportRolePermission(owin_reportroletemplateEntity objEntity)"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        IList<rptm_allreportinfoEntity> IKAFUserSecurity.LoadReportMenu(Int64 MasterUserID)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().LoadReportMenu(MasterUserID);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<KAF_LoadMenuByUserIDEntity> IKAFUserSecurity.LoadReportMenu"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }



        IList<owin_roleEntity> IKAFUserSecurity.GetRoleByUser(owin_userEntity owin_user)
        {
            try
            {
                return DataAccessFactory.CreateKAFUserSecurityDataAccess().GetRoleByUser(owin_user);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IKAFUserSecurity.GetRoleByUser"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

    }
}
