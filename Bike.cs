using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Practice___Classes
{
    internal class Bike
    {

        string _Brand;
        string _color;
         int _NumOfWheeles;

        public string Brand { get => _Brand; set => _Brand = value; }
        public string Color { get => _color; set => _color = value; }
        public int NumOfWheeles { get => _NumOfWheeles; set => _NumOfWheeles = value; }
    }
}
