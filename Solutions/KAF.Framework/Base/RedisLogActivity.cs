using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using log4net.Appender;
using log4net.Config;
using StackExchange.Redis;
using KAF.BusinessDataObjects;
using System.Web;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using KAF.AppConfiguration.Configuration;

namespace KAF.WebFramework
{
    public class RedisLogActivity : IDisposable
    {
        private static readonly log4net.ILog logger = LogManager.GetLogger("RedisAppender");
        #region IDisposable Members

        public RedisLogActivity()
        {
           // XmlConfigurator.Configure();
        }

        private bool isDisposed = false;

        ~RedisLogActivity()
        {
            Dispose(false);
        }

        /// <summary>
        /// Releases the unmanaged resources used by the KAF.SMSServiceAssistant.AppLogActivity and
        /// optionally releases the managed resources.
        /// </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="Dispose" type="protected void"> Dispose. </method>
        /// <param name="disposing" type="bool">    True to release both managed and unmanaged resources; false to
        ///                             release only unmanaged resources. </param>
        ///
        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Code to dispose the managed resources of the class
            }
            // Code to dispose the un-managed resources of the class

            isDisposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion

        public enum LOGLevel
        {
            Info = 1,
            Error = 2,
            Debug = 3
        }

        /// <summary>   Sets a log. </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="SetLog" type="log_applogactivityEntity">  SetLog. </method>
        /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
        /// <param name="sec" type="SecurityCapsule">      The security. </param>
        /// <param name="codePack" type="KAF_TransCodesEntity"> The code pack. </param>
        /// <param name="msg" type="string">      The message. </param>
        /// <param name="loglevel" type="LOGLevel"> The loglevel. </param>
        /// <returns>   A log_applogactivityEntity. </returns>

        public log_applogactivityEntity SetLog(
            SecurityCapsule sec,
            KAF_TransCodesEntity codePack,
            string msg, LOGLevel loglevel)
        {
            log_applogactivityEntity obj = new log_applogactivityEntity();
            try
            {
                obj.BaseSecurityParam = new SecurityCapsule();
                obj.BaseSecurityParam = sec;
                if (!string.IsNullOrEmpty(sec.hitfrom))
                    obj.hitfrom = sec.hitfrom;

                if (sec.appformid.HasValue)
                    obj.BaseSecurityParam.appformid = sec.appformid.GetValueOrDefault();
                else
                    obj.BaseSecurityParam.appformid = -99;

                if (!string.IsNullOrEmpty(sec.username))
                    obj.username = sec.username;

                if (sec.userorganizationkey.HasValue)
                    obj.organizationkey = sec.userorganizationkey.GetValueOrDefault();
                else
                    obj.organizationkey = -99;

                if (!string.IsNullOrEmpty(sec.controllername))
                    obj.BaseSecurityParam.controllername = sec.controllername;

                if (!string.IsNullOrEmpty(sec.pageurl))
                    obj.pageurl = sec.pageurl;

                if (!string.IsNullOrEmpty(sec.ipaddress))
                    obj.BaseSecurityParam.ipaddress = sec.ipaddress;

                if (!string.IsNullOrEmpty(sec.actioname))
                    obj.machinename = sec.actioname;

                if (sec.createdby.HasValue)
                    obj.BaseSecurityParam.createdby = sec.createdby;
                else
                    obj.BaseSecurityParam.createdby = -99;

                obj.level = loglevel.ToString();

                obj.tranid = sec.transid;
                obj.sessionid = sec.sessionid;
                obj.raisingevent = sec.raisingevent;

                obj.message = msg;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return obj;
        }

        /// <summary>   Logs a data. </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="LogData" type="public void"> LogData. </method>
        /// <param name="objLog" type="log_applogactivityEntity">   The object log. </param>

        public void LogData(log_applogactivityEntity objLog)
        {
            if (objLog != null)
            {
                clsTextMasking objmasking = new clsTextMasking();
                string classname = "KAF_Redis_MAJCSC";
                try
                {
                    if (!string.IsNullOrEmpty(objLog.BaseSecurityParam.controllername))
                    {
                        if (objLog.BaseSecurityParam != null)
                            classname = objLog.BaseSecurityParam.controllername;
                    }
                    ILog Logger = LogManager.GetLogger(classname);
                   // XmlConfigurator.Configure();
                    if (objLog.BaseSecurityParam.appformid.HasValue)
                        log4net.LogicalThreadContext.Properties["FormID"] = objLog.BaseSecurityParam.appformid.GetValueOrDefault(-99).ToString();

                    if (!string.IsNullOrEmpty(objLog.pageurl))
                        log4net.LogicalThreadContext.Properties["PageURL"] = objLog.pageurl;

                    if (!string.IsNullOrEmpty(objLog.BaseSecurityParam.ipaddress))
                        log4net.LogicalThreadContext.Properties["IPAddress"] = objLog.BaseSecurityParam.ipaddress;

                    if (!string.IsNullOrEmpty(objLog.username))
                        log4net.LogicalThreadContext.Properties["username"] = objLog.username;

                    if (objLog.hitfrom != null)
                        log4net.LogicalThreadContext.Properties["hitFrom"] = objLog.hitfrom;

                    if (objLog.organizationkey != null)
                        log4net.LogicalThreadContext.Properties["OrganizationKey"] = objLog.organizationkey.GetValueOrDefault();

                    if (!string.IsNullOrEmpty(objLog.machinename))
                        log4net.LogicalThreadContext.Properties["MachineName"] = objLog.machinename;

                    if (!string.IsNullOrEmpty(objLog.tranid))
                        log4net.LogicalThreadContext.Properties["TranID"] = objLog.tranid;

                    if (!string.IsNullOrEmpty(objLog.sessionid))
                        log4net.LogicalThreadContext.Properties["SessionID"] = objLog.sessionid;

                    if (!string.IsNullOrEmpty(objLog.raisingevent))
                        log4net.LogicalThreadContext.Properties["RaisingEvent"] = objLog.raisingevent;
                    
                    if (objLog.BaseSecurityParam.createdby.HasValue)
                        log4net.LogicalThreadContext.Properties["CreatedBy"] = objLog.BaseSecurityParam.createdby.GetValueOrDefault(0).ToString();

                    log4net.LogicalThreadContext.Properties["Message"] = objmasking.patternLibrary(objLog.message);

                    if (objLog.level == "1")
                        logger.Info(objLog.message);
                    else if (objLog.level == "2")
                        logger.Error(objLog.message);
                    else if (objLog.level == "3")
                        logger.Debug(objLog.message);
                    else
                        logger.Info(objLog.message);
                }
                catch (Exception ex)
                {

                    throw;
                }
                finally
                {
                    objmasking.Dispose();
                }
            }
        }
    }
}
