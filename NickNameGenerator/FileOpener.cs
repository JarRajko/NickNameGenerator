using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickNameGenerator
{
    public class FileOpener
    {
        private string[] _nouns;

        public FileOpener(string path) 
        {

            if (File.Exists(path))
            {
                string[] nouns = File.ReadAllLines(path);
                _nouns = nouns;

            }
            else
            {
                MessageBox.Show("File not found!","Error");
            }

        }


        public string[] getNouns()
        {
            return _nouns;
        }
    }
}
