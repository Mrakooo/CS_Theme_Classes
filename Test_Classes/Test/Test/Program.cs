using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ListStudent listStudent = new ListStudent();

            Student st_one = new Student("Thomas", "Taylor", 20, 1.83, 63, false, Nation.French, new Adress("France", "Paris", "Brovera", 7), 241, 4500);
            Student st_two = new Student("Rita", "Flores", 18, 1.83, 63, false, Nation.French, new Adress("France", "Paris", "Brovera", 7), 221, 5000);
            Student st_three = new Student("Sarah", "Collins", 16, 1.83, 63, false, Nation.French, new Adress("France", "Paris", "Brovera", 7), 261, 5000);
            Student st_four = new Student();

            listStudent.Add(st_one);
            listStudent.Add(st_two);
            listStudent.Add(st_three);
            listStudent.Add(st_four);

            listStudent.Show();

            Console.ReadLine();
        }
    }
}
