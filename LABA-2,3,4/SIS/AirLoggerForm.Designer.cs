namespace SIS
{
    partial class AirLoggerForm
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
            button6 = new Button();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button6
            // 
            button6.AutoSize = true;
            button6.Dock = DockStyle.Top;
            button6.Location = new Point(0, 0);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(788, 40);
            button6.TabIndex = 19;
            button6.Text = "Вывод данных с выбранной таблицы";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 40);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(788, 393);
            dataGridView1.TabIndex = 20;
            // 
            // Id
            // 
            Id.HeaderText = "Column1";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "userExeption", "Student", "Project", "Professor" });
            comboBox1.Location = new Point(12, 10);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 21;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // AirLoggerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 433);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button6);
            Name = "AirLoggerForm";
            Text = "AirLoggerForm";
            Load += AirLoggerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button6;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private ComboBox comboBox1;
    }
}