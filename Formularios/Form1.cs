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
    public partial class Form1 : Form
    {
        Calculadora calculadora ;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            try// detecta si el usuario ingreso mal un valor
            {
                //obtengo datos del usuario
                int num1 = int.Parse(num_1.Text);
                int num2 = int.Parse(num_2.Text);
                calculadora = new Calculadora(num1, num2);//creo objeto
                calcularOperacion();//calcula la operacion segun el check seleccionado
            }
            catch (Exception ex)//cabptura el error e imprime en resultado valor no valido
            {
                result.Text = "Valor invalido";
            }

        }

        public  void calcularOperacion()//calcula operacion segun check seleccionado
        {
            if (check_suma.Checked)//si el check seleccionado es suma
            {
                result.Text= calculadora.sumar().ToString();//llama a la funcion suma del objeto
            }else if (check_resta.Checked)
            {
                result.Text = calculadora.restar().ToString();
            }
            else if (check_multi.Checked)
            {
                result.Text = calculadora.multiplicar().ToString();
            }
            else if (check_division.Checked)
            {
                result.Text = calculadora.dividir().ToString();
            }
            else if (check_modulo.Checked)
            {
                result.Text = calculadora.modulo().ToString();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void check_resta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_2(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_3(object sender, EventArgs e)
        {

        }
    }
}
