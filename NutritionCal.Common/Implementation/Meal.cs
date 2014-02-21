using NutritionCal.Common.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NutritionCal.Common.Implementation
{
    public class Meal :IMeal
    {
        
        public Meal()
        {
            mealitems = Enumerable.Empty<IMealItem>();

           
        }
        public string MealName { get; set; }
        public IEnumerable<IMealItem> mealitems { get; set; }

        public void AddFood(IMealItem mealItem)
        {
            mealitems = mealitems.Concat(new[] { mealItem });
        }

       
        
    }
}
