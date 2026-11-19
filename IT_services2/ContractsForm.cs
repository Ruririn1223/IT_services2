using System;
using System.Windows.Forms;
using Unity;
using IT_services2.Repositories;

namespace IT_services2
{
    public partial class ContractsForm : Form
    {
        private readonly IUnityContainer _container;
        private readonly IContractRepository _contractRepository;

        public ContractsForm(IUnityContainer container, IContractRepository contractRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _contractRepository = contractRepository ?? throw new ArgumentNullException(nameof(contractRepository));
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<ContractForm>().ShowDialog();
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadList()
        {
            dataGridViewData.DataSource = _contractRepository.GetAll();
        }

        private void ContractsForm_Load(object sender, EventArgs e)
        {
            LoadList();
        }
    }
}
