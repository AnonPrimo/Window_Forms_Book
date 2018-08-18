namespace B032_Budilnik
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.label_Time_F2 = new System.Windows.Forms.Label();
            this.label_Text_F2 = new System.Windows.Forms.Label();
            this.button_Ok_F2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Time_F2
            // 
            this.label_Time_F2.AutoSize = true;
            this.label_Time_F2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Time_F2.Location = new System.Drawing.Point(98, 46);
            this.label_Time_F2.Name = "label_Time_F2";
            this.label_Time_F2.Size = new System.Drawing.Size(47, 14);
            this.label_Time_F2.TabIndex = 0;
            this.label_Time_F2.Text = "00 : 00";
            this.label_Time_F2.UseMnemonic = false;
            // 
            // label_Text_F2
            // 
            this.label_Text_F2.AutoSize = true;
            this.label_Text_F2.Location = new System.Drawing.Point(63, 81);
            this.label_Text_F2.Name = "label_Text_F2";
            this.label_Text_F2.Size = new System.Drawing.Size(110, 13);
            this.label_Text_F2.TabIndex = 1;
            this.label_Text_F2.Text = "Текст повідомлення";
            // 
            // button_Ok_F2
            // 
            this.button_Ok_F2.Location = new System.Drawing.Point(83, 126);
            this.button_Ok_F2.Name = "button_Ok_F2";
            this.button_Ok_F2.Size = new System.Drawing.Size(75, 23);
            this.button_Ok_F2.TabIndex = 2;
            this.button_Ok_F2.Text = "Ok";
            this.button_Ok_F2.UseVisualStyleBackColor = true;
            this.button_Ok_F2.Click += new System.EventHandler(this.button_Ok_F2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(262, 168);
            this.Controls.Add(this.button_Ok_F2);
            this.Controls.Add(this.label_Text_F2);
            this.Controls.Add(this.label_Time_F2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_Time_F2;
        public System.Windows.Forms.Label label_Text_F2;
        public System.Windows.Forms.Button button_Ok_F2;
    }
}