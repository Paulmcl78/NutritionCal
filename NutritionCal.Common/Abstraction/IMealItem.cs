using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCal.Common.Abstraction
{
    public interface IMealItem
    {
        string foodName { get; set; }
        decimal Measure { get; set; }
        decimal Protein { get; set; }
        decimal Carbs { get; set; }
        decimal Fat { get; set; }
        decimal Calories { get; set; }
        decimal CalCalories { get; set; }
    }
}
