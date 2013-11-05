using NutritionCal.Common.Abstraction;

namespace NutritionCal.Common.Implementation
{
    public class GoalTypeFactory : IGoalTypeFactory
    {
        public IGoalType GetGoalType(GoalTypeEnum goalTypeEnum)
        {
            switch (goalTypeEnum)
            {
                 case GoalTypeEnum.GainWeight:
                    return new GoalGainWeight();
                case GoalTypeEnum.LoseWeight:
                    return new GoalLoseWeight();
                case GoalTypeEnum.LoseWeightObese:
                    return new GoalLoseWeightObese();
                case GoalTypeEnum.MaintainWeight:
                    return new GoalMaintainWeight();
            }

            return null;
        }
    }
}