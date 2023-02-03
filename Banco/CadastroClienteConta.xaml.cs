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
    /// Lógica interna para CadastroClienteConta.xaml
    /// </summary>
    public partial class CadastroClienteConta : Window
    {
        public CadastroClienteConta()
        {
            InitializeComponent();
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listContas.ItemsSource = null;
            listContas.ItemsSource = NConta.Listar();
            listClientes.ItemsSource = null;
            listClientes.ItemsSource = NCliente.Listar();
        }

        private void VincularClick(object sender, RoutedEventArgs e)
        {
            if (listContas.SelectedItem != null && listClientes.SelectedItem != null)
            {
                Conta co = (Conta)listContas.SelectedItem;
                Cliente ci = (Cliente)listClientes.SelectedItem;
                NCliente.Vincular(co, ci);
                ListarClick(sender, e);
            }
            else
            {
                MessageBox.Show("É preciso selecionar uma conta e um cliente!");
            }
        }
    }
}
