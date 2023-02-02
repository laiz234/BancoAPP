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
    /// Lógica interna para ListContaCliente.xaml
    /// </summary>
    public partial class ListContaCliente : Window
    {
        public ListContaCliente()
        {
            InitializeComponent();
            listClientes.ItemsSource = NCliente.Listar();
        }

        private void listContas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listClientes.SelectedItem != null)
            {
                Cliente c = (Cliente)listClientes.SelectedItem;
                listContas.ItemsSource = null;
                listContas.ItemsSource = NConta.Listar(c);
            }
            else
                MessageBox.Show("É preciso selecionar um Cliente");
        }
    }
}
