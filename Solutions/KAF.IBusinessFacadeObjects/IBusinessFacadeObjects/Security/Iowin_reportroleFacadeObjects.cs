

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Iowin_reportroleFacadeObjects")]
    public partial interface Iowin_reportroleFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(owin_reportroleEntity owin_reportrole);
        
		[OperationContract]
		long Update(owin_reportroleEntity owin_reportrole);
		
		[OperationContract]
		long Delete(owin_reportroleEntity owin_reportrole );
        
        [OperationContract]
        long SaveList(List<owin_reportroleEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<owin_reportroleEntity> GetAll(owin_reportroleEntity owin_reportrole);
		
		[OperationContract]
        IList<owin_reportroleEntity> GetAllByPages(owin_reportroleEntity owin_reportrole);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDetowin_reportpermission(owin_reportroleEntity Master, List<owin_reportpermissionEntity> DetailList);

        [OperationContract]
        long SaveMasterDetowin_reportroletemplate(owin_reportroleEntity Master, List<owin_reportroletemplateEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        owin_reportroleEntity  GetSingle(owin_reportroleEntity owin_reportrole);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<owin_reportroleEntity> GAPgListView(owin_reportroleEntity owin_reportrole);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
