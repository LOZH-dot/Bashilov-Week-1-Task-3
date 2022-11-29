namespace Ex1_Forms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.XNumeric = new System.Windows.Forms.NumericUpDown();
            this.YNumeric = new System.Windows.Forms.NumericUpDown();
            this.ZNumeric = new System.Windows.Forms.NumericUpDown();
            this.VNumeric = new System.Windows.Forms.NumericUpDown();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.XNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Число X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Число Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Число Z:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(23, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Число V:";
            // 
            // XNumeric
            // 
            this.XNumeric.DecimalPlaces = 2;
            this.XNumeric.Location = new System.Drawing.Point(90, 25);
            this.XNumeric.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.XNumeric.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.XNumeric.Name = "XNumeric";
            this.XNumeric.Size = new System.Drawing.Size(120, 20);
            this.XNumeric.TabIndex = 4;
            // 
            // YNumeric
            // 
            this.YNumeric.DecimalPlaces = 2;
            this.YNumeric.Location = new System.Drawing.Point(90, 75);
            this.YNumeric.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.YNumeric.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.YNumeric.Name = "YNumeric";
            this.YNumeric.Size = new System.Drawing.Size(120, 20);
            this.YNumeric.TabIndex = 5;
            // 
            // ZNumeric
            // 
            this.ZNumeric.DecimalPlaces = 2;
            this.ZNumeric.Location = new System.Drawing.Point(90, 122);
            this.ZNumeric.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.ZNumeric.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.ZNumeric.Name = "ZNumeric";
            this.ZNumeric.Size = new System.Drawing.Size(120, 20);
            this.ZNumeric.TabIndex = 6;
            // 
            // VNumeric
            // 
            this.VNumeric.DecimalPlaces = 2;
            this.VNumeric.Location = new System.Drawing.Point(90, 167);
            this.VNumeric.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.VNumeric.Minimum = new decimal(new int[] {
            99999999,
            0,
            0,
            -2147483648});
            this.VNumeric.Name = "VNumeric";
            this.VNumeric.Size = new System.Drawing.Size(120, 20);
            this.VNumeric.TabIndex = 7;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(49, 215);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(146, 40);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Отобразить минимальное";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Минимальное число:";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minLabel.Location = new System.Drawing.Point(161, 283);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(14, 16);
            this.minLabel.TabIndex = 10;
            this.minLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 349);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.VNumeric);
            this.Controls.Add(this.ZNumeric);
            this.Controls.Add(this.YNumeric);
            this.Controls.Add(this.XNumeric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.XNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown XNumeric;
        private System.Windows.Forms.NumericUpDown YNumeric;
        private System.Windows.Forms.NumericUpDown ZNumeric;
        private System.Windows.Forms.NumericUpDown VNumeric;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label minLabel;
    }
}

