using NutritionCal.Common.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NutritionCal.Common.Implementation
{
    public class AllMeals:IAllMeals
    {
        private const string filename = @"..\..\Resources\Meal.xml";

        public AllMeals()
        {
           
            try
            {
                XDocument doc = XDocument.Load(filename);

                meals = (from myElements in doc.Descendants("Meal")
                         select new Meal()
                         {
                             MealName = myElements.Attribute("name").Value,
                             mealitems = (from mi in myElements.Elements("MealItem")
                                          select new MealItem()
                                          {
                                              foodName = mi.Element("FoodName").Value,
                                              Measure = Convert.ToDecimal(mi.Element("Measure").Value),
                                              Protein = Convert.ToDecimal(mi.Element("Protein").Value),
                                              Carbs = Convert.ToDecimal(mi.Element("Carbs").Value),
                                              Fat = Convert.ToDecimal(mi.Element("Fat").Value),
                                              Calories = Convert.ToDecimal(mi.Element("Calories").Value),
                                              CalCalories = Convert.ToDecimal(mi.Element("CalCalories").Value)
                                          }).ToList()

                         }).ToList<IMeal>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

       public IEnumerable<IMeal> meals { get; set; }


       public void AddMeal(IMeal meal)
       {
           meals = meals.Concat(new[] { meal });
       }

       public void SaveChanged()
       {
           XElement allFoods = new XElement("Meals");

           int count = 0;

           foreach(IMeal meal in meals)
           {
               XAttribute mealAtt = new XAttribute("name", meal.MealName);
               XElement Meal = new XElement("Meal",mealAtt);
               //Meal.Attribute = new XAttribute("name", meal.MealName);
           }
       }

    }
}
