using ClassLibrary1;
using SIS;
using AirLoggerPGLib;
using Timer = System.Windows.Forms.Timer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Windows_Forms
{
    public partial class Form1 : Form
    {

        public ToolStripLabel dateLabel;
        public DbContextOptions<DataBase> options;
        ToolStripLabel infoLabel;
        Timer timer;

        void timer_tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToString();

        }

        public Form1()
        {
            Program.f1 = this;

            InitializeComponent();

            var builder = new ConfigurationBuilder();
            // установка пути к текущему каталогу
            builder.SetBasePath(Directory.GetCurrentDirectory());
            // получаем конфигурацию из файла
            builder.AddJsonFile("airlogger.json");
            // создаем конфигурацию
            var config = builder.Build();
            // получаем строку подключения
            string connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<DataBase>();
            options = optionsBuilder
                .UseNpgsql(connectionString)
                .Options;


            infoLabel = new ToolStripLabel();
            infoLabel.Text = "Дата и время: ";
            dateLabel = new ToolStripLabel();

            statusStrip1.Items.Add(infoLabel);
            statusStrip1.Items.Add(dateLabel);

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


        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void лР2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 newForm = new Form2(this, options);
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
                debugBox.Text = dateLabel + "\r\n";

                debugBox.Text = error.Message + "\r\n";
                debugBox.Text = error.InnerException.ToString() + "\r\n";
                debugBox.Text = error.Source + "\r\n";
                debugBox.Text += error.StackTrace;
            }
        }

        private void лРToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                asyncParser newForm = new asyncParser(this);
                newForm.Show();
            }
            catch (Exception error)
            {
                debugBox.Text = dateLabel + "\r\n";

                debugBox.Text = error.Message + "\r\n";
                debugBox.Text = error.InnerException.ToString() + "\r\n";
                debugBox.Text = error.Source + "\r\n";
                debugBox.Text += error.StackTrace;
            }
        }



        private void бДСЛогамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AirLoggerForm newForm = new AirLoggerForm(this);
                newForm.Show();
            }
            catch (Exception error)
            {
                debugBox.Text = dateLabel + "\r\n";

                debugBox.Text = error.Message + "\r\n";
                debugBox.Text = $"{error.InnerException}\r\n";
                debugBox.Text = error.Source + "\r\n";
                debugBox.Text += error.StackTrace;
            }
        }

        private void логФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;

            string fileName = openFileDialog1.FileName;

            string fileText = System.IO.File.ReadAllText(fileName);
            debugBox.Text = fileText;
            MessageBox.Show("Файл открыт!");
        }

        private void вTxtФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;

            string fileName = saveFileDialog1.FileName;

            System.IO.File.WriteAllText(fileName, debugBox.Text);
            MessageBox.Show("Файл сохранен!");
        }

        private void вDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AddInDB newForm = new AddInDB(this);
                newForm.Show();
            }
            catch (Exception error)
            {
                debugBox.Text = dateLabel + "\r\n";

                debugBox.Text = error.Message + "\r\n";
                debugBox.Text = $"{error.InnerException}\r\n";
                debugBox.Text = error.Source + "\r\n";
                debugBox.Text += error.StackTrace;
            }
        }
    }
}
