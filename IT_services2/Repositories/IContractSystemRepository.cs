using IT_services2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace IT_services2.Repositories
{
    public interface IContractSystemRepository
    {
        IEnumerable<Contract_System> GetByContractId(int contractId);
        IEnumerable<Contract_System> GetBySystemId(int systemId);
        void Add(Contract_System contractSystem);
        void Remove(int contractId, int systemId);
    }
}
