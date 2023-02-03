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
    /// Lógica interna para CadClienteBanco.xaml
    /// </summary>
    public partial class CadClienteBanco : Window
    {
        public CadClienteBanco()
        {
            InitializeComponent();
        }

        private void CadastrarClick(object sender, RoutedEventArgs e)
        {
            if (listBancos.SelectedItem != null &&
                listClientes.SelectedItem != null)
            {
                Cliente c = (Cliente)listClientes.SelectedItem;
                Banco b = (Banco)listBancos.SelectedItem;
                NCliente.Cadastrar(c, b);
                ListarClick(sender, e);
            }
            else
            {
                MessageBox.Show("É preciso selecionar um cliente e um banco");
            }

        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listBancos.ItemsSource = null;
            listBancos.ItemsSource = NBanco.Listar();
            listClientes.ItemsSource = null;
            listClientes.ItemsSource = NCliente.Listar();
        }
    }
}
