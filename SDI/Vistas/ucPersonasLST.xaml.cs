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

namespace SDI.Vistas {
    /// <summary>
    /// Lógica de interacción para ucPersonasLST.xaml
    /// </summary>
    public partial class ucPersonasLST : UserControl {
        public ucPersonasLST() {
            InitializeComponent();
        }

        private void Salir_Click(object sender, RoutedEventArgs e) {
            MainWindow.Actual.Cambia(null);
        }
        private void Ver_Click(object sender, RoutedEventArgs e) {
            MainWindow.Actual.Cambia(new ucPersonasFRM());
       }

        private void BtnNuevo_Click(object sender, RoutedEventArgs e) {
            popDlg.IsOpen = true;
        }

        private void btnCerrarPOP_Click(object sender, RoutedEventArgs e) {
            popDlg.IsOpen = false;
        }
    }
}
