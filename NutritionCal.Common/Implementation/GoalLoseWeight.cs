using NutritionCal.Common.Abstraction;

namespace NutritionCal.Common.Implementation
{
    public class GoalLoseWeight :IGoalType
    {
        public GoalLoseWeight()
        {
            ProteinAmount = 1.2;
            FatAmount = 0.2;
            CarbAmount = 1.0;
        }

        public double ProteinAmount { get; private set; }
        public double FatAmount { get; private set; }
        public double CarbAmount { get; private set; }

        public string GetGoalType()
        {
            return Enumerations.GetEnumDescription(GoalTypeEnum.LoseWeight);
        }
    }
}
