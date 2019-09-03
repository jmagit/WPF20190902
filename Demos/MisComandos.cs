using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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
    public class MisComandos {
        private string cad;
        public ICommand Abrir {
            get {
                return new DelegateCommand<string>(
                    cmdParam => {
                        cad = cmdParam;
                    },
                    cmdParam => {
                        return true;
                    }
                    );
            }
        }
    }
}
