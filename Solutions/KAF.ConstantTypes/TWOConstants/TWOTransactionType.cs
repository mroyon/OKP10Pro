using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAF.ConstantTypes.TWOConstants
{
    public class TWOTransactionType
    {
        public static string POS_Deposit { get { return "140"; } }
        public static string POS_Cash_Advance { get { return "115"; } }
        public static string POS_Balance_Inquery { get { return "117"; } }
        public static string POS_Normal_Purchase { get { return "110"; } }

        public static string ATM_Deposit { get { return "020"; } }
        public static string ATM_Cash_Withdraw { get { return "010"; } }
        public static string ATM_Balance_Inquery { get { return "030"; } }
      
    }
}
