using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer.EntitiesClasses
{
 public   class clsMedia
    {
        public static bool AddMediaForNet(int netID, List<Media> films)
        {
            if (films == null) return true;
            using (ERBA_Entities db = new ERBA_Entities())
            {
                try
                {
                    var qry = db.Media.Where(f => f.NetID == netID).ToList();
                    foreach (var med in qry)
                    {
                        db.Media.Remove(med);
                    }
                    foreach (var film in films)
                    {
                        db.Media.Add(film);
                    }
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

    }
}
