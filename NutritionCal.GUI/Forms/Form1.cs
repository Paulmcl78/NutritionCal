using System;
using System.Drawing;
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
        private GoalTypeEnum _goalType;

        public Form1(IBaseInformation baseInformation, IGoalTypeFactory goalTypeFactory)
        {
            InitializeComponent();
            _baseInformation = baseInformation;
            _goalTypeFactory = goalTypeFactory;
        }



        private bool ProfileExists()
        {
            if (_baseInformation.ProfileExists())
            {
                FrmResults results = CastleContainer.Resolve<FrmResults>();
                results.Show();
                this.Hide();
                return true;
            }

            return false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double weight;
            if (string.IsNullOrEmpty(txtWeight.Text)) return;

            if (!double.TryParse(txtWeight.Text, out weight)) return;

            _baseInformation.Weight = GetWeight(weight);

            _baseInformation.Calculate(_goalTypeFactory.GetGoalType(_goalType));

            UpdateProfile();

            FrmResults results = CastleContainer.Resolve<FrmResults>();
            results.Show();
            Hide();
        }

        private void UpdateProfile()
        {
            _baseInformation.SaveAndUpdate();
          
        }

        public double GetWeight(double weight)
        {
            WeightUnits weightUnits;
            Enum.TryParse(cbWeight.SelectedItem.ToString(), true, out weightUnits);

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

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (ProfileExists()) return;
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
                tableLayoutPanel1.Controls.Add(rb,1,counter);

                counter++;
            }

            tableLayoutPanel1.Controls.Add(lblWeight, 0, counter);
            tableLayoutPanel1.Controls.Add(txtWeight, 1, counter);
            tableLayoutPanel1.Controls.Add(cbWeight, 2, counter);
            tableLayoutPanel1.Controls.Add(cmdSubmit, 1, counter + 1);

            tableLayoutPanel1.Refresh();

            this.Size = new Size(tableLayoutPanel1.Size.Width + 50 ,tableLayoutPanel1.Size.Height + 75);
            

            //rbGain.Text = Enumerations.GetEnumDescription(GoalTypeEnum.GainWeight);
            //rbLose.Text = Enumerations.GetEnumDescription(GoalTypeEnum.LoseWeight);
            //rbLose25.Text = Enumerations.GetEnumDescription(GoalTypeEnum.LoseWeightObese);
            //rbMaintain.Text = Enumerations.GetEnumDescription(GoalTypeEnum.MaintainWeight);

        }

        private void RbOnCheckedChanged(object sender, EventArgs eventArgs)
        {
            if (((RadioButton)sender).Checked == false) return;

            _goalType = Enumerations.GetEmumFromDescription<GoalTypeEnum>(((RadioButton)sender).Text);

        }


    }
}
