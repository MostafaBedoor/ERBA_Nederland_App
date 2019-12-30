using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.EntitiesClasses;
using DataLayer;

namespace ERBA_Manager.Configuratie.Forms
{
    public partial class frmAfdekmateriaal : DevExpress.XtraEditors.XtraForm
    {
        clsAfdekmateriaal cls = new clsAfdekmateriaal();
        //clsAfdekKlaarzetView view = new clsAfdekKlaarzetView();
        OpenFileDialog ofd = new OpenFileDialog();
        int AfID;
        public frmAfdekmateriaal(int id)
        {
            InitializeComponent();
            AfID = id;
            Comboboxes.Leveranciers(cmbLev);
            if (id!= 0)
            {
                Afdekmateriaal a =  cls.GetAfdekmateriaal(id);
                pictureBox1.Image = Image.FromFile(a.Afdekmateriaalfoto);
                ofd.FileName = a.Afdekmateriaalfoto;
                txtInfo.Text = a.Info;
                txtLocatie.Text = a.Locatie;
                txtMag.Text = a.Magazijn;
                cmbLev.SelectedValue = int.Parse(a.Leverancier);
                txtNaam.Text = a.Naam_afdekmateriaal;
                txtOmschrijving.Text = a.Omschrijving;
                txtPrijs.Text = a.Prijs.ToString();
                //gcklaarzetten.DataSource = view.GetKlaarzetten(id);
            }
        }
        
        private void itmEinde_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            this.Close();
        }

        private void btnFotoAdd_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Image Files (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void navOK_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (AfID != 0)
            {
                cls.DeleteAfdekmateriaal(AfID);
            }
            else
                AfID = cls.getmax() + 1;
            cls.InsertAfdekmateriaal(AfID, txtNaam.Text, txtOmschrijving.Text, txtLocatie.Text, txtInfo.Text, cmbLev.SelectedValue.ToString(), decimal.Parse(txtPrijs.Text), ofd.FileName, txtMag.Text);
            this.Close();
        }

        private void btnFotoDel_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            ofd.FileName = "";
        }
    }
}
