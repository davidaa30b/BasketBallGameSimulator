﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class playersEntities : DbContext
    {
        public playersEntities()
            : base("name=playersEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<game_table_guest> game_table_guest { get; set; }
        public virtual DbSet<game_table_host> game_table_host { get; set; }
        public virtual DbSet<parametars_table> parametars_table { get; set; }
        public virtual DbSet<player_character> player_character { get; set; }
        public virtual DbSet<position_of_players_table> position_of_players_table { get; set; }
        public virtual DbSet<teamsinfo> teamsinfo { get; set; }
    }
}