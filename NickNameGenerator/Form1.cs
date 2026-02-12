namespace NickNameGenerator
{
    public partial class Form1 : Form
    {

        private string[] _nouns;
        private string[] _adjectives;


        public Form1()
        {
            InitializeComponent();
            FileOpener fp = new FileOpener();
            _nouns = fp.getWordsFromTextFile("nouns.txt");
            _adjectives = fp.getWordsFromTextFile("adjectives.txt");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string noun = _nouns[rand.Next(_nouns.Length)];
            string adjective = _nouns[rand.Next(_adjectives.Length)];
            textBoxNouns.Text = adjective + " " + noun;
        }
    }




}
