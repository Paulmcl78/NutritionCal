using NutritionCal.Common.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NutritionCal.GUI.Forms
{
    public partial class EditMeal : Form, IUpdate
    {

        private readonly IFoodStats _foodStats;
        private readonly IAllMeals _allMeals;
        private IMeal _mealOrg;
        private IMeal _mealUpdate;
        private readonly IUpdate _origin;

        public EditMeal(IAllMeals allMeals,IFoodStats foodStats, IUpdate origin)
        {
            InitializeComponent();
            _allMeals = allMeals;
            _foodStats = foodStats;
            _origin = origin;

            dataGridView1.CellEndEdit += OnCellChange;
            dataGridView1.UserDeletingRow += OnRowDeleted;

        }

        private void OnRowDeleted(object sender, DataGridViewRowCancelEventArgs e)
        {
            string foodName = dataGridView1[0, e.Row.Index].Value.ToString();

            IList<IMealItem> newList = _mealUpdate.Mealitems.Where(mealItem => mealItem.FoodName != foodName).ToList();

            _mealUpdate.Mealitems = newList;
        }     

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbResults.Items.Clear();
            if(string.IsNullOrEmpty(txtSearch.Text))
            {
                GetResults();
            }

            else
            {
                GetResults(txtSearch.Text);
            }

            lbResults.Visible = true;
        }


        private void GetResults(string mealName = null)
        {
            if (mealName != null) return;
            foreach (IMeal meal in _allMeals.meals)
            {
                lbResults.Items.Add(meal.MealName);
            }
        }

        private void lbResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            iMealItemBindingSource.Clear();

            _mealOrg = _allMeals.meals.First(x => x.MealName == lbResults.SelectedItem.ToString());

            _mealUpdate = (IMeal)_mealOrg.Clone();

            txtName.Text = _mealUpdate.MealName;

            foreach (IMealItem mealItem in _mealUpdate.Mealitems)
            {
                iMealItemBindingSource.Add(mealItem);
            }

            pnlItems.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void OnCellChange(object sender, DataGridViewCellEventArgs e)
        {
            string foodName = dataGridView1[0, e.RowIndex].Value.ToString();


            IFood food = _foodStats.Foods.First(x => x.Name == foodName);

            IMealItem mealItem = _mealUpdate.Mealitems.First(x => x.FoodName == food.Name);

            mealItem.Measure = Convert.ToDecimal(dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString());
            mealItem.Protein = (food.Protein / food.Measure) * mealItem.Measure;
            mealItem.Carbs = (food.Carbs / food.Measure) * mealItem.Measure;
            mealItem.Fat = (food.Fat / food.Measure) * mealItem.Measure;
            mealItem.Calories = (food.Calories / food.Measure) * mealItem.Measure;
            mealItem.CalCalories = (mealItem.Protein * 4) + (mealItem.Carbs * 4) + (mealItem.Fat * 9);

        }

        private void btSave_Click(object sender, EventArgs e)
        {

            _mealUpdate.MealName = txtName.Text;

            IMeal mealtoRemove = _allMeals.meals.First(x => x.MealName == _mealOrg.MealName);

            _allMeals.meals.Remove(mealtoRemove);
            _allMeals.meals.Add(_mealUpdate);
           
            _allMeals.SaveChanged();

            _origin.Update();
            Close();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            AddFoodToMeal addFood = new AddFoodToMeal(_mealUpdate, _foodStats, this);

            addFood.ShowDialog();
        }

        private void EditMeal_Load(object sender, EventArgs e)
        {

        }

        void IUpdate.Update()
        {
            iMealItemBindingSource.Clear();

            foreach (IMealItem mealItem in _mealUpdate.Mealitems)
            {
                iMealItemBindingSource.Add(mealItem);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            IMeal mealtoRemove = _allMeals.meals.First(x => x.MealName == _mealOrg.MealName);

            _allMeals.meals.Remove(mealtoRemove);

            _allMeals.SaveChanged();

            _origin.Update();
            Close();
        }
    }
}
