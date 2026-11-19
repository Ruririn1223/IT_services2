using System;
using System.Windows.Forms;
using IT_services2.Entities;
using IT_services2.Repositories;

namespace IT_services2
{
    public partial class SystemForm : Form
    {
        private readonly ISystemRepository _systemRepository;
        private readonly IOrganizationRepository _organizationRepository;
        private readonly ITSystem _system;

        // Конструктор для создания новой системы
        public SystemForm(ISystemRepository systemRepository, IOrganizationRepository organizationRepository)
            : this(systemRepository, organizationRepository, null)
        {
        }

        // Конструктор для редактирования существующей
        public SystemForm(ISystemRepository systemRepository, IOrganizationRepository organizationRepository, ITSystem system)
        {
            InitializeComponent();
            _systemRepository = systemRepository ?? throw new ArgumentNullException(nameof(systemRepository));
            _organizationRepository = organizationRepository ?? throw new ArgumentNullException(nameof(organizationRepository));
            _system = system;

            // Заполняем ComboBox организациями
            comboBoxOrganization.DataSource = _organizationRepository.GetAll();
            comboBoxOrganization.DisplayMember = "Name";
            comboBoxOrganization.ValueMember = "Id";

            if (_system != null)
            {
                this.Text = "Редактирование системы";
                textBoxName.Text = _system.Name;
                textBoxDescription.Text = _system.Description;
                comboBoxOrganization.SelectedValue = _system.OrganizationId;
            }
            else
            {
                this.Text = "Добавление системы";
            }
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxName.Text.Trim();
                string description = textBoxDescription.Text.Trim();

                if (comboBoxOrganization.SelectedItem == null)
                {
                    MessageBox.Show("Выберите организацию.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int organizationId = (int)comboBoxOrganization.SelectedValue;

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Введите название системы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (_system == null)
                {
                    // Создание новой
                    var newSystem = ITSystem.Create(0, name, description, organizationId);
                    _systemRepository.Create(newSystem);
                }
                else
                {
                    // Редактирование существующей
                    var updatedSystem = ITSystem.Create(_system.Id, name, description, organizationId);
                    _systemRepository.Update(updatedSystem);
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
