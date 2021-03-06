﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// We moved the class files to their own folders.
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form 
    {
        // Reference 
        IPrizeRequester callingForm;
        public CreatePrizeForm(IPrizeRequester caller)
        {
            InitializeComponent();

            // caller is only within the constructor scope
            // to make it visible at class level we assign it to the local instance of IPrizeRequester
            callingForm = caller;
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                PrizeModel model = new PrizeModel(placeNameValue.Text,
                    placeNumberValue.Text,
                    prizeAmountValue.Text,
                    prizePercentageValue.Text);

                GlobalConfig.Connection.CreatePrize(model);
                callingForm.PrizeComplete(model);

                // Closing form instead of clearing all the fields
                this.Close();
                
                // Optional: Clearing the form once the create prize task was successful.
                //placeNameValue.Text = "";
                //placeNumberValue.Text = "";
                //prizeAmountValue.Text = "0";
                //prizePercentageValue.Text = "0";
            }
            else
            {
                // Error for invalid entries.
                MessageBox.Show("This form has invalid information. Please Check and try again.");
            }
        }

        /// <summary>
        /// Validates the form entries for Create Prize form.
        /// </summary>
        /// <returns>False if any of the form field value is invalid.</returns>
        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;

            bool placeNumberValid = int.TryParse(placeNumberValue.Text, out placeNumber);

            if (placeNumberValid == false)
            {
                output = false;
            }

            if(placeNumber <1)
            {
                output = false;
            }

            if(placeNameValue.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageValue.Text, out prizePercentage);

            if(prizeAmountValid == false || prizePercentageValid == false)
            {
                output = false;
            }
            if(prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }
            if(prizePercentage <0 || prizePercentage > 100)
            {
                output = false;
            }

            return output;
        }
    }
}