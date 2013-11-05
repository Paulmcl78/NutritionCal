namespace NutritionCal.Common.Abstraction
{
    public interface IBaseInformation
    {
        double Weight { get; set; }
        int Calories { get; }
        double Protein { get; }
        double Carbohydrates { get; }
        double Fats { get; }
        double ProteinPercentage { get; }
        double CarbohydratesPercentage { get; }
        double FatsPercentage { get; }
        void Calculate(IGoalType goalType);

    }
}
