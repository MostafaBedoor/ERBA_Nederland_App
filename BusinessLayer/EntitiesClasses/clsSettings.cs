using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer.EntitiesClasses
{
  public  class clsSettings
    {
        public static string GetValueFromSettingsBySleutel(string sectionKey, string subSection1, string subSection2, string sleutel)
        {
            using (ERBA_Entities dc = new ERBA_Entities())
            {
                var qry = (from s in dc.Setting where s.SectionKey == sectionKey && s.SubSection1 == subSection1 && s.SubSection2 == subSection2 && s.Sleutel == sleutel select s).FirstOrDefault();
                if (qry == null) return "";
                else return qry.Waarde.ToString();
            }
        }

        public static bool UpdateSetting(Setting setting)
        {
            try
            {
                using (ERBA_Entities dc = new ERBA_Entities())
                {
                    var set = (from s in dc.Setting where s.SectionKey == setting.SectionKey && s.SubSection1 == setting.SubSection1 && s.SubSection2 == setting.SubSection2 && s.Sleutel == setting.Sleutel select s).FirstOrDefault();
                    set.Waarde = setting.Waarde;
                    dc.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
