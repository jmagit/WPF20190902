using DevExpress.Mvvm;
using Domain.Base;
using SDI.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SDI.ViewModels {
    public class PasarVMArgs {
        public object VM { get; set; }
    }
    //public class BaseMntViewModel<E, S> : ObservableBase {
    //    private ObservableCollection<E> listado;

    //    public ObservableCollection<E> Listado {
    //        get => listado;
    //        set { listado = value; RaisePropertyChanged(nameof(Listado)); }
    //    }
    //    private E elemento;

    //    public E Elemento {
    //        get => elemento;
    //        set { elemento = value; RaisePropertyChanged(nameof(Elemento)); }
    //    }

    //    private S srv = new S();

    //    public BaseMntViewModel() {
    //        Listado = srv.getAll();
    //    }

    //    public event Action<EventArgs> AbrirDetalle;
    //    public event Action<EventArgs> CerrarDetalle;
    //    public event Action<ConsoleCancelEventArgs> PedirConfirmacion;

    //    private bool verDetalle = false;

    //    public bool VerDetalle {
    //        get => verDetalle;
    //        set { verDetalle = value; RaisePropertyChanged(nameof(VerDetalle)); }
    //    }

    //    public ICommand Abrir {
    //        get {
    //            return new DelegateCommand<bool>(
    //                cmdParam => {
    //                    NavigationController.AbrirPersonasListCmd();
    //                }
    //                );
    //        }
    //    }
    //    public ICommand Modificar {
    //        get {
    //            return new DelegateCommand<bool>(
    //                cmdParam => {
    //                    NavigationController.AbrirPersonasDetCmd(this);
    //                }
    //                );
    //        }
    //    }

    //    protected virtual bool canSalir() { return true; }
    //    public ICommand Salir {
    //        get {
    //            return new DelegateCommand<bool>(
    //                cmdParam => {
    //                    if (canSalir() && CerrarDetalle != null)
    //                        CerrarDetalle(new EventArgs());
    //                }
    //                );
    //        }
    //    }

    //    private void GuardarCmd() {
    //        //if()
    //        //...
    //        srv.Modify(Elemento);
    //        VerDetalle = false;
    //    }

    //    public ICommand Guardar {
    //        get { return new DelegateCommand(GuardarCmd); }
    //    }

    //}

    //public class ProductosVM:BaseMntViewModel<Produto, ProductoService> {

    //}

    public class PersonasVM : ObservableBase {
        private ObservableCollection<Persona> listado = new ObservableCollection<Persona>();

        public ObservableCollection<Persona> Listado {
            get => listado;
            set { listado = value; RaisePropertyChanged(nameof(Listado)); }
        }
        private Persona elemento = new Persona();

        public Persona Elemento {
            get => elemento;
            set { elemento = value; RaisePropertyChanged(nameof(Elemento)); }
        }

        private PersonaService srv = new PersonaService();

        public PersonasVM() {
            Listado = srv.getAll();
            if(Listado.Count > 0)
                Elemento = Listado[0];
        }

        public event Action<PasarVMArgs> AbrirDetalle;
        public event Action<EventArgs> CerrarDetalle;
        public event Action<ConsoleCancelEventArgs> PedirConfirmacion;

        private bool verDetalle = false;

        public bool VerDetalle {
            get => verDetalle;
            set { verDetalle = value; RaisePropertyChanged(nameof(VerDetalle)); }
        }

        public ICommand Abrir {
            get {
                return new DelegateCommand<bool>(
                    cmdParam => {
                        NavigationController.AbrirPersonasListCmd();
                    }
                    );
            }
        }
        public ICommand Modificar {
            get {
                return new DelegateCommand<bool>(
                    cmdParam => {
                        if (AbrirDetalle != null)
                            AbrirDetalle(new PasarVMArgs() { VM = this });
                        else
                            throw new Exception("Falta el controlador de eventos.");
                        // NavigationController.AbrirPersonasDetCmd(this);
                    }
                    );
            }
        }
        public ICommand Salir {
            get {
                return new DelegateCommand<bool>(
                    cmdParam => {
                        if(CerrarDetalle != null)
                            CerrarDetalle(new EventArgs());
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
