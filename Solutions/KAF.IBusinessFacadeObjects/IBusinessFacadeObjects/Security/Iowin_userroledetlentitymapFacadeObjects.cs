

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Iowin_userroledetlentitymapFacadeObjects")]
    public partial interface Iowin_userroledetlentitymapFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(owin_userroledetlentitymapEntity owin_userroledetlentitymap);
        
		[OperationContract]
		long Update(owin_userroledetlentitymapEntity owin_userroledetlentitymap);
		
		[OperationContract]
		long Delete(owin_userroledetlentitymapEntity owin_userroledetlentitymap );
        
        [OperationContract]
        long SaveList(List<owin_userroledetlentitymapEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<owin_userroledetlentitymapEntity> GetAll(owin_userroledetlentitymapEntity owin_userroledetlentitymap);
		
		[OperationContract]
        IList<owin_userroledetlentitymapEntity> GetAllByPages(owin_userroledetlentitymapEntity owin_userroledetlentitymap);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDetowin_userroledetlentityprofilemap(owin_userroledetlentitymapEntity Master, List<owin_userroledetlentityprofilemapEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        owin_userroledetlentitymapEntity  GetSingle(owin_userroledetlentitymapEntity owin_userroledetlentitymap);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<owin_userroledetlentitymapEntity> GAPgListView(owin_userroledetlentitymapEntity owin_userroledetlentitymap);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
