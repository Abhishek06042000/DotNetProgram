using System;
using System.Drawing;
using System.Windows.Forms;

namespace Practical9FormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sizeIncrease_Click(object sender, EventArgs e)
        {
            float fontSize = labelFont.Font.Size;
            labelFont.Font = new Font(labelFont.Font.FontFamily, ++fontSize);
        }

        private void sizeDecrease_Click(object sender, EventArgs e)
        {
            float fontSize = labelFont.Font.Size;
            if(fontSize > 10)
                labelFont.Font = new Font(labelFont.Font.FontFamily, --fontSize);
        }
    }
}
