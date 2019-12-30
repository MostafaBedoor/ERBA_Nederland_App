using DataLayer;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ERBA_Manager
{
    class Comboboxes
    {
        public static void Leveranciers(ComboBox cmb)
        {
            using (ERBAEntities db = new ERBAEntities())
            {
                cmb.DataSource = db.Leveranciers.OrderBy(g => g.Naam).ToList();
                cmb.ValueMember = "LEVID";
                cmb.DisplayMember = "Naam";
            }
        }

        public static void NetStatus(ComboBox cmb)
        {
            using (ERBAEntities db = new ERBAEntities())
            {
                cmb.DataSource = db.Netten.ToList();
                cmb.ValueMember = "NetstatusID";
                cmb.DisplayMember = "Netstatus1";
            }
        }

        public static void Netten(ComboBox cmb)
        {
            using (ERBAEntities db = new ERBAEntities())
            {
                cmb.DataSource = db.Netten.OrderBy(g => g.Naam_net).ToList();
                cmb.ValueMember = "NetID";
                cmb.DisplayMember = "Naam_net";
            }
        }

        public static void Netten(ComboBox cmb, int StatusCode)
        {
            using (ERBAEntities db = new ERBAEntities())
            {
                cmb.DataSource = db.Netnummers.Where(n => n.Netstatus == StatusCode).ToList();
                cmb.ValueMember = "NetID";
                cmb.DisplayMember = "Naam_net";
            }
        }

        public static void AutoclaafCode(ComboBox cmb)
        {
            using (ERBAEntities db = new ERBAEntities())
            {
                cmb.DataSource = db.SubLLocaties.Where(s => s.Vervallen == null || s.Vervallen > DateTime.Now).ToList();
                cmb.ValueMember = "AutoclaafID";
                cmb.DisplayMember = "Code";
            }
        }

        public static void AutoclaafNaam(ComboBox cmb)
        {
            using (ERBAEntities db = new ERBAEntities())
            {
                cmb.DataSource = db.SubLLocaties.Where(s => s.Type == "A" || s.Type == "P").ToList();
                cmb.ValueMember = "AutoclaafID";
                cmb.DisplayMember = "Naam";
            }
        }

        public static void Temperature(ComboBox cmb, string autoclaaf)
        {
            using (ERBAEntities db = new ERBAEntities())
            {
                var a = db.SubLLocaties.Where(i => i.Type == autoclaaf).FirstOrDefault();
                cmb.DataSource = db.Temperatuur.Where(c => c.AutoclaafType == a.Type).OrderBy(g => g.TempID).ToList();
                cmb.ValueMember = "TempID";
                cmb.DisplayMember = "Temperatuur1";
            }
        }
    }
}
