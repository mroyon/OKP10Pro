

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_languageproficiencyFacadeObjects")]
    public partial interface Ihr_languageproficiencyFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_languageproficiencyEntity hr_languageproficiency);
        
		[OperationContract]
		long Update(hr_languageproficiencyEntity hr_languageproficiency);
		
		[OperationContract]
		long Delete(hr_languageproficiencyEntity hr_languageproficiency );
        
        [OperationContract]
        long SaveList(List<hr_languageproficiencyEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_languageproficiencyEntity> GetAll(hr_languageproficiencyEntity hr_languageproficiency);
		
		[OperationContract]
        IList<hr_languageproficiencyEntity> GetAllByPages(hr_languageproficiencyEntity hr_languageproficiency);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_languageproficiencyEntity  GetSingle(hr_languageproficiencyEntity hr_languageproficiency);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_languageproficiencyEntity> GAPgListView(hr_languageproficiencyEntity hr_languageproficiency);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
