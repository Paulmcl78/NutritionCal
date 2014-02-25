using System.Collections.Generic;

namespace NutritionCal.Common.Abstraction
{
    public interface IFoodStats
    {
        IList<IFood> Foods { get; set; }

        void AddFood(string name, decimal measure, decimal protein, decimal carbs, decimal fat, decimal calories);

        bool FoodExists(string name);
        
        void SaveChanges();
    }
}
