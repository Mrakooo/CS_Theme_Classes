using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Theme_Classes
{
    internal class ListStudent
    {
        public ListStudent()
        {
            List = new List<Student>();
        }

        public void Add(Student human)
        {
            List.Add(human);
        }
        public void Show()
        {
            for (int n = 0; n < List.Count; n++)
                List[n].printInfo();
        }
        public List<Student> List { get; set; }
        public void SaveStudent_json()
        {
            const string fileName = "Student.json";
            string jsonString = JsonSerializer.Serialize(this.List);
            File.WriteAllText(fileName, jsonString);

            Console.WriteLine(jsonString);
        }


        public string StudentTxt()
        {
            string res = "";
            for(int n = 0; n < List.Count; n++)
            {
                res += List[n].toStr();
                res += "\n" + "-=-=-=-=-=-=-=-=-=-=-=-=-=-" + "\n";
            }

            return res;
        }

        public void TextWritter(string url)
        {
            StreamWriter sw = new StreamWriter(url);
            sw.WriteLine(StudentTxt());
            sw.Close();
        }

    }
}
