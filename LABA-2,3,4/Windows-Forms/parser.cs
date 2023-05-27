using System;
using System.Drawing;
using System.Windows.Forms;
using ClassLibrary1;
using System.Text.RegularExpressions;
using Windows_Forms;

namespace Windows_Forms
{
    public partial class parser : Form
    {
        Form1 mainForm;
        public parser()
        {
            InitializeComponent();
        }
        public parser(Form1 f) 
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            mainForm = f;
        }

        private void openButton_Click(object sender, EventArgs e) 
        {
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string filetext = System.IO.File.ReadAllText(filename);
            richTextBox1.Text = filetext;
        }

        private void SetSelectionStyle(int startIndex, int len, FontStyle style)
        {
            richTextBox1.Select(startIndex, len); 

            Font temp_font = richTextBox1.SelectionFont;
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | style); 

            switch ((int)comboBox1.SelectedIndex) 
            {
                case 0:
                    richTextBox1.SelectionColor = System.Drawing.Color.Red;
                    break;
                case 1:
                    richTextBox1.SelectionColor = System.Drawing.Color.Green;
                    break;
                case 2:
                    richTextBox1.SelectionColor = System.Drawing.Color.Purple;
                    break;
                default:
                    richTextBox1.SelectionColor = System.Drawing.Color.Blue;
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e) 
        {
            int save_cur = richTextBox1.SelectionStart; 

            string text_info = richTextBox1.Text;
            string reg = comboBox1.Text;
            if (comboBox1.SelectedIndex == 2) 
                reg = "(?<=[ ,\\n])m\\w+?n[^a-zA-Z]";

            Reg1 Regular = new Reg1(reg);

            MatchCollection matches = Regular.parse_main(text_info); 

            if (matches.Count > 0) 
            {
                richTextBox1.Select(0, richTextBox1.TextLength); 
                richTextBox1.SelectionColor = System.Drawing.Color.Black;
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Regular);

                textBox1.Text = "Совпадения: \r\n";
                foreach (Match match in matches) 
                {
                    textBox1.Text += match.Index + " позиция: \t" + match.Value + "\r\n";
                    SetSelectionStyle(match.Index, match.Length, FontStyle.Underline);
                }

                richTextBox1.SelectionStart = save_cur; 
                richTextBox1.Select(save_cur, 0);

            }
            else
            {
                textBox1.Text = "Совпадений не найдено \r\n";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) 
        {
            this.button1_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                int save_cur = mainForm.debugBox.SelectionStart;


                Reg1 Regular = new Reg1("[0-3][0-9].[0-1][0-9].[1-2][0-9][0-9][0-9]");
                Reg1 RegularForm = new Reg1("[f,F]orm");

                string IP = "  (192.168.77.129)";

                mainForm.debugBox.Select(0, mainForm.debugBox.TextLength);
                mainForm.debugBox.SelectionColor = System.Drawing.Color.Black;
                mainForm.debugBox.SelectionFont = new Font(mainForm.debugBox.SelectionFont, mainForm.debugBox.SelectionFont.Style | FontStyle.Regular);

                MatchCollection matches = Regular.parse_main(mainForm.debugBox.Text);
                MatchCollection forms = RegularForm.parse_main(mainForm.debugBox.Text);
                int shift = 0;
                Match rebot = matches[0];
                foreach (Match match in matches)
                {
                    if (SetSelectStyle(rebot.Index + shift, rebot.Length, FontStyle.Underline) == 1)
                    {
                        foreach (Match form in forms)
                        {
                            if (form.Index < match.Index && form.Index > rebot.Index)
                            {
                                mainForm.debugBox.Text = mainForm.debugBox.Text.Substring(0, form.Index + shift) + IP + mainForm.debugBox.Text.Substring(form.Index + shift);
                                shift += IP.Length;
                            }

                        }

                    }
                    rebot = match;
                }
                if (SetSelectStyle(rebot.Index + shift, rebot.Length, FontStyle.Underline) == 1)
                {
                    foreach (Match form in forms)
                    {
                        if (form.Index > rebot.Index)
                        {
                            mainForm.debugBox.Text = mainForm.debugBox.Text.Substring(0, form.Index + shift) + IP + mainForm.debugBox.Text.Substring(form.Index + shift);
                            shift += IP.Length;
                        }

                    }

                }

                shift = 0;
                rebot = matches[0];
                foreach (Match match in matches)
                {

                    if (SetSelectStyle(rebot.Index + shift, rebot.Length, FontStyle.Underline) == 1)
                    {
                        foreach (Match form in forms)
                        {
                            if (form.Index < match.Index && form.Index > rebot.Index)
                            {

                                mainForm.debugBox.Select(form.Index + 2 + shift, 16);
                                shift += IP.Length;
                                mainForm.debugBox.SelectionColor = System.Drawing.Color.Green;
                            }

                        }

                    }
                    rebot = match;
                }
                if (SetSelectStyle(rebot.Index + shift, rebot.Length, FontStyle.Underline) == 1)
                {
                    foreach (Match form in forms)
                    {
                        if (form.Index > rebot.Index)
                        {
                            mainForm.debugBox.Select(form.Index + 2 + shift, 16);
                            shift += IP.Length;
                            mainForm.debugBox.SelectionColor = System.Drawing.Color.Green;
                        }

                    }

                }
                matches = Regular.parse_main(mainForm.debugBox.Text);

                foreach (Match match in matches)
                {
                    SetSelectStyle(match.Index, match.Length, FontStyle.Underline);
                }




                mainForm.debugBox.SelectionStart = save_cur;
                mainForm.debugBox.Select(save_cur, 0);
                mainForm.debugBox.SelectionColor = System.Drawing.Color.Black;
                mainForm.debugBox.SelectionFont = new Font(mainForm.debugBox.SelectionFont, mainForm.debugBox.SelectionFont.Style | FontStyle.Regular);
            }
            catch (Exception error)
            {
                mainForm.debugBox.Text += mainForm.dateLabel + "" + mainForm.timeLabel + "\r\n";
                mainForm.debugBox.Text += "Метод: " + error.TargetSite + "\r\n";
                mainForm.debugBox.Text += error.Message + "\r\n";
                mainForm.debugBox.Text += error.Source + "\r\n";
                mainForm.debugBox.Text += "Трассировка стека:\r\n" + error.StackTrace + "\r\n";
                mainForm.debugBox.Text += "______________________________________________________\r\n";
            }
        }
        private int SetSelectStyle(int startIndex, int len, FontStyle style)
        {
            mainForm.debugBox.Select(startIndex, len);

            Font temp_font = mainForm.debugBox.SelectionFont;

            int a = 0;
            string temp = mainForm.debugBox.Text.Substring(startIndex, 10);

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
                    mainForm.debugBox.SelectionColor = System.Drawing.Color.Red;
                    break;
                case 1:
                    mainForm.debugBox.SelectionColor = System.Drawing.Color.Green;
                    break;
            }
            return a;
        }
    }
}
