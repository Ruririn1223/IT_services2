using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_services2.Entities
{
    public class ITSystem
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int OrganizationId { get; private set; }

        private ITSystem(int id, string name, string description, int organizationId)
        {
            Id = id;
            Name = name;
            Description = description;
            OrganizationId = organizationId;
        }

        public static ITSystem Create(int id, string name, string description, int organizationId)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name), "Название системы не может быть пустым.");
            if (organizationId <= 0)
                throw new ArgumentException("ID организации должен быть положительным.", nameof(organizationId));

            return new ITSystem(id, name, description ?? string.Empty, organizationId);
        }
    }
}
