using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class VwFactory : ICarFactory
    {

        public ICar CreateSedan()
        {
            return new VwPassat();
        }

        public ICar CreateHatchback()
        {
            return new VwGolf();
        }

        public ICar CreateLimo()
        {
            return new VwPhaeton();
        }
    }
}
