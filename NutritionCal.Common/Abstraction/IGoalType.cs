namespace NutritionCal.Common.Abstraction
{
    public interface IGoalType
    {
        double ProteinAmount { get; }
        double FatAmount { get; }
        double CarbAmount { get; }
    }
}
