

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_deathinfoFacadeObjects")]
    public partial interface Ihr_deathinfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_deathinfoEntity hr_deathinfo);
        
		[OperationContract]
		long Update(hr_deathinfoEntity hr_deathinfo);
		
		[OperationContract]
		long Delete(hr_deathinfoEntity hr_deathinfo );
        
        [OperationContract]
        long SaveList(List<hr_deathinfoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_deathinfoEntity> GetAll(hr_deathinfoEntity hr_deathinfo);
		
		[OperationContract]
        IList<hr_deathinfoEntity> GetAllByPages(hr_deathinfoEntity hr_deathinfo);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_deathinfoEntity  GetSingle(hr_deathinfoEntity hr_deathinfo);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_deathinfoEntity> GAPgListView(hr_deathinfoEntity hr_deathinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
