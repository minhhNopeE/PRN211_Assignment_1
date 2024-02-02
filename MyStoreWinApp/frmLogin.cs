using BusinessObject;
using DataAccess.Repository;
using System;
using System.Windows.Forms;

namespace MyStoreWinApp {
	public partial class frmLogin : Form {
		public IMemberRepository MemberRepository { get; set; }

		public frmLogin() {
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e) {
			string email = txtEmail.Text.Trim();
			string password = txtPassword.Text.Trim();
			MemberObject member = MemberRepository.GetMemberByEmailAndPassword(email, password);
			if (member != null) {
				this.Hide();
				if (member.Email.Equals("admin@fstore.com")) {
					frmMemberManagement memberManagement = new() {
						MemberRepository = this.MemberRepository,
						CurrentMember = member
					};
					memberManagement.ShowDialog();
				}
				else {
					frmMemberDetail memberDetail = new() {
						MemberRepository = this.MemberRepository,
						CurrentMember = member,
						IsUpdate = true,
						IsAdmin = false,
					};
					memberDetail.ShowDialog();
				}

				this.Show();
			}
			else {
				MessageBox.Show("Incorrect email or password", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void toggleLogin() {
			string email = txtEmail.Text.Trim();
			string password = txtPassword.Text.Trim();
			if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password)) {
				btnLogin.Enabled = false;
			}
			else {
				btnLogin.Enabled = true;
			}
		}

		private void txtEmail_TextChanged(object sender, EventArgs e) => toggleLogin();

		private void frmLogin_Load(object sender, EventArgs e) {
			txtEmail.Text = "admin@fstore.com";
			txtPassword.Text = "admin@@";
			// btnLogin.Enabled = false;
		}

		private void txtPassword_TextChanged(object sender, EventArgs e) => toggleLogin();

		private void btnClose_Click(object sender, EventArgs e) => Close();
	}
}