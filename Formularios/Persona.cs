using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios
{
    internal class Persona
    {
        public String Nombre { get; set; }
        public int Edad { get; set; }
        public String Email { get; set; }
        public String Cedula { get; set; }
        public String TipoSangre { get; set; }

        public Persona(String nombre, int edad, String email, String cedula, String tipoSangre) 
        { 
            Nombre = nombre;
            Edad = Edad;
            Email = email;
            Cedula = cedula;
             TipoSangre = tipoSangre;
        }


    }
}
