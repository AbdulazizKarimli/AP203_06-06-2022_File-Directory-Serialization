using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using Xml2CSharp;

namespace FileDirectorySerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FileDirectory
            //Directory.CreateDirectory(@"C:\Users\HP\Desktop\Test");
            //Directory.Delete(@"C:\Users\HP\Desktop\Test", true);
            //Console.WriteLine(Directory.Exists(@"C:\Users\HP\Desktop\Test"));

            //File.Create(@"C:\Users\HP\Desktop\Test\test.txt");
            //StreamWriter sw = new StreamWriter(@"C:\Users\HP\Desktop\Test\test.txt");
            //sw.WriteLine("test text");
            //sw.WriteLine("test text1");
            //sw.Close();

            //StreamReader sr = new StreamReader(@"C:\Users\HP\Desktop\Test\test.txt");
            //Console.WriteLine(sr.ReadToEnd());
            //sr.Close();
            //if(!File.Exists(@"C:\Users\HP\Desktop\Test"))
            //    File.Create(@"C:\Users\HP\Desktop\Test\test.txt");

            //using (StreamWriter sw = new StreamWriter(@"C:\Users\HP\Desktop\Test\test.txt"))
            //{
            //    sw.Write("ssad");
            //}

            //using (StreamReader sr = new StreamReader(@"C:\Users\HP\Desktop\Test\test.txt"))
            //{
            //    Console.WriteLine(sr.ReadToEnd());
            //}

            //if (!File.Exists(@"C:\Users\HP\Desktop\Test\test.txt"))
            //{
            //    File.Create(@"C:\Users\HP\Desktop\Test\test.txt");
            //}

            //File.Create(@"C:\Users\HP\Desktop\Test\test.html");


            //foreach (var item in Directory.GetFiles(@"C:\Users\HP\Desktop\Test\"))
            //{
            //    Console.WriteLine(item);
            //}

            //Directory.CreateDirectory(@"C:\Users\HP\Desktop\Test\Inside");
            //File.Create(@"C:\Users\HP\Desktop\Test\Inside\test.txt");

            //string folderPath = @"C:\Users\HP\Desktop\Test";
            //string filePath = @"C:\Users\HP\Desktop\Test\test.txt";


            //foreach (var item in Directory.GetDirectories(path))
            //{
            //    //Console.WriteLine(item);
            //    foreach (var file in Directory.GetFiles(item))
            //    {
            //        Console.WriteLine(file);
            //    }
            //}

            //string search = "test";
            //using (StreamReader sr = new StreamReader(filePath))
            //{
            //    if(sr.ReadToEnd().Contains(search))
            //        Console.WriteLine("ok");
            //}

            //using (FileStream fs = new FileStream(@"C:\Users\HP\Desktop\Test\test.txt", FileMode.OpenOrCreate))
            //{
            //    Console.WriteLine(fs);
            //}

            #region ClassWork
            //string path = @"C:\Users\HP\Desktop\Test\";

            //bool check = true;
            //do
            //{
            //    Console.WriteLine("Menu");
            //    Console.WriteLine("1. Create File");
            //    Console.WriteLine("2. Write text to file");
            //    Console.WriteLine("3. Read text from file ");
            //    Console.WriteLine("0. Quit");

            //    string choice = Console.ReadLine();

            //    switch (choice)
            //    {
            //        case "1":
            //            string fileName = Console.ReadLine();
            //            if(!File.Exists(path + fileName))
            //            {
            //                var result = File.Create(path + fileName);
            //                result.Close();
            //            }
            //            break;
            //        case "2":
            //            string text = Console.ReadLine();
            //            using (StreamWriter sw = new StreamWriter(path + "test.txt"))
            //            {
            //                sw.Write(text);
            //            }
            //            break;
            //        case "3":
            //            using (StreamReader sr = new StreamReader(path + "test.txt"))
            //            {
            //                Console.WriteLine(sr.ReadToEnd());
            //            }
            //            break;
            //        case "0":
            //            check = false;
            //            break;
            //        default:
            //            Console.WriteLine("wrong input");
            //            break;
            //    }
            //} while (check);
            #endregion
            #endregion

            #region Json
            //string path = @"D:\Programming\CodeAcademy\Work\AzTU\AP203\C#\ClassWorks\AP203_06-06-2022_File-Directory-Serialization\FileDirectorySerialization\FileDirectorySerialization\";

            //Directory.CreateDirectory(path + "Files");
            //File.Create(path + @"Files\test.json");

            //Student student = new Student()
            //{
            //    Id = 1,
            //    Name = "Hafiz",
            //    Surname = "Mehdiyev",
            //    Age = 21,
            //    Point = 78
            //};
            //Student student1 = new Student()
            //{
            //    Id = 2,
            //    Name = "Allahverdi",
            //    Surname = "Ahmedov",
            //    Age = 20,
            //    Point = 75.5
            //};

            //Course course = new Course()
            //{
            //    Id = 1,
            //    Name = "test course",
            //    Students = new List<Student> { student, student1 },
            //};

            //string studentJsonStr = JsonConvert.SerializeObject(student);
            //Console.WriteLine(studentJsonStr);

            //using (StreamWriter sw = new StreamWriter(path + @"Files\test.json"))
            //{
            //    sw.Write(studentJsonStr);
            //}

            //string courseJsonStr = JsonConvert.SerializeObject(course);
            //using (StreamWriter sw = new StreamWriter(path + @"Files\test.json"))
            //{
            //    sw.Write(courseJsonStr);
            //}

            //string courseJsonStr;
            //using (StreamReader sr = new StreamReader(path + @"Files\test.json"))
            //{
            //    courseJsonStr = sr.ReadToEnd();
            //}

            //Course course1 = JsonConvert.DeserializeObject<Course>(courseJsonStr);
            //foreach (var student2 in course1.Students)
            //{
            //    Console.WriteLine(student2.Name);
            //}
            #endregion

            #region XML
            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(ValCurs));
            //StreamReader sr = null;
            //using (sr = new StreamReader(@"D:\Programming\CodeAcademy\Work\AzTU\AP203\C#\ClassWorks\AP203_06-06-2022_File-Directory-Serialization\FileDirectorySerialization\FileDirectorySerialization\Files\XMLFile1.xml"))
            //{
            //    var result = (ValCurs)xmlSerializer.Deserialize(sr);
            //    foreach (var item in result.ValType)
            //    {
            //        foreach (var valute in item.Valute)
            //        {
            //            Console.WriteLine(valute.Name);
            //        }
            //    }
            //}
            #endregion

            #region Regex
            //Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            //Console.WriteLine(regex.IsMatch("test@gmail.com"));
            #endregion

            #region HttpClient
            //HttpClient httpClient = new HttpClient();
            //var result = httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts").Result;
            //var resultStr = result.Content.ReadAsStringAsync().Result;

            //List<Post> posts = JsonConvert.DeserializeObject<List<Post>>(resultStr);

            //foreach (var post in posts)
            //{
            //    Console.WriteLine(post.Title);
            //}
            #endregion
        }
    }
}
