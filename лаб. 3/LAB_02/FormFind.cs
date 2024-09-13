using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Xml.Serialization;
using System.Security.Principal;
using System.Reflection;

using System.Text.Json;


namespace LAB_02
{
    public partial class FormFind : Form
    {
        List<computer> computerList = new List<computer>();
        List<computer> Computers = new List<computer>();
        List<computer> Searched = new List<computer>();


        public FormFind(List<computer> computers)
        {
            InitializeComponent();
            computerList = computers;
            Computers = computers;
            panel1.Hide();
            /*listBox1.Items.AddRange(computers.ToArray());*/
            foreach (computer comp in computers)
            {
                listBox1.Items.Add(comp.ToString());
            }
        }

        private void Seriolaaze()
        {
            try
            {
                List<string> textList = new List<string>();

                foreach (var item in listBox1.Items)
                {
                    if (item is string text)
                    {
                        textList.Add(text);
                    }
                }
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                string json = JsonSerializer.Serialize(textList, options);
                File.WriteAllText("Searched.json", json);
               
                MessageBox.Show("Данные успешно сохранены!", "Успех!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            menuStrip1.Hide();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            menuStrip1.Show();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                listBox1.SelectedIndex = 0;
                return;
            }

            if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
            {
                listBox1.SelectedIndex++;
            }
        }

        private void впередToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                listBox1.SelectedIndex = 0;
                return;
            }

            if (listBox1.SelectedIndex > 0)
            {
                listBox1.SelectedIndex--;
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                computerList.RemoveAt(listBox1.SelectedIndex);

                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void частотаРаботыПроцессораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<computer> sortedAccounts = computerList.OrderBy(account => account.inprocessor.chastota).ToList();

            foreach (computer account in sortedAccounts)
            {
                listBox1.Items.Add(account.ToString());
            }
        }

        private void размерOZYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<computer> sortedAccounts = computerList.OrderBy(account => account.sizeozy).ToList();

            foreach (computer account in sortedAccounts)
            {
                listBox1.Items.Add(account.ToString());
            }
        }

        private void конструкторПоискаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void поПроизводителюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string searchPattern = searchTextBox.Text;

            listBox1.Items.Clear();

            List<computer> searchedAccounts = computerList.Where(account => Regex.IsMatch(account.inprocessor.proizvoditel, $@"{searchPattern}\w*", RegexOptions.IgnoreCase)).ToList();
            foreach (computer account in searchedAccounts)
            {
                listBox1.Items.Add(account.ToString());
            }
        }

        private void поМоделиПроцессораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string searchPattern = searchTextBox.Text;

            listBox1.Items.Clear();

            List<computer> searchedAccounts = computerList.Where(account => Regex.IsMatch(account.inprocessor.model, $@"{searchPattern}\w*", RegexOptions.IgnoreCase)).ToList();
            foreach (computer account in searchedAccounts)
            {
                listBox1.Items.Add(account.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string searchPatternPr = proizv_text.Text;
            string searchPatternM = model_text.Text;

            listBox1.Items.Clear();

            List<computer> searchedAccounts = computerList.Where(account =>
                Regex.IsMatch(account.inprocessor.proizvoditel, $@"^{searchPatternPr}", RegexOptions.IgnoreCase) &&
                Regex.IsMatch(account.inprocessor.model, $@"^{searchPatternM}", RegexOptions.IgnoreCase)
             ).ToList();

            foreach (computer account in searchedAccounts)
            {
                listBox1.Items.Add(account.ToString());
            }
        }

        private void skrit_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void save_rez_Click(object sender, EventArgs e)
        {
            Seriolaaze();
            Seriolaze();
        }



        private void Seriolaze()
        {
            try
            {
                foreach (var item in listBox1.Items)
                {
                    if (item is computer account)
                    {
                        Searched.Add(account);
                    }
                }
                using (FileStream fs = new FileStream("Searched.xml", FileMode.Create))
                {
                    XmlSerializer xml = new XmlSerializer(Searched.GetType());
                    xml.Serialize(fs, Searched);
                }
                MessageBox.Show("Данные успешно сохранены!", "Успех!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }

    }
}
