

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Iowin_formactionFacadeObjects")]
    public partial interface Iowin_formactionFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(owin_formactionEntity owin_formaction);
        
		[OperationContract]
		long Update(owin_formactionEntity owin_formaction);
		
		[OperationContract]
		long Delete(owin_formactionEntity owin_formaction );
        
        [OperationContract]
        long SaveList(List<owin_formactionEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<owin_formactionEntity> GetAll(owin_formactionEntity owin_formaction);
		
		[OperationContract]
        IList<owin_formactionEntity> GetAllByPages(owin_formactionEntity owin_formaction);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDetowin_rolepermission(owin_formactionEntity Master, List<owin_rolepermissionEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        owin_formactionEntity  GetSingle(owin_formactionEntity owin_formaction);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<owin_formactionEntity> GAPgListView(owin_formactionEntity owin_formaction);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
