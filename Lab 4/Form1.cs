
 /// Author: Siddharth Choudhury
 /// Date: July 13, 2021
 /// Modified: August 1, 2021
 /// Title: Lab 4 NETD 2202
 /// Description: A contact tracer form where we can enter different people including there first and last name, number 
 ///               and whether or not they have been contacted.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class FormContactTracer : Form
    {
        public FormContactTracer()
        {
            InitializeComponent();
        }

        #region GLOBAL VARS
        List<Contact> Contacts = new List<Contact>();


        #endregion
        // Setting up the Reset button and clearing all controls after resetting form to its original state
        private void buttonReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
            dataGridViewContactList.Rows.Clear();
        }

        private void SetDefaults()
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            maskedTextBoxPhone.Clear();
            maskedTextBoxEmailAddress.Clear(); 
            checkBoxContacted.Checked = false;

        }


        // Setting up the Enter button
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxFirstName.Text))
            {
                labelOutput.Text = "Please enter your first name";
            }
            else if (String.IsNullOrEmpty(textBoxLastName.Text))
            {
                labelOutput.Text = "Please enter your last name";
            }
            else if (String.IsNullOrEmpty(maskedTextBoxEmailAddress.Text))
            {
                labelOutput.Text = "Please enter your email";
            }
            else if (String.IsNullOrEmpty(maskedTextBoxPhone.Text))
            {
                labelOutput.Text = "Please enter your phone number";
            }
            else
            { 
            GetStatus(textBoxFirstName.Text, textBoxLastName.Text, 
                 maskedTextBoxEmailAddress.Text, DateTime.Now, checkBoxContacted.Checked);
            }
        }

        private void GetStatus(String firstName, String lastName, String emailAddress, DateTime dateTime, Boolean contactStatus)
        {
            try
            {

                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridViewContactList);
                newRow.Cells[0].Value = contactStatus;
                newRow.Cells[1].Value = firstName;
                newRow.Cells[2].Value = lastName;
                newRow.Cells[3].Value = dateTime;
                newRow.Cells[4].Value = emailAddress;
                dataGridViewContactList.Rows.Add(newRow);
                SetDefaults();
            }
            catch 
            {
                MessageBox.Show("There were errors while running");
            }

        }



        // Setting up the Exit button to exit the application
        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
