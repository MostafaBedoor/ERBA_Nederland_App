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
    
    public partial class Instrserienummers
    {
        public int ID { get; set; }
        public Nullable<int> InsID { get; set; }
        public string Uniek_Serienummer { get; set; }
        public Nullable<System.DateTime> Vervallenop { get; set; }
        public Nullable<System.DateTime> Aanschafdatum { get; set; }
        public bool Inreparatie { get; set; }
        public string SerieNrKoppelNet { get; set; }
    }
}