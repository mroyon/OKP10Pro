

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_languageFacadeObjects")]
    public partial interface Igen_languageFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_languageEntity gen_language);
        
		[OperationContract]
		long Update(gen_languageEntity gen_language);
		
		[OperationContract]
		long Delete(gen_languageEntity gen_language );
        
        [OperationContract]
        long SaveList(List<gen_languageEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_languageEntity> GetAll(gen_languageEntity gen_language);
		
		[OperationContract]
        IList<gen_languageEntity> GetAllByPages(gen_languageEntity gen_language);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_languageproficiency(gen_languageEntity Master, List<hr_languageproficiencyEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_languageEntity  GetSingle(gen_languageEntity gen_language);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_languageEntity> GAPgListView(gen_languageEntity gen_language);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
