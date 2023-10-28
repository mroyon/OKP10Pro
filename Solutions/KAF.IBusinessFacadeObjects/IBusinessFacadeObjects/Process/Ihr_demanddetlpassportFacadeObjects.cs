

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_demanddetlpassportFacadeObjects")]
    public partial interface Ihr_demanddetlpassportFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_demanddetlpassportEntity hr_demanddetlpassport);
        
		[OperationContract]
		long Update(hr_demanddetlpassportEntity hr_demanddetlpassport);
		
		[OperationContract]
		long Delete(hr_demanddetlpassportEntity hr_demanddetlpassport );
        
        [OperationContract]
        long SaveList(List<hr_demanddetlpassportEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_demanddetlpassportEntity> GetAll(hr_demanddetlpassportEntity hr_demanddetlpassport);
		
		[OperationContract]
        IList<hr_demanddetlpassportEntity> GetAllByPages(hr_demanddetlpassportEntity hr_demanddetlpassport);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_demanddetlpassportEntity  GetSingle(hr_demanddetlpassportEntity hr_demanddetlpassport);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_demanddetlpassportEntity> GAPgListView(hr_demanddetlpassportEntity hr_demanddetlpassport);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
