using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDI.Model {
    public partial class Persona {
        public Persona(int idPersona, string nombre, string apellidos) {
            this.idPersona = idPersona;
            this.nombre = nombre;
            this.apellidos = apellidos;
        }

        public int Edad {
            get {
                return DateTime.Today.Subtract(fechaNacimiento).Days / 365;
            }
        }

        void FechaNacimientoChanged() {
            RaisePropertyChanged(nameof(Edad));
        }

        public void Jubilate() {

        }
        public override string this[string columnName] {
            get {
                switch(columnName) {
                    case nameof(Nombre):
                        if (String.IsNullOrWhiteSpace(Nombre))
                            return "Es obligatorio";
                        if(Nombre.Length > 10)
                            return "Es muy largo";
                        break;
                }
                return null;
            }
        }

    }
}
