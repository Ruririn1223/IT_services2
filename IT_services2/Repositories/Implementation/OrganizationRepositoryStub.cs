using IT_services2.Entities;
using IT_services2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_services2.Repositories.Implementation
{
    public class OrganizationRepositoryStub : IOrganizationRepository
    {
        public Organization GetById(int id)
        {
            return null;
        }

        public IEnumerable<Organization> GetAll()
        {
            return new List<Organization>();
        }

        public Organization Create(Organization organization)
        {
            return organization;
        }

        public void Update(Organization organization)
        {
            // Заглушка — ничего не делает
        }

        public void Delete(int id)
        {
            // Заглушка — ничего не делает
        }
    }
}
