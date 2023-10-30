using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double pesot = double.Parse(txtPeso.Text);
                double alturat = double.Parse(txtAltura.Text);

                double resultado = pesot / (alturat * alturat);

                txtResultado.Text = resultado.ToString();

                if (resultado < 18.5)
                {
                    lblResultado.Text = "Abaixo do peso";
                    lblResultado.ForeColor = Color.Red;

                }
                else if (resultado < 24.9)
                {
                    lblResultado.Text = "Peso ideal, parabéns!";
                    lblResultado.ForeColor = Color.Orange;
                }
                else if (resultado < 29.9)
                {
                    lblResultado.Text = "Levemente acima do peso";
                    lblResultado.ForeColor = Color.Purple;
                }
                else if (resultado < 34.9)
                {
                    lblResultado.Text = "Obesidade grau I";
                    lblResultado.ForeColor = Color.Yellow;

                }
                else if (resultado < 39.9)
                {
                    lblResultado.Text = "Obesidade grau II";
                    lblResultado.ForeColor = Color.Black;
                }
                else if (resultado > 40)
                {
                    lblResultado.Text = "Obesidade III";
                    lblResultado.ForeColor = Color.Pink;
                }
            
            
            
            }
            catch
            {
                MessageBox.Show("Os dados não foram encontrados!");
                txtResultado.Clear();
                txtPeso.Clear();
                txtAltura.Clear();

            }

            

            
            

            

            
            

            
            

            


        }
        
    }
}
