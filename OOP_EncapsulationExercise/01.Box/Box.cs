﻿using System;

namespace _01.Box
{
    public class Box
    {

        private double length;
        private double width;
        private double height;

        public Box(double length, double width,double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get => this.length;

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative. ");
                }
                this.length = value;
            }
        }

        public double Width
        {
            get => this.width;

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative. ");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get => this.height;

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative. ");
                }

                this.height = value;
            }
        }

        public double CalculateSurfaceArea()
        {
            // 2lw + 2lh + 2wh
            return 2 * this.Length * this.Width + this.LateralSurfaceArea();
        }

        public double CalculateVolume()
        {
            return this.Width * this.Length * this.Height;
        }

        public double LateralSurfaceArea()
        {
            //  2lh + 2wh  
            return 2 * this.Length * this.Height + 2 * this.Width * this.Height;
        }
    }
}