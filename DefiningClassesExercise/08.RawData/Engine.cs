using System;
using System.Collections.Generic;
using System.Text;

namespace _08.RawData
{
    public class Engine
    {
        private int engineSpeed;
        private int enginePower;

        public Engine(int engineSpeed, int enginePower)
        {
            this.EngineSpeed = engineSpeed;
            this.EnginePower = enginePower;
        }

        public int EnginePower
        {
            get { return this.enginePower; }
            set { this.enginePower = value; }
        }

        public int EngineSpeed
        {
            get { return this.engineSpeed; }
            set { this.engineSpeed = value; }
        }
        public bool EnginePowerOver250()
        {
            return this.enginePower > 250 ? true : false;
        }
    }
}
