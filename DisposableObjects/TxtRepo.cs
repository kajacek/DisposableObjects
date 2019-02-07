using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposableObjects
{
    public class TxtRepo :RepoDisposable
    {
        public string GetTextFromFile(string path)
        {
            string text = File.ReadAllText(path);
            return text;
        }
    }
}
