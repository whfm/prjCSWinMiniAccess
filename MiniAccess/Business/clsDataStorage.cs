using DAO;
using System.Collections.Generic;

namespace MiniAccess
{
    /* 
    Data storage public class
    */
    public class clsDataStorage
    {
        public static DBEngine dbe = new DBEngine();
        public static Database db;
        public static List<string> tableNames = new List<string>();
        public static bool status;
    }
}
