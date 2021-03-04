using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace modelo
{
    public class MCliente
    {
        public int id_cliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int telefono { get; set; }
        public int dni { get; set; }
        public string correo { get; set; }

        MConexion conectar = new MConexion();
        MySqlConnection con;

        public MCliente()
        {
            this.id_cliente = 0;
            this.nombre = "";
            this.apellido = "";
            this.telefono = 0;
            this.dni = 0;
            this.correo = "";
        }
        public DataTable listar()
        {
            con = conectar.conexioDB();
            conectar.validarConexion();
            string query = "listarCliente";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dt.TableName = "cliente";
            da.Fill(dt);

            cmd.Dispose();
            con.Close();
            return dt;
        }

        public void insertar(MCliente obj)
        {
            con = conectar.conexioDB();
            conectar.validarConexion();
            string query = "insertarCliente";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nombrecli", obj.nombre);
            cmd.Parameters.AddWithValue("apellidocli", obj.apellido);
            cmd.Parameters.AddWithValue("telefonocli", obj.telefono);
            cmd.Parameters.AddWithValue("dnicli", obj.dni);
            cmd.Parameters.AddWithValue("correocli", obj.correo);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
        }
        public MCliente modificar(int id)
        {
            con = conectar.conexioDB();
            conectar.validarConexion();
            string query = "modificarCliente";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id_cliente", id);
            MySqlDataReader cursor = cmd.ExecuteReader();

            MCliente obj = new MCliente();
            if (cursor.HasRows)
            {
                while (cursor.Read())
                {
                    obj.id_cliente = Convert.ToInt32(cursor["id_cliente"].ToString());
                    obj.nombre = cursor["nombre"].ToString();
                    obj.apellido = cursor["apellido"].ToString();
                    obj.telefono = Convert.ToInt32(cursor["telefono"].ToString());
                    obj.dni = Convert.ToInt32(cursor["dni"].ToString());
                    obj.correo = cursor["correo"].ToString();
                }
            }
            cmd.Dispose();
            con.Close();
            return obj;
        }
        public void actualizar(MCliente obj)
        {
            con = conectar.conexioDB();
            conectar.validarConexion();
            string query = "actualizarCliente";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nombrecli", obj.nombre);
            cmd.Parameters.AddWithValue("apellidocli", obj.apellido);
            cmd.Parameters.AddWithValue("telefonocli", obj.telefono);
            cmd.Parameters.AddWithValue("dnicli", obj.dni);
            cmd.Parameters.AddWithValue("correocli", obj.correo);
            cmd.Parameters.AddWithValue("id_clien", obj.id_cliente);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
        }
        public void eliminar(int id)
        {
            con = conectar.conexioDB();
            conectar.validarConexion();
            string query = "eliminarCliente";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id_clien", id);
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
