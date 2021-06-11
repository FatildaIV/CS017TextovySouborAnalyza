using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace CS016TextovySouborCteni
{
    public partial class zobrazeniSouboruForm : Form
    {
        public zobrazeniSouboruForm()
        {
            InitializeComponent();
        }

        private void souborNacteniButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader r = new StreamReader(openFileDialog.FileName);
                souborObsahTextBox.Text = r.ReadToEnd();
            }
            pocetSlovLabel.Text = string.Format("Počet slov: {0}", PocetSlov(souborObsahTextBox.Text));
            cetnostSlovListBox.DataSource = CetnostSlov(souborObsahTextBox.Text);
        }

        private void souborNactenPostupneiButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader r = new StreamReader(openFileDialog.FileName);

                // spustit souborNacteniPostupne(r) v novem vlaknu (thread) z hlavniho vlakna
                var t = Task.Run(() => souborNacteniPostupne(r));
                var s = Task.Run(() => statistikaAktualizace());
            }
        }

        private void statistikaAktualizace() {
            while (true)
            {
                Thread.Sleep(1000);
                pocetSlovLabel.Invoke((MethodInvoker)delegate
                {
                    var x = CetnostSlov(souborObsahTextBox.Text);
                    cetnostSlovListBox.DataSource = x;
                    cetnostSlovLabel.Text = string.Format("Četnost slov: (Unikátní slova: {0})", x.Count);
                });
            }
        }

        private  void souborNacteniPostupne(StreamReader r)
        {
            while (!r.EndOfStream && !nacitaniZastavit)             
            {
                // zmenu textboxu musi provest vlakno, ktere jej vytvorilo (hlavni) 
                // pomoci Invoke je toto vlakno pozadano o provedeni prikazu v bloku
                souborObsahTextBox.Invoke((MethodInvoker)delegate   
                {
                    // provede hlavni vlakno
                    souborObsahTextBox.AppendText(r.ReadLine());        
                });
                Thread.Sleep(10);
                pocetSlovLabel.Invoke((MethodInvoker)delegate
                {
                    pocetSlovLabel.Text = string.Format("Počet slov: {0}", PocetSlov(souborObsahTextBox.Text));
                });
            }
            nacitaniZastavit = false;
        }

        private static int PocetSlov(string text) {
            return text.Split(' ', Convert.ToChar(Keys.Enter), Convert.ToChar(10)).Length;
        }

        //funkce vraci slovnik cetnosti slov (napr. "ahoj" => 50, "svete" => 12, ...)
        private static List<KeyValuePair<string, int>> CetnostSlov(string text) 
        {
            //return text.Split(' ', Convert.ToChar(Keys.Enter), Convert.ToChar(10)).Length;
            //return text.Split(' ', Convert.ToChar(Keys.Enter), Convert.ToChar(10)).ToDictionary<int, string>(key => key, value => 0);
            string[] myArray = text.Split(' ', '.', ':', Convert.ToChar(Keys.Enter), Convert.ToChar(10));
            var myList = myArray.GroupBy(x => x.ToLower()).ToDictionary(x => x.Key, x => x.Count()).ToList();
            myList.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
            return myList;
        }

        private bool nacitaniZastavit = false;
        private void nacitaniZastavitButton_Click(object sender, EventArgs e)
        {
            nacitaniZastavit = true;
        }
    }
}
