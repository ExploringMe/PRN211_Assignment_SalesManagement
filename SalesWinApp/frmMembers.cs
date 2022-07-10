using BusinessObject;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmMembers : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        IOrderRepository orderRepository = new OrderRepository();
        BindingSource source;
        public frmMembers()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var member = GetMemberObject();
            try
            {
                if (member != null)
                {
                    memberRepository.InsertMember(member);
                    LoadMemberList();
                    MessageBox.Show("Add new member successfully");
                }
                else
                {
                    MessageBox.Show("Add new member fail. Fill in the blank information box!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var member = GetMemberObject();

            try
            {
                member.MemberId = int.Parse(txtMemberID.Text);
                memberRepository.UpdateMember(member);
                LoadMemberList();
                MessageBox.Show("Update member successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update member fail. Select a member beside to update!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var memberID = int.Parse(txtMemberID.Text);
                orderRepository.DeleteOrderByMemberID(memberID);
                memberRepository.DeleteMember(memberID);
                LoadMemberList();
                txtMemberID.Clear();
                MessageBox.Show("Delete member successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete member fail. Select a member beside to delete!");
            }
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            LoadMemberList();
        }

        private void btnBack_Click(object sender, EventArgs e) => Close();

        private Member GetMemberObject()
        {
            Member member = null;
            try
            {
                member = new Member
                {
                    Email = txtGmail.Text,
                    CompanyName = txtCompany.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Password = txtPassword.Text,
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get member");
            }
            return member;
        }

        public void LoadMemberList()
        {
            var members = memberRepository.GetMembers();
            try
            {
                source = new BindingSource();
                source.DataSource = members;

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;

                dgvMemberList.Columns[0].Width = (int)(dgvMemberList.Width * 0.1);
                dgvMemberList.Columns[1].Width = (int)(dgvMemberList.Width * 0.19);
                dgvMemberList.Columns[2].Width = (int)(dgvMemberList.Width * 0.163);
                dgvMemberList.Columns[3].Width = (int)(dgvMemberList.Width * 0.163);
                dgvMemberList.Columns[4].Width = (int)(dgvMemberList.Width * 0.163);
                dgvMemberList.Columns[5].Width = (int)(dgvMemberList.Width * 0.163);
                dgvMemberList.Columns[6].Width = (int)(dgvMemberList.Width * 0);
                if (members.Count() == 0)
                {
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }

        private void dgvMemberList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvMemberList.Rows.Count - 1)
            {
                txtMemberID.Text = dgvMemberList.Rows[e.RowIndex].Cells["MemberID"].Value.ToString();
                txtGmail.Text = dgvMemberList.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                txtCompany.Text = dgvMemberList.Rows[e.RowIndex].Cells["CompanyName"].Value.ToString();
                txtCity.Text = dgvMemberList.Rows[e.RowIndex].Cells["City"].Value.ToString();
                txtCountry.Text = dgvMemberList.Rows[e.RowIndex].Cells["Country"].Value.ToString();
                txtPassword.Text = dgvMemberList.Rows[e.RowIndex].Cells["Password"].Value.ToString();
            }
        }
    }
}
