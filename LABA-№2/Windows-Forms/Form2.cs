using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Windows_Forms
{
    
    public partial class Form2 : Form
    {
        public int number;
        public Form1 Fm1;

        public Form2(Form1 fm)
        {
            InitializeComponent();
            Fm1 = fm;
            for (int i = 0; i < 12; i++)
            {
                dataGridView1.Rows.Add();

                dataGridView1.Rows[i].Cells[0].Value += (i + 1).ToString();
                
            }
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void случайноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void случайноСЗаданнойЧастотойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Random rnd = new Random();
            for (int i = 0; i < 12; i++)
            {
                dataGridView1.Rows.Add();

                dataGridView1.Rows[i].Cells[0].Value += (i + 1).ToString();
                dataGridView1.Rows[i].Cells[1].Value = (rnd.Next()%70-10).ToString();
            }
        }

        private void вручнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < 12; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value += (i + 1).ToString();
            }
            
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < (dataGridView1.RowCount - 1); i++)
                {
                    int intValue;
                    bool succes = Int32.TryParse((string)dataGridView1.Rows[i].Cells[1].Value, out intValue);
                    if (!succes || intValue > 60 || intValue < -10) throw new Exception("Введенные данные не соответствуют требованиям");
                    if ((intValue % 10) != 0)
                    {
                        if ((intValue % 10) % 2 == 0 && intValue % (intValue % 10) == 0)
                        {
                            dataGridView1.Rows.RemoveAt(i);
                            i--;
                        }
                    }

                }
            }
            catch (Exception error)
            {
                Fm1.textBox1.Text = error.Message + '\n';
                Fm1.textBox1.Text = Convert.ToString(error.InnerException) + '\n';
                Fm1.textBox1.Text = error.Source + '\n';
                Fm1.textBox1.Text += error.StackTrace;
            }
           
        }

        private void вставитьЧислоKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form3 newForm = new Form3(this);
                newForm.ShowDialog();
                for (int i = 0; i < (dataGridView1.RowCount - 1); i++)
                {
                    int intValue;
                    bool succes = Int32.TryParse((string)dataGridView1.Rows[i].Cells[1].Value, out intValue);
                    if (!succes || intValue > 60 || intValue < -10) throw new Exception("Введенные данные не соответствуют требованиям");
                    if (intValue % 10 == number)
                    {
                        dataGridView1.Rows.Insert(i);
                        dataGridView1.Rows[i].Cells[1].Value = number.ToString();
                        i++;
                        dataGridView1.Rows.Insert(i + 1);
                        dataGridView1.Rows[i + 1].Cells[1].Value = number.ToString();
                        i++;
                    }
                }
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
                }
            }
            catch (Exception error)
            {
                Fm1.textBox1.Text = error.Message + '\n';
                Fm1.textBox1.Text = Convert.ToString(error.InnerException) + '\n';
                Fm1.textBox1.Text = error.Source + '\n';
                Fm1.textBox1.Text += error.StackTrace;
            }
            
        }

        private void перестановкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int max = dataGridView1.RowCount - 1;
                for (int i = 1; i < max; i += 2)
                {


                    dataGridView1.Rows.Insert(i);
                    dataGridView1.Rows[i].Cells[1].Value = dataGridView1.Rows[max + 1].Cells[1].Value;
                    dataGridView1.Rows[i].Cells[0].Value = dataGridView1.Rows[max + 1].Cells[0].Value;
                    dataGridView1.Rows.RemoveAt(max + 1);


                }
            }
            catch (Exception error)
            {
                Fm1.textBox1.Text = error.Message + '\n';
                Fm1.textBox1.Text = Convert.ToString(error.InnerException) + '\n';
                Fm1.textBox1.Text = error.Source + '\n';
                Fm1.textBox1.Text += error.StackTrace;
            }
           
        }

        private void дополнительноеЗаданиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.ShowDialog();
        }
    }
}
