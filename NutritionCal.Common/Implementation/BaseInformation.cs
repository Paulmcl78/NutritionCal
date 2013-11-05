using System;
using NutritionCal.Common.Abstraction;

namespace NutritionCal.Common.Implementation
{
    public class BaseInformation : IBaseInformation
    {
        public double Weight { get; set; }
        public int Calories { get; private set; }
        public double Protein { get; private set; }
        public double Carbohydrates { get; private set; }
        public double Fats { get; private set; }
        public double ProteinPercentage { get; private set; }
        public double CarbohydratesPercentage { get; private set; }
        public double FatsPercentage { get; private set; }
        
        public void Calculate(IGoalType goalType)
        {
            Protein = CalulateProtein(goalType);
            Carbohydrates = CalulateCarbs(goalType);
            Fats = CalulateFats(goalType);
            Calories = CalculateCalories();
            CalculatePercentages();
        }

        #region Private Members

        private void CalculatePercentages()
        {
            ProteinPercentage = (((Protein*4)/Calories) *100);
            CarbohydratesPercentage = (((Carbohydrates * 4)/Calories) * 100);
            FatsPercentage = (((Fats * 9)/Calories)*100);
        }

        private int CalculateCalories()
        {
            return Convert.ToInt32((Protein*4) + (Carbohydrates*4) + (Fats*9));
        }

        private double CalulateProtein(IGoalType goalType)
        {
            return goalType.ProteinAmount*Weight;
        }

        private double CalulateCarbs(IGoalType goalType)
        {
            return goalType.CarbAmount * Weight;
        }

        private double CalulateFats(IGoalType goalType)
        {
            return goalType.FatAmount * Weight;
        }

        #endregion


    }
}
