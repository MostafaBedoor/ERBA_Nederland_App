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
    
    public partial class Programmainstellingen
    {
        public int ID { get; set; }
        public Nullable<int> Inleggenstatus { get; set; }
        public bool Gewichtnetinschakelen { get; set; }
        public bool Downbrengen { get; set; }
        public Nullable<int> Tijdtotdown { get; set; }
        public bool Netregzondcsa { get; set; }
        public Nullable<int> Expdatnaster { get; set; }
        public Nullable<int> Expdatmetdustcov { get; set; }
        public bool Barcodelezer { get; set; }
        public string SMTP_Server { get; set; }
        public string SMTP_Poort { get; set; }
        public string SMTP_Wachtwoord { get; set; }
        public string SMTP_Inlognaam { get; set; }
        public string SMTP_Afzender { get; set; }
        public string ReparatieMailadres { get; set; }
        public string ZichtOrderMailadres { get; set; }
        public bool SMTP__Log { get; set; }
        public string DatabaseStatus { get; set; }
        public string DocumentsLocation { get; set; }
    }
}
