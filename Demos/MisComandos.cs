using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;

namespace Demos {
    //class UnComando : ICommand {
    //    public event EventHandler CanExecuteChanged;

    //    public bool CanExecute(object parameter) {
    //        throw new NotImplementedException();
    //    }

    //    public void Execute(object parameter) {
    //        throw new NotImplementedException();
    //    }
    //}
    public class MisComandos : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propiedad) {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
        }

        private string nombre = "Propiedad pendiente";
        public string Nombre {
            get => nombre;
            set {
                if (nombre != value) {
                    nombre = value;
                    RaisePropertyChanged(nameof(Nombre));
                    RaisePropertyChanged(nameof(OtroBoton));
                }
            }
        }
        public bool OtroBoton {
            get => Nombre != "Hola Mundo";
        }

        //private string cad;

        void kk() {
            Abrir.Execute("kk");
        }
        public ICommand Abrir {
            get {
                return new DelegateCommand<string>(
                    cmdParam => {
                        Nombre = cmdParam;
                    },
                    cmdParam => {
                        return Nombre != "Hola Mundo";
                    }
                    );
            }
        }

    }
    public class MisComandos1 : BindableBase {
        public string Nombre {
            get { return GetValue<string>(nameof(Nombre)); }
            set { SetValue(value, nameof(Nombre)); }
        }
        //private string cad;



        public ICommand Abrir {
            get {
                return new DelegateCommand<string>(
                    cmdParam => {
                        Nombre = cmdParam;
                    },
                    cmdParam => {
                        return true;
                    }
                    );
            }
        }

    }
}
