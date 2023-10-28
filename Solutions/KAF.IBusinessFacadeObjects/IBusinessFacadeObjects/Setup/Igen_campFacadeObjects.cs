

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_campFacadeObjects")]
    public partial interface Igen_campFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_campEntity gen_camp);
        
		[OperationContract]
		long Update(gen_campEntity gen_camp);
		
		[OperationContract]
		long Delete(gen_campEntity gen_camp );
        
        [OperationContract]
        long SaveList(List<gen_campEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_campEntity> GetAll(gen_campEntity gen_camp);
		
		[OperationContract]
        IList<gen_campEntity> GetAllByPages(gen_campEntity gen_camp);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        //[OperationContract]
        //long SaveMasterDethr_attachmentinfo(gen_campEntity Master, List<hr_attachmentinfoEntity> DetailList);

        //[OperationContract]
        //long SaveMasterDethr_okptransferinfo(gen_campEntity Master, List<hr_okptransferinfoEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_campEntity  GetSingle(gen_campEntity gen_camp);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_campEntity> GAPgListView(gen_campEntity gen_camp);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
