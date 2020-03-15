using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        /// <summary>
        /// Connections created in GlobalConfig class.
        /// Only the methods in this class can configure the connections 
        /// But all others can retreive the inforamtions for the connections.
        /// </summary>
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        
        // Read the above line as Connections will hold anything that implements the IDataConnection contract.

        /// <summary>
        /// Method to initialize database and or textFile connections.
        /// Can be scaled in the future but for now only limited to database 
        /// and text file connections.
        /// </summary>
        /// <param name="database">True/False</param>
        /// <param name="textFiles">True/False</param>
        public static void InitializeConnections(bool database,bool textFiles)
        {
            if (database)
            {
                // TODO - Set up the SQL Connector properly
                SQLConnector sql = new SQLConnector();
                Connections.Add(sql);
            }

            if(textFiles)
            {
                // TODO - Set up the Text Connector Properly
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }
        }
    }
}
