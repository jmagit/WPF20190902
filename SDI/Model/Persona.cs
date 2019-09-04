using SDI.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDI.Model {
    public class Persona: ObservableBase {
        private int idPersona = 0;
        public int IdPersona {
            get => idPersona;
            set { idPersona = value; RaisePropertyChanged(nameof(IdPersona)); }
        }
        private string nombre = "";
        public string Nombre {
            get => nombre;
            set { nombre = value; RaisePropertyChanged(nameof(Nombre)); }
        }
        private string apellidos = "";
        public string Apellidos {
            get => apellidos;
            set { apellidos = value; RaisePropertyChanged(nameof(Apellidos)); }
        }

        public Persona() {

        }
        public Persona(int idPersona, string nombre, string apellidos) {
            this.idPersona = idPersona;
            this.nombre = nombre;
            this.apellidos = apellidos;
        }
    }
}
