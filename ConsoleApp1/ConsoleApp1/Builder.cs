using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // абстрактный класс строителя
    abstract class AbstractHeroBuilder
    {
        public Hero Hero { get; private set; }

        public void CreateHero()
        {
            Hero = new Hero();
        }
        public abstract void SetName();
        public abstract void SetWand();
        public abstract void SetPatronus();
    }
   
    class Director
    {
        public Hero Make(AbstractHeroBuilder heroBuilder)
        {
            heroBuilder.CreateHero();
            heroBuilder.SetName();
            heroBuilder.SetWand();
            heroBuilder.SetPatronus();
            return heroBuilder.Hero;
        }
    }
    
    class HeroBuilder : AbstractHeroBuilder
    {

        public override void SetName()
        {
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            this.Hero.Name = name;
        }

        public override void SetWand()
        {
            Console.WriteLine("Введите оружие:");
            string wand = Console.ReadLine();
            this.Hero.wand = new Wand(wand);
        }

        public override void SetPatronus()
        {
            Console.WriteLine("Введите количество брони:");
            string patronus = Console.ReadLine();
            this.Hero.patronus = new Patronus(patronus);
        }
    }
}
