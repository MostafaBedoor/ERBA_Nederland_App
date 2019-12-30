using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DataLayer;

namespace BusinessLayer.EntitiesClasses
{
   public class clsAfdekmateriaal
    {
        public List<Afdekmateriaal> GetAllAfdekmateriaal()
        {
            using (ERBAEntities db = new ERBAEntities())
            {
                try
                {
                    var Afdek = db.Afdekmateriaal.OrderBy(l => l.Naam_afdekmateriaal).ToList();
                    return Afdek;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        public Afdekmateriaal GetAfdekmateriaal(int id)
        {
            using (ERBAEntities db = new ERBAEntities())
            {
                try
                {
                    var Afdek = db.Afdekmateriaal.Where(g => g.AfdekID == id).FirstOrDefault();
                    return Afdek;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        public void DeleteAfdekmateriaal(int id)
        {
            using (ERBAEntities db = new ERBAEntities())
            {
                try
                {
                    var Afdek = db.Afdekmateriaal.Where(g => g.AfdekID == id).FirstOrDefault();
                    db.Afdekmateriaal.Remove(Afdek);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public int getmax()
        {
            using (ERBAEntities db = new ERBAEntities())
            {
                try
                {
                    var Afdek = db.Afdekmateriaal.Max(x => x.AfdekID);
                    return Afdek;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
            }
        }

        public void InsertAfdekmateriaal(int id, string naam, string omsch, string loc, string info, string lev, decimal prijs, string foto, string mag)
        {
            using (ERBAEntities db = new ERBAEntities())
            {
                try
                {
                    var Afdek = new Afdekmateriaal();
                    Afdek.AfdekID = id;
                    Afdek.Naam_afdekmateriaal = naam;
                    Afdek.Omschrijving = omsch;
                    Afdek.Locatie = loc;
                    Afdek.Info = info;
                    Afdek.Leverancier = lev;
                    Afdek.Prijs = prijs;
                    Afdek.Afdekmateriaalfoto = foto;
                    Afdek.Magazijn = mag;
                    db.Afdekmateriaal.Add(Afdek);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

