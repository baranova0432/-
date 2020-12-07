using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mlab9
{
    public delegate void DelH (int power);
    public delegate void DelA (int damage);
    public delegate void DelMessage(string message);
   public class Game
    {
        public int health;
        public int maxhealth;
        public string name;

        public Game(string name, int health)
        {
            this.name = name;
            this.health = health;
            maxhealth = health;
        }

        public event DelH HealEvent;
        public event DelA AttackEvent;
        public event DelMessage MessageEvent;
        public void Attack(int damage)
        {
            if (health - damage > 0)
            { health -= damage;
                MessageEvent?.Invoke($"Damage for: {damage} {this.name}");
            }
            else
            {
                health = 0;
                MessageEvent?.Invoke($"Object {this.name} is dead");
            }
                             
        }
        public void Heal(int power)
        {
            if (health + power < maxhealth)
            {
                health += power;
                MessageEvent?.Invoke($"Health restored (НР - {health})+{this.name}`y");
            }
            else
            {
                health = maxhealth;
                MessageEvent?.Invoke($"Health is fully restored(НР - {health}){this.name} ");
            }
        }



        

    }
}
