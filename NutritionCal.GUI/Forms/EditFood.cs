﻿using NutritionCal.Common.Abstraction;
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
    public partial class EditFood : Form
    {
        private readonly IFoodStats _foodStats;

        public EditFood(IFoodStats foodStats)
        {
            InitializeComponent();
            _foodStats = foodStats;
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


            if (results.Count() == 0)
            {
                MessageBox.Show("No results found");
                return;
            }

            lbResults.Visible = true;
         foreach(string name in results)
         {
             lbResults.Items.Add(name);
             
         }
            
        }

        private void EditFood_Load(object sender, EventArgs e)
        {
          
        }

        private void lbResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            IFood food = _foodStats.Foods
                .Where(x => x.Name == lbResults.SelectedItem.ToString())
                .First();
            txtName.Text = food.Name;
            txtMeasure.Text = food.Measure.ToString();
            txtProtein.Text = food.Protein.ToString();
            txtCarbs.Text = food.Carbs.ToString();
            txtFats.Text = food.Fat.ToString();
            txtCalories.Text = food.Calories.ToString();

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
            this.Close();
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
                _foodStats.AddFood(txtName.Text,
                    Convert.ToDecimal(txtMeasure.Text),
                    Convert.ToDecimal(txtProtein.Text),
                    Convert.ToDecimal(txtCarbs.Text),
                    Convert.ToDecimal(txtFats.Text),
                    Convert.ToDecimal(txtCalories.Text)
                   );

                MessageBox.Show(string.Format("{0} has been updated", txtName.Text));

                ClearForm();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please ensure all fields have been filled in");
            }
        }

    }
}