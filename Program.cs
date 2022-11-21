using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write(" Как Вас зовут? ");
            name = Convert.ToString(Console.ReadLine());
            int age;
            Console.Write(" Сколько Вам лет? ");
            age = Convert.ToInt32(Console.ReadLine());
            string sign;
            Console.Write(" Кто Вы по знаку зодиака? ");
            sign = Convert.ToString(Console.ReadLine());
            string work;
            Console.Write(" Где Вы работаете? ");
            work = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" Вас зовут " + name + ',' + " Вам " + age + " год " + ',' + " вы " + sign + ',' + " работаете на " + work + '.');
        }
    }
}
