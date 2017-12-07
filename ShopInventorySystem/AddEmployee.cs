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
   // public delegate void RefreshDelegate();
    public partial class AddEmployee : Form
    {
        Employee employee = new Employee();
        Dashboard dashboard = new Dashboard();
       // RefreshDelegate refreshDelegate;
        public AddEmployee()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtConPassword.PasswordChar = '*';
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.AddEmployees();
               // Dashboard dashboard = new Dashboard();
               // dashboard.RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill all the items");
            }
        }
#region method

        public void AddEmployees()
        {
            DateTime thisDay = DateTime.Today;
            string joinYear = thisDay.Year.ToString();
            string joinMonth = thisDay.Month.ToString();
            string joinDay = thisDay.Day.ToString();

            string birthYear = dateBirth.Value.Year.ToString();
            string birthMonth = dateBirth.Value.Month.ToString();
            string birthDay = dateBirth.Value.Day.ToString();

            employee.EmployeeName = txtName.Text;
            employee.Address = txtAddress.Text;
            employee.Phone = txtPhone.Text;
            employee.Gender = comboGender.Text;
            employee.Education = txtEducation.Text;
            employee.Post = comboPost.Text;
            employee.Salary = Convert.ToInt32(txtSalary.Text);
            employee.BloodGroup = comboBloodGroup.Text;
            employee.Joindate = joinDay + "-" + joinMonth + "-" + joinYear;
            employee.Birthdate = birthDay + "-" + birthMonth + "-" + birthYear;
            employee.Password = txtPassword.Text;

            EmployeeServices employeeService = new EmployeeServices();

            if (employeeService.Add(employee) == 1)
            {
                MessageBox.Show("Record Added Successfully!");
                this.Close();
            }
            else
                MessageBox.Show("Could not store data!!");
        }
        #endregion
    }
}
