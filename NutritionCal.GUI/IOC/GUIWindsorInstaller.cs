using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using NutritionCal.GUI.Forms;

namespace NutritionCal.GUI.IOC
{
    public class GUIWindsorInstaller :IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<Form1>());
        }
    }
}
