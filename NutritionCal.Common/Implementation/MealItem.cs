using NutritionCal.Common.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCal.Common.Implementation
{
    public class MealItem: IMealItem
    {

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public string foodName { get; set; }
        public decimal Measure { get; set; }
        public decimal Protein { get; set; }
        public decimal Carbs { get; set; }
        public decimal Fat { get; set; }
        public decimal Calories { get; set; }
        public decimal CalCalories { get; set; }
    }
}
