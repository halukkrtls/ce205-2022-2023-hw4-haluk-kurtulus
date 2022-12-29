using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ce205_hw4_gui.TrieAlgorithm;

namespace ce205_hw4_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void KnuthrichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void HorspooltextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SmithAlignment_Click(object sender, EventArgs e)
        {
            SmithWaterman smith = new SmithWaterman();
            string gene1 = SmithtextBox1.Text;
            string gene2 = SmithtextBox2.Text;

            SmithrichTextBox.Clear();

            for (int i = 0; i < Math.Max(gene1.Length, gene2.Length); i++)
            {
                // Check if the characters at the current position match
                if (i < gene1.Length && i < gene2.Length && gene1[i] == gene2[i])
                {
                    if (i < gene1.Length)
                    {
                        // If they match, add them to the RichTextBox with a green color
                        SmithrichTextBox.SelectionStart = SmithrichTextBox.TextLength;
                        SmithrichTextBox.SelectionLength = 1;
                        SmithrichTextBox.SelectionColor = Color.Green;
                        SmithrichTextBox.AppendText(gene1[i].ToString());
                        SmithrichTextBox.SelectionColor = SmithrichTextBox.ForeColor;
                    }
                    if (i < gene2.Length)
                    {
                        SmithrichTextBox.SelectionStart = SmithrichTextBox.TextLength;
                        SmithrichTextBox.SelectionLength = 1;
                        SmithrichTextBox.SelectionColor = Color.Green;
                        SmithrichTextBox.AppendText(gene2[i].ToString());
                        SmithrichTextBox.SelectionColor = SmithrichTextBox.ForeColor;
                    }
                    SmithrichTextBox.AppendText("\n");
                }
                else if (i < gene1.Length && i < gene2.Length && gene1[i] != gene2[i])
                {
                    if (i < gene1.Length)
                    {

                        SmithrichTextBox.SelectionStart = SmithrichTextBox.TextLength;
                        SmithrichTextBox.SelectionLength = 1;
                        SmithrichTextBox.SelectionColor = Color.Red;
                        SmithrichTextBox.AppendText(gene1[i].ToString());
                        SmithrichTextBox.SelectionColor = SmithrichTextBox.ForeColor;
                    }
                    if (i < gene2.Length)
                    {
                        SmithrichTextBox.SelectionStart = SmithrichTextBox.TextLength;
                        SmithrichTextBox.SelectionLength = 1;
                        SmithrichTextBox.SelectionColor = Color.Red;
                        SmithrichTextBox.AppendText(gene2[i].ToString());
                        SmithrichTextBox.SelectionColor = SmithrichTextBox.ForeColor;
                        SmithrichTextBox.AppendText("\n");
                    }
                }
                else
                {
                    if (i < gene1.Length)
                    {

                        SmithrichTextBox.SelectionStart = SmithrichTextBox.TextLength;
                        SmithrichTextBox.SelectionLength = 1;
                        SmithrichTextBox.SelectionColor = Color.Blue;
                        SmithrichTextBox.AppendText(gene1[i].ToString());
                        SmithrichTextBox.SelectionColor = SmithrichTextBox.ForeColor;
                    }
                    if (i < gene2.Length)
                    {
                        SmithrichTextBox.SelectionStart = SmithrichTextBox.TextLength;
                        SmithrichTextBox.SelectionLength = 1;
                        SmithrichTextBox.SelectionColor = Color.Blue;
                        SmithrichTextBox.AppendText(gene2[i].ToString());
                        SmithrichTextBox.SelectionColor = SmithrichTextBox.ForeColor;
                    }
                    SmithrichTextBox.AppendText("-" + "\n");
                }
            }
        }

        private void AlignmentNeedleman_Click(object sender, EventArgs e)
        {
            Needleman_Wunsch needleman = new Needleman_Wunsch();
            string input1 = NeedlemanTextBox1.Text;
            string input2 = NeedlemanTextBox2.Text;

            // Clear the RichTextBox
            NeedlemanRichTextBox.Clear();

            // Iterate over the characters in the input strings
            for (int i = 0; i < Math.Max(input1.Length, input2.Length); i++)
            {
                // Check if the characters at the current position match
                if (i < input1.Length && i < input2.Length && input1[i] == input2[i])
                {
                    if (i < input1.Length)
                    {
                        // If they match, add them to the RichTextBox with a green color
                        NeedlemanRichTextBox.SelectionStart = NeedlemanRichTextBox.TextLength;
                        NeedlemanRichTextBox.SelectionLength = 1;
                        NeedlemanRichTextBox.SelectionColor = Color.Green;
                        NeedlemanRichTextBox.AppendText(input1[i].ToString());
                        NeedlemanRichTextBox.SelectionColor = NeedlemanRichTextBox.ForeColor;
                    }
                    if (i < input2.Length)
                    {
                        NeedlemanRichTextBox.SelectionStart = NeedlemanRichTextBox.TextLength;
                        NeedlemanRichTextBox.SelectionLength = 1;
                        NeedlemanRichTextBox.SelectionColor = Color.Green;
                        NeedlemanRichTextBox.AppendText(input2[i].ToString());
                        NeedlemanRichTextBox.SelectionColor = NeedlemanRichTextBox.ForeColor;
                    }
                    NeedlemanRichTextBox.AppendText("\n");
                }
                else if (i < input1.Length && i < input2.Length && input1[i] != input2[i])
                {
                    // If they do not match, add them to the RichTextBox with a red color
                    if (i < input1.Length)
                    {
                        NeedlemanRichTextBox.SelectionStart = NeedlemanRichTextBox.TextLength;
                        NeedlemanRichTextBox.SelectionLength = 1;
                        NeedlemanRichTextBox.SelectionColor = Color.Red;
                        NeedlemanRichTextBox.AppendText(input1[i].ToString());
                        NeedlemanRichTextBox.SelectionColor = NeedlemanRichTextBox.ForeColor;
                    }
                    if (i < input2.Length)
                    {
                        NeedlemanRichTextBox.SelectionStart = NeedlemanRichTextBox.TextLength;
                        NeedlemanRichTextBox.SelectionLength = 1;
                        NeedlemanRichTextBox.SelectionColor = Color.Red;
                        NeedlemanRichTextBox.AppendText(input2[i].ToString());
                        NeedlemanRichTextBox.SelectionColor = NeedlemanRichTextBox.ForeColor;
                    }
                    NeedlemanRichTextBox.AppendText("\n");
                }
                else
                {
                    // If one of the strings is shorter, add the remaining characters to the RichTextBox with a blue color
                    if (i < input1.Length)
                    {
                        NeedlemanRichTextBox.SelectionStart = NeedlemanRichTextBox.TextLength;
                        NeedlemanRichTextBox.SelectionLength = 1;
                        NeedlemanRichTextBox.SelectionColor = Color.Blue;
                        NeedlemanRichTextBox.AppendText(input1[i].ToString());
                        NeedlemanRichTextBox.SelectionColor = NeedlemanRichTextBox.ForeColor;
                    }
                    if (i < input2.Length)
                    {
                        NeedlemanRichTextBox.SelectionStart = NeedlemanRichTextBox.TextLength;
                        NeedlemanRichTextBox.SelectionLength = 1;
                        NeedlemanRichTextBox.SelectionColor = Color.Blue;
                        NeedlemanRichTextBox.AppendText(input2[i].ToString());
                        NeedlemanRichTextBox.SelectionColor = NeedlemanRichTextBox.ForeColor;
                    }
                    NeedlemanRichTextBox.AppendText("-" + "\n");
                }
            }
        }

        private void HuntAlignment_Click(object sender, EventArgs e)
        {
            // Get the input strings and the pattern
            string input1 = HunttextBox1.Text;
            string input2 = HunttextBox2.Text;

            // Clear the RichTextBox
            HuntrichTextBox.Clear();

            // Iterate over the characters in the input strings
            for (int i = 0; i < Math.Max(input1.Length, input2.Length); i++)
            {
                // Check if the characters at the current position match
                if (i < input1.Length && i < input2.Length && input1[i] == input2[i])
                {
                    if (i < input1.Length)
                    {
                        // If they match, add them to the RichTextBox with a green color
                        HuntrichTextBox.SelectionStart = HuntrichTextBox.TextLength;
                        HuntrichTextBox.SelectionLength = 1;
                        HuntrichTextBox.SelectionColor = Color.Green;
                        HuntrichTextBox.AppendText(input1[i].ToString());
                        HuntrichTextBox.SelectionColor = HuntrichTextBox.ForeColor;
                    }
                    if (i < input2.Length)
                    {
                        HuntrichTextBox.SelectionStart = HuntrichTextBox.TextLength;
                        HuntrichTextBox.SelectionLength = 1;
                        HuntrichTextBox.SelectionColor = Color.Green;
                        HuntrichTextBox.AppendText(input2[i].ToString());
                        HuntrichTextBox.SelectionColor = HuntrichTextBox.ForeColor;
                    }
                    HuntrichTextBox.AppendText("\n");
                }
                else if (i < input1.Length && i < input2.Length && input1[i] != input2[i])
                {
                    // If they do not match, add them to the RichTextBox with a red color
                    if (i < input1.Length)
                    {
                        HuntrichTextBox.SelectionStart = HuntrichTextBox.TextLength;
                        HuntrichTextBox.SelectionLength = 1;
                        HuntrichTextBox.SelectionColor = Color.Red;
                        HuntrichTextBox.AppendText(input1[i].ToString());
                        HuntrichTextBox.SelectionColor = HuntrichTextBox.ForeColor;
                    }
                    if (i < input2.Length)
                    {
                        HuntrichTextBox.SelectionStart = HuntrichTextBox.TextLength;
                        HuntrichTextBox.SelectionLength = 1;
                        HuntrichTextBox.SelectionColor = Color.Red;
                        HuntrichTextBox.AppendText(input2[i].ToString());
                        HuntrichTextBox.SelectionColor = HuntrichTextBox.ForeColor;
                    }
                    HuntrichTextBox.AppendText("\n");
                }
                else
                {
                    // If one of the strings is shorter, add the remaining characters to the RichTextBox with a blue color
                    if (i < input1.Length)
                    {
                        HuntrichTextBox.SelectionStart = HuntrichTextBox.TextLength;
                        HuntrichTextBox.SelectionLength = 1;
                        HuntrichTextBox.SelectionColor = Color.Blue;
                        HuntrichTextBox.AppendText(input1[i].ToString());
                        HuntrichTextBox.SelectionColor = HuntrichTextBox.ForeColor;
                    }
                    if (i < input2.Length)
                    {
                        HuntrichTextBox.SelectionStart = HuntrichTextBox.TextLength;
                        HuntrichTextBox.SelectionLength = 1;
                        HuntrichTextBox.SelectionColor = Color.Blue;
                        HuntrichTextBox.AppendText(input2[i].ToString());
                        HuntrichTextBox.SelectionColor = HuntrichTextBox.ForeColor;
                    }
                    HuntrichTextBox.AppendText("-" + "\n");
                }
            }
        }

        private void SearchKnuth_Click(object sender, EventArgs e)
        {
            Knuth_Morris_Pratt kmp = new Knuth_Morris_Pratt();

            string[] words = KnuthtextBox.Text.Split(',');
            foreach (string word in words)
            {
                int startIndex = 0;
                while (startIndex < KnuthrichTextBox.TextLength)
                {
                    int index = kmp.KMPSearch(word, KnuthrichTextBox.Text, startIndex);
                    if (index != -1)
                    {
                        KnuthrichTextBox.SelectionStart = index;
                        KnuthrichTextBox.SelectionLength = word.Length;
                        KnuthrichTextBox.SelectionColor = Color.Yellow;
                    }
                    else
                        break;
                    startIndex += index + word.Length;
                }
            }
        }

        private void SearchHorspool_Click(object sender, EventArgs e)
        {
            Horspool h = new Horspool();

            string[] words = HorspooltextBox.Text.Split(',');
            foreach (string word in words)
            {
                int startIndex = 0;
                while (startIndex < HorspoolrichTextBox.TextLength)
                {
                    int index = h.ShiftMyTable(word, HorspoolrichTextBox.Text, startIndex);
                    if (index != -1)
                    {
                        HorspoolrichTextBox.SelectionStart = index;
                        HorspoolrichTextBox.SelectionLength = word.Length;
                        HorspoolrichTextBox.SelectionColor = Color.Yellow;
                    }
                    else
                        break;
                    startIndex += index + word.Length;
                }
            }
        }

        private void SearchBoyer_Click(object sender, EventArgs e)
        {
            Horspool h = new Horspool();

            string[] words = BoyertextBox.Text.Split(',');
            foreach (string word in words)
            {
                int startIndex = 0;
                while (startIndex < BoyerrichTextBox.TextLength)
                {
                    int index = h.ShiftMyTable(word, BoyerrichTextBox.Text, startIndex);
                    if (index != -1)
                    {
                        BoyerrichTextBox.SelectionStart = index;
                        BoyerrichTextBox.SelectionLength = word.Length;
                        BoyerrichTextBox.SelectionColor = Color.Yellow;
                    }
                    else
                        break;
                    startIndex += index + word.Length;
                }
            }
        }

        private void InsertTrie_Click(object sender, EventArgs e)
        {
            string paraf = textBox1.Text;
            char[] white = new char[] { ' ', ',', '.', '\t' };
            String[] keys = paraf.Split(white);

            TrieAlgorithm.Trie root = new TrieAlgorithm.Trie();

            // Construct trie

            int i;
            for (i = 0; i < keys.Length; i++)
            { 
                richTextBox1.Text = richTextBox1.Text + keys[i] + Environment.NewLine;
                TrieAlgorithm.Trie.Insert(keys[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Trie trie = new Trie();
            string prefix = textBox2.Text;

            // Split the text in the insertRichTextBox into words
            string[] words = richTextBox1.Text.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            richTextBox2.Clear();
            foreach (string word in words)
            {
                if (word.StartsWith(prefix))
                {
                    richTextBox2.AppendText(word + Environment.NewLine);
                }
            }
        }

        private void NeedlemanTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NeedlemanTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int length = 200;

            // Initialize an array of the possible DNA nucleotides
            char[] nucleotides = { 'A', 'C', 'G', 'T' };

            // Generate the random DNA sequence
            string dna = "";
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                dna += nucleotides[rand.Next(4)];
            }

            // Display the DNA sequence in the text box
            NeedlemanTextBox2.Text = dna;
        }

        private void Random1_Click(object sender, EventArgs e)
        {
            int length = 150;

            // Initialize an array of the possible DNA nucleotides
            char[] nucleotides = { 'A', 'C', 'G', 'T' };

            // Generate the random DNA sequence
            string dna = "";
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                dna += nucleotides[rand.Next(4)];
            }

            // Display the DNA sequence in the text box
            NeedlemanTextBox1.Text = dna;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int length = 200;

            // Initialize an array of the possible DNA nucleotides
            char[] nucleotides = { 'A', 'C', 'G', 'T' };

            // Generate the random DNA sequence
            string dna = "";
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                dna += nucleotides[rand.Next(4)];
            }

            // Display the DNA sequence in the text box
            SmithtextBox1.Text = dna;
        }

        private void SmithtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Random4_Click(object sender, EventArgs e)
        {
            int length = 150;

            // Initialize an array of the possible DNA nucleotides
            char[] nucleotides = { 'A', 'C', 'G', 'T' };

            // Generate the random DNA sequence
            string dna = "";
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                dna += nucleotides[rand.Next(4)];
            }

            // Display the DNA sequence in the text box
            SmithtextBox2.Text = dna;
        }

        private void Random6_Click(object sender, EventArgs e)
        {
            int length = 200;

            // Initialize an array of the possible DNA nucleotides
            char[] nucleotides = { 'A', 'C', 'G', 'T' };

            // Generate the random DNA sequence
            string dna = "";
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                dna += nucleotides[rand.Next(4)];
            }

            // Display the DNA sequence in the text box
            HunttextBox1.Text = dna;
        }

        private void HunttextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Random7_Click(object sender, EventArgs e)
        {
            int length = 150;

            // Initialize an array of the possible DNA nucleotides
            char[] nucleotides = { 'A', 'C', 'G', 'T' };

            // Generate the random DNA sequence
            string dna = "";
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                dna += nucleotides[rand.Next(4)];
            }

            // Display the DNA sequence in the text box
            HunttextBox2.Text = dna;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int rand_num = rd.Next(0, 200);
            string keys = "Lorem Ipsum simply dummy text printing typesetting industry. Lorem Ipsum been industry's standard dummy text ever since 1500s, when unknown printer took galley type scrambled make type specimen book. survived only five centuries, also leap into electronic typesetting, remaining essentially unchanged. popularised 1960s with release Letraset sheets containing Lorem Ipsum passages, more recently with desktop publishing software like Aldus PageMaker including versions Lorem Ipsum." +
                "long established fact that reader will distracted readable content page when looking layout. point using Lorem Ipsum that normal distribution letters, opposed using 'Content here, content here', making look like readable English. Many desktop publishing packages page editors Lorem Ipsum their default model text, search 'lorem ipsum' will uncover many sites still their infancy. Various versions have evolved over years, sometimes accident, sometimes purpose (injected humour and the like)." +
                "Contrary popular belief, Lorem Ipsum simply random text. roots piece classical Latin literature from, making over years. Richard McClintock, Latin professor Hampden-Sydney College Virginia, looked more obscure Latin words, consectetur, from Lorem Ipsum passage, going through cites word classical literature, discovered undoubtable source. Lorem Ipsum comes from sections Finibus Bonorum Malorum (The Extremes Good Evil) Cicero, written This book treatise theory ethics, very popular during Renaissance. first line Lorem Ipsum," +
                "There many variations passages Lorem Ipsum available, majority have suffered alteration " +
                "some form, injected humour, randomised words which don't look even slightly believable. " +
                "going passage Lorem Ipsum, need sure there isn't anything embarrassing hidden " +
                "middle text. Lorem Ipsum generators Internet tend repeat predefined chunks " +
                "necessary, making this first true generator Internet. uses dictionary over 200 Latin words," +
                " combined with handful model sentence structures, generate Lorem Ipsum which looks reasonable. " +
                " generated Lorem Ipsum therefore always free from repetition, injected humour, non-characteristic words.";

            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

            string[] arrkeys = keys.Split(delimiterChars);

            textBox1.Text = arrkeys[rand_num];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

