using KAF.BusinessDataObjects;
using KAF.IDataAccessObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAF.DataAccessObjects
{
    internal sealed partial class owin_rolepermissionDataAccessObjects : BaseDataAccess, Iowin_rolepermissionDataAccessObjects
    {
        IList<owin_rolepermissionEntity> Iowin_rolepermissionDataAccessObjects.GetAll_Ext(owin_rolepermissionEntity owin_rolepermission)
        {
            try
            {
                const string SP = "owin_rolepermission_GA_Ext";
                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {

                    AddSortExpressionParameter(cmd, owin_rolepermission.SortExpression);
                    FillSequrityParameters(owin_rolepermission.BaseSecurityParam, cmd, Database);
                    FillParameters(owin_rolepermission, cmd, Database);

                    IList<owin_rolepermissionEntity> itemList = new List<owin_rolepermissionEntity>();
                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        while (reader.Read())
                        {
                            itemList.Add(new owin_rolepermissionEntity(reader));
                        }
                        reader.Close();
                    }
                    cmd.Dispose();
                    return itemList;
                }
            }
            catch (Exception ex)
            {
                throw GetDataAccessException(ex, SourceOfException("Iowin_rolepermissionDataAccess.GetAllowin_rolepermission"));
            }
        }
    }
}
