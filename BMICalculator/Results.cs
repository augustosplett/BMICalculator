using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class Results : Form
    {
        public Results(float bmi, string tier, float weightToNormal)
        {
            InitializeComponent();
            LoadResults(bmi, tier, weightToNormal);
        }

        private void LoadResults(float bmi, string tier, float weightToNormal)
        {
            labelBmiIndex.Text = $"Your BMI Index is: {bmi.ToString("0.##")}";
            labelTier.Text = $"You are classified as: {tier}";
            var gainOrLose = weightToNormal >= 0 ? "lose" : "gain";
            labelChagingKilos.Text = $"To reach the ideal weight you need to {gainOrLose} {Math.Abs(weightToNormal).ToString("0.##")}Kg";
                
        }

        private void Results_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
