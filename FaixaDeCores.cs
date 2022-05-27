using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaixaDeCorResistor
{
     public partial class Faixas_de_cores : Form
    {
        string faixa1, faixa2, faixa3;

        #region Faixa4
        private void btn_dourado4_Click(object sender, EventArgs e)
        {
            txt_tolerancia.Text = "5";
            txt_faixa4.BackColor = Color.Gold;
        }
        private void btn_prateado4_Click(object sender, EventArgs e)
        {
            txt_tolerancia.Text = "10";
            txt_faixa4.BackColor = Color.Silver;
        }
        private void btn_vermelho4_Click(object sender, EventArgs e)
        {
            txt_tolerancia.Text = "2";
            txt_faixa4.BackColor = Color.Red;
        }

        private void btn_verde4_Click(object sender, EventArgs e)
        {
            txt_tolerancia.Text = "0,5";
            txt_faixa4.BackColor = Color.Green;
        }

        private void btn_azul4_Click(object sender, EventArgs e)
        {
            txt_tolerancia.Text = "0,25";
            txt_faixa4.BackColor = Color.Blue;
        }

        private void btn_violeta4_Click(object sender, EventArgs e)
        {
            txt_tolerancia.Text = "0,1";
            txt_faixa4.BackColor = Color.Violet;
        }

        private void btn_cinza4_Click(object sender, EventArgs e)
        {
            txt_tolerancia.Text = "0,05";
            txt_faixa4.BackColor = Color.Gray;
        }

        private void btn_marrom4_Click(object sender, EventArgs e)
        {
            txt_tolerancia.Text = "1";
            txt_faixa4.BackColor = Color.Brown;
        }
        #endregion

        #region Faixa3
        public void btn_vermelho3_Click(object sender, EventArgs e)
        {
            faixa3 = "00";
            txt_faixa3.BackColor = Color.Red;
        }

        private void btn_laranja3_Click(object sender, EventArgs e)
        {
            faixa3 = "000";
            txt_faixa3.BackColor = Color.Orange;
        }

        private void btn_amarelo3_Click(object sender, EventArgs e)
        {
            faixa3 = "0000";
            txt_faixa3.BackColor = Color.Yellow;
        }

        private void btn_verde3_Click(object sender, EventArgs e)
        {
            faixa3 = "00000";
            txt_faixa3.BackColor = Color.Green;
        }

        private void btn_azul3_Click(object sender, EventArgs e)
        {
            faixa3 = "000000";
            txt_faixa3.BackColor = Color.Blue;
        }

        private void btn_violeta3_Click(object sender, EventArgs e)
        {
            faixa3 = "0000000";
            txt_faixa3.BackColor = Color.Violet;
        }

        private void btn_cinza3_Click(object sender, EventArgs e)
        {
            faixa3 = "00000000";
            txt_faixa3.BackColor = Color.Gray;
        }

        private void btn_branco3_Click(object sender, EventArgs e)
        {
            faixa3 = "000000000";
            txt_faixa3.BackColor = Color.White;
        }

        private void btn_marrom3_Click(object sender, EventArgs e)
        {
            faixa3 = "0";
            txt_faixa3.BackColor = Color.Brown;
        }

        private void btn_preto3_Click(object sender, EventArgs e)
        {
            faixa3 = "";
            txt_faixa3.BackColor = Color.Black;
        }
        #endregion

        #region Faixa2
        private void btn_vermelho2_Click(object sender, EventArgs e)
        {
            faixa2 = "2";
            txt_faixa2.BackColor = Color.Red;
        }

        private void btn_laranja2_Click(object sender, EventArgs e)
        {
            faixa2 = "3";
            txt_faixa2.BackColor = Color.Orange;
        }

        private void btn_amarelo2_Click(object sender, EventArgs e)
        {
            faixa2 = "4";
            txt_faixa2.BackColor = Color.Yellow;
        }

        private void btn_verde2_Click(object sender, EventArgs e)
        {
            faixa2 = "5";
            txt_faixa2.BackColor = Color.Green;
        }

        private void btn_azul2_Click(object sender, EventArgs e)
        {
            faixa2 = "6";
            txt_faixa2.BackColor = Color.Blue;
        }

        private void btn_violeta2_Click(object sender, EventArgs e)
        {
            faixa2 = "7";
            txt_faixa2.BackColor = Color.Violet;
        }

        private void btn_cinza2_Click(object sender, EventArgs e)
        {
            faixa2 = "8";
            txt_faixa2.BackColor = Color.Gray;
        }

        private void btn_branco2_Click(object sender, EventArgs e)
        {
            faixa2 = "9";
            txt_faixa2.BackColor = Color.White;
        }

        private void btn_marrom2_Click(object sender, EventArgs e)
        {
            faixa2 = "1";
            txt_faixa2.BackColor = Color.Brown;
        }

        private void btn_preto2_Click(object sender, EventArgs e)
        {
            faixa2 = "0";
            txt_faixa2.BackColor = Color.Black;
        }
        #endregion

        #region Faixa1
        private void btn_vermelho1_Click(object sender, EventArgs e)
        {
            faixa1 = "2";
            txt_faixa1.BackColor = Color.Red;
        }

        private void btn_laranja1_Click(object sender, EventArgs e)
        {
            faixa1 = "3";
            txt_faixa1.BackColor = Color.Orange;
        }

        private void btn_amarelo1_Click(object sender, EventArgs e)
        {
            faixa1 = "4";
            txt_faixa1.BackColor = Color.Yellow;
        }

        private void btn_verde1_Click(object sender, EventArgs e)
        {
            faixa1 = "5";
            txt_faixa1.BackColor = Color.Green;
        }

        private void btn_azul1_Click(object sender, EventArgs e)
        {
            faixa1 = "6";
            txt_faixa1.BackColor = Color.Blue;
        }

        private void btn_violeta1_Click(object sender, EventArgs e)
        {
            faixa1 = "7";
            txt_faixa1.BackColor = Color.Violet;
        }

        private void btn_cinza1_Click(object sender, EventArgs e)
        {
            faixa1 = "8";
            txt_faixa1.BackColor = Color.Gray;
        }

        private void btn_branco1_Click(object sender, EventArgs e)
        {
            faixa1 = "9";
            txt_faixa1.BackColor = Color.White;
        }

        private void btn_marrom1_Click(object sender, EventArgs e)
        {
            faixa1 = "1";
            txt_faixa1.BackColor = Color.Brown;
        }

        private void btn_preto1_Click(object sender, EventArgs e)
        {
            faixa1 = "0";
            txt_faixa1.BackColor = Color.Black;
        }
        #endregion

        private void Faixas_de_cores_MouseHover(object sender, EventArgs e)
        {
            CalculoFaixa obj_calculoFaixa = new CalculoFaixa(faixa1, faixa2, faixa3);
            txt_resistor.Text = obj_calculoFaixa.calculo();
        }

        public Faixas_de_cores()
        {
            InitializeComponent();
        }

    }
}
