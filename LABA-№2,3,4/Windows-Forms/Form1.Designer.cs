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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.закрытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.лабораторныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лР1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лР2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лР3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редакторГрафИзобрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фракталыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лР4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.парсингToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.endD = new System.Windows.Forms.TextBox();
            this.beginD = new System.Windows.Forms.TextBox();
            this.debugBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.лабораторныеToolStripMenuItem,
            this.открытьToolStripMenuItem1,
            this.парсингToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.создатьToolStripMenuItem,
            this.закрытьToolStripMenuItem,
            this.закрытьToolStripMenuItem1});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить ";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(133, 6);
            // 
            // закрытьToolStripMenuItem1
            // 
            this.закрытьToolStripMenuItem1.Name = "закрытьToolStripMenuItem1";
            this.закрытьToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.закрытьToolStripMenuItem1.Text = "Закрыть";
            this.закрытьToolStripMenuItem1.Click += new System.EventHandler(this.закрытьToolStripMenuItem1_Click);
            // 
            // лабораторныеToolStripMenuItem
            // 
            this.лабораторныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лР1ToolStripMenuItem,
            this.лР2ToolStripMenuItem,
            this.лР3ToolStripMenuItem,
            this.лР4ToolStripMenuItem});
            this.лабораторныеToolStripMenuItem.Name = "лабораторныеToolStripMenuItem";
            this.лабораторныеToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.лабораторныеToolStripMenuItem.Text = "Лабораторные";
            // 
            // лР1ToolStripMenuItem
            // 
            this.лР1ToolStripMenuItem.Name = "лР1ToolStripMenuItem";
            this.лР1ToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.лР1ToolStripMenuItem.Text = "ЛР-№1";
            // 
            // лР2ToolStripMenuItem
            // 
            this.лР2ToolStripMenuItem.Name = "лР2ToolStripMenuItem";
            this.лР2ToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.лР2ToolStripMenuItem.Text = "ЛР-№2";
            this.лР2ToolStripMenuItem.Click += new System.EventHandler(this.лР2ToolStripMenuItem_Click);
            // 
            // лР3ToolStripMenuItem
            // 
            this.лР3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редакторГрафИзобрToolStripMenuItem,
            this.фракталыToolStripMenuItem});
            this.лР3ToolStripMenuItem.Name = "лР3ToolStripMenuItem";
            this.лР3ToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.лР3ToolStripMenuItem.Text = "ЛР-№3";
            this.лР3ToolStripMenuItem.Click += new System.EventHandler(this.лР3ToolStripMenuItem_Click);
            // 
            // редакторГрафИзобрToolStripMenuItem
            // 
            this.редакторГрафИзобрToolStripMenuItem.Name = "редакторГрафИзобрToolStripMenuItem";
            this.редакторГрафИзобрToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.редакторГрафИзобрToolStripMenuItem.Text = "редактор граф. изобр";
            this.редакторГрафИзобрToolStripMenuItem.Click += new System.EventHandler(this.редакторГрафИзобрToolStripMenuItem_Click);
            // 
            // фракталыToolStripMenuItem
            // 
            this.фракталыToolStripMenuItem.Name = "фракталыToolStripMenuItem";
            this.фракталыToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.фракталыToolStripMenuItem.Text = "Фракталы";
            this.фракталыToolStripMenuItem.Click += new System.EventHandler(this.фракталыToolStripMenuItem_Click);
            // 
            // лР4ToolStripMenuItem
            // 
            this.лР4ToolStripMenuItem.Name = "лР4ToolStripMenuItem";
            this.лР4ToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.лР4ToolStripMenuItem.Text = "ЛР-№4";
            this.лР4ToolStripMenuItem.Click += new System.EventHandler(this.лР4ToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem1
            // 
            this.открытьToolStripMenuItem1.Name = "открытьToolStripMenuItem1";
            this.открытьToolStripMenuItem1.Size = new System.Drawing.Size(64, 20);
            this.открытьToolStripMenuItem1.Text = "открыть";
            // 
            // парсингToolStripMenuItem
            // 
            this.парсингToolStripMenuItem.Name = "парсингToolStripMenuItem";
            this.парсингToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.парсингToolStripMenuItem.Text = "Парсинг ";
            this.парсингToolStripMenuItem.Click += new System.EventHandler(this.парсингToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(683, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "До:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "От:";
            // 
            // endD
            // 
            this.endD.Location = new System.Drawing.Point(709, 4);
            this.endD.Margin = new System.Windows.Forms.Padding(2);
            this.endD.Name = "endD";
            this.endD.Size = new System.Drawing.Size(80, 20);
            this.endD.TabIndex = 9;
            this.endD.Text = "30.12.2023";
            // 
            // beginD
            // 
            this.beginD.Location = new System.Drawing.Point(587, 4);
            this.beginD.Margin = new System.Windows.Forms.Padding(2);
            this.beginD.Name = "beginD";
            this.beginD.Size = new System.Drawing.Size(80, 20);
            this.beginD.TabIndex = 8;
            this.beginD.Text = "16.06.2014";
            // 
            // debugBox
            // 
            this.debugBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debugBox.Location = new System.Drawing.Point(0, 24);
            this.debugBox.Margin = new System.Windows.Forms.Padding(2);
            this.debugBox.Name = "debugBox";
            this.debugBox.Size = new System.Drawing.Size(800, 404);
            this.debugBox.TabIndex = 12;
            this.debugBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.debugBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endD);
            this.Controls.Add(this.beginD);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Multitool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лабораторныеToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripSeparator закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem лР1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лР2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лР3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лР4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редакторГрафИзобрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фракталыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem парсингToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox endD;
        private System.Windows.Forms.TextBox beginD;
        public System.Windows.Forms.RichTextBox debugBox;
    }
}

