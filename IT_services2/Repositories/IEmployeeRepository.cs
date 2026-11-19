using IT_services2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_services2.Repositories
{
    public interface IEmployeeRepository
    {
        Employee GetById(int id);
        IEnumerable<Employee> GetAll();
        Employee Create(Employee employee);
        void Update(Employee employee);
        void Delete(int id);
    }
}
