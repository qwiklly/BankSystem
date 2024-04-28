using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    
    internal static class Program
    {

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitializeDatabase();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
        private static void InitializeDatabase()
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=MyDB.sqlite;Version=3;"))
            {
                conn.Open();

                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        id_user INTEGER PRIMARY KEY,
                        user_RUB INTEGER,
                        user_HKD INTEGER,
                        credit INTEGER,
                        deposit INTEGER
                    )";

                string insertDataQuery = @"
                    INSERT OR IGNORE INTO Users (id_user, user_RUB, user_HKD, credit, deposit)
                    VALUES 
                        (0, 10000, 0, 0, 0),
                        (1, 10000, 0, 0, 0),
                        (2, 10000, 0, 0, 0),
                        (3, 10000, 0, 0, 0),
                        (4, 10000, 0, 0, 0),
                        (5, 10000, 0, 0, 0),
                        (6, 10000, 0, 0, 0),
                        (7, 10000, 0, 0, 0),
                        (8, 10000, 0, 0, 0),
                        (9, 10000, 0, 0, 0)";

                using (SQLiteCommand cmd = new SQLiteCommand(createTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                using (SQLiteCommand cmd = new SQLiteCommand(insertDataQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
