using System;
using System.IO;
using System.Windows.Forms;

namespace NickNameGenerator
{
    public partial class Form1 : Form
    {
        private string[] _nouns;
        private string[] _adjectives;
        private string[] _prefixes;
        private string[] _postfixes;

        private string _baseNoun = "";
        private string _currentAdj = "";
        private string _currentPrefix = "";
        private string _currentPostfix = "";
        private string _currentNumber = "";

        public Form1()
        {
            InitializeComponent();
            FileOpener fp = new FileOpener();
            _nouns = fp.getWordsFromTextFile("nouns.txt");
            _adjectives = fp.getWordsFromTextFile("adjectives.txt");
            _prefixes = fp.getWordsFromTextFile("Prefixes.txt");
            _postfixes = fp.getWordsFromTextFile("Postfixes.txt");
        }

        private void UpdateLabel()
        {
            string baseToDisplay = _baseNoun;

            if (numerizeCheckbox.Checked)
            {
                baseToDisplay = ApplyNumberize(baseToDisplay);
            }

            string final = baseToDisplay;

            if (checkBoxAdjective.Checked) final = _currentAdj + " " + final;
            if (checkBoxPrefix.Checked) final = _currentPrefix + final;
            if (checkBoxPostfix.Checked) final = final + _currentPostfix;
            if (checkBoxNumber.Checked) final = final + _currentNumber;

            labelText.Text = final.Trim();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            if (_nouns != null && _nouns.Length > 0)
            {
                _baseNoun = _nouns[rand.Next(_nouns.Length)];
                UpdateLabel();
            }
        }

        private void emptyMessageBox()
        {
            MessageBox.Show("Generate base name first!");
        }

        private void adjectiveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_baseNoun)) { emptyMessageBox(); return; }

            Random rand = new Random();
            _currentAdj = _adjectives[rand.Next(_adjectives.Length)];
            UpdateLabel();
        }

        private void prefixButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_baseNoun)) { emptyMessageBox(); return; }

            Random rand = new Random();
            _currentPrefix = _prefixes[rand.Next(_prefixes.Length)] + " ";
            UpdateLabel();
        }

        private void postfixButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_baseNoun)) { emptyMessageBox(); return; }

            Random rand = new Random();
            _currentPostfix = _postfixes[rand.Next(_postfixes.Length)];
            UpdateLabel();
        }

        private void numberButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_baseNoun)) { emptyMessageBox(); return; }

            Random rand = new Random();
            _currentNumber = rand.Next(10, 999).ToString();
            UpdateLabel();
        }

        private void checkBoxAdjective_CheckedChanged(object sender, EventArgs e) { UpdateLabel(); }
        private void checkBoxPrefix_CheckedChanged(object sender, EventArgs e) { UpdateLabel(); }
        private void checkBoxPostfix_CheckedChanged(object sender, EventArgs e) { UpdateLabel(); }
        private void checkBoxNumber_CheckedChanged(object sender, EventArgs e) { UpdateLabel(); }

        private void numberizeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_baseNoun)) { emptyMessageBox(); return; }

            numerizeCheckbox.Checked = !numerizeCheckbox.Checked;
            UpdateLabel();
        }

        private string ApplyNumberize(string input)
        {
            return input.Replace("i", "1").Replace("I", "1")
                        .Replace("s", "5").Replace("S", "5")
                        .Replace("e", "3").Replace("E", "3")
                        .Replace("a", "4").Replace("A", "4")
                        .Replace("o", "0").Replace("O", "0");
        }


        private void numerizeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if (labelText.Text != "")
            {
                Clipboard.SetText(labelText.Text);
                MessageBox.Show("Text \"" + labelText.Text + "\" copied succesfully!", "Success");
            }
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
            char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 't', 'v', 'w', 'x', 'z' };

            Random rand = new Random();
            _baseNoun = "";
            for (int i = 0; i < lengthTrackBar.Value; i++)
            {
                if (i % 2 == 0)
                    _baseNoun += consonants[rand.Next(consonants.Length)];
                else
                    _baseNoun += vowels[rand.Next(vowels.Length)];
            }
            UpdateLabel();
        }

        private void lengthTrackBar_Scroll(object sender, EventArgs e)
        {
            label1.Text = "Nickname length" + " " + lengthTrackBar.Value;
        }
    }
}