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
               
              Console.WriteLine("Fin");


            }
            this.ckB8.Checked = res[7] == 1 ? true : false;
            this.ckB7.Checked = res[6] == 1 ? true : false;
            this.ckB6.Checked = res[5] == 1 ? true : false;
            this.ckB5.Checked = res[4] == 1 ? true : false;
            this.ckB4.Checked = res[3] == 1 ? true : false;
            this.ckB3.Checked = res[2] == 1 ? true : false;
            this.ckB2.Checked = res[1] == 1 ? true : false;
            this.ckB1.Checked = res[0] == 1 ? true : false;
            

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
    

        private void btnBaD_Click(object sender, EventArgs e)
        {
            bool cbk1 = this.ckB1.Checked, cbk2 = this.ckB2.Checked, cbk3 = this.ckB3.Checked, cbk4 = this.ckB4.Checked, ckb5 = this.ckB5.Checked, ckb6 = this.ckB6.Checked, ckb7 = this.ckB7.Checked, ckb8 = this.ckB8.Checked;
            int conta = 0;
            if (ckB1.Checked) conta += 1;
            if (ckB2.Checked) conta += 2;
            if (ckB3.Checked) conta += 4;
            if (ckB4.Checked) conta += 8;
            if (ckB5.Checked) conta += 16;
            if (ckB6.Checked) conta += 32;
            if (ckB7.Checked) conta += 64;
            if (ckB8.Checked) conta += 128;
            this.txtDecimal.Text = conta.ToString();





        }

        private void ckB1_CheckedChanged(object sender, EventArgs e)
        {
            SumaBinarioaDecimal();
            void SumaBinarioaDecimal()
            {
                int num = 0;
                if (ckB1.Checked) num += 1;
                if (ckB2.Checked) num += 2;
                if (ckB3.Checked) num += 4;
                if (ckB4.Checked) num += 8;
                if (ckB5.Checked) num += 16;
                if (ckB6.Checked) num += 32;
                if (ckB7.Checked) num += 64;
                if (ckB8.Checked) num += 128;
                this.txtDecimal.Text = num.ToString();
            }
        }

        private void groupResul_Enter(object sender, EventArgs e)
        {

        }
    }
}
