using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Reg_with_crypto
{
    public static class Crypto
    {
        public static string ToSHA256(string input)
        {

            SHA256 sha256 = SHA256.Create();
            
            try
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                var sb = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
        
      /*  public static void CreateFile()
        {
            if (!File.Exists(emailhelye))
            {
                File.Create(emailhelye);
              //  ir.Close();
            }
        }
       */
        
        

        
       
        static void Registration(string email)
        {

        }

      //  StreamWriter iro = new StreamWriter();

        
    }

    
}
