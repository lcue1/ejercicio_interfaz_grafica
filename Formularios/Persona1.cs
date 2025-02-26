using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class Persona1 : Form
    {
        private Crud crud;
        public Persona1()
        {
            InitializeComponent();
            crud = new Crud();
;        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(crud.listaPersona.Count == 0)
            {
                MessageBox.Show("No hay registros agregados", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            mostrarInformacion();
        }
        private void mostrarInformacion()
        {

            String nombres = "";
            foreach (Persona p in crud.listaPersona)
            {
                nombres += (p.Nombre + "\n");
            }
            MessageBox.Show(nombres, "Nombres de personas");

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void registrar_persona_Click(object sender, EventArgs e)
        {
            try
            {
                String nombre = nombre_persona.Text;
                int edad = int.Parse(edad_persona.Text);
                String email = email_persona.Text;
                String cedula = cedula_persona.Text;
                String tipoSangre = tiposangre_persona.Text;

                Persona p = new Persona(nombre, edad, email, cedula, tipoSangre);
                crud.agregarPersona(p);

                MessageBox.Show("Persona agregada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese numero en edad","Dato incorrecto",MessageBoxButtons.OK);
            }
        }
    }
}
