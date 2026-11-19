using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_services2.Entities
{
    public class Contract_System
    {
        public int ContractId { get; private set; }
        public int SystemId { get; private set; }

        private Contract_System(int contractId, int systemId)
        {
            ContractId = contractId;
            SystemId = systemId;
        }

        public static Contract_System Create(int contractId, int systemId)
        {
            if (contractId <= 0)
                throw new ArgumentException("ID договора должен быть положительным.", nameof(contractId));
            if (systemId <= 0)
                throw new ArgumentException("ID системы должен быть положительным.", nameof(systemId));

            return new Contract_System(contractId, systemId);
        }
    }
}
