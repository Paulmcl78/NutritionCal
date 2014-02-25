using NutritionCal.Common.Abstraction;

namespace NutritionCal.Common.Implementation
{
    public class GoalMaintainWeight : IGoalType
    {
        public GoalMaintainWeight()
        {
            ProteinAmount = 1;
            FatAmount = 0.25;
            CarbAmount = 1.5;
        }

        public double ProteinAmount { get; private set; }
        public double FatAmount { get; private set; }
        public double CarbAmount { get; private set; }


        public string GetGoalType()
        {
            return Enumerations.GetEnumDescription(GoalTypeEnum.MaintainWeight);
        }
    }
}
