using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer.EntitiesClasses
{
   public class clsInstrumentsCategories
    {
        public List<Categorie> GetAllCategories()
        {
            using (ERBA_Entities db = new ERBA_Entities())
            {
                try
                {
                    var cats = db.Categorie.OrderBy(l => l.Name).ToList();
                    return cats;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
        public bool AddEditCategory(Categorie cat)
        {
            using (ERBA_Entities db = new ERBA_Entities())
            {
                try
                {
                    if (cat.ID > 0)
                    {
                        var qry = db.Categorie.Where(g => g.ID == cat.ID).FirstOrDefault();
                        qry.Name = cat.Name;
                    }
                    else
                    {
                        db.Categorie.Add(cat);
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
