namespace KanjiTester
{
    partial class Addkanji
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
            this.btnLang = new System.Windows.Forms.Button();
            this.lblKanji = new System.Windows.Forms.Label();
            this.lblMeaning = new System.Windows.Forms.Label();
            this.lblKunyomi = new System.Windows.Forms.Label();
            this.lblOnyomi = new System.Windows.Forms.Label();
            this.lblReadings = new System.Windows.Forms.Label();
            this.txbKanji = new System.Windows.Forms.TextBox();
            this.txbMeaning = new System.Windows.Forms.TextBox();
            this.txbKunyomi = new System.Windows.Forms.TextBox();
            this.txbOnyomi = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLang
            // 
            this.btnLang.Location = new System.Drawing.Point(12, 12);
            this.btnLang.Name = "btnLang";
            this.btnLang.Size = new System.Drawing.Size(65, 29);
            this.btnLang.TabIndex = 0;
            this.btnLang.Text = "日本語";
            this.btnLang.UseMnemonic = false;
            this.btnLang.UseVisualStyleBackColor = true;
            this.btnLang.Click += new System.EventHandler(this.btnLang_Click);
            // 
            // lblKanji
            // 
            this.lblKanji.AutoSize = true;
            this.lblKanji.Font = new System.Drawing.Font("Noto Sans CJK JP Bold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblKanji.Location = new System.Drawing.Point(47, 80);
            this.lblKanji.Name = "lblKanji";
            this.lblKanji.Size = new System.Drawing.Size(46, 19);
            this.lblKanji.TabIndex = 1;
            this.lblKanji.Text = "Kanji:";
            // 
            // lblMeaning
            // 
            this.lblMeaning.AutoSize = true;
            this.lblMeaning.Font = new System.Drawing.Font("Noto Sans CJK JP Bold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMeaning.Location = new System.Drawing.Point(26, 112);
            this.lblMeaning.Name = "lblMeaning";
            this.lblMeaning.Size = new System.Drawing.Size(68, 19);
            this.lblMeaning.TabIndex = 2;
            this.lblMeaning.Text = "Meaning:";
            // 
            // lblKunyomi
            // 
            this.lblKunyomi.AutoSize = true;
            this.lblKunyomi.Font = new System.Drawing.Font("Noto Sans CJK JP Bold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblKunyomi.Location = new System.Drawing.Point(19, 182);
            this.lblKunyomi.Name = "lblKunyomi";
            this.lblKunyomi.Size = new System.Drawing.Size(74, 19);
            this.lblKunyomi.TabIndex = 3;
            this.lblKunyomi.Text = "Kun\'yomi:";
            // 
            // lblOnyomi
            // 
            this.lblOnyomi.AutoSize = true;
            this.lblOnyomi.Font = new System.Drawing.Font("Noto Sans CJK JP Bold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblOnyomi.Location = new System.Drawing.Point(26, 215);
            this.lblOnyomi.Name = "lblOnyomi";
            this.lblOnyomi.Size = new System.Drawing.Size(67, 19);
            this.lblOnyomi.TabIndex = 4;
            this.lblOnyomi.Text = "On\'yomi:";
            // 
            // lblReadings
            // 
            this.lblReadings.AutoSize = true;
            this.lblReadings.Font = new System.Drawing.Font("Noto Sans CJK JP Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadings.Location = new System.Drawing.Point(59, 147);
            this.lblReadings.Name = "lblReadings";
            this.lblReadings.Size = new System.Drawing.Size(82, 24);
            this.lblReadings.TabIndex = 10;
            this.lblReadings.Text = "Readings";
            // 
            // txbKanji
            // 
            this.txbKanji.Font = new System.Drawing.Font("Noto Sans CJK JP Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbKanji.Location = new System.Drawing.Point(99, 77);
            this.txbKanji.Name = "txbKanji";
            this.txbKanji.Size = new System.Drawing.Size(42, 27);
            this.txbKanji.TabIndex = 11;
            this.txbKanji.TextChanged += new System.EventHandler(this.txbKanji_TextChanged);
            // 
            // txbMeaning
            // 
            this.txbMeaning.Font = new System.Drawing.Font("Noto Sans CJK JP Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMeaning.Location = new System.Drawing.Point(99, 109);
            this.txbMeaning.Name = "txbMeaning";
            this.txbMeaning.Size = new System.Drawing.Size(179, 27);
            this.txbMeaning.TabIndex = 12;
            this.txbMeaning.TextChanged += new System.EventHandler(this.txbMeaning_TextChanged);
            // 
            // txbKunyomi
            // 
            this.txbKunyomi.Font = new System.Drawing.Font("Noto Sans CJK JP Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbKunyomi.Location = new System.Drawing.Point(99, 179);
            this.txbKunyomi.Name = "txbKunyomi";
            this.txbKunyomi.Size = new System.Drawing.Size(179, 27);
            this.txbKunyomi.TabIndex = 13;
            this.txbKunyomi.TextChanged += new System.EventHandler(this.txbKunyomi_TextChanged);
            // 
            // txbOnyomi
            // 
            this.txbOnyomi.Font = new System.Drawing.Font("Noto Sans CJK JP Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbOnyomi.Location = new System.Drawing.Point(99, 211);
            this.txbOnyomi.Name = "txbOnyomi";
            this.txbOnyomi.Size = new System.Drawing.Size(179, 27);
            this.txbOnyomi.TabIndex = 14;
            this.txbOnyomi.TextChanged += new System.EventHandler(this.txbOnyomi_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(124, 267);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add to list";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Addkanji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 312);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbOnyomi);
            this.Controls.Add(this.txbKunyomi);
            this.Controls.Add(this.txbMeaning);
            this.Controls.Add(this.txbKanji);
            this.Controls.Add(this.lblReadings);
            this.Controls.Add(this.lblOnyomi);
            this.Controls.Add(this.lblKunyomi);
            this.Controls.Add(this.lblMeaning);
            this.Controls.Add(this.lblKanji);
            this.Controls.Add(this.btnLang);
            this.MaximizeBox = false;
            this.Name = "Addkanji";
            this.Text = "Add a Kanji";
            this.Load += new System.EventHandler(this.Addkanji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLang;
        private System.Windows.Forms.Label lblKanji;
        private System.Windows.Forms.Label lblMeaning;
        private System.Windows.Forms.Label lblKunyomi;
        private System.Windows.Forms.Label lblOnyomi;
        private System.Windows.Forms.Label lblReadings;
        private System.Windows.Forms.TextBox txbKanji;
        private System.Windows.Forms.TextBox txbMeaning;
        private System.Windows.Forms.TextBox txbKunyomi;
        private System.Windows.Forms.TextBox txbOnyomi;
        private System.Windows.Forms.Button btnAdd;
    }
}