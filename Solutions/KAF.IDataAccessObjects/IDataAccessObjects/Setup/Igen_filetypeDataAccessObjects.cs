using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Igen_filetypeDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(gen_filetypeEntity gen_filetype);
		
		long Update(gen_filetypeEntity gen_filetype);
        
		long Delete(gen_filetypeEntity gen_filetype);
		
        long SaveList(IList<gen_filetypeEntity> listAdded, IList<gen_filetypeEntity> listUpdated, IList<gen_filetypeEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<gen_filetypeEntity> GetAll(gen_filetypeEntity gen_filetype);
		
		IList<gen_filetypeEntity> GetAllByPages(gen_filetypeEntity gen_filetype);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDethr_basicfile(gen_filetypeEntity masterEntity, IList<hr_basicfileEntity> listAdded, IList<hr_basicfileEntity> listUpdated, IList<hr_basicfileEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         gen_filetypeEntity  GetSingle(gen_filetypeEntity gen_filetype);
         #endregion 
         
         #region ForListView Paged Method
         IList<gen_filetypeEntity> GAPgListView(gen_filetypeEntity gen_filetype);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
