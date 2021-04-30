
namespace UserInterface
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupCalculate = new System.Windows.Forms.GroupBox();
            this.groupDatabase = new System.Windows.Forms.GroupBox();
            this.lblFirstNumber = new System.Windows.Forms.Label();
            this.lblLastNumber = new System.Windows.Forms.Label();
            this.numericFirstNumber = new System.Windows.Forms.NumericUpDown();
            this.numericLastNumber = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.lblUsers = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.groupCalculate.SuspendLayout();
            this.groupDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFirstNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLastNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // groupCalculate
            // 
            this.groupCalculate.Controls.Add(this.txtResults);
            this.groupCalculate.Controls.Add(this.label3);
            this.groupCalculate.Controls.Add(this.btnDivide);
            this.groupCalculate.Controls.Add(this.btnMultiply);
            this.groupCalculate.Controls.Add(this.btnSubtract);
            this.groupCalculate.Controls.Add(this.btnAdd);
            this.groupCalculate.Controls.Add(this.numericLastNumber);
            this.groupCalculate.Controls.Add(this.numericFirstNumber);
            this.groupCalculate.Controls.Add(this.lblLastNumber);
            this.groupCalculate.Controls.Add(this.lblFirstNumber);
            this.groupCalculate.Location = new System.Drawing.Point(12, 12);
            this.groupCalculate.Name = "groupCalculate";
            this.groupCalculate.Size = new System.Drawing.Size(359, 195);
            this.groupCalculate.TabIndex = 0;
            this.groupCalculate.TabStop = false;
            this.groupCalculate.Text = "Calculate Section";
            // 
            // groupDatabase
            // 
            this.groupDatabase.Controls.Add(this.btnAddPerson);
            this.groupDatabase.Controls.Add(this.txtLastName);
            this.groupDatabase.Controls.Add(this.txtFirstName);
            this.groupDatabase.Controls.Add(this.userComboBox);
            this.groupDatabase.Controls.Add(this.lblLastName);
            this.groupDatabase.Controls.Add(this.lblFirstName);
            this.groupDatabase.Controls.Add(this.lblUsers);
            this.groupDatabase.Location = new System.Drawing.Point(377, 12);
            this.groupDatabase.Name = "groupDatabase";
            this.groupDatabase.Size = new System.Drawing.Size(306, 195);
            this.groupDatabase.TabIndex = 0;
            this.groupDatabase.TabStop = false;
            this.groupDatabase.Text = "Database Section";
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.AutoSize = true;
            this.lblFirstNumber.Location = new System.Drawing.Point(18, 31);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(66, 13);
            this.lblFirstNumber.TabIndex = 0;
            this.lblFirstNumber.Text = "First Number";
            // 
            // lblLastNumber
            // 
            this.lblLastNumber.AutoSize = true;
            this.lblLastNumber.Location = new System.Drawing.Point(18, 58);
            this.lblLastNumber.Name = "lblLastNumber";
            this.lblLastNumber.Size = new System.Drawing.Size(67, 13);
            this.lblLastNumber.TabIndex = 1;
            this.lblLastNumber.Text = "Last Number";
            // 
            // numericFirstNumber
            // 
            this.numericFirstNumber.Location = new System.Drawing.Point(107, 29);
            this.numericFirstNumber.Name = "numericFirstNumber";
            this.numericFirstNumber.Size = new System.Drawing.Size(120, 20);
            this.numericFirstNumber.TabIndex = 2;
            // 
            // numericLastNumber
            // 
            this.numericLastNumber.Location = new System.Drawing.Point(107, 56);
            this.numericLastNumber.Name = "numericLastNumber";
            this.numericLastNumber.Size = new System.Drawing.Size(120, 20);
            this.numericLastNumber.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(21, 98);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(102, 98);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(75, 23);
            this.btnSubtract.TabIndex = 5;
            this.btnSubtract.Text = "Subtract";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(183, 98);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 23);
            this.btnMultiply.TabIndex = 6;
            this.btnMultiply.Text = "Multiply";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(264, 98);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 23);
            this.btnDivide.TabIndex = 7;
            this.btnDivide.Text = "Divide";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Results";
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(142, 146);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(100, 20);
            this.txtResults.TabIndex = 9;
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Location = new System.Drawing.Point(23, 31);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(34, 13);
            this.lblUsers.TabIndex = 0;
            this.lblUsers.Text = "Users";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(23, 58);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(23, 84);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // userComboBox
            // 
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(95, 28);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(121, 21);
            this.userComboBox.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(95, 55);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(121, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(95, 81);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(120, 144);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(75, 23);
            this.btnAddPerson.TabIndex = 6;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 226);
            this.Controls.Add(this.groupDatabase);
            this.Controls.Add(this.groupCalculate);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.groupCalculate.ResumeLayout(false);
            this.groupCalculate.PerformLayout();
            this.groupDatabase.ResumeLayout(false);
            this.groupDatabase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFirstNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLastNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupCalculate;
        private System.Windows.Forms.Label lblLastNumber;
        private System.Windows.Forms.Label lblFirstNumber;
        private System.Windows.Forms.GroupBox groupDatabase;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numericLastNumber;
        private System.Windows.Forms.NumericUpDown numericFirstNumber;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ComboBox userComboBox;
    }
}