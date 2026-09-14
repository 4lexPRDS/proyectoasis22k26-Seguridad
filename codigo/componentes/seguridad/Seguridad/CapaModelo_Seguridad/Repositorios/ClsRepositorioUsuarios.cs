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
    public class ClsRepositorioUsuarios : ClsSentencias, IRepositorioUsuarios
    {
        private string _SelectAll;
        private string _Insert;
        private string _Delete;
        private string _Update;
        // Consulta para validar el login del usuario
        private string login = "SELECT idUsuario, idEmpleado, nombreUsuario, is_active " +
     "FROM tblusuario WHERE nombreUsuario=? AND contrasenaUsuario=? AND is_active=1";

        //Metodo para validar usuario y contraseña, retorna un objeto ClsUsuarios si es valido, de lo contrario retorna null
        public ClsUsuarios SeguridadMetValidarLogin(string usuario, string contrasena)
        {
            var _parametros = new List<OdbcParameter>();
            _parametros.Add(new OdbcParameter("p_usuario", usuario));
            _parametros.Add(new OdbcParameter("p_contrasena", contrasena));

            var tabla = SeguridadMetEjecucionConsulta(login, CommandType.Text, _parametros);

            if (tabla.Rows.Count == 0) return null;

            var row = tabla.Rows[0];
            return new ClsUsuarios
            {
                IdUsuario = Convert.ToInt32(row[0]),
                IdEmpleado = Convert.ToInt32(row[1]),
                NombreUsuario = row[2].ToString(),
                IsActive = Convert.ToInt32(row[3])
            };
        }
        public ClsRepositorioUsuarios()
        {
            _SelectAll = "SELECT idUsuario"
                         + ", idEmpleado"
                         + ",nombreUsuario"
                         + ", contrasenaUsuario"
                         + ", ultimoAccesoUsuario"
                         + ", is_active"
                         + " FROM tblusuario";
            _Insert = "INSERT INTO tblusuario (idEmpleado,nombreUsuario, contrasenaUsuario, ultimoAccesoUsuario, is_active) VALUES (?,?,?,?,?)";

            _Update = "UPDATE tblusuario SET idEmpleado=?,nombreUsuario=?, contrasenaUsuario=?, ultimoAccesoUsuario=?,is_active=? WHERE idUsuario=?";

            _Delete = "DELETE FROM tblusuario WHERE idUsuario=?";
        }

        public int SeguridadMetAgregar(ClsUsuarios Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_idEmpleado", Entidad.IdEmpleado));
            Parametros.Add(new OdbcParameter("p_nombreUsuario", Entidad.NombreUsuario));
            Parametros.Add(new OdbcParameter("p_contrasenaUsuario", Entidad.ContrasenaUsuario));
            Parametros.Add(new OdbcParameter("p_ultimoAccesoUsuario", Entidad.UltimoAccesoUsuario));
            Parametros.Add(new OdbcParameter("p_is_active", Entidad.IsActive));

            return SeguridadMetEjecucionNonQuery(_Insert, Parametros, CommandType.Text);
        }

        public int SeguridadMetEditar(ClsUsuarios Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_idEmpleado", Entidad.IdEmpleado));
            Parametros.Add(new OdbcParameter("p_nombreUsuario", Entidad.NombreUsuario));
            Parametros.Add(new OdbcParameter("p_contrasenaUsuario", Entidad.ContrasenaUsuario));
            Parametros.Add(new OdbcParameter("p_ultimoAccesoUsuario", Entidad.UltimoAccesoUsuario));
            Parametros.Add(new OdbcParameter("p_is_active", Entidad.IsActive));
            Parametros.Add(new OdbcParameter("p_idUsuario", Entidad.IdUsuario));
            return SeguridadMetEjecucionNonQuery(_Update, Parametros, CommandType.Text);
        }

        public int SeguridadMetRemover(ClsUsuarios Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_idUsuario", Entidad.IdUsuario));
            return SeguridadMetEjecucionNonQuery(_Delete, Parametros, CommandType.Text);
        }

        public IEnumerable<ClsUsuarios> SeguridadMetObtenerTodos()
        {
            var ListaUsuarios = new List<ClsUsuarios>();
            var TablaDatos = SeguridadMetEjecucionConsulta(_SelectAll, CommandType.Text);
            foreach (DataRow Fila in TablaDatos.Rows)
            {
                var Usuario = new ClsUsuarios();
                Usuario.IdUsuario = Convert.ToInt32(Fila[0]);
                Usuario.IdEmpleado = Convert.ToInt32(Fila[1]);
                Usuario.NombreUsuario = Fila[2].ToString();
                Usuario.ContrasenaUsuario = Fila[3].ToString();
                Usuario.UltimoAccesoUsuario = Convert.ToDateTime(Fila[4]);
                Usuario.IsActive = Convert.ToInt32(Fila[5]);
                ListaUsuarios.Add(Usuario);
            }
            TablaDatos.Clear();
            TablaDatos = null;
            return ListaUsuarios;
        }

        public DataTable SeguridadMetObtenerEmpleados()
        {
            return SeguridadMetEjecucionConsulta("SELECT idEmpleado, nombresEmpleado FROM tblempleado", CommandType.Text);
        }
    }
}