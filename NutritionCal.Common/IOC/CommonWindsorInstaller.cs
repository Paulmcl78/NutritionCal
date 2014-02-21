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
            container.Register(Component.For<IBaseInformation>().ImplementedBy<BaseInformation>().LifeStyle.Singleton);
            container.Register(Component.For<IGoalTypeFactory>().ImplementedBy<GoalTypeFactory>().LifeStyle.Singleton);
            container.Register(Component.For<IFoodStats>().ImplementedBy<FoodStats>().LifeStyle.Singleton);
            container.Register(Component.For<IAllMeals>().ImplementedBy<AllMeals>().LifeStyle.Singleton);
        }
    }
}
