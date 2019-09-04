using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.entities {
    public partial class Person {
        partial void BusinessEntityIDChanged() {
            RaisePropertyChanged("Total");
        }
    }
}
