﻿using System;
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
    /// Lógica interna para ListClienteBanco.xaml
    /// </summary>
    public partial class ListClienteBanco : Window
    {
        public ListClienteBanco()
        {
            InitializeComponent();
            listBancos.ItemsSource = NBanco.Listar();
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            if (listClientes.SelectedItem != null)
            {
                Cliente c = (Cliente)listClientes.SelectedItem;
                listBancos.ItemsSource = null;
                listBancos.ItemsSource = NBanco.Listar();
            }
            else
                MessageBox.Show("É preciso selecionar um Cliente");
        }
    }
}
