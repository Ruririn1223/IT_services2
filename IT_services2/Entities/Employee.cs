using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT_services2.Entities.Enums;

namespace IT_services2.Entities
{
    public class Employee
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public Position Position { get; private set; }
        public string Email { get; private set; }

        private Employee(int id, string firstName, string lastName, Position position, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Position = position;
            Email = email;
        }

        public static Employee Create(int id, string firstName, string lastName, Position position, string email)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentNullException(nameof(firstName), "Имя не может быть пустым.");
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentNullException(nameof(lastName), "Фамилия не может быть пустой.");

            return new Employee(id, firstName, lastName, position, email ?? string.Empty);
        }
    }
}
