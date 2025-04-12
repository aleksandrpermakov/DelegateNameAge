using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateNameAge
{
    internal class Program
    {
        delegate void processing(string name,string age);
        static void Print(string n, string a)
        {
            Console.WriteLine($"Привет {n} проживжий(ая) { a} лет");
        }
        static void WriteToFile(string name, string age)
        {
            StreamWriter sr = new StreamWriter("out.txt", true);
            sr.Write($"Привет {name} проживжий(ая) {age} лет \n");
            sr.Close();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Здраствуйте, введите свое имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите свой возраст:");
            string age = Console.ReadLine();
            Console.WriteLine("Если нужно ввести приветствие на экран нажмите 1:");
            Console.WriteLine("Если нужно ввести приветствие на экран и дописать в фаил нажмите 2:");
            Console.WriteLine("Если нужно дописать приветствие в фаил нажмите 3:");
            int conclusion;
            int.TryParse (Console.ReadLine(),out conclusion);
            
            if (conclusion == 1)
            {
                processing withdrawt_ = Print;
                withdrawt_(name, age);
            }
            else if (conclusion == 2)
            {
                processing withdrawt_ = Print;
                withdrawt_ += WriteToFile;
                withdrawt_(name, age);
            }
            else if (conclusion == 3)
            {
                processing withdrawt_ = WriteToFile;
                withdrawt_(name, age);
            }


        }
    }
}
