using System.Globalization;
using NutritionCal.Common.Abstraction;
using NutritionCal.Common.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NutritionCal.GUI.Forms
{
    public partial class EditFood : Form
    {
        private readonly IFoodStats _foodStats;
        private readonly IAllMeals _allMeals;
        private IFood _selectedfood;
        private readonly IUpdate _origin;

        public EditFood(IFoodStats foodStats, IAllMeals allMeals, IUpdate origin)
        {
            InitializeComponent();
            _foodStats = foodStats;
            _allMeals = allMeals;
            _origin = origin;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ClearResults();
            ClearFood();

            IEnumerable<string> results;

            if(string.IsNullOrWhiteSpace(txtSearch.Text))
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


            IEnumerable<string> names = results as IList<string> ?? results.ToList();
            if (!names.Any())
            {
                MessageBox.Show(@"No results found");
                return;
            }

            lbResults.Visible = true;
         foreach(string name in names)
         {
             lbResults.Items.Add(name);
             
         }
            
        }

        private void EditFood_Load(object sender, EventArgs e)
        {
          
        }

        private void lbResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedfood = _foodStats.Foods.First(x => x.Name == lbResults.SelectedItem.ToString());
            txtName.Text = _selectedfood.Name;
            txtMeasure.Text = _selectedfood.Measure.ToString(CultureInfo.InvariantCulture);
            txtProtein.Text = _selectedfood.Protein.ToString(CultureInfo.InvariantCulture);
            txtCarbs.Text = _selectedfood.Carbs.ToString(CultureInfo.InvariantCulture);
            txtFats.Text = _selectedfood.Fat.ToString(CultureInfo.InvariantCulture);
            txtCalories.Text = _selectedfood.Calories.ToString(CultureInfo.InvariantCulture);

            tlpFood.Visible = true;
        }

        private void ClearFood()
        {
            txtName.Text = "";
            txtMeasure.Text = "";
            txtProtein.Text = "";
            txtCarbs.Text = "";
            txtFats.Text = "";
            txtCalories.Text = "";
            tlpFood.Visible = false;

        }
        private void ClearForm()
        {
            ClearFood();
            ClearResults();
            txtSearch.Text = "";
           
        }

        private void ClearResults()
        {
            lbResults.Items.Clear();
            lbResults.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            _origin.Update();
            Close();
        }


        private bool PassedValidation()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMeasure.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtProtein.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCarbs.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtFats.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCalories.Text))
            {
                return false;
            }

            return true;
        }

        private void lblSave_Click(object sender, EventArgs e)
        {
            if (PassedValidation())
            {
                _foodStats.Foods.Remove(_selectedfood);

                _foodStats.AddFood(txtName.Text,
                    Convert.ToDecimal(txtMeasure.Text),
                    Convert.ToDecimal(txtProtein.Text),
                    Convert.ToDecimal(txtCarbs.Text),
                    Convert.ToDecimal(txtFats.Text),
                    Convert.ToDecimal(txtCalories.Text)
                   );

                MessageBox.Show(string.Format("{0} has been updated", _selectedfood.Name));

                _foodStats.SaveChanges();

                ClearForm();
                UpdateAllMeals(_selectedfood.Name, txtName.Text);
                _origin.Update();
                Close();
            }
            else
            {
                MessageBox.Show(@"Please ensure all fields have been filled in");
            }
        }

        

        private void btDelete_Click(object sender, EventArgs e)
        {
            DeleteFoodFromAllMeals();

            _foodStats.Foods.Remove(_selectedfood);
            ClearForm();
        }

        private void DeleteFoodFromAllMeals()
        {
         
            int allMealCount = _allMeals.meals.Count()-1;

            for (int i =0; i < allMealCount; i++)
            {
                IMeal meal = _allMeals.meals[i];

                int itemCount = meal.Mealitems.Count()-1;

                for (int j = itemCount; j > 0; j--)
                {
                    if(meal.Mealitems[j].FoodName == _selectedfood.Name)
                    {
                        _allMeals.meals[i].Mealitems.RemoveAt(j);
                    }
                }
            }

            _allMeals.SaveChanged();


        }

        private void UpdateAllMeals(string previousName, string newName)
        {
            IFood newFood = _foodStats.Foods.FirstOrDefault(x => x.Name == newName);

            int allMealCount = _allMeals.meals.Count() -1;

            for (int i = 0; i < allMealCount; i++)
            {
                IMeal meal = _allMeals.meals[i];

                int itemCount = meal.Mealitems.Count() - 1;

                for (int j = itemCount - 1; j > 0; j--)
                {
                    if (meal.Mealitems[j].FoodName == previousName)
                    {
                        decimal previousMeasure = _allMeals.meals[i].Mealitems[j].Measure;

                        IMealItem newItem = new MealItem();

                        if (newFood != null)
                        {
                            newItem.FoodName = newFood.Name;
                       
                        newItem.Measure = Convert.ToDecimal(previousMeasure);
                        newItem.Protein = (newFood.Protein/newFood.Measure)*newItem.Measure;
                        newItem.Carbs = (newFood.Carbs/newFood.Measure)*newItem.Measure;
                        newItem.Fat = (newFood.Fat/newFood.Measure)*newItem.Measure;
                        newItem.Calories = (newFood.Calories/newFood.Measure)*newItem.Measure;
                        newItem.CalCalories = (newItem.Protein*4) + (newItem.Carbs*4) + (newItem.Fat*9);

                        _allMeals.meals[i].Mealitems.RemoveAt(j);
                        _allMeals.meals[i].Mealitems.Add(newItem);
                        }
                }
                }
            }

            _allMeals.SaveChanged();
        }

    }
}
