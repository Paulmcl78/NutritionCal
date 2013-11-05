using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using NutritionCal.Common.Abstraction;
using NutritionCal.Common.Implementation;

namespace NutritionCal.Common.IOC
{
    public class CommonWindsorInstaller :IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IBaseInformation>().ImplementedBy<BaseInformation>().LifeStyle.Transient);
            container.Register(Component.For<IGoalTypeFactory>().ImplementedBy<GoalTypeFactory>());
        }
    }
}
