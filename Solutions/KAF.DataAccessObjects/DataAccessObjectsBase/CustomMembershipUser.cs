using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace KAF.DataAccessObjects
{
    public class CustomMembershipUser
    {
        public CustomMembershipUser()
        {
        }

        public string decryptSimple(string password)
        {
            try
            {
                System.Text.Decoder utf8decode = new UTF8Encoding().GetDecoder();
                byte[] todecode_byte = Convert.FromBase64String(password);
                char[] decoded_char = new char[utf8decode.GetCharCount(todecode_byte, 0, todecode_byte.Length)];
                utf8decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
                return new string(decoded_char);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string encryptSimple(string password)
        {
            try
            {
                byte[] testdata = new byte[password.Length];
                return Convert.ToBase64String(Encoding.UTF8.GetBytes(password));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
       

    }
}
