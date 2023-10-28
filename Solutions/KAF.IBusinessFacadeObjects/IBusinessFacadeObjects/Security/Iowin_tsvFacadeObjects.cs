

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Iowin_tsvFacadeObjects")]
    public partial interface Iowin_tsvFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(owin_tsvEntity owin_tsv);
        
		[OperationContract]
		long Update(owin_tsvEntity owin_tsv);
		
		[OperationContract]
		long Delete(owin_tsvEntity owin_tsv );
        
        [OperationContract]
        long SaveList(List<owin_tsvEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<owin_tsvEntity> GetAll(owin_tsvEntity owin_tsv);
		
		[OperationContract]
        IList<owin_tsvEntity> GetAllByPages(owin_tsvEntity owin_tsv);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        owin_tsvEntity  GetSingle(owin_tsvEntity owin_tsv);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<owin_tsvEntity> GAPgListView(owin_tsvEntity owin_tsv);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
