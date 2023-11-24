using System.Data.SqlClient;

namespace MyWinForm
{
    public partial class Form1 : Form
    {
        private readonly string conStr = @"Server=221-P\MSSQLSERVER11;Database=SEP_222;User Id=admin;Password=1234;";
        public Form1()
        {
            InitializeComponent();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            using (SqlConnection db = new SqlConnection(conStr))
            {
                db.Open();
                using (SqlCommand cmd = new SqlCommand("pStaffInfo", db))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@company_name", tbCompany.Text);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dt.Load(cmd.ExecuteReader());
                    gvInfo.DataSource = dt;
                }
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            fmAddEdit form = new fmAddEdit();
            form.Show();
        }
    }
}