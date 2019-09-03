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
    /// Lógica de interacción para ucPersonasFRM.xaml
    /// </summary>
    public partial class ucPersonasFRM : UserControl {
        public ucPersonasFRM() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            MainWindow.Actual.Cambia(new ucPersonasLST());
        }
    }
}
