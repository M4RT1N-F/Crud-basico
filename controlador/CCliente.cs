using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using modelo;

namespace controlador
{
    public class CCliente
    {
        MCliente objCliente = new MCliente();

        public DataView listarCliente()
        {
            DataView dv = new DataView();
            dv.Table = objCliente.listar();
            return dv;
        }
        public void insertarCliente(MCliente obj)
        {
            objCliente.insertar(obj);
        }
        public MCliente modificarCliente(int id)
        {
            MCliente obj = new MCliente();
            obj = objCliente.modificar(id);
            return obj;
        }
        public void actualizarCliente(MCliente obj)
        {
            objCliente.actualizar(obj);
        }
        public void eliminarCliente(int id)
        {
            objCliente.eliminar(id);
        }
    }
}
