﻿namespace P03_BarraksWars.Core.InputCommands
{
    using System;
    using _03BarracksFactory.Contracts;

    public class RetireCommand : Command
    {
        public RetireCommand(string[] data, IRepository repository, IUnitFactory unitFactory)
            : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            string unitType = Data[1];
            this.Repository.RemoveUnit(unitType);

            return $"{unitType} retired!";
        }
    }
}
