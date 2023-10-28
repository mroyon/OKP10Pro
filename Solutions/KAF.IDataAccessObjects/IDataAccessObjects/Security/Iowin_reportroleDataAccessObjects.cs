using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Iowin_reportroleDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(owin_reportroleEntity owin_reportrole);
		
		long Update(owin_reportroleEntity owin_reportrole);
        
		long Delete(owin_reportroleEntity owin_reportrole);
		
        long SaveList(IList<owin_reportroleEntity> listAdded, IList<owin_reportroleEntity> listUpdated, IList<owin_reportroleEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<owin_reportroleEntity> GetAll(owin_reportroleEntity owin_reportrole);
		
		IList<owin_reportroleEntity> GetAllByPages(owin_reportroleEntity owin_reportrole);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        long SaveMasterDetowin_reportpermission(owin_reportroleEntity masterEntity, IList<owin_reportpermissionEntity> listAdded, IList<owin_reportpermissionEntity> listUpdated, IList<owin_reportpermissionEntity> listDeleted);

        long SaveMasterDetowin_reportroletemplate(owin_reportroleEntity masterEntity, IList<owin_reportroletemplateEntity> listAdded, IList<owin_reportroletemplateEntity> listUpdated, IList<owin_reportroletemplateEntity> listDeleted);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         owin_reportroleEntity  GetSingle(owin_reportroleEntity owin_reportrole);
         #endregion 
         
         #region ForListView Paged Method
         IList<owin_reportroleEntity> GAPgListView(owin_reportroleEntity owin_reportrole);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
