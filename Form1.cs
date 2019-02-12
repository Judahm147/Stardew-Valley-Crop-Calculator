using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stardew_Valley_Crop_Calculator
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        private int numCrops;
        private string cropType;
        private decimal pricePerCrop;
        private decimal quality;

        public Form1()
        {
            InitializeComponent();
            UpdateForm();
        }

        private decimal CalculateIncome()
        {
            UpdateForm();
            decimal incomeGenerated = 0;
            for(int i = 0; i < numCrops; i++)
            {
                decimal cropValue = 0;
                cropValue = pricePerCrop * quality;
                incomeGenerated = incomeGenerated + cropValue;

            }

            return incomeGenerated;
        }
        

        

        private void UpdateForm()
        {
            numCrops = (int)numericUpDown1.Value;
            cropType = (string)comboBox1.SelectedItem;
            SetQuality();
            setPricePerCrop();
        }

        public void SetQuality()
        {
            quality = calculateQuality();
        }

        private decimal calculateQuality()
        {
            decimal qualityMultiplier;
            int qualityThreshold = 1;
            qualityThreshold = random.Next(1, 60);

            if (normalFertilizerRad.Checked)
                qualityThreshold = random.Next(10, 60);

            if (qualityFertilizerRad.Checked)
                qualityThreshold = random.Next(15, 60);

            if (qualityThreshold <= 20)
                qualityMultiplier = 1;
            else if (qualityThreshold <= 40)
                qualityMultiplier = 1.25M;
            else
                qualityMultiplier = 1.5M;

            return qualityMultiplier;

        }

        public void setPricePerCrop()
        {
            switch (cropType)
            {
                case "Potato":
                    pricePerCrop = 25;
                    break;
                case "Cauliflower":
                    pricePerCrop = 60;
                    break;
                case "Raddish":
                    pricePerCrop = 15;
                    break;
                case "Rhubarb":
                    pricePerCrop = 75;
                    break;
                default:
                    pricePerCrop = 0;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateForm();
            decimal incomeGenerated = CalculateIncome();
            textBox1.Text = incomeGenerated.ToString("c");
        }
    }
}
