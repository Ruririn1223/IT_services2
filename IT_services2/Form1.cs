using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace IT_services2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly IUnityContainer _container;

        public Form1(IUnityContainer container)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
        }
        private void MenuItemOrganizations_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<OrganizationsForm>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MenuItemEmployees_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<EmployeesForm>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuItemSystems_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<SystemsForm>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MenuItemContracts_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<ContractsForm>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MenuItemReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Раздел в разработке", "Отчеты", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
