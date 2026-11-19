using IT_services2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_services2.Repositories
{
    public interface ISystemRepository
    {
        ITSystem GetById(int id);
        IEnumerable<ITSystem> GetAll();
        IEnumerable<ITSystem> GetByOrganizationId(int organizationId);
        ITSystem Create(ITSystem system);
        void Update(ITSystem system);
        void Delete(int id);
    }
}
