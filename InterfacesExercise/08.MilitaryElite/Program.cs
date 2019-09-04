using _08.MilitaryElite.Models;
using _08.MilitaryElite.Models.Privates;
using _08.MilitaryElite.Models.Privates.SpecialisedSoldiers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.MilitaryElite
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashSet<Soldier> soldiers = new HashSet<Soldier>();

            while (true)
            {
                string[] inputArgs = Console.ReadLine().Split();

                string type = inputArgs[0];

                if (type == "End")
                {
                    break;
                }

                string id = inputArgs[1];
                string firstName = inputArgs[2];
                string lastName = inputArgs[3];

                if (type == "Private")
                {
                    decimal salary = decimal.Parse(inputArgs[4]);

                    Private @private = new Private(id, firstName, lastName, salary);
                    soldiers.Add(@private);
                }
                else if (type == "Spy")
                {
                    int code = int.Parse(inputArgs[4]);
                    Spy spy = new Spy(id, firstName, lastName, code);

                    soldiers.Add(spy);
                }
                else if (type == "LieutenantGeneral")
                {
                    decimal salary = decimal.Parse(inputArgs[4]);
                    HashSet<string> ids = inputArgs.Skip(5).ToHashSet();
                    HashSet<Private> privates = new HashSet<Private>();
                    GetSoldiers(ids, soldiers, privates);

                    LieutenantGeneral general = new LieutenantGeneral(id, firstName, lastName, salary, privates);

                    soldiers.Add(general);
                }
                else if (type == "Engineer")
                {

                    decimal salary = decimal.Parse(inputArgs[4]);
                    string corps = inputArgs[5];
                    List<string> repairArgs = inputArgs.Skip(6).ToList();
                    var repairs = new HashSet<Repair>();
                    GetRepairs(repairArgs, repairs);
                    try
                    {
                        Engineer engineer = new Engineer(id, firstName, lastName, salary, corps, repairs);
                        soldiers.Add(engineer);
                    }
                    catch (Exception)
                    {

                    }

                }
                else if (type == "Commando")
                {
                    decimal salary = decimal.Parse(inputArgs[4]);
                    string corps = inputArgs[5];
                    List<string> mission = inputArgs.Skip(6).ToList();
                    var missions = new HashSet<Mission>();
                    GetMissions(mission, missions);
                    try
                    {
                        Commando commando = new Commando(id, firstName, lastName, salary, corps, missions);
                        soldiers.Add(commando);
                    }
                    catch (Exception)
                    {

                    }
                }

            }
            foreach (var item in soldiers)
            {
                Console.WriteLine(item);
            }
        }

        private static void GetMissions(List<string> missionArgs, HashSet<Mission> missions)
        {
            for (int i = 0; i < missionArgs.Count; i += 2)
            {
                string codeName = missionArgs[i];
                string state = missionArgs[i + 1];
                try
                {
                    Mission mission = new Mission(codeName, state);
                    missions.Add(mission);
                }
                catch (Exception)
                {

                }

            }
        }

        private static void GetRepairs(List<string> repairArgs, HashSet<Repair> repairs)
        {
            for (int i = 0; i < repairArgs.Count; i += 2)
            {
                string partName = repairArgs[i];
                int workHours = int.Parse(repairArgs[i + 1]);
                Repair repair = new Repair(partName, workHours);

                repairs.Add(repair);
            }

        }

        private static void GetSoldiers(HashSet<string> ids, HashSet<Soldier> soldiers, HashSet<Private> privates)
        {
            foreach (var item in ids)
            {
                foreach (var privateSoldier in soldiers.Where(x=>x.GetType().Name == nameof(Private)))
                {
                    if (item.Contains(privateSoldier.Id))
                    {
                        privates.Add((Private)privateSoldier);

                    }
                }
            }
        }
    }
}
