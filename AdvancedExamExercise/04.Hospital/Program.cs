using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var departments = new Dictionary<string, List<string>>();
            var doctors = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ");

                if (input[0] == "Output")
                {
                    break;
                }

                string department = input[0];
                string doctor = input[1] + " " + input[2];
                string patient = input[3];

                if (!departments.ContainsKey(department))
                {
                    departments.Add(department, new List<string>());

                }
                departments[department].Add(patient);
                if (!doctors.ContainsKey(doctor))
                {
                    doctors.Add(doctor, new List<string>());
                }
                doctors[doctor].Add(patient);
            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }
                string[] tokens = line.Split();

                if (tokens.Length == 1)
                {

                    string department = tokens[0];

                    foreach (var item in departments[department])
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (int.TryParse(tokens[1], out int _))
                {

                    if (int.Parse(tokens[1]) > 20)
                    {
                        continue;
                    }

                    var patients = departments[tokens[0]];

                    List<string> room = patients.Skip(3 * (int.Parse(tokens[1]) - 1)).ToList();

                    List<string> roomToPrint = room.Take(3).ToList();

                    foreach (var patient in room)
                    {
                        Console.WriteLine(patient);
                    }
                }
                else
                {
                    string doctorName = tokens[0] + " " + tokens[1];
                    var filter = doctors[doctorName].OrderBy(x => x);

                    foreach (var patient in filter)
                    {
                        Console.WriteLine(patient);
                    }
                }
            }
        }
    }
}
