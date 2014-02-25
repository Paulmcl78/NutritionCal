using NutritionCal.Common.Abstraction;
using System;
using System.Windows.Forms;
using NutritionCal.GUI.Properties;

namespace NutritionCal.GUI.Forms
{
     public partial class AddFood : Form
    {
         private readonly IFoodStats _foodStats;

        public AddFood(IFoodStats foodstats)
        {
            InitializeComponent();
            _foodStats = foodstats;
        }

        private void AddFood_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            Close();
        }

         private void ClearForm()
        {
            txtName.Text = "";
            txtMeasure.Text = "";
             txtProtein.Text = "";
             txtCarbs.Text = "";
             txtFats.Text = "";
             txtCalories.Text = "";
        }

         private void lblSave_Click(object sender, EventArgs e)
         {
             if(PassedValidation())
             {
                 _foodStats.AddFood(txtName.Text,
                     Convert.ToDecimal(txtMeasure.Text),
                     Convert.ToDecimal(txtProtein.Text),
                     Convert.ToDecimal(txtCarbs.Text),
                     Convert.ToDecimal(txtFats.Text),
                     Convert.ToDecimal(txtCalories.Text)
                    );

                 MessageBox.Show(string.Format("{0} has been added to your list of foods", txtName.Text));

                 ClearForm();
                 Close();
             }
             else
             {
                 MessageBox.Show(Resources.AddFood_lblSave_Click_Please_ensure_all_fields_have_been_filled_in);
             }
             

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
             if (_foodStats.FoodExists(txtName.Text))
             {
                    MessageBox.Show(Resources.A_food_with_this_name_already_exists__please_chose_another_name);
                    return false;
             }

             return true;
         }

    }
}
