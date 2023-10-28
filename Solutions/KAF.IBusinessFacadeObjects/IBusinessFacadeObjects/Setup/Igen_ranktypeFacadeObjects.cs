

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_ranktypeFacadeObjects")]
    public partial interface Igen_ranktypeFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_ranktypeEntity gen_ranktype);
        
		[OperationContract]
		long Update(gen_ranktypeEntity gen_ranktype);
		
		[OperationContract]
		long Delete(gen_ranktypeEntity gen_ranktype );
        
        [OperationContract]
        long SaveList(List<gen_ranktypeEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_ranktypeEntity> GetAll(gen_ranktypeEntity gen_ranktype);
		
		[OperationContract]
        IList<gen_ranktypeEntity> GetAllByPages(gen_ranktypeEntity gen_ranktype);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDetgen_rank(gen_ranktypeEntity Master, List<gen_rankEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_ranktypeEntity  GetSingle(gen_ranktypeEntity gen_ranktype);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_ranktypeEntity> GAPgListView(gen_ranktypeEntity gen_ranktype);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
