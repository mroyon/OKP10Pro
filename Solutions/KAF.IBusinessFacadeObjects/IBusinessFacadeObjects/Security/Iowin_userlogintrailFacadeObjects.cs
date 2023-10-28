

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Iowin_userlogintrailFacadeObjects")]
    public partial interface Iowin_userlogintrailFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(owin_userlogintrailEntity owin_userlogintrail);
        
		[OperationContract]
		long Update(owin_userlogintrailEntity owin_userlogintrail);
		
		[OperationContract]
		long Delete(owin_userlogintrailEntity owin_userlogintrail );
        
        [OperationContract]
        long SaveList(List<owin_userlogintrailEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<owin_userlogintrailEntity> GetAll(owin_userlogintrailEntity owin_userlogintrail);
		
		[OperationContract]
        IList<owin_userlogintrailEntity> GetAllByPages(owin_userlogintrailEntity owin_userlogintrail);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        owin_userlogintrailEntity  GetSingle(owin_userlogintrailEntity owin_userlogintrail);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<owin_userlogintrailEntity> GAPgListView(owin_userlogintrailEntity owin_userlogintrail);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
