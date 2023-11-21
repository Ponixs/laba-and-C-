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
            debugBox = new RichTextBox();
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
            button6.Text = "Вывод исключений";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // debugBox
            // 
            debugBox.Dock = DockStyle.Fill;
            debugBox.Location = new Point(0, 40);
            debugBox.Margin = new Padding(2);
            debugBox.Name = "debugBox";
            debugBox.Size = new Size(788, 393);
            debugBox.TabIndex = 20;
            debugBox.Text = "";
            // 
            // AirLoggerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 433);
            Controls.Add(debugBox);
            Controls.Add(button6);
            Name = "AirLoggerForm";
            Text = "AirLoggerForm";
            Load += AirLoggerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button6;
        public RichTextBox debugBox;
    }
}