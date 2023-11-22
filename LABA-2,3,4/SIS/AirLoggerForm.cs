using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using AirLoggerPGLib;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Windows_Forms;
using static System.Windows.Forms.Design.AxImporter;
using static System.Runtime.InteropServices.JavaScript.JSType;



namespace SIS
{

    public partial class AirLoggerForm : Form
    {

        public Form1 fm1 = null!;
        private DbContextOptions<DataBase> options = null!;

        public AirLoggerForm() => InitializeComponent();

        public AirLoggerForm(Form1 f)
        {
            InitializeComponent();
            fm1 = f;

            options = fm1.options;

            f.BackColor = Color.Black;
            comboBox1.SelectedItem = "userException";
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns.Add("Col2", "Message");
            dataGridView1.Columns.Add("Col3", "TargetSite");
            dataGridView1.Columns.Add("Col4", "dateTimeExc");
            dataGridView1.Columns.Add("Col5", "indexForm");
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

                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                using (DataBase db = new DataBase(options))
                {
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0:
                            {

                                var users = db.UserException.ToList();
                                foreach (UserException u in users)
                                {
                                    //richTextBox1.Text += ($"{u.id_Student}.{u.FirstName} - {u.LastName} - {u.id_Group}" + "\n\r");
                                    this.dataGridView1.Rows.Add(u.id, u.Message, u.TargetSite, u.dateTimeExc, u.indexForm);
                                }

                                break;
                            }

                        case 1:
                            {

                                var students = db.Students.ToList();
                                    foreach (Students s in students)
                                    {
                                        this.dataGridView1.Rows.Add(s.id_Student, s.FirstName,
                                       s.LastName, s.id_Group);
                                    }
                            }
                            break;

                        case 2:
                            {

                                var projects = db.Project.ToList();
                                foreach (Project p in projects)
                                {
                                    this.dataGridView1.Rows.Add(p.id_Project, p.id_Student,
                                   p.ProjectName, p.versionProject, p.CatalogName);
                                }

                                break;

                            }
                        case 3:
                            {

                                var professors = db.Professor.ToList();
                                foreach (Professor p in professors)
                                {
                                    this.dataGridView1.Rows.Add(p.id_Professor, p.FirstName,
                                   p.LastName, p.id_Department);
                                }
                                break;
                            }
                            default: { break; }
                    }
                }
            }
            catch (DivideByZeroException error)
            {
                using (DataBase db = new DataBase(options))
                {
                    db.AddLogInDB(Convert.ToString(error.Message), Convert.ToString(error.TargetSite), Convert.ToString(Program.f1.dateLabel) + ' ' + Convert.ToString(Program.f1.timeLabel), GetType().FullName);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = dataGridView1.ColumnCount;
            for (var i = 1; i < n; i++)
                dataGridView1.Columns.RemoveAt(1);
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        dataGridView1.Columns[0].HeaderText = "id";
                        dataGridView1.Columns.Add("Col2", "Message");
                        dataGridView1.Columns.Add("Col3", "TargetSite");
                        dataGridView1.Columns.Add("Col4", "dateTimeExc");
                        dataGridView1.Columns.Add("Col5", "indexForm");
                        break;
                    }
                case 1:
                    {
                        dataGridView1.Columns[0].HeaderText = "id_Student";
                        dataGridView1.Columns.Add("Col2", "FirstName");
                        dataGridView1.Columns.Add("Col3", "LastName");
                        dataGridView1.Columns.Add("Col4", "id_Group");
                        break;
                    }
                case 2:
                    {
                        dataGridView1.Columns[0].HeaderText = "id_Project";
                        dataGridView1.Columns.Add("Col2", "id_Student");
                        dataGridView1.Columns.Add("Col3", "ProjectName");
                        dataGridView1.Columns.Add("Col4", "versionProject");
                        dataGridView1.Columns.Add("Col5", "CatalogName");
                        break;
                    }
                case 3:
                    {
                        dataGridView1.Columns[0].HeaderText = "id_Professor";
                        dataGridView1.Columns.Add("Col2", "FirstName");
                        dataGridView1.Columns.Add("Col3", "LastName");
                        dataGridView1.Columns.Add("Col4", "id_Department");
                        break;
                    }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
