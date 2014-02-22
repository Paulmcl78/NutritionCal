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
    public partial class EditMeal : Form, IUpdate
    {

        private readonly IFoodStats _foodStats;
        private IAllMeals _allMeals;
        private IMeal mealOrg;
        private IMeal mealUpdate;
        private IUpdate _origin;

        public EditMeal(IAllMeals AllMeals,IFoodStats foodStats, IUpdate origin)
        {
            InitializeComponent();
            _allMeals = AllMeals;
            _foodStats = foodStats;
            _origin = origin;

            dataGridView1.CellEndEdit += OnCellChange;
            dataGridView1.UserDeletingRow += OnRowDeleted;

        }

        private void OnRowDeleted(object sender, DataGridViewRowCancelEventArgs e)
        {
            string foodName = dataGridView1[0, e.Row.Index].Value.ToString();

            IList<IMealItem> newList = new List<IMealItem>();

            foreach (IMealItem mealItem in mealUpdate.mealitems)
            {
                if (mealItem.foodName != foodName)
                {
                    newList.Add(mealItem);
                }
            }

            mealUpdate.mealitems = newList;
        }     

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbResults.Items.Clear();
            if(string.IsNullOrEmpty(txtSearch.Text))
            {
                getResults();
            }

            else
            {
                getResults(txtSearch.Text);
            }

            lbResults.Visible = true;
        }


        private void getResults(string mealName = null)
        {
            if (mealName == null)
            {
                foreach (IMeal meal in _allMeals.meals)
                {
                    lbResults.Items.Add(meal.MealName);
                }
            }
        }

        private void lbResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            iMealItemBindingSource.Clear();

            mealOrg = _allMeals.meals
                .Where(x => x.MealName == lbResults.SelectedItem.ToString())
                .First();

            mealUpdate = (IMeal)mealOrg.Clone();

            txtName.Text = mealUpdate.MealName;

            foreach (IMealItem mealItem in mealUpdate.mealitems)
            {
                iMealItemBindingSource.Add(mealItem);
            }

            pnlItems.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void OnCellChange(object sender, DataGridViewCellEventArgs e)
        {
            string foodName = dataGridView1[0, e.RowIndex].Value.ToString();


            IFood food = _foodStats.Foods
               .Where(x => x.Name == foodName)
               .First();

            IMealItem mealItem = mealUpdate.mealitems
                .Where(x => x.foodName == food.Name)
                .First();

            mealItem.Measure = Convert.ToDecimal(dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString());
            mealItem.Protein = (food.Protein / food.Measure) * mealItem.Measure;
            mealItem.Carbs = (food.Carbs / food.Measure) * mealItem.Measure;
            mealItem.Fat = (food.Fat / food.Measure) * mealItem.Measure;
            mealItem.Calories = (food.Calories / food.Measure) * mealItem.Measure;
            mealItem.CalCalories = (mealItem.Protein * 4) + (mealItem.Carbs * 4) + (mealItem.Fat * 9);

        }

        private void btSave_Click(object sender, EventArgs e)
        {

            mealUpdate.MealName = txtName.Text;

            IMeal mealtoRemove = _allMeals.meals
                .Where(x => x.MealName == mealOrg.MealName)
                .First();

            _allMeals.meals.Remove(mealtoRemove);
            _allMeals.meals.Add(mealUpdate);
           
            _allMeals.SaveChanged();

            _origin.Update();
            this.Close();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            AddFoodToMeal addFood = new AddFoodToMeal(mealUpdate, _foodStats, this);

            addFood.ShowDialog();
        }

        private void EditMeal_Load(object sender, EventArgs e)
        {

        }

        void IUpdate.Update()
        {
            iMealItemBindingSource.Clear();

            foreach (IMealItem mealItem in mealUpdate.mealitems)
            {
                iMealItemBindingSource.Add(mealItem);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            IMeal mealtoRemove = _allMeals.meals
               .Where(x => x.MealName == mealOrg.MealName)
               .First();

            _allMeals.meals.Remove(mealtoRemove);

            _allMeals.SaveChanged();

            _origin.Update();
            this.Close();
        }
    }
}
