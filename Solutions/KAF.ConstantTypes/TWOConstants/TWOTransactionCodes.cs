using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAF.ConstantTypes.TWOConstants
{
    public class TWOTransactionCodes
    {

        public static string Approved { get { return "00001"; } }
        public static string Should_select_account_number { get { return "00010"; } }
        public static string Lost_card { get { return "00040"; } }
        public static string Stolen_card { get { return "00041"; } }
        public static string Unauthorized_usage { get { return "00050"; } }
        public static string Expired_card { get { return "00051"; } }
        public static string Invalid_card { get { return "00052"; } }
        public static string Invalid_PIN { get { return "00053"; } }
        public static string System_error { get { return "00054"; } }
        public static string Ineligible_transaction { get { return "00055"; } }
        public static string Ineligible_account { get { return "00056"; } }
        public static string Transaction_not_supported { get { return "00057"; } }
        public static string Restricted_Card { get { return "00058"; } }
        public static string Insufficient_funds { get { return "00059"; } }
        public static string Uses_limit_exceeded { get { return "00060"; } }
        public static string Withdrawal_limit_would_be_exceeded { get { return "00061"; } }
        public static string PIN_tries_exceeded { get { return "00062"; } }
        public static string The_withdrawal_limit_is_already_reached { get { return "00063"; } }
        public static string Invalid_credit_amount { get { return "00064"; } }
        public static string No_statement_information { get { return "00065"; } }
        public static string Statement_not_available { get { return "00066"; } }
        public static string Invalid_cash_back_amount { get { return "00067"; } }
        public static string External_decline { get { return "00068"; } }
        public static string Destination_not_available { get { return "00072"; } }
        public static string Inquiry_only { get { return "00097"; } }
        public static string Withdrawal_limit_already { get { return "00063"; } }
    }
}

  
