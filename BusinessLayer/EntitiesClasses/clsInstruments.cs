using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BusinessLayer.EntitiesClasses
{
    public class clsInstruments
    {
        private List<Categorie> _categories;
        //private List<NetInstrument> _InstrumentNets;
        public spGetInstrumentByID_Result GetInstrumentByID(int instrumentID)
        {
            using (ERBA_Entities db = new ERBA_Entities())
            {
                try
                {
                    //var instrument = db.Netten.Where(n => n.NetID == instrumentNumber).FirstOrDefault();
                    var instrument = db.spGetInstrumentByID(instrumentID).ToList().FirstOrDefault();
                    return instrument;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        public List<spGetNetInstruments_Result> GetNetInstruments(int netID)
        {
            using (ERBA_Entities db = new ERBA_Entities())
            {
                try
                {
                    var res = db.spGetNetInstruments(netID).ToList();
                    return res;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        public List<spGetAllInstruments_Result> GetAllInstruments()
        {
            using (ERBA_Entities db = new ERBA_Entities())
            {
                try
                {
                    var res = db.spGetAllInstruments().ToList();
                    return res;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        public List<Categorie> GetInstrumentsCategoreis()
        {
            if (_categories != null) return _categories;
            using (ERBA_Entities db = new ERBA_Entities())
            {
                try
                {
                    _categories = db.Categorie.ToList();
                    return _categories;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        public List<spGetInstrumentNetList_Result> GetInstrumentsNets(int instrID)
        {
            using (ERBA_Entities db = new ERBA_Entities())
            {
                try
                {
                    var qry = db.spGetInstrumentNetList(instrID).ToList();
                    return qry;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
        //  public List<InstrumentSerialnumbers> GetInstrumentsSerials(int instrID)
        //{
        //    using (ERBA_Entities db = new ERBA_Entities())
        //    {
        //        try
        //        {
        //            var qry = db.InstrumentSerialnumbers.Where(I => I.InstrumentID == instrID).ToList();
        //            return qry;
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return null;
        //        }
        //    }
        //}

        public int AddEditInstrument(Instrumenten Instrument)
        {
            using (ERBA_Entities db = new ERBA_Entities())
            {
                int toReturn = 0;
                try
                {
                    if (Instrument.ID > 0)
                    {
                        Instrumenten qry = db.Instrumenten.Where(n => n.ID == Instrument.ID).FirstOrDefault();
                        qry.CategorieID = Instrument.CategorieID;
                        qry.Instrumentnaam = Instrument.Instrumentnaam;
                        qry.LeverancierID = Instrument.LeverancierID;
                        qry.Gewicht = Instrument.Gewicht;
                        qry.AantalVoorraad = Instrument.AantalVoorraad;
                        qry.VoorraadLocatie = Instrument.VoorraadLocatie;
                        qry.Datumwijziging = Instrument.Datumwijziging;
                        qry.MaxTemp = Instrument.MaxTemp;
                        qry.MinTemp = Instrument.MinTemp;
                        qry.Bijzonderheden = Instrument.Bijzonderheden;
                        db.SaveChanges();
                        toReturn = Instrument.ID;
                    }
                    else
                    {
                        db.Instrumenten.Add(Instrument);
                        db.SaveChanges();
                        toReturn = Instrument.ID;
                    }
                    return toReturn;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
        }

        public bool DeleteInstrumentFromNet(int netID, int instrumentID)
        {
            try
            {
                using (ERBA_Entities db = new ERBA_Entities())
                {
                    var qry = db.NetInstrument.Where(ni => ni.NETID == netID && instrumentID == ni.INSID).ToList();
                    foreach (NetInstrument inst in qry)
                    {
                        db.NetInstrument.Remove(inst);
                    }
                    db.SaveChanges();
                    return true;
                    //if (qry.AantalINS > 0)
                    //{
                    //    qry.AantalINS -= 1;
                    //    db.SaveChanges();
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
