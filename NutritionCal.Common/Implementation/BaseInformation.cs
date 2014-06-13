using System;
using System.Globalization;
using System.Linq;
using System.Xml.Linq;
using NutritionCal.Common.Abstraction;

namespace NutritionCal.Common.Implementation
{
    public class BaseInformation : IBaseInformation
    {

        private IGoalTypeFactory _goalTypeFactory;
        private const string Filename = @"..\..\Resources\Profile.xml";


        public double Weight { get; set; }
        public double EnteredWeight { get; set; }
        public WeightUnits WeightUnits { get; set; }
        public int Calories { get; private set; }
        public double Protein { get; private set; }
        public double Carbohydrates { get; private set; }
        public double Fats { get; private set; }
        public double ProteinPercentage { get; private set; }
        public double CarbohydratesPercentage { get; private set; }
        public double FatsPercentage { get; private set; }
        public IGoalType GoalType { get; private set; }


        public BaseInformation(IGoalTypeFactory goalTypeFactory)
        {
            _goalTypeFactory = goalTypeFactory;
        }

        public void Calculate(IGoalType goalType)
        {
            GoalType = goalType;
            Protein = CalulateProtein(goalType);
            Carbohydrates = CalulateCarbs(goalType);
            Fats = CalulateFats(goalType);
            Calories = CalculateCalories();
            CalculatePercentages();
        }

        
        public void SaveAndUpdate()
        {
            XElement profile = new XElement("Profile");

            XElement xWeight = new XElement("Weight") { Value = Weight.ToString(CultureInfo.InvariantCulture) };
            profile.Add(xWeight);
            XElement xEnteredWeight = new XElement("EnteredWeight") { Value = EnteredWeight.ToString(CultureInfo.InvariantCulture) };
            profile.Add(xEnteredWeight);
            XElement xWeightUnits = new XElement("WeightUnits") { Value = WeightUnits.ToString() };
            profile.Add(xWeightUnits);
            XElement xGoalType = new XElement("GoalType") { Value = GoalType.GetGoalType().ToString(CultureInfo.InvariantCulture) };
            profile.Add(xGoalType);

            XDocument xDoc = new XDocument();
            xDoc.Add(profile);
            xDoc.Save(Filename);
        }



        public bool ProfileExists()
        {

            try
            {
                XDocument doc = XDocument.Load(Filename);
                                
                  Weight = Convert.ToDouble(doc.Descendants("Profile").FirstOrDefault().Element("Weight").Value);
                  EnteredWeight = Convert.ToDouble(doc.Descendants("Profile").FirstOrDefault().Element("EnteredWeight").Value);
                  WeightUnits = (WeightUnits)Enum.Parse(typeof(WeightUnits), doc.Descendants("Profile").FirstOrDefault().Element("WeightUnits").Value);
                  Calculate( _goalTypeFactory.GetGoalType(Enumerations.GetEmumFromDescription<GoalTypeEnum>(doc.Descendants("Profile").FirstOrDefault().Element("GoalType").Value)));
                       

            return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return false;
        }

        #region Private Members

        private void CalculatePercentages()
        {
            ProteinPercentage = (((Protein*4)/Calories) *100);
            CarbohydratesPercentage = (((Carbohydrates * 4)/Calories) * 100);
            FatsPercentage = (((Fats * 9)/Calories)*100);
        }

        private int CalculateCalories()
        {
            return Convert.ToInt32((Protein*4) + (Carbohydrates*4) + (Fats*9));
        }

        private double CalulateProtein(IGoalType goalType)
        {
            return goalType.ProteinAmount*Weight;
        }

        private double CalulateCarbs(IGoalType goalType)
        {
            return goalType.CarbAmount * Weight;
        }

        private double CalulateFats(IGoalType goalType)
        {
            return goalType.FatAmount * Weight;
        }

        #endregion


    }
}
