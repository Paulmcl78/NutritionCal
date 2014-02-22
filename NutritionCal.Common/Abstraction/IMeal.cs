using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCal.Common.Abstraction
{
    public interface IMeal : ICloneable
    {

        string MealName { get; set; }
        IList<IMealItem> mealitems { get; set; }

        void AddFood(IMealItem mealItem);

        
    }
}
