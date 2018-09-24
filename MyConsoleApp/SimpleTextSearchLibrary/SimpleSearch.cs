using Common;
using System.IO;
using System.Text;

namespace SimpleTextSearchLibrary
{
    public class SimpleSearch : ISearcher
    {
        private string _methodName = "SimpleSearch";

        private string _version = "1.0";

        public string Version
        {
            get { return _version; }
            set { _version = value; }
        }

        public string Result { get; set; } = "";

        public string MethodName
        {
            get { return _methodName; }
            set { _methodName = value; }
        }

        /// <summary>
        /// Method returns its description 
        /// </summary>
        public string AboutSearchMethod()
        {
            return MethodName + "; current version: " + Version + ";\n" +
                "This is a simple search method that looks for a string in the text that is identical " +
                "to the pre-entered string, based on its register and all characters.";
        }

        /// <summary>
        /// Search method which looks for a string whith its register and all characters 
        /// </summary>
        public ISearcher Search(string word, StreamReader streamReader)
        {
            string line;
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
