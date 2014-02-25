using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using NutritionCal.Common.Abstraction;
using NutritionCal.Common.IOC;
using NutritionCal.Common.Implementation;

namespace NutritionCal.GUI.Forms
{
    public partial class FrmResults : Form , IUpdate
    {
        private readonly IBaseInformation _baseInformation;
        private readonly IAllMeals _allMeals;
        private DataTable _dataTable;
        private IEnumerable<IMealItem> _totalMeals;
        
        public FrmResults(IBaseInformation baseInformation, IAllMeals allMeals)
        {
            InitializeComponent();
            _baseInformation = baseInformation;
            _allMeals = allMeals;
            _totalMeals = Enumerable.Empty<IMealItem>();
        }

         private void Results_Load(object sender, EventArgs e)
        {

            BuildFullResults();

             Controls.Add(BuildStrip());
             Refresh();

        }

        private StatusStrip BuildStrip()
        {
            StatusStrip status = new StatusStrip();
            ToolStripStatusLabel weight = new ToolStripStatusLabel(string.Format("Current weight : {0}{1}", _baseInformation.EnteredWeight, _baseInformation.WeightUnits))
                {
                    BorderStyle = Border3DStyle.Etched,
                    BorderSides = ToolStripStatusLabelBorderSides.Right
                };

            status.Items.Add(weight);

            ToolStripStatusLabel goal = new ToolStripStatusLabel(string.Format("Goal : {0}", _baseInformation.GoalType.GetGoalType()))
            {
                BorderStyle = Border3DStyle.Etched,
                BorderSides = ToolStripStatusLabelBorderSides.Right
            };

            
            status.Items.Add(goal);

            return status;
        }


        private void BuildFullResults()
         {
             _dataTable = new DataTable("Results Table");
             BuildHeader();
             BuildMeals();
             AddBlank();
             BuildTotal();
             BuildTraget();
             dataGridView2.DataSource = _dataTable;
             StyleTable();
         }

        private void BuildTotal()
        {
            try
            {
                decimal protein = 0;
                decimal carbs = 0;
                decimal fats = 0;
                decimal calories = 0;
                decimal calCalories = 0;
                foreach (IMealItem mealItem in _totalMeals)
                {
                    protein = protein + mealItem.Protein;
                    carbs = carbs + mealItem.Carbs;
                    fats = fats + mealItem.Fat;
                    calories = calories + mealItem.Calories;
                    calCalories = calCalories + mealItem.CalCalories;
                }

                _dataTable.Rows.Add("Total",
                        protein.ToString(CultureInfo.InvariantCulture),
                        carbs.ToString(CultureInfo.InvariantCulture),
                        fats.ToString(CultureInfo.InvariantCulture),
                        calories.ToString(CultureInfo.InvariantCulture),
                        calCalories.ToString(CultureInfo.InvariantCulture)
                        );
                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

        }

        private void StyleTable()
        {
            int counter = 0;

            int finalRow = dataGridView2.Rows.Count;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if ((counter == finalRow - 1) || (counter == finalRow -2))
                {
                    row.DefaultCellStyle.Font = new Font(dataGridView2.Font, FontStyle.Bold);
                    row.DefaultCellStyle.BackColor = Color.DimGray;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = counter%2 == 0 ? Color.LemonChiffon : Color.LightGray;
                }

                counter++;
            }

            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

         private void BuildHeader()
        {
            _dataTable.Columns.Add("Meal");
            _dataTable.Columns.Add("Protein");
            _dataTable.Columns.Add("Carbs");
            _dataTable.Columns.Add("Fats");
            _dataTable.Columns.Add("Calories");
            _dataTable.Columns.Add("Calculated Calories");

        }

         private void BuildTraget()
         {

             _dataTable.Rows.Add("Target",
                                 _baseInformation.Protein.ToString(CultureInfo.InvariantCulture),
                                 _baseInformation.Carbohydrates.ToString(CultureInfo.InvariantCulture),
                                 _baseInformation.Fats.ToString(CultureInfo.InvariantCulture),
                                 _baseInformation.Calories.ToString(CultureInfo.InvariantCulture),
                                 _baseInformation.Calories.ToString(CultureInfo.InvariantCulture)
                 );


             _dataTable.Rows.Add("Target %",
                            string.Format("{0}%", Math.Round(_baseInformation.ProteinPercentage, 2).ToString(CultureInfo.InvariantCulture)),
                            string.Format("{0}%", Math.Round(_baseInformation.CarbohydratesPercentage, 2).ToString(CultureInfo.InvariantCulture)),
                            string.Format("{0}%", Math.Round(_baseInformation.FatsPercentage, 2).ToString(CultureInfo.InvariantCulture)),
                            "",
                            ""
                 );

         }

        private void AddBlank()
        {
            _dataTable.Rows.Add();
        }

        private void BuildMeals()
        {

            try
            {
                foreach (IMeal meal in _allMeals.meals)
                {
                    IMealItem toalItem = new MealItem();
                   foreach (IMealItem mealItem in meal.Mealitems)
                    {


                        toalItem.Protein = toalItem.Protein + mealItem.Protein;
                        toalItem.Carbs = toalItem.Carbs + mealItem.Carbs;
                        toalItem.Fat = toalItem.Fat + mealItem.Fat;
                        toalItem.Calories = toalItem.Calories + mealItem.Calories;
                        toalItem.CalCalories = toalItem.CalCalories + mealItem.CalCalories;
                    }


                    _dataTable.Rows.Add(meal.MealName,
                        toalItem.Protein.ToString(CultureInfo.InvariantCulture),
                        toalItem.Carbs.ToString(CultureInfo.InvariantCulture),
                        toalItem.Fat.ToString(CultureInfo.InvariantCulture),
                        toalItem.Calories.ToString(CultureInfo.InvariantCulture),
                        toalItem.CalCalories.ToString(CultureInfo.InvariantCulture)
                        );

                    _totalMeals = _totalMeals.Concat(new[]{ toalItem});
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex);
            }
            

        }

        private void addFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFood results = CastleContainer.Resolve<AddFood>();
            results.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetWeightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 resetWeight = CastleContainer.Resolve<Form1>();
            resetWeight.Show();
            Close();
        }


        private void editFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditFood results = CastleContainer.Resolve<EditFood>(new { origin = this });
            results.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addMealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMeal form = CastleContainer.Resolve<AddMeal>();
            form.Show();
        }

        
        private void editMealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditMeal form = CastleContainer.Resolve<EditMeal>(new { origin = this });
            form.Show();
        }

        void IUpdate.Update()
        {
            BuildFullResults();
        }


    }

}
