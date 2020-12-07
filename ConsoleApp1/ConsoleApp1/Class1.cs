using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
            static class Menu
            {
                public static SchoolH schoolH = new SchoolH();

                //Гланое меню
                public static void MainMenu()
                {
                    Console.WriteLine("Назовите своего персонажа:\n");
                    MHero hero = new MHero();
                    hero.Create(Console.ReadLine());
                    Console.WriteLine($"Персонаж {hero.MainPerson.Name} успешно создан");
     
                    //Console.Clear();
                    Console.WriteLine("1 - Сделать героя");
                    Console.WriteLine("2 - Показать всех героев");
                    Console.WriteLine("3 - Найти героя");
                    Console.WriteLine("4 -  Выйти");
                    Console.WriteLine("Выберите действие: \t");
                    switch (GetCommand())
                    {
                        case 1:
                            schoolH.AddComponent(new Adapter(MakeHeroMenu()));
                            break;
                        case 2:
                            schoolH.ShowHero();
                            break;
                        case 3:
                            {
                                Console.WriteLine("Введите имя героя: ");
                                string name = Console.ReadLine();
                                schoolH.Find(name);
                            }
                            break;
                        case 4:
                    //MoveHero();
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                }

                //Cоздание героя
                public static Hero MakeHeroMenu()
                {
                    Console.Clear();
                    Director creator = new Director();
                    AbstractHeroBuilder builder = new HeroBuilder();
                    Console.WriteLine("1 - Сделать героя с помощью Builder");
                    Console.WriteLine("2 - Сделать героя с помощью Abstract Factory");
                    Console.WriteLine("Выберите действие: \t");
                    switch (GetCommand())
                    {
                        case 1:
                            Hero hero = creator.Make(builder);
                            Console.WriteLine(hero.ToString());
                            return hero;
                        case 2:
                            return MakeHeroAbstractMenu();
                default:
                            break;
                    }
                    return null;
                }

                //Создание героя с помощью Abstract Factory
                public static Hero MakeHeroAbstractMenu()
                {
                    Console.Clear();
                    Console.WriteLine("1 - Сделать гриффиндорца");
                    Console.WriteLine("2 - Сделать пуффендуйца");
                    Console.WriteLine("3 - Сделать слизеринца");
                    Console.WriteLine("4 - Сделать когтевранца");
                    Console.WriteLine("Выберите действие: \t");
                    switch (GetCommand())
                    {
                        case 1:
                            Hero person = new Hero(new Griffindor());
                            return person;
                        case 2:
                            Hero person1 = new Hero(new HufflePuff());
                            return person1;
                        case 3:
                            Hero person2 = new Hero(new Slytherin());
                            return person2;
                        case 4:
                            Hero person3 = new Hero(new Ravenclaw());
                            return person3;
                        default:
                            break;
                    }
                    return null;
                }

                

                public static int GetCommand()
                {
                    int count;
                    while (!int.TryParse(Console.ReadLine(), out count))
                    {
                        Console.WriteLine("Ошибка ввода! Введите целое число!!!");
                    }
                    return count;
                }
            }
        }
    
