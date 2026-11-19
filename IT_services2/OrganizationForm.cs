using System;
using System.Windows.Forms;
using IT_services2.Entities;
using IT_services2.Repositories;

namespace IT_services2
{
    public partial class OrganizationForm : Form
    {
        private readonly IOrganizationRepository _organizationRepository;
        private readonly Organization _organization;

        // Конструктор для создания новой организации
        public OrganizationForm(IOrganizationRepository organizationRepository)
            : this(organizationRepository, null)
        {
        }

        // Конструктор для редактирования существующей
        public OrganizationForm(IOrganizationRepository organizationRepository, Organization organization)
        {
            InitializeComponent();
            _organizationRepository = organizationRepository ?? throw new ArgumentNullException(nameof(organizationRepository));
            _organization = organization;

            if (_organization != null)
            {
                this.Text = "Редактирование организации";
                textBoxName.Text = _organization.Name;
                textBoxINN.Text = _organization.INN;
                textBoxAddress.Text = _organization.Address;
                textBoxPhone.Text = _organization.ContactPhone;
            }
            else
            {
                this.Text = "Добавление организации";
            }
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxName.Text.Trim();
                string inn = textBoxINN.Text.Trim();
                string address = textBoxAddress.Text.Trim();
                string phone = textBoxPhone.Text.Trim();

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Введите название организации.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(inn))
                {
                    MessageBox.Show("Введите ИНН.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (_organization == null)
                {
                    // Создание новой
                    var newOrg = Organization.Create(0, name, inn, address, phone);
                    _organizationRepository.Create(newOrg);
                }
                else
                {
                    // Редактирование существующей
                    var updatedOrg = Organization.Create(_organization.Id, name, inn, address, phone);
                    _organizationRepository.Update(updatedOrg);
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
