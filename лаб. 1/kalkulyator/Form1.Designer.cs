namespace kalkulyator
{
    partial class Calculator
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
            this.Fnumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Snumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Flist = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Slist = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "введите первое число";
            // 
            // Fnumber
            // 
            this.Fnumber.Location = new System.Drawing.Point(59, 48);
            this.Fnumber.Name = "Fnumber";
            this.Fnumber.Size = new System.Drawing.Size(153, 22);
            this.Fnumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "введите второе число";
            // 
            // Snumber
            // 
            this.Snumber.Location = new System.Drawing.Point(381, 48);
            this.Snumber.Name = "Snumber";
            this.Snumber.Size = new System.Drawing.Size(152, 22);
            this.Snumber.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "выберите операцию";
            // 
            // Flist
            // 
            this.Flist.FormattingEnabled = true;
            this.Flist.Items.AddRange(new object[] {
            "и",
            "или",
            "искл или",
            "не"});
            this.Flist.Location = new System.Drawing.Point(218, 115);
            this.Flist.Name = "Flist";
            this.Flist.Size = new System.Drawing.Size(157, 24);
            this.Flist.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(101, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "посчитать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Send_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LavenderBlush;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(381, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 25);
            this.button2.TabIndex = 7;
            this.button2.Text = "очистить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Clean_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(218, 272);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(157, 22);
            this.Result.TabIndex = 8;
            this.Result.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "результат";
            // 
            // Slist
            // 
            this.Slist.AutoCompleteCustomSource.AddRange(new string[] {
            "двоичная",
            "десятичная",
            "восьмеричная",
            "шестнадцатеричная"});
            this.Slist.FormattingEnabled = true;
            this.Slist.Items.AddRange(new object[] {
            "двоичная",
            "восьмеричная",
            "десятичная",
            "шестнадцатеричная"});
            this.Slist.Location = new System.Drawing.Point(218, 177);
            this.Slist.Name = "Slist";
            this.Slist.Size = new System.Drawing.Size(157, 24);
            this.Slist.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "выберите сис. счисл";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Slist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Flist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Snumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Fnumber);
            this.Controls.Add(this.label1);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Fnumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Snumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Flist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Slist;
        private System.Windows.Forms.Label label5;
    }
}

