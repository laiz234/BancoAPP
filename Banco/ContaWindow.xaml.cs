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
    /// Lógica interna para ContaWindow.xaml
    /// </summary>
    public partial class ContaWindow : Window
    {
        public ContaWindow()
        {
            InitializeComponent();
        }

        private void Inserir_Click(object sender, RoutedEventArgs e)
        {
            Conta co = new Conta();
            co.Id = int.Parse(txtId.Text);
            co.Cliente = txtCliente.Text;
            co.Numero = txtNumero.Text;
            NConta.Inserir(co);
            Listar_Click_1(sender, e);
        }

        private void Listar_Click_1(object sender, RoutedEventArgs e)
        {
            listContas.ItemsSource = null;
            listContas.ItemsSource = NConta.Listar();
        }

        private void Atualizar_Click_2(object sender, RoutedEventArgs e)
        {
            Conta co = new Conta();
            co.Id = int.Parse(txtId.Text);
            co.Cliente = txtCliente.Text;
            co.Numero = txtNumero.Text;
            NConta.Atualizar(co);
            Listar_Click_1(sender, e);
        }

        private void Excluir_Click_3(object sender, RoutedEventArgs e)
        {
            Conta co = new Conta();
            co.Id = int.Parse(txtId.Text);
            NConta.Excluir(co);
            Listar_Click_1(sender, e);
        }

        private void listContas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listContas.SelectedItem != null)
            {
                Conta obj = (Conta)listContas.SelectedItem;
                txtId.Text = obj.Id.ToString();
                txtCliente.Text = obj.Cliente;
                txtNumero.Text = obj.Numero;
            }
        }
    }
}
