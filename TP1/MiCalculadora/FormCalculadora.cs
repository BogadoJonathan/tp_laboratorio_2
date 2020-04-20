using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            string[] operadores = { "+", "-", "/", "*" };
            cmbOperador.Items.AddRange(operadores);
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if(this.HayResultado())
            {
                lblResultado.Text = Convert.ToString(Int32.Parse(lblResultado.Text),2);
            }
        }

        private void IblResultado_Click(object sender, EventArgs e)
        {

        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //public LaCalculadora()        { }

        private void Limpiar()
        {
            textNumero1.Clear();
            textNumero2.Clear();
            cmbOperador.Items.Clear();
            lblResultado.Text = "";
            
        }

        private static double Operar(string numero1,string numero2,string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            return Calculadora.Operar(num1, num2, operador);
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Convert.ToString(FormCalculadora.Operar(textNumero1.Text, textNumero2.Text, cmbOperador.Text));
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (this.HayResultado())
            {
                lblResultado.Text = Convert.ToString(Convert.ToInt32(lblResultado.Text, 2));
            }
        }

        private bool HayResultado()
        {
            return !(lblResultado.Text == "");
        }
    }
}
