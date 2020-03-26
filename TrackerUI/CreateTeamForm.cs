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
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        ITeamRequester callingForm;

        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();

            // TODO : Comment it after Testing
            // Testing out the forms by inserting a sample data.
            // CreateSampleData();
            callingForm = caller;

            // Finally wire up the form.
            WireUpLists();
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Saurabh", LastName = "Mankar" });
            availableTeamMembers.Add(new PersonModel { FirstName = "EPJ", LastName = "Morgan" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Soham", LastName = "Nagawanshi" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Abhishek", LastName = "Kokate" });
        }

        private void WireUpLists()
        {
            // TODO : Find a better way to refresh selectTeamMemberDropDown
            // By assigning it null then assigning it value makes sure you don't come across refresh issues.
            // Check Reference : Video 13 (https://youtu.be/QTdfiZpoabk) Time 30:56 onwards
            selectTeamMemberDropDown.DataSource = null;
            
            // Sort List before assigning it back to the dropdown so it looks neat
            // Using the comparison signature of the Sort method
            // passing on a tuple for comparing the objects based on fullname
            availableTeamMembers.Sort((p,q) => p.FullName.CompareTo(q.FullName));

            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            // TODO : Find a better way to refresh teamMembersListBox
            // By assigning it null then assigning it value makes sure you don't come across refresh issues.
            // Check Reference : Video 13 (https://youtu.be/QTdfiZpoabk) Time 30:56 onwards
            teamMembersListBox.DataSource = null;

            // Sort List before assigning it back to the dropdown so it looks neat
            // Using the comparison signature of the Sort method
            // passing on a tuple for comparing the objects based on fullname
            selectedTeamMembers.Sort((p, q) => p.FullName.CompareTo(q.FullName));

            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            
            if (!ValidateForm())
            {
                MessageBox.Show("You need to fill in all the fields.");
            }
            else
            {
                PersonModel p = new PersonModel();
                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.CellphoneNumber = cellphoneValue.Text;

                p = GlobalConfig.Connection.CreatePerson(p);
                selectedTeamMembers.Add(p);
                
                WireUpLists();


                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "";
            }
        }

        private void ResetForm()
        {
            firstNameValue.Text = "";
            lastNameValue.Text = "";
            emailValue.Text = "";
            cellphoneValue.Text = "";
            teamNameValue.Text = "";
        }

        private bool ValidateForm()
        {

            // All the form fields are mandatory.
            if (firstNameValue.Text.Length == 0)
            {
                return false;
            }

            if (lastNameValue.Text.Length == 0)
            {
                return false;
            }

            if (emailValue.Text.Length == 0)
            {
                return false;
            }

            if (cellphoneValue.Text.Length == 0)
            {
                return false;
            }


            return true;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            // The Selected Item in the selectTeamMemberDropDown needs to be added to 
            // teamMembersListBox and then remove it from drop down.

            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Add(p);
                availableTeamMembers.Remove(p);
            }
            // Calling the method again to refresh the view.
            WireUpLists();
            
        }

        private void removeSelectedTeamMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);
            }

            WireUpLists();
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            if (teamNameValue.Text == "")
            {
                MessageBox.Show("You need to enter a team name.");
            }
            else
            {
                TeamModel t = new TeamModel();

                t.TeamName = teamNameValue.Text;
                t.TeamMembers = selectedTeamMembers;

                GlobalConfig.Connection.CreateTeam(t);

                callingForm.TeamComplete(t);
                
                this.Close();
            }
        }
    }
}
