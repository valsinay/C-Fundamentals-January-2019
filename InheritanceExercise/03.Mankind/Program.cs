using System;

namespace _03.Mankind
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] studentInput = Console.ReadLine().Split();

                string studentfirstName = studentInput[0];
                string studentlastName = studentInput[1];
                string studentfacultyNumber = studentInput[2];

                Student student = new Student(studentfacultyNumber,studentfirstName,studentlastName);

                string[] workerInput = Console.ReadLine().Split();

                string workerFirstName = workerInput[0];
                string workerLastName = workerInput[1];
                double salary = double.Parse(workerInput[2]);
                double hours = double.Parse(workerInput[3]);

                Worker worker = new Worker(workerFirstName, workerLastName, salary, hours);

                Console.WriteLine(student);
                Console.WriteLine();
                Console.WriteLine(worker);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
