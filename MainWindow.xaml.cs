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

namespace Atividade1
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }

        private void btEntrar_Click(object sender, RoutedEventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = passBoxSenha.Password.ToString();

            if (usuario == "Luana" && senha== "123")
            {
                MessageBox.Show("Login Realizado com Sucesso!");
                janela1 principal = new janela1();
                principal.ShowDialog();
                MainWindow mainWindow = new MainWindow();
                mainWindow.Close();
            }
            else
            {
                MessageBox.Show("Senha ou Usuário Incorreto!","Aviso",MessageBoxButton.OK,MessageBoxImage.Exclamation);
            }
        }

        private void passBoxSenha_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void passBoxSenha_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btEntrar_Click(sender, e);
            }
        }

        private void buttonCadastrar_Click(object sender, RoutedEventArgs e)
        {
            cadastrogrid principal = new cadastrogrid();
            principal.ShowDialog();
        }
    }
}
