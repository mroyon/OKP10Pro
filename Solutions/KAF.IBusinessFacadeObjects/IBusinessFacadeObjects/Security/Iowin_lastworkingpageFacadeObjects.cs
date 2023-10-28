

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Iowin_lastworkingpageFacadeObjects")]
    public partial interface Iowin_lastworkingpageFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(owin_lastworkingpageEntity owin_lastworkingpage);
        
		[OperationContract]
		long Update(owin_lastworkingpageEntity owin_lastworkingpage);
		
		[OperationContract]
		long Delete(owin_lastworkingpageEntity owin_lastworkingpage );
        
        [OperationContract]
        long SaveList(List<owin_lastworkingpageEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<owin_lastworkingpageEntity> GetAll(owin_lastworkingpageEntity owin_lastworkingpage);
		
		[OperationContract]
        IList<owin_lastworkingpageEntity> GetAllByPages(owin_lastworkingpageEntity owin_lastworkingpage);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        owin_lastworkingpageEntity  GetSingle(owin_lastworkingpageEntity owin_lastworkingpage);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<owin_lastworkingpageEntity> GAPgListView(owin_lastworkingpageEntity owin_lastworkingpage);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
