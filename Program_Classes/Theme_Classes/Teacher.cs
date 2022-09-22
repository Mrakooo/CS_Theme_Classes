using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;
//using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Theme_Classes
{
    public enum KeyWords { csharp, python, java, JS }
    class Teacher : Human
    {
        private int salary;
        private string department;
        private int numofseats;
        private KeyWords keywords;
        private List<Student> list;

        public Teacher() : base()
        {
            list = new List<Student>();
        }
        public Teacher(string name, string surname, int age, double height,
            double weight, bool habbits, string email, Nation nation, Adress adress, int salary, string department, int numofseats, KeyWords keywords) : base(name, surname,
                age, height, weight, habbits, email, nation, adress)
        {
            this.salary = salary;
            this.department = department;
            this.numofseats = numofseats;
            this.keywords = keywords;
            this.list = new List<Student>();
        }

        public void add(Student student)
        {
            if (check_numofset(student.Key.ToString()))
                list.Add(student);
            else
            {
                Console.WriteLine("Мест нет либо интересы не совпадают!");
            }
        }

        public void show()
        {
            for (int n = 0; n < list.Count(); n++)
                list[n].printInfo();
        }

        public override void printInfo()
        {
            string data =
               base.toStr() + "\n" +
               "Salary: " + this.salary.ToString() + "\n" +
               "Money: " + this.department + "\n" +
                "Number of set: " + this.numofseats.ToString() + "\n" +
                "Key: " + this.keywords.ToString();
            Console.WriteLine(data);

        }

        public bool check_numofset(string key)
        {
            bool flag = false;
            if ((list.Count < numofseats) && (key == keywords.ToString()))
                flag = true;
            else
            {
                flag = false;
            }
            return flag;
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public int NumOfSeats
        {
            get { return numofseats; }
            set { numofseats = value; }
        }
        public KeyWords KeyWords
        {
            get { return keywords; }
            set { keywords = value; }
        }
        public List<Student> List
        {
            get { return list; }
            set { list = value; }
        }
    }

}
