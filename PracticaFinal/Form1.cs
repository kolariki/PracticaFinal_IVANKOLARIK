using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;

namespace PracticaFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidaciones_Click(object sender, EventArgs e)
        {
            validarSueldo();
            validarPuesto();
            validarLongitudNombre();
            validarLongitudApellido();

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            imprimir();
        }

        private void btnHoras_Click(object sender, EventArgs e)
        {
            int[] horas = horas = new int[5];
            int suma = 0;

            horasTrabajadas(horas);

            for (int i = 0; i < horas.Length; i++)
            {
                suma = horas[i] + suma;
            }

            double promedio = horas.Average();
            int contador = diasMenosTrabajados(horas);

            MessageBox.Show("El total de horas trabajadas es: " + suma + "\nEl promedio de las horas trabajadas esta semana es: " + promedio + "\nEsta semana se trabajaron  " + contador + " dias menos de 4 hs diarias");

        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }



        
       
        
        











        #region metodos

        private void validarSueldo()
        {

            decimal sueldo = Convert.ToDecimal(txtSueldo.Text);
            if (sueldo <= 0)
            {
                MessageBox.Show("ERROR, EL SUELDO INGRESADO DEBE SER MAYOR A CERO");
            }
        }
       
        private void validarPuesto()
        {
            string puesto = txtPuesto.Text;
            if (puesto != " Soporte Tecnico" || puesto != "DBA" || puesto != "Desarrollador")
            {
            
                MessageBox.Show("ERROR AL INGRESAR EL PUESTO, DEBE INGRESAR ALGUNA DE LAS SIGUIENTES OPCIONES: \n\nSoporte Tecnico \nDBA \nDesarrollador");
            }
        }

        private void validarLongitudNombre()
        {

            string nombre = txtNombre.Text;

            if (nombre.Length < 2)
            {
                MessageBox.Show("ERROR \nLos datos ingresados deben tener mas de dos caracteres");
            }
            else if (nombre.Length > 50)
            {
                MessageBox.Show("ERROR \nLos datos ingresados deben tener menos de 50 caracteres");
            }
        }

        private void validarLongitudApellido()
        {

            string apellido = txtApellido.Text;

            if (apellido.Length < 2)
            {
                MessageBox.Show("ERROR \nLos datos ingresados deben tener mas de dos caracteres");
            }
            else if (apellido.Length > 50)
            {
                MessageBox.Show("ERROR \nLos datos ingresados deben tener menos de 50 caracteres");
            }
        }

        private void imprimir()
        {
            string nombre = txtNombre.Text;
            string upperString = nombre.ToUpper();
            string apellido = txtApellido.Text;
            string upperString2 = apellido.ToUpper();
            string puesto = txtPuesto.Text;
            string upperString3 = puesto.ToUpper();
            decimal sueldo = Convert.ToDecimal(txtSueldo.Text);


            MessageBox.Show(upperString + " " + upperString2 + " " + upperString3);
        }


        private void horasTrabajadas(int[] horario)
        {


            for (int i = 0; i < horario.Length; i++)
            {
                int horasDiarias = Convert.ToInt32(Interaction.InputBox("Ingrese las horas trabajadas diariamente: "));
                horario[i] = horasDiarias;
            }
        }
        public int diasMenosTrabajados(int[] horario)
        {
            int contador = 0;
            for (int i = 0; i < horario.Length; i++)
            {
                if (horario[i] < 4)
                { 
                    contador++;
                } 
            }
            return contador;
        }


        private void limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtPuesto.Clear();
            txtSueldo.Clear();
        }

       
    }
}

        #endregion

       
    

