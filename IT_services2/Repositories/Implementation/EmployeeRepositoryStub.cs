using IT_services2.Entities;
using IT_services2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_services2.Repositories.Implementation
{
    public class EmployeeRepositoryStub : IEmployeeRepository
    {
        public Employee GetById(int id)
        {
            return null;
        }

        public IEnumerable<Employee> GetAll()
        {
            return new List<Employee>();
        }

        public Employee Create(Employee employee)
        {
            return employee;
        }

        public void Update(Employee employee)
        {
            // Заглушка
        }

        public void Delete(int id)
        {
            // Заглушка
        }
    }
}
