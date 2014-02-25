using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml.Linq;
using NutritionCal.Common.Abstraction;

namespace NutritionCal.Common.Implementation
{
    public class FoodStats :IFoodStats
    {
        private const string Filename = @"..\..\Resources\FoodStats.xml";

        public FoodStats()
        {
            try
            {
                XDocument doc = XDocument.Load(Filename);

                Foods = (from c in doc.Descendants("Food")
                         let xElementName = c.Element("Name")
                         where xElementName != null
                         let xElementMeasure = c.Element("Measure")
                         where xElementMeasure != null
                         let xElementProtein = c.Element("Protein")
                         where xElementProtein != null
                         let xElementCarbs = c.Element("Carbs")
                         where xElementCarbs != null
                         let xElementFats = c.Element("Fat")
                         where xElementFats != null
                         let xElementCalories = c.Element("Calories")
                         where xElementCalories != null
                         select new Food
                             {
                                 Name = xElementName.Value,
                                 Measure = Convert.ToDecimal(xElementMeasure.Value),
                                 Protein = Convert.ToDecimal(xElementProtein.Value),
                                 Carbs = Convert.ToDecimal(xElementCarbs.Value),
                                 Fat = Convert.ToDecimal(xElementFats.Value),
                                 Calories = Convert.ToDecimal(xElementCalories.Value),

                             }).ToList<IFood>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        public IList<IFood> Foods { get; set; }
        
        
        public void AddFood(string name, decimal measure, decimal protein, decimal carbs, decimal fat, decimal calories)
        {
            Foods.Add(new Food
                        {
                            Name = name,
                            Measure = measure,
                            Protein = protein,
                            Carbs = carbs,
                            Fat = fat,
                            Calories = calories
                        });
        }

        public void SaveChanges()
        {

            XElement allFoods = new XElement("FoodStats");

           
            foreach (var food in Foods)
            {

                XElement name = new XElement("Name") {Value = food.Name};
                XElement measure = new XElement("Measure") { Value = food.Measure.ToString(CultureInfo.InvariantCulture) };
                XElement protein = new XElement("Protein") { Value = food.Protein.ToString(CultureInfo.InvariantCulture) };
                XElement carbs = new XElement("Carbs") { Value = food.Carbs.ToString(CultureInfo.InvariantCulture) };
                XElement fat = new XElement("Fat") { Value = food.Fat.ToString(CultureInfo.InvariantCulture) };
                XElement calories = new XElement("Calories") { Value = food.Calories.ToString(CultureInfo.InvariantCulture) };

               XElement foodElement = new XElement("Food",name,measure,protein,carbs,fat,calories);

                allFoods.Add(foodElement);

            }
 
            XDocument xDoc = new XDocument();
            xDoc.Add(allFoods);
            xDoc.Save(Filename);
        }


        public bool FoodExists(string name)
        {
            return Foods.Any(x => x.Name.ToLower() == name.ToLower());
        }
    }
}
