using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataLayer;

namespace BusinessLayer.EntitiesClasses
{
    public class clsUsers
    {
        public Gebruiker GetGebruikerByInlogGegs(string naam, string pw)
        {
            using (ERBAEntities db = new ERBAEntities())
            {
                try
                {
                    var geb = db.Gebruiker.Where(g => g.Inlognaam == naam && g.Wachtwoord == pw).FirstOrDefault();                    
                    return geb;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
        public Gebruiker GetGebruikerByID(int id)
        {
            using (ERBAEntities db = new ERBAEntities())
            {
                try
                {
                    var geb = db.Gebruiker.Where(g => g.ID == id).FirstOrDefault();                    
                    return geb;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
        public List<Roll> GetUesrRolls()
        {
            using (ERBAEntities db = new ERBAEntities())
            {
                try
                {
                    var geb = db.Roll.ToList();                    
                    return geb;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
        public List<Gebruiker> GetAllUesr()
        {
            using (ERBAEntities db = new ERBAEntities())
            {
                try
                {
                    var geb = db.Gebruiker.ToList();                    
                    return geb;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
        public List<string> GetUesrFunctie()
        {
            using (ERBAEntities db = new ERBAEntities())
            {
                List<string> toReturn = new List<string>();
                try
                {
                    var gebs = db.Gebruiker.Select(o => new { o.Functie}).ToList();
                    gebs = gebs.OrderBy(g => g.Functie).ToList();
                    foreach (var fun in gebs)
                    {
                        toReturn.Add(fun.Functie);
                    }
                    return toReturn;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }


    }

    //public class UserFunctie
    //{
    //    public int RolID { get; set; }
    //    public string RolNaam { get; set; }
    //}
}
