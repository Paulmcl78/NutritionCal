using System;

namespace NutritionCal.Common.Abstraction
{
    public interface IMealItem: ICloneable
    {
        string FoodName { get; set; }
        decimal Measure { get; set; }
        decimal Protein { get; set; }
        decimal Carbs { get; set; }
        decimal Fat { get; set; }
        decimal Calories { get; set; }
        decimal CalCalories { get; set; }
    }
}
