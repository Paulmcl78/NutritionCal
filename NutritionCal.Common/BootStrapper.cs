using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;

namespace NutritionCal.Common
{
    public class BootStrapper
    {
        private static readonly BootStrapper instance = new BootStrapper();
        private static WindsorContainer container = new WindsorContainer();

        public static BootStrapper Instance { get { return instance; } }

        static BootStrapper()
        {
        }

        private BootStrapper()
        {
        }

        public WindsorContainer BootstrapIoc()
        {
            return container;
        }


    }
}
