

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_bankaccountinfoFacadeObjects")]
    public partial interface Ihr_bankaccountinfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_bankaccountinfoEntity hr_bankaccountinfo);
        
		[OperationContract]
		long Update(hr_bankaccountinfoEntity hr_bankaccountinfo);
		
		[OperationContract]
		long Delete(hr_bankaccountinfoEntity hr_bankaccountinfo );
        
        [OperationContract]
        long SaveList(List<hr_bankaccountinfoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_bankaccountinfoEntity> GetAll(hr_bankaccountinfoEntity hr_bankaccountinfo);
		
		[OperationContract]
        IList<hr_bankaccountinfoEntity> GetAllByPages(hr_bankaccountinfoEntity hr_bankaccountinfo);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_bankaccountinfoEntity  GetSingle(hr_bankaccountinfoEntity hr_bankaccountinfo);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_bankaccountinfoEntity> GAPgListView(hr_bankaccountinfoEntity hr_bankaccountinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
