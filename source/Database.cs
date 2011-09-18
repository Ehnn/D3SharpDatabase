﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace D3Database
{
    public class Database
    {
        #region Singleton
        private static volatile Database instance;
        private static object syncRoot = new Object();

        private Database() { }

        public static Database Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new Database();
                    }
                }

                return instance;
            }
        }
        #endregion

        public SQLiteConnection Connection{get; private set;}

        public void Connect(string databaseFile)
        {
            Connection = new SQLiteConnection(string.Format("Data Source={0}", databaseFile));
            Connection.Open();
        }

        public int GetLastInsertId()
        {
            SQLiteCommand command = new SQLiteCommand("SELECT last_insert_rowid()", Database.Instance.Connection);
            return Convert.ToInt32(command.ExecuteScalar());
        } 
    }
}
