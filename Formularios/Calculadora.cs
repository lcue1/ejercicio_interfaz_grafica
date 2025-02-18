using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios
{
    internal class Calculadora:Operaciones//implementa operaciones
    {
        //declaro atributos
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public Calculadora(int num1, int num2) {//recibe parametros para operar
            Num1 = num1;//inicializo atributos
            Num2 = num2;
        }
        //impplemento todos los metodos de la interfaz
        public int sumar()//suma
        {
            return Num1 + Num2;
        }

        public int restar()
        {
            return Num1 - Num2;
        }
        public int multiplicar()
        {
            return Num1 * Num2;
        }

        public int dividir()
        {
            return Num1 / Num2;
        }
        public float modulo()
        {
            return Num1 % Num2;
        }


    }
}
