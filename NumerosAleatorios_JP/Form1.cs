using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosAleatorios_JP
{
    public partial class Form1 : Form
    {
        int aleatorio;
        int intentos = 5;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(txtBnumero.Text, out int numero);

            if (numero == aleatorio)
            {
                MessageBox.Show("Felicidades adivinaste");
                DialogResult volver = MessageBox.Show("¿Quiere volver a jugar?", "Resultado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (volver == DialogResult.No)
                {
                    Application.Exit();
                }
                else if (volver == DialogResult.Yes)
                {
                    aleatorio = random.Next(1, 100);
                    intentos = 5;
                    lblIntento.Text = intentos.ToString();
                    txtBnumero.Text = "";
                }

            }
            else
            {
                if(intentos == 1)
                {
                    lblIntento.Text = 0.ToString();
                    MessageBox.Show("Ha perdido el juego");
                    DialogResult volver = MessageBox.Show("¿Quiere volver a jugar?", "Resultado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (volver == DialogResult.No)
                    {
                        Application.Exit();
                    }
                    else if (volver == DialogResult.Yes)
                    {
                        aleatorio = random.Next(1, 100);
                        intentos = 5;
                        lblIntento.Text = intentos.ToString();
                        txtBnumero.Text = "";
                    }

                }
                else
                {
                    intentos = intentos - 1;
                    lblIntento.Text = intentos.ToString();
                    if (numero > aleatorio)
                    {
                        MessageBox.Show($"{numero} es mayor al numero aleatorio");
                    }
                    else
                    {
                        if (numero < aleatorio)
                        {
                            MessageBox.Show($"{numero} es menor al numero aleatorio");
                        }
                    }
                }
                
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            aleatorio = random.Next(1, 100);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
