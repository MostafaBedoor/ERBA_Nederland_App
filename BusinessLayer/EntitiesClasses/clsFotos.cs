using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer.EntitiesClasses
{
    public class clsFotos
    {
        public static List<Fotos> GetFotosForNet(int netID)
        {
            using (ERBA_Entities db = new ERBA_Entities())
            {
                try
                {
                    var qry = db.Fotos.Where(f => f.NetID == netID).ToList();
                    return qry;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
        public static bool AddFotoForNet(int netID, List<Fotos> fotos)
        {
            if (fotos == null) return true;
            using (ERBA_Entities db = new ERBA_Entities())
            {
                try
                {
                    var qry = db.Fotos.Where(f => f.NetID == netID).ToList();
                    foreach (var fot in qry)
                    {
                        db.Fotos.Remove(fot);
                    }
                    foreach (var foto in fotos)
                    {
                        db.Fotos.Add(foto);
                    }
                    //Fotos foto = new Fotos { NetID = netID, Foto = image };
                    //db.Fotos.Add(foto);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false ;
                }
            }
        }

        public static bool AddFotoForInstrument(int instrID, List<InstrumentImages> fotos)
        {
            using (ERBA_Entities db = new ERBA_Entities())
            {
                try
                {
                    var qry = db.InstrumentImages.Where(f => f.InstrumentID == instrID).ToList();
                    foreach (var fot in qry)
                    {
                        db.InstrumentImages.Remove(fot);
                    }
                    foreach (var foto in fotos)
                    {
                        db.InstrumentImages.Add(foto);
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
