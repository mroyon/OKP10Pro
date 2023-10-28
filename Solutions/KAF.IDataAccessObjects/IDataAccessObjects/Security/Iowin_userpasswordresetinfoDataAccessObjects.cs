using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Iowin_userpasswordresetinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo);
		
		long Update(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo);
        
		long Delete(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo);
		
        long SaveList(IList<owin_userpasswordresetinfoEntity> listAdded, IList<owin_userpasswordresetinfoEntity> listUpdated, IList<owin_userpasswordresetinfoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<owin_userpasswordresetinfoEntity> GetAll(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo);
		
		IList<owin_userpasswordresetinfoEntity> GetAllByPages(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         owin_userpasswordresetinfoEntity  GetSingle(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo);
         #endregion 
         
         #region ForListView Paged Method
         IList<owin_userpasswordresetinfoEntity> GAPgListView(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
