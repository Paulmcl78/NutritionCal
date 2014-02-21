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
    public partial class AddMeal : Form
    {
        private readonly IFoodStats _foodStats;
        private IAllMeals _AllMeals;
        private IMeal _meal;

        public AddMeal(IFoodStats foodStats, IAllMeals meal)
        {
            InitializeComponent();
            _foodStats = foodStats;
            _AllMeals = meal;
            _meal = new Meal();

            dataGridView1.CellEndEdit += new DataGridViewCellEventHandler(onEndEdit); 
        }

        private void AddMeal_Load(object sender, EventArgs e)
        {
                        
        }

     
        private void onEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
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

        private void btnAdd_Click(object sender, EventArgs e)
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

            iMealItemBindingSource.Add(mealItem);

            _meal.AddFood(mealItem);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _meal.MealName = txtName.Text;
            _AllMeals.AddMeal(_meal);
            this.Close();
        }

    }
}
