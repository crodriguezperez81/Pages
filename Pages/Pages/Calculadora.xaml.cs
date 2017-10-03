using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calculadora : ContentPage
    {
        double n1 = 0.0;
        double n2 = 0.0;
        string operacion = "";

        public Calculadora()
        {
            InitializeComponent();
        }
        private void mas_Clicked(object sender, EventArgs e)
        {

            if (n1 == 0)
            {
                n1 = Convert.ToDouble(texto.Text);
                operacion = "suma";
                texto.Text = "";
            }
        }


        private void igual_Clicked(object sender, EventArgs e)
        {
            n2 = Convert.ToDouble(texto.Text);

            switch (operacion)
            {
                case "dividir":
                    texto.Text = Convert.ToString(n1 / n2);
                    n2 = 0;
                    n1 = 0;
                    break;
                case "multiplicar":
                    texto.Text = Convert.ToString(n1 * n2);
                    n2 = 0;
                    n1 = 0;
                    break;
                case "suma":
                    texto.Text = Convert.ToString(n1 + n2);
                    n2 = 0;
                    n1 = 0;
                    break;
                case "resta":
                    texto.Text = Convert.ToString(n1 - n2);
                    n2 = 0;
                    n1 = 0;
                    break;
                default:
                    texto.Text = "ERROR";
                    break;
            }
        }

        private void punto_Clicked(object sender, EventArgs e)
        {
            if (texto.Text.Contains("."))
            {
                texto.Text = texto.Text;
            }
            else
            {
                texto.Text = texto.Text + ".";
            }

        }

        private void menos_Clicked(object sender, EventArgs e)
        {
            if (n1 == 0)
            {
                n1 = Convert.ToDouble(texto.Text);
                operacion = "resta";
                texto.Text = "";
            }
        }

        private void tres_Clicked(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "3";
        }

        private void dos_Clicked(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "2";
        }

        private void uno_Clicked(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "1";
        }

        private void por_Clicked(object sender, EventArgs e)
        {
            if (n1 == 0)
            {
                n1 = Convert.ToDouble(texto.Text);
                operacion = "multiplicar";
                texto.Text = "";
            }
        }

        private void seis_Clicked(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "6";
        }

        private void cinco_Clicked(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "5";
        }

        private void cuatro_Clicked(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "4";
        }

        private void entre_Clicked(object sender, EventArgs e)
        {
            if (n1 == 0)
            {
                n1 = Convert.ToDouble(texto.Text);
                operacion = "dividir";
                texto.Text = "";
            }
        }

        private void nueve_Clicked(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "9";
        }

        private void ocho_Clicked(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "8";
        }

        private void siete_Clicked(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "7";
        }

        private void c_Clicked(object sender, EventArgs e)
        {
            texto.Text = "";
        }

        private void cero_Clicked(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "0";
        }

        private void ini_Clicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}