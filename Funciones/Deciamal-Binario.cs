using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funciones
{
    public partial class Deciamal_Binario : Form
    {
        public Deciamal_Binario()
        {
            InitializeComponent();
        }

        private void Deciamal_Binario_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btbAceptar_Click(object sender, EventArgs e)
        {
            int decimalN = int.Parse (this.txtDecimal.Text);
            int[] res = binario_decimal(decimalN);
            Console.WriteLine("INICIO");
            for (int i=res.Length - 1; i>= 0; i--)
            {
                Console.WriteLine("{0}", res[i]);
                if (res[0] == 1)
                {
                    this.ckB1.Checked = true;
                }
                else
                {
                    this.ckB1.Checked = false;
                }
                if (res[1] == 1)
                {
                    this.ckB2.Checked = true;
                }
                else
                {
                    this.ckB2.Checked = false;
                }
                if (res[2] == 1)
                {
                    this.ckB3.Checked = true;
                }
                else
                {
                    this.ckB3.Checked = false;
                }
                if (res[3] == 1)
                {
                    this.ckB4.Checked = true;
                }
                else
                {
                    this.ckB4.Checked = false;
                }
                if (res[4] == 1)
                {
                    this.ckB5.Checked = true;
                }
                else
                {
                    this.ckB5.Checked = false;
                }
                if (res[5] == 1)
                {
                    this.ckB6.Checked = true;
                }
                else
                {
                    this.ckB6.Checked = false;
                }
                if (res[6] == 1)
                {
                    this.ckB7.Checked = true;
                }
                else
                {
                    this.ckB7.Checked = false;
                }
                if (res[7] == 1)
                {
                    this.ckB8.Checked = true;
                }
                else
                {
                    this.ckB8.Checked = false;
                }
            Console.WriteLine("Fin");

        }
       }

        private int[] binario_decimal(int decimalN)
        {
            int[] bin = { 0, 0, 0, 0, 0, 0, 0, 0 };
            //int int[] bin = new int [8] para ingresarlos de  otra manera
            int i = 0;
            int resto = 0;
            while (decimalN >0)
            {
                resto = decimalN % 2;
                bin[i++] = resto;
                decimalN = decimalN / 2;
                Console.WriteLine("{0}",resto);
            }
            return bin;
        }
    

        private void ckB4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
