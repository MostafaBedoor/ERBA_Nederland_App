using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer.EntitiesClasses
{
    public class clsNetten
    {
        public List<spGetNetten_Result> GetNetten()
        {
            using (ERBA_Entities db = new ERBA_Entities())
            {
                try
                {
                    var netten = db.spGetNetten().ToList().OrderBy(l => l.Naam).ToList();
                    return netten;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
        public bool AddInstrumentToNet(int netID, int instrumentID)
        {
            using (ERBA_Entities db = new ERBA_Entities())
            {
                try
                {
                    int usedInstNumbers = db.NetInstrument.Where(instr => instr.INSID == instrumentID).Count();
                    //int availableInstNumbers = 0;
                    int availableInstNumbers = Convert.ToInt32(db.Instrumenten.Where(instr => instr.ID == instrumentID).FirstOrDefault().AantalVoorraad);
                    if (usedInstNumbers >= availableInstNumbers)
                    {
                        MessageBox.Show("Voorraad niet genoeg", "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    var qry = db.NetInstrument.Where(ni => ni.NETID == netID && ni.INSID == instrumentID).FirstOrDefault();
                    if (qry != null)
                    {
                        qry.AantalINS += 1;
                    }
                    else
                    {
                        NetInstrument netInst = new NetInstrument { NETID = netID, INSID = instrumentID, AantalINS = 1, Inlegvolgnummer = 0 };
                        db.NetInstrument.Add(netInst);
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
        public spGetNetByID_Result GetNetByID(int netNumber)
        {
            using (ERBA_Entities db = new ERBA_Entities())
            {
                try
                {
                    //var net = db.Netten.Where(n => n.ID == netNumber).FirstOrDefault();
                    var net = db.spGetNetByID(netNumber).FirstOrDefault();
                    return net;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
         public Netten GetNetByNameOrNumber(string netTekst)
        {
            using (ERBA_Entities db = new ERBA_Entities())
            {
                try
                {
                    //var net = db.Netten.Where(n => n.ID == netNumber).FirstOrDefault();
                    var nets = db.Netten.Where(n => n.Naam_net.Contains(netTekst) || n.NetNumber.Contains(netTekst)).ToList();
                    if (nets.Count == 1) return nets[0];
                    else return null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
         public bool ChangeNetLocatiomn(string netTekst, int locationID, int subLocationID)
        {
            using (ERBA_Entities db = new ERBA_Entities())
            {
                try
                {
                    //var net = db.Netten.Where(n => n.ID == netNumber).FirstOrDefault();
                    var nets = db.Netten.Where(n => n.Naam_net.Contains(netTekst) || n.NetNumber.Contains(netTekst)).ToList();
                    if (nets.Count == 1)
                    {
                        nets[0].LocatieID = locationID;
                        nets[0].SubLocatieID = subLocationID;
                        db.SaveChanges();
                        return true;
                    }
                    else return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public int AddEditNet(Netten net)
        {
            using (ERBA_Entities db = new ERBA_Entities())
            {
                int toReturn = 0;
                try
                {
                    if (net.ID > 0)
                    {
                        Netten qry = db.Netten.Where(n => n.ID == net.ID).FirstOrDefault();
                        qry.NetNumber = net.NetNumber;
                         qry.Naam_net = net.Naam_net;
                       qry.LocatieID = net.LocatieID;
                        qry.GewijzigdDoorID = net.GewijzigdDoorID;
                        qry.TempID = net.TempID;
                        qry.KasLocation = net.KasLocation;
                        qry.Datumwijziging = net.Datumwijziging;
                        qry.ExtraInfo = net.ExtraInfo;
                        db.SaveChanges();
                        toReturn = net.ID;
                    }
                    else
                    {
                        db.Netten.Add(net);
                        db.SaveChanges();
                        toReturn = net.ID;
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

        public List<Media> GetNetMedia(int netID)
        {
            using (ERBA_Entities db = new ERBA_Entities())
            {
                try
                {
                    var res = db.Media.Where(m => m.NetID == netID).ToList();
                    return res;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FOUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
        public bool EditNetBon(int netID)
        {
            using (ERBA_Entities db = new ERBA_Entities())
            {
                try
                {
                    int numberOfMonth = 0;
                    numberOfMonth =Convert.ToInt32(clsSettings.GetValueFromSettingsBySleutel("Settings", "NetSettings", "Expiration", "Month")); //Vervallenop
                    var res = db.Netten.Where(m => m.ID == netID).FirstOrDefault();
                    res.DateCSA = DateTime.Now;
                    res.Vervallenop = DateTime.Now.AddMonths(numberOfMonth);
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
