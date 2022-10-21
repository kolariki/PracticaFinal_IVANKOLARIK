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
            validaciones();

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            imprimir();
        }

        private void btnHoras_Click(object sender, EventArgs e)
        {
            horasTrabajadas();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }















        #region metodos

        private void validaciones()
        {
            string nombre = txtNombre.Text;
            decimal sueldo = Convert.ToDecimal(txtSueldo.Text);
            string puesto = txtPuesto.Text;


            if (sueldo < 0 && puesto != "Soporte Técnico" || puesto != "DBA" || puesto != "Desarrollador" && nombre.Length > 1 && nombre.Length < 50)
            {
                MessageBox.Show("Uno o mas datos no son correctos!");
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

        private void horasTrabajadas()
        {
            int[] horas;
            horas = new int[5];
            double acumulado = 0;
            double promedio = 0;
            int min = Int32.MinValue;




            for (int i = 0; i < horas.Length; i++)
            {
                int numero = Convert.ToInt32(Interaction.InputBox("Ingrese horas trabajadas dia: " + (i+1)));
                horas[i] = numero;
                acumulado = acumulado + numero;
                promedio = acumulado / 5;

                
                for (int j = 0; j < horas.Length; j++)
                {
                    if (horas[j] > min) ;
                    {
                     min = horas[j];
                    }
                }
                   

            }






            MessageBox.Show("El numero total de horas trabajadas esta semana es: " + " " + acumulado + "." + " " + "El promedio de horas trabajadas es de: " + ". " + promedio + ". " + "El dia que menos horas trabajo es el dia: " + min);

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

       
    

