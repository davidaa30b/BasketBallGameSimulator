//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BaketballGameSimulator2._0.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class player_character
    {
        public int Personal_id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Positon { get; set; }
        public string Team { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public Nullable<System.DateTime> DateOfDraft { get; set; }
        public Nullable<System.DateTime> DeclineDate { get; set; }
        public Nullable<System.DateTime> RetireDate { get; set; }
        public Nullable<double> DraftOverall { get; set; }
        public Nullable<double> MaximumOverall { get; set; }
        public Nullable<double> DeclineFactor { get; set; }
        public Nullable<double> RaiseFactor { get; set; }
        public Nullable<double> EmotionalConst { get; set; }
        public Nullable<double> PhysicalConst { get; set; }
        public Nullable<double> IntellectualConst { get; set; }
        public Nullable<double> DailyStatus { get; set; }
        public Nullable<System.TimeSpan> PeakTimeDay { get; set; }
        public Nullable<double> EfficeincyToDate { get; set; }
    }
}
