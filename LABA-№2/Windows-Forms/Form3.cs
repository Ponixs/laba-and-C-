using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms
{
    public partial class Form3 : Form
    {
        public Form2 fm2;

        public Form3(Form2 f)
        {
            InitializeComponent();
            fm2 = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                int intValue;
                bool succes = Int32.TryParse(textBox1.Text, out intValue);
                if (!succes || intValue > 9 || intValue < 0) throw new Exception("Введенные данные не соответствуют требованиям");
                fm2.number = intValue;
                this.Dispose();
            }
            catch (Exception error)
            {
                textBox1.Text = error.Message + '\n';
                textBox1.Text += error.StackTrace;
            }
        }
    }
}
