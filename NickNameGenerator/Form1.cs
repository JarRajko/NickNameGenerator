namespace NickNameGenerator
{
    public partial class Form1 : Form
    {

        private string[] _nouns;
        private string[] _adjectives;
        private string[] _prefixes;
        private string[] _postfixes;


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
            string noun = _nouns[rand.Next(_nouns.Length)];
            string adjective = _nouns[rand.Next(_adjectives.Length)];
            string prefix = _prefixes[rand.Next(_prefixes.Length)];
            string postfix = _postfixes[rand.Next(_postfixes.Length)];

            string nickname = noun;


            if (checkBoxPrefix.Checked)
            {
                nickname = prefix + " " + nickname;
            }

            if (checkBoxAdjective.Checked)
            {
                nickname = adjective + " " + nickname;
            }

            if (checkBoxPostfix.Checked)
            {
                nickname = nickname + " " +  postfix;
            }

            labelText.Text = nickname;
        }
    }




}
