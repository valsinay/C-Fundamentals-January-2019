using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.Core
{
    public class Engine
    {
        private StorageMaster storageMaster;

        public Engine()
        {
            this.storageMaster = new StorageMaster();

        }

        public void Run()
        {

            while (true)
            {
                try
                {
                    string line = Console.ReadLine();
                    if (line == "END")
                    {
                        break;
                    }
                    string[] args = line.Split();
                    string result =ReadCommand(args);

                    Console.WriteLine(result);

                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                } 
            }

            Console.WriteLine(storageMaster.GetSummary());
        }

        private string ReadCommand(string[] args)
        {
            string command = args[0];
            string type = string.Empty;
            string storageName = string.Empty;
            string result = string.Empty;

            switch (command)
            {
                case "AddProduct":
                    type = args[1];
                    double price = double.Parse(args[2]);
                   result= storageMaster.AddProduct(type, price);
                    break;
                case "RegisterStorage":
                    type = args[1];
                    string name = args[2];
                   result =  storageMaster.RegisterStorage(type, name);
                    break;
                case "SelectVehicle":
                     storageName = args[1];
                    int garageSlot = int.Parse(args[2]);
               result=     storageMaster.SelectVehicle(storageName, garageSlot);
                    break;
                case "LoadVehicle":
                    string[] products = args.Skip(1).ToArray();
                   result= storageMaster.LoadVehicle(products);
                    break;
                case "SendVehicleTo":
                    string sourceName = args[1];
                    int sourceGarageSlot = int.Parse(args[2]);
                    string destinationName = args[3];
                    result = storageMaster.SendVehicleTo(sourceName, sourceGarageSlot, destinationName);
                    break;
                case "UnloadVehicle":
                    storageName = args[1];
                    int garageSlotToUnload = int.Parse(args[2]);
                    result = storageMaster.UnloadVehicle(storageName, garageSlotToUnload);
                    break;
                case "GetStorageStatus":
                    storageName = args[1];
                    result = storageMaster.GetStorageStatus(storageName);
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
