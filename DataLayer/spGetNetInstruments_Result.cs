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
    
    public partial class spGetNetInstruments_Result
    {
        public int ID { get; set; }
        public string Instrumentnaam { get; set; }
        public string Bestelnummer { get; set; }
        public int INSID { get; set; }
        public int NETID { get; set; }
        public Nullable<int> Aantal { get; set; }
        public Nullable<int> Inlegvolgnummer { get; set; }
        public Nullable<int> AantalIngebruik { get; set; }
        public bool Aan_Speld { get; set; }
    }
}
