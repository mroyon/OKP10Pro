using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Iowin_formactionDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(owin_formactionEntity owin_formaction);
		
		long Update(owin_formactionEntity owin_formaction);
        
		long Delete(owin_formactionEntity owin_formaction);
		
        long SaveList(IList<owin_formactionEntity> listAdded, IList<owin_formactionEntity> listUpdated, IList<owin_formactionEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<owin_formactionEntity> GetAll(owin_formactionEntity owin_formaction);
		
		IList<owin_formactionEntity> GetAllByPages(owin_formactionEntity owin_formaction);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDetowin_rolepermission(owin_formactionEntity masterEntity, IList<owin_rolepermissionEntity> listAdded, IList<owin_rolepermissionEntity> listUpdated, IList<owin_rolepermissionEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         owin_formactionEntity  GetSingle(owin_formactionEntity owin_formaction);
         #endregion 
         
         #region ForListView Paged Method
         IList<owin_formactionEntity> GAPgListView(owin_formactionEntity owin_formaction);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
