namespace task_2._16_WF
{
    partial class GetAnswer
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
            this.outSizeOfArr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.outAnswr = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размер массива";
            // 
            // outSizeOfArr
            // 
            this.outSizeOfArr.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outSizeOfArr.Location = new System.Drawing.Point(16, 36);
            this.outSizeOfArr.Multiline = true;
            this.outSizeOfArr.Name = "outSizeOfArr";
            this.outSizeOfArr.Size = new System.Drawing.Size(148, 30);
            this.outSizeOfArr.TabIndex = 1;
            this.outSizeOfArr.TextChanged += new System.EventHandler(this.outSizeOfArr_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(193, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ответ";
            // 
            // outAnswr
            // 
            this.outAnswr.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outAnswr.Location = new System.Drawing.Point(197, 36);
            this.outAnswr.Name = "outAnswr";
            this.outAnswr.Size = new System.Drawing.Size(57, 30);
            this.outAnswr.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(16, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Get Answer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GetAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 111);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outAnswr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outSizeOfArr);
            this.Controls.Add(this.label1);
            this.Name = "GetAnswer";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outSizeOfArr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outAnswr;
        private System.Windows.Forms.Button button1;
    }
}

