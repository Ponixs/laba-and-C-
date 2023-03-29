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
    public partial class Form1 : Form   
    {
        ToolStripLabel dateLabel;
        ToolStripLabel timeLabel;
        ToolStripLabel infoLabel;
        Timer timer;

        void timer_tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();

        }

        public Form1()
        {

            InitializeComponent();

            infoLabel = new ToolStripLabel();
            infoLabel.Text = "Дата и время: ";
            dateLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();

            statusStrip1.Items.Add(infoLabel);
            statusStrip1.Items.Add(dateLabel);
            statusStrip1.Items.Add(timeLabel);

            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_tick;
            timer.Start();
           
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;

            string fileName = saveFileDialog1.FileName;

            System.IO.File.WriteAllText(fileName, textBox1.Text);
            MessageBox.Show("Файл сохранен!");
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;

            string fileName = openFileDialog1.FileName;

            string fileText = System.IO.File.ReadAllText(fileName);
            textBox1.Text = fileText;
            MessageBox.Show("Файл открыт!");
        }

        private void лР2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 newForm = new Form2();
                newForm.Show();
            }
            catch (Exception error)
            {
                textBox1.Text = error.Message + '\n';
                textBox1.Text += error.StackTrace;
            }
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void закрытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
