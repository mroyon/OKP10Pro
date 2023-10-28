

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_documentuploadFacadeObjects")]
    public partial interface Ihr_documentuploadFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_documentuploadEntity hr_documentupload);
        
		[OperationContract]
		long Update(hr_documentuploadEntity hr_documentupload);
		
		[OperationContract]
		long Delete(hr_documentuploadEntity hr_documentupload );
        
        [OperationContract]
        long SaveList(List<hr_documentuploadEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_documentuploadEntity> GetAll(hr_documentuploadEntity hr_documentupload);
		
		[OperationContract]
        IList<hr_documentuploadEntity> GetAllByPages(hr_documentuploadEntity hr_documentupload);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_documentuploadEntity  GetSingle(hr_documentuploadEntity hr_documentupload);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_documentuploadEntity> GAPgListView(hr_documentuploadEntity hr_documentupload);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
