using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace D3Database
{
    class D3DB
    {
        #region Singleton
        private static volatile D3DB instance;
        private static object syncRoot = new Object();

        public D3DB()
        {
            if (instance != null)
                return;
        }

        //private D3DB() { }

        public static D3DB Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new D3DB();
                    }
                }

                return instance;
            }
        }
        #endregion

        public static void SaveHero()
        {
            Console.WriteLine("saved hero");
        }

    }
}
