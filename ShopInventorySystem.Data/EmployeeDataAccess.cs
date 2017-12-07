using ShopInventorySystem.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventorySystem.Data
{
    public class EmployeeDataAccess
    {
        public int Add(Employee employee)
        {
            string query = string.Format("INSERT INTO EMPLOYEE (EmployeeName, Address, Phone, Gender, Education, BloodGroup, Post, Salary, Joindate, Birthdate, Password) VALUES('{0}', '{1}', {2}, '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')", employee.EmployeeName, employee.Address, employee.Phone, employee.Gender, employee.Education, employee.BloodGroup, employee.Post, employee.Salary, employee.Joindate, employee.Birthdate, employee.Password);
            return DataAccess.ExecuteQuery(query);
        }

        public int Remove(string id)
        {
            string query = "DELETE FROM Employee WHERE Phone = '" + id + "'";
            return DataAccess.ExecuteQuery(query);
        }

        public int Edit(Employee employee)
        {
            string query = string.Format("UPDATE Employee SET EmployeeName ='{1}',Salary={2},JoinDate='{3}',BirthDate='{4}',Post='{5}',phone='{6}' WHERE EmployeeId='{0}'", employee.EmployeeId, employee.EmployeeName, employee.Salary, employee.Joindate, employee.Birthdate, employee.Post, employee.Phone);
            return DataAccess.ExecuteQuery(query);
        }

        public int UpdatePassword(string id, string password)
        {
            string query = "UPDATE Employee SET Password ='" + password + "' WHERE EmployeeId = '" + id + "'";
            return DataAccess.ExecuteQuery(query);
        }
        public List<Employee> GetAll()
        {
            string query = "SELECT EmployeeId, EmployeeName, Address, Phone, Gender, Education, BloodGroup, Post, Salary, Joindate, Birthdate FROM Employee";
            SqlDataReader reader = DataAccess.GetData(query);

            Employee employee = null;
            List<Employee> employeeList = new List<Employee>();
            while (reader.Read())
            {
                employee = new Employee(Convert.ToInt32(reader["EmployeeId"].ToString()));
                employee.EmployeeName = reader["EmployeeName"].ToString();
                employee.Salary = Convert.ToInt32(reader["Salary"].ToString());
                employee.Joindate = reader["Joindate"].ToString();
                employee.Birthdate = reader["Birthdate"].ToString();
                employee.Post = reader["Post"].ToString();
                employee.Phone = reader["Phone"].ToString();
                employee.BloodGroup = reader["BloodGroup"].ToString();
                employee.Gender = reader["Gender"].ToString();
                employee.Education = reader["Education"].ToString();
                employee.Address = reader["Address"].ToString();

                employeeList.Add(employee);
            }
            return employeeList;
        }

        public List<Employee> GetByPhone(string phone)
        {
            string query = "SELECT EmployeeId, EmployeeName, Address, Phone, Gender, Education, BloodGroup, Post, Salary, Joindate, Birthdate FROM Employee WHERE Phone = '" + phone + "'";
            SqlDataReader reader = DataAccess.GetData(query);

            Employee employee = null;
            List<Employee> employeeList = new List<Employee>();
            while (reader.Read())
            {
                employee = new Employee(Convert.ToInt32(reader["EmployeeId"].ToString()));
                employee.EmployeeName = reader["EmployeeName"].ToString();
                employee.Salary = Convert.ToInt32(reader["Salary"].ToString());
                employee.Joindate = reader["Joindate"].ToString();
                employee.Birthdate = reader["Birthdate"].ToString();
                employee.Post = reader["Post"].ToString();
                employee.Phone = reader["Phone"].ToString();
                employee.BloodGroup = reader["BloodGroup"].ToString();
                employee.Gender = reader["Gender"].ToString();
                employee.Education = reader["Education"].ToString();
                employee.Address = reader["Address"].ToString();

                employeeList.Add(employee);
            }
            return employeeList;
        }
        public int GetUser(string phone)
        {
            string query = "SELECT EmployeeName FROM Employee WHERE Phone = '" + phone + "'";
            SqlDataReader reader = DataAccess.GetData(query);
            if(reader.HasRows)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public List<Employee> GetByName(string employeeName)
        {
            string query = "SELECT EmployeeId, EmployeeName, Address, Phone, Gender, Education, BloodGroup, Post, Salary, Joindate, Birthdate FROM Employee WHERE EmployeeName LIKE '" + employeeName + "%'";
            SqlDataReader reader = DataAccess.GetData(query);

            Employee employee = null;
            List<Employee> employeeList = new List<Employee>();
            while (reader.Read())
            {
                employee = new Employee(Convert.ToInt32(reader["EmployeeId"].ToString()));
                employee.EmployeeName = reader["EmployeeName"].ToString();
                employee.Salary = Convert.ToInt32(reader["Salary"].ToString());
                employee.Joindate = reader["Joindate"].ToString();
                employee.Birthdate = reader["Birthdate"].ToString();
                employee.Post = reader["Post"].ToString();
                employee.Phone = reader["Phone"].ToString();
                employee.BloodGroup = reader["BloodGroup"].ToString();
                employee.Gender = reader["Gender"].ToString();
                employee.Education = reader["Education"].ToString();
                employee.Address = reader["Address"].ToString();
                employeeList.Add(employee);
            }
            return employeeList;
        }

        public List<Employee> GetByPost(string employeePost)
        {
            string query = "SELECT EmployeeId, EmployeeName, Address, Phone, Gender, Education, BloodGroup, Post, Salary, Joindate, Birthdate FROM Employee where Post LIKE '" + employeePost + "%'";
            SqlDataReader reader = DataAccess.GetData(query);

            Employee employee = null;
            List<Employee> employeeList = new List<Employee>();
            while (reader.Read())
            {
                employee = new Employee(Convert.ToInt32(reader["EmployeeId"].ToString()));
                employee.EmployeeName = reader["EmployeeName"].ToString();
                employee.Salary = Convert.ToInt32(reader["Salary"].ToString());
                employee.Joindate = reader["Joindate"].ToString();
                employee.Birthdate = reader["Birthdate"].ToString();
                employee.Post = reader["Post"].ToString();
                employee.Phone = reader["Phone"].ToString();
                employee.BloodGroup = reader["BloodGroup"].ToString();
                employee.Gender = reader["Gender"].ToString();
                employee.Education = reader["Education"].ToString();
                employee.Address = reader["Address"].ToString();
                employeeList.Add(employee);
            }
            return employeeList;
        }

        public List<Employee> GetJoinDate(string joindate)
        {
            string query = "SELECT EmployeeId, EmployeeName, Address, Phone, Gender, Education, BloodGroup, Post, Salary, Joindate, Birthdate FROM Employee where Joindate='" + joindate + "'";
            SqlDataReader reader = DataAccess.GetData(query);

            Employee employee = null;
            List<Employee> employeeList = new List<Employee>();
            while (reader.Read())
            {
                employee = new Employee(Convert.ToInt32(reader["EmployeeId"].ToString()));
                employee.EmployeeName = reader["EmployeeName"].ToString();
                employee.Salary = Convert.ToInt32(reader["Salary"].ToString());
                employee.Joindate = reader["Joindate"].ToString();
                employee.Birthdate = reader["Birthdate"].ToString();
                employee.Post = reader["Post"].ToString();
                employee.Phone = reader["Phone"].ToString();
                employee.BloodGroup = reader["BloodGroup"].ToString();
                employee.Gender = reader["Gender"].ToString();
                employee.Education = reader["Education"].ToString();
                employee.Address = reader["Address"].ToString();
                employeeList.Add(employee);
            }
            return employeeList;
        }
        public List<Employee> EmployeeLogIn(string employeeId)
        {
            string query = "SELECT EmployeeId,EmployeeName,Phone,Password from Employee where Phone ='" + employeeId + "'";
            SqlDataReader reader = DataAccess.GetData(query);
            Employee employee = null;

            List<Employee> employeeList = new List<Employee>();
            while (reader.Read())
            {
                employee = new Employee(Convert.ToInt32(reader["EmployeeId"].ToString()));
                employee.EmployeeName = reader["EmployeeName"].ToString();
                employee.Phone = reader["Phone"].ToString();
                employee.Password = reader["Password"].ToString();

                employeeList.Add(employee);
            }
            return employeeList;
        }
    }
}
