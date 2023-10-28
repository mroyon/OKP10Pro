using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;
using KAF.BusinessDataObjects;
using KAF.IDataAccessObjects;
using KAF.AppConfiguration.Configuration;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;



namespace KAF.DataAccessObjects
{
	/// <summary>
    /// Un touched: From Generator
    /// KAF Information Center
    /// </summary>
	
	internal sealed partial class hr_okptransferinfoDataAccessObjects 
	{
        //IList<KAFGenericComboEntity> Ihr_okptransferinfoDataAccessObjects.Add_WithFiles(hr_okptransferinfoEntity hr_okptransferinfo)
        //{
        //    List<KAFGenericComboEntity> returnArray = new List<KAFGenericComboEntity>();

        //    long retCode = -99;
        //    long folderid = -99;

        //    const string MasterSPInsert = "hr_okptransferinfo_Ins";

        //    DbConnection connection = Database.CreateConnection();
        //    connection.Open();
        //    DbTransaction transaction = connection.BeginTransaction();


        //    try
        //    {
        //        using (DbCommand cmd = Database.GetStoredProcCommand(MasterSPInsert))
        //        {
        //            FillParameters(hr_okptransferinfo, cmd, Database);
        //            FillSequrityParameters(hr_okptransferinfo.BaseSecurityParam, cmd, Database);
        //            AddOutputParameter(cmd);
        //            retCode = Database.ExecuteNonQuery(cmd, transaction);
        //            retCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
        //            cmd.Dispose();
        //        }

        //        if (retCode <= 0)
        //            throw new Exception("ERROR: @Military Service Save");
        //        else
        //        {
        //            returnArray.Add(new KAFGenericComboEntity()
        //            {
        //                comText = "okptransferid",
        //                comText2 = retCode.ToString(),
        //                comText3 = "Hr_OkpTransferInfo"
        //            });


        //            List<cor_foldercontentsEntity> objFileList = new List<cor_foldercontentsEntity>();
        //            objFileList = hr_okptransferinfo.cor_foldercontentsList;

        //            if (objFileList != null && objFileList.Count > 0)
        //            {
        //                cor_foldercontentsDataAccessObjects cor_foldercontentsDataAccessObjects = new cor_foldercontentsDataAccessObjects(this.Context);
        //                foreach (cor_foldercontentsEntity objFile in objFileList)
        //                {
        //                    objFile.BaseSecurityParam = new BusinessDataObjects.BusinessDataObjectsBase.SecurityCapsule();
        //                    objFile.BaseSecurityParam = hr_okptransferinfo.BaseSecurityParam;

        //                    objFile.foldercontentid = -99;
        //                    objFile.folderid = long.Parse(hr_okptransferinfo.strValue5);
        //                    objFile.columnpkid = long.Parse(returnArray.Where(p => p.comText3 == objFile.tablename).FirstOrDefault().comText2);
        //                    objFile.filepath = hr_okptransferinfo.strValue6 + "/Upload/";
        //                }

        //                retCode = cor_foldercontentsDataAccessObjects.SaveList(Database, transaction, objFileList, new List<cor_foldercontentsEntity>(), new List<cor_foldercontentsEntity>());
        //                if (retCode <= 0)
        //                    throw new Exception("ERROR: @FOLDER STRUCTURE Save");
        //                else
        //                    returnArray.Add(new KAFGenericComboEntity()
        //                    {
        //                        comText = "foldercontentid",
        //                        comText2 = retCode.ToString(),
        //                        comText3 = "COR_FolderContents"
        //                    });
        //            }
        //        }
        //        transaction.Commit();
        //    }
        //    catch (Exception ex)
        //    {
        //        transaction.Rollback();
        //        throw GetDataAccessException(ex, SourceOfException("Ihr_okptransferinfoDataAccess.Add_WithFiles"));
        //    }
        //    finally
        //    {
        //        transaction.Dispose();
        //        connection.Close();
        //        connection = null;
        //    }
        //    return returnArray;
        //}


        //IList<KAFGenericComboEntity> Ihr_okptransferinfoDataAccessObjects.Update_WithFiles(hr_okptransferinfoEntity hr_okptransferinfo)
        //{
        //    List<KAFGenericComboEntity> returnArray = new List<KAFGenericComboEntity>();

        //    long retCode = -99;
        //    long folderid = -99;

        //    const string MasterSPUpdate = "hr_okptransferinfo_Upd";


        //    DbConnection connection = Database.CreateConnection();
        //    connection.Open();
        //    DbTransaction transaction = connection.BeginTransaction();

