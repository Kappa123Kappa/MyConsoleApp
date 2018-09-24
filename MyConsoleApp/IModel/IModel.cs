using Common;
using System.Collections.Generic;

namespace IModels
{
    public interface IModel
    {
        List<ISearcher> listOfSearchers { get; set; }
        List<ISearcher> getSearchers();
    }
}
