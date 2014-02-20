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
        private IMealItem mi;

       public AddMeal(IFoodStats foodStats)
        {
            InitializeComponent();
            _foodStats = foodStats;
            dataGridView1.CellEndEdit += new DataGridViewCellEventHandler(onEndEdit); 
        }

        private void AddMeal_Load(object sender, EventArgs e)
        {
            foreach(IFood food in _foodStats.Foods)
            {
                mi = new MealItem();
                mi.foodName = food.Name;
                mi.Measure = food.Measure/2;
                mi.Protein = (food.Protein / food.Measure) * mi.Measure;

                iMealItemBindingSource.Add(mi);
                
            }
            //dataGridView1.DataSource = _foodStats.Foods;
            
        }

     
        private void onEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Test " + mi.Measure);
        }

    }
}
