using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BuildingShape
{
    public class Shape
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual  double calculateArea()
        {

            return 0;

        }

    }
}

