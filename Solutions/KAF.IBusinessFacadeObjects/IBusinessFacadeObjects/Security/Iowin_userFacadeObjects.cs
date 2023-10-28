

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Iowin_userFacadeObjects")]
    public partial interface Iowin_userFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(owin_userEntity owin_user);
        
		[OperationContract]
		long Update(owin_userEntity owin_user);
		
		[OperationContract]
		long Delete(owin_userEntity owin_user );
        
        [OperationContract]
        long SaveList(List<owin_userEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<owin_userEntity> GetAll(owin_userEntity owin_user);
		
		[OperationContract]
        IList<owin_userEntity> GetAllByPages(owin_userEntity owin_user);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDetowin_lastworkingpage(owin_userEntity Master, List<owin_lastworkingpageEntity> DetailList);

        [OperationContract]
        long SaveMasterDetowin_reportpermission(owin_userEntity Master, List<owin_reportpermissionEntity> DetailList);

        [OperationContract]
        long SaveMasterDetowin_userroledetl(owin_userEntity Master, List<owin_userroledetlEntity> DetailList);

        [OperationContract]
        long SaveMasterDetowin_tsv(owin_userEntity Master, List<owin_tsvEntity> DetailList);

        [OperationContract]
        long SaveMasterDetowin_userlogintrail(owin_userEntity Master, List<owin_userlogintrailEntity> DetailList);

        [OperationContract]
        long SaveMasterDetowin_userpasswordresetinfo(owin_userEntity Master, List<owin_userpasswordresetinfoEntity> DetailList);

        [OperationContract]
        long SaveMasterDetowin_userprefferencessettings(owin_userEntity Master, List<owin_userprefferencessettingsEntity> DetailList);

        [OperationContract]
        long SaveMasterDetowin_userrole(owin_userEntity Master, List<owin_userroleEntity> DetailList);

        [OperationContract]
        long SaveMasterDetowin_userroledetlentitymap(owin_userEntity Master, List<owin_userroledetlentitymapEntity> DetailList);

        [OperationContract]
        long SaveMasterDetowin_userroledetlentityprofilemap(owin_userEntity Master, List<owin_userroledetlentityprofilemapEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        owin_userEntity  GetSingle(owin_userEntity owin_user);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<owin_userEntity> GAPgListView(owin_userEntity owin_user);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        [OperationContract]
        long UpdateReviewed(owin_userEntity owin_user);
        #endregion 
    }
}
