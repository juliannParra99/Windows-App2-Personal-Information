using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Al presionar el botón aceptar se debe validar que los text Apellido, Nombre, Edad y
//Dirección tengan datos, en caso de estar vacíos marcarlos de color rojo.
//Si pasa la validación los datos se deben escribir en el text de resultado (TextBox
//multilínea) con el siguiente formato:
//Apellido y Nombre: XXXXXXXXXXXXXXX
//Edad: XXX
//Dirección: XXXXXXXXXXXXXXXXXXXXX
//En el campo Edad solo debe aceptar Números.
//En todos los campos limitar la cantidad de caracteres y pasarlos a mayúsculas.
//Al presionar el botón Cancelar se debe cerrar la aplicación.

namespace formDatas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8) //ASCII para saber que teclas se presionaron
            {
                e.Handled = true;
            }

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {


            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string age = txtAge.Text;
            string address = txtAddress.Text;

            string result = "FULL NAME: " + firstName  + lastName + ",  Age: " + age + ", Address: " + address; //ordenarlo descendentemente
            txtResult.Text = result;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}