﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _08.MilitaryElite.Contracts.Privates.SpecialisedSoldiers
{
    public interface IMission
    {
        string CodeName { get; }

        string State { get; }
    }
}
