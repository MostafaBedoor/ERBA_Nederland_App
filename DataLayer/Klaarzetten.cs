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
    
    public partial class Klaarzetten
    {
        public int ID { get; set; }
        public string Omschrijving { get; set; }
        public string Extras { get; set; }
        public string Specialisme { get; set; }
        public Nullable<int> Klaarzetten_Als { get; set; }
        public string Extras_OK { get; set; }
        public string OKbeschrijving { get; set; }
        public string Bijzonderheden { get; set; }
        public Nullable<System.DateTime> Datumwijziging { get; set; }
        public Nullable<int> Gewijzigddoor { get; set; }
        public string Status_operatieverslag { get; set; }
    }
}