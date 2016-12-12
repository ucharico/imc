using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MiniCalc;
namespace FrmMiniCalc
{
    public partial class FrmIMC : Form
    {
        public FrmIMC()
        {
            InitializeComponent();
        }

        private void CmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void CmdCaclular_Click(object sender, EventArgs e)
        {
            double vindicador=0;
            double vPeso=0;
            double vAltura = 0;
            if (TxtPeso.Text.Trim()=="")
            {
              MessageBox.Show("Ingrese Peso","", MessageBoxButtons.OK,MessageBoxIcon.Error);
              TxtPeso.Focus();
                
            }
            vPeso = Convert.ToDouble(TxtPeso.Text);
            vAltura = Convert.ToDouble(Txtaltura.Text);
            TxtResultado.Text = (Math.Round(vPeso / (vAltura*vAltura),1)).ToString();
            //Indicador
            vindicador = Convert.ToDouble(TxtResultado.Text);
            if (vindicador>=18.5 &&  vindicador<=24.9)
            {
                TxtIndicador.Text = "Promedio";
            }
            else if (vindicador >= 25 && vindicador <= 29.9)
            {
                TxtIndicador.Text = "Aumentado";
            }
            else if (vindicador >= 30 && vindicador <= 34.9)
            {
                TxtIndicador.Text = "Moderado";
            }
            else if (vindicador >= 35 && vindicador <= 39.9)
            {
                TxtIndicador.Text = "Severo";
            }
            else if (vindicador >= 40)
            {
                TxtIndicador.Text = "Muy Severo";
            }
        }
    }
}
