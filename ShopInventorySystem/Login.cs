using ShopInventorySystem.Data;
using ShopInventorySystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopInventorySystem
{
    public partial class Login : Form
    {
        EmployeeServices employeeServices = new EmployeeServices();
        public static int id;
        Dashboard dashboard = new Dashboard();

        public Login()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        public void LoginCheck()
        {
            List<Employee> employeeList = new List<Employee>();
            employeeList = employeeServices.EmployeeLogIn(txtEmployeeId.Text);
            if(employeeList.Any())
            {
                foreach (Employee employee in employeeList)
                {
                    if (txtPassword.Text == employee.Password)
                    {
                        id = employee.EmployeeId;
                        dashboard.lblUserName.Text = employee.EmployeeName.ToString();
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        txtPassword.Clear();
                        MessageBox.Show("Please enter a valid combination of ID and Password");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid ID");
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoginCheck();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
