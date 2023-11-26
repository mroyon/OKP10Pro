using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_familycivilidinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add(hr_familycivilidinfoEntity hr_familycivilidinfo);
		
		long Update(hr_familycivilidinfoEntity hr_familycivilidinfo);
        
		long Delete(hr_familycivilidinfoEntity hr_familycivilidinfo);
		
        long SaveList(IList<hr_familycivilidinfoEntity> listAdded, IList<hr_familycivilidinfoEntity> listUpdated, IList<hr_familycivilidinfoEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_familycivilidinfoEntity> GetAll(hr_familycivilidinfoEntity hr_familycivilidinfo);
		
		IList<hr_familycivilidinfoEntity> GetAllByPages(hr_familycivilidinfoEntity hr_familycivilidinfo);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         hr_familycivilidinfoEntity  GetSingle(hr_familycivilidinfoEntity hr_familycivilidinfo);
         #endregion 
         
         #region ForListView Paged Method
         IList<hr_familycivilidinfoEntity> GAPgListView(hr_familycivilidinfoEntity hr_familycivilidinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
