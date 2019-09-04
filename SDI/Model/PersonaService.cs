using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace SDI.Model {
    public class PersonaService {
        public ObservableCollection<Persona> getAll() {
            var rslt = new ObservableCollection<Persona>();
            rslt.Add(new Persona(1, "Pepito", "Grillo"));
            rslt.Add(new Persona(2, "Carmelo", "Coton"));
            return rslt;
        }
        public Persona get(int id) {
            return new Persona(2, "Carmelo", "Coton");
        }

        public void Add(Persona item) { }
        public void Modify(Persona item) { }
        public void Delete(Persona item) { }
    }
}
