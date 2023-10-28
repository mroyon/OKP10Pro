

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_okpFacadeObjects")]
    public partial interface Igen_okpFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_okpEntity gen_okp);
        
		[OperationContract]
		long Update(gen_okpEntity gen_okp);
		
		[OperationContract]
		long Delete(gen_okpEntity gen_okp );
        
        [OperationContract]
        long SaveList(List<gen_okpEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_okpEntity> GetAll(gen_okpEntity gen_okp);
		
		[OperationContract]
        IList<gen_okpEntity> GetAllByPages(gen_okpEntity gen_okp);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDetgen_okpco(gen_okpEntity Master, List<gen_okpcoEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_newdemanddetl(gen_okpEntity Master, List<hr_newdemanddetlEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_svcinfo(gen_okpEntity Master, List<hr_svcinfoEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_okpEntity  GetSingle(gen_okpEntity gen_okp);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_okpEntity> GAPgListView(gen_okpEntity gen_okp);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
