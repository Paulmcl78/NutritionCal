using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NutritionCal.Common.Abstraction;
using NutritionCal.Common.Implementation;
using NutritionCal.Common;

namespace NutritionCal.Test
{
    [TestClass]
    public class GoalFactoryFixture
    {
        [TestMethod]
        public void TestGoalTypeFactoryGain()
        {
            IGoalTypeFactory goalTypeFactory = new GoalTypeFactory();

            IGoalType actualGoalType = goalTypeFactory.GetGoalType(GoalTypeEnum.GainWeight);

            Assert.IsInstanceOfType(actualGoalType,typeof(GoalGainWeight));
        }

        [TestMethod]
        public void TestGoalTypeFactoryLose()
        {
            IGoalTypeFactory goalTypeFactory = new GoalTypeFactory();

            IGoalType actualGoalType = goalTypeFactory.GetGoalType(GoalTypeEnum.LoseWeight);

            Assert.IsInstanceOfType(actualGoalType, typeof(GoalLoseWeight));
        }

        [TestMethod]
        public void TestGoalTypeFactoryLoseObese()
        {
            IGoalTypeFactory goalTypeFactory = new GoalTypeFactory();

            IGoalType actualGoalType = goalTypeFactory.GetGoalType(GoalTypeEnum.LoseWeightObese);

            Assert.IsInstanceOfType(actualGoalType, typeof(GoalLoseWeightObese));
        }

        [TestMethod]
        public void TestGoalTypeFactoryMaintain()
        {
            IGoalTypeFactory goalTypeFactory = new GoalTypeFactory();

            IGoalType actualGoalType = goalTypeFactory.GetGoalType(GoalTypeEnum.MaintainWeight);

            Assert.IsInstanceOfType(actualGoalType, typeof(GoalMaintainWeight));
        }
    }
}
