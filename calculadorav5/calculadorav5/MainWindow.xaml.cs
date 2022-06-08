using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace calculadorav5
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        long numero1 = 0;
        long numero2 = 0;
        string operacion = "";

        public MainWindow()
        {
            InitializeComponent();
        }



        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 1;
                Pantalla.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 1;
                Pantalla.Text = numero2.ToString();
            }

        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 2;
                Pantalla.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 2;
                Pantalla.Text = numero2.ToString();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 3;
                Pantalla.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 3;
                Pantalla.Text = numero2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 4;
                Pantalla.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 4;
                Pantalla.Text = numero2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 5;
                Pantalla.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 5;
                Pantalla.Text = numero2.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 6;
                Pantalla.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 6;
                Pantalla.Text = numero2.ToString();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 7;
                Pantalla.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 7;
                Pantalla.Text = numero2.ToString();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 8;
                Pantalla.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 8;
                Pantalla.Text = numero2.ToString();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 9;
                Pantalla.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 9;
                Pantalla.Text = numero2.ToString();
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10);
                Pantalla.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10);
                Pantalla.Text = numero2.ToString();
            }
        }

        private void btnSumar_Click(object sender, RoutedEventArgs e)
        {
            operacion = "+";
            Pantalla.Text = "0";
        }

        private void btnRestar_Click(object sender, RoutedEventArgs e)
        {
            operacion = "-";
            Pantalla.Text = "0";
        }

        private void btnMultiplicar_Click(object sender, RoutedEventArgs e)
        {
            operacion = "*";
            Pantalla.Text = "0";
        }

        private void btnDividir_Click(object sender, RoutedEventArgs e)
        {
            operacion = "/";
            Pantalla.Text = "0";
        }

        private void btnResultado_Click(object sender, RoutedEventArgs e)
        {
            switch (operacion)
            {
                case "+":
                    Pantalla.Text = (numero1 + numero2).ToString();
                    break;
                case "-":
                    Pantalla.Text = (numero1 - numero2).ToString();
                    break;
                case "*":
                    Pantalla.Text = (numero1 * numero2).ToString();
                    break;
                case "/":
                    Pantalla.Text = (numero1 / numero2).ToString();
                    break;

            }
            numero1 = 0;
            numero2 = 0;
            operacion = "";
        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            //CE: CLEAR ENTRY
            if (operacion == "")
            {
                numero1 = 0;
            }
            else
            {
                numero2 = 0;
            }
            Pantalla.Text = "0";

        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            //C: CLEAR
            numero1 = 0;
            numero2 = 0;
            operacion = "";
            Pantalla.Text = "0";

        }

        

        


        //MENU CONFIG
        private void SalirMenu_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resultado = MessageBox.Show("¿Estás seguro?", "Atención", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (resultado == MessageBoxResult.Yes)
            {
                Close();
            }
        }

        private void LetraCursiva_Checked(object sender, RoutedEventArgs e)
        {
            Pantalla.FontStyle = FontStyles.Italic;
            Pantalla.FontWeight = FontWeights.Light;



        }

        private void LetraCursiva_Unchecked(object sender, RoutedEventArgs e)
        {
            Pantalla.FontStyle = FontStyles.Normal;
        }

        private void LetraNegrita_Checked(object sender, RoutedEventArgs e)
        {
            Pantalla.FontWeight = FontWeights.Bold;
        }

        private void LetraNegrita_Unchecked(object sender, RoutedEventArgs e)
        {
            Pantalla.FontWeight = FontWeights.Light;
        }

        private void LetraNormal_Checked(object sender, RoutedEventArgs e)
        {
            Pantalla.FontStyle = FontStyles.Normal;
            Pantalla.FontWeight = FontWeights.Light;
        }

        private void LetraNormal_Unchecked(object sender, RoutedEventArgs e)
        {
            Pantalla.FontStyle = FontStyles.Normal;
            Pantalla.FontWeight = FontWeights.Light;
        }

        private void AyudaMenu_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resultado = MessageBox.Show("Intrucciones para navegar por el menú:" + "\r\n" + "Opciones - Navega por las opciones de la calculadora" + "\r\n" + " Formato - Cambia el tipo de letra de la pantalla" + "\r\n" + " Ayuda - Muestra el cuadro de ayuda", "Ayuda");
        }
    }



}
