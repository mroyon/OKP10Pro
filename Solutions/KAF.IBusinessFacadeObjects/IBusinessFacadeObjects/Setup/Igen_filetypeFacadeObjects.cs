

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Igen_filetypeFacadeObjects")]
    public partial interface Igen_filetypeFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(gen_filetypeEntity gen_filetype);
        
		[OperationContract]
		long Update(gen_filetypeEntity gen_filetype);
		
		[OperationContract]
		long Delete(gen_filetypeEntity gen_filetype );
        
        [OperationContract]
        long SaveList(List<gen_filetypeEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<gen_filetypeEntity> GetAll(gen_filetypeEntity gen_filetype);
		
		[OperationContract]
        IList<gen_filetypeEntity> GetAllByPages(gen_filetypeEntity gen_filetype);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDethr_basicfile(gen_filetypeEntity Master, List<hr_basicfileEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        gen_filetypeEntity  GetSingle(gen_filetypeEntity gen_filetype);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<gen_filetypeEntity> GAPgListView(gen_filetypeEntity gen_filetype);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
