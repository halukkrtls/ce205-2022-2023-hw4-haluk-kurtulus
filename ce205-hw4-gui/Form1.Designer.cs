namespace ce205_hw4_gui
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Random2 = new System.Windows.Forms.Button();
            this.Random1 = new System.Windows.Forms.Button();
            this.NeedlemanRichTextBox = new System.Windows.Forms.RichTextBox();
            this.AlignmentNeedleman = new System.Windows.Forms.Button();
            this.NeedlemanTextBox2 = new System.Windows.Forms.TextBox();
            this.NeedlemanTextBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Random4 = new System.Windows.Forms.Button();
            this.Random3 = new System.Windows.Forms.Button();
            this.SmithtextBox2 = new System.Windows.Forms.TextBox();
            this.SmithrichTextBox = new System.Windows.Forms.RichTextBox();
            this.SmithtextBox1 = new System.Windows.Forms.TextBox();
            this.SmithAlignment = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Random7 = new System.Windows.Forms.Button();
            this.Random6 = new System.Windows.Forms.Button();
            this.HuntrichTextBox = new System.Windows.Forms.RichTextBox();
            this.HuntAlignment = new System.Windows.Forms.Button();
            this.HunttextBox1 = new System.Windows.Forms.TextBox();
            this.HunttextBox2 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.KnuthrichTextBox = new System.Windows.Forms.RichTextBox();
            this.SearchKnuth = new System.Windows.Forms.Button();
            this.KnuthtextBox = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.HorspoolrichTextBox = new System.Windows.Forms.RichTextBox();
            this.HorspooltextBox = new System.Windows.Forms.TextBox();
            this.SearchHorspool = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.BoyerrichTextBox = new System.Windows.Forms.RichTextBox();
            this.SearchBoyer = new System.Windows.Forms.Button();
            this.BoyertextBox = new System.Windows.Forms.TextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.InsertTrie = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1448, 738);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.BurlyWood;
            this.tabPage1.Controls.Add(this.Random2);
            this.tabPage1.Controls.Add(this.Random1);
            this.tabPage1.Controls.Add(this.NeedlemanRichTextBox);
            this.tabPage1.Controls.Add(this.AlignmentNeedleman);
            this.tabPage1.Controls.Add(this.NeedlemanTextBox2);
            this.tabPage1.Controls.Add(this.NeedlemanTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1440, 709);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Needleman-Wunsch";
            // 
            // Random2
            // 
            this.Random2.BackColor = System.Drawing.Color.Chartreuse;
            this.Random2.Location = new System.Drawing.Point(363, 68);
            this.Random2.Name = "Random2";
            this.Random2.Size = new System.Drawing.Size(89, 22);
            this.Random2.TabIndex = 5;
            this.Random2.Text = "Random";
            this.Random2.UseVisualStyleBackColor = false;
            this.Random2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Random1
            // 
            this.Random1.BackColor = System.Drawing.Color.GreenYellow;
            this.Random1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Random1.Location = new System.Drawing.Point(363, 28);
            this.Random1.Name = "Random1";
            this.Random1.Size = new System.Drawing.Size(89, 22);
            this.Random1.TabIndex = 4;
            this.Random1.Text = "Random";
            this.Random1.UseVisualStyleBackColor = false;
            this.Random1.Click += new System.EventHandler(this.Random1_Click);
            // 
            // NeedlemanRichTextBox
            // 
            this.NeedlemanRichTextBox.Location = new System.Drawing.Point(6, 139);
            this.NeedlemanRichTextBox.Name = "NeedlemanRichTextBox";
            this.NeedlemanRichTextBox.Size = new System.Drawing.Size(1428, 567);
            this.NeedlemanRichTextBox.TabIndex = 3;
            this.NeedlemanRichTextBox.Text = "";
            // 
            // AlignmentNeedleman
            // 
            this.AlignmentNeedleman.BackColor = System.Drawing.Color.RoyalBlue;
            this.AlignmentNeedleman.Location = new System.Drawing.Point(654, 28);
            this.AlignmentNeedleman.Name = "AlignmentNeedleman";
            this.AlignmentNeedleman.Size = new System.Drawing.Size(176, 62);
            this.AlignmentNeedleman.TabIndex = 2;
            this.AlignmentNeedleman.Text = "Alignment";
            this.AlignmentNeedleman.UseVisualStyleBackColor = false;
            this.AlignmentNeedleman.Click += new System.EventHandler(this.AlignmentNeedleman_Click);
            // 
            // NeedlemanTextBox2
            // 
            this.NeedlemanTextBox2.Location = new System.Drawing.Point(127, 68);
            this.NeedlemanTextBox2.Name = "NeedlemanTextBox2";
            this.NeedlemanTextBox2.Size = new System.Drawing.Size(199, 22);
            this.NeedlemanTextBox2.TabIndex = 1;
            this.NeedlemanTextBox2.TextChanged += new System.EventHandler(this.NeedlemanTextBox2_TextChanged);
            // 
            // NeedlemanTextBox1
            // 
            this.NeedlemanTextBox1.Location = new System.Drawing.Point(127, 28);
            this.NeedlemanTextBox1.Name = "NeedlemanTextBox1";
            this.NeedlemanTextBox1.Size = new System.Drawing.Size(199, 22);
            this.NeedlemanTextBox1.TabIndex = 0;
            this.NeedlemanTextBox1.TextChanged += new System.EventHandler(this.NeedlemanTextBox1_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Aquamarine;
            this.tabPage2.Controls.Add(this.Random4);
            this.tabPage2.Controls.Add(this.Random3);
            this.tabPage2.Controls.Add(this.SmithtextBox2);
            this.tabPage2.Controls.Add(this.SmithrichTextBox);
            this.tabPage2.Controls.Add(this.SmithtextBox1);
            this.tabPage2.Controls.Add(this.SmithAlignment);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1440, 709);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Smith-Waterman";
            // 
            // Random4
            // 
            this.Random4.BackColor = System.Drawing.Color.HotPink;
            this.Random4.Location = new System.Drawing.Point(345, 54);
            this.Random4.Name = "Random4";
            this.Random4.Size = new System.Drawing.Size(89, 22);
            this.Random4.TabIndex = 6;
            this.Random4.Text = "Random";
            this.Random4.UseVisualStyleBackColor = false;
            this.Random4.Click += new System.EventHandler(this.Random4_Click);
            // 
            // Random3
            // 
            this.Random3.BackColor = System.Drawing.Color.HotPink;
            this.Random3.Location = new System.Drawing.Point(345, 26);
            this.Random3.Name = "Random3";
            this.Random3.Size = new System.Drawing.Size(89, 22);
            this.Random3.TabIndex = 5;
            this.Random3.Text = "Random";
            this.Random3.UseVisualStyleBackColor = false;
            this.Random3.Click += new System.EventHandler(this.button4_Click);
            // 
            // SmithtextBox2
            // 
            this.SmithtextBox2.Location = new System.Drawing.Point(124, 54);
            this.SmithtextBox2.Name = "SmithtextBox2";
            this.SmithtextBox2.Size = new System.Drawing.Size(190, 22);
            this.SmithtextBox2.TabIndex = 3;
            // 
            // SmithrichTextBox
            // 
            this.SmithrichTextBox.Location = new System.Drawing.Point(7, 110);
            this.SmithrichTextBox.Name = "SmithrichTextBox";
            this.SmithrichTextBox.Size = new System.Drawing.Size(1433, 603);
            this.SmithrichTextBox.TabIndex = 2;
            this.SmithrichTextBox.Text = "";
            // 
            // SmithtextBox1
            // 
            this.SmithtextBox1.Location = new System.Drawing.Point(124, 26);
            this.SmithtextBox1.Name = "SmithtextBox1";
            this.SmithtextBox1.Size = new System.Drawing.Size(190, 22);
            this.SmithtextBox1.TabIndex = 1;
            this.SmithtextBox1.TextChanged += new System.EventHandler(this.SmithtextBox1_TextChanged);
            // 
            // SmithAlignment
            // 
            this.SmithAlignment.BackColor = System.Drawing.Color.Purple;
            this.SmithAlignment.Location = new System.Drawing.Point(696, 26);
            this.SmithAlignment.Name = "SmithAlignment";
            this.SmithAlignment.Size = new System.Drawing.Size(131, 52);
            this.SmithAlignment.TabIndex = 0;
            this.SmithAlignment.Text = "Alignment";
            this.SmithAlignment.UseVisualStyleBackColor = false;
            this.SmithAlignment.Click += new System.EventHandler(this.SmithAlignment_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkGreen;
            this.tabPage3.Controls.Add(this.Random7);
            this.tabPage3.Controls.Add(this.Random6);
            this.tabPage3.Controls.Add(this.HuntrichTextBox);
            this.tabPage3.Controls.Add(this.HuntAlignment);
            this.tabPage3.Controls.Add(this.HunttextBox1);
            this.tabPage3.Controls.Add(this.HunttextBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1440, 709);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hunt-Szymanski";
            // 
            // Random7
            // 
            this.Random7.BackColor = System.Drawing.Color.Red;
            this.Random7.Location = new System.Drawing.Point(346, 58);
            this.Random7.Name = "Random7";
            this.Random7.Size = new System.Drawing.Size(89, 22);
            this.Random7.TabIndex = 7;
            this.Random7.Text = "Random";
            this.Random7.UseVisualStyleBackColor = false;
            this.Random7.Click += new System.EventHandler(this.Random7_Click);
            // 
            // Random6
            // 
            this.Random6.BackColor = System.Drawing.Color.Red;
            this.Random6.Location = new System.Drawing.Point(346, 28);
            this.Random6.Name = "Random6";
            this.Random6.Size = new System.Drawing.Size(89, 22);
            this.Random6.TabIndex = 6;
            this.Random6.Text = "Random";
            this.Random6.UseVisualStyleBackColor = false;
            this.Random6.Click += new System.EventHandler(this.Random6_Click);
            // 
            // HuntrichTextBox
            // 
            this.HuntrichTextBox.Location = new System.Drawing.Point(7, 86);
            this.HuntrichTextBox.Name = "HuntrichTextBox";
            this.HuntrichTextBox.Size = new System.Drawing.Size(1433, 603);
            this.HuntrichTextBox.TabIndex = 5;
            this.HuntrichTextBox.Text = "";
            // 
            // HuntAlignment
            // 
            this.HuntAlignment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.HuntAlignment.Location = new System.Drawing.Point(705, 28);
            this.HuntAlignment.Name = "HuntAlignment";
            this.HuntAlignment.Size = new System.Drawing.Size(131, 52);
            this.HuntAlignment.TabIndex = 4;
            this.HuntAlignment.Text = "Alignment";
            this.HuntAlignment.UseVisualStyleBackColor = false;
            this.HuntAlignment.Click += new System.EventHandler(this.HuntAlignment_Click);
            // 
            // HunttextBox1
            // 
            this.HunttextBox1.Location = new System.Drawing.Point(126, 28);
            this.HunttextBox1.Name = "HunttextBox1";
            this.HunttextBox1.Size = new System.Drawing.Size(190, 22);
            this.HunttextBox1.TabIndex = 3;
            this.HunttextBox1.TextChanged += new System.EventHandler(this.HunttextBox1_TextChanged);
            // 
            // HunttextBox2
            // 
            this.HunttextBox2.Location = new System.Drawing.Point(126, 58);
            this.HunttextBox2.Name = "HunttextBox2";
            this.HunttextBox2.Size = new System.Drawing.Size(190, 22);
            this.HunttextBox2.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tabPage4.Controls.Add(this.KnuthrichTextBox);
            this.tabPage4.Controls.Add(this.SearchKnuth);
            this.tabPage4.Controls.Add(this.KnuthtextBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1440, 709);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Kunt-Morris-Pratt";
            // 
            // KnuthrichTextBox
            // 
            this.KnuthrichTextBox.Location = new System.Drawing.Point(10, 110);
            this.KnuthrichTextBox.Name = "KnuthrichTextBox";
            this.KnuthrichTextBox.Size = new System.Drawing.Size(1433, 603);
            this.KnuthrichTextBox.TabIndex = 7;
            this.KnuthrichTextBox.Text = "";
            this.KnuthrichTextBox.TextChanged += new System.EventHandler(this.KnuthrichTextBox_TextChanged);
            // 
            // SearchKnuth
            // 
            this.SearchKnuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SearchKnuth.Location = new System.Drawing.Point(357, 23);
            this.SearchKnuth.Name = "SearchKnuth";
            this.SearchKnuth.Size = new System.Drawing.Size(131, 52);
            this.SearchKnuth.TabIndex = 6;
            this.SearchKnuth.Text = "Search";
            this.SearchKnuth.UseVisualStyleBackColor = false;
            this.SearchKnuth.Click += new System.EventHandler(this.SearchKnuth_Click);
            // 
            // KnuthtextBox
            // 
            this.KnuthtextBox.Location = new System.Drawing.Point(138, 38);
            this.KnuthtextBox.Name = "KnuthtextBox";
            this.KnuthtextBox.Size = new System.Drawing.Size(190, 22);
            this.KnuthtextBox.TabIndex = 5;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tabPage5.Controls.Add(this.HorspoolrichTextBox);
            this.tabPage5.Controls.Add(this.HorspooltextBox);
            this.tabPage5.Controls.Add(this.SearchHorspool);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1440, 709);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Horspool";
            // 
            // HorspoolrichTextBox
            // 
            this.HorspoolrichTextBox.Location = new System.Drawing.Point(28, 82);
            this.HorspoolrichTextBox.Name = "HorspoolrichTextBox";
            this.HorspoolrichTextBox.Size = new System.Drawing.Size(1433, 603);
            this.HorspoolrichTextBox.TabIndex = 9;
            this.HorspoolrichTextBox.Text = "";
            this.HorspoolrichTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // HorspooltextBox
            // 
            this.HorspooltextBox.Location = new System.Drawing.Point(171, 39);
            this.HorspooltextBox.Name = "HorspooltextBox";
            this.HorspooltextBox.Size = new System.Drawing.Size(190, 22);
            this.HorspooltextBox.TabIndex = 8;
            this.HorspooltextBox.TextChanged += new System.EventHandler(this.HorspooltextBox_TextChanged);
            // 
            // SearchHorspool
            // 
            this.SearchHorspool.BackColor = System.Drawing.Color.Red;
            this.SearchHorspool.Location = new System.Drawing.Point(386, 24);
            this.SearchHorspool.Name = "SearchHorspool";
            this.SearchHorspool.Size = new System.Drawing.Size(131, 52);
            this.SearchHorspool.TabIndex = 7;
            this.SearchHorspool.Text = "Search";
            this.SearchHorspool.UseVisualStyleBackColor = false;
            this.SearchHorspool.Click += new System.EventHandler(this.SearchHorspool_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.Lime;
            this.tabPage6.Controls.Add(this.BoyerrichTextBox);
            this.tabPage6.Controls.Add(this.SearchBoyer);
            this.tabPage6.Controls.Add(this.BoyertextBox);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1440, 709);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Boyer-Moore";
            // 
            // BoyerrichTextBox
            // 
            this.BoyerrichTextBox.Location = new System.Drawing.Point(4, 106);
            this.BoyerrichTextBox.Name = "BoyerrichTextBox";
            this.BoyerrichTextBox.Size = new System.Drawing.Size(1433, 603);
            this.BoyerrichTextBox.TabIndex = 11;
            this.BoyerrichTextBox.Text = "";
            // 
            // SearchBoyer
            // 
            this.SearchBoyer.BackColor = System.Drawing.Color.Cyan;
            this.SearchBoyer.Location = new System.Drawing.Point(395, 23);
            this.SearchBoyer.Name = "SearchBoyer";
            this.SearchBoyer.Size = new System.Drawing.Size(131, 52);
            this.SearchBoyer.TabIndex = 10;
            this.SearchBoyer.Text = "Search";
            this.SearchBoyer.UseVisualStyleBackColor = false;
            this.SearchBoyer.Click += new System.EventHandler(this.SearchBoyer_Click);
            // 
            // BoyertextBox
            // 
            this.BoyertextBox.Location = new System.Drawing.Point(172, 38);
            this.BoyertextBox.Name = "BoyertextBox";
            this.BoyertextBox.Size = new System.Drawing.Size(190, 22);
            this.BoyertextBox.TabIndex = 9;
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.Gray;
            this.tabPage7.Controls.Add(this.button8);
            this.tabPage7.Controls.Add(this.richTextBox2);
            this.tabPage7.Controls.Add(this.richTextBox1);
            this.tabPage7.Controls.Add(this.button3);
            this.tabPage7.Controls.Add(this.InsertTrie);
            this.tabPage7.Controls.Add(this.textBox1);
            this.tabPage7.Controls.Add(this.textBox2);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1440, 709);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Trie";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(360, 49);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(89, 22);
            this.button8.TabIndex = 16;
            this.button8.Text = "Random";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(692, 98);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(712, 611);
            this.richTextBox2.TabIndex = 15;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(26, 98);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(635, 605);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(692, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 22);
            this.button3.TabIndex = 13;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // InsertTrie
            // 
            this.InsertTrie.Location = new System.Drawing.Point(476, 49);
            this.InsertTrie.Name = "InsertTrie";
            this.InsertTrie.Size = new System.Drawing.Size(100, 22);
            this.InsertTrie.TabIndex = 12;
            this.InsertTrie.Text = "Insert";
            this.InsertTrie.UseVisualStyleBackColor = true;
            this.InsertTrie.Click += new System.EventHandler(this.InsertTrie_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(813, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 22);
            this.textBox2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 752);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox NeedlemanRichTextBox;
        private System.Windows.Forms.Button AlignmentNeedleman;
        private System.Windows.Forms.TextBox NeedlemanTextBox2;
        private System.Windows.Forms.TextBox NeedlemanTextBox1;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.TabPage tabPage5;
        public System.Windows.Forms.TabPage tabPage6;
        public System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox SmithtextBox2;
        private System.Windows.Forms.RichTextBox SmithrichTextBox;
        private System.Windows.Forms.TextBox SmithtextBox1;
        private System.Windows.Forms.Button SmithAlignment;
        private System.Windows.Forms.RichTextBox HuntrichTextBox;
        private System.Windows.Forms.Button HuntAlignment;
        private System.Windows.Forms.TextBox HunttextBox1;
        private System.Windows.Forms.TextBox HunttextBox2;
        private System.Windows.Forms.RichTextBox KnuthrichTextBox;
        private System.Windows.Forms.Button SearchKnuth;
        private System.Windows.Forms.TextBox KnuthtextBox;
        private System.Windows.Forms.TextBox HorspooltextBox;
        private System.Windows.Forms.Button SearchHorspool;
        private System.Windows.Forms.RichTextBox HorspoolrichTextBox;
        private System.Windows.Forms.RichTextBox BoyerrichTextBox;
        private System.Windows.Forms.Button SearchBoyer;
        private System.Windows.Forms.TextBox BoyertextBox;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button InsertTrie;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Random2;
        private System.Windows.Forms.Button Random1;
        private System.Windows.Forms.Button Random4;
        private System.Windows.Forms.Button Random3;
        private System.Windows.Forms.Button Random6;
        private System.Windows.Forms.Button Random7;
        private System.Windows.Forms.Button button8;
    }
}

