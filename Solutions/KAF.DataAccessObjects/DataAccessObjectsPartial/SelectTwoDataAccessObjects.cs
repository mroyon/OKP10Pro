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
    internal sealed class SelectTwoDataAccessObjects : BaseDataAccess, ISelectTwoDataAccessObjects
    {
        #region Constructors
        private string ClassName = "SelectTwoDataAccessObjects";
        public SelectTwoDataAccessObjects(Context context)
            : base(context)
        {
        }

        private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        #endregion
        
        IList<stp_organizationentityEntity> ISelectTwoDataAccessObjects.GetPaged_Stp_OrganizationEntity(stp_organizationentityEntity stp_organizationentity)
        {
            IList<stp_organizationentityEntity> itemList = new List<stp_organizationentityEntity>();
            try
            {
                const string SP = "stp_organizationentity_GAPgListView_SelectToExt";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    if (stp_organizationentity.entitykey.HasValue)
                        Database.AddInParameter(cmd, "@EntityKey", DbType.Int64, stp_organizationentity.entitykey);
                    if (stp_organizationentity.organizationkey.HasValue)
                        Database.AddInParameter(cmd, "@OrganizationKey", DbType.Int64, stp_organizationentity.organizationkey);
                    if (stp_organizationentity.parentkey.HasValue)
                        Database.AddInParameter(cmd, "@ParentKey", DbType.Int64, stp_organizationentity.parentkey);
                    if (stp_organizationentity.entirytypekey.HasValue)
                        Database.AddInParameter(cmd, "@EntiryTypeKey", DbType.Int64, stp_organizationentity.entirytypekey);
                    if (stp_organizationentity.entitylevel.HasValue)
                        Database.AddInParameter(cmd, "@EntityLevel", DbType.Int32, stp_organizationentity.entitylevel);
                    if (!(string.IsNullOrEmpty(stp_organizationentity.seqfirstindex)))
                        Database.AddInParameter(cmd, "@SeqFirstIndex", DbType.String, stp_organizationentity.seqfirstindex);
                    if (!(string.IsNullOrEmpty(stp_organizationentity.seqfullindex)))
                        Database.AddInParameter(cmd, "@SeqFullIndex", DbType.String, stp_organizationentity.seqfullindex);
                    //if (!(string.IsNullOrEmpty(stp_organizationentity.entitycpde)))
                    //    Database.AddInParameter(cmd, "@EntityCpde", DbType.String, stp_organizationentity.entitycpde);
                    if (!(string.IsNullOrEmpty(stp_organizationentity.entityname)))
                        Database.AddInParameter(cmd, "@EntityName", DbType.String, stp_organizationentity.entityname);
                    if (!(string.IsNullOrEmpty(stp_organizationentity.description)))
                        Database.AddInParameter(cmd, "@Description", DbType.String, stp_organizationentity.description);
                    if ((stp_organizationentity.isactive != null))
                        Database.AddInParameter(cmd, "@IsActive", DbType.Boolean, stp_organizationentity.isactive);
                    if ((stp_organizationentity.ex_date1.HasValue))
                        Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, stp_organizationentity.ex_date1);
                    if ((stp_organizationentity.ex_date2.HasValue))
                        Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, stp_organizationentity.ex_date2);
                    if (!(string.IsNullOrEmpty(stp_organizationentity.ex_nvarchar1)))
                        Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, stp_organizationentity.ex_nvarchar1);
                    if (!(string.IsNullOrEmpty(stp_organizationentity.ex_nvarchar2)))
                        Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, stp_organizationentity.ex_nvarchar2);
                    if (stp_organizationentity.ex_bigint1.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, stp_organizationentity.ex_bigint1);
                    if (stp_organizationentity.ex_bigint2.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, stp_organizationentity.ex_bigint2);
                    if (stp_organizationentity.ex_decimal1.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, stp_organizationentity.ex_decimal1);
                    if (stp_organizationentity.ex_decimal2.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, stp_organizationentity.ex_decimal2);

                    if (stp_organizationentity.ex_decimal2.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, stp_organizationentity.ex_decimal2);

                    if (!string.IsNullOrEmpty(stp_organizationentity.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, stp_organizationentity.strCommonSerachParam);

                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, stp_organizationentity.SortExpression);
                    AddPageSizeParameter(cmd, stp_organizationentity.PageSize);
                    AddCurrentPageParameter(cmd, stp_organizationentity.CurrentPage);
                    FillSequrityParameters(stp_organizationentity.BaseSecurityParam, cmd, Database);


                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new stp_organizationentityEntity(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        stp_organizationentity.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;

                }

            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("ISelectTwoDataAccessObjects.GetPaged_Stp_OrganizationEntity"));
            }
            return itemList;
        }

        IList<gen_govcityEntity> ISelectTwoDataAccessObjects.GetPaged_Gen_GovCity(gen_govcityEntity gen_govcity)
        {
            IList<gen_govcityEntity> itemList = new List<gen_govcityEntity>();
            try
            {
                const string SP = "gen_govcity_GAPgListView_SelectToExt";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    if (gen_govcity.cityid.HasValue)
                        Database.AddInParameter(cmd, "@CityID", DbType.Int64, gen_govcity.cityid);
                    //if (gen_govcity.oraclecityid.HasValue)
                    //    Database.AddInParameter(cmd, "@OracleCityID", DbType.Int64, gen_govcity.oraclecityid);
                    if (gen_govcity.parentid.HasValue)
                        Database.AddInParameter(cmd, "@ParentID", DbType.Int64, gen_govcity.parentid);
                    //if (gen_govcity.oracleparentid.HasValue)
                    //    Database.AddInParameter(cmd, "@OracleParentID", DbType.Int64, gen_govcity.oracleparentid);
                    if (!(string.IsNullOrEmpty(gen_govcity.cityname)))
                        Database.AddInParameter(cmd, "@CityName", DbType.String, gen_govcity.cityname);
                    //if (!(string.IsNullOrEmpty(gen_govcity.citynameeng)))
                    //    Database.AddInParameter(cmd, "@CityNameEng", DbType.String, gen_govcity.citynameeng);
                    if ((gen_govcity.isgov != null))
                        Database.AddInParameter(cmd, "@IsGov", DbType.Boolean, gen_govcity.isgov);
                    if (gen_govcity.countryid.HasValue)
                        Database.AddInParameter(cmd, "@CountryID", DbType.Int64, gen_govcity.countryid);

                    //Database.AddInParameter(cmd, "@AREA_CODE_PACI", DbType.Decimal, gen_govcity.area_code_paci);
                    if (!(string.IsNullOrEmpty(gen_govcity.remarks)))
                        Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_govcity.remarks);
                    if ((gen_govcity.ex_date1.HasValue))
                        Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_govcity.ex_date1);
                    if ((gen_govcity.ex_date2.HasValue))
                        Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_govcity.ex_date2);
                    if (!(string.IsNullOrEmpty(gen_govcity.ex_nvarchar1)))
                        Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_govcity.ex_nvarchar1);
                    if (!(string.IsNullOrEmpty(gen_govcity.ex_nvarchar2)))
                        Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_govcity.ex_nvarchar2);
                    if (gen_govcity.ex_bigint1.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_govcity.ex_bigint1);
                    if (gen_govcity.ex_bigint2.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_govcity.ex_bigint2);
                    if (gen_govcity.ex_decimal1.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_govcity.ex_decimal1);
                    if (gen_govcity.ex_decimal2.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_govcity.ex_decimal2);

                    if (!string.IsNullOrEmpty(gen_govcity.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_govcity.strCommonSerachParam);

                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_govcity.SortExpression);
                    AddPageSizeParameter(cmd, gen_govcity.PageSize);
                    AddCurrentPageParameter(cmd, gen_govcity.CurrentPage);
                    FillSequrityParameters(gen_govcity.BaseSecurityParam, cmd, Database);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_govcityEntity(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_govcity.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;

                }

            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("ISelectTwoDataAccessObjects.GetPaged_Gen_GovCity"));
            }
            return itemList;
        }
        
        IList<gen_countryEntity> ISelectTwoDataAccessObjects.GetPaged_Gen_Country(gen_countryEntity gen_country)
        {
            IList<gen_countryEntity> itemList = new List<gen_countryEntity>();
            try
            {
                const string SP = "gen_country_GAPgListView_SelectToExt";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    if (gen_country.countryid.HasValue)
                        Database.AddInParameter(cmd, "@CountryID", DbType.Int64, gen_country.countryid);
                    if (!(string.IsNullOrEmpty(gen_country.countryname)))
                        Database.AddInParameter(cmd, "@CountryName", DbType.String, gen_country.countryname);
                    if (!(string.IsNullOrEmpty(gen_country.nationality)))
                        Database.AddInParameter(cmd, "@Nationality", DbType.String, gen_country.nationality);
                    if (!(string.IsNullOrEmpty(gen_country.remarks)))
                        Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_country.remarks);
                    if ((gen_country.ex_date1.HasValue))
                        Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_country.ex_date1);
                    if ((gen_country.ex_date2.HasValue))
                        Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_country.ex_date2);
                    if (!(string.IsNullOrEmpty(gen_country.ex_nvarchar1)))
                        Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_country.ex_nvarchar1);
                    if (!(string.IsNullOrEmpty(gen_country.ex_nvarchar2)))
                        Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_country.ex_nvarchar2);
                    if (gen_country.ex_bigint1.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_country.ex_bigint1);
                    if (gen_country.ex_bigint2.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_country.ex_bigint2);
                    if (gen_country.ex_decimal1.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_country.ex_decimal1);
                    if (gen_country.ex_decimal2.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_country.ex_decimal2);

                    if (!string.IsNullOrEmpty(gen_country.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_country.strCommonSerachParam);

                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_country.SortExpression);
                    AddPageSizeParameter(cmd, gen_country.PageSize);
                    AddCurrentPageParameter(cmd, gen_country.CurrentPage);
                    FillSequrityParameters(gen_country.BaseSecurityParam, cmd, Database);


                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_countryEntity(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_country.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }

            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("ISelectTwoDataAccessObjects.GetPaged_Gen_Country"));
            }
            return itemList;
        }

        IList<gen_divisiondistrictEntity> ISelectTwoDataAccessObjects.GetPaged_Gen_District(gen_divisiondistrictEntity objEntity)
        {
            IList<gen_divisiondistrictEntity> itemList = new List<gen_divisiondistrictEntity>();
            try
            {
                const string SP = "gen_divisiondistrict_GAPgListView_SelectToExt";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    if (objEntity.districtid.HasValue)
                        Database.AddInParameter(cmd, "@DistrictID", DbType.Int64, objEntity.districtid);
                    if (objEntity.parentid.HasValue)
                        Database.AddInParameter(cmd, "@ParentID", DbType.Int64, objEntity.parentid);
                    if (!(string.IsNullOrEmpty(objEntity.districtname)))
                        Database.AddInParameter(cmd, "@DistrictName", DbType.String, objEntity.districtname);
                    if (objEntity.isdivision.HasValue)
                        Database.AddInParameter(cmd, "@IsDivision", DbType.Boolean, objEntity.isdivision);
                    if (objEntity.countryid.HasValue)
                        Database.AddInParameter(cmd, "@CountryID", DbType.Int64, objEntity.countryid);
                    if (!(string.IsNullOrEmpty(objEntity.remarks)))
                        Database.AddInParameter(cmd, "@Remarks", DbType.String, objEntity.remarks);
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

                    if (!string.IsNullOrEmpty(objEntity.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, objEntity.strCommonSerachParam);

                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, objEntity.SortExpression);
                    AddPageSizeParameter(cmd, objEntity.PageSize);
                    AddCurrentPageParameter(cmd, objEntity.CurrentPage);
                    FillSequrityParameters(objEntity.BaseSecurityParam, cmd, Database);


                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_divisiondistrictEntity(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        objEntity.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }

            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("ISelectTwoDataAccessObjects.GetPaged_Gen_Country"));
            }
        }

        IList<gen_rankEntity> ISelectTwoDataAccessObjects.GetPaged_Gen_Rank(gen_rankEntity gen_rank)
        {
            IList<gen_rankEntity> itemList = new List<gen_rankEntity>();
            try
            {
                const string SP = "gen_rank_GAPgListView_SelectToExt";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    if (gen_rank.rankid.HasValue)
                        Database.AddInParameter(cmd, "@RankID", DbType.Int64, gen_rank.rankid);
                    if (!(string.IsNullOrEmpty(gen_rank.rankname)))
                        Database.AddInParameter(cmd, "@RankName", DbType.String, gen_rank.rankname);
                    if (gen_rank.ranktypeid.HasValue)
                        Database.AddInParameter(cmd, "@RankTypeID", DbType.Int64, gen_rank.ranktypeid);
                    if (gen_rank.countryid.HasValue)
                        Database.AddInParameter(cmd, "@CountryID", DbType.Int64, gen_rank.countryid);
                    if (gen_rank.typepriority.HasValue)
                        Database.AddInParameter(cmd, "@TypePriority", DbType.Int64, gen_rank.typepriority);
                    if (gen_rank.priority.HasValue)
                        Database.AddInParameter(cmd, "@Priority", DbType.Int64, gen_rank.priority);
                    if (!(string.IsNullOrEmpty(gen_rank.comments)))
                        Database.AddInParameter(cmd, "@Comments", DbType.String, gen_rank.comments);
                    if (!(string.IsNullOrEmpty(gen_rank.remarks)))
                        Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_rank.remarks);
                    if ((gen_rank.ex_date1.HasValue))
                        Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_rank.ex_date1);
                    if ((gen_rank.ex_date2.HasValue))
                        Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_rank.ex_date2);
                    if (!(string.IsNullOrEmpty(gen_rank.ex_nvarchar1)))
                        Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_rank.ex_nvarchar1);
                    if (!(string.IsNullOrEmpty(gen_rank.ex_nvarchar2)))
                        Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_rank.ex_nvarchar2);
                    if (gen_rank.ex_bigint1.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_rank.ex_bigint1);
                    if (gen_rank.ex_bigint2.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_rank.ex_bigint2);
                    if (gen_rank.ex_decimal1.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_rank.ex_decimal1);
                    if (gen_rank.ex_decimal2.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_rank.ex_decimal2);

                    if (!string.IsNullOrEmpty(gen_rank.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_rank.strCommonSerachParam);

                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_rank.SortExpression);
                    AddPageSizeParameter(cmd, gen_rank.PageSize);
                    AddCurrentPageParameter(cmd, gen_rank.CurrentPage);
                    FillSequrityParameters(gen_rank.BaseSecurityParam, cmd, Database);


                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_rankEntity(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_rank.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;

                }

            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("ISelectTwoDataAccessObjects.GetPaged_Stp_OrganizationEntity"));
            }
            return itemList;
        }
        IList<gen_tradeEntity> ISelectTwoDataAccessObjects.GetPaged_Gen_Trade(gen_tradeEntity gen_trade)
        {
            IList<gen_tradeEntity> itemList = new List<gen_tradeEntity>();
            try
            {
                const string SP = "gen_trade_GAPgListView_SelectToExt";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    if (gen_trade.tradeid.HasValue)
                        Database.AddInParameter(cmd, "@TradeID", DbType.Int64, gen_trade.tradeid);
                    if (gen_trade.forceid.HasValue)
                        Database.AddInParameter(cmd, "@ForceID", DbType.Int64, gen_trade.forceid);
                    if (gen_trade.countryid.HasValue)
                        Database.AddInParameter(cmd, "@CountryID", DbType.Int64, gen_trade.countryid);
                    if (!(string.IsNullOrEmpty(gen_trade.tradename)))
                        Database.AddInParameter(cmd, "@TradeName", DbType.String, gen_trade.tradename);
                    if (!(string.IsNullOrEmpty(gen_trade.remarks)))
                        Database.AddInParameter(cmd, "@Remarks", DbType.String, gen_trade.remarks);
                    if ((gen_trade.ex_date1.HasValue))
                        Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, gen_trade.ex_date1);
                    if ((gen_trade.ex_date2.HasValue))
                        Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, gen_trade.ex_date2);
                    if (!(string.IsNullOrEmpty(gen_trade.ex_nvarchar1)))
                        Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, gen_trade.ex_nvarchar1);
                    if (!(string.IsNullOrEmpty(gen_trade.ex_nvarchar2)))
                        Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, gen_trade.ex_nvarchar2);
                    if (gen_trade.ex_bigint1.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, gen_trade.ex_bigint1);
                    if (gen_trade.ex_bigint2.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, gen_trade.ex_bigint2);
                    if (gen_trade.ex_decimal1.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, gen_trade.ex_decimal1);
                    if (gen_trade.ex_decimal2.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, gen_trade.ex_decimal2);

                    if (!string.IsNullOrEmpty(gen_trade.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, gen_trade.strCommonSerachParam);

                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, gen_trade.SortExpression);
                    AddPageSizeParameter(cmd, gen_trade.PageSize);
                    AddCurrentPageParameter(cmd, gen_trade.CurrentPage);
                    FillSequrityParameters(gen_trade.BaseSecurityParam, cmd, Database);


                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_tradeEntity(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        gen_trade.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;

                }

            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("ISelectTwoDataAccessObjects.GetPaged_Stp_OrganizationEntity"));
            }
            return itemList;
        }

        IList<gen_thanaEntity> ISelectTwoDataAccessObjects.GetPaged_Gen_Thana(gen_thanaEntity objEntity)
        {
            IList<gen_thanaEntity> itemList = new List<gen_thanaEntity>();
            try
            {
                const string SP = "gen_thana_GAPgListView_SelectToExt";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    if (objEntity.thanaid.HasValue)
                        Database.AddInParameter(cmd, "@ThanaID", DbType.Int64, objEntity.thanaid);
                    if (!(string.IsNullOrEmpty(objEntity.thananame)))
                        Database.AddInParameter(cmd, "@ThanaName", DbType.String, objEntity.thananame);
                    if (objEntity.districtid.HasValue)
                        Database.AddInParameter(cmd, "@DistrictID", DbType.Int64, objEntity.districtid);
                    if (!(string.IsNullOrEmpty(objEntity.remarks)))
                        Database.AddInParameter(cmd, "@Remarks", DbType.String, objEntity.remarks);
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

                    if (!string.IsNullOrEmpty(objEntity.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, objEntity.strCommonSerachParam);

                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, objEntity.SortExpression);
                    AddPageSizeParameter(cmd, objEntity.PageSize);
                    AddCurrentPageParameter(cmd, objEntity.CurrentPage);
                    FillSequrityParameters(objEntity.BaseSecurityParam, cmd, Database);


                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new gen_thanaEntity(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        objEntity.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;
                }

            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("ISelectTwoDataAccessObjects.GetPaged_Gen_Country"));
            }
        }

        IList<stp_organizationEntity> ISelectTwoDataAccessObjects.GetPaged_Stp_Organization(stp_organizationEntity stp_organization)
        {
            IList<stp_organizationEntity> itemList = new List<stp_organizationEntity>();
            try
            {
                const string SP = "stp_organization_GAPgListView_SelectToExt";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    if (stp_organization.organizationkey.HasValue)
                        Database.AddInParameter(cmd, "@OrganizationKey", DbType.Int64, stp_organization.organizationkey);
                   
                    if (!(string.IsNullOrEmpty(stp_organization.organizationnamear)))
                        Database.AddInParameter(cmd, "@OrganizationNameAr", DbType.String, stp_organization.organizationnamear);
                    if (!(string.IsNullOrEmpty(stp_organization.addresslineonear)))
                        Database.AddInParameter(cmd, "@AddressLineOneAr", DbType.String, stp_organization.addresslineonear);
                    if (!(string.IsNullOrEmpty(stp_organization.addresslinetwoar)))
                        Database.AddInParameter(cmd, "@AddressLineTwoAr", DbType.String, stp_organization.addresslinetwoar);
                    if (!(string.IsNullOrEmpty(stp_organization.phonear)))
                        Database.AddInParameter(cmd, "@PhoneAr", DbType.String, stp_organization.phonear);
                    if (!(string.IsNullOrEmpty(stp_organization.emailar)))
                        Database.AddInParameter(cmd, "@EmailAr", DbType.String, stp_organization.emailar);
                    if (!(string.IsNullOrEmpty(stp_organization.websitear)))
                        Database.AddInParameter(cmd, "@WebsiteAr", DbType.String, stp_organization.websitear);
                    if (!(string.IsNullOrEmpty(stp_organization.domainar)))
                        Database.AddInParameter(cmd, "@DomainAr", DbType.String, stp_organization.domainar);
                    if (!(string.IsNullOrEmpty(stp_organization.faxar)))
                        Database.AddInParameter(cmd, "@FaxAr", DbType.String, stp_organization.faxar);
                    if (!(string.IsNullOrEmpty(stp_organization.organizationname)))
                        Database.AddInParameter(cmd, "@OrganizationName", DbType.String, stp_organization.organizationname);
                    if (!(string.IsNullOrEmpty(stp_organization.addresslineone)))
                        Database.AddInParameter(cmd, "@AddressLineOne", DbType.String, stp_organization.addresslineone);
                    if (!(string.IsNullOrEmpty(stp_organization.addresslinetwo)))
                        Database.AddInParameter(cmd, "@AddressLineTwo", DbType.String, stp_organization.addresslinetwo);
                    if (!(string.IsNullOrEmpty(stp_organization.phone)))
                        Database.AddInParameter(cmd, "@Phone", DbType.String, stp_organization.phone);
                    if (!(string.IsNullOrEmpty(stp_organization.email)))
                        Database.AddInParameter(cmd, "@Email", DbType.String, stp_organization.email);
                    if (!(string.IsNullOrEmpty(stp_organization.website)))
                        Database.AddInParameter(cmd, "@Website", DbType.String, stp_organization.website);
                    if (!(string.IsNullOrEmpty(stp_organization.domain)))
                        Database.AddInParameter(cmd, "@Domain", DbType.String, stp_organization.domain);
                    if (!(string.IsNullOrEmpty(stp_organization.fax)))
                        Database.AddInParameter(cmd, "@Fax", DbType.String, stp_organization.fax);
                    if ((stp_organization.ismailenable != null))
                        Database.AddInParameter(cmd, "@IsMailEnable", DbType.Boolean, stp_organization.ismailenable);
                    if (!(string.IsNullOrEmpty(stp_organization.smtphost)))
                        Database.AddInParameter(cmd, "@smtpHost", DbType.String, stp_organization.smtphost);
                    if (stp_organization.mailport.HasValue)
                        Database.AddInParameter(cmd, "@mailPort", DbType.Int64, stp_organization.mailport);
                    if (!(string.IsNullOrEmpty(stp_organization.smtpusername)))
                        Database.AddInParameter(cmd, "@smtpUserName", DbType.String, stp_organization.smtpusername);
                    if (!(string.IsNullOrEmpty(stp_organization.smtppassword)))
                        Database.AddInParameter(cmd, "@smtpPassword", DbType.String, stp_organization.smtppassword);
                    if ((stp_organization.mailssl != null))
                        Database.AddInParameter(cmd, "@mailSSL", DbType.Boolean, stp_organization.mailssl);
                    if (!(string.IsNullOrEmpty(stp_organization.fromemailaddress)))
                        Database.AddInParameter(cmd, "@fromemailaddress", DbType.String, stp_organization.fromemailaddress);
                    if (!(string.IsNullOrEmpty(stp_organization.maildisplayname)))
                        Database.AddInParameter(cmd, "@maildisplayName", DbType.String, stp_organization.maildisplayname);
                    if ((stp_organization.isftpenable != null))
                        Database.AddInParameter(cmd, "@isFtpEnable", DbType.Boolean, stp_organization.isftpenable);
                    if (!(string.IsNullOrEmpty(stp_organization.ftpaddress)))
                        Database.AddInParameter(cmd, "@ftpAddress", DbType.String, stp_organization.ftpaddress);
                    if (!(string.IsNullOrEmpty(stp_organization.ftpport)))
                        Database.AddInParameter(cmd, "@ftpPort", DbType.String, stp_organization.ftpport);
                    if (!(string.IsNullOrEmpty(stp_organization.ftpusername)))
                        Database.AddInParameter(cmd, "@ftpUserName", DbType.String, stp_organization.ftpusername);
                    if (!(string.IsNullOrEmpty(stp_organization.ftppassword)))
                        Database.AddInParameter(cmd, "@ftpPassword", DbType.String, stp_organization.ftppassword);
                    if ((stp_organization.isssl != null))
                        Database.AddInParameter(cmd, "@IsSSL", DbType.Boolean, stp_organization.isssl);
                    if (!(string.IsNullOrEmpty(stp_organization.logoimg)))
                        Database.AddInParameter(cmd, "@LogoImg", DbType.String, stp_organization.logoimg);
                    if (!(string.IsNullOrEmpty(stp_organization.webheader)))
                        Database.AddInParameter(cmd, "@WebHeader", DbType.String, stp_organization.webheader);
                    if (!(string.IsNullOrEmpty(stp_organization.folderpath)))
                        Database.AddInParameter(cmd, "@FolderPath", DbType.String, stp_organization.folderpath);
                    if ((stp_organization.ex_date1.HasValue))
                        Database.AddInParameter(cmd, "@Ex_Date1", DbType.DateTime, stp_organization.ex_date1);
                    if ((stp_organization.ex_date2.HasValue))
                        Database.AddInParameter(cmd, "@Ex_Date2", DbType.DateTime, stp_organization.ex_date2);
                    if (!(string.IsNullOrEmpty(stp_organization.ex_nvarchar1)))
                        Database.AddInParameter(cmd, "@Ex_Nvarchar1", DbType.String, stp_organization.ex_nvarchar1);
                    if (!(string.IsNullOrEmpty(stp_organization.ex_nvarchar2)))
                        Database.AddInParameter(cmd, "@Ex_Nvarchar2", DbType.String, stp_organization.ex_nvarchar2);
                    if (stp_organization.ex_bigint1.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Bigint1", DbType.Int64, stp_organization.ex_bigint1);
                    if (stp_organization.ex_bigint2.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Bigint2", DbType.Int64, stp_organization.ex_bigint2);
                    if (stp_organization.ex_decimal1.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Decimal1", DbType.Decimal, stp_organization.ex_decimal1);
                    if (stp_organization.ex_decimal2.HasValue)
                        Database.AddInParameter(cmd, "@Ex_Decimal2", DbType.Decimal, stp_organization.ex_decimal2);

                    if (!string.IsNullOrEmpty(stp_organization.strCommonSerachParam))
                        Database.AddInParameter(cmd, "@CommonSerachParam", DbType.String, stp_organization.strCommonSerachParam);

                    AddTotalRecordParameter(cmd);
                    AddSortExpressionParameter(cmd, stp_organization.SortExpression);
                    AddPageSizeParameter(cmd, stp_organization.PageSize);
                    AddCurrentPageParameter(cmd, stp_organization.CurrentPage);
                    FillSequrityParameters(stp_organization.BaseSecurityParam, cmd, Database);


                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new stp_organizationEntity(reader));
                        }
                        reader.Close();
                    }

                    if (itemList.Count > 0)
                    {
                        itemList[0].RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                        stp_organization.RETURN_KEY = Convert.ToInt64(cmd.Parameters["@TotalRecord"].Value.ToString());
                    }
                    cmd.Dispose();
                    return itemList;

                }

            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("ISelectTwoDataAccessObjects.GetPaged_Stp_OrganizationEntity"));
            }
            return itemList;
        }


    }
}
