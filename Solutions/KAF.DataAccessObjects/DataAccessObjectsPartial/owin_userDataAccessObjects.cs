using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;
using KAF.DataAccessObjects;
using KAF.BusinessDataObjects;
using KAF.IDataAccessObjects;
using KAF.AppConfiguration.Configuration;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;


namespace KAF.DataAccessObjects
{
	/// <summary>
    /// Un touched: From Generator
    /// Maxima Prince
    /// </summary>
	
	internal sealed partial class owin_userDataAccessObjects 
	{
		
	   
		#region GetAll

        IList<owin_userEntity> Iowin_userDataAccessObjects.SearchUser(owin_userEntity owin_user)
        {
           try
            {
				const string SP = "KAF_User_Search";
				using (DbCommand cmd = Database.GetStoredProcCommand(SP))
				{
					
					AddSortExpressionParameter(cmd, owin_user.SortExpression);
                    FillSequrityParameters(owin_user.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_user, cmd, Database);
                    
                    IList<owin_userEntity> itemList = new List<owin_userEntity>();
					using (IDataReader reader = Database.ExecuteReader(cmd))
					{
                        while (reader.Read())
                        {
                            itemList.Add(new owin_userEntity(reader));
                        }
                        reader.Close();
					}
                    cmd.Dispose();
                    return itemList;
				}
			}
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_userDataAccess.GetAllowin_user"));
            }	
        }

        #endregion


    }
}