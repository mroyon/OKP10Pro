using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Iowin_forminfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(owin_forminfoEntity owin_forminfo);
		
		long Update(owin_forminfoEntity owin_forminfo);
        
		long Delete(owin_forminfoEntity owin_forminfo);
		
        long SaveList(IList<owin_forminfoEntity> listAdded, IList<owin_forminfoEntity> listUpdated, IList<owin_forminfoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<owin_forminfoEntity> GetAll(owin_forminfoEntity owin_forminfo);
		
		IList<owin_forminfoEntity> GetAllByPages(owin_forminfoEntity owin_forminfo);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDetowin_formaction(owin_forminfoEntity masterEntity, IList<owin_formactionEntity> listAdded, IList<owin_formactionEntity> listUpdated, IList<owin_formactionEntity> listDeleted);

        long SaveMasterDetowin_lastworkingpage(owin_forminfoEntity masterEntity, IList<owin_lastworkingpageEntity> listAdded, IList<owin_lastworkingpageEntity> listUpdated, IList<owin_lastworkingpageEntity> listDeleted);

        long SaveMasterDetowin_rolepermission(owin_forminfoEntity masterEntity, IList<owin_rolepermissionEntity> listAdded, IList<owin_rolepermissionEntity> listUpdated, IList<owin_rolepermissionEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         owin_forminfoEntity  GetSingle(owin_forminfoEntity owin_forminfo);
         #endregion 
         
         #region ForListView Paged Method
         IList<owin_forminfoEntity> GAPgListView(owin_forminfoEntity owin_forminfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
