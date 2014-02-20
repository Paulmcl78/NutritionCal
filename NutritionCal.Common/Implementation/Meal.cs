using NutritionCal.Common.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCal.Common.Implementation
{
    public class Meal :IMeal
    {
        public string MealName { get; set; }
        public IEnumerable<IMealItem> mealitems { get; set; }
    }
}
