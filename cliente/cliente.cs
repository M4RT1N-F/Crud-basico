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
    public partial class cliente : Form
    {
        CCliente objCliente = new CCliente();
        DataView dv = new DataView();

        int pk_registro = 0;
        int pk_editar = 0;
        public cliente()
        {
            InitializeComponent();
        }
        private void estilo()
        {
            dg_cliente.AllowUserToAddRows = false;
            dg_cliente.MultiSelect = false;
            dg_cliente.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dg_cliente.DefaultCellStyle.SelectionBackColor = Color.Coral;
            dg_cliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_cliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_cliente.ReadOnly = true;

            dg_cliente.Columns["id_cliente"].Visible = false;
            dg_cliente.Columns["nombre"].HeaderText = "Nombre Cliente";
            dg_cliente.Columns["apellido"].HeaderText = "Apellidos";
            dg_cliente.Columns["telefono"].HeaderText = "DNI";
            dg_cliente.Columns["dni"].HeaderText = "Telefono";
            dg_cliente.Columns["correo"].HeaderText = "Correo";
        }
        private void listarCliente()
        {
            dv = objCliente.listarCliente();
            dg_cliente.DataSource = dv;
        }

        private void cliente_Load(object sender, EventArgs e)
        {
            listarCliente();
            estilo();
        }
        
        private void insertarCliente()
        {
            Form_nuevoCliente cliente = new Form_nuevoCliente();
            DialogResult resultado = cliente.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("Se agrego correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listarCliente();
            }
        }

        private void bt_nuevoCliente_Click(object sender, EventArgs e)
        {
            insertarCliente();
        }
        private void modificarCliente()
        {
            if(pk_registro > 0)
            {
                Form_modificarCliente cliente = new Form_modificarCliente();
                MCliente obj = new MCliente();
                obj = objCliente.modificarCliente(pk_registro);

                pk_editar = obj.id_cliente;
                cliente.txt_nombre.Text = obj.nombre;
                cliente.txt_apellido.Text = obj.apellido;
                cliente.txt_telefono.Text = obj.telefono.ToString();
                cliente.txt_dni.Text = obj.dni.ToString();
                cliente.txt_correo.Text = obj.correo;

                DialogResult resultado = cliente.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    obj.nombre = cliente.txt_nombre.Text;
                    obj.apellido = cliente.txt_apellido.Text;
                    obj.telefono = Convert.ToInt32(cliente.txt_dni.Text);
                    obj.dni = Convert.ToInt32(cliente.txt_dni.Text);
                    obj.correo = cliente.txt_correo.Text;
                    obj.id_cliente = pk_editar;

                    objCliente.actualizarCliente(obj);

                    MessageBox.Show("Se actualizo correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listarCliente();
                }
            }
        }

        private void bt_modificarCliente_Click(object sender, EventArgs e)
        {
            modificarCliente();
        }

        private void dg_cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pk_registro = Convert.ToInt32(dg_cliente.CurrentRow.Cells["id_cliente"].Value.ToString());
        }
        private void eliminarCliente()
        {
            if(pk_registro > 0)
            {
                DialogResult resultado = MessageBox.Show("Deseas eliminar este registro", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if(resultado == DialogResult.OK)
                {
                    MessageBox.Show("Eliminado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objCliente.eliminarCliente(pk_registro);
                    listarCliente();
                }
            }
        }

        private void bt_eliminarCliente_Click(object sender, EventArgs e)
        {
            eliminarCliente();
        }
    }
}
