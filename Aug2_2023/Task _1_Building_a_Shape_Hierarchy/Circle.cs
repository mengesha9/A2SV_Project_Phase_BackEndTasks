using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingShape
{
    public class Circle : Shape
    {
        private double raduis;

        
        public double Raduis
        {
            get { return raduis ; }
            set { raduis = value; }
        }
        public override double calculateArea()
        {

            return 3.14*raduis*raduis;

        }


    }

    
}
