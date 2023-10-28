

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_visademandinfoFacadeObjects")]
    public partial interface Ihr_visademandinfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_visademandinfoEntity hr_visademandinfo);
        
		[OperationContract]
		long Update(hr_visademandinfoEntity hr_visademandinfo);
		
		[OperationContract]
		long Delete(hr_visademandinfoEntity hr_visademandinfo );
        
        [OperationContract]
        long SaveList(List<hr_visademandinfoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_visademandinfoEntity> GetAll(hr_visademandinfoEntity hr_visademandinfo);
		
		[OperationContract]
        IList<hr_visademandinfoEntity> GetAllByPages(hr_visademandinfoEntity hr_visademandinfo);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_visademandinfodetl(hr_visademandinfoEntity Master, List<hr_visademandinfodetlEntity> DetailList);

        [OperationContract]
        long SaveMasterDethr_visaissueinfo(hr_visademandinfoEntity Master, List<hr_visaissueinfoEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_visademandinfoEntity  GetSingle(hr_visademandinfoEntity hr_visademandinfo);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_visademandinfoEntity> GAPgListView(hr_visademandinfoEntity hr_visademandinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
