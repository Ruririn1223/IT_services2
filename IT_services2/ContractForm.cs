using IT_services2.Entities;
using IT_services2.Entities.Enums;
using IT_services2.Repositories;
using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace IT_services2
{
    public partial class ContractForm : Form
    {
        private readonly IContractRepository _contractRepository;
        private readonly IOrganizationRepository _organizationRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ISystemRepository _systemRepository;
        private readonly IContractSystemRepository _contractSystemRepository;

        public ContractForm(
            IContractRepository contractRepository,
            IOrganizationRepository organizationRepository,
            IEmployeeRepository employeeRepository,
            ISystemRepository systemRepository,
            IContractSystemRepository contractSystemRepository)
        {
            InitializeComponent();

            _contractRepository = contractRepository ?? throw new ArgumentNullException(nameof(contractRepository));
            _organizationRepository = organizationRepository ?? throw new ArgumentNullException(nameof(organizationRepository));
            _employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
            _systemRepository = systemRepository ?? throw new ArgumentNullException(nameof(systemRepository));
            _contractSystemRepository = contractSystemRepository ?? throw new ArgumentNullException(nameof(contractSystemRepository));

            InitializeControls();
        }

        private void InitializeControls()
        {
            // Заполняем ComboBox организациями
            comboBoxOrganization.DataSource = _organizationRepository.GetAll();
            comboBoxOrganization.DisplayMember = "Name";
            comboBoxOrganization.ValueMember = "Id";

            // Заполняем ComboBox сотрудниками
            comboBoxEmployee.DataSource = _employeeRepository.GetAll();
            comboBoxEmployee.DisplayMember = "LastName";
            comboBoxEmployee.ValueMember = "Id";

            // Заполняем ComboBox статусами
            comboBoxStatus.DataSource = Enum.GetValues(typeof(Status));

            // Заполняем CheckedListBox системами
            checkedListBoxSystems.DataSource = _systemRepository.GetAll();
            checkedListBoxSystems.DisplayMember = "Name";
            checkedListBoxSystems.ValueMember = "Id";

            // Заполняем CheckBox флагами
            checkBoxNDA.Tag = Flags.NDA;
            checkBoxUrgent.Tag = Flags.Urgent;
            checkBoxPrepayment.Tag = Flags.Prepayment;
            checkBoxLongTerm.Tag = Flags.LongTerm;

            // Устанавливаем дату по умолчанию
            dateTimePickerDate.Value = DateTime.Now;
            dateTimePickerEndDate.Value = DateTime.Now.AddMonths(6);
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            try
            {
                string number = textBoxNumber.Text.Trim();
                DateTime date = dateTimePickerDate.Value;
                DateTime endDate = dateTimePickerEndDate.Value;
                decimal amount = numericUpDownAmount.Value;

                if (comboBoxOrganization.SelectedItem == null)
                {
                    MessageBox.Show("Выберите организацию.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (comboBoxEmployee.SelectedItem == null)
                {
                    MessageBox.Show("Выберите сотрудника.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (comboBoxStatus.SelectedItem == null)
                {
                    MessageBox.Show("Выберите статус.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int organizationId = (int)comboBoxOrganization.SelectedValue;
                int employeeId = (int)comboBoxEmployee.SelectedValue;
                Status status = (Status)comboBoxStatus.SelectedItem;

                // Собираем флаги
                Flags flags = Flags.None;
                if (checkBoxNDA.Checked) flags |= Flags.NDA;
                if (checkBoxUrgent.Checked) flags |= Flags.Urgent;
                if (checkBoxPrepayment.Checked) flags |= Flags.Prepayment;
                if (checkBoxLongTerm.Checked) flags |= Flags.LongTerm;

                if (string.IsNullOrWhiteSpace(number))
                {
                    MessageBox.Show("Введите номер договора.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (endDate <= date)
                {
                    MessageBox.Show("Дата окончания должна быть позже даты начала.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (amount <= 0)
                {
                    MessageBox.Show("Сумма должна быть положительной.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Создаём договор
                var contract = Contract.Create(0, number, date, endDate, amount, organizationId, employeeId, status, flags);
                var createdContract = _contractRepository.Create(contract);

                // Сохраняем связи M:N
                foreach (var item in checkedListBoxSystems.CheckedItems)
                {
                    var system = item as ITSystem;
                    if (system != null)
                    {
                        var contractSystem = Contract_System.Create(createdContract.Id, system.Id);
                        _contractSystemRepository.Add(contractSystem);
                    }
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
