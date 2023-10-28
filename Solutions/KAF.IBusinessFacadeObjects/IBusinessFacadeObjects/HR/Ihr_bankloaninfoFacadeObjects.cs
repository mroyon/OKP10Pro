

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_bankloaninfoFacadeObjects")]
    public partial interface Ihr_bankloaninfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_bankloaninfoEntity hr_bankloaninfo);
        
		[OperationContract]
		long Update(hr_bankloaninfoEntity hr_bankloaninfo);
		
		[OperationContract]
		long Delete(hr_bankloaninfoEntity hr_bankloaninfo );
        
        [OperationContract]
        long SaveList(List<hr_bankloaninfoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_bankloaninfoEntity> GetAll(hr_bankloaninfoEntity hr_bankloaninfo);
		
		[OperationContract]
        IList<hr_bankloaninfoEntity> GetAllByPages(hr_bankloaninfoEntity hr_bankloaninfo);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_bankloaninfoEntity  GetSingle(hr_bankloaninfoEntity hr_bankloaninfo);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_bankloaninfoEntity> GAPgListView(hr_bankloaninfoEntity hr_bankloaninfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
