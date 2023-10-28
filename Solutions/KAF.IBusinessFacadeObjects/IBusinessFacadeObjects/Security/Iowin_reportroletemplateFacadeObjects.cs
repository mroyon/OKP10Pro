

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Iowin_reportroletemplateFacadeObjects")]
    public partial interface Iowin_reportroletemplateFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(owin_reportroletemplateEntity owin_reportroletemplate);
        
		[OperationContract]
		long Update(owin_reportroletemplateEntity owin_reportroletemplate);
		
		[OperationContract]
		long Delete(owin_reportroletemplateEntity owin_reportroletemplate );
        
        [OperationContract]
        long SaveList(List<owin_reportroletemplateEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<owin_reportroletemplateEntity> GetAll(owin_reportroletemplateEntity owin_reportroletemplate);
		
		[OperationContract]
        IList<owin_reportroletemplateEntity> GetAllByPages(owin_reportroletemplateEntity owin_reportroletemplate);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        owin_reportroletemplateEntity  GetSingle(owin_reportroletemplateEntity owin_reportroletemplate);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<owin_reportroletemplateEntity> GAPgListView(owin_reportroletemplateEntity owin_reportroletemplate);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
