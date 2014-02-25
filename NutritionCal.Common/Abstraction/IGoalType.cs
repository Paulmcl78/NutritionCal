namespace NutritionCal.Common.Abstraction
{
    public interface IGoalType
    {
        string GetGoalType();
        double ProteinAmount { get; }
        double FatAmount { get; }
        double CarbAmount { get; }
    }
}
