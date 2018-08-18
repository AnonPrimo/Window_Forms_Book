namespace B032_Budilnik
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label_TimeNow = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Mess = new System.Windows.Forms.TextBox();
            this.checkBox_OnOff = new System.Windows.Forms.CheckBox();
            this.button_Safe = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.numericUpDown_Hours = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Min = new System.Windows.Forms.NumericUpDown();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Hours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Min)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Зараз";
            // 
            // label_TimeNow
            // 
            this.label_TimeNow.AutoSize = true;
            this.label_TimeNow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TimeNow.Location = new System.Drawing.Point(95, 42);
            this.label_TimeNow.Name = "label_TimeNow";
            this.label_TimeNow.Size = new System.Drawing.Size(47, 14);
            this.label_TimeNow.TabIndex = 1;
            this.label_TimeNow.Text = "00 : 00";
            this.label_TimeNow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сигнал";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Години";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Хвилини";
            // 
            // textBox_Mess
            // 
            this.textBox_Mess.Location = new System.Drawing.Point(38, 143);
            this.textBox_Mess.Name = "textBox_Mess";
            this.textBox_Mess.Size = new System.Drawing.Size(259, 20);
            this.textBox_Mess.TabIndex = 7;
            // 
            // checkBox_OnOff
            // 
            this.checkBox_OnOff.AutoSize = true;
            this.checkBox_OnOff.Location = new System.Drawing.Point(38, 186);
            this.checkBox_OnOff.Name = "checkBox_OnOff";
            this.checkBox_OnOff.Size = new System.Drawing.Size(81, 17);
            this.checkBox_OnOff.TabIndex = 8;
            this.checkBox_OnOff.Text = "Вкл.\\Викл.";
            this.checkBox_OnOff.UseVisualStyleBackColor = true;
            this.checkBox_OnOff.CheckedChanged += new System.EventHandler(this.checkBox_OnOff_CheckedChanged);
            // 
            // button_Safe
            // 
            this.button_Safe.Location = new System.Drawing.Point(38, 233);
            this.button_Safe.Name = "button_Safe";
            this.button_Safe.Size = new System.Drawing.Size(75, 23);
            this.button_Safe.TabIndex = 9;
            this.button_Safe.Text = "Зберегти";
            this.button_Safe.UseVisualStyleBackColor = true;
            this.button_Safe.Click += new System.EventHandler(this.button_Safe_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 92);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // numericUpDown_Hours
            // 
            this.numericUpDown_Hours.Location = new System.Drawing.Point(38, 107);
            this.numericUpDown_Hours.Name = "numericUpDown_Hours";
            this.numericUpDown_Hours.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown_Hours.TabIndex = 11;
            // 
            // numericUpDown_Min
            // 
            this.numericUpDown_Min.Location = new System.Drawing.Point(181, 107);
            this.numericUpDown_Min.Name = "numericUpDown_Min";
            this.numericUpDown_Min.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDown_Min.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown_Min.TabIndex = 12;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem1.Text = "Показати";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem2.Text = "Про програму";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem3.Text = "Завершити";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 287);
            this.Controls.Add(this.numericUpDown_Min);
            this.Controls.Add(this.numericUpDown_Hours);
            this.Controls.Add(this.button_Safe);
            this.Controls.Add(this.checkBox_OnOff);
            this.Controls.Add(this.textBox_Mess);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_TimeNow);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Hours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_TimeNow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Mess;
        private System.Windows.Forms.CheckBox checkBox_OnOff;
        private System.Windows.Forms.Button button_Safe;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Hours;
        private System.Windows.Forms.NumericUpDown numericUpDown_Min;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}

