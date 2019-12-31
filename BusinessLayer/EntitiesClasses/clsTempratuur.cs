using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer.EntitiesClasses
{
   public class clsTempratuur
    {
        public static List<Temperatuur> GetListTempratuur()
        {
            using (ERBA_Entities db = new ERBA_Entities())
            {
                try
                {
                    var qry = db.Temperatuur.ToList();
                    return qry;
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
