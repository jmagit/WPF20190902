using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDI.Base {
    public abstract class ObservableBase : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propiedad) {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
        }
    }
}
