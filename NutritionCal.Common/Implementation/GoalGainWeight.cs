using System;
using System.ComponentModel;
using System.Reflection;
using NutritionCal.Common.Abstraction;

namespace NutritionCal.Common.Implementation
{
    public class GoalGainWeight :IGoalType
    {
        public GoalGainWeight()
        {
            ProteinAmount = 1;
            FatAmount = 0.33;
            CarbAmount = 2.0;

            
        }

        public string GetGoalType()
        {
            return Enumerations.GetEnumDescription(GoalTypeEnum.GainWeight);
        }

        public double ProteinAmount { get; private set; }
        public double FatAmount { get; private set; }
        public double CarbAmount { get; private set; }


        
    }
}
