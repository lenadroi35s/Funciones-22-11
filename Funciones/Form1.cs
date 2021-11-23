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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int contador = cuenta_letra(this.txtfrase.Text,"a");
            this.txtResultado.Text = contador.ToString();

        }
        /// <summary>
        /// Cuenta la cantidad de 'a' que existen en una frase
        /// </summary>
        /// <param name="frase"></param>
        /// <returns></returns>
        private int cuenta_letra(string frase, string letra)
        {
            int conta = 0;
            for (int x=0; x<frase.Length; x++ )
            {
                if (frase[x].ToString().ToLower() == letra.ToLower())
                    conta++;
            }
            return conta;
        }
       
    }
}
