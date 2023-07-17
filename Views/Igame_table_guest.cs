using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaketballGameSimulator2._0.Views
{
    interface Igame_table_guest
    {
        string Id { get; set; }
        string Player_id { get; set; }
        string Name { get; set; }
        string EfficiencyAtTheTime { get; set; }
    }
}
