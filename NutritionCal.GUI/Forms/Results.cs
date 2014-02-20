using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using NutritionCal.Common.Abstraction;
using NutritionCal.Common.IOC;

namespace NutritionCal.GUI.Forms
{
    public partial class FrmResults : Form
    {
        private readonly IBaseInformation _baseInformation;
        private readonly IFoodStats _foodStats;

        public FrmResults(IBaseInformation baseInformation, IFoodStats foodstats)
        {
            InitializeComponent();
            _baseInformation = baseInformation;
            _foodStats = foodstats;
        }

         private void Results_Load(object sender, EventArgs e)
        {

            
            buildTable();

            tlpFinal.Controls.Add(tlpResults, 0, 0);
            
           
        }

        private void buildTable()
         {
             tlpResults.Controls.Add(BuildLabel("Protein"), 1, 0);
             tlpResults.Controls.Add(BuildLabel("Carbs"), 2, 0);
             tlpResults.Controls.Add(BuildLabel("Fats"), 3, 0);
             tlpResults.Controls.Add(BuildLabel("Calories"), 4, 0);

             tlpResults.Controls.Add(BuildLabel("Values"), 0, 1);
             tlpResults.Controls.Add(BuildLabel(_baseInformation.Protein.ToString(CultureInfo.InvariantCulture)), 1, 1);
             tlpResults.Controls.Add(BuildLabel(_baseInformation.Carbohydrates.ToString(CultureInfo.InvariantCulture)), 2, 1);
             tlpResults.Controls.Add(BuildLabel(_baseInformation.Fats.ToString(CultureInfo.InvariantCulture)), 3, 1);
             tlpResults.Controls.Add(BuildLabel(_baseInformation.Calories.ToString(CultureInfo.InvariantCulture)), 4, 1);

             tlpResults.Controls.Add(BuildLabel("Percentages"), 0, 2);
             tlpResults.Controls.Add(BuildLabel(string.Format("{0}%",Math.Round(_baseInformation.ProteinPercentage, 2).ToString(CultureInfo.InvariantCulture))), 1, 2);
             tlpResults.Controls.Add(BuildLabel(string.Format("{0}%",Math.Round(_baseInformation.CarbohydratesPercentage, 2).ToString(CultureInfo.InvariantCulture))), 2, 2);
             tlpResults.Controls.Add(BuildLabel(string.Format("{0}%",Math.Round(_baseInformation.FatsPercentage, 2).ToString(CultureInfo.InvariantCulture))), 3, 2);
             tlpResults.Controls.Add(BuildLabel(string.Format("{0}%",Math.Round(_baseInformation.CarbohydratesPercentage, 2).ToString(CultureInfo.InvariantCulture))), 4, 2);







         }

        private Label BuildLabel(string text)
        {
            Label label = new Label();
            label.Dock = DockStyle.Fill;
            label.Text = text;
            label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            return label;
        }

       

        private void addFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFood results = CastleContainer.Resolve<AddFood>();
            results.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetWeightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearForm();
            Form1 resetWeight = CastleContainer.Resolve<Form1>();
            resetWeight.Show();
            this.Close();
        }


        private void clearForm()
        {

        }

        private void editFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditFood results = CastleContainer.Resolve<EditFood>();
            results.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addMealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMeal form = CastleContainer.Resolve<AddMeal>();
            form.Show();
        }




    }
}
