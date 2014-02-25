using System;
using System.Windows.Forms;
using NutritionCal.Common;
using NutritionCal.Common.Abstraction;
using NutritionCal.Common.IOC;

namespace NutritionCal.GUI.Forms
{
    public partial class Form1 : Form
    {
        private readonly IBaseInformation _baseInformation;
        private readonly IGoalTypeFactory _goalTypeFactory;

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

            _baseInformation.Weight = GetWeight(weight);

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


            FrmResults results = CastleContainer.Resolve<FrmResults>();
            results.Show();
            Hide();
        }

        public double GetWeight(double weight)
        {
            WeightUnits weightUnits;
            Enum.TryParse(cbWeight.SelectedText, true, out weightUnits);

            _baseInformation.EnteredWeight = weight;
            _baseInformation.WeightUnits = weightUnits;

            switch (weightUnits)
            {
                    case WeightUnits.Lb:
                    return weight;

                    case WeightUnits.Kg:
                    return (Math.Round((weight*2.20462), 2));

                default:
                    throw new NotSupportedException(string.Format("No support for {0}",weightUnits));
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cbWeight.DataSource = Enum.GetValues(typeof (WeightUnits));

            int counter = 2;
                

            foreach (Enum value in Enum.GetValues(typeof(GoalTypeEnum)))
            {
                RadioButton rb = new RadioButton();
                rb.Text = Enumerations.GetEnumDescription(value);
                rb.AutoSize = true;
                rb.CheckedChanged += RbOnCheckedChanged;
                tableLayoutPanel1.Controls.Add(rb,0,counter);

                counter++;
            }

            rbGain.Text = Enumerations.GetEnumDescription(GoalTypeEnum.GainWeight);
            rbLose.Text = Enumerations.GetEnumDescription(GoalTypeEnum.LoseWeight);
            rbLose25.Text = Enumerations.GetEnumDescription(GoalTypeEnum.LoseWeightObese);
            rbMaintain.Text = Enumerations.GetEnumDescription(GoalTypeEnum.MaintainWeight);

        }

        private void RbOnCheckedChanged(object sender, EventArgs eventArgs)
        {
            if (((RadioButton)sender).Checked == false) return;
           
            MessageBox.Show(((RadioButton)sender).Text);
        }


    }
}
