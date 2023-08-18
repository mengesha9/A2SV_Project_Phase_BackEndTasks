using System;

namespace BuildingShape
{
    internal class Triangle : Shape
    {
        private double _base; 
        private double _height;

        public double Base
        {
            get { return _base; }
            set { _base = value; }
        }

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        

        public  override  double calculateArea()
        {
            return (_base * _height) / 2;
        }
    }
}
