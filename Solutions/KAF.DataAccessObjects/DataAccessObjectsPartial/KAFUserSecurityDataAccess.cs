using System;
using KAF.BusinessDataObjects;
using KAF.AppConfiguration.Configuration;
using KAF.IDataAccessObjects.IDataAccessObjectsPartial;

using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Linq;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.DataAccessObjects.DataAccessObjectsPartial
{
    internal sealed class KAFUserSecurityDataAccess : BaseDataAccess, IKAFUserSecurityDataAccess
    {
        #region Constructors
        private string ClassName = "KAFUserSecurityDataAccess";
        public KAFUserSecurityDataAccess(Context context)
            : base(context)
        {
        }

        private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        #endregion


        #region REVISED EDITION
        /// <summary>
        /// To Validate User Info
        /// </summary> 
        /// <method name="ValidateInfoByUserNameAndPassword" type="string"></param>
        /// <param name="string , string , long ></param>
        /// <remarks>Validate User Info By User Name And Password.</remarks>
        //FIXED
        KAF_GetUserInfoByCredentialEntity IKAFUserSecurityDataAccess.ValidateInfoByUserNameAndPassword_Ext(string UserName, string SessionID, long LoginSerial)
        {
            IList<KAF_GetUserInfoByCredentialEntity> itemList = new List<KAF_GetUserInfoByCredentialEntity>();
            try
            {
                const string SP = "KAF_OwinUserByUserNameAndPass_Ex";
                EncryptionHelper objEnc2 = new EncryptionHelper();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@UserName", DbType.String, UserName);
                    Database.AddInParameter(cmd, "@SessionID", DbType.String, SessionID);
                    Database.AddInParameter(cmd, "@LoginSerial", DbType.Int64, LoginSerial);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new KAF_GetUserInfoByCredentialEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.ValidateInfoByUserNameAndPassword"));
            }
            if (itemList != null && itemList.Count > 0)
            {
                return itemList[0];
            }
            else
                return null;
        }
        //FIXED
        KAF_GetUserInfoByCredentialEntity IKAFUserSecurityDataAccess.ValidateInfoByUserNameAndPassword(string UserName, string Password, string BankToken)
        {
            IList<KAF_GetUserInfoByCredentialEntity> itemList = new List<KAF_GetUserInfoByCredentialEntity>();
            try
            {
                const string SP = "KAF_OwinUserByUserNameAndPass";
                EncryptionHelper objEnc2 = new EncryptionHelper();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@UserName", DbType.String, UserName);
                    Database.AddInParameter(cmd, "@TokenKey", DbType.String, BankToken);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            KAF_GetUserInfoByCredentialEntity objEntity = new KAF_GetUserInfoByCredentialEntity();
                            objEntity.LoadFromReader(reader);
                            if (!reader.IsDBNull(reader.GetOrdinal("OkpId"))) objEntity.okpid = reader.GetInt64(reader.GetOrdinal("OkpId"));

                            itemList.Add(objEntity);
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.ValidateInfoByUserNameAndPassword"));
            }
            if (itemList != null && itemList.Count > 0)
            {
                KAF.AppConfiguration.Configuration.EncryptionHelper obj = new KAF.AppConfiguration.Configuration.EncryptionHelper();

                string[] strEncryptionValues = new string[4];
                strEncryptionValues = obj.GetDecryptedValuesDynamicVectorAuto(itemList[0].password, itemList[0].passwordsalt,
                    itemList[0].passwordkey, itemList[0].passwordvector,
                    KAF.AppConfiguration.EncryptionHandler.PCryptography.HashAlgorithm.SHA256,
                    KAF.AppConfiguration.EncryptionHandler.PCryptography.KeySize.bit_256);
                string dePass = string.Empty;
                dePass = strEncryptionValues[3].ToString();

                if (Password == dePass && UserName == itemList[0].username)
                {
                    itemList[0].password = "blablablabla";
                    itemList[0].passwordquestion = "blablablabla";
                    itemList[0].passwordanswer = "blablablabla";
                    itemList[0].passwordkey = "blablablabla";
                    itemList[0].passwordvector = "blablablabla";
                    itemList[0].passwordsalt = "blablablabla";
                    itemList[0].masprivatekey = "blablablabla";
                    itemList[0].maspublickey = "blablablabla";
                    return itemList[0];
                }
                else
                    return null;
            }
            else
                return null;
        }
        /// <summary>
        /// To Get User Info By Mster User ID
        /// </summary> 
        /// <method name="GetUserInfoByMsterUserIDShortProfile" type="KAF_GetUserInfoByCredentialRefEntity"></param>
        /// <param name= "MasterUserID" type="long"></param>
        /// <remarks> Get User Info By Mster User ID</remarks>
        //FIXED
        KAF_GetUserInfoByCredentialEntity IKAFUserSecurityDataAccess.GetUserInfoByMsterUserIDShortProfile(long MasterUserID)
        {
            IList<KAF_GetUserInfoByCredentialEntity> itemList = new List<KAF_GetUserInfoByCredentialEntity>();
            try
            {
                const string SP = "KAF_OwinUserByUserNameAndPass_Ex";
                EncryptionHelper objEnc2 = new EncryptionHelper();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@MasterUserID", DbType.Int64, MasterUserID);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new KAF_GetUserInfoByCredentialEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.GetUserInfoByMsterUserID"));
            }
            if (itemList != null && itemList.Count > 0)
            {
                return itemList[0];
            }
            else
                return null;
        }
        /// <summary>
        /// To User Profile Short View
        /// </summary> 
        /// <method name="UserProfileShortView" type="UserProfileShortViewEntity"></param>
        /// <param name= "objEntity" type="UserProfileShortViewEntity"></param>
        /// <remarks>User Profile Short View</remarks>
        //FIXED
        KAF_GetUserInfoByCredentialEntity IKAFUserSecurityDataAccess.UserProfileShortView(KAF_GetUserInfoByCredentialEntity objEntity)
        {
            IList<KAF_GetUserInfoByCredentialEntity> itemList = new List<KAF_GetUserInfoByCredentialEntity>();
            try
            {
                const string SP = "KAF_OwinUserByUserNameAndPass_Ex";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@MasterUserID", DbType.Int64, objEntity.masteruserid);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new KAF_GetUserInfoByCredentialEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.UserProfileShortView"));
            }
            if (itemList != null && itemList.Count > 0)
                return itemList[0];
            else
                return null;
        }
        #endregion

        #region SELECTED METHODS

        /// <summary>
        /// To Load From DB By User
        /// </summary> 
        /// <method name="LoadNewGetFromDB" type="KAF_LoadPermissionToUseEntity"></param>
        /// <param name= "securityCapsule" type="SecurityCapsule"></param>
        /// <remarks> Load From DB By User</remarks>
        KAF_LoadPermissionToUseEntity IKAFUserSecurityDataAccess.LoadNewGetFromDB(SecurityCapsule securityCapsule)
        {
            try
            {
                const string SP = "KAF_GetFromDBByUser";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    IList<KAF_LoadPermissionToUseEntity> itemList = new List<KAF_LoadPermissionToUseEntity>();

                    Database.AddInParameter(cmd, "@MasterUserID", DbType.Int64, securityCapsule.createdby);
                    Database.AddInParameter(cmd, "@FormID", DbType.Int64, securityCapsule.appformid.GetValueOrDefault(0));
                    Database.AddInParameter(cmd, "@OrganizationKey", DbType.Int64, securityCapsule.userorganizationkey.GetValueOrDefault(0));

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new KAF_LoadPermissionToUseEntity(reader));
                        }

                        reader.Close();
                    }
                    cmd.Dispose();

                    if (itemList != null && itemList.Count > 0)
                        return itemList[0];
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IgencustomerDataAccess.GetKAF_SecuserMasterLockControlEntity"));
            }
        }
        /// <summary>
        /// To Get User Name And ID By Catetory
        /// </summary> 
        /// <method name="GetUserNameAndIDByCatetory" type="IList<clsUserNameAndNumberEntity>"></param>
        /// <param name= "entity" type="clsUserNameAndNumberEntity"></param>
        /// <remarks> Get User Name And ID By Catetory</remarks>
        IList<clsUserNameAndNumberEntity> IKAFUserSecurityDataAccess.GetUserNameAndIDByCatetory(clsUserNameAndNumberEntity entity)
        {
            IList<clsUserNameAndNumberEntity> itemList = new List<clsUserNameAndNumberEntity>();
            try
            {
                const string SP = "GetUserNameAndIDByCatetory";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@UserCategoryID", DbType.Int64, entity.id);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new clsUserNameAndNumberEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.GetUserNameAndIDByCatetory"));
            }
            return itemList;
        }
        /// <summary>
        /// To Save Update Preference
        /// </summary> 
        /// <method name="SaveUpdatePreference" type="int"></param>
        /// <param name= "entity" type="clsUserNameAndNumberEntity"></param>
        /// <remarks> Save Update Preference</remarks>
        int IKAFUserSecurityDataAccess.SaveUpdatePreference(long FormID, long MasterUserID, int PrePageSize, SecurityCapsule Sec)
        {
            int DefaultPageSize = PrePageSize;
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand("KAF_SaveUpdatePreference"))
                {
                    Database.AddInParameter(cmd, "@MasterUserID", DbType.Int64, MasterUserID);
                    Database.AddInParameter(cmd, "@AppFormID", DbType.Int64, FormID);
                    Database.AddInParameter(cmd, "@PrePageSize", DbType.Int32, PrePageSize);
                    FillSequrityParameters(Sec, cmd, Database);
                    DefaultPageSize = Convert.ToInt32(Database.ExecuteScalar(cmd));
                    if (DefaultPageSize < 0)
                    {
                        throw new ArgumentException("Error Code." + DefaultPageSize.ToString());
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.SaveUpdatePreference"));
            }
            finally
            {

            }
            return DefaultPageSize;
        }
        /// <summary>
        /// To Get User Name And Password By MasterUser ID
        /// </summary> 
        /// <method name="GetUserNameAndPasswordByMasterUserID" type="KAF_GetUserInfoByCredentialEntity"></param>
        /// <param name= "MasterUserID" type="long"></param>
        /// <param name= "TokenKey" type="string"></param>
        /// <remarks> To Get User Name And Password By MasterUser ID</remarks>
        KAF_GetUserInfoByCredentialEntity IKAFUserSecurityDataAccess.GetUserNameAndPasswordByMasterUserID(long? MasterUserID, string TokenKey)
        {
            IList<KAF_GetUserInfoByCredentialEntity> itemList = new List<KAF_GetUserInfoByCredentialEntity>();
            try
            {
                const string SP = "KAF_UserByUserNameAndPass";
                //EncryptionHelper objEnc2 = new EncryptionHelper();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@MasterUserID", DbType.Int64, MasterUserID);

                    Database.AddInParameter(cmd, "@TokenKey", DbType.String, TokenKey);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new KAF_GetUserInfoByCredentialEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
                return itemList.FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.GetUserNameAndPasswordByMasterUserID"));
            }
            //if (itemList != null && itemList.Count > 0)
            //{


            //    objSingle = itemList.Where(p => p.MasterUserID == MasterUserID).FirstOrDefault();


            //    if (objSingle != null)
            //    {
            //        KAF.AppConfiguration.Configuration.EncryptionHelper obj = new KAF.AppConfiguration.Configuration.EncryptionHelper();

            //        string[] strEncryptionValues = new string[4];
            //        strEncryptionValues = obj.GetDecryptedValuesDynamicVectorAuto(objSingle.Password, objSingle.PasswordSalt,
            //            objSingle.PasswordKey, objSingle.PasswordVector,
            //            KAF.AppConfiguration.EncryptionHandler.PCryptography.HashAlgorithm.SHA256,
            //            KAF.AppConfiguration.EncryptionHandler.PCryptography.KeySize.bit_256);
            //        string dePass = string.Empty;
            //        dePass = strEncryptionValues[3].ToString();

            //        if (Password == dePass && UserName == objSingle.UserName)
            //            return objSingle;
            //        else
            //            return null;
            //    }
            //    else
            //        return null;
            //}
            //else
            //    return null;
        }
        /// <summary>
        /// To Load Menu Hierarchy List
        /// </summary> 
        /// <method name="LoadMenuHierarchyList" type="IList<KAF_GetMenuHierarchyEntity>"></param>
        /// <param name= "OrganizationKey" type="long"></param>
        /// <remarks> ToLoad Menu Hierarchy List</remarks>
        IList<KAF_GetMenuHierarchyEntity> IKAFUserSecurityDataAccess.LoadMenuHierarchyList(long OrganizationKey)
        {
            IList<KAF_GetMenuHierarchyEntity> itemList = new List<KAF_GetMenuHierarchyEntity>();
            try
            {
                const string SP = "KAF_GetMenuHierarchy";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@OrganizationKey", DbType.Int64, OrganizationKey);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new KAF_GetMenuHierarchyEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.LoadMenuHierarchyList"));
            }
            return itemList;
        }
        /// <summary>
        /// To Load Menu By Master User ID
        /// </summary> 
        /// <method name="LoadMenuByMasterUserID" type="IList<KAF_LoadMenuByUserIDEntity>"></param>
        /// <param name= "OrganizationKey" type="long"></param>
        /// <param name= "MasterUserID" type="Int64"></param>
        /// <remarks>Load Menu By Master User ID</remarks>
        IList<KAF_LoadMenuByUserIDEntity> IKAFUserSecurityDataAccess.LoadMenuByMasterUserID(Int64 MasterUserID, long OrganizationKey)
        {
            IList<KAF_LoadMenuByUserIDEntity> itemList = new List<KAF_LoadMenuByUserIDEntity>();
            try
            {
                const string SP = "KAF_LoadMenuByUserID";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@MasterUserID", DbType.Int64, MasterUserID);
                    if (OrganizationKey > 0)
                        Database.AddInParameter(cmd, "@OrganizationKey", DbType.Int64, OrganizationKey);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new KAF_LoadMenuByUserIDEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.LoadMenuByMasterUserID"));
            }
            return itemList;
        }
        /// <summary>
        /// To Get Switch Board Permission
        /// </summary> 
        /// <method name="GetSwitchBoardPermission" type="IList<KAF_GSwitchBoardPermissionEntity>"></param>
        /// <param name= "MasterUserID" type="Int64"></param>
        /// <remarks>Get Switch Board Permission</remarks>
        

        #endregion
        KAF_GetUserInfoByCredentialEntity IKAFUserSecurityDataAccess.GetUserByName(string UserName)
        {
            IList<KAF_GetUserInfoByCredentialEntity> itemList = new List<KAF_GetUserInfoByCredentialEntity>();
            try
            {
                const string SP = "KAF_UserByUserNameAndPass_ExT2";
                EncryptionHelper objEnc2 = new EncryptionHelper();
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@UserName", DbType.String, UserName);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new KAF_GetUserInfoByCredentialEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.GetUserByName"));
            }
            if (itemList != null && itemList.Count > 0)
            {
                return itemList[0];
            }
            else
                return null;
        }
        /// <summary>
        /// To Update Email Address
        /// </summary> 
        /// <method name="UpdateEmailAddress" type="long"></param>
        /// <param name= "objEn" type="List<UserProfileShortViewEntity>"></param>
        /// <remarks> Update Email Address</remarks>
        long IKAFUserSecurityDataAccess.UpdateEmailAddress(List<KAF_GetUserInfoByCredentialEntity> objEn)
        {
            long returnCode = -99;

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();

            try
            {

                if (objEn.Count > 0)
                {
                    foreach (KAF_GetUserInfoByCredentialEntity objSingle in objEn)
                    {
                        using (DbCommand cmd = Database.GetStoredProcCommand("KAF_UpdateEmailAddress"))
                        {
                            Database.AddInParameter(cmd, "@MasterUserID", DbType.Int64, objSingle.masteruserid);
                            if (!string.IsNullOrEmpty(objSingle.emailaddress))
                                Database.AddInParameter(cmd, "@Email", DbType.String, objSingle.emailaddress);

                            if (!string.IsNullOrEmpty(objSingle.strValue1))
                                Database.AddInParameter(cmd, "@Phone", DbType.String, objSingle.strValue1);

                            FillSequrityParameters(objSingle.BaseSecurityParam, cmd, Database);
                            AddOutputParameter(cmd);
                            returnCode = Database.ExecuteNonQuery(cmd, transaction);
                            if (returnCode < 0)
                            {
                                throw new ArgumentException("Error in transaction.");
                            }
                            cmd.Dispose();
                        }
                    }
                }
                if (returnCode > 0)
                    transaction.Commit();
                else
                    throw new ArgumentException("Error Code." + returnCode.ToString());
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.UpdateEmailAddress"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

        IList<Owin_ProcessGetFormActionistEntity> IKAFUserSecurityDataAccess.GetOwin_ProcessGetFormActionistEntity(long? RoleID)
        {

            IList<Owin_ProcessGetFormActionistEntity> itemList = new List<Owin_ProcessGetFormActionistEntity>();
            try
            {
                const string SP = "Owin_ProcessGetFormActionList";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@RoleID", DbType.Int64, RoleID);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new Owin_ProcessGetFormActionistEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }

            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.GetOwin_ProcessGetFormActionistEntity"));
            }
            return itemList;
        }


        long IKAFUserSecurityDataAccess.Owin_UserPasswordChange(owin_userEntity objEntity)
        {
            long returnValue = -99;
            try
            {
                IList<KAF_GetUserInfoByCredentialEntity> itemList = new List<KAF_GetUserInfoByCredentialEntity>();
                const string SPGet = "KAF_OwinUserByUserNameAndPass";
                EncryptionHelper objEnc2 = new EncryptionHelper();
                using (DbCommand cmd = Database.GetStoredProcCommand(SPGet))
                {
                    Database.AddInParameter(cmd, "@UserName", DbType.String, objEntity.username);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new KAF_GetUserInfoByCredentialEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }

                if (itemList != null && itemList.Count > 0)
                {
                    string EncString = string.Empty;
                    EncString = objEntity.passwordsalt;

                    KAF.AppConfiguration.Configuration.EncryptionHelper obj = new KAF.AppConfiguration.Configuration.EncryptionHelper();

                    string[] strEncryptionValuesOld = new string[4];
                    strEncryptionValuesOld = obj.GetDecryptedValuesDynamicVectorAuto(itemList[0].password, itemList[0].passwordsalt,
                        itemList[0].passwordkey, itemList[0].passwordvector,
                        KAF.AppConfiguration.EncryptionHandler.PCryptography.HashAlgorithm.SHA256,
                        KAF.AppConfiguration.EncryptionHandler.PCryptography.KeySize.bit_256);
                    string dePass = string.Empty;
                    dePass = strEncryptionValuesOld[3].ToString();

                    if (objEntity.password == dePass && objEntity.username == itemList[0].username)
                    {
                        string[] strEncryptionValues = new string[4];
                        strEncryptionValues = obj.GetEncryptedValuesDynamic(EncString,
                            KAF.AppConfiguration.EncryptionHandler.PCryptography.HashAlgorithm.SHA256,
                            KAF.AppConfiguration.EncryptionHandler.PCryptography.KeySize.bit_256);

                        objEntity.passwordkey = strEncryptionValues[0].ToString();
                        objEntity.passwordsalt = strEncryptionValues[1].ToString();
                        objEntity.passwordvector = strEncryptionValues[2].ToString();
                        objEntity.password = strEncryptionValues[3].ToString();

                        using (DbCommand cmd = Database.GetStoredProcCommand("KAF_Owin_UserPasswordChange"))
                        {
                            Database.AddInParameter(cmd, "@UserId", DbType.Guid, objEntity.userid);
                            Database.AddInParameter(cmd, "@MasterUserID", DbType.Int64, objEntity.masteruserid);
                            Database.AddInParameter(cmd, "@UserName", DbType.String, objEntity.username);

                            Database.AddInParameter(cmd, "@SessionID", DbType.String, objEntity.sessionid);
                            Database.AddInParameter(cmd, "@SessionToken", DbType.String, objEntity.token);

                            Database.AddInParameter(cmd, "@Password", DbType.String, objEntity.password);
                            Database.AddInParameter(cmd, "@PasswordSalt", DbType.String, objEntity.passwordsalt);
                            Database.AddInParameter(cmd, "@PasswordKey", DbType.String, objEntity.passwordkey);
                            Database.AddInParameter(cmd, "@PasswordVector", DbType.String, objEntity.passwordvector);

                            Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, objEntity.ex_date1);
                            Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, objEntity.ex_date2);
                            Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, objEntity.ex_nvarchar1);
                            Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, objEntity.ex_nvarchar2);
                            Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, objEntity.ex_bigint1);
                            Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, objEntity.ex_bigint2);
                            Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, objEntity.ex_decimal1);
                            Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, objEntity.ex_decimal2);

                            AddOutputParameter(cmd);
                            FillSequrityParameters(objEntity.BaseSecurityParam, cmd, Database);
                            returnValue = Database.ExecuteNonQuery(cmd);
                            if (returnValue < 0)
                            {
                                throw new ArgumentException("Error Code." + returnValue.ToString());
                            }
                            cmd.Dispose();
                        }
                    }
                    else
                        throw new Exception("Invalid User credentials.");
                }
                else
                    throw new Exception("Invalid User credentials.");
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.Owin_UserPasswordChange"));
            }
            finally
            {

            }
            return returnValue;
        }


        long IKAFUserSecurityDataAccess.Owin_UserProfileUpdate(owin_userEntity objEntity)
        {
            long returnValue = -99;
            try
            {
                using (DbCommand cmd = Database.GetStoredProcCommand("KAF_Owin_UserProfileUpdate"))
                {
                    Database.AddInParameter(cmd, "@UserId", DbType.Guid, objEntity.userid);
                    Database.AddInParameter(cmd, "@MasterUserID", DbType.Int64, objEntity.masteruserid);
                    Database.AddInParameter(cmd, "@UserName", DbType.String, objEntity.username);

                    Database.AddInParameter(cmd, "@SessionID", DbType.String, objEntity.sessionid);
                    Database.AddInParameter(cmd, "@SessionToken", DbType.String, objEntity.token);

                    //if (!(string.IsNullOrEmpty(objEntity.UserProfilePhoto)))
                    //    Database.AddInParameter(cmd, "@UserProfilePhoto", DbType.String, objEntity.UserProfilePhoto);
                    if (!(string.IsNullOrEmpty(objEntity.loweredusername)))
                        Database.AddInParameter(cmd, "@LoweredUserName", DbType.String, objEntity.loweredusername);
                    if (!(string.IsNullOrEmpty(objEntity.mobilenumber)))
                        Database.AddInParameter(cmd, "@MobileNumber", DbType.String, objEntity.mobilenumber);

                    if (!(string.IsNullOrEmpty(objEntity.passwordquestion)))
                        Database.AddInParameter(cmd, "@PasswordQuestion", DbType.String, objEntity.passwordquestion);
                    if (!(string.IsNullOrEmpty(objEntity.passwordanswer)))
                        Database.AddInParameter(cmd, "@PasswordAnswer", DbType.String, objEntity.passwordanswer);


                    Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, objEntity.ex_date1);
                    Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, objEntity.ex_date2);
                    Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, objEntity.ex_nvarchar1);
                    Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, objEntity.ex_nvarchar2);
                    Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, objEntity.ex_bigint1);
                    Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, objEntity.ex_bigint2);
                    Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, objEntity.ex_decimal1);
                    Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, objEntity.ex_decimal2);

                    AddOutputParameter(cmd);
                    FillSequrityParameters(objEntity.BaseSecurityParam, cmd, Database);
                    returnValue = Database.ExecuteNonQuery(cmd);
                    if (returnValue < 0)
                    {
                        throw new ArgumentException("Error Code." + returnValue.ToString());
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.Owin_UserProfileUpdate"));
            }
            finally
            {

            }
            return returnValue;
        }


        long IKAFUserSecurityDataAccess.ForgetPasswordRequest(owin_userEntity objEntity)
        {
            long returnValue = -99;
            try
            {
                IList<owin_userEntity> itemList = new List<owin_userEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand("KAF_Owin_ForgetPasswordRequest"))
                {
                    Database.AddInParameter(cmd, "@EmailAddress", DbType.String, objEntity.emailaddress);
                    Database.AddInParameter(cmd, "@UserName", DbType.String, objEntity.username);

                    Database.AddInParameter(cmd, "@SessionID", DbType.String, objEntity.sessionid);
                    Database.AddInParameter(cmd, "@SessionToken", DbType.String, objEntity.strValue2);

                    Database.AddInParameter(cmd, "@MobileNumber", DbType.String, objEntity.mobilenumber);

                    Database.AddInParameter(cmd, "@PasswordQuestion", DbType.String, objEntity.passwordquestion);
                    Database.AddInParameter(cmd, "@PasswordAnswer", DbType.String, objEntity.passwordanswer);
                    Database.AddInParameter(cmd, "@TransID", DbType.String, objEntity.strValue1);
                    Database.AddInParameter(cmd, "@PageToken", DbType.String, objEntity.strValue3);


                    AddOutputParameter(cmd);
                    //FillSequrityParameters(objEntity.BaseSecurityParam, cmd, Database);

                    returnValue = Database.ExecuteNonQuery(cmd);
                    returnValue = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    if (returnValue < 0)
                    {
                        throw new ArgumentException("Error Code." + returnValue.ToString());
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.Owin_UserProfileUpdate"));
            }
            finally
            {

            }
            return returnValue;
        }


        public long AssignRolePermission(owin_rolepermissionEntity objEntity)
        {
            long returnValue = -99;
            try
            {
                IList<owin_userEntity> itemList = new List<owin_userEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand("Owin_RolePermission_UpdExt"))
                {
                    Database.AddInParameter(cmd, "@FormActionID", DbType.String, objEntity.ex_nvarchar1);
                    Database.AddInParameter(cmd, "@RoleID", DbType.Int64, objEntity.roleid);

                    AddOutputParameter(cmd);
                    FillSequrityParameters(objEntity.BaseSecurityParam, cmd, Database);

                    returnValue = Database.ExecuteNonQuery(cmd);
                    //returnValue = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    if (returnValue < 0)
                    {
                        throw new ArgumentException("Error Code." + returnValue.ToString());
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.AssignRolePermission"));
            }
            finally
            {

            }
            return returnValue;
        }


        long IKAFUserSecurityDataAccess.ForgetPasswordRequestProcess(owin_userEntity objEntity)
        {
            long returnValue = -99;
            try
            {
                KAF.AppConfiguration.Configuration.EncryptionHelper obj = new KAF.AppConfiguration.Configuration.EncryptionHelper();

                string[] strEncryptionValues = new string[4];
                strEncryptionValues = obj.GetEncryptedValuesDynamic(objEntity.password,
                    KAF.AppConfiguration.EncryptionHandler.PCryptography.HashAlgorithm.SHA256,
                    KAF.AppConfiguration.EncryptionHandler.PCryptography.KeySize.bit_256);

                objEntity.passwordkey = strEncryptionValues[0].ToString();
                objEntity.passwordsalt = strEncryptionValues[1].ToString();
                objEntity.passwordvector = strEncryptionValues[2].ToString();
                objEntity.password = strEncryptionValues[3].ToString();



                using (DbCommand cmd = Database.GetStoredProcCommand("KAF_Owin_ForgetPasswordRequestProcess"))
                {
                    Database.AddInParameter(cmd, "@EmailAddress", DbType.String, objEntity.emailaddress);
                    Database.AddInParameter(cmd, "@UserName", DbType.String, objEntity.username);
                    Database.AddInParameter(cmd, "@MobileNumber", DbType.String, objEntity.mobilenumber);

                    Database.AddInParameter(cmd, "@SessionID", DbType.String, objEntity.sessionid);
                    Database.AddInParameter(cmd, "@SessionToken", DbType.String, objEntity.token);

                    Database.AddInParameter(cmd, "@PasswordAnswer", DbType.String, objEntity.passwordanswer);

                    Database.AddInParameter(cmd, "@Password", DbType.String, objEntity.password);
                    Database.AddInParameter(cmd, "@PasswordKey", DbType.String, objEntity.passwordkey);
                    Database.AddInParameter(cmd, "@PasswordVector", DbType.String, objEntity.passwordvector);
                    Database.AddInParameter(cmd, "@PasswordSalt", DbType.String, objEntity.passwordsalt);

                    Database.AddInParameter(cmd, "@TransID", DbType.String, objEntity.strValue1);
                    Database.AddInParameter(cmd, "@IPAddress", DbType.String, objEntity.useripaddress);

                    AddOutputParameter(cmd);
                    //FillSequrityParameters(objEntity.BaseSecurityParam, cmd, Database);

                    returnValue = Database.ExecuteNonQuery(cmd);
                    returnValue = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    if (returnValue < 0)
                    {
                        throw new ArgumentException("Error Code." + returnValue.ToString());
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.Owin_UserProfileUpdate"));
            }
            finally
            {

            }
            return returnValue;
        }


        IList<Owin_ProcessGetFormActionistEntity_Ext> IKAFUserSecurityDataAccess.GetOwin_ProcessGetFormActionistEntityExt(long? MasterUserID)
        {

            IList<Owin_ProcessGetFormActionistEntity_Ext> itemList = new List<Owin_ProcessGetFormActionistEntity_Ext>();
            try
            {
                const string SP = "KAF_GetMenuWiseFormActionList";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@MasterUserID", DbType.Int64, MasterUserID);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new Owin_ProcessGetFormActionistEntity_Ext(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }

            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.GetOwin_ProcessGetFormActionistEntityExt"));
            }
            return itemList;
        }

        long IKAFUserSecurityDataAccess.CreateUser(owin_userEntity owin_user)
        {
            long returnValue = -99;
            try
            {

                #region Check if user exists
                IList<owin_userEntity> itemList = new List<owin_userEntity>();
                using (DbCommand cmd = Database.GetStoredProcCommand("owin_user_GA"))
                {

                    Database.AddInParameter(cmd, "@UserId", DbType.Guid, owin_user.userid);
                    Database.AddInParameter(cmd, "@UserName", DbType.String, owin_user.username);
                    Database.AddInParameter(cmd, "@EmailAddress", DbType.String, owin_user.emailaddress);
                    FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();

                }
                if (itemList.Count > 0)
                {
                    throw new Exception("User name already exists, please try another name.");
                }
                #endregion

                KAF.AppConfiguration.Configuration.transactioncodeGen objTranCodeGen = new KAF.AppConfiguration.Configuration.transactioncodeGen();

                string EncString = string.Empty;
                EncString = owin_user.password;

                KAF.AppConfiguration.Configuration.EncryptionHelper obj = new KAF.AppConfiguration.Configuration.EncryptionHelper();
                string[] strEncryptionValues = new string[4];
                strEncryptionValues = obj.GetEncryptedValuesDynamic(EncString,
                    KAF.AppConfiguration.EncryptionHandler.PCryptography.HashAlgorithm.SHA256,
                    KAF.AppConfiguration.EncryptionHandler.PCryptography.KeySize.bit_256);

                owin_user.passwordkey = strEncryptionValues[0].ToString();
                owin_user.passwordsalt = strEncryptionValues[1].ToString();
                owin_user.passwordvector = strEncryptionValues[2].ToString();
                owin_user.password = strEncryptionValues[3].ToString();

                if ("00000000-0000-0000-0000-000000000000" == owin_user.userid.ToString())
                {
                    string part = "R" + DateTime.Now.Ticks.ToString();
                    owin_user.userid = objTranCodeGen.StringToGUID(part);
                }

                const string SP = "owin_user_InsExt";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    FillParameters(owin_user, cmd, Database);

                    if (!(string.IsNullOrEmpty(owin_user.roleid)))
                        Database.AddInParameter(cmd, "@RoleID", DbType.String, owin_user.roleid);
                    FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);
                    try
                    {
                        returnValue = Database.ExecuteNonQuery(cmd);
                        returnValue = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    }
                    catch (Exception ex)
                    {
                        throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.Addowin_user"));
                    }
                    cmd.Dispose();
                }

            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.CreateUser"));
            }
            finally
            {
            }
            return returnValue;
        }
        long IKAFUserSecurityDataAccess.UpdateUser(owin_userEntity owin_user)
        {
            long returnValue = -99;
            try
            {

                const string SP = "owin_user_UpdExt";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    FillParameters(owin_user, cmd, Database);

                    if (!(string.IsNullOrEmpty(owin_user.roleid)))
                        Database.AddInParameter(cmd, "@RoleID", DbType.String, owin_user.roleid);

                    FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);
                    try
                    {
                        returnValue = Database.ExecuteNonQuery(cmd);
                        returnValue = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    }
                    catch (Exception ex)
                    {
                        throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.UpdateUser"));
                    }
                    cmd.Dispose();
                }

            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.UpdateUser"));
            }
            finally
            {
            }
            return returnValue;
        }
        long IKAFUserSecurityDataAccess.DeleteUser(owin_userEntity owin_user)
        {
            long returnValue = -99;
            try
            {
                const string SP = "owin_user_delExt";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    FillParameters(owin_user, cmd, Database, true);
                    FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);
                    try
                    {
                        returnValue = Database.ExecuteNonQuery(cmd);
                        returnValue = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    }
                    catch (Exception ex)
                    {
                        throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.DeleteUser"));
                    }
                    cmd.Dispose();
                }

            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.DeleteUser"));
            }
            finally
            {
            }
            return returnValue;
        }
        public static void FillParameters(owin_userEntity owin_user, DbCommand cmd, Database Database, bool forDelete = false)
        {
            if (owin_user.userid.HasValue)
                Database.AddInParameter(cmd, "@UserId", DbType.Guid, owin_user.userid);
            if (forDelete) return;
            Database.AddInParameter(cmd, "@ApplicationId", DbType.Guid, owin_user.applicationid);
            if (owin_user.masteruserid.HasValue)
                Database.AddInParameter(cmd, "@MasterUserID", DbType.Int64, owin_user.masteruserid);
            if (!(string.IsNullOrEmpty(owin_user.username)))
                Database.AddInParameter(cmd, "@UserName", DbType.String, owin_user.username);
            if (!(string.IsNullOrEmpty(owin_user.UserProfilePhoto)))
                Database.AddInParameter(cmd, "@UserProfilePhoto", DbType.String, owin_user.UserProfilePhoto);
            if (!(string.IsNullOrEmpty(owin_user.emailaddress)))
                Database.AddInParameter(cmd, "@EmailAddress", DbType.String, owin_user.emailaddress);
            if (!(string.IsNullOrEmpty(owin_user.loweredusername)))
                Database.AddInParameter(cmd, "@LoweredUserName", DbType.String, owin_user.loweredusername);
            if (!(string.IsNullOrEmpty(owin_user.mobilenumber)))
                Database.AddInParameter(cmd, "@MobileNumber", DbType.String, owin_user.mobilenumber);
            if ((owin_user.isanonymous != null))
                Database.AddInParameter(cmd, "@IsAnonymous", DbType.Boolean, owin_user.isanonymous);
            if ((owin_user.ischildenable != null))
                Database.AddInParameter(cmd, "@IsChildEnable", DbType.Boolean, owin_user.ischildenable);
            if (!(string.IsNullOrEmpty(owin_user.masprivatekey)))
                Database.AddInParameter(cmd, "@MasPrivateKey", DbType.String, owin_user.masprivatekey);
            if (!(string.IsNullOrEmpty(owin_user.maspublickey)))
                Database.AddInParameter(cmd, "@MasPublicKey", DbType.String, owin_user.maspublickey);
            if (!(string.IsNullOrEmpty(owin_user.password)))
                Database.AddInParameter(cmd, "@Password", DbType.String, owin_user.password);
            if (!(string.IsNullOrEmpty(owin_user.passwordsalt)))
                Database.AddInParameter(cmd, "@PasswordSalt", DbType.String, owin_user.passwordsalt);
            if (!(string.IsNullOrEmpty(owin_user.passwordkey)))
                Database.AddInParameter(cmd, "@PasswordKey", DbType.String, owin_user.passwordkey);
            if (!(string.IsNullOrEmpty(owin_user.passwordvector)))
                Database.AddInParameter(cmd, "@PasswordVector", DbType.String, owin_user.passwordvector);
            if (!(string.IsNullOrEmpty(owin_user.mobilepin)))
                Database.AddInParameter(cmd, "@MobilePIN", DbType.String, owin_user.mobilepin);
            if (!(string.IsNullOrEmpty(owin_user.passwordquestion)))
                Database.AddInParameter(cmd, "@PasswordQuestion", DbType.String, owin_user.passwordquestion);
            if (!(string.IsNullOrEmpty(owin_user.passwordanswer)))
                Database.AddInParameter(cmd, "@PasswordAnswer", DbType.String, owin_user.passwordanswer);
            if ((owin_user.approved != null))
                Database.AddInParameter(cmd, "@Approved", DbType.Boolean, owin_user.approved);
            if ((owin_user.locked != null))
                Database.AddInParameter(cmd, "@Locked", DbType.Boolean, owin_user.locked);
            if ((owin_user.lastlogindate.HasValue))
                Database.AddInParameter(cmd, "@LastLoginDate", DbType.DateTime, owin_user.lastlogindate);
            if ((owin_user.lastpasschangeddate.HasValue))
                Database.AddInParameter(cmd, "@LastPassChangedDate", DbType.DateTime, owin_user.lastpasschangeddate);
            if ((owin_user.lastlockoutdate.HasValue))
                Database.AddInParameter(cmd, "@LastLockoutDate", DbType.DateTime, owin_user.lastlockoutdate);
            if (owin_user.failedpasswordattemptcount.HasValue)
                Database.AddInParameter(cmd, "@FailedPasswordAttemptCount", DbType.Int32, owin_user.failedpasswordattemptcount);
            if (!(string.IsNullOrEmpty(owin_user.comment)))
                Database.AddInParameter(cmd, "@Comment", DbType.String, owin_user.comment);
            if ((owin_user.lastactivitydate.HasValue))
                Database.AddInParameter(cmd, "@LastActivityDate", DbType.DateTime, owin_user.lastactivitydate);
            if ((owin_user.isreviewed != null))
                Database.AddInParameter(cmd, "@IsReviewed", DbType.Boolean, owin_user.isreviewed);
            if (owin_user.reviewedby.HasValue)
                Database.AddInParameter(cmd, "@ReviewedBy", DbType.Int64, owin_user.reviewedby);
            if (!(string.IsNullOrEmpty(owin_user.reviewedbyusername)))
                Database.AddInParameter(cmd, "@ReviewedByUserName", DbType.String, owin_user.reviewedbyusername);
            if ((owin_user.revieweddate.HasValue))
                Database.AddInParameter(cmd, "@ReviewedDate", DbType.DateTime, owin_user.revieweddate);
            if ((owin_user.isapproved != null))
                Database.AddInParameter(cmd, "@IsApproved", DbType.Boolean, owin_user.isapproved);
            if (owin_user.approvedby.HasValue)
                Database.AddInParameter(cmd, "@ApprovedBy", DbType.Int64, owin_user.approvedby);
            if (!(string.IsNullOrEmpty(owin_user.approvedbyusername)))
                Database.AddInParameter(cmd, "@ApprovedByUserName", DbType.String, owin_user.approvedbyusername);
            if ((owin_user.approveddate.HasValue))
                Database.AddInParameter(cmd, "@ApprovedDate", DbType.DateTime, owin_user.approveddate);
            if ((owin_user.ex_date1.HasValue))
                Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, owin_user.ex_date1);
            if ((owin_user.ex_date2.HasValue))
                Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, owin_user.ex_date2);
            if (!(string.IsNullOrEmpty(owin_user.ex_nvarchar1)))
                Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, owin_user.ex_nvarchar1);
            if (!(string.IsNullOrEmpty(owin_user.ex_nvarchar2)))
                Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, owin_user.ex_nvarchar2);
            if (owin_user.ex_bigint1.HasValue)
                Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, owin_user.ex_bigint1);
            if (owin_user.ex_bigint2.HasValue)
                Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, owin_user.ex_bigint2);
            if (owin_user.ex_decimal1.HasValue)
                Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, owin_user.ex_decimal1);
            if (owin_user.ex_decimal2.HasValue)
                Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, owin_user.ex_decimal2);
        }

        long IKAFUserSecurityDataAccess.UserStatusLockUpdate(owin_userEntity owin_user)
        {
            long returnValue = -99;
            try
            {
                const string SP = "owin_user_UpdStatusLock";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    FillParameters(owin_user, cmd, Database);
                    FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);
                    try
                    {
                        returnValue = Database.ExecuteNonQuery(cmd);
                        returnValue = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    }
                    catch (Exception ex)
                    {
                        throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.UserStatusLockUpdate"));
                    }
                    cmd.Dispose();
                }

            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.UserStatusLockUpdate"));
            }
            finally
            {
            }
            return returnValue;
        }
        long IKAFUserSecurityDataAccess.UserApproveUpdate(owin_userEntity owin_user)
        {
            long returnValue = -99;
            try
            {
                const string SP = "owin_user_UpdApproved";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    FillParameters(owin_user, cmd, Database);
                    FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);
                    try
                    {
                        returnValue = Database.ExecuteNonQuery(cmd);
                        returnValue = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    }
                    catch (Exception ex)
                    {
                        throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.UserApproveUpdate"));
                    }
                    cmd.Dispose();
                }

            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.UserApproveUpdate"));
            }
            finally
            {
            }
            return returnValue;
        }
        long IKAFUserSecurityDataAccess.UserReviewedUpdate(owin_userEntity owin_user)
        {
            long returnValue = -99;
            try
            {
                const string SP = "owin_user_UpdReview";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    FillParameters(owin_user, cmd, Database);
                    FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);
                    try
                    {
                        returnValue = Database.ExecuteNonQuery(cmd);
                        returnValue = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    }
                    catch (Exception ex)
                    {
                        throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.UserReviewedUpdate"));
                    }
                    cmd.Dispose();
                }

            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.UserReviewedUpdate"));
            }
            finally
            {
            }
            return returnValue;
        }

        IList<owin_userEntity> IKAFUserSecurityDataAccess.UserReviewGet(owin_userEntity owin_user)
        {

            IList<owin_userEntity> itemList = new List<owin_userEntity>();
            try
            {

                const string SP = "Owin_ProcessGetUserListForReview";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    FillParameters(owin_user, cmd, Database);
                    AddSortExpressionParameter(cmd, owin_user.SortExpression);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userEntity(reader));
                        }
                        reader.Dispose();
                    }


                    cmd.Dispose();
                }

            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.UserReviewGet"));
            }
            return itemList;
        }

        long IKAFUserSecurityDataAccess.UserReviewedByGroupUpdate(owin_userEntity owin_user)
        {
            long returnValue = -99;
            try
            {
                const string SP = "owin_user_UpdReview_EXT";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    Database.AddInParameter(cmd, "@ReviewString", DbType.String, owin_user.strValue1);
                    FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);
                    try
                    {
                        returnValue = Database.ExecuteNonQuery(cmd);
                        returnValue = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    }
                    catch (Exception ex)
                    {
                        throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.UserReviewedByGroupUpdate"));
                    }
                    cmd.Dispose();
                }

            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.UserReviewedUpdate"));
            }
            finally
            {
            }
            return returnValue;
        }
        IList<owin_userEntity> IKAFUserSecurityDataAccess.GetUserReviewByGroupData(owin_userEntity owin_user)
        {
            try
            {
                const string SP = "Owin_ProcessGetUserListForReview_GAPgListView";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, owin_user.SortExpression);
                    AddPageSizeParameter(cmd, owin_user.PageSize);
                    AddCurrentPageParameter(cmd, owin_user.CurrentPage);
                    FillParameters(owin_user, cmd, Database);
                    FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);


                    //Database.AddInParameter(cmd, "@SearchType", DbType.String, "6");
                    //Database.AddInParameter(cmd, "@UserID", DbType.Guid, hr_basicprofile.BaseSecurityParam.userid);


                    IList<owin_userEntity> itemList = new List<owin_userEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userEntity(reader));
                        }
                        reader.Close();
                    }
                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        owin_user.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.GetUserReviewByGroupData"));
            }
        }
        long IKAFUserSecurityDataAccess.UserPasswordResetUpdate(owin_userEntity owin_user)
        {
            long returnValue = -99;
            try
            {
                KAF.AppConfiguration.Configuration.transactioncodeGen objTranCodeGen = new KAF.AppConfiguration.Configuration.transactioncodeGen();

                string EncString = string.Empty;
                EncString = owin_user.password;

                KAF.AppConfiguration.Configuration.EncryptionHelper obj = new KAF.AppConfiguration.Configuration.EncryptionHelper();
                string[] strEncryptionValues = new string[4];
                strEncryptionValues = obj.GetEncryptedValuesDynamic(EncString,
                    KAF.AppConfiguration.EncryptionHandler.PCryptography.HashAlgorithm.SHA256,
                    KAF.AppConfiguration.EncryptionHandler.PCryptography.KeySize.bit_256);

                owin_user.passwordkey = strEncryptionValues[0].ToString();
                owin_user.passwordsalt = strEncryptionValues[1].ToString();
                owin_user.passwordvector = strEncryptionValues[2].ToString();
                owin_user.password = strEncryptionValues[3].ToString();

                const string SP = "owin_user_UpdPassword";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    FillParameters(owin_user, cmd, Database);
                    FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);
                    try
                    {
                        returnValue = Database.ExecuteNonQuery(cmd);
                        returnValue = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    }
                    catch (Exception ex)
                    {
                        throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.UserPasswordResetUpdate"));
                    }
                    cmd.Dispose();
                }

            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.UserPasswordResetUpdate"));
            }
            finally
            {
            }
            return returnValue;
        }
        long IKAFUserSecurityDataAccess.UserEmailUpdate(owin_userEntity owin_user)
        {
            long returnValue = -99;
            try
            {
                const string SP = "owin_user_UpdEmail";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    FillParameters(owin_user, cmd, Database);
                    FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);
                    AddOutputParameter(cmd);
                    try
                    {
                        returnValue = Database.ExecuteNonQuery(cmd);
                        returnValue = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    }
                    catch (Exception ex)
                    {
                        throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.UserEmailUpdate"));
                    }
                    cmd.Dispose();
                }

            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.UserEmailUpdate"));
            }
            finally
            {
            }
            return returnValue;
        }


        long IKAFUserSecurityDataAccess.CreateRole_Ext(owin_roleEntity owin_role)
        {
            long returnCode = -99;

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();

            try
            {

                if (owin_role != null)
                {
                    using (DbCommand cmd = Database.GetStoredProcCommand("owin_role_Ins_ext"))
                    {

                        if (owin_role.roleid.HasValue)
                            Database.AddInParameter(cmd, "@RoleID", DbType.Int64, owin_role.roleid);
                        if (!(string.IsNullOrEmpty(owin_role.rolename)))
                            Database.AddInParameter(cmd, "@RoleName", DbType.String, owin_role.rolename);
                        if (!(string.IsNullOrEmpty(owin_role.description)))
                            Database.AddInParameter(cmd, "@Description", DbType.String, owin_role.description);
                        if ((owin_role.ex_date1.HasValue))
                            Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, owin_role.ex_date1);
                        if ((owin_role.ex_date2.HasValue))
                            Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, owin_role.ex_date2);
                        if (!(string.IsNullOrEmpty(owin_role.ex_nvarchar1)))
                            Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, owin_role.ex_nvarchar1);
                        if (!(string.IsNullOrEmpty(owin_role.ex_nvarchar2)))
                            Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, owin_role.ex_nvarchar2);
                        if (owin_role.ex_bigint1.HasValue)
                            Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, owin_role.ex_bigint1);
                        if (owin_role.ex_bigint2.HasValue)
                            Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, owin_role.ex_bigint2);
                        if (owin_role.ex_decimal1.HasValue)
                            Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, owin_role.ex_decimal1);
                        if (owin_role.ex_decimal2.HasValue)
                            Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, owin_role.ex_decimal2);
                        if (!(string.IsNullOrEmpty(owin_role.createdbyusername)))
                            Database.AddInParameter(cmd, "@CreatedByUserName", DbType.String, owin_role.createdbyusername);
                        if (!(string.IsNullOrEmpty(owin_role.updatedbyusername)))
                            Database.AddInParameter(cmd, "@UpdatedByUserName", DbType.String, owin_role.updatedbyusername);

                        FillSequrityParameters(owin_role.BaseSecurityParam, cmd, Database);
                        AddOutputParameter(cmd);
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                        if (returnCode < 0)
                        {
                            throw new ArgumentException("Error in transaction.");
                        }
                        cmd.Dispose();
                    }
                }
                if (returnCode > 0)
                    transaction.Commit();
                else
                    throw new ArgumentException("Error Code." + returnCode.ToString());
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.CreateRole_Ext"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        long IKAFUserSecurityDataAccess.UpdateRole_Ext(owin_roleEntity owin_role)
        {
            long returnCode = -99;

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();

            try
            {

                if (owin_role != null)
                {
                    using (DbCommand cmd = Database.GetStoredProcCommand("owin_role_Upd_ext"))
                    {

                        if (owin_role.roleid.HasValue)
                            Database.AddInParameter(cmd, "@RoleID", DbType.Int64, owin_role.roleid);
                        if (!(string.IsNullOrEmpty(owin_role.rolename)))
                            Database.AddInParameter(cmd, "@RoleName", DbType.String, owin_role.rolename);
                        if (!(string.IsNullOrEmpty(owin_role.description)))
                            Database.AddInParameter(cmd, "@Description", DbType.String, owin_role.description);
                        if ((owin_role.ex_date1.HasValue))
                            Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, owin_role.ex_date1);
                        if ((owin_role.ex_date2.HasValue))
                            Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, owin_role.ex_date2);
                        if (!(string.IsNullOrEmpty(owin_role.ex_nvarchar1)))
                            Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, owin_role.ex_nvarchar1);
                        if (!(string.IsNullOrEmpty(owin_role.ex_nvarchar2)))
                            Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, owin_role.ex_nvarchar2);
                        if (owin_role.ex_bigint1.HasValue)
                            Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, owin_role.ex_bigint1);
                        if (owin_role.ex_bigint2.HasValue)
                            Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, owin_role.ex_bigint2);
                        if (owin_role.ex_decimal1.HasValue)
                            Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, owin_role.ex_decimal1);
                        if (owin_role.ex_decimal2.HasValue)
                            Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, owin_role.ex_decimal2);
                        if (!(string.IsNullOrEmpty(owin_role.createdbyusername)))
                            Database.AddInParameter(cmd, "@CreatedByUserName", DbType.String, owin_role.createdbyusername);
                        if (!(string.IsNullOrEmpty(owin_role.updatedbyusername)))
                            Database.AddInParameter(cmd, "@UpdatedByUserName", DbType.String, owin_role.updatedbyusername);

                        FillSequrityParameters(owin_role.BaseSecurityParam, cmd, Database);
                        AddOutputParameter(cmd);
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                        if (returnCode < 0)
                        {
                            throw new ArgumentException("Error in transaction.");
                        }
                        cmd.Dispose();
                    }
                }
                if (returnCode > 0)
                    transaction.Commit();
                else
                    throw new ArgumentException("Error Code." + returnCode.ToString());
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.UpdateRole_Ext"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }
        long IKAFUserSecurityDataAccess.DeleteRole_Ext(owin_roleEntity owin_role)
        {
            long returnCode = -99;

            DbConnection connection = Database.CreateConnection();
            connection.Open();
            DbTransaction transaction = connection.BeginTransaction();

            try
            {

                if (owin_role != null)
                {
                    using (DbCommand cmd = Database.GetStoredProcCommand("owin_role_Del_ext"))
                    {

                        if (owin_role.roleid.HasValue)
                            Database.AddInParameter(cmd, "@RoleID", DbType.Int64, owin_role.roleid);
                        if (!(string.IsNullOrEmpty(owin_role.rolename)))
                            Database.AddInParameter(cmd, "@RoleName", DbType.String, owin_role.rolename);
                        if (!(string.IsNullOrEmpty(owin_role.description)))
                            Database.AddInParameter(cmd, "@Description", DbType.String, owin_role.description);
                        if ((owin_role.ex_date1.HasValue))
                            Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, owin_role.ex_date1);
                        if ((owin_role.ex_date2.HasValue))
                            Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, owin_role.ex_date2);
                        if (!(string.IsNullOrEmpty(owin_role.ex_nvarchar1)))
                            Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, owin_role.ex_nvarchar1);
                        if (!(string.IsNullOrEmpty(owin_role.ex_nvarchar2)))
                            Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, owin_role.ex_nvarchar2);
                        if (owin_role.ex_bigint1.HasValue)
                            Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, owin_role.ex_bigint1);
                        if (owin_role.ex_bigint2.HasValue)
                            Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, owin_role.ex_bigint2);
                        if (owin_role.ex_decimal1.HasValue)
                            Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, owin_role.ex_decimal1);
                        if (owin_role.ex_decimal2.HasValue)
                            Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, owin_role.ex_decimal2);
                        if (!(string.IsNullOrEmpty(owin_role.createdbyusername)))
                            Database.AddInParameter(cmd, "@CreatedByUserName", DbType.String, owin_role.createdbyusername);
                        if (!(string.IsNullOrEmpty(owin_role.updatedbyusername)))
                            Database.AddInParameter(cmd, "@UpdatedByUserName", DbType.String, owin_role.updatedbyusername);

                        FillSequrityParameters(owin_role.BaseSecurityParam, cmd, Database);
                        AddOutputParameter(cmd);
                        returnCode = Database.ExecuteNonQuery(cmd, transaction);
                        if (returnCode < 0)
                        {
                            throw new ArgumentException("Error in transaction.");
                        }
                        cmd.Dispose();
                    }
                }
                if (returnCode > 0)
                    transaction.Commit();
                else
                    throw new ArgumentException("Error Code." + returnCode.ToString());
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.DeleteRole_Ext"));
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
                connection = null;
            }
            return returnCode;
        }

        public long SetReportRolePermission(owin_reportroletemplateEntity objEntity)
        {
            long returnValue = -99;
            try
            {

                using (DbCommand cmd = Database.GetStoredProcCommand("owin_reportroletemplate_Ins_Ext"))
                {
                    Database.AddInParameter(cmd, "@ReportRoleID", DbType.Int64, objEntity.reportroleid);
                    Database.AddInParameter(cmd, "@ReportIDs", DbType.String, objEntity.ex_nvarchar1);

                    AddOutputParameter(cmd);
                    FillSequrityParameters(objEntity.BaseSecurityParam, cmd, Database);

                    returnValue = Database.ExecuteNonQuery(cmd);
                    //returnValue = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
                    if (returnValue < 0)
                    {
                        throw new ArgumentException("Error Code." + returnValue.ToString());
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.AssignRolePermission"));
            }
            finally
            {

            }
            return returnValue;
        }

        IList<rptm_allreportinfoEntity> IKAFUserSecurityDataAccess.LoadReportMenu(Int64 MasterUserID)
        {
            IList<rptm_allreportinfoEntity> itemList = new List<rptm_allreportinfoEntity>();
            try
            {
                const string SP = "KAF_GetReportPermissionByUser";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@MasterUserID", DbType.Int64, MasterUserID);


                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new rptm_allreportinfoEntity(reader));
                        }
                        reader.Dispose();
                    }
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.LoadMenuByMasterUserID"));
            }
            return itemList;
        }



        IList<owin_roleEntity> IKAFUserSecurityDataAccess.GetRoleByUser(owin_userEntity owin_user)
        {
            try
            {
                const string SP = "Owin_GetUserRoleByUser";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@UserId", DbType.Guid, owin_user.userid);

                    IList<owin_roleEntity> itemList = new List<owin_roleEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_roleEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFUserSecurityDataAccess.GetRoleByUser"));
            }
        }

    }

}
