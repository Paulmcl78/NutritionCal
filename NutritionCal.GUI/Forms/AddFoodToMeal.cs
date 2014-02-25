using NutritionCal.Common.Abstraction;
using NutritionCal.Common.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NutritionCal.GUI.Properties;

namespace NutritionCal.GUI.Forms
{
    public partial class AddFoodToMeal : Form
    {
        private readonly IFoodStats _foodStats;
        private readonly IMeal _mealOrg;
        private readonly IUpdate _origin;

        public AddFoodToMeal(IMeal allMeals, IFoodStats foodStats, IUpdate original)
        {
            InitializeComponent();
            _mealOrg = allMeals;
            _foodStats = foodStats;
            _origin = original;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
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


            IEnumerable<string> names = results as string[] ?? results.ToArray();
            if (!names.Any())
            {
                MessageBox.Show(Resources.No_results_found);
                return;
            }

            lbResults.Visible = true;
            foreach (string name in names)
            {
                lbResults.Items.Add(name);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMeassurment.Text) || lbResults.SelectedIndex == -1)
            {
                MessageBox.Show(Resources.No_food_selected_or_no_measuremented_entered);
            }
            else 
            {
                IFood food = _foodStats.Foods.First(x => x.Name == lbResults.SelectedItem.ToString());

                IMealItem mealItem = new MealItem();
                mealItem.FoodName = food.Name;
                mealItem.Measure = Convert.ToDecimal(txtMeassurment.Text);
                mealItem.Protein = (food.Protein / food.Measure) * mealItem.Measure;
                mealItem.Carbs = (food.Carbs / food.Measure) * mealItem.Measure;
                mealItem.Fat = (food.Fat / food.Measure) * mealItem.Measure;
                mealItem.Calories = (food.Calories / food.Measure) * mealItem.Measure;
                mealItem.CalCalories = (mealItem.Protein * 4) + (mealItem.Carbs * 4) + (mealItem.Fat * 9);

                _mealOrg.AddFood(mealItem);

                _origin.Update();
                Close();
            }
        }

    }
}
