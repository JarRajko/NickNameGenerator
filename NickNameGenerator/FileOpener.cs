using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickNameGenerator
{
    public class FileOpener
    {

        public string[] getWordsFromTextFile(string path)
        {
            if (File.Exists(path))
            {
                string[] nouns = File.ReadAllLines(path);
                return nouns;
            }
            else
            {
                MessageBox.Show("File not found!", "Error");
                Environment.Exit(1);
                return null;
            }
        }
    }
}
