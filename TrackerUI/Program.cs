using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize the database connections
            TrackerLibrary.GlobalConfig.InitializeConnections(DatabaseType.Sql);

            // Testing Create Prize Form
           //Application.Run(new CreatePrizeForm());

            // Testing Create Team Form
            //Application.Run(new CreateTeamForm());

            // Testing Create Tournament Form
            Application.Run(new CreateTournamentForm());

            // Testing Create  Form
            //Application.Run(new CreateTeamForm());


            //Application.Run(new TournamentDashboardForm());
        }
    }
}
