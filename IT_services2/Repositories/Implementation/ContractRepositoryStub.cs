using IT_services2.Entities;
using IT_services2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_services2.Repositories.Implementation
{
    public class ContractRepositoryStub : IContractRepository
    {
        public Contract GetById(int id)
        {
            return null;
        }

        public IEnumerable<Contract> GetAll()
        {
            return new List<Contract>();
        }

        public IEnumerable<Contract> GetByOrganizationId(int organizationId)
        {
            return new List<Contract>();
        }

        public IEnumerable<Contract> GetByEmployeeId(int employeeId)
        {
            return new List<Contract>();
        }

        public Contract Create(Contract contract)
        {
            return contract;
        }
    }
}
