using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface ISearcher
    {
        string MethodName { get; set; }

        string Version { get; set; }

        ISearcher Search(string word, StreamReader streamReader);

        string Result { get; set; }

        string AboutSearchMethod();
    }
}
