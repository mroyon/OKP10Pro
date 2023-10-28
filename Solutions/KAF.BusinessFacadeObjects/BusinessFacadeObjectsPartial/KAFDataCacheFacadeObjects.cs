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
    public sealed class KAFDataCacheFacadeObjects : BaseFacade, IKAFDataCacheFacadeObjects
    {
        #region Instance Variables
        private string ClassName = "KAFDataCacheFacadeObjects";
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

        public KAFDataCacheFacadeObjects()
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

        ~KAFDataCacheFacadeObjects()
        {
            Dispose(false);
        }

        private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        #endregion



        IList<owin_roleEntity> IKAFDataCacheFacadeObjects.GetforCache_roleEntity(owin_roleEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFDataCacheDataAccessObjects().GetforCache_roleEntity(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_roleEntity> IKAFDataCacheFacadeObjects.GetforCache_roleEntity"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        IList<owin_reportroleEntity> IKAFDataCacheFacadeObjects.GetforCache_reportroleEntity(owin_reportroleEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFDataCacheDataAccessObjects().GetforCache_reportroleEntity(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_reportroleEntity> IKAFDataCacheFacadeObjects.GetforCache_reportroleEntity"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        IList<owin_formactionEntity> IKAFDataCacheFacadeObjects.GetforCache_formactionEntity(owin_formactionEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFDataCacheDataAccessObjects().GetforCache_formactionEntity(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_formactionEntity> IKAFDataCacheFacadeObjects.GetforCache_formactionEntity"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        IList<owin_forminfoEntity> IKAFDataCacheFacadeObjects.GetforCache_forminfoEntity(owin_forminfoEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFDataCacheDataAccessObjects().GetforCache_forminfoEntity(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_forminfoEntity> IKAFDataCacheFacadeObjects.GetforCache_forminfoEntity"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        IList<gen_airlinesEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_airlinesEntity(gen_airlinesEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFDataCacheDataAccessObjects().GetforCache_gen_airlinesEntity(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_bloodgroupEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_airlinesEntity"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        IList<gen_buildingEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_buildingEntity(gen_buildingEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFDataCacheDataAccessObjects().GetforCache_gen_buildingEntity(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_bloodgroupEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_buildingEntity"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        IList<gen_okpEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_okpEntity(gen_okpEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFDataCacheDataAccessObjects().GetforCache_gen_okpEntity(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_bloodgroupEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_okpEntity"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        IList<gen_armsEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_armsEntity(gen_armsEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFDataCacheDataAccessObjects().GetforCache_gen_armsEntity(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_bloodgroupEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_armsEntity"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        IList<stp_organizationentitytypeEntity> IKAFDataCacheFacadeObjects.GetforCache_stp_organizationentitytypeEntity(stp_organizationentitytypeEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFDataCacheDataAccessObjects().GetforCache_stp_organizationentitytypeEntity(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<stp_organizationentitytypeEntity> IKAFDataCacheFacadeObjects.GetforCache_stp_organizationentitytypeEntity"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }
        IList<stp_organizationEntity> IKAFDataCacheFacadeObjects.GetforCache_stp_organizationEntity(stp_organizationEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFDataCacheDataAccessObjects().GetforCache_stp_organizationEntity(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<stp_organizationEntity> IKAFDataCacheFacadeObjects.GetforCache_stp_organizationEntity"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        IList<gen_bankbranchEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_bankbranchEntity(gen_bankbranchEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFDataCacheDataAccessObjects().GetforCache_gen_bankbranchEntity(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_bankbranchEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_bankbranchEntity"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }
        IList<gen_bankEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_bankEntity(gen_bankEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFDataCacheDataAccessObjects().GetforCache_gen_bankEntity(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_bankEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_bankEntity"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        IList<gen_filetypeEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_filetypeEntity(gen_filetypeEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFDataCacheDataAccessObjects().GetforCache_gen_filetypeEntity(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_filetypeEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_filetypeEntity"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        IList<gen_relationshipEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_relationshipEntity(gen_relationshipEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFDataCacheDataAccessObjects().GetforCache_gen_relationshipEntity(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_relationshipEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_relationshipEntity"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }


        IList<gen_bloodgroupEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_bloodgroupEntity(gen_bloodgroupEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFDataCacheDataAccessObjects().GetforCache_gen_bloodgroupEntity(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_bloodgroupEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_bloodgroupEntity"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        IList<gen_freedomfighttypeEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_freedomfighttypeEntity(gen_freedomfighttypeEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFDataCacheDataAccessObjects().GetforCache_gen_freedomfighttypeEntity(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_freedomfighttypeEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_freedomfighttypeEntity"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        IList<gen_genderEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_genderEntity(gen_genderEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFDataCacheDataAccessObjects().GetforCache_gen_genderEntity(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_genderEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_genderEntity"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        IList<gen_issuetypeEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_issuetypeEntity(gen_issuetypeEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFDataCacheDataAccessObjects().GetforCache_gen_issuetypeEntity(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_issuetypeEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_issuetypeEntity"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        IList<gen_languageEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_languageEntity(gen_languageEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFDataCacheDataAccessObjects().GetforCache_gen_languageEntity(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_languageEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_languageEntity"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        IList<gen_languageproficiencyEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_languageproficiencyEntity(gen_languageproficiencyEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFDataCacheDataAccessObjects().GetforCache_gen_languageproficiencyEntity(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_languageproficiencyEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_languageproficiencyEntity"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        IList<gen_maritalstatusEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_maritalstatusEntity(gen_maritalstatusEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFDataCacheDataAccessObjects().GetforCache_gen_maritalstatusEntity(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_maritalstatusEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_maritalstatusEntity"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        IList<gen_movementtypeEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_movementtypeEntity(gen_movementtypeEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFDataCacheDataAccessObjects().GetforCache_gen_movementtypeEntity(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_movementtypeEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_movementtypeEntity"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        IList<gen_penaltytypeEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_penaltytypeEntity(gen_penaltytypeEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFDataCacheDataAccessObjects().GetforCache_gen_penaltytypeEntity(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_penaltytypeEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_penaltytypeEntity"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        IList<gen_promotiontypeEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_promotiontypeEntity(gen_promotiontypeEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFDataCacheDataAccessObjects().GetforCache_gen_promotiontypeEntity(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_promotiontypeEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_promotiontypeEntity"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        IList<gen_ranktypeEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_ranktypeEntity(gen_ranktypeEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFDataCacheDataAccessObjects().GetforCache_gen_ranktypeEntity(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_ranktypeEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_ranktypeEntity"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        IList<gen_religionEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_religionEntity(gen_religionEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFDataCacheDataAccessObjects().GetforCache_gen_religionEntity(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_religionEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_religionEntity"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        IList<gen_servicestatusEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_servicestatusEntity(gen_servicestatusEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFDataCacheDataAccessObjects().GetforCache_gen_servicestatusEntity(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_servicestatusEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_servicestatusEntity"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

        IList<gen_leavetypeEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_leavetypeEntity(gen_leavetypeEntity objEntity)
        {
            try
            {
                return DataAccessFactory.CreateKAFDataCacheDataAccessObjects().GetforCache_gen_leavetypeEntity(objEntity);
            }
            catch (DataException ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_leavetypeEntity> IKAFDataCacheFacadeObjects.GetforCache_gen_leavetypeEntity"));
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }

    }
}
