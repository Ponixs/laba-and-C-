using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms
{
    public partial class Form1 : Form   
    {
        
        public ToolStripLabel dateLabel;
        public ToolStripLabel timeLabel;
        ToolStripLabel infoLabel;
        Timer timer;

        void timer_tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();

        }

        public Form1()
        {
            Program.f1 = this;

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

            System.IO.File.WriteAllText(fileName, debugBox.Text);
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
            debugBox.Text = fileText;
            MessageBox.Show("Файл открыт!");
        }

        private void лР2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 newForm = new Form2(this);
                newForm.Show();
            }
            catch (Exception error)
            {
                debugBox.Text = error.Message + "\r\n";
                debugBox.Text = error.InnerException.ToString() + "\r\n";
                debugBox.Text = error.Source + "\r\n";
                debugBox.Text += error.StackTrace;
            }
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            debugBox.Clear();
        }

        private void закрытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void лР3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void редакторГрафИзобрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                paint newForm = new paint(this);
                newForm.ShowDialog();
            }
            catch (Exception error)
            {
                debugBox.Text = error.Message + "\r\n";
                debugBox.Text = error.InnerException.ToString() + "\r\n";
                debugBox.Text = error.Source + "\r\n";
                debugBox.Text += error.StackTrace;
            }
}

        private void фракталыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                fractal newForm = new fractal(this);
                newForm.ShowDialog();
            }
            catch (Exception error)
            {
                debugBox.Text = error.Message + "\r\n";
                debugBox.Text = error.InnerException.ToString() + "\r\n";
                debugBox.Text = error.Source + "\r\n";
                debugBox.Text += error.StackTrace;
            }
        }

        private void лР4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                parser newForm = new parser(this);
                newForm.Show();
            }
            catch (Exception error)
            {
                debugBox.Text = dateLabel + " " + timeLabel + "\r\n";

                debugBox.Text = error.Message + "\r\n";
                debugBox.Text = error.InnerException.ToString() + "\r\n";
                debugBox.Text = error.Source + "\r\n";
                debugBox.Text += error.StackTrace;
            }
        }

        private void парсингToolStripMenuItem_Click(object sender, EventArgs e)
        {
             int save_cur = debugBox.SelectionStart; 

            string text_info = debugBox.Text;
            Reg1 Regular = new Reg1("[0-3][0-9].[0-1][0-9].[1-2][0-9][0-9][0-9]\\w+(?:[F,f]orm)"); 
            MatchCollection matches = Regular.parse_main(text_info);   

            

            if (matches.Count > 0) 
            {
                debugBox.Select(0, debugBox.TextLength);   
                debugBox.SelectionColor = System.Drawing.Color.Black;
                debugBox.SelectionFont = new Font(debugBox.SelectionFont, debugBox.SelectionFont.Style | FontStyle.Regular);

                foreach (Match match in matches) 
                {
                    SetSelectionStyle(match.Index, match.Length, FontStyle.Underline);
                }

                debugBox.SelectionStart = save_cur; 
                debugBox.Select(save_cur, 0);
                debugBox.SelectionColor = System.Drawing.Color.Black;
                debugBox.SelectionFont = new Font(debugBox.SelectionFont, debugBox.SelectionFont.Style | FontStyle.Regular);

            }
        }

        private void SetSelectionStyle(int startIndex, int len, FontStyle style) 
        {
            debugBox.Select(startIndex, len);

            Font temp_font = debugBox.SelectionFont;

            int a = 0;
            string temp = debugBox.Text.Substring(startIndex, 10); 

            string[] my_data = temp.Split('.'); 
            string[] start = beginD.Text.Split('.');
            string[] end = endD.Text.Split('.');

            int my_y = int.Parse(my_data[2]);
            int s_y = int.Parse(start[2]);
            int e_y = int.Parse(end[2]);

            int my_m = int.Parse(my_data[1]);
            int s_m = int.Parse(start[1]);
            int e_m = int.Parse(end[1]);

            int my_d = int.Parse(my_data[0]);
            int s_d = int.Parse(start[0]);
            int e_d = int.Parse(end[0]);

            if (my_y > s_y && my_y < e_y)
                a = 1;

            if (my_y == s_y || my_y == e_y)
            {
                if (my_m > s_m && my_m < e_m)
                    a = 1;
                if (my_m == s_m || my_m == e_m)
                {
                    if (my_d > s_d && my_d < e_d)
                        a = 1;
                }
            }

            switch (a) 
            {
                case 0:
                    debugBox.SelectionColor = System.Drawing.Color.Red;
                    break;
                case 1:
                    debugBox.SelectionColor = System.Drawing.Color.Green;
                    break;
            }
        }
    }
}
