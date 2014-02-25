namespace NutritionCal.Common.Abstraction
{
    public interface IBaseInformation
    {
        double Weight { get; set; }
        double EnteredWeight { get; set; }
        WeightUnits WeightUnits { get; set; }
        int Calories { get; }
        double Protein { get; }
        double Carbohydrates { get; }
        double Fats { get; }
        double ProteinPercentage { get; }
        double CarbohydratesPercentage { get; }
        double FatsPercentage { get; }
        IGoalType GoalType { get; }
        void Calculate(IGoalType goalType);

    }
}
