using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections.ObjectModel;

namespace LV5_Dizajn_OOP.Proxy
{
    interface IDataset
    {
        ReadOnlyCollection<List<string>> GetData();
    }
}
