using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using NutritionCal.Common.Abstraction;

namespace NutritionCal.GUI.Forms
{
    public partial class FrmResults : Form
    {
        private readonly IBaseInformation _baseInformation;
        private IFoodStats _foodStats;

        public FrmResults(IBaseInformation baseInformation)
        {
            InitializeComponent();
            _baseInformation = baseInformation;
        }

        #region properties
        public IFoodStats FoodStats
        {
            get { return _foodStats; }
            set { _foodStats = value; }
        }

        #endregion


        private void Results_Load(object sender, EventArgs e)
        {
            txtCalories.Text = _baseInformation.Calories.ToString(CultureInfo.InvariantCulture);
            txtCarbPercent.Text = Math.Round(_baseInformation.CarbohydratesPercentage,2).ToString(CultureInfo.InvariantCulture);
            txtCarbs.Text = _baseInformation.Carbohydrates.ToString(CultureInfo.InvariantCulture);
            txtFat.Text = _baseInformation.Fats.ToString(CultureInfo.InvariantCulture);
            txtFatPercent.Text = Math.Round(_baseInformation.FatsPercentage,2).ToString(CultureInfo.InvariantCulture);
            txtProtein.Text = _baseInformation.Protein.ToString(CultureInfo.InvariantCulture);
            txtProteinPercent.Text = Math.Round(_baseInformation.ProteinPercentage,2).ToString(CultureInfo.InvariantCulture);

            test();
        }

        private void test()
        {

            FoodStats.AddFood("test", 1, 1, 1, 1, 1);

            txtCalories.Text = FoodStats.Foods.First(x => x.Name == "test").Name;


        }





    }
}
