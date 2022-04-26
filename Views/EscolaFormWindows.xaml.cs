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
using MySql.Data.MySqlClient;


namespace EscolaSistema.Views
{
    /// <summary>
    /// Lógica interna para EscolaFormWindows.xaml
    /// </summary>
    public partial class EscolaFormWindows : Window
    {
        public EscolaFormWindows()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btSalvar_Click(object sender, RoutedEventArgs e)
        {


            //Informações:

            string nome = txtNome.Text;
            string razao = TxtRazaoSocial.Text;
            string cnpj = txtCnpj.Text;
            string insc = TxtInscricao.Text;

            //Informações Complementares:

            string rdTipoPri;
            string dataCriacao = dtCriacao.SelectedDate?.ToString("yyyy-MM-dd");

            //Resposável:

            string nome2 = txtNome2.Text;
            string telefone2 = txtTelefone2.Text;

            //Endereço e Contato:

            string telefone3 = txtTelefone3.Text;
            string email3 = txtEmail3.Text;
            string rua = txtRua.Text;
            string numero = txtNumero.Text;
            string bairro = txtBairro1.Text;
            string complemento = txtComplemento1.Text;
            string cep = txtCEP.Text;
            string cidade = txtCidade.Text;
            string estado = cbBoxEstado.Text;

            if (rdFator.IsChecked == true)
            {
                rdTipoPri = "Privado";
            }
            else
            {
                rdTipoPri = "Público";
            }



            MySqlConnection conexao = new MySqlConnection("server=localhost;database=bd_sistEscola;port=3360;user=root;password=root");

            try
            {
                conexao.Open();
                var comando = conexao.CreateCommand();

                comando.CommandText = "insert into Escola values(null, @nome, @razao, @cnpj, @insc," +
                    " @tipo, @datacri, @responsavel, @responsaveltele, @email, @telefone," +
                    " @rua, @numero, @bairro, @complemento, @cep, @cidade, @estado); ";


                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@razao", razao);
                comando.Parameters.AddWithValue("@cnpj", cnpj);
                comando.Parameters.AddWithValue("@insc", insc);
                comando.Parameters.AddWithValue("@tipo", rdTipoPri);
                comando.Parameters.AddWithValue("@datacri", dataCriacao);
                comando.Parameters.AddWithValue("@responsavel", nome2);
                comando.Parameters.AddWithValue("@responsaveltele", telefone2);
                comando.Parameters.AddWithValue("@email", email3);
                comando.Parameters.AddWithValue("@telefone", telefone3);
                comando.Parameters.AddWithValue("@rua", rua);
                comando.Parameters.AddWithValue("@numero", numero);
                comando.Parameters.AddWithValue("@bairro", bairro);
                comando.Parameters.AddWithValue("@complemento", complemento);
                comando.Parameters.AddWithValue("@cep", cep);
                comando.Parameters.AddWithValue("@cidade", cidade);
                comando.Parameters.AddWithValue("@estado", estado);

                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {

                    MessageBox.Show("Registro Realizado com Sucesso!");

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void btClose_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
