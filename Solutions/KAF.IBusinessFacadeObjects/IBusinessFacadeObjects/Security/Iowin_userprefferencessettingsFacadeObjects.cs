

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Iowin_userprefferencessettingsFacadeObjects")]
    public partial interface Iowin_userprefferencessettingsFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(owin_userprefferencessettingsEntity owin_userprefferencessettings);
        
		[OperationContract]
		long Update(owin_userprefferencessettingsEntity owin_userprefferencessettings);
		
		[OperationContract]
		long Delete(owin_userprefferencessettingsEntity owin_userprefferencessettings );
        
        [OperationContract]
        long SaveList(List<owin_userprefferencessettingsEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<owin_userprefferencessettingsEntity> GetAll(owin_userprefferencessettingsEntity owin_userprefferencessettings);
		
		[OperationContract]
        IList<owin_userprefferencessettingsEntity> GetAllByPages(owin_userprefferencessettingsEntity owin_userprefferencessettings);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        owin_userprefferencessettingsEntity  GetSingle(owin_userprefferencessettingsEntity owin_userprefferencessettings);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<owin_userprefferencessettingsEntity> GAPgListView(owin_userprefferencessettingsEntity owin_userprefferencessettings);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
