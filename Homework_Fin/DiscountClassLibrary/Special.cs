using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountClassLibrary
{
    public class Special : Discount
    {
        public override double Scale { get { return 0.5; } }
    }
}