using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    class MainMenuCreator
    {
        int selectedMenu;

        public void MainMenu()
        {
            List<Common.ISearcher> listOfSearchMethods = new List<Common.ISearcher>();
            listOfSearchMethods.Add(new SimpleTextSearchLibrary.SimpleSearch());
            listOfSearchMethods.Add(new SpecialTextSearchLibrary.SpecialSearch());
            //SimpleTextSearchLibrary.SimpleSearch simpleSearch = new SimpleTextSearchLibrary.SimpleSearch();
            //SpecialTextSearchLibrary.SpecialSearch specialSearch = new SpecialTextSearchLibrary.SpecialSearch();
            do
            {
                Console.WriteLine(
                "Press key '1' to get information about all the methods of searching the string in the file.\n" +
                "Press key '2' for searching string in the file\n" +
                "Press key '3' for exit"
                );
                if (int.TryParse(Console.ReadLine(), out selectedMenu))
                {
                    switch (selectedMenu)
                    {
                        case 1:
                            listOfSearchMethods.ForEach(
                                searchMethod => Console.WriteLine(searchMethod.AboutSearchMethod() + "\n"));
                            Console.WriteLine("\n\n\n");
                            break;
                        case 2:
                            Console.WriteLine("write some string:");
                            string word = Console.ReadLine();
                            List<Task<Common.ISearcher>> searchTasksList = new List<Task<Common.ISearcher>>();
                            foreach (var searchMethod in listOfSearchMethods)
                            {
                                searchTasksList.Add(new Task<Common.ISearcher>(
                                        () => searchMethod.Search(word, new File().getStreamReader("../../Files/text.txt"))));
                            }
                            
                            foreach (var t in searchTasksList)
                                t.Start();
                            Task.WaitAll(searchTasksList.ToArray());
                            foreach (var t in searchTasksList)
                            {
                                Console.WriteLine();
                                Console.WriteLine(t.Result.MethodName + " Version: v." + t.Result.Version);
                                Console.WriteLine("Found: " + t.Result.Result);
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            break;
                        default:
                            Console.Clear();
                            break;
                    }
                }
            } while (selectedMenu != 3);

        }
    }

    
}
