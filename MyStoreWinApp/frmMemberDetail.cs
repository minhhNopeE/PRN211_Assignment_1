using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmMemberDetail : Form
    {
        public IMemberRepository MemberRepository { get; set; }
        public MemberObject CurrentMember { get; set; }
        public bool IsUpdate { get; set; }
        public bool IsAdmin { get; set; }

        public frmMemberDetail()
        {
            InitializeComponent();
        }

        private void frmMemberDetail_Load(object sender, EventArgs e)
        {
            if (IsAdmin)
            {
                txtEmail.Enabled = false;
                txtPassword.Enabled = false;
                txtConfirm.Enabled = false;
            }

            if (IsUpdate)
            {
                txtMemberID.Text = CurrentMember.MemberID.ToString();
                txtMemberName.Text = CurrentMember.MemberName;
                txtEmail.Text = CurrentMember.Email;
                txtPassword.Text = CurrentMember.Password;
                txtConfirm.Text = CurrentMember.Password;
                txtCity.Text = CurrentMember.City;
                txtCountry.Text = CurrentMember.Country;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsUpdate)
            {
                if (txtPassword.Text.Equals(txtConfirm.Text))
                {
                    MemberObject newInfo = new()
                    {
                        MemberID = CurrentMember.MemberID,
                        MemberName = txtMemberName.Text,
                        Email = txtEmail.Text,
                        Password = txtPassword.Text,
                        City = txtCity.Text,
                        Country = txtCountry.Text
                    };
                    if (!newInfo.IsValid())
                    {
                        MessageBox.Show(
                            "Missing required infomation",
                            "Infomation error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        this.DialogResult = DialogResult.None;
                        return;
                    }

                    if (!newInfo.IsEmailValid())
                    {
                        MessageBox.Show(
                            "Invalid email",
                            "Email error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        this.DialogResult = DialogResult.None;
                        return;
                    }

                    if (newInfo != CurrentMember)
                    {
                        MemberRepository.UpdateMember(newInfo);
                        MessageBox.Show(
                            "Update successfully",
                            "Update status",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk
                        );
                    }
                    else
                    {
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Password and confirm password does not match",
                        "Save error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    this.DialogResult = DialogResult.None;
                }
            }
            else
            {
                if (txtPassword.Text.Equals(txtConfirm.Text))
                {
                    int maxID = 0;
                    foreach (MemberObject member in MemberRepository.GetListAllMember())
                    {
                        if (member.MemberID > maxID)
                        {
                            maxID = member.MemberID;
                        }
                    }

                    MemberObject newMember = new()
                    {
                        MemberID = maxID + 1,
                        MemberName = txtMemberName.Text,
                        Email = txtEmail.Text,
                        Password = txtPassword.Text,
                        City = txtCity.Text,
                        Country = txtCountry.Text
                    };

                    if (!newMember.IsValid())
                    {
                        MessageBox.Show(
                            "Missing required infomation",
                            "Infomation error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        this.DialogResult = DialogResult.None;
                        return;
                    }

                    if (!newMember.IsEmailValid())
                    {
                        MessageBox.Show(
                            "Invalid email",
                            "Email error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        this.DialogResult = DialogResult.None;
                        return;
                    }

                    MemberRepository.InsertMember(newMember);
                }
                else
                {
                    MessageBox.Show(
                        "Password and confirm password does not match",
                        "Save error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    this.DialogResult = DialogResult.None;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
