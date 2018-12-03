namespace KanjiTester
{
    partial class Main
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
            this.btnReveal = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblKanji = new System.Windows.Forms.Label();
            this.lblMeaning = new System.Windows.Forms.Label();
            this.lblKunyomi = new System.Windows.Forms.Label();
            this.lblOnyomi = new System.Windows.Forms.Label();
            this.txbMeaning = new System.Windows.Forms.TextBox();
            this.txbKun = new System.Windows.Forms.TextBox();
            this.txbOn = new System.Windows.Forms.TextBox();
            this.lblReadings = new System.Windows.Forms.Label();
            this.btnJisho = new System.Windows.Forms.Button();
            this.btnLang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReveal
            // 
            this.btnReveal.Location = new System.Drawing.Point(329, 244);
            this.btnReveal.Name = "btnReveal";
            this.btnReveal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReveal.Size = new System.Drawing.Size(60, 30);
            this.btnReveal.TabIndex = 0;
            this.btnReveal.Text = "Reveal";
            this.btnReveal.UseVisualStyleBackColor = true;
            this.btnReveal.Click += new System.EventHandler(this.btnReveal_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(191, 297);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 30);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblKanji
            // 
            this.lblKanji.AutoSize = true;
            this.lblKanji.Font = new System.Drawing.Font("Noto Sans CJK JP Bold", 128.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblKanji.Location = new System.Drawing.Point(232, -12);
            this.lblKanji.Name = "lblKanji";
            this.lblKanji.Size = new System.Drawing.Size(278, 253);
            this.lblKanji.TabIndex = 2;
            this.lblKanji.Text = "例";
            this.lblKanji.Visible = false;
            // 
            // lblMeaning
            // 
            this.lblMeaning.AutoSize = true;
            this.lblMeaning.Font = new System.Drawing.Font("Noto Sans CJK JP Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeaning.Location = new System.Drawing.Point(10, 68);
            this.lblMeaning.Name = "lblMeaning";
            this.lblMeaning.Size = new System.Drawing.Size(68, 19);
            this.lblMeaning.TabIndex = 3;
            this.lblMeaning.Text = "Meaning:";
            // 
            // lblKunyomi
            // 
            this.lblKunyomi.AutoSize = true;
            this.lblKunyomi.Font = new System.Drawing.Font("Noto Sans CJK JP Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKunyomi.Location = new System.Drawing.Point(6, 145);
            this.lblKunyomi.Name = "lblKunyomi";
            this.lblKunyomi.Size = new System.Drawing.Size(74, 19);
            this.lblKunyomi.TabIndex = 4;
            this.lblKunyomi.Text = "Kun\'yomi:";
            // 
            // lblOnyomi
            // 
            this.lblOnyomi.AutoSize = true;
            this.lblOnyomi.Font = new System.Drawing.Font("Noto Sans CJK JP Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnyomi.Location = new System.Drawing.Point(12, 177);
            this.lblOnyomi.Name = "lblOnyomi";
            this.lblOnyomi.Size = new System.Drawing.Size(67, 19);
            this.lblOnyomi.TabIndex = 5;
            this.lblOnyomi.Text = "On\'yomi:";
            // 
            // txbMeaning
            // 
            this.txbMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMeaning.Location = new System.Drawing.Point(85, 66);
            this.txbMeaning.Name = "txbMeaning";
            this.txbMeaning.ReadOnly = true;
            this.txbMeaning.Size = new System.Drawing.Size(170, 22);
            this.txbMeaning.TabIndex = 6;
            // 
            // txbKun
            // 
            this.txbKun.Font = new System.Drawing.Font("Noto Sans CJK JP Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbKun.Location = new System.Drawing.Point(85, 141);
            this.txbKun.Name = "txbKun";
            this.txbKun.ReadOnly = true;
            this.txbKun.Size = new System.Drawing.Size(170, 27);
            this.txbKun.TabIndex = 7;
            // 
            // txbOn
            // 
            this.txbOn.Font = new System.Drawing.Font("Noto Sans CJK JP Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbOn.Location = new System.Drawing.Point(85, 173);
            this.txbOn.Name = "txbOn";
            this.txbOn.ReadOnly = true;
            this.txbOn.Size = new System.Drawing.Size(170, 27);
            this.txbOn.TabIndex = 8;
            // 
            // lblReadings
            // 
            this.lblReadings.AutoSize = true;
            this.lblReadings.Font = new System.Drawing.Font("Noto Sans CJK JP Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadings.Location = new System.Drawing.Point(63, 111);
            this.lblReadings.Name = "lblReadings";
            this.lblReadings.Size = new System.Drawing.Size(82, 24);
            this.lblReadings.TabIndex = 9;
            this.lblReadings.Text = "Readings";
            // 
            // btnJisho
            // 
            this.btnJisho.Enabled = false;
            this.btnJisho.Location = new System.Drawing.Point(73, 218);
            this.btnJisho.Name = "btnJisho";
            this.btnJisho.Size = new System.Drawing.Size(112, 30);
            this.btnJisho.TabIndex = 10;
            this.btnJisho.Text = "See on Jisho.org!";
            this.btnJisho.UseVisualStyleBackColor = true;
            this.btnJisho.Click += new System.EventHandler(this.btnJisho_Click);
            // 
            // btnLang
            // 
            this.btnLang.Location = new System.Drawing.Point(9, 12);
            this.btnLang.Name = "btnLang";
            this.btnLang.Size = new System.Drawing.Size(65, 29);
            this.btnLang.TabIndex = 11;
            this.btnLang.Text = "日本語";
            this.btnLang.UseVisualStyleBackColor = true;
            this.btnLang.Click += new System.EventHandler(this.btnLang_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 339);
            this.Controls.Add(this.btnLang);
            this.Controls.Add(this.btnJisho);
            this.Controls.Add(this.lblReadings);
            this.Controls.Add(this.txbOn);
            this.Controls.Add(this.txbKun);
            this.Controls.Add(this.txbMeaning);
            this.Controls.Add(this.lblOnyomi);
            this.Controls.Add(this.lblKunyomi);
            this.Controls.Add(this.lblMeaning);
            this.Controls.Add(this.lblKanji);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnReveal);
            this.Name = "Main";
            this.Text = "Kanji Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReveal;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblKanji;
        private System.Windows.Forms.Label lblMeaning;
        private System.Windows.Forms.Label lblKunyomi;
        private System.Windows.Forms.Label lblOnyomi;
        private System.Windows.Forms.TextBox txbMeaning;
        private System.Windows.Forms.TextBox txbKun;
        private System.Windows.Forms.TextBox txbOn;
        private System.Windows.Forms.Label lblReadings;
        private System.Windows.Forms.Button btnJisho;
        private System.Windows.Forms.Button btnLang;
    }
}

