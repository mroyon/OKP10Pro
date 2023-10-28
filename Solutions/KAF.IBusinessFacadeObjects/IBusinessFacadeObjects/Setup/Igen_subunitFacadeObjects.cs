

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_subunitFacadeObjects")]
    public partial interface Igen_subunitFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_subunitEntity gen_subunit);
        
		[OperationContract]
		long Update(gen_subunitEntity gen_subunit);
		
		[OperationContract]
		long Delete(gen_subunitEntity gen_subunit );
        
        [OperationContract]
        long SaveList(List<gen_subunitEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_subunitEntity> GetAll(gen_subunitEntity gen_subunit);
		
		[OperationContract]
        IList<gen_subunitEntity> GetAllByPages(gen_subunitEntity gen_subunit);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        //[OperationContract]
        //long SaveMasterDethr_attachmentinfo(gen_subunitEntity Master, List<hr_attachmentinfoEntity> DetailList);

        //[OperationContract]
        //long SaveMasterDethr_okptransferinfo(gen_subunitEntity Master, List<hr_okptransferinfoEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_subunitEntity  GetSingle(gen_subunitEntity gen_subunit);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_subunitEntity> GAPgListView(gen_subunitEntity gen_subunit);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
