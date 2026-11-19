using IT_services2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_services2.Repositories
{
    public interface IOrganizationRepository
    {
        Organization GetById(int id);
        IEnumerable<Organization> GetAll();
        Organization Create(Organization organization);
        void Update(Organization organization);
        void Delete(int id);
    }
}
