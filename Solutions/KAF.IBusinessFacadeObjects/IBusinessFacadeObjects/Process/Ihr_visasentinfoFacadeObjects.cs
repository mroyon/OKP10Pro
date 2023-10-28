

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_visasentinfoFacadeObjects")]
    public partial interface Ihr_visasentinfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_visasentinfoEntity hr_visasentinfo);
        
		[OperationContract]
		long Update(hr_visasentinfoEntity hr_visasentinfo);
		
		[OperationContract]
		long Delete(hr_visasentinfoEntity hr_visasentinfo );
        
        [OperationContract]
        long SaveList(List<hr_visasentinfoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_visasentinfoEntity> GetAll(hr_visasentinfoEntity hr_visasentinfo);
		
		[OperationContract]
        IList<hr_visasentinfoEntity> GetAllByPages(hr_visasentinfoEntity hr_visasentinfo);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_ptademand(hr_visasentinfoEntity Master, List<hr_ptademandEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_visasentinfodetl(hr_visasentinfoEntity Master, List<hr_visasentinfodetlEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_visasentinfoEntity  GetSingle(hr_visasentinfoEntity hr_visasentinfo);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_visasentinfoEntity> GAPgListView(hr_visasentinfoEntity hr_visasentinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