        //    try
        //    {
        //        using (DbCommand cmd = Database.GetStoredProcCommand(MasterSPUpdate))
        //        {
        //            FillParameters(hr_okptransferinfo, cmd, Database);
        //            FillSequrityParameters(hr_okptransferinfo.BaseSecurityParam, cmd, Database);
        //            AddOutputParameter(cmd);
        //            retCode = Database.ExecuteNonQuery(cmd, transaction);
        //            retCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
        //            cmd.Dispose();
        //        }

        //        if (retCode <= 0)
        //            throw new Exception("ERROR: @Military Service Save");
        //        else
        //        {
        //            returnArray.Add(new KAFGenericComboEntity()
        //            {
        //                comText = "okptransferid",
        //                comText2 = retCode.ToString(),
        //                comText3 = "Hr_OkpTransferInfo"
        //            });

        //            cor_foldercontentsDataAccessObjects cor_foldercontentsDataAccessObjects = new cor_foldercontentsDataAccessObjects(this.Context);
        //            List<cor_foldercontentsEntity> objFileDeleteList = new List<cor_foldercontentsEntity>();
        //            List<cor_foldercontentsEntity> objFileAddList = new List<cor_foldercontentsEntity>();

        //            objFileDeleteList = hr_okptransferinfo.cor_foldercontentsList.Where(p => p.strValue1 == "deleted").ToList();
        //            objFileAddList = hr_okptransferinfo.cor_foldercontentsList.Where(p => p.strValue1 == "added").ToList();


        //            foreach (cor_foldercontentsEntity obj in objFileDeleteList)
        //            {
        //                cor_foldercontentsEntity objSingleFile = new cor_foldercontentsEntity();
        //                obj.BaseSecurityParam = new BusinessDataObjects.BusinessDataObjectsBase.SecurityCapsule();
        //                obj.BaseSecurityParam = hr_okptransferinfo.BaseSecurityParam;
        //                obj.CurrentState = BusinessDataObjects.BusinessDataObjectsBase.BaseEntity.EntityState.Deleted;
        //            }

        //            foreach (cor_foldercontentsEntity obj in objFileAddList)
        //            {
        //                cor_foldercontentsEntity objSingleFile = new cor_foldercontentsEntity();
        //                obj.BaseSecurityParam = new BusinessDataObjects.BusinessDataObjectsBase.SecurityCapsule();
        //                obj.BaseSecurityParam = hr_okptransferinfo.BaseSecurityParam;
        //                obj.folderid = long.Parse(hr_okptransferinfo.strValue5);
        //                obj.columnpkid = long.Parse(returnArray.Where(p => p.comText3 == obj.tablename).FirstOrDefault().comText2);
        //                obj.filepath = hr_okptransferinfo.strValue6 + "/Upload/";
        //                obj.CurrentState = BusinessDataObjects.BusinessDataObjectsBase.BaseEntity.EntityState.Added;
        //            }

        //            retCode = cor_foldercontentsDataAccessObjects.SaveList(Database, transaction, objFileAddList, new List<cor_foldercontentsEntity>(), objFileDeleteList);
        //            if (retCode <= 0)
        //                throw new Exception("ERROR: @FOLDER STRUCTURE UPDATE");
        //            else
        //                returnArray.Add(new KAFGenericComboEntity()
        //                {
        //                    comText = "foldercontentid",
        //                    comText2 = retCode.ToString(),
        //                    comText3 = "COR_FolderContents"
        //                });

        //        }
        //        transaction.Commit();
        //    }
        //    catch (Exception ex)
        //    {
        //        transaction.Rollback();
        //        throw GetDataAccessException(ex, SourceOfException("Ihr_okptransferinfoDataAccess.Update_WithFiles"));
        //    }
        //    finally
        //    {
        //        transaction.Dispose();
        //        connection.Close();
        //        connection = null;
        //    }
        //    return returnArray;
        //}


        //IList<KAFGenericComboEntity> Ihr_okptransferinfoDataAccessObjects.Delete_WithFiles(hr_okptransferinfoEntity hr_okptransferinfo)
        //{
        //    List<KAFGenericComboEntity> returnArray = new List<KAFGenericComboEntity>();

        //    long retCode = -99;
        //    long folderid = -99;

        //    const string MasterSPDelete = "hr_okptransferinfo_Del";


        //    DbConnection connection = Database.CreateConnection();
        //    connection.Open();
        //    DbTransaction transaction = connection.BeginTransaction();

        //    try
        //    {
        //        if (hr_okptransferinfo.cor_foldercontentsList != null && hr_okptransferinfo.cor_foldercontentsList.Count > 0)
        //        {
        //            cor_foldercontentsDataAccessObjects cor_foldercontentsDataAccessObjects = new cor_foldercontentsDataAccessObjects(this.Context);
        //            List<cor_foldercontentsEntity> objFileDeleteList = new List<cor_foldercontentsEntity>();
        //            objFileDeleteList = hr_okptransferinfo.cor_foldercontentsList;

