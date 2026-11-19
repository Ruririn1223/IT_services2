using IT_services2.Entities;
using IT_services2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_services2.Repositories.Implementation
{
    public class ContractSystemRepositoryStub : IContractSystemRepository
    {
        public IEnumerable<Contract_System> GetByContractId(int contractId)
        {
            return new List<Contract_System>();
        }

        public IEnumerable<Contract_System> GetBySystemId(int systemId)
        {
            return new List<Contract_System>();
        }

        public void Add(Contract_System contractSystem)
        {
            // Заглушка
        }

        public void Remove(int contractId, int systemId)
        {
            // Заглушка
        }
    }
}
