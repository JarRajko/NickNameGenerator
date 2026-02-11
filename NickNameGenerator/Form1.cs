namespace NickNameGenerator
{
    public partial class Form1 : Form
    {

        private string[] _nouns;

        public Form1()
        {
            InitializeComponent();
            FileOpener fp = new FileOpener("nouns.txt");
            _nouns = fp.getNouns();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string name = _nouns[rand.Next(_nouns.Length)];
            textBoxNouns.Text = name;
        }
    }




}
