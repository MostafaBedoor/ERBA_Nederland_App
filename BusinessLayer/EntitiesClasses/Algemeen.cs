using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer.EntitiesClasses
{
  public class Algemeen
    {
        public static List<Roll> GetLookupAlleUserTypes()
        {
            try
            {
                using (ERBAEntities db = new ERBAEntities())
                {
                    try
                    {
                        var lst = db.Roll.ToList();
                        return lst;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
