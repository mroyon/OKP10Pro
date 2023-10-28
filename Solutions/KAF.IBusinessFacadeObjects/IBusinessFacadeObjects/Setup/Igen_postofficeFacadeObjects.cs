

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_postofficeFacadeObjects")]
    public partial interface Igen_postofficeFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_postofficeEntity gen_postoffice);
        
		[OperationContract]
		long Update(gen_postofficeEntity gen_postoffice);
		
		[OperationContract]
		long Delete(gen_postofficeEntity gen_postoffice );
        
        [OperationContract]
        long SaveList(List<gen_postofficeEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_postofficeEntity> GetAll(gen_postofficeEntity gen_postoffice);
		
		[OperationContract]
        IList<gen_postofficeEntity> GetAllByPages(gen_postofficeEntity gen_postoffice);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_emergencycontact(gen_postofficeEntity Master, List<hr_emergencycontactEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_postofficeEntity  GetSingle(gen_postofficeEntity gen_postoffice);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_postofficeEntity> GAPgListView(gen_postofficeEntity gen_postoffice);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
