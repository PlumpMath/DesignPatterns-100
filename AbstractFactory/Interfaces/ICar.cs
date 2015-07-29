using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interfaces
{
    public interface ICar
    {
        Color Color { get; }

        string Make { get; }

        string Model { get; }

        void Drive();
    }
}
