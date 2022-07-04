using BusinessObject;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmMembers : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;
        public frmMembers()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadMemberList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            LoadMemberList();
        }

        private void btnBack_Click(object sender, EventArgs e) => Close();

        private void ClearText()
        {
            txtMemberID.Text = string.Empty;
            txtGmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtCompany.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
        }

        public void LoadMemberList()
        {
            var members = memberRepository.GetMembers();
            try
            {
                source = new BindingSource();
                source.DataSource = members;

                txtMemberID.DataBindings.Clear();
                txtGmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCompany.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtGmail.DataBindings.Add("Text", source, "Email");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtCountry.DataBindings.Add("Text", source, "Country");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCompany.DataBindings.Add("Text", source, "CompanyName");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
                if (members.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }
    }
}
