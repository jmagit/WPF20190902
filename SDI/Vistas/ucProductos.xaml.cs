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
    /// Lógica de interacción para ucProductos.xaml
    /// </summary>
    public partial class ucProductos : UserControl {
        private string titulo = "Productos";
        public string Titulo {
            get { return titulo; }
            set {
                titulo = value;
                txtTitulo.Text = Titulo;
            }
        }



        public int Otro {
            get { return (int)GetValue(OtroProperty); }
            set { SetValue(OtroProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Otro.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OtroProperty =
            DependencyProperty.Register("Otro", typeof(int), typeof(ucProductos), new PropertyMetadata(0));

        public static readonly RoutedEvent ChangeEvent = EventManager.RegisterRoutedEvent(
            "Change", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(ucProductos));

        public event RoutedEventHandler Tap {
            add { AddHandler(ChangeEvent, value); }
            remove { RemoveHandler(ChangeEvent, value); }
        }


        public ucProductos() {
            InitializeComponent();

        }
    }
}
