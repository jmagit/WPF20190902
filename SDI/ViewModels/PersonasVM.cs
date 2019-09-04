using DevExpress.Mvvm;
using SDI.Base;
using SDI.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SDI.ViewModels {
    public class PersonasVM : ObservableBase {
        private ObservableCollection<Persona> listado;

        public ObservableCollection<Persona> Listado {
            get => listado;
            set { listado = value; RaisePropertyChanged(nameof(Listado)); }
        }
        private Persona elemento;

        public Persona Elemento {
            get => elemento;
            set { elemento = value; RaisePropertyChanged(nameof(Elemento)); }
        }

        private PersonaService srv = new PersonaService();

        public PersonasVM() {
            Listado = srv.getAll();
        }

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
            srv.Modify(Elemento);
            VerDetalle = false;
        }

        public ICommand Guardar {
            get { return new DelegateCommand(GuardarCmd); }
        }

    }
}
