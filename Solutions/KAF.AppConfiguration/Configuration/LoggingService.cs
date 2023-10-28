using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;

namespace KAF.AppConfiguration.Configuration
{
    public class LoggingService
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public void Log(string message)
        {
            log.Info(message);
        }
    }
}
