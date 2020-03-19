using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        /// <summary>
        /// Connections created in GlobalConfig class.
        /// Only the methods in this class can configure the connections 
        /// But all others can retreive the inforamtions for the connections.
        /// </summary>
        public static IDataConnection Connection { get; private set; }
        
        // Read the above line as Connections will hold anything that implements the IDataConnection contract.

        /// <summary>
        /// Method to initialize database and or textFile connections.
        /// Can be scaled in the future but for now only limited to database 
        /// and text file connections.
        /// </summary>
        /// <param name="database">True/False</param>
        /// <param name="textFiles">True/False</param>
        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                SQLConnector sql = new SQLConnector();
                Connection = sql;
            }
            else if(db == DatabaseType.TextFile)
            {
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
