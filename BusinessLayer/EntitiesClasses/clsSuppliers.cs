using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer.EntitiesClasses
{
    public class clsSuppliers
    {
        public List<Leveranciers> GetAllLeveranciers()
        {
            using (ERBA_Entities db = new ERBA_Entities())
            {
                try
                {
                    var suppliers = db.Leveranciers.OrderBy(l => l.Naam).ToList();
                    return suppliers;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        public Leveranciers GetLeverancierByID(int id)
        {
            using (ERBA_Entities db = new ERBA_Entities())
            {
                try
                {
                    var supplier = db.Leveranciers.Where(g => g.LEVID == id).FirstOrDefault();
                    return supplier;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        public bool AddEditLeverancier(Leveranciers supplier)
        {
            using (ERBA_Entities db = new ERBA_Entities())
            {
                try
                {
                    if (supplier.LEVID > 0)
                    {
                        var qry = db.Leveranciers.Where(g => g.LEVID == supplier.LEVID).FirstOrDefault();
                        qry.Naam = supplier.Naam;
                        qry.Adres = supplier.Adres;
                        qry.Postcode = supplier.Postcode;
                        qry.Plaats = supplier.Plaats;
                        qry.Vertegenwoordiger = supplier.Vertegenwoordiger;
                        qry.Telefoonnummer = supplier.Telefoonnummer;
                        qry.Mobiel = supplier.Mobiel;
                        qry.Specialisatie = supplier.Specialisatie;
                        qry.Website = supplier.Website;
                        qry.Emailadres = supplier.Emailadres;
                        qry.Crediteurnummer = supplier.Crediteurnummer;
                        qry.Klantnummer = supplier.Klantnummer;
                        qry.ExtraInfo = supplier.ExtraInfo;
                    }
                    else
                    {
                        db.Leveranciers.Add(supplier);
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

