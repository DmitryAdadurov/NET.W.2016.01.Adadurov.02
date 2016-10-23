namespace Task6.GUI
{
    partial class FormMain
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
            this.textBoxStringA = new System.Windows.Forms.TextBox();
            this.textBoxStringB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxStringResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxStringA
            // 
            this.textBoxStringA.Location = new System.Drawing.Point(31, 31);
            this.textBoxStringA.Name = "textBoxStringA";
            this.textBoxStringA.Size = new System.Drawing.Size(227, 20);
            this.textBoxStringA.TabIndex = 0;
            // 
            // textBoxStringB
            // 
            this.textBoxStringB.Location = new System.Drawing.Point(31, 78);
            this.textBoxStringB.Name = "textBoxStringB";
            this.textBoxStringB.Size = new System.Drawing.Size(227, 20);
            this.textBoxStringB.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Новая строка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxStringResult
            // 
            this.textBoxStringResult.Location = new System.Drawing.Point(31, 185);
            this.textBoxStringResult.Name = "textBoxStringResult";
            this.textBoxStringResult.Size = new System.Drawing.Size(227, 20);
            this.textBoxStringResult.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "String a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "String b";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStringResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxStringB);
            this.Controls.Add(this.textBoxStringA);
            this.Name = "FormMain";
            this.Text = "Task 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStringA;
        private System.Windows.Forms.TextBox textBoxStringB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxStringResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

