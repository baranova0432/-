using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        class MainPerson
        {
            private static MainPerson instance;
            public string Name { get; private set; }
            protected MainPerson(string name)
            {
                Name = name;
            }

            public static MainPerson getInstance(string name)
            {
                if (instance == null)
                    instance = new MainPerson(name);
                return instance;
            }
        }
        class MHero
        {
            public MainPerson MainPerson { get; set; }
            public void Create(string personname)
            {
                MainPerson = MainPerson.getInstance(personname);

            }
        }



}

