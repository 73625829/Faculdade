using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularImc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonClick_Click(object sender, EventArgs e)
        {
            string stNome = txtNome.Text;
            string stGenero = txtGenero.Text;
            int intIdade = int.Parse(txtIdade.Text);
            int dbPeso = int.Parse(txtPeso.Text);
            double dbAltura = double.Parse(txtAltura.Text);
           
            double altura, peso, resultado;
            altura = Convert.ToDouble(txtAltura.Text);
            peso = Convert.ToInt16(txtPeso.Text);
            resultado = peso / (altura * altura);
            
            MessageBox.Show("Seu IMC é de: " + resultado);
        }
    }
}
