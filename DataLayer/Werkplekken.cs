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
    
    public partial class Werkplekken
    {
        public int WP_ID { get; set; }
        public string Werkpleknaam { get; set; }
        public string Standaardprinter { get; set; }
        public string Labelprinter { get; set; }
        public Nullable<int> netstatus { get; set; }
    }
}