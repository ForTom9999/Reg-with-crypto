using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reg_with_crypto.FileIO
{
    public class Write
    {
       // public static string emailhelye = "o:\\Itt\\ott\\mailok.txt";
        public static StreamWriter ir = new StreamWriter(Read.Email, true);
        public static StreamWriter irhash = new StreamWriter(Read.Hash, true);
        

     /*   public static void IrEmail()
        {
            string elsoSor = "ID;Email;";
          // File.AppendAllText(Read.Email, elsoSor);
            ir.WriteLine(elsoSor);
            ir.Close();
        }
      
        public static void IrHash()
        {
            string elsoSor = "ID;Hash;";
            ir.WriteLine(elsoSor);
            ir.Close();
        }
       */
        public static void Reg(string email, string password)
        {
            //Read.IsREgistredEmail(email);
            
            Read.ID++;
            ir.WriteLine("{0};{1}", Read.ID, email);
            ir.Close();
            irhash.WriteLine("{0};{1}", Read.ID, Crypto.ToSHA256(password));
            irhash.Close();


        }



    }
}
