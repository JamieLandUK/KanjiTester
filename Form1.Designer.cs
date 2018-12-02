namespace KanjiTester
{
    partial class Form1
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
            // 
            // lblKanji
            // 
            this.lblKanji.AutoSize = true;
            this.lblKanji.Font = new System.Drawing.Font("Noto Sans CJK JP Bold", 128.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblKanji.Location = new System.Drawing.Point(230, -12);
            this.lblKanji.Name = "lblKanji";
            this.lblKanji.Size = new System.Drawing.Size(278, 253);
            this.lblKanji.TabIndex = 2;
            this.lblKanji.Text = "悪";
            this.lblKanji.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 339);
            this.Controls.Add(this.lblKanji);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnReveal);
            this.Name = "Form1";
            this.Text = "Kanji Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReveal;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblKanji;
    }
}

