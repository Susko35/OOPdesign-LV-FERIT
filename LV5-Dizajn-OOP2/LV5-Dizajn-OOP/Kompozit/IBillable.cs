using System;
using System.Collections.Generic;
using System.Text;

namespace LV5_Dizajn_OOP.Kompozit
{
    interface IBillable
    {
        double Price { get; }
        string Description(int depth = 0);
    }

}
