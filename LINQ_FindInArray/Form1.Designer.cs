namespace LINQ_FindInArray
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
            this.textBox_InputText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_Contain = new System.Windows.Forms.RadioButton();
            this.radioButton_Equals = new System.Windows.Forms.RadioButton();
            this.label_Results = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_InputText
            // 
            this.textBox_InputText.Location = new System.Drawing.Point(72, 25);
            this.textBox_InputText.Name = "textBox_InputText";
            this.textBox_InputText.Size = new System.Drawing.Size(100, 20);
            this.textBox_InputText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text";
            // 
            // radioButton_Contain
            // 
            this.radioButton_Contain.AutoSize = true;
            this.radioButton_Contain.Location = new System.Drawing.Point(26, 76);
            this.radioButton_Contain.Name = "radioButton_Contain";
            this.radioButton_Contain.Size = new System.Drawing.Size(61, 17);
            this.radioButton_Contain.TabIndex = 2;
            this.radioButton_Contain.TabStop = true;
            this.radioButton_Contain.Text = "Contain";
            this.radioButton_Contain.UseVisualStyleBackColor = true;
            // 
            // radioButton_Equals
            // 
            this.radioButton_Equals.AutoSize = true;
            this.radioButton_Equals.Location = new System.Drawing.Point(26, 111);
            this.radioButton_Equals.Name = "radioButton_Equals";
            this.radioButton_Equals.Size = new System.Drawing.Size(57, 17);
            this.radioButton_Equals.TabIndex = 3;
            this.radioButton_Equals.TabStop = true;
            this.radioButton_Equals.Text = "Equals";
            this.radioButton_Equals.UseMnemonic = false;
            this.radioButton_Equals.UseVisualStyleBackColor = true;
            // 
            // label_Results
            // 
            this.label_Results.Location = new System.Drawing.Point(23, 169);
            this.label_Results.Name = "label_Results";
            this.label_Results.Size = new System.Drawing.Size(275, 157);
            this.label_Results.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Results:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 395);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Results);
            this.Controls.Add(this.radioButton_Equals);
            this.Controls.Add(this.radioButton_Contain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_InputText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_InputText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_Contain;
        private System.Windows.Forms.RadioButton radioButton_Equals;
        private System.Windows.Forms.Label label_Results;
        private System.Windows.Forms.Label label2;
    }
}

