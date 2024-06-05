using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_IUnior
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            int programCount;
            int money;
            int time;
            bool truth;

            name = "Исмоил" ;
            age = 25 ;
            programCount = 1 ;
            money = 100000 ;
            time = 10;
            truth = true;

            Console.WriteLine("Здравствуйте, меня зовут " + name + ".");
            Console.WriteLine("Мне " + age + " лет.");
            Console.WriteLine("Я хочу научиться делать игры, это моя " + programCount + " программа на языке C#.");
            Console.WriteLine("Когда я закончу обучение я хочу зарабатывать " + money + " денег в " + time + " наносекунд.");
            Console.WriteLine("Достигну ли я желаемого? " + truth + "!");
            Console.ReadLine();
        }
    }
}
