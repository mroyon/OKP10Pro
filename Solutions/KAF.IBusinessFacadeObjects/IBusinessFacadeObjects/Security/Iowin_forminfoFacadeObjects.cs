

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Iowin_forminfoFacadeObjects")]
    public partial interface Iowin_forminfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(owin_forminfoEntity owin_forminfo);
        
		[OperationContract]
		long Update(owin_forminfoEntity owin_forminfo);
		
		[OperationContract]
		long Delete(owin_forminfoEntity owin_forminfo );
        
        [OperationContract]
        long SaveList(List<owin_forminfoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<owin_forminfoEntity> GetAll(owin_forminfoEntity owin_forminfo);
		
		[OperationContract]
        IList<owin_forminfoEntity> GetAllByPages(owin_forminfoEntity owin_forminfo);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        long SaveMasterDetowin_formaction(owin_forminfoEntity Master, List<owin_formactionEntity> DetailList);

        [OperationContract]
        long SaveMasterDetowin_lastworkingpage(owin_forminfoEntity Master, List<owin_lastworkingpageEntity> DetailList);

        [OperationContract]
        long SaveMasterDetowin_rolepermission(owin_forminfoEntity Master, List<owin_rolepermissionEntity> DetailList);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        owin_forminfoEntity  GetSingle(owin_forminfoEntity owin_forminfo);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<owin_forminfoEntity> GAPgListView(owin_forminfoEntity owin_forminfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
