

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_attachmentinfoFacadeObjects")]
    public partial interface Ihr_attachmentinfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_attachmentinfoEntity hr_attachmentinfo);
        
		[OperationContract]
		long Update(hr_attachmentinfoEntity hr_attachmentinfo);
		
		[OperationContract]
		long Delete(hr_attachmentinfoEntity hr_attachmentinfo );
        
        [OperationContract]
        long SaveList(List<hr_attachmentinfoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_attachmentinfoEntity> GetAll(hr_attachmentinfoEntity hr_attachmentinfo);
		
		[OperationContract]
        IList<hr_attachmentinfoEntity> GetAllByPages(hr_attachmentinfoEntity hr_attachmentinfo);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_attachmentinfoEntity  GetSingle(hr_attachmentinfoEntity hr_attachmentinfo);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_attachmentinfoEntity> GAPgListView(hr_attachmentinfoEntity hr_attachmentinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
