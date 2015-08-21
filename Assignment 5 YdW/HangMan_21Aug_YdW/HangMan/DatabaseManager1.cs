using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace HangMan
{
    public class DatabaseManager1
    {
        static string dbName = "HMData.sqlite";
        string dbPath = Path.Combine(Android.OS.Environment.ExternalStorageDirectory.ToString(), dbName);

        public DatabaseManager1()
        {
            Console.WriteLine(dbPath);
        }

        public List<MyWords> ViewAll()
        {
            try
            {
                using (var conn = new SQLite.SQLiteConnection(dbPath))
                {
                    var cmd = new SQLite.SQLiteCommand(conn);
                    cmd.CommandText = "Select *from MyWordBank";
                    var sb = cmd.ExecuteQuery<MyWords>();
                    return sb;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return null;
            }
        }


        //public List<ScoreBoard> ViewAll()
        //{
        //    try
        //    {
        //        using (var conn = new SQLite.SQLiteConnection(dbPath))
        //        {
        //            var cmd = new SQLite.SQLiteCommand(conn);
        //            cmd.CommandText = "Select *from ScoreBoard";
        //            var sb = cmd.ExecuteQuery<ScoreBoard>();
        //            return sb;
        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Error: " + e.Message);
        //        return null;
        //    }
        //}
    }
}