        //            foreach (cor_foldercontentsEntity obj in objFileDeleteList)
        //            {
        //                cor_foldercontentsEntity objSingleFile = new cor_foldercontentsEntity();
        //                obj.BaseSecurityParam = new BusinessDataObjects.BusinessDataObjectsBase.SecurityCapsule();
        //                obj.BaseSecurityParam = hr_okptransferinfo.BaseSecurityParam;
        //                obj.CurrentState = BusinessDataObjects.BusinessDataObjectsBase.BaseEntity.EntityState.Deleted;
        //            }
        //            retCode = cor_foldercontentsDataAccessObjects.SaveList(Database, transaction, new List<cor_foldercontentsEntity>(), new List<cor_foldercontentsEntity>(), objFileDeleteList);
        //            if (retCode <= 0)
        //                throw new Exception("ERROR: @FOLDER STRUCTURE Save");
        //            else
        //                returnArray.Add(new KAFGenericComboEntity()
        //                {
        //                    comText = "foldercontentid",
        //                    comText2 = retCode.ToString(),
        //                    comText3 = "COR_FolderContents"
        //                });
        //        }

        //        hr_okptransferinfo.CurrentState = BusinessDataObjects.BusinessDataObjectsBase.BaseEntity.EntityState.Deleted;
        //        using (DbCommand cmd = Database.GetStoredProcCommand(MasterSPDelete))
        //        {
        //            FillParameters(hr_okptransferinfo, cmd, Database);
        //            FillSequrityParameters(hr_okptransferinfo.BaseSecurityParam, cmd, Database);
        //            AddOutputParameter(cmd);
        //            retCode = Database.ExecuteNonQuery(cmd, transaction);
        //            retCode = (Int64)(cmd.Parameters["@RETURN_KEY"].Value);
        //            cmd.Dispose();
        //        }

        //        if (retCode <= 0)
        //            throw new Exception("ERROR: @Military Service DELETE");
        //        else
        //        {
        //            returnArray.Add(new KAFGenericComboEntity()
        //            {
        //                 comText = "okptransferid",
        //                comText2 = retCode.ToString(),
        //                comText3 = "Hr_OkpTransferInfo"
        //            });

        //        }
        //        transaction.Commit();
        //    }
        //    catch (Exception ex)
        //    {
        //        transaction.Rollback();
        //        throw GetDataAccessException(ex, SourceOfException("Ihr_okptransferinfoDataAccess.Delete_WithFiles"));
        //    }
        //    finally
        //    {
        //        transaction.Dispose();
        //        connection.Close();
        //        connection = null;
        //    }
        //    return returnArray;
        //}


        //IList<hr_okptransferinfoEntity> Ihr_okptransferinfoDataAccessObjects.ViewSingle_WithFiles(hr_okptransferinfoEntity hr_okptransferinfo)
        //{
        //    List<hr_okptransferinfoEntity> returnArray = new List<hr_okptransferinfoEntity>();

        //    long retCode = -99;

        //    return returnArray;
        //}
        #region Add Operation

        long Ihr_okptransferinfoDataAccessObjects.Add_Ext(hr_okptransferinfoEntity hr_okptransferinfo)
        {
            long returnCode = -99;
            const string SP = "hr_okptransferinfo_Ins_Ext";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_okptransferinfo, cmd, Database);
                FillSequrityParameters(hr_okptransferinfo.BaseSecurityParam, cmd, Database);
                AddOutputParameter(cmd);
                try
                {
                    returnCode = Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_okptransferinfoDataAccess.Addhr_okptransferinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Add Operation

        #region Update Operation

        long Ihr_okptransferinfoDataAccessObjects.Update_Ext(hr_okptransferinfoEntity hr_okptransferinfo)
        {
            long returnCode = -99;
            const string SP = "hr_okptransferinfo_Upd_Ext";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                FillParameters(hr_okptransferinfo, cmd, Database);
                FillSequrityParameters(hr_okptransferinfo.BaseSecurityParam, cmd, Database);
                AddOutputParameter(cmd);
                try
                {
                    returnCode = Database.ExecuteNonQuery(cmd);
                }
                catch (Exception ex)
                {
                    throw GetDataAccessException(ex, SourceOfException("Ihr_okptransferinfoDataAccess.Updatehr_okptransferinfo"));
                }
                cmd.Dispose();
            }
            return returnCode;
        }

        #endregion Update Operation
    }
}