using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    public class Car : ICar
    {
        public abstract Color Color { get; }

        public abstract string Make { get; }

        public abstract string Model { get; }

        public virtual void Drive()
        {
            Console.WriteLine("You are driving {0} {1} {2}", this.Color, this.Make, this.Model);
        }
    }
}
