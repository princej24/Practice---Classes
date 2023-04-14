using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Practice___Classes
{
    public  class Car
    {
        string _make;
        string _model;
        string _color; 
        int _mileage; 

        int _year;

        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }
        public string Color { get => _color; set => _color = value; }
        public int Mileage { get => _mileage; set => _mileage = value; }
        public int Year { get => _year; set => _year = value; }
    }




}
