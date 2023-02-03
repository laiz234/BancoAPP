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

namespace Banco
{
    /// <summary>
    /// Lógica interna para BancoWindow.xaml
    /// </summary>
    public partial class BancoWindow : Window
    {
        public BancoWindow()
        {
            InitializeComponent();
        }

        private void InserirClick_Click(object sender, RoutedEventArgs e)
        {
            AgenciaBancaria b = new AgenciaBancaria();
            b.Id = int.Parse(txtId.Text);
            b.Nome = txtNome.Text;
            NBanco.Inserir(b);
            ListarClick_Click(sender, e);
        }

        private void ListarClick_Click(object sender, RoutedEventArgs e)
        {
            listBancos.ItemsSource = null;
            listBancos.ItemsSource = NBanco.Listar();
        }

        private void AtualizarClick_Click(object sender, RoutedEventArgs e)
        {
            AgenciaBancaria b = new AgenciaBancaria();
            b.Id = int.Parse(txtId.Text);
            b.Nome = txtNome.Text;
            NBanco.Atualizar(b);
            ListarClick_Click(sender, e);
        }

        private void ExcluirClick_Click(object sender, RoutedEventArgs e)
        {
            AgenciaBancaria b = new AgenciaBancaria();
            b.Id = int.Parse(txtId.Text);
            NBanco.Excluir(b);
            ListarClick_Click(sender, e);
        }

        private void listBancos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBancos.SelectedItem != null)
            {
                AgenciaBancaria obj = (AgenciaBancaria)listBancos.SelectedItem;
                txtId.Text = obj.Id.ToString();
                txtNome.Text = obj.Nome;
            }
        }
    }
}
