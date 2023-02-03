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

namespace Banco
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Cliente_Click(object sender, RoutedEventArgs e)
        {
            ClienteWindow w = new ClienteWindow();
            w.ShowDialog();
        }

        private void Conta_Click(object sender, RoutedEventArgs e)
        {
            ContaWindow w = new ContaWindow();
            w.ShowDialog();
        }

        private void Banco_Click(object sender, RoutedEventArgs e)
        {
            BancoWindow w = new BancoWindow();
            w.ShowDialog();
        }

        private void CadClienteConta_Click(object sender, RoutedEventArgs e)
        {
            CadastroClienteConta w = new CadastroClienteConta();
            w.ShowDialog();
        }

        private void CadClienteBanco_Click(object sender, RoutedEventArgs e)
        {
            CadClienteBanco w = new CadClienteBanco();
            w.ShowDialog();
        }

        private void ListClienteBanco_Click(object sender, RoutedEventArgs e)
        {
            ListClienteBanco w = new ListClienteBanco();
            w.ShowDialog();
        }

        private void ListClienteConta_Click(object sender, RoutedEventArgs e)
        {
            ListContaCliente w = new ListContaCliente();
            w.ShowDialog();
        }
    }
}
