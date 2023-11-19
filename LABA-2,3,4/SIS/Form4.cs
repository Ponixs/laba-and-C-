using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label3.Text = "Заполните поля";
                return;
            }
            string name = textBox1.Text;
            foreach (char c in name)
            {
                if (!char.IsLetter(c))
                {
                    label3.Text = "Введите имя с использованием только букв";
                    return;
                }
            }
            string surname = textBox2.Text;
            foreach (char c in surname)
            {
                if (!char.IsLetter(c))
                {
                    label3.Text = "Введите фамилию с использованием только букв";
                    return;
                }
            }
            string endString = "";
            label3.Text = "";
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] >= 'а' && name[i] <= 'я')
                {
                    if (name[i] >= 'ъ' && name[i] <= 'я')
                    {
                        endString += (char)(name[i] + 6 - 33);
                    }
                    else
                    {
                        endString += (char)(name[i] + 6);
                    }
                }
                else if (name[i] >= 'А' && name[i] <= 'Я')
                {
                    if (name[i] >= 'Ъ' && name[i] <= 'Я')
                    {
                        endString += (char)(name[i] + 6 - 33);
                    }
                    else
                    {
                        endString += (char)(name[i] + 6);
                    }
                }
                else if (name[i] >= 'a' && name[i] <= 'z')
                {
                    if (name[i] >= 'u' && name[i] <= 'z')
                    {
                        endString += (char)(name[i] + 6 - 26);
                    }
                    else
                    {
                        endString += (char)(name[i] + 6);
                    }
                }
                else if (name[i] >= 'A' && name[i] <= 'Z')
                {
                    if (name[i] >= 'U' && name[i] <= 'Z')
                    {
                        endString += (char)(name[i] + 6 - 26);
                    }
                    else
                    {
                        endString += (char)(name[i] + 6);
                    }
                }
            }
            textBox3.Text = endString;
            string sur = " ";

            for (int i = 0; i < surname.Length; i++)
            {
                if (surname[i] >= 'а' && surname[i] <= 'я')
                {
                    if (surname[i] >= 'ъ' && surname[i] <= 'я')
                    {
                        sur += (char)(surname[i] + 6 - 33);
                    }
                    else
                    {
                        sur += (char)(surname[i] + 6);
                    }
                }
                else if (surname[i] >= 'А' && surname[i] <= 'Я')
                {
                    if (surname[i] >= 'Ъ' && surname[i] <= 'Я')
                    {
                        sur += (char)(surname[i] + 6 - 33);
                    }
                    else
                    {
                        sur += (char)(surname[i] + 6);
                    }
                }
                else if (surname[i] >= 'a' && surname[i] <= 'z')
                {
                    if (surname[i] >= 'u' && surname[i] <= 'z')
                    {
                        sur += (char)(surname[i] + 6 - 26);
                    }
                    else
                    {
                        sur += (char)(surname[i] + 6);
                    }
                }
                else if (surname[i] >= 'A' && surname[i] <= 'Z')
                {
                    if (surname[i] >= 'U' && surname[i] <= 'Z')
                    {
                        sur += (char)(surname[i] + 6 - 26);
                    }
                    else
                    {
                        sur += (char)(surname[i] + 6);
                    }
                }
            }

            textBox3.Text += sur;
        }

    }
}
