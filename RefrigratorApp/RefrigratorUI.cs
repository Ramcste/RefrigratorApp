using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigratorApp
{
    public partial class RefrigratorUI : Form
    {
        public RefrigratorUI()
        {
            InitializeComponent();
        }

        Refrigrator refrigrator=new Refrigrator();
        private void saveWeightButton_Click(object sender, EventArgs e)
        {
            refrigrator.maxWeight=double.Parse(maxWeightTextBox.Text);

            MessageBox.Show("You refrigrator can hold maximum weight of: "+refrigrator.maxWeight+"Kg");

            maxWeightTextBox.Text = "";
        }

        private void enterWeightButton_Click(object sender, EventArgs e)
        {
            refrigrator.noofItems = int.Parse(noofItemsTextBox.Text);

            refrigrator.weightPerItems = double.Parse(weightPerunitTextBox.Text);
            refrigrator.itemsWeight = refrigrator.noofItems*refrigrator.weightPerItems;


            if (refrigrator.maxWeight > refrigrator.itemsWeight)
            {

                currentWeightTextBox.Text = refrigrator.itemsWeight.ToString();

                remainingWeightTextBox.Text = (refrigrator.maxWeight - refrigrator.itemsWeight).ToString();
            }
            else
            {
                MessageBox.Show("Refrigrator can't hold this amount of items");
               
            }
        }
    }
}
