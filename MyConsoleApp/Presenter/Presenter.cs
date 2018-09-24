using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using IMainFormsApp;
using IModels;
using Models;

namespace Presenters
{
    public class Presenter
    {
        private IModel _model;
        private IMainForm _mainForm;

        private List<ISearcher> listOfSearchers = new List<ISearcher>();
        private List<string> listSearchersName = new List<string>();

        public Presenter(IMainForm mainForm)
        {
            _mainForm = mainForm;
            loadModel();
            loadSearchers();
        }

        public List<string> getInformationAboutMethods()
        {
            List<string> information = new List<string>();
            foreach (ISearcher searcher in listOfSearchers)
            {
                information.Add(searcher.AboutSearchMethod());
            }
            return information;
        }

        public List<ISearcher> searchString(string word, string pathToFile)
        {
            List<ISearcher> results = new List<ISearcher>();
            foreach (ISearcher searcher in listOfSearchers)
            {
                results.Add(searcher.Search(word, new StreamReader(pathToFile)));
            }
            return results;
        }

        public List<string> getMethodsNames()
        {
            foreach (ISearcher searcher in listOfSearchers)
            {
                listSearchersName.Add(searcher.MethodName);
            }
            return listSearchersName;
        }

        private void loadModel()
        {
           _model = Model.getModel();
        }

        private void loadSearchers()
        {
            listOfSearchers = _model.getSearchers();
        }
    }
}
