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
        public parser(Form1 f) // Инициализация
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            mainForm = f;
        }

        private void openButton_Click(object sender, EventArgs e) // кнопка для открытия файла
        {
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string filetext = System.IO.File.ReadAllText(filename);
            richTextBox1.Text = filetext;
        }

        private void SetSelectionStyle(int startIndex, int len, FontStyle style) // Функция для выделения совпадений в тексте
        {
            richTextBox1.Select(startIndex, len); // Выделяем текст

            Font temp_font = richTextBox1.SelectionFont;
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | style); // Меняем стиль на подчеркнутый

            switch ((int)comboBox1.SelectedIndex) // Для разных цветов у разных регулярок
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

            //richTextBox1.SelectionStart = richTextBox1.Text.Length;
        }

        private void button1_Click(object sender, EventArgs e) // Выполнение регулярки
        {
            int save_cur = richTextBox1.SelectionStart; // Сохраняем позицию курсора в тексте

            string text_info = richTextBox1.Text;
            string reg = comboBox1.Text;
            if (comboBox1.SelectedIndex == 2) // Если выбрано доп. задание
                reg = "(?<=[ ,\\n])m\\w+?n[^a-zA-Z]";

            Reg1 Regular = new Reg1(reg); // При помощи длл либы создаем класс для выполнения регулярки

            MatchCollection matches = Regular.parse_main(text_info); // Выполняем функцию в классе длл либы

            if (matches.Count > 0) // Если найдены совпадения
            {
                richTextBox1.Select(0, richTextBox1.TextLength); // Чистим текст от стилей
                richTextBox1.SelectionColor = System.Drawing.Color.Black;
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Regular);

                textBox1.Text = "Совпадения: \r\n";
                foreach (Match match in matches) // Выделяем каждое совпадение
                {
                    textBox1.Text += match.Index + " позиция: \t" + match.Value + "\r\n";
                    SetSelectionStyle(match.Index, match.Length, FontStyle.Underline);
                }

                richTextBox1.SelectionStart = save_cur; // Возвращаем мкурсор в начало
                richTextBox1.Select(save_cur, 0);

            }
            else
            {
                textBox1.Text = "Совпадений не найдено \r\n";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) // При вводе текста выполняем регулярку (2 пункт)
        {
            this.button1_Click(sender, e);
        }
    }
}
