using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Iowin_reportroletemplateDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(owin_reportroletemplateEntity owin_reportroletemplate);
		
		long Update(owin_reportroletemplateEntity owin_reportroletemplate);
        
		long Delete(owin_reportroletemplateEntity owin_reportroletemplate);
		
        long SaveList(IList<owin_reportroletemplateEntity> listAdded, IList<owin_reportroletemplateEntity> listUpdated, IList<owin_reportroletemplateEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<owin_reportroletemplateEntity> GetAll(owin_reportroletemplateEntity owin_reportroletemplate);
		
		IList<owin_reportroletemplateEntity> GetAllByPages(owin_reportroletemplateEntity owin_reportroletemplate);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         owin_reportroletemplateEntity  GetSingle(owin_reportroletemplateEntity owin_reportroletemplate);
         #endregion 
         
         #region ForListView Paged Method
         IList<owin_reportroletemplateEntity> GAPgListView(owin_reportroletemplateEntity owin_reportroletemplate);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
