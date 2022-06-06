using SimpleSongs.View.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSongs.View
{
    public class MenuDisplay : IMenuDisplay
    {
        public void ClearScreen()
        {
            Console.Clear();
        }

        public void PrintAndWaitForKey(string content)
        {
            Console.WriteLine("\n\t" +content);
            Console.ReadKey();
        }

        public void PrintMany<T>(List<T> entities)
        {
            foreach (var item in entities)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintMessage(string content)
        {
            Console.WriteLine("\n\t" +content);
        }

        public void PrintIntro()
        {
            Console.WriteLine(" \t\tWelcome to:\n");
            Console.WriteLine(@" _______ _________ _______  _______  _        _______ 
(  ____ \\__   __/(       )(  ____ )( \      (  ____ \
| (    \/   ) (   | () () || (    )|| (      | (    \/
| (_____    | |   | || || || (____)|| |      | (__    
(_____  )   | |   | |(_)| ||  _____)| |      |  __)   
      ) |   | |   | |   | || (      | |      | (      
/\____) |___) (___| )   ( || )      | (____/\| (____/\
\_______)\_______/|/     \||/       (_______/(_______/
                                                      
 _______  _______  _        _______  _______ 
(  ____ \(  ___  )( (    /|(  ____ \(  ____ \
| (    \/| (   ) ||  \  ( || (    \/| (    \/
| (_____ | |   | ||   \ | || |      | (_____ 
(_____  )| |   | || (\ \) || | ____ (_____  )
      ) || |   | || | \   || | \_  )      ) |
/\____) || (___) || )  \  || (___) |/\____) |
\_______)(_______)|/    )_)(_______)\_______)");
            PrintAndWaitForKey("\n\t\tPress any key to continue");
        }
    }
}
