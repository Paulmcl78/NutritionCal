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
        private const string filename = @"..\..\Resources\FoodStats.xml";

        public FoodStats()
        {
            try
            {
                XDocument doc = XDocument.Load(filename);

                Foods = (from c in doc.Descendants("Food")
                         select new Food()
                             {
                                 Name = c.Element("Name").Value,
                                 Measure = Convert.ToDecimal(c.Element("Measure").Value),
                                 Protein = Convert.ToDecimal(c.Element("Protein").Value),
                                 Carbs = Convert.ToDecimal(c.Element("Carbs").Value),
                                 Fat = Convert.ToDecimal(c.Element("Fat").Value),
                                 Calories = Convert.ToDecimal(c.Element("Calories").Value),

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
            xDoc.Save(filename);
        }


        public bool foodExists(string name)
        {
            return Foods.Any(x => x.Name.ToLower() == name.ToLower());
        }
    }
}
