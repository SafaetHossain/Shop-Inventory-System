using ShopInventorySystem.Data;
using ShopInventorySystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopInventorySystem
{
    public delegate void RefreshDelegate();
    public partial class Dashboard : Form
    {
        Employee employee = new Employee();
        IEmployeeServices employeeServices = new EmployeeServices();
        RefreshDelegate refreshDelegate;
        public Dashboard()
        {
            InitializeComponent();
            timer1.Start();
            txtPassword.PasswordChar = '*';
            txtConPassword.PasswordChar = '*';
            refreshDelegate = this.RefreshDataGridView;
            this.ShowDataGridView();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //ShowDataGridView();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            timer1.Stop();
        }
#region Panel_Employee
        #region menu
        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            plEmployee.Visible = true;
            refreshDelegate = this.RefreshDataGridView;
            this.ShowDataGridView();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            plEmployee.Visible = false;
            plDashboard.Visible = true;
        }
        #endregion

        #region button_click
        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        //add Employee button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(txtPhone.Text);
            if(txtPassword.Text != "" && txtConPassword.Text != "")
            {
                if ( employeeServices.GetUser(txtPhone.Text) == 0)
                {
                    if(txtPassword.Text == txtConPassword.Text)
                    {
                        AddEmployees();
                    }
                    else
                    {
                        MessageBox.Show("Password And Confirm Password are not match!");
                    }
                }
                else
                {
                    MessageBox.Show("Record Already Added");
                }
            }
            else
            {
                MessageBox.Show("Password and Confirm Password must be filled");
            }
        }
        private void Edit_Click(object sender, EventArgs e)
        {

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure?", "DeleteEmployee", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int rowIndex = employeeDataGridView.CurrentCell.RowIndex;
                string phone = employeeDataGridView.Rows[rowIndex].Cells[2].Value.ToString();
                DeleteEmployee(phone);
            }
        }

        private void employeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtName.Text = employeeDataGridView.Rows[e.RowIndex].Cells["EmployeeName"].Value.ToString();
                txtAddress.Text = employeeDataGridView.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                txtPhone.Text = employeeDataGridView.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                comboBloodGroup.Text = employeeDataGridView.Rows[e.RowIndex].Cells["BloodGroup"].Value.ToString();
                comboGender.Text = employeeDataGridView.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                txtEducation.Text = employeeDataGridView.Rows[e.RowIndex].Cells["Education"].Value.ToString();
                comboPost.Text = employeeDataGridView.Rows[e.RowIndex].Cells["Post"].Value.ToString();
                txtSalary.Text = employeeDataGridView.Rows[e.RowIndex].Cells["Salary"].Value.ToString();
                DateTime dt1 = DateTime.ParseExact(employeeDataGridView.Rows[e.RowIndex].Cells["Joindate"].Value.ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
                dateJoin.Value = dt1;
                DateTime dt2 = DateTime.ParseExact(employeeDataGridView.Rows[e.RowIndex].Cells["Birthdate"].Value.ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
                dateBirth.Value = dt2;
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAddress.Clear();
            txtConPassword.Clear();
            txtEducation.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            txtSalary.Clear();
            comboBloodGroup.SelectedIndex = -1;
            comboGender.SelectedIndex = -1;
            comboPost.SelectedIndex = -1;
            dateJoin.Value = DateTime.Now;
            dateBirth.Value = DateTime.Now;
        }
        #endregion

        #region method
        #region Search_Method
        public void NameSearch()
        {
            employeeDataGridView.AutoGenerateColumns = false;
            employeeDataGridView.DataSource = employeeServices.GetByName(txtSearch.Text);
        }
        public void JoinDateSearch()
        {
            employeeDataGridView.AutoGenerateColumns = false;
            employeeDataGridView.DataSource = employeeServices.GetByJoinDate(txtSearch.Text);
        }
        public void PostSearch()
        {
            employeeDataGridView.AutoGenerateColumns = false;
            employeeDataGridView.DataSource = employeeServices.GetByPost(txtSearch.Text);
        }
        public void PhoneSearch()
        {
            employeeDataGridView.AutoGenerateColumns = false;
            employeeDataGridView.DataSource = employeeServices.GetByPhone(txtSearch.Text);
        }
        #endregion

        public void AddEmployees()
        {
            string joinYear = dateJoin.Value.Year.ToString();
            string joinMonth = dateJoin.Value.Month.ToString("D2");
            string joinDay = dateJoin.Value.Day.ToString("D2");

            string birthYear = dateBirth.Value.Year.ToString();
            string birthMonth = dateBirth.Value.Month.ToString("D2");
            string birthDay = dateBirth.Value.Day.ToString("D2");

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

            if (employeeServices.Add(employee) == 1)
            {
                MessageBox.Show("Record Added Successfully!");
                employeeDataGridView.DataSource = employeeServices.GetAll();
            }
            else
                MessageBox.Show("Could not store data!!");
        }
        public void DeleteEmployee(string phone)
        {
            if (employeeServices.Remove(phone) == 1)
            {
                MessageBox.Show("Your selected Employee deleted");
                employeeDataGridView.DataSource = employeeServices.GetAll();
            }
            else
            {
                MessageBox.Show("Your slected Employee not deleted");
                employeeDataGridView.DataSource = employeeServices.GetAll();
            }
        }
        #region GridView_method
        public void ShowDataGridView()
        {
            employeeDataGridView.AutoGenerateColumns = false;
            employeeDataGridView.DataSource = employeeServices.GetAll();
        }
        private void RefreshDataGridView()
        {
            employeeDataGridView.DataSource = null;
            this.ShowDataGridView();
        }
        #endregion
        
        #endregion
        
        #region TextChanged
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(comboSearchItem.SelectedItem.ToString() == "Name")
            {
                this.RefreshDataGridView();
                this.NameSearch();
            }
            else if (comboSearchItem.SelectedItem.ToString() == "Joindate")
            {
                this.RefreshDataGridView();
                this.JoinDateSearch();
            }
            else if(comboSearchItem.SelectedItem.ToString() == "Post")
            {
                this.RefreshDataGridView();
                this.PostSearch();
            }
            else
            {
                this.RefreshDataGridView();
                this.PhoneSearch();
            }
        }
        #endregion

        #region Key_Press
        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            char salary = e.KeyChar;

            if (!char.IsDigit(salary) && salary != 8 && salary != 46)
            {
                e.Handled = true;
                MessageBox.Show("Only Digits(0..9) are allowed!");
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char name = e.KeyChar;
            if (!char.IsLetter(name) && name != 8 && name != 46 && name != 32)
            {
                e.Handled = true;
                MessageBox.Show("Only Letters and Space are allowed!");
            }
        }

        private void txtEducation_KeyPress(object sender, KeyPressEventArgs e)
        {
            char edu = e.KeyChar;
            if (!char.IsLetter(edu) && edu != 8 && edu != 46)
            {
                e.Handled = true;
                MessageBox.Show("Only Letters are allowed!");
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char phone = e.KeyChar;

            if (!char.IsDigit(phone) && phone != 8 && phone != 46)
            {
                e.Handled = true;
                MessageBox.Show("Only Digits(0..9) are allowed!");
            }
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            char password = e.KeyChar;

            if (!char.IsLetterOrDigit(password) && password != 8 && password != 46)
            {
                e.Handled = true;
                MessageBox.Show("Only Digits(0..9) and Letters are allowed!");
            }
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.lblTime.Text = dateTime.ToString();
        }
#endregion
    }
}
