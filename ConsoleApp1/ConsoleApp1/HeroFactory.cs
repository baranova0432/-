using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;


namespace ConsoleApp1
{

    public interface IHeroFactory
    {
        Wand CreateWand();
        Patronus CreatePatronus();
        string CreateName();
    }

    public class Patronus
    {
        public virtual string patronus { get; set; }

        public Patronus(string patronus)
        {
            this.patronus = patronus;
        }

        public override string ToString()
        {
                return $"Патронус: {patronus.ToString()}.";
        }
    }

    public class Wand
    {
        public virtual string wand { get; set; }

        public Wand(string wand)
        {
            this.wand = wand;
        }

        public override string ToString()
        {
            return $"Палочка: {wand.ToString()}.";
        }
    }

    class Griffindor : IHeroFactory
    {
        public string CreateName()
        {
            Console.Clear();
            Console.WriteLine("Введите имя: \t");
            string name = Console.ReadLine();
            return name;
        }

        public Wand CreateWand()
        {
            return new Wand("Дуб");
        }

        public Patronus CreatePatronus()
        {
            return new Patronus("Лев");
        }

    }

    class Slytherin : IHeroFactory
    {
        public string CreateName()
        {
            Console.Clear();
            Console.WriteLine("Введите имя: \t");
            string name = Console.ReadLine();
            return name;
        }

        public Wand CreateWand()
        {
            return new Wand("Ольха");
        }

        public Patronus CreatePatronus()
        {
            return new Patronus("Змея");
        }
    }

    class Ravenclaw : IHeroFactory
    {
        public string CreateName()
        {
            Console.Clear();
            Console.WriteLine("Введите имя: \t");
            string name = Console.ReadLine();
            return name;
        }

        public Wand CreateWand()
        {
            return new Wand("Клен");
        }

        public Patronus CreatePatronus()
        {
            return new Patronus("Орел");
        }
    }
    class HufflePuff : IHeroFactory
    {
        public string CreateName()
        {
            Console.Clear();
            Console.WriteLine("Введите имя: \t");
            string name = Console.ReadLine();
            return name;
        }

        public Wand CreateWand()
        {
            return new Wand("Бук");
        }

        public Patronus CreatePatronus()
        {
            return new Patronus("Барсук");
        }
    }
}