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
    
    public partial class Zichtorders
    {
        public int ZichtID { get; set; }
        public string Artikel { get; set; }
        public Nullable<System.DateTime> Op_zicht_van { get; set; }
        public Nullable<System.DateTime> Op_zicht_tot { get; set; }
        public Nullable<int> Firma { get; set; }
        public string Ordernummer { get; set; }
        public bool Doorgegeven_aan_firma { get; set; }
        public bool Assistentie { get; set; }
        public string Afspraken_mbt_assistentie { get; set; }
        public bool Naar_TD { get; set; }
        public Nullable<System.DateTime> Naar_TD_datum { get; set; }
        public Nullable<System.DateTime> Retour_TD_datum { get; set; }
        public bool Betreft_bruikleennet { get; set; }
        public bool Implantaten_mee { get; set; }
        public Nullable<System.DateTime> OK_Datum { get; set; }
        public string Soort_operatie { get; set; }
        public string Aangevraagd_door { get; set; }
        public Nullable<System.DateTime> Aangevraagd_op { get; set; }
        public bool zichtorder_binnen { get; set; }
        public string aangenomen_door { get; set; }
        public Nullable<System.DateTime> zichtorder_binnen_datum { get; set; }
        public Nullable<int> zichtorder_retour_behouden { get; set; }
        public Nullable<System.DateTime> datum_behouden_retour { get; set; }
        public string retour_behouden_afgehandeld_door { get; set; }
        public Nullable<decimal> kosten { get; set; }
        public Nullable<int> Aantal_netten { get; set; }
        public bool verzonden { get; set; }
    }
}
