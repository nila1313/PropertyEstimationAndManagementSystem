using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PropertyEstimationAndManagementSystem.Data;
using PropertyEstimationAndManagementSystem.Entites;
using PropertyEstimationAndManagementSystem.GuiForms;


namespace PropertyEstimationAndManagementSystem.GuiForms.ManagerGui
{
    public partial class InsertEmployee : Form
    {

        DataAccess da;
        Users user { get; set; }

        public InsertEmployee()
        {
            //this.users = users;
            //this.login = login;
            InitializeComponent();
            da = new DataAccess();
            user = new Users();
        }
      

        private void InsertEmployee_Load(object sender, EventArgs e)
        {
            ShowUsers.DataSource = da.Execute("select Employee.Id,FirstName,LastName,UserName,UserPassword from Employee inner join Users on Employee.Id=Users.Id;");
            ShowUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.ShowUsers.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
            this.ShowUsers.DefaultCellStyle.BackColor = Color.FromArgb(36, 36, 36);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ShowUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = ShowUsers.SelectedRows[0] as DataGridViewRow;
                user.UserName = row.Cells[1].Value.ToString();
                user.UserPassword = row.Cells[0].Value.ToString();
                //user.UserType = row.Cells[1].Value.ToString();
               
            }
            catch (Exception eae)
            {
                MessageBox.Show("Please select a row");
            }

        }

        public void showUserList()
        
        {          
            ShowUsers.DataSource = da.GetData<Users>("");
            ShowUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

     
    }
}
