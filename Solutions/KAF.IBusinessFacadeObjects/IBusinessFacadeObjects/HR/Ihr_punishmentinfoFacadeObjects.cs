

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_punishmentinfoFacadeObjects")]
    public partial interface Ihr_punishmentinfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_punishmentinfoEntity hr_punishmentinfo);
        
		[OperationContract]
		long Update(hr_punishmentinfoEntity hr_punishmentinfo);
		
		[OperationContract]
		long Delete(hr_punishmentinfoEntity hr_punishmentinfo );
        
        [OperationContract]
        long SaveList(List<hr_punishmentinfoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_punishmentinfoEntity> GetAll(hr_punishmentinfoEntity hr_punishmentinfo);
		
		[OperationContract]
        IList<hr_punishmentinfoEntity> GetAllByPages(hr_punishmentinfoEntity hr_punishmentinfo);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_punishmentinfoEntity  GetSingle(hr_punishmentinfoEntity hr_punishmentinfo);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_punishmentinfoEntity> GAPgListView(hr_punishmentinfoEntity hr_punishmentinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
