namespace Windows_Forms
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.формированиеМассиваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.случайноСЗаданнойЧастотойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вручнуюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьЧислоKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перестановкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дополнительноеЗаданиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 426);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "№";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Массив";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.формированиеМассиваToolStripMenuItem,
            this.сортировкаToolStripMenuItem,
            this.дополнительноеЗаданиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(446, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // формированиеМассиваToolStripMenuItem
            // 
            this.формированиеМассиваToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.случайноСЗаданнойЧастотойToolStripMenuItem,
            this.вручнуюToolStripMenuItem});
            this.формированиеМассиваToolStripMenuItem.Name = "формированиеМассиваToolStripMenuItem";
            this.формированиеМассиваToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.формированиеМассиваToolStripMenuItem.Text = "Формирование массива";
            // 
            // случайноСЗаданнойЧастотойToolStripMenuItem
            // 
            this.случайноСЗаданнойЧастотойToolStripMenuItem.Name = "случайноСЗаданнойЧастотойToolStripMenuItem";
            this.случайноСЗаданнойЧастотойToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.случайноСЗаданнойЧастотойToolStripMenuItem.Text = "Случайно с заданной частотой";
            this.случайноСЗаданнойЧастотойToolStripMenuItem.Click += new System.EventHandler(this.случайноСЗаданнойЧастотойToolStripMenuItem_Click);
            // 
            // вручнуюToolStripMenuItem
            // 
            this.вручнуюToolStripMenuItem.Name = "вручнуюToolStripMenuItem";
            this.вручнуюToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.вручнуюToolStripMenuItem.Text = "Вручную";
            this.вручнуюToolStripMenuItem.Click += new System.EventHandler(this.вручнуюToolStripMenuItem_Click);
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem,
            this.вставитьЧислоKToolStripMenuItem,
            this.перестановкаToolStripMenuItem});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.сортировкаToolStripMenuItem.Text = "Функции";
            this.сортировкаToolStripMenuItem.Click += new System.EventHandler(this.сортировкаToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить ";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // вставитьЧислоKToolStripMenuItem
            // 
            this.вставитьЧислоKToolStripMenuItem.Name = "вставитьЧислоKToolStripMenuItem";
            this.вставитьЧислоKToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вставитьЧислоKToolStripMenuItem.Text = "Вставить число k";
            this.вставитьЧислоKToolStripMenuItem.Click += new System.EventHandler(this.вставитьЧислоKToolStripMenuItem_Click);
            // 
            // перестановкаToolStripMenuItem
            // 
            this.перестановкаToolStripMenuItem.Name = "перестановкаToolStripMenuItem";
            this.перестановкаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.перестановкаToolStripMenuItem.Text = "Перестановка";
            this.перестановкаToolStripMenuItem.Click += new System.EventHandler(this.перестановкаToolStripMenuItem_Click);
            // 
            // дополнительноеЗаданиеToolStripMenuItem
            // 
            this.дополнительноеЗаданиеToolStripMenuItem.Name = "дополнительноеЗаданиеToolStripMenuItem";
            this.дополнительноеЗаданиеToolStripMenuItem.Size = new System.Drawing.Size(159, 20);
            this.дополнительноеЗаданиеToolStripMenuItem.Text = "Дополнительное задание";
            this.дополнительноеЗаданиеToolStripMenuItem.Click += new System.EventHandler(this.дополнительноеЗаданиеToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "LABA-№2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem формированиеМассиваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem случайноСЗаданнойЧастотойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вручнуюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьЧислоKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перестановкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дополнительноеЗаданиеToolStripMenuItem;
    }
}