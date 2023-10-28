

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_passportinfoFacadeObjects")]
    public partial interface Ihr_passportinfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_passportinfoEntity hr_passportinfo);
        
		[OperationContract]
		long Update(hr_passportinfoEntity hr_passportinfo);
		
		[OperationContract]
		long Delete(hr_passportinfoEntity hr_passportinfo );
        
        [OperationContract]
        long SaveList(List<hr_passportinfoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_passportinfoEntity> GetAll(hr_passportinfoEntity hr_passportinfo);
		
		[OperationContract]
        IList<hr_passportinfoEntity> GetAllByPages(hr_passportinfoEntity hr_passportinfo);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_residentvisa(hr_passportinfoEntity Master, List<hr_residentvisaEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_passportinfoEntity  GetSingle(hr_passportinfoEntity hr_passportinfo);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_passportinfoEntity> GAPgListView(hr_passportinfoEntity hr_passportinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
