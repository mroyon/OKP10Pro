using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAF.ConstantTypes.TWOConstants
{
    public enum TWOMessageTypeIndication
    {
        AuthorizationRequest = 0100,
        AuthorizationResponse = 0110,
        AuthorizationAdviceRequest = 0120,
        AuthorizationAdviceResponse = 0130,
        FinancialTranRequest = 0200,
        FinancialTranResponse = 0210,
        FinancialAdviceRequest = 0220,
        FinancialAdviceResponse = 0230,
        AcquirerReversalAdvice = 0420,
        AcquirerReversalAdviceResponse = 0430,
        NetworkManagementRequest = 0800,
        NetworkManagementResponse = 0810
    }

    public class TWOMessageTypeIndication_G : IDisposable
    {
        #region Constructer & Destructor

        private bool IsDisposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected void Dispose(bool Diposing)
        {
            if (!IsDisposed)
            {
                if (Diposing)
                {
                    //Clean Up managed resources
                }
                //Clean up unmanaged resources
            }
            IsDisposed = true;
        }
        ~TWOMessageTypeIndication_G()
        {
            Dispose(false);
        }
        public TWOMessageTypeIndication_G()
        {

        }

        #endregion

        /// <summary>   Gets two message type indication type. </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="GetTWOMessageTypeIndicationType" type="TWOMessageTypeIndication"> GetTWOMessageTypeIndicationType. </method>
        /// <param name="data" type="string"> The data. </param>
        /// <returns>   The two message type indication type. </returns>

        public TWOMessageTypeIndication GetTWOMessageTypeIndicationType(string data)
        {


            if (data == "100") return TWOMessageTypeIndication.AuthorizationRequest;
            else if (data == "110") return TWOMessageTypeIndication.AuthorizationResponse;
            else if (data == "120") return TWOMessageTypeIndication.AuthorizationAdviceRequest;
            else if (data == "130") return TWOMessageTypeIndication.AuthorizationAdviceResponse;
            else if (data == "200") return TWOMessageTypeIndication.FinancialTranRequest;
            else if (data == "210") return TWOMessageTypeIndication.FinancialTranResponse;
            else if (data == "220") return TWOMessageTypeIndication.FinancialAdviceRequest;
            else if (data == "230") return TWOMessageTypeIndication.FinancialAdviceResponse;
            else if (data == "420") return TWOMessageTypeIndication.AcquirerReversalAdvice;
            else if (data == "430") return TWOMessageTypeIndication.AcquirerReversalAdviceResponse;
            else if (data == "800") return TWOMessageTypeIndication.NetworkManagementRequest;
            else //if (data == "810")
                return TWOMessageTypeIndication.NetworkManagementResponse;

        }
    }
}
