using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void startButton_Click(object sender, EventArgs e)
        {
			label2.Text = "Program №1:\n";
			number1(label2, textBox1);
			label3.Text = "Program №2:\n";
			number2(label3);
		}

		static int number1(Label label, TextBox text)
		{
			int max = 200;
			string userString = text.Text;
			int intValue;
			bool succes = int.TryParse(userString, out intValue);

			if ((intValue > 50) || (intValue < 0) || !succes) return -1;
			int count = 1;
			for (int i = 1; i < max; i++)
			{
				
				if (intValue == find_divisor(i))
				{
					if ((count++) % 10 == 0) label.Text += "\n";
					label.Text += $"{i} ";
				}
			}
			return 0;
		}

		private static int find_divisor(int div)
		{
			if (div == 1 || div == -1) return 1;
			int count = 2;
			for (int i = 2; i <= (int)Math.Sqrt(div); i++) if (div % i == 0) count += 2;
			if (((int)Math.Sqrt(div) == Math.Sqrt(div)) && (div % (int)Math.Sqrt(div) == 0)) count--;
			return count;
		}

		static void number2(Label label)
		{
			for (int i = 1; i < 20; i++)
			{
				for (int j = 1; j < 20; j++)
				{
					for (int k = 1; k < 20; k++)
					{
						if ((i + j * j) == (k * k))
						{
							label.Text += $"{i} {j} {k}\n";
						}

					}
				}
			}
		}


	}
}
