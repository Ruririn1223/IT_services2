using IT_services2.Repositories;
using IT_services2.Repositories.Implementation;
using IT_services2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace IT_services
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(CreateContainer().Resolve<Form1>());
        }

        private static IUnityContainer CreateContainer()
        {
            var container = new UnityContainer();

            // Регистрация справочников (полный CRUD)
            container.RegisterType<IOrganizationRepository, OrganizationRepositoryStub>(
                new Unity.Lifetime.TransientLifetimeManager());
            container.RegisterType<IEmployeeRepository, EmployeeRepositoryStub>(
                new Unity.Lifetime.TransientLifetimeManager());
            container.RegisterType<ISystemRepository, SystemRepositoryStub>(
                new Unity.Lifetime.TransientLifetimeManager());

            // Регистрация операции (только Create + Read)
            container.RegisterType<IContractRepository, ContractRepositoryStub>(
                new Unity.Lifetime.TransientLifetimeManager());

            // Регистрация связки M:N
            container.RegisterType<IContractSystemRepository, ContractSystemRepositoryStub>(
                new Unity.Lifetime.TransientLifetimeManager());

            return container;
        }
    }
}