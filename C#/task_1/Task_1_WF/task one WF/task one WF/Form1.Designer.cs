namespace task_one_WF
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
            this.textBoxForX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxForN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxForEps = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCalcSerSum = new System.Windows.Forms.Button();
            this.buttonCalcSerEps = new System.Windows.Forms.Button();
            this.textBoxOutEps = new System.Windows.Forms.TextBox();
            this.textBoxOutSum = new System.Windows.Forms.TextBox();
            this.textBoxToComp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxForX
            // 
            this.textBoxForX.Location = new System.Drawing.Point(113, 20);
            this.textBoxForX.Name = "textBoxForX";
            this.textBoxForX.Size = new System.Drawing.Size(100, 20);
            this.textBoxForX.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter n";
            // 
            // textBoxForN
            // 
            this.textBoxForN.Location = new System.Drawing.Point(113, 55);
            this.textBoxForN.Name = "textBoxForN";
            this.textBoxForN.Size = new System.Drawing.Size(100, 20);
            this.textBoxForN.TabIndex = 3;
            this.textBoxForN.TextChanged += new System.EventHandler(this.textBoxForN_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Eps";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxForEps
            // 
            this.textBoxForEps.Location = new System.Drawing.Point(113, 89);
            this.textBoxForEps.Name = "textBoxForEps";
            this.textBoxForEps.Size = new System.Drawing.Size(100, 20);
            this.textBoxForEps.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxForEps);
            this.groupBox1.Controls.Add(this.textBoxForX);
            this.groupBox1.Controls.Add(this.textBoxForN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 122);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // buttonCalcSerSum
            // 
            this.buttonCalcSerSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalcSerSum.Location = new System.Drawing.Point(10, 221);
            this.buttonCalcSerSum.Name = "buttonCalcSerSum";
            this.buttonCalcSerSum.Size = new System.Drawing.Size(226, 41);
            this.buttonCalcSerSum.TabIndex = 7;
            this.buttonCalcSerSum.Text = "Задание 2";
            this.buttonCalcSerSum.UseVisualStyleBackColor = true;
            this.buttonCalcSerSum.Click += new System.EventHandler(this.buttonCalcSerSum_Click);
            // 
            // buttonCalcSerEps
            // 
            this.buttonCalcSerEps.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalcSerEps.Location = new System.Drawing.Point(12, 145);
            this.buttonCalcSerEps.Name = "buttonCalcSerEps";
            this.buttonCalcSerEps.Size = new System.Drawing.Size(226, 41);
            this.buttonCalcSerEps.TabIndex = 8;
            this.buttonCalcSerEps.Text = "Задание 1";
            this.buttonCalcSerEps.UseVisualStyleBackColor = true;
            this.buttonCalcSerEps.Click += new System.EventHandler(this.buttonCalcSerEps_Click);
            // 
            // textBoxOutEps
            // 
            this.textBoxOutEps.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOutEps.Location = new System.Drawing.Point(242, 145);
            this.textBoxOutEps.Multiline = true;
            this.textBoxOutEps.Name = "textBoxOutEps";
            this.textBoxOutEps.Size = new System.Drawing.Size(270, 61);
            this.textBoxOutEps.TabIndex = 9;
            this.textBoxOutEps.TextChanged += new System.EventHandler(this.textBoxOutEps_TextChanged);
            // 
            // textBoxOutSum
            // 
            this.textBoxOutSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOutSum.Location = new System.Drawing.Point(242, 221);
            this.textBoxOutSum.Multiline = true;
            this.textBoxOutSum.Name = "textBoxOutSum";
            this.textBoxOutSum.Size = new System.Drawing.Size(272, 64);
            this.textBoxOutSum.TabIndex = 10;
            this.textBoxOutSum.TextChanged += new System.EventHandler(this.textBoxOutSum_TextChanged);
            // 
            // textBoxToComp
            // 
            this.textBoxToComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxToComp.Location = new System.Drawing.Point(244, 58);
            this.textBoxToComp.Name = "textBoxToComp";
            this.textBoxToComp.Size = new System.Drawing.Size(272, 29);
            this.textBoxToComp.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(244, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Compare with:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 296);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxToComp);
            this.Controls.Add(this.textBoxOutSum);
            this.Controls.Add(this.textBoxOutEps);
            this.Controls.Add(this.buttonCalcSerEps);
            this.Controls.Add(this.buttonCalcSerSum);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxForX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxForN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxForEps;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCalcSerSum;
        private System.Windows.Forms.Button buttonCalcSerEps;
        private System.Windows.Forms.TextBox textBoxOutEps;
        private System.Windows.Forms.TextBox textBoxOutSum;
        private System.Windows.Forms.TextBox textBoxToComp;
        private System.Windows.Forms.Label label4;
    }
}

