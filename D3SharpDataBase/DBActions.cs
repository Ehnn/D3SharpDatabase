using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using D3Database;
using System.Security.Cryptography;

namespace D3SharpDatabase
{
    static class DBActions
    {
        #region account

        public static void SaveAccountFull()
        {
            SaveAccount("a", "b");

            //save digest
            SaveAccountDigest();

            //save normal shared items
            //if (sd.HasNormalSharedSavedItems)
            //sd.NormalSharedSavedItems

            //save hardcore shared items
            //if (sd.HasHardcoreSharedSavedItems)
            //sd.hardcore

            //save crafter data
            //sd.CrafterSavedData


        }

        public static void SaveBannerConfiguration()
        {
        }


        /// <summary>
        /// Assumes the account exists
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        public static void SaveAccount(string email, string password)
        {
            var account = (from x in D3DB.context.D3AccountSavedDefinition
                           where x.email == email
                           select x).SingleOrDefault();

            if (account == null)
            {
                //create a new account
                D3AccountSavedDefinition newacc = D3AccountSavedDefinition.CreateD3AccountSavedDefinition(Guid.NewGuid(), email, HashPassword(password));
                D3DB.context.D3AccountSavedDefinition.AddObject(newacc);
                D3DB.context.SaveChanges();
            }

            if (account != null && account.password != HashPassword(password))
            {
                Console.WriteLine("Incorrect password");
                return;
            }
        }

        private static void SaveAccountDigest()
        {
        }

        public static void LoadAccount(string email, string password)
        {
            var account = (from x in D3DB.context.D3AccountSavedDefinition
                           where x.email == email
                           select x).SingleOrDefault();

            if (account == null)
            {
                //create a new account
                D3AccountSavedDefinition newacc = D3AccountSavedDefinition.CreateD3AccountSavedDefinition(Guid.NewGuid(), email, HashPassword(password));
                D3DB.context.D3AccountSavedDefinition.AddObject(newacc);
                D3DB.context.SaveChanges();
            }

            if (account != null && account.password != HashPassword(password))
            {
                Console.WriteLine("Incorrect password");
                return;
            }
        }

        static string HashPassword(string password)
        {
            byte[] arrbyte = new byte[password.Length];
            SHA256 hash = new SHA256CryptoServiceProvider();
            arrbyte = hash.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(arrbyte);
        }

        #endregion
    }
}
