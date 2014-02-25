using System.Globalization;
using NutritionCal.Common.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace NutritionCal.Common.Implementation
{
    public class AllMeals:IAllMeals
    {

        public AllMeals ShallowCopy()
        {
            return (AllMeals)MemberwiseClone();
        }

        private const string Filename = @"..\..\Resources\Meal.xml";

        public AllMeals()
        {
           
            try
            {
                XDocument doc = XDocument.Load(Filename);

                meals = (from myElements in doc.Descendants("Meal")
                         select new Meal
                             {
                             MealName = myElements.Attribute("name").Value,
                             Mealitems = (from mi in myElements.Elements("MealItem")
                                          let xElementFoodName = mi.Element("FoodName")
                                          where xElementFoodName != null
                                          let xElementMeassure = mi.Element("Measure")
                                          where xElementMeassure != null
                                          let xElementProtein = mi.Element("Protein")
                                          where xElementProtein != null
                                          let xElementCarbs = mi.Element("Carbs")
                                          where xElementCarbs != null
                                          let xElementFats = mi.Element("Fat")
                                          where xElementFats != null
                                          let xElementCalories = mi.Element("Calories")
                                          where xElementCalories != null
                                          let xElementCalCalories = mi.Element("CalCalories")
                                          where xElementCalCalories != null
                                          select new MealItem
                                              {
                                              FoodName = xElementFoodName.Value,
                                              Measure = Convert.ToDecimal(xElementMeassure.Value),
                                              Protein = Convert.ToDecimal(xElementProtein.Value),
                                              Carbs = Convert.ToDecimal(xElementCarbs.Value),
                                              Fat = Convert.ToDecimal(xElementFats.Value),
                                              Calories = Convert.ToDecimal(xElementCalories.Value),
                                              CalCalories = Convert.ToDecimal(xElementCalCalories.Value)
                                          }).ToList<IMealItem>()

                         }).ToList<IMeal>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

       public IList<IMeal> meals { get; set; }


       public void AddMeal(IMeal meal)
       {
           meals.Add(meal);
       }

       public void SaveChanged()
       {
           XElement allFoods = new XElement("Meals");

           XElement Meal;
           foreach(IMeal meal in meals)
           {
               XAttribute mealAtt = new XAttribute("name", meal.MealName);
               Meal = new XElement("Meal",mealAtt);
               foreach (
                   XElement mealItemElement in 
                    from mealItem 
                        in meal.Mealitems 
                            let name = new XElement("FoodName") { Value = mealItem.FoodName } 
                            let measure = new XElement("Measure") { Value = mealItem.Measure.ToString(CultureInfo.InvariantCulture) } 
                            let protein = new XElement("Protein") { Value = mealItem.Protein.ToString(CultureInfo.InvariantCulture) } 
                            let carbs = new XElement("Carbs") { Value = mealItem.Carbs.ToString(CultureInfo.InvariantCulture) } 
                            let fat = new XElement("Fat") { Value = mealItem.Fat.ToString(CultureInfo.InvariantCulture) } 
                            let calories = new XElement("Calories") { Value = mealItem.Calories.ToString(CultureInfo.InvariantCulture) } 
                            let calCalories = new XElement("CalCalories") { Value = mealItem.CalCalories.ToString(CultureInfo.InvariantCulture) } 
                    select new XElement("MealItem", name, measure, protein, carbs, fat, calories, calCalories))
               {
                   Meal.Add(mealItemElement);
               }
              allFoods.Add(Meal);
           }

           XDocument xDoc = new XDocument();
           xDoc.Add(allFoods);
           xDoc.Save(Filename);
       }

    }
}
