using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;

namespace NutritionCal.Common.IOC
{
    public static class CastleContainer
    {
        private static WindsorContainer _container;

        public static WindsorContainer Instance
        {
            get { return _container ?? (_container = BootStrapper.Instance.BootstrapIoc()); }
            set { _container = value; }
        }

        public static T Resolve<T>()
        {
            return Instance.Resolve<T>();
        }

        public static T Resolve<T>(object args)
        {
            return Instance.Resolve<T>(args);
        }

        public static void Dispose()
        {
            if (_container == null) return;
            _container.Dispose();
            _container = null;
        }
    }
}
