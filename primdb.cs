using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    internal class primdb
    {



        public static int[] usersArray = new int[] { 90000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000, 10000 };
        private const string fileName = "usersData.txt";

        public static void UpdateUsersArray(int[] newUserArray)
        {
            usersArray = newUserArray;
            SaveDataToFile(usersArray);
        }

        public static int[] LoadUsersArray()
        {
            if (File.Exists(fileName))
            {
                string[] data = File.ReadAllLines(fileName);
                return Array.ConvertAll(data, int.Parse);
            }
            return usersArray;
        }

        private static void SaveDataToFile(int[] data)
        {
            string[] stringData = Array.ConvertAll(data, x => x.ToString());
            File.WriteAllLines(fileName, stringData);
        }
    }

}
