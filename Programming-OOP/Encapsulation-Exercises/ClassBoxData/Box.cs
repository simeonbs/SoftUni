using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {

        private const string ZERO_OR_NEG_EXC_MSG = "{0} cannot be zero or negative.";
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        public double Length 
        {
            get
            {
                return this.length;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(String.Format(ZERO_OR_NEG_EXC_MSG, nameof(Length)));
                }
                this.length = value;
            } 
        }
        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(String.Format(ZERO_OR_NEG_EXC_MSG, nameof(Width)));
                }
                this.width = value;
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(String.Format(ZERO_OR_NEG_EXC_MSG, nameof(Height)));
                }
                this.height = value;
            }
        }
        //Validation done

        

        public double SurfaceArea()
        {
            double SurfaceArea = (2 * this.length * this.width) + LateralSurfaceArea();
            return SurfaceArea;
        }

        public double LateralSurfaceArea()
        {
            double LateralSurfaceArea = (2 * this.length * this.height) + (2 * this.width * this.height);
            return LateralSurfaceArea;
        }

        public double Volume()
        {
            double volume = this.height * this.width * this.length;
            return volume;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {SurfaceArea():F2}");
            sb.AppendLine($"Lateral Surface Area - {LateralSurfaceArea():f2}");
            sb.AppendLine($"Volume - {Volume():f2}");
            return sb.ToString().TrimEnd();
        }
    }
}
