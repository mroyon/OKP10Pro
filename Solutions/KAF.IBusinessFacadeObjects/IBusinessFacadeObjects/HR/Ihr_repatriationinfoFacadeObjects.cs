

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_repatriationinfoFacadeObjects")]
    public partial interface Ihr_repatriationinfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_repatriationinfoEntity hr_repatriationinfo);
        
		[OperationContract]
		long Update(hr_repatriationinfoEntity hr_repatriationinfo);
		
		[OperationContract]
		long Delete(hr_repatriationinfoEntity hr_repatriationinfo );
        
        [OperationContract]
        long SaveList(List<hr_repatriationinfoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_repatriationinfoEntity> GetAll(hr_repatriationinfoEntity hr_repatriationinfo);
		
		[OperationContract]
        IList<hr_repatriationinfoEntity> GetAllByPages(hr_repatriationinfoEntity hr_repatriationinfo);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_repatriationinfoEntity  GetSingle(hr_repatriationinfoEntity hr_repatriationinfo);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_repatriationinfoEntity> GAPgListView(hr_repatriationinfoEntity hr_repatriationinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
