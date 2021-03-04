using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cliente
{
    public partial class Form_modificarCliente : Form
    {
        public Form_modificarCliente()
        {
            InitializeComponent();
        }

        private void Form_modificarCliente_Load(object sender, EventArgs e)
        {

        }

        private void bt_actualizar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }
    }
}
