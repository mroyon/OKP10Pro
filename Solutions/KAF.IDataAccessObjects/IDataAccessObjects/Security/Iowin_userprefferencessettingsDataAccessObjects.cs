using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Iowin_userprefferencessettingsDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(owin_userprefferencessettingsEntity owin_userprefferencessettings);
		
		long Update(owin_userprefferencessettingsEntity owin_userprefferencessettings);
        
		long Delete(owin_userprefferencessettingsEntity owin_userprefferencessettings);
		
        long SaveList(IList<owin_userprefferencessettingsEntity> listAdded, IList<owin_userprefferencessettingsEntity> listUpdated, IList<owin_userprefferencessettingsEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<owin_userprefferencessettingsEntity> GetAll(owin_userprefferencessettingsEntity owin_userprefferencessettings);
		
		IList<owin_userprefferencessettingsEntity> GetAllByPages(owin_userprefferencessettingsEntity owin_userprefferencessettings);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         owin_userprefferencessettingsEntity  GetSingle(owin_userprefferencessettingsEntity owin_userprefferencessettings);
         #endregion 
         
         #region ForListView Paged Method
         IList<owin_userprefferencessettingsEntity> GAPgListView(owin_userprefferencessettingsEntity owin_userprefferencessettings);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
