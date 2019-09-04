using System;
using System.Collections.Generic;
using System.Text;

namespace _08.RawData
{
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tires tires;

        public Car(string model, Engine engine,Cargo cargo, Tires tires)
        {
            this.model = model;
            this.engine = engine;
            this.cargo = cargo;
            this.tires = tires;
        }

        public string Model
        {
            get { return this.model; }
        }
        public Engine Engine
        {
            get { return this.engine; }
        }
        public Cargo Cargo
        {
            get { return this.cargo; }
        }
        public Tires Tires
        {
            get { return this.tires; }
        }
    }
}
