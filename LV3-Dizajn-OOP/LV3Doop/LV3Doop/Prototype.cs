using System;
using System.Collections.Generic;
using System.Text;

namespace LV3Doop
{
    interface Prototype
    {
        Prototype ShallowClone();
        //Prototype DeepClone(List<List<string>> data);
    }
}
