namespace NutritionCal.Common.Abstraction
{
    public interface IGoalTypeFactory
    {
        IGoalType GetGoalType(GoalTypeEnum goalTypeEnum);
    }
}