using Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SpecialTextSearchLibrary
{
    public class SpecialSearch : Common.ISearcher
    {
        private string methodName = "SpecialSearch";

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

        public ISearcher Search(string word, StreamReader streamReader)
        {
            string line;
            StringBuilder lineWithString;
            while ((line = streamReader.ReadLine()) != null)
            {
                string tempLine = line.ToUpper();
                RegexOptions options = RegexOptions.None;
                Regex regex = new Regex("[ ]{2,}", options);
                tempLine = regex.Replace(tempLine, " ");
                int firstIndexOfSubstring = tempLine.IndexOf(regex.Replace(word.ToUpper(), " "));
                if (firstIndexOfSubstring != -1)
                {
                    Result = line;
                    return this;
                }
            }
            Result = "Method didin't find this string";
            return this;
        }

        public string AboutSearchMethod()
        {
            return MethodName + "; current version: " + Version + ";\n" +
                "This is a special search method that looks for a string in the text to the pre-entered string, " +
                "with ignoring register and spaces between characters.";
        }
    }
}
