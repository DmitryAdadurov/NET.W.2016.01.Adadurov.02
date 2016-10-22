namespace Task5.GUI
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
            this.groupBoxArrayCreate = new System.Windows.Forms.GroupBox();
            this.buttonCreateArray = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxArraySize = new System.Windows.Forms.TextBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.richTextBoxResults = new System.Windows.Forms.RichTextBox();
            this.groupBoxOpenFile = new System.Windows.Forms.GroupBox();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.groupBoxArrayCreate.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.groupBoxOpenFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxArrayCreate
            // 
            this.groupBoxArrayCreate.Controls.Add(this.buttonCreateArray);
            this.groupBoxArrayCreate.Controls.Add(this.label1);
            this.groupBoxArrayCreate.Controls.Add(this.textBoxArraySize);
            this.groupBoxArrayCreate.Location = new System.Drawing.Point(12, 12);
            this.groupBoxArrayCreate.Name = "groupBoxArrayCreate";
            this.groupBoxArrayCreate.Size = new System.Drawing.Size(355, 68);
            this.groupBoxArrayCreate.TabIndex = 0;
            this.groupBoxArrayCreate.TabStop = false;
            this.groupBoxArrayCreate.Text = "Создание массива";
            // 
            // buttonCreateArray
            // 
            this.buttonCreateArray.Location = new System.Drawing.Point(274, 29);
            this.buttonCreateArray.Name = "buttonCreateArray";
            this.buttonCreateArray.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateArray.TabIndex = 2;
            this.buttonCreateArray.Text = "Создать";
            this.buttonCreateArray.UseVisualStyleBackColor = true;
            this.buttonCreateArray.Click += new System.EventHandler(this.buttonCreateArray_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество элементов";
            // 
            // textBoxArraySize
            // 
            this.textBoxArraySize.Location = new System.Drawing.Point(137, 31);
            this.textBoxArraySize.MaxLength = 4;
            this.textBoxArraySize.Name = "textBoxArraySize";
            this.textBoxArraySize.Size = new System.Drawing.Size(100, 20);
            this.textBoxArraySize.TabIndex = 0;
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.richTextBoxResults);
            this.groupBoxResult.Location = new System.Drawing.Point(12, 169);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(355, 144);
            this.groupBoxResult.TabIndex = 1;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Результаты";
            // 
            // richTextBoxResults
            // 
            this.richTextBoxResults.Location = new System.Drawing.Point(6, 19);
            this.richTextBoxResults.Name = "richTextBoxResults";
            this.richTextBoxResults.Size = new System.Drawing.Size(343, 119);
            this.richTextBoxResults.TabIndex = 0;
            this.richTextBoxResults.Text = "";
            // 
            // groupBoxOpenFile
            // 
            this.groupBoxOpenFile.Controls.Add(this.labelFilePath);
            this.groupBoxOpenFile.Controls.Add(this.buttonOpenFile);
            this.groupBoxOpenFile.Location = new System.Drawing.Point(12, 86);
            this.groupBoxOpenFile.Name = "groupBoxOpenFile";
            this.groupBoxOpenFile.Size = new System.Drawing.Size(355, 77);
            this.groupBoxOpenFile.TabIndex = 4;
            this.groupBoxOpenFile.TabStop = false;
            this.groupBoxOpenFile.Text = "Загрузить массив из файла";
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Location = new System.Drawing.Point(16, 37);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(10, 13);
            this.labelFilePath.TabIndex = 1;
            this.labelFilePath.Text = " ";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(274, 32);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "Открыть";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 325);
            this.Controls.Add(this.groupBoxOpenFile);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxArrayCreate);
            this.Name = "FormMain";
            this.Text = "Task 5";
            this.groupBoxArrayCreate.ResumeLayout(false);
            this.groupBoxArrayCreate.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxOpenFile.ResumeLayout(false);
            this.groupBoxOpenFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxArrayCreate;
        private System.Windows.Forms.TextBox textBoxArraySize;
        private System.Windows.Forms.Button buttonCreateArray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.GroupBox groupBoxOpenFile;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.RichTextBox richTextBoxResults;
    }
}

