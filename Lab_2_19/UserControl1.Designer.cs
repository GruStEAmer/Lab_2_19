namespace Lab_2_19
{
    partial class UserControl1
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(232, 44);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(38, 38);
            button1.TabIndex = 1;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ButtonHighlight;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(178, 50);
            textBox3.MaxLength = 10;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(36, 27);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DarkOrange;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 16F);
            textBox2.Location = new Point(66, 44);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(165, 85);
            textBox2.TabIndex = 4;
            textBox2.Text = "repeat";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Name = "UserControl1";
            Size = new Size(479, 614);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
    }
}
