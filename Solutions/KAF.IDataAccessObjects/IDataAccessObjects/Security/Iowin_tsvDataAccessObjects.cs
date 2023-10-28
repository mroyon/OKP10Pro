using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Iowin_tsvDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(owin_tsvEntity owin_tsv);
		
		long Update(owin_tsvEntity owin_tsv);
        
		long Delete(owin_tsvEntity owin_tsv);
		
        long SaveList(IList<owin_tsvEntity> listAdded, IList<owin_tsvEntity> listUpdated, IList<owin_tsvEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<owin_tsvEntity> GetAll(owin_tsvEntity owin_tsv);
		
		IList<owin_tsvEntity> GetAllByPages(owin_tsvEntity owin_tsv);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         owin_tsvEntity  GetSingle(owin_tsvEntity owin_tsv);
         #endregion 
         
         #region ForListView Paged Method
         IList<owin_tsvEntity> GAPgListView(owin_tsvEntity owin_tsv);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
