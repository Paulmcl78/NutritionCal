using System.Xml.Serialization;
using NutritionCal.Common.Abstraction;

namespace NutritionCal.Common.Implementation
{
    public class Food :IFood
    {
        //[XmlElement("Name")]
        public string Name { get; set; }

        //[XmlElement("Measure")]
        public decimal Measure { get; set; }

        //[XmlElement("Protein")]
        public decimal Protein { get; set; }

        //[XmlElement("Carbs")]
        public decimal Carbs { get; set; }

        //[XmlElement("Fat")]
        public decimal Fat { get; set; }

        //[XmlElement("Calories")]
        public decimal Calories { get; set; }
    }
}
