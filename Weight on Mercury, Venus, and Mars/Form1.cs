using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weight_on_Mercury__Venus__and_Mars
{
    public partial class Form1 : Form
    {
        SortedList<String, Double> WeightConversionFactors = new SortedList<string, double>();
        public Form1()
        {
            InitializeComponent();

            //Initialize the SortedList
            WeightConversionFactors.Add("Mercury", 0.3772);
            WeightConversionFactors.Add("Venus", 0.9042);
            WeightConversionFactors.Add("Mar", 0.3783);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double earthWeight = Convert.ToDouble(txtEarthWeight.Text);
            
            double mercuryWeight = earthWeight * WeightConversionFactors["Mercury"];
            txtMercuryWeight.Text = mercuryWeight.ToString();

            //TODO - can you finish Venus and Mars?

            double venusConversionFactor = WeightConversionFactors["Venus"];
            double venusWeight = earthWeight * venusConversionFactor;
            txtVenusWeight.Text = venusWeight.ToString();

            double marConversionFactor = WeightConversionFactors["Mar"];
            double marWeight = earthWeight * marConversionFactor;
            txtMarsWeight.Text = marWeight.ToString();

        }
    }
}
