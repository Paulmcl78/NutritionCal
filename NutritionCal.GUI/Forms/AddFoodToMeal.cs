using NutritionCal.Common.Abstraction;
using NutritionCal.Common.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutritionCal.GUI.Forms
{
    public partial class AddFoodToMeal : Form
    {
        private IFoodStats _foodStats;
        private IMeal _mealOrg;
        private IUpdate _origin;

        public AddFoodToMeal(IMeal AllMeals, IFoodStats foodStats, IUpdate original)
        {
            InitializeComponent();
            _mealOrg = AllMeals;
            _foodStats = foodStats;
            _origin = original;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbResults.Items.Clear();

            IEnumerable<string> results;

            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                results = _foodStats.Foods
                 .OrderBy(o => o.Name)
                 .Select(i => i.Name);
            }
            else
            {
                results = _foodStats.Foods
                .OrderBy(o => o.Name)
                .Where(x => x.Name.ToLower().Contains(txtSearch.Text.ToLower()))
                .Select(i => i.Name);
            }


            if (results.Count() == 0)
            {
                MessageBox.Show("No results found");
                return;
            }

            lbResults.Visible = true;
            foreach (string name in results)
            {
                lbResults.Items.Add(name);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMeassurment.Text) || lbResults.SelectedIndex == -1)
            {
                MessageBox.Show("No food selected or no measuremented entered");
            }
            else 
            {
                IFood food = _foodStats.Foods
               .Where(x => x.Name == lbResults.SelectedItem.ToString())
               .First();

                IMealItem mealItem = new MealItem();
                mealItem.foodName = food.Name;
                mealItem.Measure = Convert.ToDecimal(txtMeassurment.Text);
                mealItem.Protein = (food.Protein / food.Measure) * mealItem.Measure;
                mealItem.Carbs = (food.Carbs / food.Measure) * mealItem.Measure;
                mealItem.Fat = (food.Fat / food.Measure) * mealItem.Measure;
                mealItem.Calories = (food.Calories / food.Measure) * mealItem.Measure;
                mealItem.CalCalories = (mealItem.Protein * 4) + (mealItem.Carbs * 4) + (mealItem.Fat * 9);

                _mealOrg.AddFood(mealItem);

                _origin.Update();
                this.Close();
            }
        }

    }
}
