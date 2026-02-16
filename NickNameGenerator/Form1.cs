using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace NickNameGenerator
{
    public partial class Form1 : Form
    {

        private string[] _nouns;
        private string[] _adjectives;
        private string[] _prefixes;
        private string[] _postfixes;

        private string _baseNoun = "";

        public Form1()
        {
            InitializeComponent();
            FileOpener fp = new FileOpener();
            _nouns = fp.getWordsFromTextFile("nouns.txt");
            _adjectives = fp.getWordsFromTextFile("adjectives.txt");
            _prefixes = fp.getWordsFromTextFile("Prefixes.txt");
            _postfixes = fp.getWordsFromTextFile("Postfixes.txt");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            if (_nouns != null && _nouns.Length > 0)
            {
                _baseNoun = _nouns[rand.Next(_nouns.Length)];
                labelText.Text = _baseNoun;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_baseNoun))
            {
                MessageBox.Show("Generate base name first!");
                return;
            }

            Random rand = new Random();
            string finalNickname = _baseNoun;

            if (checkBoxAdjective.Checked && _adjectives.Length > 0)
            {
                string adj = _adjectives[rand.Next(_adjectives.Length)];
                finalNickname = adj + " " + finalNickname;
            }

            if (checkBoxPrefix.Checked && _prefixes.Length > 0)
            {
                string pre = _prefixes[rand.Next(_prefixes.Length)];
                finalNickname = pre + " " + finalNickname;
            }

            if (checkBoxPostfix.Checked && _postfixes.Length > 0)
            {
                string post = _postfixes[rand.Next(_postfixes.Length)];
                finalNickname = finalNickname + " " + post;
            }

            labelText.Text = finalNickname;
        }

        private void labelText_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxAdjective_CheckedChanged(object sender, EventArgs e)
        {
           
           
        }
    }

   


}
