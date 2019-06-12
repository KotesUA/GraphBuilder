namespace курсовая
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OverlayCheckBox = new System.Windows.Forms.CheckBox();
            this.EquationTextBox = new System.Windows.Forms.TextBox();
            this.BuildButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(510, 390);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // OverlayCheckBox
            // 
            this.OverlayCheckBox.AutoSize = true;
            this.OverlayCheckBox.Location = new System.Drawing.Point(11, 432);
            this.OverlayCheckBox.Name = "OverlayCheckBox";
            this.OverlayCheckBox.Size = new System.Drawing.Size(105, 17);
            this.OverlayCheckBox.TabIndex = 1;
            this.OverlayCheckBox.Text = "Graphics overlay";
            this.OverlayCheckBox.UseVisualStyleBackColor = true;
            // 
            // EquationTextBox
            // 
            this.EquationTextBox.Location = new System.Drawing.Point(51, 406);
            this.EquationTextBox.Name = "EquationTextBox";
            this.EquationTextBox.Size = new System.Drawing.Size(469, 20);
            this.EquationTextBox.TabIndex = 2;
            // 
            // BuildButton
            // 
            this.BuildButton.Location = new System.Drawing.Point(11, 455);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(509, 30);
            this.BuildButton.TabIndex = 3;
            this.BuildButton.Text = "Build!";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "f(x) = ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 498);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BuildButton);
            this.Controls.Add(this.EquationTextBox);
            this.Controls.Add(this.OverlayCheckBox);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Курсовая №3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox OverlayCheckBox;
        private System.Windows.Forms.TextBox EquationTextBox;
        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.Label label1;
    }
}

