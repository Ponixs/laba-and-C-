using AirLoggerPGLib;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Forms;

namespace SIS
{
    public partial class AddInDB : Form
    {
        public Form1 fm;
        private DbContextOptions<DataBase> options = null!;

        public AddInDB()
        {
            InitializeComponent();
        }
        public AddInDB(Form1 f)
        {
            InitializeComponent();
            fm = f;
            options = fm.options;

        }

        private void AddInDB_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DataBase db = new DataBase(options))
            {

                db.AddLogInDB(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);

            }
            Dispose();
        }
    }
}
