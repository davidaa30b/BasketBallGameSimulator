using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaketballGameSimulator2._0.Views
{
    interface Iteamsinfo
    {
        string Name { get; set; }
        string Location { get; set; }
        string Coach { get; set; }
        string Manager { get; set; }
        string Owner { get; set; }
        string EstablishmentDate { get; set; }
    }
}
