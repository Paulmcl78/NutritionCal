using NutritionCal.Common.Abstraction;
using System.Collections.Generic;

namespace NutritionCal.Common.Implementation
{
    public class Meal :IMeal
    {
        
        public Meal()
        {
            Mealitems = new List<IMealItem>();

        }
        
        public object Clone()
        {
            Meal newMeal = (Meal)this.MemberwiseClone();

            IList<IMealItem> clone = new List<IMealItem>();

             foreach (IMealItem mItem in newMeal.Mealitems)
            {
               clone.Add((IMealItem)mItem.Clone());
            }

             newMeal.Mealitems = clone;
            return newMeal;
        }

        public string MealName { get; set; }
        public IList<IMealItem> Mealitems { get; set; }

        public void AddFood(IMealItem mealItem)
        {
            Mealitems.Add(mealItem);
        }

       
        
    }
}
