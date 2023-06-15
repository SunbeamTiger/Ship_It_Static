using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_It
{
    internal class Bicycles : IShippable
    {
        public decimal ShipCost => 20.50M;
        public string Product => "Bicycle";
    }
}
