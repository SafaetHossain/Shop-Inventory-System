using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopInventorySystem.Entity;

namespace ShopInventorySystem.Data
{
    public class EmployeeServices : IEmployeeServices
    {
        private static EmployeeDataAccess employeeDataAccess = null;

        public EmployeeServices()
        {
            if (EmployeeServices.employeeDataAccess == null)
            {
                EmployeeServices.employeeDataAccess = new EmployeeDataAccess();
            }
        }

        public int Add(Employee employee)
        {
            return EmployeeServices.employeeDataAccess.Add(employee);
        }
 
        public int Edit(Employee employee)
        {
            return EmployeeServices.employeeDataAccess.Edit(employee);
        }

        public List<Employee> GetAll()
        {
            return EmployeeServices.employeeDataAccess.GetAll();
        }

        public List<Employee> GetByPhone(string phone)
        {
            return EmployeeServices.employeeDataAccess.GetByPhone(phone);
        }

        public List<Employee> GetByJoinDate(string joindate)
        {
            return EmployeeServices.employeeDataAccess.GetJoinDate(joindate);
        }

        public List<Employee> GetByName(string name)
        {
            return EmployeeServices.employeeDataAccess.GetByName(name);
        }

        public List<Employee> GetByPost(string post)
        {
            return EmployeeServices.employeeDataAccess.GetByPost(post);
        }

        public int Remove(string id)
        {
            return EmployeeServices.employeeDataAccess.Remove(id);
        }

        public int UpdatePassword(string id, string password)
        {
            return EmployeeServices.employeeDataAccess.UpdatePassword(id,password);
        }

        public List<Employee> EmployeeLogIn(string employeeId)
        {
            return EmployeeServices.employeeDataAccess.EmployeeLogIn(employeeId);
        }

        public int GetUser(string phone)
        {
            return EmployeeServices.employeeDataAccess.GetUser(phone);
        }
    }
}
