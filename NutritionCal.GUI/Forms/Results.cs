using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NutritionCal.Common.Abstraction;

namespace NutritionCal.GUI.Forms
{
    public partial class frmResults : Form
    {
        private readonly IBaseInformation _baseInformation;

        public frmResults(IBaseInformation baseInformation)
        {
            InitializeComponent();
            _baseInformation = baseInformation;
        }

        private void Results_Load(object sender, EventArgs e)
        {
            txtCalories.Text = _baseInformation.Calories.ToString(CultureInfo.InvariantCulture);
            txtCarbPercent.Text = Math.Round(_baseInformation.CarbohydratesPercentage,2).ToString(CultureInfo.InvariantCulture);
            txtCarbs.Text = _baseInformation.Carbohydrates.ToString(CultureInfo.InvariantCulture);
            txtFat.Text = _baseInformation.Fats.ToString(CultureInfo.InvariantCulture);
            txtFatPercent.Text = Math.Round(_baseInformation.FatsPercentage,2).ToString(CultureInfo.InvariantCulture);
            txtProtein.Text = _baseInformation.Protein.ToString(CultureInfo.InvariantCulture);
            txtProteinPercent.Text = Math.Round(_baseInformation.ProteinPercentage,2).ToString(CultureInfo.InvariantCulture);

        }





    }
}
