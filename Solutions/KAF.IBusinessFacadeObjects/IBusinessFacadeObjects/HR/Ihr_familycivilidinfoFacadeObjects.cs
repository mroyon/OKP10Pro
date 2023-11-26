

using System;
using System.Collections.Generic;
using System.ServiceModel;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.IBusinessFacadeObjects
{
    [ServiceContract(Name = "Ihr_familycivilidinfoFacadeObjects")]
    public partial interface Ihr_familycivilidinfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
		long Add(hr_familycivilidinfoEntity hr_familycivilidinfo);
        
		[OperationContract]
		long Update(hr_familycivilidinfoEntity hr_familycivilidinfo);
		
		[OperationContract]
		long Delete(hr_familycivilidinfoEntity hr_familycivilidinfo );
        
        [OperationContract]
        long SaveList(List<hr_familycivilidinfoEntity> list );                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        IList<hr_familycivilidinfoEntity> GetAll(hr_familycivilidinfoEntity hr_familycivilidinfo);
		
		[OperationContract]
        IList<hr_familycivilidinfoEntity> GetAllByPages(hr_familycivilidinfoEntity hr_familycivilidinfo);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        hr_familycivilidinfoEntity  GetSingle(hr_familycivilidinfoEntity hr_familycivilidinfo);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         IList<hr_familycivilidinfoEntity> GAPgListView(hr_familycivilidinfoEntity hr_familycivilidinfo);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
