using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventorySystem.Entity
{
    public class Employee
    {
        //private static int Count = 0;
        private string employeeName, address, gender, education, post, bloodGroup, phone, birthdate, joindate, password;
        private int salary, employeeId;
        public Employee()
        {
            //DateTime thisDay = DateTime.Today;
            //string year = thisDay.Year.ToString();
            //string month = thisDay.Month.ToString();

            //employeeId = year + "-" + month + "-" + "1-" + (++Count).ToString("D3");

            employeeName = "";
            post = "";
            salary = 0;
            phone = "";
            birthdate = "";
            joindate = "";
            password = "";
        }

        public Employee(string employeeName, string post, string phone, string birthdate, string joindate, string password, int salary)
        {
            this.employeeName = employeeName;
            this.post = post;
            this.salary = salary;
            this.birthdate = birthdate;
            this.joindate = birthdate;
            this.password = password;
        }
        public Employee(int employeeId)
        {
            this.employeeId = employeeId;
        }

        public string EmployeeName
        {
            set { employeeName = value; }
            get { return employeeName; }
        }

        public int EmployeeId
        {
            get { return this.employeeId; }
        }

        public string Post
        {
            set { post = value; }
            get { return post; }
        }

        public int Salary
        {
            set { salary = value; }
            get { return salary; }
        }

        public string Phone
        {
            set { phone = value; }
            get { return phone; }
        }

        public string Birthdate
        {
            set { birthdate = value; }
            get { return birthdate; }
        }

        public string Joindate
        {
            set { joindate = value; }
            get { return joindate; }
        }

        public string Password
        {
            set { password = value; }
            get { return password; }
        }
        public string Address
        {
            set { address = value; }
            get { return address; }
        }
        public string Gender
        {
            set { gender = value; }
            get { return gender; }
        }
        public string Education
        {
            set { education = value; }
            get { return education; }
        }
        public string BloodGroup
        {
            set { bloodGroup = value; }
            get { return bloodGroup; }
        }
    }
}
