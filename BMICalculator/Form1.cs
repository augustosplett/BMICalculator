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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculateBMI_Click(object sender, EventArgs e)
        {
            var height = Convert.ToSingle(textBoxHeight.Text);
            var weight = Convert.ToSingle(textBoxWeight.Text);
            var bmi = CalculateBMI(height, weight);
            var tier = CalculateTier(bmi);
            var weightToNormal = KilosToNormalWeight(weight, height);
            OpenResults(bmi, tier, weightToNormal);
            this.Hide();
        }

        private void OpenResults( float bmi, string tier, float weightToNormal)
        {
            Form results = new Results(bmi, tier, weightToNormal);
            results.Show();
        }
        private static float CalculateBMI(float height, float weight)
        {
            return (weight / (height * height)) * 10000;
        }
        private string CalculateTier(float bmi)
        {

            if (bmi < 18.5f) { return "Underweight"; }
            else if (bmi >= 18.5f && bmi < 25) { return "Normal"; }
            else if (bmi >= 25f && bmi < 30) { return "Overweight"; }
            else if (bmi >= 30f && bmi < 35) { return "Obese"; }
            else if (bmi >= 35f) { return "Extremely Obese"; }
            else return "error on calculation";
        }
        private float KilosToNormalWeight(float currentWeight, float currentHeigt)
        {
            var idealWeight = (18.5f * (currentHeigt * currentHeigt))/ 10000;
            var kilosToLose = currentWeight - idealWeight;
            //if the value is negative the user needs to gain kilos
            return kilosToLose;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
