using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Theme_Classes
{
    internal class ListTeacher
    {
        public ListTeacher()
        {
            List = new List<Teacher>();
        }

        public void Add(Teacher human)
        {
            List.Add(human);
        }
        public void Show()
        {
            for (int n = 0; n < List.Count; n++)
                List[n].printInfo();
        }
        public List<Teacher> List { get; set; }
        public void SaveTeacher_json()
        {
            const string fileName = "Teachers.json";
            string jsonString = JsonSerializer.Serialize(this.List);
            File.WriteAllText(fileName, jsonString);

            Console.WriteLine(jsonString);
        }


        public string TeacherTxt()
        {
            string res = "";
            for (int n = 0; n < List.Count; n++)
            {
                res += List[n].toStr();
                res += "\n";
            }

            return res;
        }

        public void TextWritter(string url)
        {
            StreamWriter sw = new StreamWriter(url);
            sw.WriteLine(TeacherTxt());
            sw.Close();
        }

        /*
        class listTeacher
        {


            private List<Teacher> list;
            public listTeacher()
            {
                list = new List<Teacher>();
            }

            public void add(Teacher human)
            {
                List.Add(human);
            }
            public void show()
            {
                for (int n = 0; n < list.Count(); n++)
                    List[n].printInfo();
            }
            public List<Teacher> List { get; set; }

            public void Save_json()
            {
                const string fileName = "Teacher.json";
                string jsonString = JsonSerializer.Serialize(this.List);
                File.WriteAllText(fileName, jsonString);
                Console.WriteLine(jsonString);
            }
            */
    }
}
