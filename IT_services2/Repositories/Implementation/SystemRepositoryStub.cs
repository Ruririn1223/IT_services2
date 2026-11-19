using IT_services2.Entities;
using IT_services2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_services2.Repositories.Implementation
{
    public class SystemRepositoryStub : ISystemRepository
    {
        public ITSystem GetById(int id)
        {
            return null;
        }

        public IEnumerable<ITSystem> GetAll()
        {
            return new List<ITSystem>();
        }

        public IEnumerable<ITSystem> GetByOrganizationId(int organizationId)
        {
            return new List<ITSystem>();
        }

        public ITSystem Create(ITSystem system)
        {
            return system;
        }

        public void Update(ITSystem system)
        {
            // Заглушка
        }

        public void Delete(int id)
        {
            // Заглушка
        }
    }
}
