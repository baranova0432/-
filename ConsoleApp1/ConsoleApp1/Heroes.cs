using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [Serializable]
    class Hero : Prototype<Hero>
    {
        public virtual string Name { get; set; }
        public virtual Wand wand { get; set; }
        public virtual Patronus patronus { get; set; }

        public Hero() { }
        public Hero(IHeroFactory factory)
        {
            Name = factory.CreateName();
            wand = factory.CreateWand();
            patronus = factory.CreatePatronus();
        }

        public override string ToString()
        {
            return $"{wand.ToString()} {patronus.ToString()}";
        }
    }
}
