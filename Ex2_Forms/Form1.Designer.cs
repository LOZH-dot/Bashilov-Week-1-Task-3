namespace Ex2_Forms
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
            this.ResultTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.EndNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.StepNumeric = new System.Windows.Forms.NumericUpDown();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StartNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(12, 12);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(293, 426);
            this.ResultTextBox.TabIndex = 0;
            this.ResultTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(311, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите начальное значение интервала:";
            // 
            // StartNumeric
            // 
            this.StartNumeric.DecimalPlaces = 2;
            this.StartNumeric.Location = new System.Drawing.Point(598, 39);
            this.StartNumeric.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.StartNumeric.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.StartNumeric.Name = "StartNumeric";
            this.StartNumeric.Size = new System.Drawing.Size(120, 20);
            this.StartNumeric.TabIndex = 2;
            this.StartNumeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(311, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите конечное значение интервала:";
            // 
            // EndNumeric
            // 
            this.EndNumeric.DecimalPlaces = 2;
            this.EndNumeric.Location = new System.Drawing.Point(598, 86);
            this.EndNumeric.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.EndNumeric.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.EndNumeric.Name = "EndNumeric";
            this.EndNumeric.Size = new System.Drawing.Size(120, 20);
            this.EndNumeric.TabIndex = 4;
            this.EndNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(311, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите шаг функции:";
            // 
            // StepNumeric
            // 
            this.StepNumeric.DecimalPlaces = 2;
            this.StepNumeric.Location = new System.Drawing.Point(472, 127);
            this.StepNumeric.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.StepNumeric.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.StepNumeric.Name = "StepNumeric";
            this.StepNumeric.Size = new System.Drawing.Size(120, 20);
            this.StepNumeric.TabIndex = 6;
            this.StepNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(493, 173);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(138, 39);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Вычислить значение функции";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ex2_Forms.Properties.Resources.ex_graph;
            this.pictureBox1.Location = new System.Drawing.Point(445, 288);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 150);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(490, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Задание 2. Вариант 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.StepNumeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EndNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartNumeric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.StartNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ResultTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown StartNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown EndNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown StepNumeric;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

