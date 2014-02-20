using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionCal.Common.Abstraction
{
    public interface IFoodStats
    {
        IEnumerable<IFood> Foods { get; set; }

        void AddFood(string name, decimal measure, decimal protein, decimal carbs, decimal fat, decimal calories);

        bool foodExists(string name);
        
        void SaveChanges();
    }
}
