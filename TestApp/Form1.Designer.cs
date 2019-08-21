namespace TestApp
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
            this.HelpLabel = new System.Windows.Forms.Label();
            this.textBoxXPath = new System.Windows.Forms.TextBox();
            this.buttonChose = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HelpLabel
            // 
            this.HelpLabel.AllowDrop = true;
            this.HelpLabel.AutoSize = true;
            this.HelpLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HelpLabel.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpLabel.Location = new System.Drawing.Point(0, 0);
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(223, 47);
            this.HelpLabel.TabIndex = 0;
            this.HelpLabel.Text = "Input XPath";
            // 
            // textBoxXPath
            // 
            this.textBoxXPath.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxXPath.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxXPath.Location = new System.Drawing.Point(0, 47);
            this.textBoxXPath.Name = "textBoxXPath";
            this.textBoxXPath.Size = new System.Drawing.Size(481, 34);
            this.textBoxXPath.TabIndex = 1;
            // 
            // buttonChose
            // 
            this.buttonChose.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChose.Location = new System.Drawing.Point(512, 40);
            this.buttonChose.Name = "buttonChose";
            this.buttonChose.Size = new System.Drawing.Size(126, 25);
            this.buttonChose.TabIndex = 2;
            this.buttonChose.Text = "Chose XML file";
            this.buttonChose.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(43, 136);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(566, 208);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // buttonExecute
            // 
            this.buttonExecute.Enabled = false;
            this.buttonExecute.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExecute.Location = new System.Drawing.Point(512, 70);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(126, 23);
            this.buttonExecute.TabIndex = 4;
            this.buttonExecute.Text = "Use XPath";
            this.buttonExecute.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 356);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonChose);
            this.Controls.Add(this.textBoxXPath);
            this.Controls.Add(this.HelpLabel);
            this.MaximumSize = new System.Drawing.Size(677, 403);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HelpLabel;
        private System.Windows.Forms.TextBox textBoxXPath;
        private System.Windows.Forms.Button buttonChose;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonExecute;
    }
}

