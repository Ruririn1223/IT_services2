using IT_services2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IT_services2.Repositories
{
    public interface IContractRepository
    {
        Contract GetById(int id);
        IEnumerable<Contract> GetAll();
        IEnumerable<Contract> GetByOrganizationId(int organizationId);
        IEnumerable<Contract> GetByEmployeeId(int employeeId);
        Contract Create(Contract contract);
    }
}
