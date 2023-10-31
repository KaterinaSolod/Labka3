namespace Labka3
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
            this.button = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ооооо = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(114, 192);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(151, 69);
            this.button.TabIndex = 0;
            this.button.Text = "Відправити";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(43, 129);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(277, 22);
            this.textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 2;
            // 
            // ооооо
            // 
            this.ооооо.AutoSize = true;
            this.ооооо.Location = new System.Drawing.Point(40, 339);
            this.ооооо.Name = "ооооо";
            this.ооооо.Size = new System.Drawing.Size(44, 16);
            this.ооооо.TabIndex = 4;
            this.ооооо.Text = "label3";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(43, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(277, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 423);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ооооо);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ооооо;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

