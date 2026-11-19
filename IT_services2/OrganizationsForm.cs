using IT_services2.Entities;
using IT_services2.Repositories;
using System;
using System.Windows.Forms;
using Unity;
using Unity.Resolution;

namespace IT_services2
{
    public partial class OrganizationsForm : Form
    {
        private readonly IUnityContainer _container;
        private readonly IOrganizationRepository _organizationRepository;

        public OrganizationsForm(IUnityContainer container, IOrganizationRepository organizationRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _organizationRepository = organizationRepository ?? throw new ArgumentNullException(nameof(organizationRepository));
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<OrganizationForm>().ShowDialog();
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonUpd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!TryGetIdentifierFromSelectedRow(out int id))
                    return;

                var organization = _organizationRepository.GetById(id);
                if (organization == null)
                {
                    MessageBox.Show("Организация не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _container.Resolve<OrganizationForm>(
                    new ParameterOverride("organization", organization)).ShowDialog();
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при редактировании", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (!TryGetIdentifierFromSelectedRow(out int id))
                    return;

                var result = MessageBox.Show(
                    "Вы уверены, что хотите удалить организацию?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _organizationRepository.Delete(id);
                    LoadList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при удалении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadList()
        {
            dataGridViewData.DataSource = _organizationRepository.GetAll();
        }

        private bool TryGetIdentifierFromSelectedRow(out int id)
        {
            id = 0;
            if (dataGridViewData.CurrentRow == null)
            {
                MessageBox.Show("Выберите строку в таблице.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            id = (int)dataGridViewData.CurrentRow.Cells["Id"].Value;
            return true;
        }

        private void OrganizationsForm_Load(object sender, EventArgs e)
        {
            LoadList();
        }
    }
}
