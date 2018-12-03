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

    public partial class Addkanji : Form
    {
        public Addkanji()
        {
            InitializeComponent();

            this.FormClosing += Addkanji_FormClosing;
        }

        private void Addkanji_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
        }

        private void btnLang_Click(object sender, EventArgs e)
        {
            if (MainForm.JP_LANG)
            {
                MainForm.JP_LANG = false;

                btnLang.Text = "日本語";
                btnAdd.Text = "Add to list";

                lblKanji.Text = "Kanji:";
                lblKanji.Location = new Point(47, 68);
                lblMeaning.Text = "Meaning:";
                lblMeaning.Location = new Point(26, 98);
                lblReadings.Text = "Readings";
                lblReadings.Location = new Point(59, 147);
                lblKunyomi.Text = "Kun'yomi:";
                lblKunyomi.Location = new Point(19, 182);
                lblOnyomi.Text = "On'yomi:";
                lblOnyomi.Location = new Point(26, 215);
            }
            else
            {
                MainForm.JP_LANG = true;

                btnLang.Text = "English";
                btnAdd.Text = "加える";

                lblKanji.Text = "漢字：";
                lblKanji.Location = new Point(47, 68);
                lblMeaning.Text = "意味：";
                lblMeaning.Location = new Point(47, 100);
                lblReadings.Text = "読み方";
                lblReadings.Location = new Point(66, 147);
                lblKunyomi.Text = "訓読み：";
                lblKunyomi.Location = new Point(34, 183);
                lblOnyomi.Text = "音読み：";
                lblOnyomi.Location = new Point(34, 215);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(@"Kanji.txt", true, Encoding.Unicode))
            {
                writer.WriteLine("{0},{1},{2},{3}",
                    txbKanji.Text, txbMeaning.Text, txbKunyomi.Text, txbOnyomi.Text);
            }
            // Clear the boxes to show it has been done.
            txbKanji.Clear();
            txbMeaning.Clear();
            txbKunyomi.Clear();
            txbOnyomi.Clear();
        }

        private void txbKanji_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txbKanji.Text) &&
                !String.IsNullOrEmpty(txbMeaning.Text) &&
                (!String.IsNullOrEmpty(txbKunyomi.Text) ||
                !String.IsNullOrEmpty(txbOnyomi.Text))
                )
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void txbMeaning_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txbKanji.Text) &&
                !String.IsNullOrEmpty(txbMeaning.Text) &&
                (!String.IsNullOrEmpty(txbKunyomi.Text) ||
                !String.IsNullOrEmpty(txbOnyomi.Text))
                )
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void txbKunyomi_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txbKanji.Text) &&
                !String.IsNullOrEmpty(txbMeaning.Text) &&
                (!String.IsNullOrEmpty(txbKunyomi.Text) ||
                !String.IsNullOrEmpty(txbOnyomi.Text))
                )
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void txbOnyomi_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txbKanji.Text) &&
                !String.IsNullOrEmpty(txbMeaning.Text) &&
                (!String.IsNullOrEmpty(txbKunyomi.Text) ||
                !String.IsNullOrEmpty(txbOnyomi.Text))
                )
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        void Addkanji_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.NUM_FORMS_OPEN--;
        }
    }
}
