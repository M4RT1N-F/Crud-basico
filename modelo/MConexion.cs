using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace modelo
{
    public class MConexion
    {
        //creamos un enlace
        MySqlConnection conectar;
        //creamos la clase conectar
        public MConexion()
        {
            this.conectar =  new MySqlConnection("Server=localhost; Database=clientedb; port=3306;username=root;password=");
        }
        public MySqlConnection conexioDB()
        {
            return conectar;
        }
        //validamos la conexion
        public void validarConexion()
        {
            if(conectar.State == System.Data.ConnectionState.Closed)
            {
                conectar.Open();
            }
        }
    }
}
