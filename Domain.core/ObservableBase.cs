using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Base {
    public abstract class ObservableBase : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propiedad) {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
        }
    }

    public abstract class EntityBase : ObservableBase, IDataErrorInfo {
        public virtual string this[string columnName] => null; 

        public virtual string Error {
            get {
                var msg = "";
                foreach (var p in this.GetType().GetProperties()) {
                    var cad = this[p.Name];
                    if (cad != null)
                        msg += cad + "\n";
                }
                return msg == "" ? null : msg;
            }
        }

        public virtual bool HasErrors => Error != null;
    }
}
