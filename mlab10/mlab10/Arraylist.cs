using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace mlab10
{
    public class Dif
    {
        public static ArrayList AddRandomItems(ArrayList list)
        {
            Random a = new Random();
            ArrayList newlist = list;
            for (int i = 0; i < 6; i++)
            {
               int k = a.Next(1, 5);
                newlist.Add(k);
            }
            return newlist;
        }

        public static ArrayList RemoveElem(ArrayList list, int k)
        {
            ArrayList newlist = list;
            newlist.Remove(newlist[k]);
            return newlist;
        }

        public static void FindElem(ArrayList list, int k)
        {
            string message="  ";
            int number=5;
            for(int i = 0; i < 6; i++) {
                if ((int)list[i] == k) { message = "Found one"; number = i+1; } 
            }
            if (message == "  ") { Console.WriteLine("Try again"); }
            else Console.WriteLine(message + " " +number);
        }

    }
    public class Student
    {
       public string Name;
        int Old;
        public Student(string Name, int Old)
        {
            this.Name = Name;
            this.Old = Old;
        }
    }
}
