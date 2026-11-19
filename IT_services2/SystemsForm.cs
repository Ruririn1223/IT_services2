using IT_services2.Entities;
using IT_services2.Repositories;
using System;
using System.Windows.Forms;
using Unity;
using Unity.Resolution;

namespace IT_services2
{
    public partial class SystemsForm : Form
    {
        private readonly IUnityContainer _container;
        private readonly ISystemRepository _systemRepository;

        public SystemsForm(IUnityContainer container, ISystemRepository systemRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _systemRepository = systemRepository ?? throw new ArgumentNullException(nameof(systemRepository));
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<SystemForm>().ShowDialog();
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

                var system = _systemRepository.GetById(id);
                if (system == null)
                {
                    MessageBox.Show("Система не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _container.Resolve<SystemForm>(
                    new ParameterOverride("system", system)).ShowDialog();
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
                    "Вы уверены, что хотите удалить систему?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _systemRepository.Delete(id);
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
            dataGridViewData.DataSource = _systemRepository.GetAll();
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

        private void SystemsForm_Load(object sender, EventArgs e)
        {
            LoadList();
        }

    }
}