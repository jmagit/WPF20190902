using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using DevExpress.Mvvm;
using SDI.ViewModels;
using SDI.Vistas;

namespace SDI {
    public class NavigationController {
        static MainWindow mainWindow;
        static MainWindow MainWindow {
            get {
                if (mainWindow == null) {
                    mainWindow = (MainWindow)App.Current.MainWindow;
                }
                return mainWindow;
            }

        }

        public static void AbrirPersonasListCmd() {
            MainWindow.Cambia(new ucPersonasLST());
        }
        public static ICommand AbrirPersonasList {
            get {
                return new DelegateCommand(AbrirPersonasListCmd);
            }
        }
        public static void AbrirPersonasDetCmd(PersonasVM vm) {
            var uc = new ucPersonasFRM();
            //(uc.Content as FrameworkElement).DataContext = vm;
            uc.DataContext = vm;
            vm.CerrarDetalle += Vm_CerrarDetalle;
            MainWindow.Cambia(new ucPersonasFRM());
        }

        private static void Vm_CerrarDetalle(EventArgs obj) {
            AbrirPersonasListCmd();
        }

        //public static ICommand AbrirPersonasDet {
        //    get {
        //        return new DelegateCommand(AbrirPersonasDetCmd);
        //    }
        //}
    }
}
