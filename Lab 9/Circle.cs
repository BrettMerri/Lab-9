﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Circle
    {
        #region Variables

        private double Radius;
        private double Circumference;
        private double Area;

        #endregion

        #region Properties

        public double CircleRadius
        {
            get
            {
                return Radius;
            }

            set
            {
                Radius = value;
            }
        }

        public double CircleCircumference
        {
            get
            {
                return Circumference;
            }

            set
            {
                Circumference = value;
            }
        }

        public double CircleArea
        {
            get
            {
                return Area;
            }

            set
            {
                Area = value;
            }
        }

        #endregion

        #region Constructors

        public Circle()
        {
            Radius = 0;
            Circumference = 0;
            Area = 0;
        }

        public Circle(double RadiusInput)
        {
            Radius = RadiusInput;
            Circumference = GetCircumference();
            Area = GetArea();
        }

        #endregion

        #region Methods

        public double GetCircumference()
        {
            return 2 * Math.PI * Radius;
        }

        public string GetFormattedCircumference()
        {
            return String.Format("{0:0.00}", Circumference);
        }

        public double GetArea()
        {
            return Math.PI * (Math.Pow(Radius, 2));
        }

        public string GetFormattedArea()
        {
            return String.Format("{0:0.00}", Area);
        }

        private string FormatNumber(double x)
        {
            return String.Format("{0:0.00}", x);
        }

        #endregion
    }
}
