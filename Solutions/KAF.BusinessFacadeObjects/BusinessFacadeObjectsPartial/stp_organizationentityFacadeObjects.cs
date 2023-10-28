
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using KAF.BusinessDataObjects;
using KAF.AppConfiguration.Configuration;
using KAF.DataAccessObjects;

using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using KAF.IBusinessFacadeObjects.IBusinessFacadeObjectsPartial;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;



namespace KAF.BusinessFacadeObjects.BusinessFacadeObjectsPartial
{
    public sealed  class stp_organizationentityFacadeObjects : BaseFacade, Istp_organizationentityFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "owin_userFacadeObjects";
        private bool _isDisposed;
        private Context _currentContext;

        private BaseDataAccessFactory _dataAccessFactory;

        #endregion

        #region Private Properties

        private Context CurrentContext
        {
            [DebuggerStepThrough()]
            get
            {
                if (_currentContext == null)
                {
                    _currentContext = new Context();
                }

                return _currentContext;
            }
        }

        private BaseDataAccessFactory DataAccessFactory
        {
            [DebuggerStepThrough()]
            get
            {
                if (_dataAccessFactory == null)
                {
                    _dataAccessFactory = BaseDataAccessFactory.Create(CurrentContext);
                }

                return _dataAccessFactory;
            }
        }

        #endregion

        #region Constructer & Destructor

        public stp_organizationentityFacadeObjects()
            : base()
        {
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    if (_currentContext != null)
                    {
                        _currentContext.Dispose();
                    }
                }
            }

            _isDisposed = true;
        }

        ~stp_organizationentityFacadeObjects()
        {
            Dispose(false);
        }
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        #endregion

        #region Business Facade

        #region SearchUser

        IList<stp_organizationentityEntity> Istp_organizationentityFacadeObjects.SearchUnit(stp_organizationentityEntity stp_organizationentityEntity)
		{
			try
			{
				return DataAccessFactory.Createstp_organizationentityDataAccess().SearchUnit(stp_organizationentityEntity);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userEntity> Iowin_userFacade.SearchUnit"));
            }
		}

        #endregion SearchUser



        #endregion
    }
}