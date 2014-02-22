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
            mealitems = new List<IMealItem>();

        }
        
        public object Clone()
        {
            Meal newMeal = (Meal)this.MemberwiseClone();

            IList<IMealItem> clone = new List<IMealItem>();

             foreach (IMealItem mItem in newMeal.mealitems)
            {
               clone.Add((IMealItem)mItem.Clone());
            }

             newMeal.mealitems = clone;
            return newMeal;
        }

        public string MealName { get; set; }
        public IList<IMealItem> mealitems { get; set; }

        public void AddFood(IMealItem mealItem)
        {
            mealitems.Add(mealItem);
        }

       
        
    }
}
