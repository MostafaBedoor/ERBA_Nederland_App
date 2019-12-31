using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer.EntitiesClasses
{
 public  class clsLocaties
    {
        public List<spGetFullLocations_Result> GetAllLocaties()
        {
            using (ERBA_Entities db = new ERBA_Entities())
            {
                try
                {
                    var locaties = db.spGetFullLocations().ToList();
                    return locaties;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
        public List<SubLocaties> GetAllSubLocations(int locatieID)
        {
            using (ERBA_Entities db = new ERBA_Entities())
            {
                try
                {
                    var subLocaties = db.SubLocaties.Where(l => l.LocatieID == locatieID).ToList();
                    return subLocaties;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
        public List<Netten> GetAllNettenPerLocation(int locatieID, int subLocatieID)
        {
            using (ERBA_Entities db = new ERBA_Entities())
            {
                try
                {
                    var netten = db.Netten.Where(n => n.LocatieID == locatieID && n.SubLocatieID == subLocatieID).ToList();
                    return netten;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

    }
}
