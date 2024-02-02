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
    //delegate
    delegate List<MemberObject> SearchMember(List<MemberObject> list);
    delegate List<MemberObject> FilterMember(List<MemberObject> list);

    public partial class frmMemberManagement : Form
    {
        private bool isDescending;
        private SearchMember searchMember;
        private FilterMember filterMember;

        public IMemberRepository MemberRepository { get; set; }
        public MemberObject CurrentMember { get; set; }

        public frmMemberManagement()
        {
            isDescending = false;
            InitializeComponent();
        }

        //get all - city
        private List<string> GetAllCity()
        {
            return MemberRepository.GetListAllMember().Select(mem => mem.City).Distinct().ToList();
        }

        //get all - country
        private List<string> GetAllCountry()
        {
            return MemberRepository.GetListAllMember().Select(mem => mem.Country).Distinct().ToList();
        }

        //load data
        private void LoadData()
        {
            lvData.Items.Clear();
            ClearDetails();
            List<MemberObject> list = MemberRepository.GetListAllMember(isDescending);
            list = searchMember(list);
            list = filterMember(list);
            foreach (MemberObject member in list)
            {
                ListViewItem item = new()
                {
                    Text = member.MemberID.ToString(),
                    SubItems = {
                        member.MemberName,
                        member.Email,
                        member.City,
                        member.Country
                    }
                };
                item.Tag = member;
                lvData.Items.Add(item);
            }
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            cbSearchType.SelectedIndex = 0;
            cbFilterType.SelectedIndex = 0;
        }

        //filter
        private void cbFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> valueList = null;

            switch (cbFilterType.SelectedIndex)
            {
                case 0:
                    {
                        valueList = GetAllCity();
                        filterMember = list =>
                        {
                            if (cbFilter.SelectedIndex == 0)
                            {
                                return list;
                            }

                            return MemberRepository.FilterByCity(cbFilter.Text, list);
                        };
                        break;
                    }
                case 1:
                    {
                        valueList = GetAllCountry();
                        filterMember = list =>
                        {
                            if (cbFilter.SelectedIndex == 0)
                            {
                                return list;
                            }

                            return MemberRepository.FilterByCountry(cbFilter.Text, list);
                        };
                        break;
                    }
            }

            cbFilter.Items.Clear();
            cbFilter.Items.Add("All");
            if (valueList != null)
            {
                cbFilter.Items.AddRange(valueList.ToArray());
            }

            cbFilter.SelectedIndex = 0;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e) => LoadData();

        //search
        private void cbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbSearchType.SelectedIndex)
            {
                case 0:
                    {
                        searchMember = list =>
                        {
                            if (string.IsNullOrWhiteSpace(txtSearch.Text))
                            {
                                return list;
                            }

                            int searchID;
                            if (int.TryParse(txtSearch.Text, out searchID))
                            {
                                return MemberRepository.SearchMemberByID(searchID, list);
                            }

                            return new List<MemberObject>();
                        };
                        break;
                    }
                case 1:
                    {
                        searchMember = list =>
                        {
                            if (string.IsNullOrWhiteSpace(txtSearch.Text))
                            {
                                return list;
                            }

                            return MemberRepository.SearchMemberByName(txtSearch.Text, list);
                        };
                        break;
                    }
            }

            txtSearch.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) => LoadData();

        private void ClearDetails()
        {
            txtID.Text = String.Empty;
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        //list view
        private void lvData_SelectedIndexChanged(object sender, EventArgs e)
        {
            var items = lvData.SelectedItems;
            if (items.Count > 0)
            {
                MemberObject member = items[0].Tag as MemberObject;
                txtID.Text = member.MemberID.ToString();
                txtName.Text = member.MemberName;
                txtEmail.Text = member.Email;
                txtCity.Text = member.City;
                txtCountry.Text = member.Country;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                ClearDetails();
            }
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            MemberObject newMember = new();
            frmMemberDetail formMemberDetail = new()
            {
                MemberRepository = this.MemberRepository,
                IsUpdate = false
            };
            formMemberDetail.ShowDialog();
            LoadData();
            cbSearchType_SelectedIndexChanged(null, null);
            cbFilterType_SelectedIndexChanged(null, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var items = lvData.SelectedItems;
            if (items.Count > 0)
            {
                MemberObject member = items[0].Tag as MemberObject;
                frmMemberDetail formMemberDetail = new()
                {
                    MemberRepository = this.MemberRepository,
                    CurrentMember = member,
                    IsUpdate = true,
                    IsAdmin = true,
                };
                if (formMemberDetail.ShowDialog() == DialogResult.OK)
                {
                    items[0].SubItems.Clear();
                    items[0].Text = member.MemberID.ToString();
                    items[0].SubItems.AddRange(
                        new[] {
                            member.MemberName,
                            member.Email,
                            member.City,
                            member.Country
                        }
                    );
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var items = lvData.SelectedItems;
            if (items.Count > 0)
            {
                MemberObject member = items[0].Tag as MemberObject;
                if (CurrentMember.MemberID == member.MemberID)
                {
                    MessageBox.Show(
                        "You cannot delete yourself",
                        "Delete error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                if (MessageBox.Show(
                        $"Are you sure to delete {member.MemberName}",
                        "Delete confirm",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation
                    ) == DialogResult.Yes)
                {
                    MemberRepository.DeleteMember(member.MemberID);
                    lvData.Items.Remove(items[0]);
                }
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            isDescending = !isDescending;
            btnSort.Text = isDescending ? "Ascending" : "Descending";
            LoadData();
        }
    }
}
