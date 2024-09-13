using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kalkulyator
{
    interface IKalkulator
    {
        void button1_Click(object sender, EventArgs e);
        void button2_Click(object sender, EventArgs e);
        void textBox3_TextChanged(object sender, EventArgs e);

    }
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        public void Send_Click(object sender, EventArgs e)
        {
            try
            {
         

                if (string.IsNullOrEmpty(Fnumber.Text) || (string.IsNullOrEmpty(Snumber.Text)) && (Slist.SelectedIndex == 3))
                {
                    MessageBox.Show("Заполните два текстовых поля!!");
                    return;
                }
                if (Flist.SelectedIndex == -1 || Slist.SelectedIndex == -1)
                {
                    MessageBox.Show("Заполните два поля со списком!!");
                    return;
                }

                int a, b, c;
                a = Convert.ToInt32(Fnumber.Text);

               
                switch (Flist.Text)
                {
                    case "и":
                        Snumber.ReadOnly = false;
                        Snumber.Enabled = true;
                        b = Convert.ToInt32(Snumber.Text);
                        c = a & b;
                        break;
                    case "или":
                        Snumber.ReadOnly = false;
                        Snumber.Enabled = true;
                        b = Convert.ToInt32(Snumber.Text);
                        c = a | b;
                        break;
                    case "искл или":
                        Snumber.ReadOnly = false;
                        Snumber.Enabled = true;
                        b = Convert.ToInt32(Snumber.Text);
                        c = a ^ b;
                        break;
                    case "не":
                        Snumber.ReadOnly = true;
                        Snumber.Enabled = false;
                        c = int.MaxValue - a;
                        break;
                    default:
                        throw new InvalidOperationException("---");
                }


                switch (Slist.Text)
                {
                    case "двоичная":
                        Result.Text = Convert.ToString(c, 2);
                        break;
                    case "восьмеричная":
                        Result.Text = Convert.ToString(c, 8);
                        break;
                    case "десятичная":
                        Result.Text = Convert.ToString(c, 10);
                        break;
                    case "шестнадцатеричная":
                        Result.Text = Convert.ToString(c, 16);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ОШИБКА!! " + ex.Message);
            }
        }
        public void Clean_Click(object sender, EventArgs e)
        {
            Snumber.Visible = true;
            Fnumber.Text = "";
            Snumber.Text = "";
            Result.Text = "";
            Flist.Text = "";
            Slist.Text = "";
            Snumber.ReadOnly = false;
            Snumber.Enabled = true;
        }

        public void Result_TextChanged(object sender, EventArgs e)
        {
            Result.ReadOnly = true;
        }
    }
}