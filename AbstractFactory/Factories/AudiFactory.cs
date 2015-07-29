using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    public class AudiFactory : ICarFactory
    {
        public ICar CreateSedan()
        {
            return new AudiA4();
        }

        public ICar CreateHatchback()
        {
            return new AudiA3();
        }

        public ICar CreateLimo()
        {
            return new AudiA8();
        }
    }
}
