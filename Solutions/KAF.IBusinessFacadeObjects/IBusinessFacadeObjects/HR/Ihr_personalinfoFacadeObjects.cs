

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_personalinfoFacadeObjects")]
    public partial interface Ihr_personalinfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_personalinfoEntity hr_personalinfo);
        
		[OperationContract]
		long Update(hr_personalinfoEntity hr_personalinfo);
		
		[OperationContract]
		long Delete(hr_personalinfoEntity hr_personalinfo );
        
        [OperationContract]
        long SaveList(List<hr_personalinfoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_personalinfoEntity> GetAll(hr_personalinfoEntity hr_personalinfo);
		
		[OperationContract]
        IList<hr_personalinfoEntity> GetAllByPages(hr_personalinfoEntity hr_personalinfo);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_personalinfoEntity  GetSingle(hr_personalinfoEntity hr_personalinfo);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_personalinfoEntity> GAPgListView(hr_personalinfoEntity hr_personalinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
