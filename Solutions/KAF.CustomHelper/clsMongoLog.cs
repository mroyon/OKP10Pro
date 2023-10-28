
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;

using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;


namespace KAF.CustomHelper.HelperClasses
{
    public class clsMongoLog
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public clsMongoLog()
        { }
        public void SetLog(SecurityCapsule secpack, KAF_TransCodesEntity objPacks, string msg, LOGLevel levelType)
        {
            try 
            {
                if (secpack != null && secpack.createdby != null && secpack.createdby > 0)
                {
                    JavaScriptSerializer js = new JavaScriptSerializer();

                    ThreadContext.Properties["username"] = secpack.username;
                    ThreadContext.Properties["controllername"] = secpack.controllername;
                    ThreadContext.Properties["actionname"] = secpack.actioname;
                    ThreadContext.Properties["transid"] = secpack.transid;
                    ThreadContext.Properties["applicationname"] = "KAF-IMS-EXC-WEB-V5.0";
                    clsLogDetail objLog = SetLog(secpack, msg);
                    if (levelType == LOGLevel.Error)
                        log.Error(js.Serialize(objLog));
                    if (levelType == LOGLevel.Info)
                        log.Info(js.Serialize(objLog));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public clsLogDetail SetLog(
           SecurityCapsule sec,
           string msg)
        {
            clsLogDetail obj = new clsLogDetail();

            try
            {
                obj.securitycapule = sec;
                obj.msg = msg;
                obj.pageurl = sec.pageurl;
                obj.sessionid = sec.sessionid;
                obj.transid = sec.transid;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return obj;
        }
    }

    public enum LOGLevel
    {
        Info = 1,
        Error = 2,
        Debug = 3
    }
}