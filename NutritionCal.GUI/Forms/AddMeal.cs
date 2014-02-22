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
    public partial class AddMeal : Form, IUpdate
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

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddFoodToMeal addFood = new AddFoodToMeal(_meal, _foodStats, this);
            addFood.ShowDialog(); 
        }

        void IUpdate.Update()
        {
            iMealItemBindingSource.Clear();

            foreach (IMealItem mealItem in _meal.mealitems)
            {
                iMealItemBindingSource.Add(mealItem);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _meal.MealName = txtName.Text;
            _AllMeals.AddMeal(_meal);
            _AllMeals.SaveChanged();
            this.Close();
        }


        private void dataGridView1_CellChanged(object sender, DataGridViewCellEventArgs e)
        {
           string foodName = dataGridView1[0,e.RowIndex].Value.ToString();


           IFood food = _foodStats.Foods
              .Where(x => x.Name == foodName)
              .First();

           IMealItem mealItem = _meal.mealitems
               .Where(x => x.foodName == food.Name)
               .First();

           mealItem.Measure = Convert.ToDecimal(dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString());
           mealItem.Protein = (food.Protein / food.Measure) * mealItem.Measure;
           mealItem.Carbs = (food.Carbs / food.Measure) * mealItem.Measure;
           mealItem.Fat = (food.Fat / food.Measure) * mealItem.Measure;
           mealItem.Calories = (food.Calories / food.Measure) * mealItem.Measure;
           mealItem.CalCalories = (mealItem.Protein * 4) + (mealItem.Carbs * 4) + (mealItem.Fat * 9);

        }

    }
}
