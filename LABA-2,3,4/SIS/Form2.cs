using AirLoggerPGLib;
using Microsoft.EntityFrameworkCore;
using SIS;
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
        private DbContextOptions<DataBase> options;

        public Form2(Form1 fm, DbContextOptions<DataBase> DBoptions)
        {
            InitializeComponent();
            Fm1 = fm;
            options = DBoptions;

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
                    int b = 5 / intValue;

                }
            }
            catch (Exception error)
            {
                using (DataBase db = new DataBase(options))
                {
                    db.AddLogInDB(Convert.ToString(error.Message), Convert.ToString(error.TargetSite), Convert.ToString(Program.f1.dateLabel) + ' ' + Convert.ToString(Program.f1.timeLabel), "DBWorkU Form");
                }

                Fm1.debugBox.Text += Fm1.dateLabel + "" + Fm1.timeLabel + "\r\n";
                Fm1.debugBox.Text += "Метод: " + error.TargetSite + "\r\n";
                Fm1.debugBox.Text += error.Message + "\r\n";
                Fm1.debugBox.Text += error.Source + "\r\n";
                Fm1.debugBox.Text += "Трассировка стека:\r\n" + error.StackTrace + "\r\n";
                Fm1.debugBox.Text += "______________________________________________________\r\n";
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
                using (DataBase db = new DataBase(options))
                {
                    db.AddLogInDB(Convert.ToString(error.Message), Convert.ToString(error.TargetSite), Convert.ToString(Program.f1.dateLabel) + ' ' + Convert.ToString(Program.f1.timeLabel), "DBWorkU Form");
                }

                Fm1.debugBox.Text += Fm1.dateLabel + "" + Fm1.timeLabel + "\r\n";
                Fm1.debugBox.Text += "Метод: " + error.TargetSite + "\r\n";
                Fm1.debugBox.Text += error.Message + "\r\n";
                Fm1.debugBox.Text += error.Source + "\r\n";
                Fm1.debugBox.Text += "Трассировка стека:\r\n" + error.StackTrace + "\r\n";
                Fm1.debugBox.Text += "______________________________________________________\r\n";
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
                using (DataBase db = new DataBase(options))
                {
                    db.AddLogInDB(Convert.ToString(error.Message), Convert.ToString(error.TargetSite), Convert.ToString(Program.f1.dateLabel) + ' ' + Convert.ToString(Program.f1.timeLabel), "DBWorkU Form");
                }

                Fm1.debugBox.Text += Fm1.dateLabel + "" + Fm1.timeLabel + "\r\n";
                Fm1.debugBox.Text += "Метод: " + error.TargetSite + "\r\n";
                Fm1.debugBox.Text += error.Message + "\r\n";
                Fm1.debugBox.Text += error.Source + "\r\n";
                Fm1.debugBox.Text += "Трассировка стека:\r\n" + error.StackTrace + "\r\n";
                Fm1.debugBox.Text += "______________________________________________________\r\n";
            }
           
        }

        private void дополнительноеЗаданиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.ShowDialog();
        }

        private void сортировкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
