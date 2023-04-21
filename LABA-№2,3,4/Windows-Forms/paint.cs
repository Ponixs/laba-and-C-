using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.DataFormats;
using Windows_Forms;

namespace Windows_Forms
{
    public partial class paint : Form
    {
        private int mode;
        private Point movePt;
        private Point nullPt = new Point(int.MaxValue, 0);

        private SolidBrush brush = new SolidBrush(Color.White);
        private Pen pen = new Pen(Color.Black);
        private Point startPt;
        private Color col = Color.Black; 

        int k1 = 1, k2 = 0;
        int A = 50;
        int F = 1;
        int nterms = 3;
        private makePanel makePanel = new makePanel();

        public paint()
        {
            InitializeComponent();
            AddOwnedForm(makePanel);
            openFileDialog1.InitialDirectory = saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            makePanel.numericUpDown1.Value = panel1.ClientSize.Width;
            makePanel.numericUpDown2.Value = panel1.ClientSize.Height;
            makePanel.button1_Click(this, null);
            pen.StartCap = pen.EndCap = LineCap.Round;
            pen.Alignment = PenAlignment.Inset;

        }
        public paint(Form1 f)
        {
            InitializeComponent();
            AddOwnedForm(makePanel);
            openFileDialog1.InitialDirectory = saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            makePanel.numericUpDown1.Value = panel1.ClientSize.Width;
            makePanel.numericUpDown2.Value = panel1.ClientSize.Height;
            makePanel.button1_Click(this, null);
            pen.StartCap = pen.EndCap = LineCap.Round;
            pen.Alignment = PenAlignment.Inset;

        }
        private void ReversibleDraw()
        {
            Point p1 = pictureBox1.PointToScreen(startPt), p2 = pictureBox1.PointToScreen(movePt);
            if (mode == 1)
                ControlPaint.DrawReversibleLine(p1, p2, Color.Black);
            else
                ControlPaint.DrawReversibleFrame(PtToRect(p1, p2), Color.Black, FrameStyle.Thick);
        }
        private void DrawFigure(Rectangle r, Graphics g)
        {
            g.FillRectangle(brush, r);
            g.DrawRectangle(pen, r);
        }
        private Rectangle PtToRect(Point p1, Point p2)
        {
            int x = Math.Min(p1.X, p2.X),
                y = Math.Min(p1.Y, p2.Y),
                w = Math.Abs(p2.X - p1.X),
                h = Math.Abs(p2.Y - p1.Y);
            return new Rectangle(x, y, w, h);
        }
        private void paint_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //startPt = nullPt;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string s = openFileDialog1.FileName;
                try
                {
                    Image im = new Bitmap(s);
                    Graphics g = Graphics.FromImage(im);
                    g.Dispose();
                    if (pictureBox1.Image != null)
                        pictureBox1.Image.Dispose();
                    pictureBox1.Image = im;
                }
                catch
                {
                    MessageBox.Show("File " + s + " has a wrong format.", "Error");
                    return;
                }
                Text = "Image Editor - " + s;
                saveFileDialog1.FileName = Path.ChangeExtension(s, "png");
                openFileDialog1.FileName = "";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = label6.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                label6.BackColor = colorDialog1.Color;
                col = colorDialog1.Color;
            }
        }
        private void label6_BackColorChanged(object sender, EventArgs e)
        {
            pen.Color = label6.BackColor;
        }
        private void label7_BackColorChanged(object sender, EventArgs e)
        {
            //заливка
            brush.Color = label7.BackColor;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Label lb = sender as Label;
            colorDialog1.Color = lb.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                lb.BackColor = colorDialog1.Color;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            makePanel.ActiveControl = makePanel.numericUpDown1;
            if (makePanel.ShowDialog() == DialogResult.OK)
            {
                saveFileDialog1.FileName = "";
                Text = "Image Editor";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //startPt = nullPt;
            string s0 = saveFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string s = saveFileDialog1.FileName;
                if (s.ToUpper() == s0.ToUpper())
                {
                    s0 = Path.GetDirectoryName(s0) + "\\($$##$$).png";
                    pictureBox1.Image.Save(s0);
                    pictureBox1.Image.Dispose();
                    File.Delete(s);
                    File.Move(s0, s);
                    pictureBox1.Image = new Bitmap(s);
                }
                else
                    pictureBox1.Image.Save(s);
                Text = "Image Editor - " + s;
            }
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            movePt = startPt = e.Location;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //label1.Text = string.Format("X,Y: {0},{1}", e.X, e.Y);
            if (startPt == nullPt)
                return;
            if (e.Button == MouseButtons.Left)
                switch (mode)
                {
                    case 0:
                        Graphics g = Graphics.FromImage(pictureBox1.Image);
                        g.DrawLine(pen, startPt, e.Location);
                        g.Dispose();
                        startPt = e.Location;
                        pictureBox1.Invalidate();
                        pictureBox1.Update();
                        break;
                    case 1:
                        ReversibleDraw();
                        movePt = e.Location;
                        ReversibleDraw();
                        break;
                    case 2:
                        ReversibleDraw();
                        movePt = e.Location;
                        ReversibleDraw();
                        break;
                }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (startPt == nullPt)
                return;
            if (mode >= 1)
            {
                ReversibleDraw();
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                switch (mode)
                {
                    case 0:
                        g.DrawLine(pen, startPt, movePt);
                        break;
                    case 1:
                        g.DrawLine(pen, startPt, movePt);
                        break;
                    case 2:
                        DrawFigure(PtToRect(startPt, movePt), g);
                        this.Invalidate();
                        break;
                }
                g.Dispose();
                pictureBox1.Invalidate();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                g.Clear(Color.White);
            pictureBox1.Invalidate();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = (int)numericUpDown4.Value;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (!rb.Checked)
                return;
            mode = rb.TabIndex;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            redrawFourier();
        }
        private void redrawFourier()
        {
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);

            g.DrawLine(pen, 0, pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height / 2);
            pen.Width = Convert.ToInt32(numericUpDown4.Value);
            pen.Color = col;
            int Interval = pictureBox1.Width;
            double yp = 0, yy1 = 0, yy2 = 0;
            int angle = 0;
            int xtemp = 0;
            int ytemp = pictureBox1.Height / 2;

            for(int i = 0; i < Interval; i++)
            {
                for(int j = 1; j < nterms; j++)
                {
                    yy1 = A / ((k1 * j) + k2);
                    double arg = ((j * k1) + k2) * F * 0.01397 * angle;
                    yy2 = Math.Sin(arg);
                    yp = yp + yy1 * yy2;
                }
                xtemp = i;
                g.DrawLine(pen, xtemp, ytemp, i, pictureBox1.Height / 2 + (int)Math.Truncate(yp));
                yp = 0;
                angle++;
            }
            pen.Color = Color.Black;
            g.Dispose();
            pictureBox1.Invalidate();
        }
         

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            nterms = (int)numericUpDown1.Value;
            redrawFourier();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            A = (int)numericUpDown2.Value;
            redrawFourier();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((int)comboBox1.SelectedIndex)
            {
                case 0:
                    k1 = 1;
                    k2 = 0;
                    break;
                case 1:
                    k1 = 2;
                    k2 = 1;
                    break;
                case 2:
                    k1 = 2;
                    k2 = -1;
                    break;
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            F = (int)numericUpDown3.Value;
            redrawFourier();
        }
    }
}
