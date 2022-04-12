using System;
using System.Text;
using System.IO;
using System.Globalization;
using CsvHelper;

namespace Programming_7
{
    public class CSVHelper
    {
        public static List<Person> ReadFile(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);
            List<Person> result = new List<Person>();

            using (reader)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    var lineArr = line.Split(";");

                    result.Add(new Person
                    {
                        FirstName = lineArr[0],
                        LastName = lineArr[1]
                    });
                    line = reader.ReadLine();
                }
            }
            return result;
        }

        public static void WriteToFile(List<Person> source, string fileName)
        {
            StreamWriter writer = new StreamWriter(fileName);

            using (writer)
            {
                foreach (var element in source)
                {
                    writer.Write(element.FirstName);
                    writer.Write(";");
                    writer.Write(element.LastName);
                    writer.WriteLine();
                }
            }
        }

        public static void WriteToFile_WithCSV(List<Person> source, string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(source);
                }
            }
        }
    }
}

