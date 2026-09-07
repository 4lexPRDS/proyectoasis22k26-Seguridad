using CapaModelo_Seguridad.Contratos;
using CapaModelo_Seguridad.Repositorios;
using CapaModelo_Seguridad.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Seguridad.Repositorios
{
    public class RepositorioUsuarios: Sentencias, IRepositorioUsuarios
    {
        private string selectAll;
        private string insert;  
        private string delete;  
        private string update;
       public RepositorioUsuarios()
        {
            selectAll = "SELECT idUsuario," +
                "idEmpleado," +
                "usuarioUsuario," +
                "ultimoAccesoUsuario FROM tblusuario";
            insert= "INSERT INTO tblusuario VALUES (NULL,?,?,?,?)";

            update = "UPDATE tblusuario SET idEmpleado=?, usuarioUsuario=?, contrasenaUsuario=?, ultimoAccesoUsuario=? WHERE idUsuario=?"; 

            delete = "DELETE FROM tblusuario WHERE idUsuario=?";
        }

        public int Agregar(Usuarios entidad)
        {
            var _parametros = new List<OdbcParameter>();
            _parametros.Add(new OdbcParameter("p_idEmpleado", entidad.idEmpleado));
            _parametros.Add(new OdbcParameter("p_usuarioUsuario", entidad.usuarioUsuario));
          
            _parametros.Add(new OdbcParameter("p_contrasenaUsuario", entidad.contrasenaUsuario));
            _parametros.Add(new OdbcParameter("p_ultimoAccesoUsuario", entidad.ultimoAccesoUsuario));

            return EjecucionNonQuery(insert, _parametros, CommandType.Text);
        }
        public int Editar(Usuarios entidad)
        {
            var _parametros = new List<OdbcParameter>();
            _parametros.Add(new OdbcParameter("p_idEmpleado", entidad.idEmpleado));
            _parametros.Add(new OdbcParameter("p_usuarioUsuario", entidad.usuarioUsuario));
            
            _parametros.Add(new OdbcParameter("p_contrasenaUsuario", entidad.contrasenaUsuario));
            _parametros.Add(new OdbcParameter("p_ultimoAccesoUsuario", entidad.ultimoAccesoUsuario));
            _parametros.Add(new OdbcParameter("p_idUsuario", entidad.idUsuario));
            return EjecucionNonQuery(update, _parametros, CommandType.Text);
        }
        public int Remover(Usuarios entidad)
        {
            var _parametros = new List<OdbcParameter>();
            _parametros.Add(new OdbcParameter("p_idUsuario", entidad.idUsuario));
            return EjecucionNonQuery(delete, _parametros, CommandType.Text);
        }
        public IEnumerable<Usuarios> GetAll()
        {
            var lstUsuario = new List<Usuarios>();
            var tblTabla = EjecucionConsulta(selectAll, CommandType.Text);
            foreach (DataRow row in tblTabla.Rows)
            {
                var empleado = new Usuarios();
                empleado.idUsuario = Convert.ToInt32(row[0]);
                empleado.idEmpleado = Convert.ToInt32(row[1]);
                empleado.usuarioUsuario = row[2].ToString();
               
                empleado.ultimoAccesoUsuario = Convert.ToDateTime(row[3]);
                lstUsuario.Add(empleado);
            }
            tblTabla.Clear();
            tblTabla = null;
            return lstUsuario;
        }


    }
}
