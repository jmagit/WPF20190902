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

namespace SDI.Vistas {
    /// <summary>
    /// Lógica de interacción para CDlg.xaml
    /// </summary>
    public partial class CDlg : Window {
        public CDlg() {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, RoutedEventArgs e) {
            this.DialogResult = true;
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e) {
            this.DialogResult = false;
        }
    }
}
