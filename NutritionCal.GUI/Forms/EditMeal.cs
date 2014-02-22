using NutritionCal.Common.Abstraction;
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
    public partial class EditMeal : Form
    {

        private IAllMeals _allMeals;

        public EditMeal(IAllMeals AllMeals)
        {
            InitializeComponent();
            _allMeals = AllMeals;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
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
    }
}
