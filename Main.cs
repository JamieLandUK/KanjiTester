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
        bool JP_LANG = false;

        int CURRENT_RANDOM;
        List<int> PREVIOUS_RANDOM = new List<int>();
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
            PREVIOUS_RANDOM.Add(CURRENT_RANDOM);
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
                if (!PREVIOUS_RANDOM.Contains(CURRENT_RANDOM))
                {
                    PREVIOUS_RANDOM.Add(CURRENT_RANDOM);
                    break;
                }
                // If the list already has more than 2/3rds of the total amount of kanji
                else if (PREVIOUS_RANDOM.Count > (kanji.Count / 3 * 2))
                {
                    // Reset the list.
                    PREVIOUS_RANDOM.Clear();
                }
            }

            UpdateKanji(kanji[CURRENT_RANDOM]);
        }

        private void btnLang_Click(object sender, EventArgs e)
        {
            if (JP_LANG)
            {
                JP_LANG = false;

                btnLang.Text = "日本語";
                btnNext.Text = "Next";
                btnJisho.Text = "See on Jisho.org!";
                btnReveal.Text = "Reveal";
                btnAddKanji.Text = "Add kanji";

                lblMeaning.Text = "Meaning:";
                lblMeaning.Location = new Point(10, 68);
                lblReadings.Text = "Readings";
                lblReadings.Location = new Point(63, 111);
                lblKunyomi.Text = "Kun'yomi:";
                lblKunyomi.Location = new Point(6, 145);
                lblOnyomi.Text = "On'yomi:";
                lblOnyomi.Location = new Point(12, 177);
            }
            else
            {
                JP_LANG = true;

                btnLang.Text = "English";
                btnNext.Text = "次へ";
                btnJisho.Text = "JISHOで見る";
                btnReveal.Text = "漏らす";
                btnAddKanji.Text = "漢字を加える";

                lblMeaning.Text = "意味：";
                lblMeaning.Location = new Point(31, 68);
                lblReadings.Text = "読み方";
                lblReadings.Location = new Point(69, 111);
                lblKunyomi.Text = "訓読み：";
                lblKunyomi.Location = new Point(18, 145);
                lblOnyomi.Text = "音読み：";
                lblOnyomi.Location = new Point(18, 177);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
