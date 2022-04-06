using Newtonsoft.Json;
using System;
using System.IO;

namespace _06042022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Programming\CodeAcademy\Work\AzTU\AP203\C#\ClassWorks\AP203_06-06-2022_File-Directory-Serialization\FileDirectorySerialization\06042022\";

            //if (!Directory.Exists(path + "Files"))
            //{
            //    Directory.CreateDirectory(path + "Files");
            //}
            //if(!File.Exists(path + @"Files\database.json"))
            //{
            //    File.Create(path + @"Files\database.json");
            //}

            //Employee employee1 = new Employee()
            //{
            //    Id = 1,
            //    Name = "Allahverdi",
            //    Salary = 750.60
            //};
            //Employee employee2 = new Employee()
            //{
            //    Id = 2,
            //    Name = "Rovshan",
            //    Salary = 760
            //};
            //Employee employee3 = new Employee()
            //{
            //    Id = 3,
            //    Name = "Mushvig",
            //    Salary = 1000.60
            //};

            Department department = new Department()
            {
                Id = 1,
                Name = "Seymir MMC"
            };

            //department.Employees.Add(employee1);
            //department.Employees.Add(employee2);
            //department.Employees.Add(employee3);

            //string departmentJsonStr = JsonConvert.SerializeObject(department);

            //using (StreamWriter sw = new StreamWriter(path + @"Files\database.json"))
            //{
            //    sw.Write(departmentJsonStr);
            //}

            string result;
            using (StreamReader sr = new StreamReader(path + @"Files\database.json"))
            {
                result = sr.ReadToEnd();
            }

            Department department1 = JsonConvert.DeserializeObject<Department>(result);
            foreach (var employee in department1.Employees)
            {
                if(employee.Id == 1)
                    Console.WriteLine(employee.ShowInfo());
            }
        }
    }
}
