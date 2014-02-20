namespace NutritionCal.Common.Abstraction
{
    public interface IFood
    {
        string Name { get; set; }
        decimal Measure { get; set; }
        decimal Protein { get; set; }
        decimal Carbs { get; set; }
        decimal Fat { get; set; }
        decimal Calories { get; set; }
    }
}
