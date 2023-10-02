using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WinFormsXML
{
    public partial class Form1 : Form
    {
        List<Vozilo> brm = new List<Vozilo>(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtBrojKotaca.Text) % 2 == 1)
                {
                    MessageBox.Show("Nije paran broj.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                Vozilo brum = new Vozilo(txtModel.Text, Convert.ToInt32(txtGodinaProizvodnje.Text), Convert.ToInt32(txtBrojKotaca.Text));

                txtModel.Clear();
                txtGodinaProizvodnje.Clear();
                txtBrojKotaca.Clear();

                brm.Add(brum);


            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message, "Pogresan unos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnObradi_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            txtIspis.Clear();

            txtIspis.Text = "Model:" + "\nGod Proizvodnje" + "\nBroj kotaca" + "\nVozilo je:" + "\n";

            foreach (Vozilo brum in brm)
            {
                txtIspis.AppendText("\n\n" + brum.ToString());
            }
        }

        
    }
}

