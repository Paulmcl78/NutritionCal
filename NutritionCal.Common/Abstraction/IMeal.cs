using System;
using System.Collections.Generic;

namespace NutritionCal.Common.Abstraction
{
    public interface IMeal : ICloneable
    {

        string MealName { get; set; }
        IList<IMealItem> Mealitems { get; set; }

        void AddFood(IMealItem mealItem);

        
    }
}
