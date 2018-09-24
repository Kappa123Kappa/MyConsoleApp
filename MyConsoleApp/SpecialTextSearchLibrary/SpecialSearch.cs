using Common;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace SpecialTextSearchLibrary
{
    public class SpecialSearch : ISearcher
    {
        private string _methodName = "SpecialSearch";

        private string _version = "1.0";

        public string Version
        {
            get { return _version; }
            set { _version = value; }
        }

        public string Result { get; set; } = "-";

        public string MethodName
        {
            get { return _methodName; }
            set { _methodName = value; }
        }


        /// <summary>
        /// Search method which looks for a string without its register and all spaces
        /// </summary>
        public ISearcher Search(string word, StreamReader streamReader)
        {
            string line = "";
            while (streamReader.ReadLine() != null)
            {
                line = streamReader.ReadLine();
                string tempLine = streamReader.ReadLine();
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

        /// <summary>
        /// Method returns its description 
        /// </summary>
        public string AboutSearchMethod()
        {
            return MethodName + "; current version: " + Version + ";\n" +
                "This is a special search method that looks for a string in the text to the pre-entered string, " +
                "with ignoring register and spaces between characters.";
        }
    }
}
