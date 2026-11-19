using System;
using System.Windows.Forms;
using IT_services2.Entities;
using IT_services2.Entities.Enums;
using IT_services2.Repositories;

namespace IT_services2
{
    public partial class EmployeeForm : Form
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly Employee _employee;

        // Конструктор для создания нового сотрудника
        public EmployeeForm(IEmployeeRepository employeeRepository)
            : this(employeeRepository, null)
        {
        }

        // Конструктор для редактирования существующего
        public EmployeeForm(IEmployeeRepository employeeRepository, Employee employee)
        {
            InitializeComponent();
            _employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
            _employee = employee;

            // Заполняем ComboBox должностей
            comboBoxPosition.DataSource = Enum.GetValues(typeof(Position));

            if (_employee != null)
            {
                this.Text = "Редактирование сотрудника";
                textBoxFirstName.Text = _employee.FirstName;
                textBoxLastName.Text = _employee.LastName;
                comboBoxPosition.SelectedItem = _employee.Position;
                textBoxEmail.Text = _employee.Email;
            }
            else
            {
                this.Text = "Добавление сотрудника";
            }
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = textBoxFirstName.Text.Trim();
                string lastName = textBoxLastName.Text.Trim();
                string email = textBoxEmail.Text.Trim();

                if (comboBoxPosition.SelectedItem == null)
                {
                    MessageBox.Show("Выберите должность.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Position position = (Position)comboBoxPosition.SelectedItem;

                if (string.IsNullOrWhiteSpace(firstName))
                {
                    MessageBox.Show("Введите имя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(lastName))
                {
                    MessageBox.Show("Введите фамилию.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Введите email.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (_employee == null)
                {
                    // Создание нового
                    var newEmployee = Employee.Create(0, firstName, lastName, position, email);
                    _employeeRepository.Create(newEmployee);
                }
                else
                {
                    // Редактирование существующего
                    var updatedEmployee = Employee.Create(_employee.Id, firstName, lastName, position, email);
                    _employeeRepository.Update(updatedEmployee);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
