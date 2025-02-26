using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios
{
    internal class Crud
    {
        public List<Persona> listaPersona= new List<Persona>();

        public void agregarPersona(Persona persona)
        {
            listaPersona.Add(persona);
        }
    }
}
