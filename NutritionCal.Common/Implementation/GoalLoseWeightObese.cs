using NutritionCal.Common.Abstraction;

namespace NutritionCal.Common.Implementation
{
    public class GoalLoseWeightObese : IGoalType
    {
        public GoalLoseWeightObese()
        {
            ProteinAmount = 0.8;
            FatAmount = 0.3;
            CarbAmount = 0.7;
        }

        public double ProteinAmount { get; private set; }
        public double FatAmount { get; private set; }
        public double CarbAmount { get; private set; }

        public string GetGoalType()
        {
            return Enumerations.GetEnumDescription(GoalTypeEnum.LoseWeightObese);
        }
    }
}
