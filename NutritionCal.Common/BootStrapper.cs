using Castle.Windsor;

namespace NutritionCal.Common
{
    public class BootStrapper
    {
        private static readonly BootStrapper instance = new BootStrapper();
        private static readonly WindsorContainer Container = new WindsorContainer();

        public static BootStrapper Instance { get { return instance; } }

        static BootStrapper()
        {
        }

        private BootStrapper()
        {
        }

        public WindsorContainer BootstrapIoc()
        {
            return Container;
        }


    }
}
