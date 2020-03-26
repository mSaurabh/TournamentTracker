using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form,IPrizeRequester,ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public CreateTournamentForm()
        {
            InitializeComponent();
            InitializeLists();
            // Finally wire up the form.
            WireUpLists();
        }

        private void InitializeLists()
        {
            selectTeamDropDown.DataSource = availableTeams;
            selectTeamDropDown.DisplayMember = "TeamName";

            tournamentTeamsListBox.DataSource = selectedTeams;
            tournamentTeamsListBox.DisplayMember = "TeamName";

            prizeListBox.DataSource = selectedPrizes;
            prizeListBox.DisplayMember = "PlaceName";
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            // The Selected Item in the selectTeamDropDown needs to be added to 
            // tournamentTeamsListBox and then remove it from drop down.

            TeamModel t = (TeamModel)selectTeamDropDown.SelectedItem;

            if (t != null)
            {
                selectedTeams.Add(t);
                availableTeams.Remove(t);
            }
            // Calling the method again to refresh the view.
            WireUpLists();
        }

        private void WireUpLists()
        {
            // TODO : Find a better way to refresh selectTeamDropDown
            // By assigning it null then assigning it value makes sure you don't come across refresh issues.
            // Check Reference : Video 13 (https://youtu.be/QTdfiZpoabk) Time 30:56 onwards
            selectTeamDropDown.DataSource = null;

            // Sort List before assigning it back to the dropdown so it looks neat
            // Using the comparison signature of the Sort method
            // passing on a tuple for comparing the objects based on fullname
            availableTeams.Sort((p, q) => p.TeamName.CompareTo(q.TeamName));

            selectTeamDropDown.DataSource = availableTeams;
            selectTeamDropDown.DisplayMember = "TeamName";

            // TODO : Find a better way to refresh teamMembersListBox
            // By assigning it null then assigning it value makes sure you don't come across refresh issues.
            // Check Reference : Video 13 (https://youtu.be/QTdfiZpoabk) Time 30:56 onwards
            tournamentTeamsListBox.DataSource = null;

            // Sort List before assigning it back to the dropdown so it looks neat
            // Using the comparison signature of the Sort method
            // passing on a tuple for comparing the objects based on fullname
            selectedTeams.Sort((p, q) => p.TeamName.CompareTo(q.TeamName));

            tournamentTeamsListBox.DataSource = selectedTeams;
            tournamentTeamsListBox.DisplayMember = "TeamName";

            prizeListBox.DataSource = null;
            prizeListBox.DataSource = selectedPrizes;
            prizeListBox.DisplayMember = "PlaceName";
        }

        private void removeSelectedPlayerButton_Click(object sender, EventArgs e)
        {
           TeamModel t = (TeamModel)tournamentTeamsListBox.SelectedItem;

            if (t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);
            }

            WireUpLists();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            // Call the Create prize form.
            // "this" keyword represents this specific form instance.
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();

            
            
        }

        public void PrizeComplete(PrizeModel model)
        {
            // Check Youtube Reference : https://www.youtube.com/watch?v=rS734DJL6zM&t=255s 
            // Get back from the form prize model.
            // Take that prize model and put it in the selected prizes
            selectedPrizes.Add(model);
            
            //Refresh List once the prize is created.
            WireUpLists();
        }

        private void removeSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)prizeListBox.SelectedItem;
            if (p != null)
            {
                selectedPrizes.Remove(p);
            }

            WireUpLists();
            
        }

        private void createNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }
        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }

     
    }
}
