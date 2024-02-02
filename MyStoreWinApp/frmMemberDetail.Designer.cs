namespace MyStoreWinApp
{
    partial class frmMemberDetail
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbConfirm = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(487, 379);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(282, 379);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(307, 76);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(229, 41);
            this.lbTitle.TabIndex = 41;
            this.lbTitle.Text = "Member Detail";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(586, 307);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PlaceholderText = "Confirm Password";
            this.txtConfirm.Size = new System.Drawing.Size(225, 27);
            this.txtConfirm.TabIndex = 40;
            this.txtConfirm.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(586, 259);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Enter Password";
            this.txtPassword.Size = new System.Drawing.Size(225, 27);
            this.txtPassword.TabIndex = 39;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lbConfirm
            // 
            this.lbConfirm.AutoSize = true;
            this.lbConfirm.Location = new System.Drawing.Point(495, 307);
            this.lbConfirm.Name = "lbConfirm";
            this.lbConfirm.Size = new System.Drawing.Size(62, 20);
            this.lbConfirm.TabIndex = 38;
            this.lbConfirm.Text = "Confirm";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(487, 262);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(70, 20);
            this.lbPassword.TabIndex = 37;
            this.lbPassword.Text = "Password";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(586, 215);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.PlaceholderText = "Enter Country";
            this.txtCountry.Size = new System.Drawing.Size(225, 27);
            this.txtCountry.TabIndex = 36;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(586, 167);
            this.txtCity.Name = "txtCity";
            this.txtCity.PlaceholderText = "Enter City";
            this.txtCity.Size = new System.Drawing.Size(225, 27);
            this.txtCity.TabIndex = 35;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(161, 262);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Enter Email";
            this.txtEmail.Size = new System.Drawing.Size(225, 27);
            this.txtEmail.TabIndex = 34;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(161, 218);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.PlaceholderText = "Enter Name";
            this.txtMemberName.Size = new System.Drawing.Size(225, 27);
            this.txtMemberName.TabIndex = 33;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(161, 170);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.PlaceholderText = "Enter ID";
            this.txtMemberID.ReadOnly = true;
            this.txtMemberID.Size = new System.Drawing.Size(225, 27);
            this.txtMemberID.TabIndex = 32;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(497, 218);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(60, 20);
            this.lbCountry.TabIndex = 31;
            this.lbCountry.Text = "Country";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(523, 170);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(34, 20);
            this.lbCity.TabIndex = 30;
            this.lbCity.Text = "City";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(93, 262);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 20);
            this.lbEmail.TabIndex = 29;
            this.lbEmail.Text = "Email";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(30, 218);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(109, 20);
            this.lbName.TabIndex = 28;
            this.lbName.Text = "Member Name";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(55, 170);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(84, 20);
            this.lbID.TabIndex = 27;
            this.lbID.Text = "Member ID";
            // 
            // frmMemberDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 466);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbConfirm);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbID);
            this.Name = "frmMemberDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Detail";
            this.Load += new System.EventHandler(this.frmMemberDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private Label lbTitle;
        private TextBox txtConfirm;
        private TextBox txtPassword;
        private Label lbConfirm;
        private Label lbPassword;
        private TextBox txtCountry;
        private TextBox txtCity;
        private TextBox txtEmail;
        private TextBox txtMemberName;
        private TextBox txtMemberID;
        private Label lbCountry;
        private Label lbCity;
        private Label lbEmail;
        private Label lbName;
        private Label lbID;
    }
}