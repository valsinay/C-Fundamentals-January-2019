namespace _01.Box
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
                double length = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

            try
            {
                Box box = new Box(length,width,height);

                var surfaceAreaResult = box.CalculateSurfaceArea();
                var lateralSurfaceResult = box.LateralSurfaceArea();
                var volumeResult = box.CalculateVolume();


                Console.WriteLine($"Surface Area - {surfaceAreaResult:f2}");
                Console.WriteLine($"Lateral Surface Area - {lateralSurfaceResult:f2}");
                Console.WriteLine($"Volume - {volumeResult:f2}");
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
