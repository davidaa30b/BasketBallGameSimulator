using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaketballGameSimulator2._0.Views
{
    interface Iparametars_table
    {
        string EfficiancyRaiseMinimum { get; set; }
        string EfficiancyRaiseMaximum { get; set; }
        string EfficiancyDeclineMinimum { get; set; }
        string EfficiancyDeclineMaximum { get; set; }
        string MinimalAgeForDraft { get; set; }
        string MinimalAllowedEfficiancy { get; set; }
        string MaximumAllowedEfficiancy { get; set; }
        string EmotionalConst { get; set; }
        string PhysicalConst { get; set; }
        string IntellectuallConst { get; set; }
        string DailyStatus { get; set; }
    }
}
