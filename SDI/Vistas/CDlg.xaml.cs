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

namespace SDI.Vistas {
    /// <summary>
    /// Lógica de interacción para CDlg.xaml
    /// </summary>
    public partial class CDlg : Window {
        public CDlg() {
            InitializeComponent();
        }

        public string Nombre { get; set; } = "Hola mundo";

        private void BtnAceptar_Click(object sender, RoutedEventArgs e) {
            // ...
            Nombre = "Hola mundo";
            this.DialogResult = true;
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e) {
            Nombre = "Adiós mundo";
            this.DialogResult = false;
        }

        public static CDlg Create(UserControl uc, string title) {
            var frm = new CDlg();
            frm.ccHost.Content = uc;
            frm.Title = title;
            return frm;
        }
    }
}
