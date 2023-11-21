using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using AirLoggerPGLib;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Windows_Forms;
using static System.Windows.Forms.Design.AxImporter;



namespace SIS
{

    public partial class AirLoggerForm : Form
    {

        public Form1 fm1 = null!;
        private DbContextOptions<DataBase> options = null!;

        public AirLoggerForm() => InitializeComponent();

        public AirLoggerForm(Form1 f, DbContextOptions<DataBase> DBoptions)
        {
            InitializeComponent();
            fm1 = f;

            options = DBoptions;
        }



        private void AirLoggerForm_Load(object sender, EventArgs e)
        {

        }

        /*private void button2_Click(object sender, EventArgs e)
        {
            using (DataBase db = new DataBase(options))
            {
                Student user1 = new Student { id_Student = 1, FirstName = "Tom", LastName = "Tom", id_Group = 4 };
                Student user2 = new Student { id_Student = 3, FirstName = "Alice", LastName = "Alice", id_Group = 2 };
                // добавляем их в бд
                db.Students.AddRange(user1, user2);
                db.SaveChanges();
            }

        }*/

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                using (DataBase db = new DataBase(options))
                {
                    var users = db.UserException.ToList();
                    debugBox.Text = "";
                    foreach (UserException u in users)
                    {
                        //richTextBox1.Text += ($"{u.id_Student}.{u.FirstName} - {u.LastName} - {u.id_Group}" + "\n\r");
                        debugBox.Text += ($"{u.id}.{u.Message} - {u.TargetSite} - {u.dateTimeExc} - {u.indexForm}" + "\n\r");
                    }
                }
            }
            catch (DivideByZeroException ex)
            {
                using (DataBase db = new DataBase(options))
                {
                    db.AddLogInDB(Convert.ToString(ex.Message), Convert.ToString(ex.TargetSite), Convert.ToString(Program.f1.dateLabel) + ' ' + Convert.ToString(Program.f1.timeLabel), "DBWorkU Form");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
