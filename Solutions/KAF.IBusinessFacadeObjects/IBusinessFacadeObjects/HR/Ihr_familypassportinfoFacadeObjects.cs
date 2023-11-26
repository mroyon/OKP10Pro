

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_familypassportinfoFacadeObjects")]
    public partial interface Ihr_familypassportinfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_familypassportinfoEntity hr_familypassportinfo);
        
		[OperationContract]
		long Update(hr_familypassportinfoEntity hr_familypassportinfo);
		
		[OperationContract]
		long Delete(hr_familypassportinfoEntity hr_familypassportinfo );
        
        [OperationContract]
        long SaveList(List<hr_familypassportinfoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_familypassportinfoEntity> GetAll(hr_familypassportinfoEntity hr_familypassportinfo);
		
		[OperationContract]
        IList<hr_familypassportinfoEntity> GetAllByPages(hr_familypassportinfoEntity hr_familypassportinfo);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_familyresidentvisa(hr_familypassportinfoEntity Master, List<hr_familyresidentvisaEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_familypassportinfoEntity  GetSingle(hr_familypassportinfoEntity hr_familypassportinfo);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_familypassportinfoEntity> GAPgListView(hr_familypassportinfoEntity hr_familypassportinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
