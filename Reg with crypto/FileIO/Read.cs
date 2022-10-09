using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reg_with_crypto.FileIO
{
    
    
    public class Read
    {
        public static int ID = 0;
        private static bool isRegistred;
        private static string email = "email.txt";
        private static string hash = "hash.txt";
        private static StreamReader olv = new StreamReader(Email);
        private static StreamReader olvHash = new StreamReader(Hash);

        public static bool IsRegistred { get => isRegistred; set => isRegistred = value; }
        public static string Email { get => email; set => email = value; }
        public static StreamReader Olv { get => olv; set => olv = value; }
        public static string Hash { get => hash; set => hash = value; }
        public static StreamReader OlvHash { get => olvHash; set => olvHash = value; }


        

        public static bool IsREgistredEmail(string email)
        {
            OlvHash.Close();
            while (!Olv.EndOfStream)
            {
                string[] line = Olv.ReadLine().Split(';');
                ID = Convert.ToInt32(line[0]);  
                
                foreach (var item in line)
                {
                    

                    if (item == email)
                    {
                        //IsRegistred = true;
                        Olv.Close();
                        return true;
                        //break;
                    }
                    //IsRegistred = false;
                    
                }

               
            }
            Olv.Close();
            return false;
           // return IsRegistred;
        }
        public static int GetID(string email)
        {
            int ID;

            while (!Olv.EndOfStream)
            {
                string[] line = Olv.ReadLine().Split(';');
                ID = Convert.ToInt32(line[0]);

                foreach (var item in line)
                {
                    if (item == email)
                    {
                        Olv.Close();
                        return ID;
                    }
                }
            }
            Olv.Close();
            return -1;
        }

        public static bool CheckPassword(string password, int ID)
        {
            while (!OlvHash.EndOfStream)
            {
                string[] line = OlvHash.ReadLine().Split(';');
                if (ID == Convert.ToInt32(line[0]))
                {
                    if (Crypto.ToSHA256(password) == line[1])
                    {
                        OlvHash.Close();
                        return true; 
                    }
                }

            }
            OlvHash.Close();
            return false;
            
        }

    }
}
