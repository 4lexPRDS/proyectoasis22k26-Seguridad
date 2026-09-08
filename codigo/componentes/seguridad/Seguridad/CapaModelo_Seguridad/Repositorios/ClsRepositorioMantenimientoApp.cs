using CapaModelo_Seguridad.Contratos;
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
    public class ClsRepositorioMantenimientoApp : Sentencias, IRepositorioMantenimientoApp
    {
        private string _SelectAll;
        private string _Insert;
        private string _Update;
        private string _Delete;

        public ClsRepositorioMantenimientoApp()
        {
            _SelectAll = "SELECT * FROM tblAplicacion";
            _Insert = "INSERT INTO tblAplicacion VALUES (DEFAULT,?, ?, ?, ?, DEFAULT, DEFAULT)";
            _Update = "UPDATE tblAplicacion SET idModulo=?, nombreAplicacion=?, descripcionAplicacion=?, is_active=? WHERE idAplicacion=?";
            _Delete = "DELETE FROM tblAplicacion WHERE idAplicacion=?";
        }

        public int Agregar(ClsMantenimientoAplicacion Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_idModulo", Entidad.idModulo));
            Parametros.Add(new OdbcParameter("p_nombreAplicacion", Entidad.nombreAplicacion));
            Parametros.Add(new OdbcParameter("p_descripcionAplicacion", Entidad.descripcionAplicacion));
            Parametros.Add(new OdbcParameter("p_is_active", Entidad.is_active));
            return EjecucionNonQuery(_Insert, Parametros, CommandType.Text);
        }

        public int Editar(ClsMantenimientoAplicacion Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_idModulo", Entidad.idModulo));
            Parametros.Add(new OdbcParameter("p_nombreAplicacion", Entidad.nombreAplicacion));
            Parametros.Add(new OdbcParameter("p_descripcionAplicacion", Entidad.descripcionAplicacion));
            Parametros.Add(new OdbcParameter("p_is_active", Entidad.is_active));
            Parametros.Add(new OdbcParameter("p_idAplicacion", Entidad.idAplicacion));
            return EjecucionNonQuery(_Update, Parametros, CommandType.Text);
        }

        public int Remover(ClsMantenimientoAplicacion Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_idAplicacion", Entidad.idAplicacion));
            return EjecucionNonQuery(_Delete, Parametros, CommandType.Text);
        }

        public IEnumerable<ClsMantenimientoAplicacion> GetAll()
        {
            var LstAplicaciones = new List<ClsMantenimientoAplicacion>();
            var TablaDatos = EjecucionConsulta(_SelectAll, CommandType.Text);
            foreach (DataRow Row in TablaDatos.Rows)
            {
                var Aplicacion = new ClsMantenimientoAplicacion();

                Aplicacion.idAplicacion = Convert.ToInt32(Row[0]);
                Aplicacion.idModulo = Convert.ToInt32(Row[1]);
                Aplicacion.nombreAplicacion = Convert.ToString(Row[2]);
                Aplicacion.descripcionAplicacion = Convert.ToString(Row[3]);
                Aplicacion.is_active = Convert.ToBoolean(Row[4]);
                Aplicacion.created_at = Convert.ToDateTime(Row[5]);
                Aplicacion.updated_at = Convert.ToDateTime(Row[6]);
                LstAplicaciones.Add(Aplicacion);
            }
            TablaDatos.Clear();
            TablaDatos = null;
            return LstAplicaciones;
        }

        public DataTable SeguridadMetGetModulos()
        {
            return EjecucionConsulta("SELECT idModulo, nombreModulo FROM tblModulo", CommandType.Text);
        }

        public DataTable SeguridadMetGetAplicaciones()
        {
            return EjecucionConsulta("SELECT idAplicacion, CONCAT(idAplicacion, ' - ', nombreAplicacion) AS nombreAplicacion FROM tblAplicacion",CommandType.Text);
        }
    }
}
