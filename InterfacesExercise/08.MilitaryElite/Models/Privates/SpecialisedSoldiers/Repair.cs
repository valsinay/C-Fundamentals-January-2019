﻿using _08.MilitaryElite.Contracts.Privates.SpecialisedSoldiers;
using System;

namespace _08.MilitaryElite.Models.Privates.SpecialisedSoldiers
{
    public class Repair : IRepair
    {
        public Repair(string partName, int hoursWorked)
        {
            this.PartName = partName;
            this.HoursWorked = hoursWorked;
        }

        public string PartName { get; private set; }

        public int HoursWorked { get; private set; }

        public override string ToString()
        {
            return $"Part Name: {this.PartName} Hours Worked: {this.HoursWorked}";
        }
    }
}
