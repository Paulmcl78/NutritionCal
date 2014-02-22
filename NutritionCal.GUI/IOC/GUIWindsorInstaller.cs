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
            container.Register(Component.For<Form1>().LifeStyle.Singleton);
            container.Register(Component.For<FrmResults>().LifeStyle.Transient);
            container.Register(Component.For<AddFood>().LifeStyle.Transient);
            container.Register(Component.For<EditFood>().LifeStyle.Transient);
            container.Register(Component.For<AddMeal>().LifeStyle.Transient);
            container.Register(Component.For<EditMeal>().LifeStyle.Transient);
        }
    }
}
