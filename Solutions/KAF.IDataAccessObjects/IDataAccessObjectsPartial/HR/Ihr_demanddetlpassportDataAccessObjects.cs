using System.Collections.Generic;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IDataAccessObjects
{
	public partial interface Ihr_demanddetlpassportDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
		long Add_Ext(hr_demanddetlpassportEntity hr_demanddetlpassport);
		
		long Update_Ext(hr_demanddetlpassportEntity hr_demanddetlpassport);
        
		long Delete_Ext(hr_demanddetlpassportEntity hr_demanddetlpassport);
		
        long SaveList_Ext(IList<hr_demanddetlpassportEntity> listAdded, IList<hr_demanddetlpassportEntity> listUpdated, IList<hr_demanddetlpassportEntity> listDeleted);               
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		
		IList<hr_demanddetlpassportEntity> GetAll_Ext(hr_demanddetlpassportEntity hr_demanddetlpassport);
		
		IList<hr_demanddetlpassportEntity> GetAllByPages_Ext(hr_demanddetlpassportEntity hr_demanddetlpassport);
		IList<hr_demanddetlpassportEntity> GetDemandPassportLetterNoByNewDemandID(hr_demanddetlpassportEntity hr_demanddetlpassport);

        #region ForListView Paged Method
        IList<hr_demanddetlpassportEntity> GAPgListView_Ext(hr_demanddetlpassportEntity hr_demanddetlpassport);
        #endregion

        #endregion GetAll

    }
}
