using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Path_to_succsess
{
    internal class Market : Building
    {
        (string, short)[] products;
        Market((string, short)[] products)
        {
            this.products = products;
        }
    }
}
