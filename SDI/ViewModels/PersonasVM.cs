using DevExpress.Mvvm;
using SDI.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SDI.ViewModels {
    public class PersonasVM : ObservableBase {
        event Action<EventArgs> AbrirDetalle;
        event Action<EventArgs> CerrarDetalle;
        event Action<ConsoleCancelEventArgs> PedirConfirmacion;

        private bool verDetalle = false;

        public bool VerDetalle {
            get => verDetalle;
            set { verDetalle = value; RaisePropertyChanged(nameof(VerDetalle)); }
        }

        public ICommand Abrir {
            get {
                return new DelegateCommand<bool>(
                    cmdParam => {
                        VerDetalle = cmdParam;
                    }
                    );
            }
        }

        private void GuardarCmd() {
            //if()
            //...

            VerDetalle = false;
        }

        public ICommand Guardar {
            get { return new DelegateCommand(GuardarCmd); }
        }

    }
}
