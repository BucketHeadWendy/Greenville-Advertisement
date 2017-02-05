//Dan Plummer & Derek West
//CIS 2620-75 
//Chapter 12, Case Problem 1
//2/5/2017

//Notes:  My thought process is that the majority of the form will stay hidden until a user clicks the appropriate control.
//If they answer they are not 18, the ineligible form will pop up, if they answer yes they are 18 the next question will appear.
//If they check any of the health condition boxes, the ineligible form will pop up, if they select the None box, then next question 
//will appear. They then select if they are a new contestant or a returning contestant, they get the appropriate button 
//depending on what they choose, and that button will either take them to the returning contestant form or the new constestant
//form.  Feel free to change anything you want, I didn't really style it.   

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleAdvertisement
{
    public partial class GreenvilleAdvertisementForm : Form
    {
        public GreenvilleAdvertisementForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void GreenvilleAdvertisementForm_Load(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (diabetesCheckBox.Checked)
            {
                IneligibleForm ineligibleForm = new IneligibleForm();
                ineligibleForm.ShowDialog();
            }

            if (heartConditionCheckBox.Checked)
            {
                IneligibleForm ineligibleForm = new IneligibleForm();
                ineligibleForm.ShowDialog();
            }

            if (bloodClotsCheckBox.Checked)
            {
                IneligibleForm ineligibleForm = new IneligibleForm();
                ineligibleForm.ShowDialog();
            }

            if (noneCheckBox.Checked)
            {
                if (newContestantRadioButton.Checked)
                {
                    NewForm newForm = new NewForm();
                    newForm.ShowDialog();
                }

                if (returningContestantRadioButton.Checked)
                {
                    ReturningForm returningForm = new ReturningForm();
                    returningForm.ShowDialog();
                }
            }
        }

        private void ageYesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            conditionsLabel.Text = "Do you currently have any of the below conditions?";
            conditionsLabel.Visible = true;
            diabetesCheckBox.Visible = true;
            heartConditionCheckBox.Visible = true;
            bloodClotsCheckBox.Visible = true;
            noneCheckBox.Visible = true;
            newContestantRadioButton.Visible = true;
            returningContestantRadioButton.Visible = true;
            submitButton.Visible = true;
        }

        private void ageNoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            conditionsLabel.Text = "We're sorry, but you are currently too young to enter in \nthis year's race.";
            conditionsLabel.Visible = true;
            diabetesCheckBox.Visible = false;
            heartConditionCheckBox.Visible = false;
            bloodClotsCheckBox.Visible = false;
            noneCheckBox.Visible = false;
            newContestantRadioButton.Visible = false;
            returningContestantRadioButton.Visible = false;
            submitButton.Visible = false;
        }
    }
}
