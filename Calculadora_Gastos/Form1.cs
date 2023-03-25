using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Gastos
{
    public partial class Form1 : Form
    {
        private List<decimal> entradas = new List<decimal>();
        private List<decimal> saidas = new List<decimal>();
        private decimal saldoTotal;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            if (decimal.TryParse(textEntradas.Text, out decimal entrada))
            {
                entradas.Add(entrada);
                listBox1.Items.Add($"Entrada: {entrada:C}");
                textEntradas.Clear();
            }

            if (decimal.TryParse(textSaidas.Text, out decimal saida))
            {
                saidas.Add(saida);
                listBox1.Items.Add($"Saída: {saida:C}");
                textSaidas.Clear();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            saldoTotal = entradas.Sum() - saidas.Sum();
            textResultado.Text = $"Saldo total: {saldoTotal:C}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            saldoTotal = 0;
            entradas.Clear();
            saidas.Clear();
            textResultado.Text = "Resultado";


        }
    }
}