using IT_services2.Entities;
using IT_services2.Repositories;
using System;
using System.Windows.Forms;
using Unity;
using Unity.Resolution;

namespace IT_services2
{
    public partial class EmployeesForm : Form
    {
        private readonly IUnityContainer _container;
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesForm(IUnityContainer container, IEmployeeRepository employeeRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<EmployeeForm>().ShowDialog();
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

                var employee = _employeeRepository.GetById(id);
                if (employee == null)
                {
                    MessageBox.Show("Сотрудник не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _container.Resolve<EmployeeForm>(
                    new ParameterOverride("employee", employee)).ShowDialog();
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
                    "Вы уверены, что хотите удалить сотрудника?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _employeeRepository.Delete(id);
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
            dataGridViewData.DataSource = _employeeRepository.GetAll();
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

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            LoadList();
        }
    }
}
