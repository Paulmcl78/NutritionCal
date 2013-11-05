using System;
using System.Windows.Forms;
using NutritionCal.Common;
using NutritionCal.Common.Abstraction;

namespace NutritionCal.GUI.Forms
{
    public partial class Form1 : Form
    {
        private IBaseInformation _baseInformation;
        private IGoalTypeFactory _goalTypeFactory;

        public Form1(IBaseInformation baseInformation, IGoalTypeFactory goalTypeFactory)
        {
            InitializeComponent();
            _baseInformation = baseInformation;
            _goalTypeFactory = goalTypeFactory;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double weight;
            if (string.IsNullOrEmpty(txtWeight.Text)) return;

            if (!double.TryParse(txtWeight.Text, out weight)) return;
            _baseInformation.Weight = weight;

            GoalTypeEnum goalType = GoalTypeEnum.MaintainWeight;

            if (rbGain.Checked)
            {
                goalType = GoalTypeEnum.GainWeight;
            }
            if (rbLose.Checked)
            {
                goalType = GoalTypeEnum.LoseWeight;
            }
            if (rbLose25.Checked)
            {
                goalType = GoalTypeEnum.LoseWeightObese;
            }

            _baseInformation.Calculate(_goalTypeFactory.GetGoalType(goalType));

            frmResults results = new frmResults(_baseInformation);
            results.Show();
            //this.Hide();
        }


         private void Form1_Load(object sender, EventArgs e)
         {
             
         }

    }
}
