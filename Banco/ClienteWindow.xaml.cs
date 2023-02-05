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
    /// Lógica interna para ClienteWindow.xaml
    /// </summary>
    public partial class ClienteWindow : Window
    {
        public ClienteWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Cliente c = new Cliente();
            c.Id = int.Parse(txtId.Text);
            c.Nome = txtNome.Text;
            c.Cpf = int.Parse(txtCpf.Text);
            c.Email = txtEmail.Text;
            NCliente.Inserir(c);
            ListarClick_Click(sender, e);

        }

        private void ListarClick_Click(object sender, RoutedEventArgs e)
        {
            listClientes.ItemsSource = null;
            listClientes.ItemsSource = NCliente.Listar();
        }

        private void AtualizarClick_Click(object sender, RoutedEventArgs e)
        {
            Cliente c = new Cliente();
            c.Id = int.Parse(txtId.Text);
            c.Nome = txtNome.Text;
            c.Cpf = int.Parse(txtCpf.Text);
            c.Email = txtEmail.Text;
            NCliente.Atualizar(c);
            ListarClick_Click(sender, e);
        }

        private void ExcluirClick_Click(object sender, RoutedEventArgs e)
        {
            Cliente c = new Cliente();
            c.Id = int.Parse(txtId.Text);
            NCliente.Excluir(c);
            ListarClick_Click(sender, e);
        }

        private void listClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listClientes.SelectedItem != null)
            {
                Cliente obj = (Cliente)listClientes.SelectedItem;
                txtId.Text = obj.Id.ToString();
                txtNome.Text = obj.Nome;
                txtCpf.Text = obj.Cpf.ToString();
                txtEmail.Text = obj.Email.ToString();
            }
        }
    }
}
