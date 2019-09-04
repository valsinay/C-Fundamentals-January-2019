using System;
using System.Collections.Generic;
using System.Text;

namespace _08.RawData
{
    public class Tires

    {
        private double tire1Pressure;
        private int tire1Age;
        private double tire2Pressure;
        private int tire2Age;
        private double tire3Pressure;
        private int tire3Age;
        private double tire4Pressure;
        private int tire4Age;

        public Tires(double tire1Pressure, double tire2Pressure, double tire3Pressure, double tire4Pressure,
          int tire1Age, int tire2Age,int tire3Age ,int tire4Age )
        {
            this.Tire1Pressure = tire1Pressure;
            this.Tire2Pressure = tire2Pressure;
            this.Tire3Pressure = tire3Pressure;
            this.Tire4Pressure = tire4Pressure;
            this.Tire1Age = tire1Age;
            this.Tire2Age = tire2Age;
            this.Tire3Age = tire3Age;
            this.Tire4Age = tire4Age;
        }
        public double Tire1Pressure
        {
            get { return tire1Pressure; }
            set { tire1Pressure = value; }
        }

        public int Tire1Age
        {
            get { return tire1Age; }
            set { tire1Age = value; }
        }
        public double Tire2Pressure
        {
            get { return tire2Pressure; }
            set { tire2Pressure = value; }
        }

        public int Tire2Age
        {
            get { return tire2Age; }
            set { tire2Age = value; }
        }
        public double Tire3Pressure
        {
            get { return tire3Pressure; }
            set { tire3Pressure = value; }
        }

        public int Tire3Age
        {
            get { return tire3Age; }
            set { tire3Age = value; }
        }
        public double Tire4Pressure
        {
            get { return tire4Pressure; }
            set { tire4Pressure = value; }
        }

        public int Tire4Age
        {
            get { return tire4Age; }
            set { tire4Age = value; }
        }
        public bool TyrePressureUnder1()
        {
            return this.tire1Pressure < 1 || this.Tire2Pressure < 1 || this.Tire3Pressure < 1 || this.tire4Pressure < 1 ? true : false;
        }

    }
}
