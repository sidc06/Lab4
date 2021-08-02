
namespace Lab_4
{
    partial class FormContactTracer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelContacted = new System.Windows.Forms.Label();
            this.checkBoxContacted = new System.Windows.Forms.CheckBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridViewContactList = new System.Windows.Forms.DataGridView();
            this.columnContacted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskedTextBoxEmailAddress = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContactList)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.Location = new System.Drawing.Point(176, 22);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(85, 20);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name:";
            this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLastName
            // 
            this.labelLastName.Location = new System.Drawing.Point(176, 58);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(85, 20);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name:";
            this.labelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelEmail
            // 
            this.labelEmail.Location = new System.Drawing.Point(167, 101);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(115, 20);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email Address:";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPhone
            // 
            this.labelPhone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPhone.Location = new System.Drawing.Point(172, 139);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(115, 20);
            this.labelPhone.TabIndex = 6;
            this.labelPhone.Text = "Phone Number:";
            this.labelPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelContacted
            // 
            this.labelContacted.Location = new System.Drawing.Point(177, 171);
            this.labelContacted.Name = "labelContacted";
            this.labelContacted.Size = new System.Drawing.Size(87, 20);
            this.labelContacted.TabIndex = 9;
            this.labelContacted.Text = "Contacted?:";
            this.labelContacted.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxContacted
            // 
            this.checkBoxContacted.Location = new System.Drawing.Point(288, 172);
            this.checkBoxContacted.Name = "checkBoxContacted";
            this.checkBoxContacted.Size = new System.Drawing.Size(35, 25);
            this.checkBoxContacted.TabIndex = 10;
            this.checkBoxContacted.UseVisualStyleBackColor = true;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(288, 19);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(150, 27);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(288, 58);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(150, 27);
            this.textBoxLastName.TabIndex = 3;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(248, 453);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(95, 30);
            this.buttonEnter.TabIndex = 13;
            this.buttonEnter.Text = "&Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(351, 453);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(95, 30);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "&Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(460, 453);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(95, 30);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click_1);
            // 
            // labelOutput
            // 
            this.labelOutput.BackColor = System.Drawing.SystemColors.MenuBar;
            this.labelOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOutput.Location = new System.Drawing.Point(12, 367);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(542, 83);
            this.labelOutput.TabIndex = 12;
            // 
            // dataGridViewContactList
            // 
            this.dataGridViewContactList.AllowUserToAddRows = false;
            this.dataGridViewContactList.AllowUserToDeleteRows = false;
            this.dataGridViewContactList.AllowUserToResizeColumns = false;
            this.dataGridViewContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContactList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnContacted,
            this.columnFirstName,
            this.columnLastName,
            this.columnDate,
            this.columnEmail,
            this.columnPhone});
            this.dataGridViewContactList.Location = new System.Drawing.Point(12, 194);
            this.dataGridViewContactList.MultiSelect = false;
            this.dataGridViewContactList.Name = "dataGridViewContactList";
            this.dataGridViewContactList.ReadOnly = true;
            this.dataGridViewContactList.RowHeadersWidth = 51;
            this.dataGridViewContactList.RowTemplate.Height = 29;
            this.dataGridViewContactList.Size = new System.Drawing.Size(542, 170);
            this.dataGridViewContactList.TabIndex = 16;
            // 
            // columnContacted
            // 
            this.columnContacted.HeaderText = "Contacted";
            this.columnContacted.MinimumWidth = 6;
            this.columnContacted.Name = "columnContacted";
            this.columnContacted.ReadOnly = true;
            this.columnContacted.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnContacted.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnContacted.Width = 125;
            // 
            // columnFirstName
            // 
            this.columnFirstName.HeaderText = "First Name";
            this.columnFirstName.MinimumWidth = 6;
            this.columnFirstName.Name = "columnFirstName";
            this.columnFirstName.ReadOnly = true;
            this.columnFirstName.Width = 125;
            // 
            // columnLastName
            // 
            this.columnLastName.HeaderText = "Last Name";
            this.columnLastName.MinimumWidth = 6;
            this.columnLastName.Name = "columnLastName";
            this.columnLastName.ReadOnly = true;
            this.columnLastName.Width = 125;
            // 
            // columnDate
            // 
            this.columnDate.HeaderText = "Date";
            this.columnDate.MinimumWidth = 6;
            this.columnDate.Name = "columnDate";
            this.columnDate.ReadOnly = true;
            this.columnDate.Width = 125;
            // 
            // columnEmail
            // 
            this.columnEmail.HeaderText = "Email";
            this.columnEmail.MinimumWidth = 6;
            this.columnEmail.Name = "columnEmail";
            this.columnEmail.ReadOnly = true;
            this.columnEmail.Width = 125;
            // 
            // columnPhone
            // 
            this.columnPhone.HeaderText = "Phone";
            this.columnPhone.MinimumWidth = 6;
            this.columnPhone.Name = "columnPhone";
            this.columnPhone.ReadOnly = true;
            this.columnPhone.Width = 125;
            // 
            // maskedTextBoxEmailAddress
            // 
            this.maskedTextBoxEmailAddress.Location = new System.Drawing.Point(288, 101);
            this.maskedTextBoxEmailAddress.Name = "maskedTextBoxEmailAddress";
            this.maskedTextBoxEmailAddress.Size = new System.Drawing.Size(150, 27);
            this.maskedTextBoxEmailAddress.TabIndex = 5;
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(288, 139);
            this.maskedTextBoxPhone.Mask = "(999) 000-0000";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(150, 27);
            this.maskedTextBoxPhone.TabIndex = 7;
            // 
            // FormContactTracer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(562, 496);
            this.Controls.Add(this.maskedTextBoxPhone);
            this.Controls.Add(this.maskedTextBoxEmailAddress);
            this.Controls.Add(this.dataGridViewContactList);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.checkBoxContacted);
            this.Controls.Add(this.labelContacted);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormContactTracer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContactList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelContacted;
        private System.Windows.Forms.CheckBox checkBoxContacted;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridView dataGridViewContactList;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEmailAddress;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnContacted;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPhone;
    }
}

