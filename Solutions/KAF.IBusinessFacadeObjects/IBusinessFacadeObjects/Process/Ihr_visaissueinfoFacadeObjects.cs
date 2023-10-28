

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_visaissueinfoFacadeObjects")]
    public partial interface Ihr_visaissueinfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_visaissueinfoEntity hr_visaissueinfo);
        
		[OperationContract]
		long Update(hr_visaissueinfoEntity hr_visaissueinfo);
		
		[OperationContract]
		long Delete(hr_visaissueinfoEntity hr_visaissueinfo );
        
        [OperationContract]
        long SaveList(List<hr_visaissueinfoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_visaissueinfoEntity> GetAll(hr_visaissueinfoEntity hr_visaissueinfo);
		
		[OperationContract]
        IList<hr_visaissueinfoEntity> GetAllByPages(hr_visaissueinfoEntity hr_visaissueinfo);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_visaissueinfodetl(hr_visaissueinfoEntity Master, List<hr_visaissueinfodetlEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_visasentinfo(hr_visaissueinfoEntity Master, List<hr_visasentinfoEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_visaissueinfoEntity  GetSingle(hr_visaissueinfoEntity hr_visaissueinfo);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_visaissueinfoEntity> GAPgListView(hr_visaissueinfoEntity hr_visaissueinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
