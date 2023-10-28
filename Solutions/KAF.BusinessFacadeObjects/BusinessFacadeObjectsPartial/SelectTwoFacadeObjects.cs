using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

using KAF.BusinessDataObjects;
using KAF.AppConfiguration;
using KAF.DataAccessObjects;
using KAF.IBusinessFacadeObjects;
using KAF.AppConfiguration.Configuration;

using KAF.IBusinessFacadeObjects.IBusinessFacadeObjectsPartial;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessFacadeObjects.BusinessFacadeObjectsPartial
{
    public sealed class SelectTwoFacadeObjects : BaseFacade, ISelectTwoFacadeObjects
    {

        #region Instance Variables
        private string ClassName = "SelectTwoFacadeObjects";
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

        public SelectTwoFacadeObjects()
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

        ~SelectTwoFacadeObjects()
        {
            Dispose(false);
        }

        private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        #endregion


        IList<stp_organizationentityEntity> ISelectTwoFacadeObjects.GetPaged_Stp_OrganizationEntity(stp_organizationentityEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateSelectTwoDataAccessObjects().GetPaged_Stp_OrganizationEntity(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<stp_organizationentityEntity> ISelectTwoFacadeObjects.GetPaged_Stp_OrganizationEntity"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }
        
        IList<gen_govcityEntity> ISelectTwoFacadeObjects.GetPaged_Gen_GovCity(gen_govcityEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateSelectTwoDataAccessObjects().GetPaged_Gen_GovCity(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_govcityEntity> ISelectTwoFacadeObjects.GetPaged_Gen_GovCity"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }
       
        IList<gen_countryEntity> ISelectTwoFacadeObjects.GetPaged_Gen_Country(gen_countryEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateSelectTwoDataAccessObjects().GetPaged_Gen_Country(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_countryEntity> ISelectTwoFacadeObjects.GetPaged_Gen_Country"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        IList<gen_divisiondistrictEntity> ISelectTwoFacadeObjects.GetPaged_Gen_District(gen_divisiondistrictEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateSelectTwoDataAccessObjects().GetPaged_Gen_District(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_DistrictEntity> ISelectTwoFacadeObjects.GetPaged_Gen_District"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        IList<gen_rankEntity> ISelectTwoFacadeObjects.GetPaged_Gen_Rank(gen_rankEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateSelectTwoDataAccessObjects().GetPaged_Gen_Rank(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_rankEntity> ISelectTwoFacadeObjects.GetPaged_gen_rank"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }
        IList<gen_tradeEntity> ISelectTwoFacadeObjects.GetPaged_Gen_Trade(gen_tradeEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateSelectTwoDataAccessObjects().GetPaged_Gen_Trade(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_tradeEntity> ISelectTwoFacadeObjects.GetPaged_gen_trade"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }
        IList<gen_thanaEntity> ISelectTwoFacadeObjects.GetPaged_Gen_Thana(gen_thanaEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateSelectTwoDataAccessObjects().GetPaged_Gen_Thana(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_thanaEntity> ISelectTwoFacadeObjects.GetPaged_Gen_Thana"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        IList<stp_organizationEntity> ISelectTwoFacadeObjects.GetPaged_Stp_Organization(stp_organizationEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateSelectTwoDataAccessObjects().GetPaged_Stp_Organization(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<stp_organizationentityEntity> ISelectTwoFacadeObjects.GetPaged_Stp_OrganizationEntity"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

    }
}
