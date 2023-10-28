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
    internal sealed class KAFDataCacheDataAccessObjects : BaseDataAccess, IKAFDataCacheDataAccessObjects
    {
        #region Constructors
        private string ClassName = "KAFDataCacheDataAccessObjects";
        public KAFDataCacheDataAccessObjects(Context context)
            : base(context)
        {
        }

        private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        #endregion

        IList<owin_roleEntity> IKAFDataCacheDataAccessObjects.GetforCache_roleEntity(owin_roleEntity objEntity)
        {
            try
            {
                //const string SP = "owin_role_GA_ForCACHE";
                const string SP = "owin_role_GA_ForCache";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    if (objEntity.roleid.HasValue)
                        Database.AddInParameter(cmd, "@RoleID", DbType.Int64, objEntity.roleid);
                    if (!(string.IsNullOrEmpty(objEntity.rolename)))
                        Database.AddInParameter(cmd, "@RoleName", DbType.String, objEntity.rolename);
                    if (!(string.IsNullOrEmpty(objEntity.description)))
                        Database.AddInParameter(cmd, "@Description", DbType.String, objEntity.description);
                    if ((objEntity.ex_date1.HasValue))
                        Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, objEntity.ex_date1);
                    if ((objEntity.ex_date2.HasValue))
                        Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, objEntity.ex_date2);
                    if (!(string.IsNullOrEmpty(objEntity.ex_nvarchar1)))
                        Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, objEntity.ex_nvarchar1);
                    if (!(string.IsNullOrEmpty(objEntity.ex_nvarchar2)))
                        Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, objEntity.ex_nvarchar2);
                    if (objEntity.ex_bigint1.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, objEntity.ex_bigint1);
                    if (objEntity.ex_bigint2.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, objEntity.ex_bigint2);
                    if (objEntity.ex_decimal1.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, objEntity.ex_decimal1);
                    if (objEntity.ex_decimal2.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, objEntity.ex_decimal2);
                    if (!(string.IsNullOrEmpty(objEntity.createdbyusername)))
                        Database.AddInParameter(cmd, "@CreatedByUserName", DbType.String, objEntity.createdbyusername);
                    if (!(string.IsNullOrEmpty(objEntity.updatedbyusername)))
                        Database.AddInParameter(cmd, "@UpdatedByUserName", DbType.String, objEntity.updatedbyusername);

                    AddSortExpressionParameter(cmd, objEntity.SortExpression);
                    FillSequrityParameters(objEntity.BaseSecurityParam, cmd, Database);


                    IList<owin_roleEntity> itemList = new List<owin_roleEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            //itemList.Add(new owin_roleEntity(reader));
                            itemList.Add(new owin_roleEntity()
                            {
                                comId = reader.GetInt64(reader.GetOrdinal("comId")),
                                comText = reader.GetString(reader.GetOrdinal("comText"))

                            });
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFDataCacheDataAccessObjects.GetforCache_roleEntity"));
            }
        }

        IList<owin_reportroleEntity> IKAFDataCacheDataAccessObjects.GetforCache_reportroleEntity(owin_reportroleEntity objEntity)
        {
            try
            {
                //const string SP = "owin_reportrole_GA_ForCACHE";
                const string SP = "owin_reportrole_GA_ForCache";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    if (objEntity.reportroleid.HasValue)
                        Database.AddInParameter(cmd, "@ReportRoleID", DbType.Int64, objEntity.reportroleid);
                    if (!(string.IsNullOrEmpty(objEntity.reportrolename)))
                        Database.AddInParameter(cmd, "@ReportRoleName", DbType.String, objEntity.reportrolename);
                    if (!(string.IsNullOrEmpty(objEntity.description)))
                        Database.AddInParameter(cmd, "@Description", DbType.String, objEntity.description);
                    if ((objEntity.ex_date1.HasValue))
                        Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, objEntity.ex_date1);
                    if ((objEntity.ex_date2.HasValue))
                        Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, objEntity.ex_date2);
                    if (!(string.IsNullOrEmpty(objEntity.ex_nvarchar1)))
                        Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, objEntity.ex_nvarchar1);
                    if (!(string.IsNullOrEmpty(objEntity.ex_nvarchar2)))
                        Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, objEntity.ex_nvarchar2);
                    if (objEntity.ex_bigint1.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, objEntity.ex_bigint1);
                    if (objEntity.ex_bigint2.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, objEntity.ex_bigint2);
                    if (objEntity.ex_decimal1.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, objEntity.ex_decimal1);
                    if (objEntity.ex_decimal2.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, objEntity.ex_decimal2);
                    if (!(string.IsNullOrEmpty(objEntity.createdbyusername)))
                        Database.AddInParameter(cmd, "@CreatedByUserName", DbType.String, objEntity.createdbyusername);
                    if (!(string.IsNullOrEmpty(objEntity.updatedbyusername)))
                        Database.AddInParameter(cmd, "@UpdatedByUserName", DbType.String, objEntity.updatedbyusername);

                    AddSortExpressionParameter(cmd, objEntity.SortExpression);
                    FillSequrityParameters(objEntity.BaseSecurityParam, cmd, Database);


                    IList<owin_reportroleEntity> itemList = new List<owin_reportroleEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            //itemList.Add(new owin_reportroleEntity(reader));
                            itemList.Add(new owin_reportroleEntity()
                            {
                                comId = reader.GetInt64(reader.GetOrdinal("comId")),
                                comText = reader.GetString(reader.GetOrdinal("comText"))

                            });
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFDataCacheDataAccessObjects.GetforCache_reportroleEntity"));
            }
        }
        IList<owin_formactionEntity> IKAFDataCacheDataAccessObjects.GetforCache_formactionEntity(owin_formactionEntity objEntity)
        {
            try
            {
                //const string SP = "owin_formaction_GA_ForCACHE";
                const string SP = "owin_formaction_GA_ForCache";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {


                    if (objEntity.formactionid.HasValue)
                        Database.AddInParameter(cmd, "@FormActionID", DbType.Int64, objEntity.formactionid);
                    if (objEntity.appformid.HasValue)
                        Database.AddInParameter(cmd, "@AppFormID", DbType.Int64, objEntity.appformid);
                    if (!(string.IsNullOrEmpty(objEntity.actionname)))
                        Database.AddInParameter(cmd, "@ActionName", DbType.String, objEntity.actionname);
                    if ((objEntity.isview != null))
                        Database.AddInParameter(cmd, "@IsView", DbType.Boolean, objEntity.isview);
                    if ((objEntity.ex_date1.HasValue))
                        Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, objEntity.ex_date1);
                    if ((objEntity.ex_date2.HasValue))
                        Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, objEntity.ex_date2);
                    if (!(string.IsNullOrEmpty(objEntity.ex_nvarchar1)))
                        Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, objEntity.ex_nvarchar1);
                    if (!(string.IsNullOrEmpty(objEntity.ex_nvarchar2)))
                        Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, objEntity.ex_nvarchar2);
                    if (objEntity.ex_bigint1.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, objEntity.ex_bigint1);
                    if (objEntity.ex_bigint2.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, objEntity.ex_bigint2);
                    if (objEntity.ex_decimal1.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, objEntity.ex_decimal1);
                    if (objEntity.ex_decimal2.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, objEntity.ex_decimal2);
                    if (!(string.IsNullOrEmpty(objEntity.createdbyusername)))
                        Database.AddInParameter(cmd, "@CreatedByUserName", DbType.String, objEntity.createdbyusername);
                    if (!(string.IsNullOrEmpty(objEntity.updatedbyusername)))
                        Database.AddInParameter(cmd, "@UpdatedByUserName", DbType.String, objEntity.updatedbyusername);
                    IList<owin_formactionEntity> itemList = new List<owin_formactionEntity>();
                    //AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, objEntity.SortExpression);
                    FillSequrityParameters(objEntity.BaseSecurityParam, cmd, Database);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_formactionEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFDataCacheDataAccessObjects.GetforCache_formactionEntity"));
            }
        }

        IList<owin_forminfoEntity> IKAFDataCacheDataAccessObjects.GetforCache_forminfoEntity(owin_forminfoEntity objEntity)
        {
            try
            {
                //const string SP = "owin_forminfo_GA_ForCACHE";
                const string SP = "owin_forminfo_GA_ForCache";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    if (objEntity.appformid.HasValue)
                        Database.AddInParameter(cmd, "@AppFormID", DbType.Int64, objEntity.appformid);
                    if (!(string.IsNullOrEmpty(objEntity.formname)))
                        Database.AddInParameter(cmd, "@FormName", DbType.String, objEntity.formname);
                    if (objEntity.parentid.HasValue)
                        Database.AddInParameter(cmd, "@ParentID", DbType.Int64, objEntity.parentid);
                    if (objEntity.levelid.HasValue)
                        Database.AddInParameter(cmd, "@LevelID", DbType.Int32, objEntity.levelid);
                    if (!(string.IsNullOrEmpty(objEntity.menulevel)))
                        Database.AddInParameter(cmd, "@MenuLevel", DbType.String, objEntity.menulevel);
                    if (!(string.IsNullOrEmpty(objEntity.formnamear)))
                        Database.AddInParameter(cmd, "@FormNameAr", DbType.String, objEntity.formnamear);
                    if ((objEntity.hasdirectchild != null))
                        Database.AddInParameter(cmd, "@HasDirectChild", DbType.Boolean, objEntity.hasdirectchild);

                    if (!(string.IsNullOrEmpty(objEntity.classicon)))
                        Database.AddInParameter(cmd, "@ClassIcon", DbType.String, objEntity.classicon);
                    if (objEntity.sequence.HasValue)
                        Database.AddInParameter(cmd, "@Sequence", DbType.Int32, objEntity.sequence);
                    if (!(string.IsNullOrEmpty(objEntity.url)))
                        Database.AddInParameter(cmd, "@URL", DbType.String, objEntity.url);
                    if ((objEntity.isview != null))
                        Database.AddInParameter(cmd, "@IsView", DbType.Boolean, objEntity.isview);
                    if ((objEntity.isdynamic != null))
                        Database.AddInParameter(cmd, "@IsDynamic", DbType.Boolean, objEntity.isdynamic);
                    if ((objEntity.issuperadmin != null))
                        Database.AddInParameter(cmd, "@IsSuperAdmin", DbType.Boolean, objEntity.issuperadmin);
                    if ((objEntity.isvisibleinmenu != null))
                        Database.AddInParameter(cmd, "@IsVisibleInMenu", DbType.Boolean, objEntity.isvisibleinmenu);
                    if (objEntity.organizationkey.HasValue)
                        Database.AddInParameter(cmd, "@OrganizationKey", DbType.Int64, objEntity.organizationkey);
                    if ((objEntity.ex_date1.HasValue))
                        Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, objEntity.ex_date1);
                    if ((objEntity.ex_date2.HasValue))
                        Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, objEntity.ex_date2);
                    if (!(string.IsNullOrEmpty(objEntity.ex_nvarchar1)))
                        Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, objEntity.ex_nvarchar1);
                    if (!(string.IsNullOrEmpty(objEntity.ex_nvarchar2)))
                        Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, objEntity.ex_nvarchar2);
                    if (objEntity.ex_bigint1.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, objEntity.ex_bigint1);
                    if (objEntity.ex_bigint2.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, objEntity.ex_bigint2);
                    if (objEntity.ex_decimal1.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, objEntity.ex_decimal1);
                    if (objEntity.ex_decimal2.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, objEntity.ex_decimal2);
                    if (!(string.IsNullOrEmpty(objEntity.createdbyusername)))
                        Database.AddInParameter(cmd, "@CreatedByUserName", DbType.String, objEntity.createdbyusername);
                    if (!(string.IsNullOrEmpty(objEntity.updatedbyusername)))
                        Database.AddInParameter(cmd, "@UpdatedByUserName", DbType.String, objEntity.updatedbyusername);
                    //AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, objEntity.SortExpression);
                    FillSequrityParameters(objEntity.BaseSecurityParam, cmd, Database);


                    IList<owin_forminfoEntity> itemList = new List<owin_forminfoEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {

                        while (reader.Read())
                        {
                            itemList.Add(new owin_forminfoEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFDataCacheDataAccessObjects.GetforCache_forminfoEntity"));
            }
        }


        IList<gen_airlinesEntity> IKAFDataCacheDataAccessObjects.GetforCache_gen_airlinesEntity(gen_airlinesEntity objEntity)
        {
            IList<gen_airlinesEntity> itemList = new List<gen_airlinesEntity>();
            try
            {
                const string SP = "gen_airlines_GA_ForCache";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddSortExpressionParameter(cmd, objEntity.SortExpression);
                    FillSequrityParameters(objEntity.BaseSecurityParam, cmd, Database);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_airlinesEntity()
                            {
                                comId = reader.GetInt64(reader.GetOrdinal("comId")),
                                comText = reader.GetString(reader.GetOrdinal("comText"))
                            });
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFDataCacheDataAccessObjects.GetforCache_gen_airlinesEntity"));
            }
        }

        IList<gen_buildingEntity> IKAFDataCacheDataAccessObjects.GetforCache_gen_buildingEntity(gen_buildingEntity objEntity)
        {
            IList<gen_buildingEntity> itemList = new List<gen_buildingEntity>();
            try
            {
                const string SP = "gen_building_GA_ForCache";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddSortExpressionParameter(cmd, objEntity.SortExpression);
                    FillSequrityParameters(objEntity.BaseSecurityParam, cmd, Database);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_buildingEntity()
                            {
                                comId = reader.GetInt64(reader.GetOrdinal("comId")),
                                comText = reader.GetString(reader.GetOrdinal("comText"))
                            });
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFDataCacheDataAccessObjects.GetforCache_gen_buildingEntity"));
            }
        }


        IList<gen_okpEntity> IKAFDataCacheDataAccessObjects.GetforCache_gen_okpEntity(gen_okpEntity objEntity)
        {
            IList<gen_okpEntity> itemList = new List<gen_okpEntity>();
            try
            {
                const string SP = "gen_okp_GA_ForCache";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddSortExpressionParameter(cmd, objEntity.SortExpression);
                    FillSequrityParameters(objEntity.BaseSecurityParam, cmd, Database);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_okpEntity()
                            {
                                comId = reader.GetInt64(reader.GetOrdinal("comId")),
                                comText = reader.GetString(reader.GetOrdinal("comText"))
                            });
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFDataCacheDataAccessObjects.GetforCache_gen_okpEntity"));
            }
        }









        IList<gen_armsEntity> IKAFDataCacheDataAccessObjects.GetforCache_gen_armsEntity(gen_armsEntity objEntity)
        {
            IList<gen_armsEntity> itemList = new List<gen_armsEntity>();
            try
            {
                const string SP = "gen_arms_GA_ForCache";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddSortExpressionParameter(cmd, objEntity.SortExpression);
                    FillSequrityParameters(objEntity.BaseSecurityParam, cmd, Database);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_armsEntity()
                            {
                                comId = reader.GetInt64(reader.GetOrdinal("comId")),
                                comText = reader.GetString(reader.GetOrdinal("comText"))
                            });
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFDataCacheDataAccessObjects.GetforCache_gen_armsEntity"));
            }
        }
        IList<stp_organizationentitytypeEntity> IKAFDataCacheDataAccessObjects.GetforCache_stp_organizationentitytypeEntity(stp_organizationentitytypeEntity stp_organizationentitytype)
        {
            IList<stp_organizationentitytypeEntity> itemList = new List<stp_organizationentitytypeEntity>();
            try
            {
                const string SP = "Stp_OrganizationEntityType_GA_ForCache";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddSortExpressionParameter(cmd, stp_organizationentitytype.SortExpression);
                    FillSequrityParameters(stp_organizationentitytype.BaseSecurityParam, cmd, Database);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new stp_organizationentitytypeEntity()
                            {
                                comId = reader.GetInt64(reader.GetOrdinal("comId")),
                                comText = reader.GetString(reader.GetOrdinal("comText"))
                            });
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFDataCacheDataAccessObjects.GetforCache_stp_organizationentitytypeEntity"));
            }
        }
        IList<stp_organizationEntity> IKAFDataCacheDataAccessObjects.GetforCache_stp_organizationEntity(stp_organizationEntity stp_organization)
        {
            IList<stp_organizationEntity> itemList = new List<stp_organizationEntity>();
            try
            {
                const string SP = "stp_organization_GA_ForCache";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddSortExpressionParameter(cmd, stp_organization.SortExpression);
                    FillSequrityParameters(stp_organization.BaseSecurityParam, cmd, Database);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new stp_organizationEntity()
                            {
                                comId = reader.GetInt64(reader.GetOrdinal("comId")),
                                comText = reader.GetString(reader.GetOrdinal("comText"))
                            });
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFDataCacheDataAccessObjects.GetforCache_stp_organizationEntity"));
            }
        }

        IList<gen_bankbranchEntity> IKAFDataCacheDataAccessObjects.GetforCache_gen_bankbranchEntity(gen_bankbranchEntity gen_bankbranch)
        {
            IList<gen_bankbranchEntity> itemList = new List<gen_bankbranchEntity>();
            try
            {
                const string SP = "gen_bankbranch_GA_ForCache";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddSortExpressionParameter(cmd, gen_bankbranch.SortExpression);
                    FillSequrityParameters(gen_bankbranch.BaseSecurityParam, cmd, Database);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_bankbranchEntity()
                            {
                                comId = reader.GetInt64(reader.GetOrdinal("comId")),
                                comText = reader.GetString(reader.GetOrdinal("comText"))
                            });
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFDataCacheDataAccessObjects.GetforCache_gen_bankbranchEntity"));
            }
        }
        IList<gen_bankEntity> IKAFDataCacheDataAccessObjects.GetforCache_gen_bankEntity(gen_bankEntity gen_bank)
        {
            IList<gen_bankEntity> itemList = new List<gen_bankEntity>();
            try
            {
                const string SP = "gen_bank_GA_FORCACHE";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddSortExpressionParameter(cmd, gen_bank.SortExpression);
                    FillSequrityParameters(gen_bank.BaseSecurityParam, cmd, Database);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_bankEntity()
                            {
                                comId = reader.GetInt64(reader.GetOrdinal("comId")),
                                comText = reader.GetString(reader.GetOrdinal("comText"))
                            });
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFDataCacheDataAccessObjects.GetforCache_gen_bankEntity"));
            }
        }

        IList<gen_filetypeEntity> IKAFDataCacheDataAccessObjects.GetforCache_gen_filetypeEntity(gen_filetypeEntity gen_filetype)
        {
            IList<gen_filetypeEntity> itemList = new List<gen_filetypeEntity>();
            try
            {
                const string SP = "gen_filetype_GA_ForCache";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddSortExpressionParameter(cmd, gen_filetype.SortExpression);
                    FillSequrityParameters(gen_filetype.BaseSecurityParam, cmd, Database);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_filetypeEntity()
                            {
                                comId = reader.GetInt64(reader.GetOrdinal("comId")),
                                comText = reader.GetString(reader.GetOrdinal("comText"))
                            });
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFDataCacheDataAccessObjects.GetforCache_gen_filetypentity"));
            }
        }

        IList<gen_relationshipEntity> IKAFDataCacheDataAccessObjects.GetforCache_gen_relationshipEntity(gen_relationshipEntity gen_relationship)
        {
            IList<gen_relationshipEntity> itemList = new List<gen_relationshipEntity>();
            try
            {
                const string SP = "gen_relationship_GA_ForCache";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddSortExpressionParameter(cmd, gen_relationship.SortExpression);
                    FillSequrityParameters(gen_relationship.BaseSecurityParam, cmd, Database);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_relationshipEntity()
                            {
                                comId = reader.GetInt64(reader.GetOrdinal("comId")),
                                comText = reader.GetString(reader.GetOrdinal("comText"))
                            });
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFDataCacheDataAccessObjects.GetforCache_gen_relationshipEntity"));
            }
        }


        IList<gen_bloodgroupEntity> IKAFDataCacheDataAccessObjects.GetforCache_gen_bloodgroupEntity(gen_bloodgroupEntity objEntity)
        {
            IList<gen_bloodgroupEntity> itemList = new List<gen_bloodgroupEntity>();
            try
            {
                const string SP = "gen_bloodgroup_GA_FORCACHE";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddSortExpressionParameter(cmd, objEntity.SortExpression);
                    FillSequrityParameters(objEntity.BaseSecurityParam, cmd, Database);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_bloodgroupEntity()
                            {
                                comId = reader.GetInt64(reader.GetOrdinal("comId")),
                                comText = reader.GetString(reader.GetOrdinal("comText"))
                            });
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFDataCacheDataAccessObjects.GetforCache_gen_bloodgroupEntity"));
            }
        }
        IList<gen_freedomfighttypeEntity> IKAFDataCacheDataAccessObjects.GetforCache_gen_freedomfighttypeEntity(gen_freedomfighttypeEntity objEntity)
        {
            IList<gen_freedomfighttypeEntity> itemList = new List<gen_freedomfighttypeEntity>();
            try
            {
                const string SP = "gen_freedomfighttype_GA_FORCACHE";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddSortExpressionParameter(cmd, objEntity.SortExpression);
                    FillSequrityParameters(objEntity.BaseSecurityParam, cmd, Database);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_freedomfighttypeEntity()
                            {
                                comId = reader.GetInt64(reader.GetOrdinal("comId")),
                                comText = reader.GetString(reader.GetOrdinal("comText"))
                            });
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFDataCacheDataAccessObjects.GetforCache_gen_freedomfighttypeEntity"));
            }
        }
        IList<gen_genderEntity> IKAFDataCacheDataAccessObjects.GetforCache_gen_genderEntity(gen_genderEntity objEntity)
        {
            IList<gen_genderEntity> itemList = new List<gen_genderEntity>();
            try
            {
                const string SP = "gen_gender_GA_FORCACHE";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddSortExpressionParameter(cmd, objEntity.SortExpression);
                    FillSequrityParameters(objEntity.BaseSecurityParam, cmd, Database);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_genderEntity()
                            {
                                comId = reader.GetInt64(reader.GetOrdinal("comId")),
                                comText = reader.GetString(reader.GetOrdinal("comText"))
                            });
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFDataCacheDataAccessObjects.GetforCache_gen_genderEntity"));
            }
        }
        IList<gen_issuetypeEntity> IKAFDataCacheDataAccessObjects.GetforCache_gen_issuetypeEntity(gen_issuetypeEntity objEntity)
        {
            IList<gen_issuetypeEntity> itemList = new List<gen_issuetypeEntity>();
            try
            {
                const string SP = "gen_issuetype_GA_FORCACHE";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddSortExpressionParameter(cmd, objEntity.SortExpression);
                    FillSequrityParameters(objEntity.BaseSecurityParam, cmd, Database);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_issuetypeEntity()
                            {
                                comId = reader.GetInt64(reader.GetOrdinal("comId")),
                                comText = reader.GetString(reader.GetOrdinal("comText"))
                            });
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFDataCacheDataAccessObjects.GetforCache_gen_issuetypeEntity"));
            }
        }
        IList<gen_languageEntity> IKAFDataCacheDataAccessObjects.GetforCache_gen_languageEntity(gen_languageEntity objEntity)
        {
            IList<gen_languageEntity> itemList = new List<gen_languageEntity>();
            try
            {
                const string SP = "gen_language_GA_FORCACHE";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddSortExpressionParameter(cmd, objEntity.SortExpression);
                    FillSequrityParameters(objEntity.BaseSecurityParam, cmd, Database);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_languageEntity()
                            {
                                comId = reader.GetInt64(reader.GetOrdinal("comId")),
                                comText = reader.GetString(reader.GetOrdinal("comText"))
                            });
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFDataCacheDataAccessObjects.GetforCache_gen_languageEntity"));
            }
        }
        IList<gen_languageproficiencyEntity> IKAFDataCacheDataAccessObjects.GetforCache_gen_languageproficiencyEntity(gen_languageproficiencyEntity objEntity)
        {
            IList<gen_languageproficiencyEntity> itemList = new List<gen_languageproficiencyEntity>();
            try
            {
                const string SP = "gen_languageproficiency_GA_FORCACHE";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddSortExpressionParameter(cmd, objEntity.SortExpression);
                    FillSequrityParameters(objEntity.BaseSecurityParam, cmd, Database);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_languageproficiencyEntity()
                            {
                                comId = reader.GetInt64(reader.GetOrdinal("comId")),
                                comText = reader.GetString(reader.GetOrdinal("comText"))
                            });
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFDataCacheDataAccessObjects.GetforCache_gen_languageproficiencyEntity"));
            }
        }
        IList<gen_maritalstatusEntity> IKAFDataCacheDataAccessObjects.GetforCache_gen_maritalstatusEntity(gen_maritalstatusEntity objEntity)
        {
            IList<gen_maritalstatusEntity> itemList = new List<gen_maritalstatusEntity>();
            try
            {
                const string SP = "gen_maritalstatus_GA_FORCACHE";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddSortExpressionParameter(cmd, objEntity.SortExpression);
                    FillSequrityParameters(objEntity.BaseSecurityParam, cmd, Database);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_maritalstatusEntity()
                            {
                                comId = reader.GetInt64(reader.GetOrdinal("comId")),
                                comText = reader.GetString(reader.GetOrdinal("comText"))
                            });
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFDataCacheDataAccessObjects.GetforCache_gen_maritalstatusEntity"));
            }
        }
        IList<gen_movementtypeEntity> IKAFDataCacheDataAccessObjects.GetforCache_gen_movementtypeEntity(gen_movementtypeEntity objEntity)
        {
            IList<gen_movementtypeEntity> itemList = new List<gen_movementtypeEntity>();
            try
            {
                const string SP = "gen_movementtype_GA_FORCACHE";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddSortExpressionParameter(cmd, objEntity.SortExpression);
                    FillSequrityParameters(objEntity.BaseSecurityParam, cmd, Database);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_movementtypeEntity()
                            {
                                comId = reader.GetInt64(reader.GetOrdinal("comId")),
                                comText = reader.GetString(reader.GetOrdinal("comText"))
                            });
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFDataCacheDataAccessObjects.GetforCache_gen_movementtypeEntity"));
            }
        }
        IList<gen_penaltytypeEntity> IKAFDataCacheDataAccessObjects.GetforCache_gen_penaltytypeEntity(gen_penaltytypeEntity objEntity)
        {
            IList<gen_penaltytypeEntity> itemList = new List<gen_penaltytypeEntity>();
            try
            {
                const string SP = "gen_penaltytype_GA_FORCACHE";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddSortExpressionParameter(cmd, objEntity.SortExpression);
                    FillSequrityParameters(objEntity.BaseSecurityParam, cmd, Database);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_penaltytypeEntity()
                            {
                                comId = reader.GetInt64(reader.GetOrdinal("comId")),
                                comText = reader.GetString(reader.GetOrdinal("comText"))
                            });
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFDataCacheDataAccessObjects.GetforCache_gen_penaltytypeEntity"));
            }
        }
        IList<gen_promotiontypeEntity> IKAFDataCacheDataAccessObjects.GetforCache_gen_promotiontypeEntity(gen_promotiontypeEntity objEntity)
        {
            IList<gen_promotiontypeEntity> itemList = new List<gen_promotiontypeEntity>();
            try
            {
                const string SP = "gen_promotiontype_GA_FORCACHE";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddSortExpressionParameter(cmd, objEntity.SortExpression);
                    FillSequrityParameters(objEntity.BaseSecurityParam, cmd, Database);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_promotiontypeEntity()
                            {
                                comId = reader.GetInt64(reader.GetOrdinal("comId")),
                                comText = reader.GetString(reader.GetOrdinal("comText"))
                            });
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFDataCacheDataAccessObjects.GetforCache_gen_promotiontypeEntity"));
            }
        }
        IList<gen_ranktypeEntity> IKAFDataCacheDataAccessObjects.GetforCache_gen_ranktypeEntity(gen_ranktypeEntity objEntity)
        {
            IList<gen_ranktypeEntity> itemList = new List<gen_ranktypeEntity>();
            try
            {
                const string SP = "gen_ranktype_GA_FORCACHE";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddSortExpressionParameter(cmd, objEntity.SortExpression);
                    FillSequrityParameters(objEntity.BaseSecurityParam, cmd, Database);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_ranktypeEntity()
                            {
                                comId = reader.GetInt64(reader.GetOrdinal("comId")),
                                comText = reader.GetString(reader.GetOrdinal("comText"))
                            });
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFDataCacheDataAccessObjects.GetforCache_gen_ranktypeEntity"));
            }
        }
        IList<gen_religionEntity> IKAFDataCacheDataAccessObjects.GetforCache_gen_religionEntity(gen_religionEntity objEntity)
        {
            IList<gen_religionEntity> itemList = new List<gen_religionEntity>();
            try
            {
                const string SP = "gen_religion_GA_FORCACHE";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddSortExpressionParameter(cmd, objEntity.SortExpression);
                    FillSequrityParameters(objEntity.BaseSecurityParam, cmd, Database);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_religionEntity()
                            {
                                comId = reader.GetInt64(reader.GetOrdinal("comId")),
                                comText = reader.GetString(reader.GetOrdinal("comText"))
                            });
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFDataCacheDataAccessObjects.GetforCache_gen_religionEntity"));
            }
        }
        IList<gen_servicestatusEntity> IKAFDataCacheDataAccessObjects.GetforCache_gen_servicestatusEntity(gen_servicestatusEntity objEntity)
        {
            IList<gen_servicestatusEntity> itemList = new List<gen_servicestatusEntity>();
            try
            {
                const string SP = "gen_servicestatus_GA_FORCACHE";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddSortExpressionParameter(cmd, objEntity.SortExpression);
                    FillSequrityParameters(objEntity.BaseSecurityParam, cmd, Database);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_servicestatusEntity()
                            {
                                comId = reader.GetInt64(reader.GetOrdinal("comId")),
                                comText = reader.GetString(reader.GetOrdinal("comText"))
                            });
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFDataCacheDataAccessObjects.GetforCache_gen_servicestatusEntity"));
            }
        }

        IList<gen_leavetypeEntity> IKAFDataCacheDataAccessObjects.GetforCache_gen_leavetypeEntity(gen_leavetypeEntity objEntity)
        {
            IList<gen_leavetypeEntity> itemList = new List<gen_leavetypeEntity>();
            try
            {
                const string SP = "gen_leavetype_GA_ForCache";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddSortExpressionParameter(cmd, objEntity.SortExpression);
                    FillSequrityParameters(objEntity.BaseSecurityParam, cmd, Database);
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_leavetypeEntity()
                            {
                                comId = reader.GetInt64(reader.GetOrdinal("comId")),
                                comText = reader.GetString(reader.GetOrdinal("comText"))
                            });
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("IKAFDataCacheDataAccessObjects.GetforCache_gen_leavetypeEntity"));
            }
        }
    }
}
