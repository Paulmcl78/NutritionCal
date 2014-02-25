using NutritionCal.Common.Abstraction;

namespace NutritionCal.Common.Implementation
{
    public class Food :IFood
    {
        public string Name { get; set; }

        public decimal Measure { get; set; }

        public decimal Protein { get; set; }

        public decimal Carbs { get; set; }

        public decimal Fat { get; set; }

        public decimal Calories { get; set; }
    }
}
