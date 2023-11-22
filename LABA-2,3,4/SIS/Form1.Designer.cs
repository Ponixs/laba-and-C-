namespace Windows_Forms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            логФайлToolStripMenuItem = new ToolStripMenuItem();
            бДСЛогамиToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            вTxtФайлToolStripMenuItem = new ToolStripMenuItem();
            вDBToolStripMenuItem = new ToolStripMenuItem();
            создатьToolStripMenuItem = new ToolStripMenuItem();
            закрытьToolStripMenuItem = new ToolStripSeparator();
            закрытьToolStripMenuItem1 = new ToolStripMenuItem();
            лабораторныеToolStripMenuItem = new ToolStripMenuItem();
            лР2ToolStripMenuItem = new ToolStripMenuItem();
            лР3ToolStripMenuItem = new ToolStripMenuItem();
            редакторГрафИзобрToolStripMenuItem = new ToolStripMenuItem();
            фракталыToolStripMenuItem = new ToolStripMenuItem();
            лР4ToolStripMenuItem = new ToolStripMenuItem();
            лРToolStripMenuItem = new ToolStripMenuItem();
            парсингToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            debugBox = new RichTextBox();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.GripMargin = new Padding(2);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, лабораторныеToolStripMenuItem, парсингToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Margin = new Padding(2);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(933, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, сохранитьToolStripMenuItem, создатьToolStripMenuItem, закрытьToolStripMenuItem, закрытьToolStripMenuItem1 });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { логФайлToolStripMenuItem, бДСЛогамиToolStripMenuItem });
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(180, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // логФайлToolStripMenuItem
            // 
            логФайлToolStripMenuItem.Name = "логФайлToolStripMenuItem";
            логФайлToolStripMenuItem.Size = new Size(180, 22);
            логФайлToolStripMenuItem.Text = "Лог-файл";
            логФайлToolStripMenuItem.Click += логФайлToolStripMenuItem_Click;
            // 
            // бДСЛогамиToolStripMenuItem
            // 
            бДСЛогамиToolStripMenuItem.Name = "бДСЛогамиToolStripMenuItem";
            бДСЛогамиToolStripMenuItem.Size = new Size(180, 22);
            бДСЛогамиToolStripMenuItem.Text = "БД";
            бДСЛогамиToolStripMenuItem.Click += бДСЛогамиToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { вTxtФайлToolStripMenuItem, вDBToolStripMenuItem });
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(180, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить лог";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // вTxtФайлToolStripMenuItem
            // 
            вTxtФайлToolStripMenuItem.Name = "вTxtФайлToolStripMenuItem";
            вTxtФайлToolStripMenuItem.Size = new Size(130, 22);
            вTxtФайлToolStripMenuItem.Text = "В txt файл";
            вTxtФайлToolStripMenuItem.Click += вTxtФайлToolStripMenuItem_Click;
            // 
            // вDBToolStripMenuItem
            // 
            вDBToolStripMenuItem.Name = "вDBToolStripMenuItem";
            вDBToolStripMenuItem.Size = new Size(130, 22);
            вDBToolStripMenuItem.Text = "В DB";
            вDBToolStripMenuItem.Click += вDBToolStripMenuItem_Click;
            // 
            // создатьToolStripMenuItem
            // 
            создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            создатьToolStripMenuItem.Size = new Size(180, 22);
            создатьToolStripMenuItem.Text = "Создать";
            создатьToolStripMenuItem.Click += создатьToolStripMenuItem_Click;
            // 
            // закрытьToolStripMenuItem
            // 
            закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            закрытьToolStripMenuItem.Size = new Size(177, 6);
            // 
            // закрытьToolStripMenuItem1
            // 
            закрытьToolStripMenuItem1.Name = "закрытьToolStripMenuItem1";
            закрытьToolStripMenuItem1.Size = new Size(180, 22);
            закрытьToolStripMenuItem1.Text = "Закрыть";
            закрытьToolStripMenuItem1.Click += закрытьToolStripMenuItem1_Click;
            // 
            // лабораторныеToolStripMenuItem
            // 
            лабораторныеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { лР2ToolStripMenuItem, лР3ToolStripMenuItem, лР4ToolStripMenuItem, лРToolStripMenuItem });
            лабораторныеToolStripMenuItem.Name = "лабораторныеToolStripMenuItem";
            лабораторныеToolStripMenuItem.Size = new Size(101, 20);
            лабораторныеToolStripMenuItem.Text = "Лабораторные";
            // 
            // лР2ToolStripMenuItem
            // 
            лР2ToolStripMenuItem.Name = "лР2ToolStripMenuItem";
            лР2ToolStripMenuItem.Size = new Size(113, 22);
            лР2ToolStripMenuItem.Text = "ЛР-№2";
            лР2ToolStripMenuItem.Click += лР2ToolStripMenuItem_Click;
            // 
            // лР3ToolStripMenuItem
            // 
            лР3ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { редакторГрафИзобрToolStripMenuItem, фракталыToolStripMenuItem });
            лР3ToolStripMenuItem.Name = "лР3ToolStripMenuItem";
            лР3ToolStripMenuItem.Size = new Size(113, 22);
            лР3ToolStripMenuItem.Text = "ЛР-№3";
            лР3ToolStripMenuItem.Click += лР3ToolStripMenuItem_Click;
            // 
            // редакторГрафИзобрToolStripMenuItem
            // 
            редакторГрафИзобрToolStripMenuItem.Name = "редакторГрафИзобрToolStripMenuItem";
            редакторГрафИзобрToolStripMenuItem.Size = new Size(193, 22);
            редакторГрафИзобрToolStripMenuItem.Text = "редактор граф. изобр";
            редакторГрафИзобрToolStripMenuItem.Click += редакторГрафИзобрToolStripMenuItem_Click;
            // 
            // фракталыToolStripMenuItem
            // 
            фракталыToolStripMenuItem.Name = "фракталыToolStripMenuItem";
            фракталыToolStripMenuItem.Size = new Size(193, 22);
            фракталыToolStripMenuItem.Text = "Фракталы";
            фракталыToolStripMenuItem.Click += фракталыToolStripMenuItem_Click;
            // 
            // лР4ToolStripMenuItem
            // 
            лР4ToolStripMenuItem.Name = "лР4ToolStripMenuItem";
            лР4ToolStripMenuItem.Size = new Size(113, 22);
            лР4ToolStripMenuItem.Text = "ЛР-№4";
            лР4ToolStripMenuItem.Click += лР4ToolStripMenuItem_Click;
            // 
            // лРToolStripMenuItem
            // 
            лРToolStripMenuItem.Name = "лРToolStripMenuItem";
            лРToolStripMenuItem.Size = new Size(113, 22);
            лРToolStripMenuItem.Text = "ЛР-№5";
            лРToolStripMenuItem.Click += лРToolStripMenuItem_Click;
            // 
            // парсингToolStripMenuItem
            // 
            парсингToolStripMenuItem.Name = "парсингToolStripMenuItem";
            парсингToolStripMenuItem.Size = new Size(12, 20);
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 497);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(933, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 17);
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(0, 17);
            // 
            // debugBox
            // 
            debugBox.Dock = DockStyle.Fill;
            debugBox.Location = new Point(0, 24);
            debugBox.Margin = new Padding(2);
            debugBox.Name = "debugBox";
            debugBox.Size = new Size(933, 473);
            debugBox.TabIndex = 12;
            debugBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(debugBox);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Multitool";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem лабораторныеToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private OpenFileDialog openFileDialog1;
        private ToolStripSeparator закрытьToolStripMenuItem;
        private ToolStripMenuItem закрытьToolStripMenuItem1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem лР2ToolStripMenuItem;
        private ToolStripMenuItem лР3ToolStripMenuItem;
        private ToolStripMenuItem лР4ToolStripMenuItem;
        private ToolStripMenuItem редакторГрафИзобрToolStripMenuItem;
        private ToolStripMenuItem фракталыToolStripMenuItem;
        private ToolStripMenuItem парсингToolStripMenuItem;
        private ToolStripMenuItem лРToolStripMenuItem;
        private ToolStripMenuItem логФайлToolStripMenuItem;
        private ToolStripMenuItem бДСЛогамиToolStripMenuItem;
        public RichTextBox debugBox;
        private ToolStripMenuItem вTxtФайлToolStripMenuItem;
        private ToolStripMenuItem вDBToolStripMenuItem;
    }
}

