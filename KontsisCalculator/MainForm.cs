using KontsisCalculator.Helpers;
using System;
using System.Windows.Forms;

namespace KontsisCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }
         

        private void button1_Click(object sender, EventArgs e)
        {
            ValideteInputs();
            double angle = double.Parse(txtAngle.Text);
            double height = double.Parse(txtHight.Text);
            int sensitivity = int.Parse( txtSensitivity.Text);

            MathCalculator calculator = new MathCalculator(angle, height, sensitivity);

            double area = calculator.Area;
            double radius = calculator.Radius;
              
            this.dataGridView1.Rows.Insert(0,angle, height, radius, area);
        }

        private void ValideteInputs( )
        {
            if (txtAngle.Text.Equals(string.Empty))
                throw new ArgumentNullException(nameof(txtAngle));
            if (txtHight.Text.Equals(null))
                throw new ArgumentNullException(nameof(txtHight));

            if (txtSensitivity.Text.Equals(string.Empty))
                txtSensitivity.Text = "2";
        }

    }
}
