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
using SDI.Vistas;

namespace SDI {
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public static MainWindow Actual { get; set; }
        public MainWindow() {
            InitializeComponent();
            Actual = this;
        }

        private void Modeless_Click(object sender, RoutedEventArgs e) {
            Window frm = new Window();
            frm.Title = "Modeless";
            frm.Show();
        }
        private void OwnerModeless_Click(object sender, RoutedEventArgs e) {
            Window frm = new Window();
            frm.Title = "OwnerModeless";
            frm.Owner = this;
            frm.Show();
        }
        private void CDlg_Click(object sender, RoutedEventArgs e) {
            CDlg frm = CDlg.Create(new ucPersonasLST(), "Productos");
            frm.Owner = this;
            if (frm.ShowDialog() == true) {
                lbMsg.Content = "Acepta";
            } else {
                lbMsg.Content = "Cancela";
            }
            lbMsg.Content = frm.Nombre;
        }
        private void Personas_Click(object sender, RoutedEventArgs e) {
            var uc = new ucPersonasLST();
            // ...
            //ccHost.Content = uc;
            var tab = new TabItem();
            tab.Content = uc;
            tab.Header = "Personas";
            tabHost.Items.Add(tab);
        }
        private void Productos_Click(object sender, RoutedEventArgs e) {
            var uc = new ucProductos();
            uc.Titulo = "Los productos";
            // ...
            //ccHost.Content = uc;
            var tab = new TabItem();
            tab.Content = uc;
            tab.Header = "Productos";
            tabHost.Items.Add(tab);
        }
        private void Limpiar_Click(object sender, RoutedEventArgs e) {
            ccHost.Content = null;
        }
        private void Salir_Click(object sender, RoutedEventArgs e) {
            App.Current.Shutdown();
        }

        public void Cambia(UserControl uc) {
            ccHost.Content = uc;
        }
    }
}
