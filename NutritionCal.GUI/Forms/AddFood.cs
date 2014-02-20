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
            this.Close();
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
                 this.Close();
             }
             else
             {
                 MessageBox.Show("Please ensure all fields have been filled in");
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
             if (_foodStats.foodExists(txtName.Text))
             {
                    MessageBox.Show("A food with this name already exists, please chose another name");
                    return false;
             }

             return true;
         }

    }
}
