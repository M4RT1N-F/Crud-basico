using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using modelo;
using controlador;

namespace cliente
{
    public partial class Form_nuevoCliente : Form
    {
        CCliente objCliente = new CCliente(); 
        public Form_nuevoCliente()
        {
            InitializeComponent();
        }
        private void insertarCliente()
        {
            MCliente obj = new MCliente();
            obj.nombre = txt_nombre.Text;
            obj.apellido = txt_apellido.Text;
            obj.telefono = Convert.ToInt32(txt_telefono.Text);
            obj.dni = Convert.ToInt32(txt_dni.Text);
            obj.correo = txt_correo.Text;

            objCliente.insertarCliente(obj);

        }
        private void Form_nuevoCliente_Load(object sender, EventArgs e)
        {

        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            insertarCliente();
           
        }
      
        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        
        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                
            }
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
               
            }
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }else if (char.IsControl(e.KeyChar)) 
            {
                e.Handled = false;
            }else 
            {
                e.Handled = true;
            }
        }

        private void txt_dni_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
