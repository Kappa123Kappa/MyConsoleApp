using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace SimpleTextSearchLibrary
{
    public class SimpleSearch : Common.ISearcher
    {
        private string methodName = "SimpleSearch";

        private string version = "1.0";

        public string Version
        {
            get { return version; }
            set { version = value; }
        }

        public string Result { get; set; }

        public string MethodName
        {
            get { return methodName; }
            set { methodName = value; }
        }

        public string AboutSearchMethod()
        {
            return MethodName + "; current version: " + Version + ";\n" +
                "This is a simple search method that looks for a string in the text that is identical " +
                "to the pre-entered string, based on its register and all characters.";
        }

        public ISearcher Search(string word, StreamReader streamReader)
        {
            string line;
            StringBuilder lineWithString;
            while ((line = streamReader.ReadLine()) != null)
            {
                int firstIndexOfSubstring = line.IndexOf(word);
                if (firstIndexOfSubstring != -1)
                {
                    Result = line;
                    return this;
                }
            }
            Result = "Method didin't find this string";
            return this;
        }
    }
}
