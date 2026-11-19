using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT_services2.Entities.Enums;

namespace IT_services2.Entities
{
    public class Contract
    {
        public int Id { get; private set; }
        public string Number { get; private set; }
        public DateTime Date { get; private set; }
        public DateTime EndDate { get; private set; }
        public decimal Amount { get; private set; }
        public int OrganizationId { get; private set; }
        public int EmployeeId { get; private set; }
        public Status Status { get; private set; }
        public Flags Flags { get; private set; }

        private Contract(int id, string number, DateTime date, DateTime endDate,
            decimal amount, int organizationId, int employeeId,
            Status status, Flags flags)
        {
            Id = id;
            Number = number;
            Date = date;
            EndDate = endDate;
            Amount = amount;
            OrganizationId = organizationId;
            EmployeeId = employeeId;
            Status = status;
            Flags = flags;
        }

        public static Contract Create(int id, string number, DateTime date, DateTime endDate,
            decimal amount, int organizationId, int employeeId,
            Status status, Flags flags)
        {
            if (string.IsNullOrWhiteSpace(number))
                throw new ArgumentNullException(nameof(number), "Номер договора не может быть пустым.");
            if (endDate <= date)
                throw new ArgumentException("Дата окончания должна быть позже даты начала.", nameof(endDate));
            if (amount < 0)
                throw new ArgumentException("Сумма договора не может быть отрицательной.", nameof(amount));
            if (organizationId <= 0)
                throw new ArgumentException("ID организации должен быть положительным.", nameof(organizationId));
            if (employeeId <= 0)
                throw new ArgumentException("ID сотрудника должен быть положительным.", nameof(employeeId));

            return new Contract(id, number, date, endDate, amount,
                organizationId, employeeId, status, flags);
        }
    }
}
