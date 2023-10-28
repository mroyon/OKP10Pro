

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Iowin_rolepermissionFacadeObjects")]
    public partial interface Iowin_rolepermissionFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(owin_rolepermissionEntity owin_rolepermission);
        
		[OperationContract]
		long Update(owin_rolepermissionEntity owin_rolepermission);
		
		[OperationContract]
		long Delete(owin_rolepermissionEntity owin_rolepermission );
        
        [OperationContract]
        long SaveList(List<owin_rolepermissionEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<owin_rolepermissionEntity> GetAll(owin_rolepermissionEntity owin_rolepermission);
		
		[OperationContract]
        IList<owin_rolepermissionEntity> GetAllByPages(owin_rolepermissionEntity owin_rolepermission);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        owin_rolepermissionEntity  GetSingle(owin_rolepermissionEntity owin_rolepermission);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<owin_rolepermissionEntity> GAPgListView(owin_rolepermissionEntity owin_rolepermission);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
