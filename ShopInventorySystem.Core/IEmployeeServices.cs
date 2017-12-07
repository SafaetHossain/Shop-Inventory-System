using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopInventorySystem.Entity;

namespace ShopInventorySystem.Data
{
    public interface IEmployeeServices
    {
        int Add(Employee employee);
        int Remove(string id);
        int Edit(Employee employee);
        int UpdatePassword(string id, string password);
        List<Employee> GetAll();
        List<Employee> GetByPhone(string phone);
        List<Employee> GetByName(string name);
        List<Employee> GetByPost(string type);
        List<Employee> GetByJoinDate(string joindate);
        List<Employee> EmployeeLogIn(string employeeId);
        int GetUser(string phone);
    }
}
