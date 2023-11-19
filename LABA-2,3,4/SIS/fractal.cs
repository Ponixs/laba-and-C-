using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms
{
    public partial class fractal : Form
    {
        Form1 fm1;
        Graphics g;
        int[] array = new int[5];

        public fractal()
        {
            InitializeComponent();
        }

        public fractal(Form1 f)
        {
            InitializeComponent();
            fm1 = f;
        }

        private void fractal_Load(object sender, EventArgs e)
        {
            trackBar4.BackColor = Color.LightBlue;
            trackBar3.BackColor = Color.LightGreen;
            trackBar2.BackColor = Color.LightPink;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private double find_degree(double a, int i)
        {
            if (i>0)
            {
                a *= find_degree(a, i - 1);
            }
            return a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();

            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    tree(pictureBox1.Width / 2, pictureBox1.Height, Math.PI / 2, ((pictureBox1.Height / 6) + (pictureBox1.Width / 6)) / 2, Convert.ToInt32(numericUpDown2.Value), trackBar2.Value*25, trackBar3.Value*25, trackBar4.Value*25);
                    break;
                case 1:
                    carpet(pictureBox1.Width / 2, pictureBox1.Height / 2, ((pictureBox1.Height / 6) + (pictureBox1.Width / 6)) / 2, Convert.ToInt32(numericUpDown2.Value),trackBar2.Value*25, trackBar3.Value*25, trackBar4.Value*25);
                    break;
            }

           
        }
        private void Form4_Resize(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            this.button1_Click(sender, e);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            this.button1_Click(sender, e);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void carpet(int x, int y, int size, int step, int R, int G, int B)
        {
            if (step != 0)
            {
                int x1 = x - size / 2;
                int x2 = x + size / 2;
                int y1 = y - size / 2;
                int y2 = y + size / 2;


                if (R > 255)
                    R = 255;
                if (G > 255)
                    G = 255;
                if (B > 255)
                    B = 255;

                Pen my_pen_temp = new Pen(Color.FromArgb(R, G, B));
                g.DrawRectangle(my_pen_temp, x - size / 2, y - size / 2, size, size);

                carpet(x1, y1, size / 2, step - 1, R + 10, G + 30, B + 30);
                carpet(x1, y2, size / 2, step - 1, R + 10, G + 30, B + 30);
                carpet(x2, y1, size / 2, step - 1, R + 10, G + 30, B + 30);
                carpet(x2, y2, size / 2, step - 1, R + 10, G + 30, B + 30);
            }

        }

        private void tree(double x0, double y0, double a, double L, int N, int R, int G, int B)
        {
            const double k = 0.667;
            double x1, y1;
            if (N > 0)
            {

                if (R > 255)
                    R = 255;
                if (G > 255)
                    G = 255;
                if (B > 255)
                    B = 255;

                Pen my_pen_temp = new Pen(Color.FromArgb(R, G, B));

                x1 = x0 + L * Math.Cos(a);
                y1 = y0 - L * Math.Sin(a);
                g.DrawLine(my_pen_temp, (float)x0, (float)y0, (float)x1, (float)y1);
                tree(x1, y1, a + Math.PI / 3, L * k, N - 1, R + 10, G + 30, B + 30);
                tree(x1, y1, a + Math.PI / 7, L * k, N - 1, R + 10, G + 30, B + 30);
                tree(x1, y1, a - Math.PI / 3, L * k, N - 1, R + 10, G + 30, B + 30);
                tree(x1, y1, a - Math.PI / 7, L * k, N - 1, R + 10, G + 30, B + 30);
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            //using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            //g.Clear(Color.White);
            pictureBox1.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                
                g = pictureBox1.CreateGraphics();
                g.Clear(Color.White);
                int intValue;
                double number;
                bool succes1 = Double.TryParse(textBox1.Text, out number);
                bool succes2 = Int32.TryParse(textBox2.Text, out intValue);

                if (!succes1 || !succes2 || intValue > 100 || intValue < 0) throw new Exception("Введенные данные не соответствуют требованиям");
                number = find_degree(number, intValue);

                System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 16);
                System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                float x = 150.0F;
                float y = 50.0F;
                System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
                g.DrawString(Convert.ToString(number), drawFont, drawBrush, x, y, drawFormat);
                drawFont.Dispose();
                drawBrush.Dispose();
                g.Dispose();
            }
            catch (Exception error)
            {
                fm1.debugBox.Text = error.Message + '\n';
                fm1.debugBox.Text += error.StackTrace;
            }
        }
    }
}
