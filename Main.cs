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

namespace KanjiTester
{
    public partial class Main : Form
    {
        int CURRENT_RANDOM;
        int PREVIOUS_RANDOM;
        List<Kanji> kanji = new List<Kanji>();

        public Main()
        {
            InitializeComponent();
        }

        private void UpdateKanji(Kanji chosen)
        {
            lblKanji.Text = Convert.ToString(chosen.GetKanji());
            txbMeaning.Text = chosen.GetMeaning();
            txbKun.Text = chosen.GetKunyomi();
            txbOn.Text = chosen.GetOnyomi();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                using (StreamReader reader = new StreamReader(@"Kanji.txt"))
                {
                    var test1 = reader.ReadLine();
                    var test2 = test1.Split(',');
                    if (test2[0] != "Kanji")
                    {
                        Console.WriteLine("The .csv file is incorrect.");
                        Environment.Exit(1);
                    }

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        if (values[0] == "Kanji")
                        {
                            continue;
                        }
                        else
                        {
                            kanji.Add(new Kanji(
                                Convert.ToChar(values[0]),
                                values[1],
                                values[2],
                                values[3]
                                ));
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Kanji.csv has not been found.");
                Environment.Exit(1);
            }

            Random rn = new Random();
            CURRENT_RANDOM = rn.Next(0, kanji.Count);
            PREVIOUS_RANDOM = CURRENT_RANDOM;
            Kanji chosen = kanji[CURRENT_RANDOM];
            UpdateKanji(chosen);
            
        }

        private void btnReveal_Click(object sender, EventArgs e)
        {
            lblKanji.Visible = true;
            btnReveal.Enabled = false;
            btnJisho.Enabled = true;
        }

        private void btnJisho_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://jisho.org/search/" + Convert.ToString(kanji[CURRENT_RANDOM].GetKanji()) + "%20%23kanji");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            lblKanji.Visible = false;
            btnReveal.Enabled = true;
            btnJisho.Enabled = false;

            Random rn = new Random();

            while (true)
            {
                CURRENT_RANDOM = rn.Next(0, kanji.Count);
                if (CURRENT_RANDOM != PREVIOUS_RANDOM)
                {
                    PREVIOUS_RANDOM = CURRENT_RANDOM;
                    break;
                }
            }

            UpdateKanji(kanji[CURRENT_RANDOM]);
        }

        private void btnLang_Click(object sender, EventArgs e)
        {

        }
    }
}
