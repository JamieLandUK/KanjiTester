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
                //
            }
            else
            {
                //
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(@"Kanji.txt")) {

            }
        }

        private void txbKanji_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbKanji.Text) ||
                String.IsNullOrEmpty(txbMeaning.Text) ||
                String.IsNullOrEmpty(txbKunyomi.Text) ||
                String.IsNullOrEmpty(txbOnyomi.Text))
            {
                btnAdd.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
            }
        }

        private void txbMeaning_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbKanji.Text) ||
                String.IsNullOrEmpty(txbMeaning.Text) ||
                String.IsNullOrEmpty(txbKunyomi.Text) ||
                String.IsNullOrEmpty(txbOnyomi.Text))
            {
                btnAdd.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
            }
        }

        private void txbKunyomi_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbKanji.Text) ||
                String.IsNullOrEmpty(txbMeaning.Text) ||
                String.IsNullOrEmpty(txbKunyomi.Text) ||
                String.IsNullOrEmpty(txbOnyomi.Text))
            {
                btnAdd.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
            }
        }

        private void txbOnyomi_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbKanji.Text) ||
                String.IsNullOrEmpty(txbMeaning.Text) ||
                String.IsNullOrEmpty(txbKunyomi.Text) ||
                String.IsNullOrEmpty(txbOnyomi.Text))
            {
                btnAdd.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
            }
        }

        void Addkanji_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.NUM_FORMS_OPEN--;
        }
    }
}
