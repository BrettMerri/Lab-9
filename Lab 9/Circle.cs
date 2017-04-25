using System;
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

        #region Constructors

        public Circle()
        {
            Radius = 0;
            Circumference = 0;
            Area = 0;
        }

        public Circle(double RadiusInput) //When a Circle object is created with a radius, immediately calculate the Circumference and Area.
        {
            Radius = RadiusInput;
            Circumference = GetCircumference();
            Area = GetArea();
        }

        #endregion

        #region Methods

        public double GetCircumference()
        {
            return 2 * Math.PI * Radius; //2 * Pi * r
        }

        public string GetFormattedCircumference()
        {
            return String.Format("{0:0.00}", Circumference); //Return Circumference rounded to two decimal places
        }

        public double GetArea()
        {
            return Math.PI * (Math.Pow(Radius, 2)); //Pi * r ^ 2
        }

        public string GetFormattedArea()
        {
            return String.Format("{0:0.00}", Area); //Return Area rounded to two decimal places
        }

        #endregion
    }
}
