using NutritionCal.Common.Abstraction;
using NutritionCal.Common.Implementation;
using System;
using System.Linq;
using System.Windows.Forms;

namespace NutritionCal.GUI.Forms
{
    public partial class AddMeal : Form, IUpdate
    {
        private readonly IFoodStats _foodStats;
        private readonly IAllMeals _allMeals;
        private readonly IMeal _meal;
        private readonly IUpdate _origin;

        public AddMeal(IFoodStats foodStats, IAllMeals meal, IUpdate origin)
        {
            InitializeComponent();
            _foodStats = foodStats;
            _allMeals = meal;
            _meal = new Meal();
            _origin = origin;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddFoodToMeal addFood = new AddFoodToMeal(_meal, _foodStats, this);
            addFood.ShowDialog(); 
        }

        void IUpdate.Update()
        {
            iMealItemBindingSource.Clear();

            foreach (IMealItem mealItem in _meal.Mealitems)
            {
                iMealItemBindingSource.Add(mealItem);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _meal.MealName = txtName.Text;
            _allMeals.AddMeal(_meal);
            _allMeals.SaveChanged();
            _origin.Update();
            Close();
        }


        private void dataGridView1_CellChanged(object sender, DataGridViewCellEventArgs e)
        {
           string foodName = dataGridView1[0,e.RowIndex].Value.ToString();


           IFood food = _foodStats.Foods.First(x => x.Name == foodName);

           IMealItem mealItem = _meal.Mealitems.First(x => x.FoodName == food.Name);

           mealItem.Measure = Convert.ToDecimal(dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString());
           mealItem.Protein = (food.Protein / food.Measure) * mealItem.Measure;
           mealItem.Carbs = (food.Carbs / food.Measure) * mealItem.Measure;
           mealItem.Fat = (food.Fat / food.Measure) * mealItem.Measure;
           mealItem.Calories = (food.Calories / food.Measure) * mealItem.Measure;
           mealItem.CalCalories = (mealItem.Protein * 4) + (mealItem.Carbs * 4) + (mealItem.Fat * 9);

        }

    }
}
