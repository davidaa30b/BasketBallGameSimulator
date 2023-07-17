using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaketballGameSimulator2._0.Views
{
    interface Iplayer_character
    {
        string Firstname { get; set; }
        string Lastname { get; set; }
        string Positon { get; set; }
        string Team { get; set; }
        string DateOfBirth { get; set; }
        string DateOfDraft { get; set; }
        string DeclineDate { get; set; }
        string RetireDate { get; set; }
        string DraftOverall { get; set; }
        string MaximumOverall { get; set; }
        string DeclineFactor { get; set; }
        string RaiseFactor { get; set; }
        string EmotionalConst { get; set; }
        string PhysicalConst { get; set; }
        string IntellectualConst { get; set; }
        string DailyStatus { get; set; }
        string PeakTimeDay { get; set; }
    }
}
