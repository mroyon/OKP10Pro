

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Iowin_userroleFacadeObjects")]
    public partial interface Iowin_userroleFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(owin_userroleEntity owin_userrole);
        
		[OperationContract]
		long Update(owin_userroleEntity owin_userrole);
		
		[OperationContract]
		long Delete(owin_userroleEntity owin_userrole );
        
        [OperationContract]
        long SaveList(List<owin_userroleEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<owin_userroleEntity> GetAll(owin_userroleEntity owin_userrole);
		
		[OperationContract]
        IList<owin_userroleEntity> GetAllByPages(owin_userroleEntity owin_userrole);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDetowin_userroledetl(owin_userroleEntity Master, List<owin_userroledetlEntity> DetailList);

        [OperationContract]
        long SaveMasterDetowin_userroledetlentitymap(owin_userroleEntity Master, List<owin_userroledetlentitymapEntity> DetailList);

        [OperationContract]
        long SaveMasterDetowin_userroledetlentityprofilemap(owin_userroleEntity Master, List<owin_userroledetlentityprofilemapEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        owin_userroleEntity  GetSingle(owin_userroleEntity owin_userrole);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<owin_userroleEntity> GAPgListView(owin_userroleEntity owin_userrole);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
