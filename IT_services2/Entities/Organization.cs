using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_services2.Entities
{
    public class Organization
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string INN { get; private set; }
        public string Address { get; private set; }
        public string ContactPhone { get; private set; }

        private Organization(int id, string name, string inn, string address, string contactPhone)
        {
            Id = id;
            Name = name;
            INN = inn;
            Address = address;
            ContactPhone = contactPhone;
        }

        public static Organization Create(int id, string name, string inn, string address, string contactPhone)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name), "Название организации не может быть пустым.");
            if (string.IsNullOrWhiteSpace(inn))
                throw new ArgumentNullException(nameof(inn), "ИНН не может быть пустым.");

            return new Organization(id, name, inn, address ?? string.Empty, contactPhone ?? string.Empty);
        }
    }
}
