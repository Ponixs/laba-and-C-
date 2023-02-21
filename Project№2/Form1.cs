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
            String name, surname, result = "";
            name = textBox2.Text;
            surname = textBox1.Text;
            foreach (var letter in name) if (!char.IsLetter(letter)) return;
            foreach (var letter in surname) if (!char.IsLetter(letter)) return;

            int i = 0;
            for (; i < name.Length && i < surname.Length; i++)
            {
                int ok = name[i] + surname[i];
                result += (char)ok;
            }


            if (name.Length > surname.Length) result += name.Substring(i);
            else result += surname.Substring(i);
            Result.Text = result;

        }


    }
}
