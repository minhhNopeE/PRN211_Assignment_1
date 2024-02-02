namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            this.lbSort = new System.Windows.Forms.Label();
            this.chCountry = new System.Windows.Forms.ColumnHeader();
            this.chCity = new System.Windows.Forms.ColumnHeader();
            this.chEmail = new System.Windows.Forms.ColumnHeader();
            this.chMemberName = new System.Windows.Forms.ColumnHeader();
            this.chMemberID = new System.Windows.Forms.ColumnHeader();
            this.btnSort = new System.Windows.Forms.Button();
            this.lvData = new System.Windows.Forms.ListView();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.cbFilterType = new System.Windows.Forms.ComboBox();
            this.lbFilter = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbSearchType = new System.Windows.Forms.ComboBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSort
            // 
            this.lbSort.AutoSize = true;
            this.lbSort.Location = new System.Drawing.Point(844, 297);
            this.lbSort.Name = "lbSort";
            this.lbSort.Size = new System.Drawing.Size(36, 20);
            this.lbSort.TabIndex = 43;
            this.lbSort.Text = "Sort";
            // 
            // chCountry
            // 
            this.chCountry.Text = "Country";
            this.chCountry.Width = 150;
            // 
            // chCity
            // 
            this.chCity.Text = "City";
            this.chCity.Width = 150;
            // 
            // chEmail
            // 
            this.chEmail.Text = "Email";
            this.chEmail.Width = 240;
            // 
            // chMemberName
            // 
            this.chMemberName.Text = "Name";
            this.chMemberName.Width = 240;
            // 
            // chMemberID
            // 
            this.chMemberID.Text = "ID";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(887, 293);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(109, 29);
            this.btnSort.TabIndex = 42;
            this.btnSort.Text = "Descending";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lvData
            // 
            this.lvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chMemberID,
            this.chMemberName,
            this.chEmail,
            this.chCity,
            this.chCountry});
            this.lvData.FullRowSelect = true;
            this.lvData.Location = new System.Drawing.Point(41, 337);
            this.lvData.Name = "lvData";
            this.lvData.Size = new System.Drawing.Size(982, 307);
            this.lvData.TabIndex = 41;
            this.lvData.UseCompatibleStateImageBehavior = false;
            this.lvData.View = System.Windows.Forms.View.Details;
            this.lvData.SelectedIndexChanged += new System.EventHandler(this.lvData_SelectedIndexChanged);
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "All"});
            this.cbFilter.Location = new System.Drawing.Point(790, 250);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(139, 28);
            this.cbFilter.TabIndex = 40;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // cbFilterType
            // 
            this.cbFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterType.FormattingEnabled = true;
            this.cbFilterType.Items.AddRange(new object[] {
            "City",
            "Country"});
            this.cbFilterType.Location = new System.Drawing.Point(664, 250);
            this.cbFilterType.Name = "cbFilterType";
            this.cbFilterType.Size = new System.Drawing.Size(120, 28);
            this.cbFilterType.TabIndex = 39;
            this.cbFilterType.SelectedIndexChanged += new System.EventHandler(this.cbFilterType_SelectedIndexChanged);
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.Location = new System.Drawing.Point(614, 253);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(42, 20);
            this.lbFilter.TabIndex = 38;
            this.lbFilter.Text = "Filter";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(325, 250);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Enter Id/Name...";
            this.txtSearch.Size = new System.Drawing.Size(162, 27);
            this.txtSearch.TabIndex = 37;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cbSearchType
            // 
            this.cbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchType.FormattingEnabled = true;
            this.cbSearchType.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.cbSearchType.Location = new System.Drawing.Point(199, 249);
            this.cbSearchType.Name = "cbSearchType";
            this.cbSearchType.Size = new System.Drawing.Size(120, 28);
            this.cbSearchType.TabIndex = 36;
            this.cbSearchType.SelectedIndexChanged += new System.EventHandler(this.cbSearchType_SelectedIndexChanged);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(120, 252);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(73, 20);
            this.lbSearch.TabIndex = 35;
            this.lbSearch.Text = "Search By";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(664, 196);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(501, 196);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(329, 196);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 29);
            this.btnNew.TabIndex = 32;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(664, 102);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.Size = new System.Drawing.Size(225, 27);
            this.txtCountry.TabIndex = 31;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(664, 54);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(225, 27);
            this.txtCity.TabIndex = 30;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(262, 146);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(225, 27);
            this.txtEmail.TabIndex = 29;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(262, 102);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(225, 27);
            this.txtName.TabIndex = 28;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(262, 54);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(225, 27);
            this.txtID.TabIndex = 27;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(596, 102);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(60, 20);
            this.lbCountry.TabIndex = 26;
            this.lbCountry.Text = "Country";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(596, 54);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(34, 20);
            this.lbCity.TabIndex = 25;
            this.lbCity.Text = "City";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(194, 153);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 20);
            this.lbEmail.TabIndex = 24;
            this.lbEmail.Text = "Email";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(131, 102);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(109, 20);
            this.lbName.TabIndex = 23;
            this.lbName.Text = "Member Name";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(156, 54);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(84, 20);
            this.lbID.TabIndex = 22;
            this.lbID.Text = "Member ID";
            // 
            // frmMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 669);
            this.Controls.Add(this.lbSort);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lvData);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.cbFilterType);
            this.Controls.Add(this.lbFilter);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbSearchType);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbID);
            this.Name = "frmMemberManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Management";
            this.Load += new System.EventHandler(this.frmMemberManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbSort;
        private ColumnHeader chCountry;
        private ColumnHeader chCity;
        private ColumnHeader chEmail;
        private ColumnHeader chMemberName;
        private ColumnHeader chMemberID;
        private Button btnSort;
        private ListView lvData;
        private ComboBox cbFilter;
        private ComboBox cbFilterType;
        private Label lbFilter;
        private TextBox txtSearch;
        private ComboBox cbSearchType;
        private Label lbSearch;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnNew;
        private TextBox txtCountry;
        private TextBox txtCity;
        private TextBox txtEmail;
        private TextBox txtName;
        private TextBox txtID;
        private Label lbCountry;
        private Label lbCity;
        private Label lbEmail;
        private Label lbName;
        private Label lbID;
    }
}