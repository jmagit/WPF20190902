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
        class ResumenVM {
            public PersonasVM JefeVM { get; set; }
            public PersonasVM EmpleadoVM { get; set; }
        }
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
            var vm = new PersonasVM();
            var uc = new ucPersonasLST();
            uc.DataContext = vm;
            vm.AbrirDetalle += Vm_AbrirDetalle;
            MainWindow.Cambia(uc);
        }

        private static void Vm_AbrirDetalle(PasarVMArgs obj) {
            AbrirPersonasDetCmd(obj.VM as PersonasVM);
        }

        public static ICommand AbrirPersonasList {
            get {
                return new DelegateCommand(AbrirPersonasListCmd);
            }
        }
        public static void AbrirPersonasDetCmd(PersonasVM vm) {
            var uc = new ucPersonasFRM();
            uc.DataContext = vm;
            vm.CerrarDetalle += Vm_CerrarDetalle;
            MainWindow.Cambia(uc);
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
