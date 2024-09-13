namespace LAB_02
{
    partial class FormFind
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
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.частотаРаботыПроцессораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.впередToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.proizv_text = new System.Windows.Forms.TextBox();
            this.model_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.размерOZYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поПроизводителюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поМоделиПроцессораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.конструкторПоискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skrit = new System.Windows.Forms.Button();
            this.save_rez = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem,
            this.сортироватьToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.впередToolStripMenuItem,
            this.назадToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(767, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поПроизводителюToolStripMenuItem,
            this.поМоделиПроцессораToolStripMenuItem,
            this.конструкторПоискаToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // сортироватьToolStripMenuItem
            // 
            this.сортироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.частотаРаботыПроцессораToolStripMenuItem,
            this.размерOZYToolStripMenuItem});
            this.сортироватьToolStripMenuItem.Name = "сортироватьToolStripMenuItem";
            this.сортироватьToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.сортироватьToolStripMenuItem.Text = "Сортировать";
            // 
            // частотаРаботыПроцессораToolStripMenuItem
            // 
            this.частотаРаботыПроцессораToolStripMenuItem.Name = "частотаРаботыПроцессораToolStripMenuItem";
            this.частотаРаботыПроцессораToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.частотаРаботыПроцессораToolStripMenuItem.Text = "частота работы процессора";
            this.частотаРаботыПроцессораToolStripMenuItem.Click += new System.EventHandler(this.частотаРаботыПроцессораToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // впередToolStripMenuItem
            // 
            this.впередToolStripMenuItem.Name = "впередToolStripMenuItem";
            this.впередToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.впередToolStripMenuItem.Text = "Вперед";
            this.впередToolStripMenuItem.Click += new System.EventHandler(this.впередToolStripMenuItem_Click);
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(522, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Скрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(649, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Закрепить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.skrit);
            this.panel1.Controls.Add(this.proizv_text);
            this.panel1.Controls.Add(this.model_text);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 127);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // proizv_text
            // 
            this.proizv_text.BackColor = System.Drawing.SystemColors.MenuBar;
            this.proizv_text.Location = new System.Drawing.Point(15, 34);
            this.proizv_text.Name = "proizv_text";
            this.proizv_text.Size = new System.Drawing.Size(173, 22);
            this.proizv_text.TabIndex = 4;
            // 
            // model_text
            // 
            this.model_text.BackColor = System.Drawing.SystemColors.MenuBar;
            this.model_text.Location = new System.Drawing.Point(15, 91);
            this.model_text.Name = "model_text";
            this.model_text.Size = new System.Drawing.Size(173, 22);
            this.model_text.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "производитель";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "модель процессора";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(210, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 37);
            this.button3.TabIndex = 0;
            this.button3.Text = "Найти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Данные для поиска";
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.searchTextBox.Location = new System.Drawing.Point(12, 455);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(173, 22);
            this.searchTextBox.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 205);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(476, 212);
            this.listBox1.TabIndex = 6;
            // 
            // размерOZYToolStripMenuItem
            // 
            this.размерOZYToolStripMenuItem.Name = "размерOZYToolStripMenuItem";
            this.размерOZYToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.размерOZYToolStripMenuItem.Text = "размер OZY";
            this.размерOZYToolStripMenuItem.Click += new System.EventHandler(this.размерOZYToolStripMenuItem_Click);
            // 
            // поПроизводителюToolStripMenuItem
            // 
            this.поПроизводителюToolStripMenuItem.Name = "поПроизводителюToolStripMenuItem";
            this.поПроизводителюToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.поПроизводителюToolStripMenuItem.Text = "по производителю";
            this.поПроизводителюToolStripMenuItem.Click += new System.EventHandler(this.поПроизводителюToolStripMenuItem_Click);
            // 
            // поМоделиПроцессораToolStripMenuItem
            // 
            this.поМоделиПроцессораToolStripMenuItem.Name = "поМоделиПроцессораToolStripMenuItem";
            this.поМоделиПроцессораToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.поМоделиПроцессораToolStripMenuItem.Text = "по модели процессора";
            this.поМоделиПроцессораToolStripMenuItem.Click += new System.EventHandler(this.поМоделиПроцессораToolStripMenuItem_Click);
            // 
            // конструкторПоискаToolStripMenuItem
            // 
            this.конструкторПоискаToolStripMenuItem.Name = "конструкторПоискаToolStripMenuItem";
            this.конструкторПоискаToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.конструкторПоискаToolStripMenuItem.Text = "конструктор поиска";
            this.конструкторПоискаToolStripMenuItem.Click += new System.EventHandler(this.конструкторПоискаToolStripMenuItem_Click);
            // 
            // skrit
            // 
            this.skrit.Location = new System.Drawing.Point(210, 76);
            this.skrit.Name = "skrit";
            this.skrit.Size = new System.Drawing.Size(85, 37);
            this.skrit.TabIndex = 5;
            this.skrit.Text = "Скрыть";
            this.skrit.UseVisualStyleBackColor = true;
            this.skrit.Click += new System.EventHandler(this.skrit_Click);
            // 
            // save_rez
            // 
            this.save_rez.Location = new System.Drawing.Point(279, 440);
            this.save_rez.Name = "save_rez";
            this.save_rez.Size = new System.Drawing.Size(209, 37);
            this.save_rez.TabIndex = 6;
            this.save_rez.Text = "сохранить результаты";
            this.save_rez.UseVisualStyleBackColor = true;
            this.save_rez.Click += new System.EventHandler(this.save_rez_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "производитель -  модель - частота - размер OZY";
            // 
            // FormFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 498);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.save_rez);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormFind";
            this.Text = "FormFind";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem впередToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox proizv_text;
        private System.Windows.Forms.TextBox model_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem частотаРаботыПроцессораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерOZYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поПроизводителюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поМоделиПроцессораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem конструкторПоискаToolStripMenuItem;
        private System.Windows.Forms.Button skrit;
        private System.Windows.Forms.Button save_rez;
        private System.Windows.Forms.Label label5;
    }
}