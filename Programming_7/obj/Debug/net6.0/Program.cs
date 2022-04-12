using System;
using System.Text.Json;
using System.Xml.Serialization;
using System.Data;

namespace Programming_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = GenerateListOfPeople();

            //JSonDemo(people);
            //XMLDemo("/Users/vladimirschmadlak/Documents/Code/University/Programming/Programming_7/Programming_7/Files/textFile.txt", people);

            Console.ReadKey();
        }

        private static List<Person> GenerateListOfPeople()
        {
            List<Person> people = new List<Person>();

            for (int i = 0; i <= 10; i++)
            {
                people.Add(new Person
                {
                    FirstName = $"fName {i}",
                    LastName = $"lName {i}"
                });
            }

            return people;
        }

        private static void JSonDemo(List<Person> people)
        {
            JsonSerializerOptions options = new JsonSerializerOptions();

            options.WriteIndented = true;
            options.IgnoreNullValues = true;

            string jSonString = JsonSerializer.Serialize(people, options);

            List<Person> backList = JsonSerializer.Deserialize<List<Person>>(jSonString);

            Console.WriteLine(jSonString);
        }

        private static void XMLDemo(string fileName, List<Person> people)
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<Person>));

            TextWriter writer = new StreamWriter(fileName);

            ser.Serialize(writer, people);

            writer.Close();
        }
    }
}