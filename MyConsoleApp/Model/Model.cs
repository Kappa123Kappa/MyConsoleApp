using Common;
using IModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Models
{
    public class Model : IModel
    {
        private static Model _model;

        public List<ISearcher> listOfSearchers { get; set; }

        public static Model getModel()
        {
            if (_model == null)
                _model = new Model();
            return _model;
        }

        public List<ISearcher> getSearchers()
        {
            return loadSearchers();
        }

        private List<ISearcher> loadSearchers()
        {
            List<ISearcher> listOfSearchers = new List<ISearcher>();

            string[] files = Directory.GetFiles(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "*.dll");
            try
            {
                foreach (string file in files)
                {
                    Assembly assembly = Assembly.LoadFrom(Path.GetFullPath(file));
                    foreach (Type type in assembly.GetTypes())
                    {
                        if (type.GetInterfaces().Contains(typeof(ISearcher)))
                        {
                            ISearcher isearcher = (ISearcher)Activator.CreateInstance(type);
                            listOfSearchers.Add(isearcher);
                        }
                    }

                }
            }
            catch(NullReferenceException e)
            {

            }
            
            return listOfSearchers;
        }
    }
}
