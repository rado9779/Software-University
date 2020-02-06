using System;
using System.Linq;
using System.Collections.Generic;

namespace P04_Hospital
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, List<string>> doctors = new Dictionary<string, List<string>>();
            Dictionary<string, List<List<string>>> departments = new Dictionary<string, List<List<string>>>();


            string command = Console.ReadLine();
            while (command != "Output")
            {
                string[] elements = command.Split();
                var departament = elements[0];
                var firstName = elements[1];
                var lastName = elements[2];
                var patient = elements[3];
                var fullName = firstName + lastName;

                if (!doctors.ContainsKey(fullName))
                {
                    doctors[fullName] = new List<string>();
                }
                if (!departments.ContainsKey(departament))
                {
                    departments[departament] = new List<List<string>>();
                    for (int rooms = 0; rooms < 20; rooms++)
                    {
                        departments[departament].Add(new List<string>());
                    }
                }

                bool havePlace = departments[departament]
                    .SelectMany(x => x)
                    .Count() < 60;

                if (havePlace)
                {
                    int room = 0;
                    doctors[fullName].Add(patient);

                    for (int i = 0; i < departments[departament].Count; i++)
                    {
                        if (departments[departament][i].Count < 3)
                        {
                            room = i;
                            break;
                        }
                    }
                    departments[departament][room].Add(patient);
                }
                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string[] elements = command.Split();

                if (elements.Length == 1)
                {
                    Console.WriteLine(string.Join("\n", departments[elements[0]].Where(x => x.Count > 0).SelectMany(x => x)));
                }
                else if (elements.Length == 2 && int.TryParse(elements[1], out int staq))
                {
                    Console.WriteLine(string.Join("\n", departments[elements[0]][staq - 1].OrderBy(x => x)));
                }
                else
                {
                    Console.WriteLine(string.Join("\n", doctors[elements[0] + elements[1]].OrderBy(x => x)));
                }
                command = Console.ReadLine();
            }
        }
    }
}
