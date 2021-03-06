//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Netten
    {
        public int ID { get; set; }
        public int LocatieID { get; set; }
        public int TempID { get; set; }
        public int GewijzigdDoorID { get; set; }
        public string KasLocation { get; set; }
        public string NetNumber { get; set; }
        public string Naam_net { get; set; }
        public Nullable<System.DateTime> Vervallenop { get; set; }
        public Nullable<System.DateTime> Datumwijziging { get; set; }
        public Nullable<System.DateTime> DateCSA { get; set; }
        public Nullable<System.DateTime> EndDateCSA { get; set; }
        public string ExtraInfo { get; set; }
        public string ExtraInfoCSA { get; set; }
        public Nullable<int> charge { get; set; }
    
        public virtual Gebruiker Gebruiker { get; set; }
        public virtual luLocatie luLocatie { get; set; }
        public virtual Temperatuur Temperatuur { get; set; }
    }
}
