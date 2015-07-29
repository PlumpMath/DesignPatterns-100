using AbstractFactory.Makes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Models
{
    public class A3 : Audi
    {
        public override string Model
        {
            get { return "A3"; }
        }
    }
}
