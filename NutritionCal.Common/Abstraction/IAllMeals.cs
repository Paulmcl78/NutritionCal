using System.Collections.Generic;

namespace NutritionCal.Common.Abstraction
{
    public interface IAllMeals
    {
        IList<IMeal> meals { get; set; }

        void AddMeal(IMeal meal);

        void SaveChanged();
    }
}
