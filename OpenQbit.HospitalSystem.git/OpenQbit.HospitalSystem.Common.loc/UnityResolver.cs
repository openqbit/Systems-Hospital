using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using OpenQbit.Hospital.BusinessService.Contracts;
using OpenQbit.Hospital.DataAccess.DAL.Contracts;
using OpenQbit.Hospital.DataAccsess.DAL;
using OpenQbit.Hospital.Common.Utils.Logs;
using OpenQbit.Hospital.BusinessService;

namespace OpenQbit.Masterdb.Common.Ioc
{
    public class UnityResolver
    {
        private static readonly IUnityContainer Container = new UnityContainer();

        public static void Register()
        {
            Container.RegisterType<IRepository, Repository>();
            Container.RegisterType<ILogger, LoggerB>();

            Container.RegisterType<IOrderManager, OrderManager>();
            Container.RegisterType<IInventoryManager, InventoryManager>();
            Container.RegisterType<IItemManager, ItemManager>();
            Container.RegisterType<IPatientManager, PatientManager>();

        }

        public static T Resolve<T>()
        {
            T defaultT = default(T);
            var resolved = Container.Resolve<T>();
            return (resolved == null) ? defaultT : resolved;
        }

        public static IUnityContainer GetContainer()
        {
            return Container;
        }
    }
}
