using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCal.Common.Abstraction
{
    public interface IMeal
    {
        string MealName { get; set; }
        IEnumerable<IMealItem> mealitems { get; set; }
    }
}
