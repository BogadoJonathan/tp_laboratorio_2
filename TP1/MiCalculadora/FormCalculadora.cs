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
            Numero number = new Numero();
            if(this.HayResultado())
            {
                lblResultado.Text = number.DecimalBinario(lblResultado.Text);
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

        /// <summary>
        /// Toma el operador si hace la cuenta necesaria con los 2 numeros ingresados
        /// </summary>
        /// <param name="numero1">Numero 1, ingresado desde el boxtext</param>
        /// <param name="numero2">Numero 2, ingresado desde el boxtext</param>
        /// <param name="numero3">Operador seleccionado</param>
        /// <returns>Retorna resultado de la operacion</returns>
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
            Numero number = new Numero();
            if (this.HayResultado())
            {
                lblResultado.Text = number.BinarioDecimal(lblResultado.Text);
            }
        }

        /// <summary>
        /// Verifica si hay resultado en el label y si es un numero entero
        /// </summary>
        /// <returns>Retorna true si hay resultado y es numero entero, de lo contrario false</returns>
        private bool HayResultado()
        {
            int aux;
            bool succes = Int32.TryParse(lblResultado.Text,out aux);
            return (!(lblResultado.Text == "") && (aux % 2) == 0 && succes);
        }
    }
}
