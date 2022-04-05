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
using System.Windows.Shapes;

namespace Atividade1
{
    /// <summary>
    /// Lógica interna para janela1.xaml
    /// </summary>
    public partial class janela1 : Window
    {
        public janela1()
        {
            InitializeComponent();
        }

        private void btCalcular__Click(object sender, RoutedEventArgs e)
        {
            double numero1 = double.Parse(txtValor1_.Text);
            double numero2 = double.Parse(txtValor2_.Text);

            double resultado;

            resultado = numero1 - numero2;

            txtValor1_.Clear();
            txtValor2_.Clear();

            MessageBox.Show("O seu resultado é de: " + resultado);
        }

        private void btFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btCalcular2_Click(object sender, RoutedEventArgs e)
        {
            double numero1 = double.Parse(Valor1Adi.Text);
            double numero2 = double.Parse(Valor2Adi.Text);

            double resultado;

            resultado = numero1 + numero2;

            Valor1Adi.Clear();
            Valor2Adi.Clear();

            MessageBox.Show("O seu resultado é de: " + resultado);
        }

        private void btCalcular3_Click(object sender, RoutedEventArgs e)
        {
            double numero1 = double.Parse(Valor1Multi1.Text);
            double numero2 = double.Parse(Valor2Multi1.Text);

            double resultado;

            resultado = numero1 * numero2;

            Valor1Multi1.Clear();
            Valor2Multi1.Clear();

            MessageBox.Show("O seu resultado é de: " + resultado);
        }

        private void btCalcular4_Click(object sender, RoutedEventArgs e)
        {
            double numero1 = double.Parse(Valor1Div1.Text);
            double numero2 = double.Parse(Valor2Div2.Text);

            double resultado;

            resultado = numero1 / numero2;

            Valor1Div1.Clear();
            Valor2Div2.Clear();

            MessageBox.Show("O seu resultado é de: " + resultado);
        }
    }
}
