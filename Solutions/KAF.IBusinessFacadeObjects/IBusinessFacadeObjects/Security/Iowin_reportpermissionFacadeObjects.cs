

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Iowin_reportpermissionFacadeObjects")]
    public partial interface Iowin_reportpermissionFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(owin_reportpermissionEntity owin_reportpermission);
        
		[OperationContract]
		long Update(owin_reportpermissionEntity owin_reportpermission);
		
		[OperationContract]
		long Delete(owin_reportpermissionEntity owin_reportpermission );
        
        [OperationContract]
        long SaveList(List<owin_reportpermissionEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<owin_reportpermissionEntity> GetAll(owin_reportpermissionEntity owin_reportpermission);
		
		[OperationContract]
        IList<owin_reportpermissionEntity> GetAllByPages(owin_reportpermissionEntity owin_reportpermission);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        owin_reportpermissionEntity  GetSingle(owin_reportpermissionEntity owin_reportpermission);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<owin_reportpermissionEntity> GAPgListView(owin_reportpermissionEntity owin_reportpermission);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
