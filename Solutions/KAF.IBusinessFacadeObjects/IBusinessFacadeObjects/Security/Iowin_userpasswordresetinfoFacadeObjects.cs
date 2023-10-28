

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Iowin_userpasswordresetinfoFacadeObjects")]
    public partial interface Iowin_userpasswordresetinfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo);
        
		[OperationContract]
		long Update(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo);
		
		[OperationContract]
		long Delete(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo );
        
        [OperationContract]
        long SaveList(List<owin_userpasswordresetinfoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<owin_userpasswordresetinfoEntity> GetAll(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo);
		
		[OperationContract]
        IList<owin_userpasswordresetinfoEntity> GetAllByPages(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        owin_userpasswordresetinfoEntity  GetSingle(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<owin_userpasswordresetinfoEntity> GAPgListView(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
