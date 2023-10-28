

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_languageproficiencyFacadeObjects")]
    public partial interface Igen_languageproficiencyFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_languageproficiencyEntity gen_languageproficiency);
        
		[OperationContract]
		long Update(gen_languageproficiencyEntity gen_languageproficiency);
		
		[OperationContract]
		long Delete(gen_languageproficiencyEntity gen_languageproficiency );
        
        [OperationContract]
        long SaveList(List<gen_languageproficiencyEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_languageproficiencyEntity> GetAll(gen_languageproficiencyEntity gen_languageproficiency);
		
		[OperationContract]
        IList<gen_languageproficiencyEntity> GetAllByPages(gen_languageproficiencyEntity gen_languageproficiency);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_languageproficiency(gen_languageproficiencyEntity Master, List<hr_languageproficiencyEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_languageproficiencyEntity  GetSingle(gen_languageproficiencyEntity gen_languageproficiency);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_languageproficiencyEntity> GAPgListView(gen_languageproficiencyEntity gen_languageproficiency);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
