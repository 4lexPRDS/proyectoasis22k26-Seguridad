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
    public class ClsRepositorioAsigAppPerf : ClsSentencias, IRepositorioAsigAppPerf
    {
        private string _SelectAll;
        private string _Insert;
        private string _Update;
        private string _Delete;

        public ClsRepositorioAsigAppPerf()
        {
            //esto debe estar igual a la base para que haga match tambein 
            _SelectAll = "SELECT * FROM tblRolModuloAplicacion";
            _Insert = "INSERT INTO tblRolModuloAplicacion VALUES (?, ?, ?, ?, ?, ?, ?, DEFAULT, DEFAULT)";
            _Update = "UPDATE tblRolModuloAplicacion SET derInsertarRolModuloAplicacion=?, derEditarRolModuloAplicacion=?, derEliminarRolModuloAplicacion=?, derImprimirRolModuloAplicacion=? WHERE idRol=? AND idModulo=? AND idAplicacion=?";
            _Delete = "DELETE FROM tblRolModuloAplicacion WHERE idRol=? AND idModulo=? AND idAplicacion=?";
        }

        public int SeguridadMetAgregar(ClsAsigAppPerf Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_idRol", Entidad.IdRol));
            Parametros.Add(new OdbcParameter("p_idModulo", Entidad.IdModulo));
            Parametros.Add(new OdbcParameter("p_idAplicacion", Entidad.IdAplicacion));
            Parametros.Add(new OdbcParameter("p_derInsertar", Entidad.DerInsertarRolModuloAplicacion));
            Parametros.Add(new OdbcParameter("p_derEditar", Entidad.DerEditarRolModuloAplicacion));
            Parametros.Add(new OdbcParameter("p_derEliminar", Entidad.DerEliminarRolModuloAplicacion));
            Parametros.Add(new OdbcParameter("p_derImprimir", Entidad.DerImprimirRolModuloAplicacion));

            return SeguridadMetEjecucionNonQuery(_Insert, Parametros, CommandType.Text);
        }

        public int SeguridadMetEditar(ClsAsigAppPerf Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_derInsertar", Entidad.DerInsertarRolModuloAplicacion));
            Parametros.Add(new OdbcParameter("p_derEditar", Entidad.DerEditarRolModuloAplicacion));
            Parametros.Add(new OdbcParameter("p_derEliminar", Entidad.DerEliminarRolModuloAplicacion));
            Parametros.Add(new OdbcParameter("p_derImprimir", Entidad.DerImprimirRolModuloAplicacion));
            Parametros.Add(new OdbcParameter("p_idRol", Entidad.IdRol));
            Parametros.Add(new OdbcParameter("p_idModulo", Entidad.IdModulo));
            Parametros.Add(new OdbcParameter("p_idAplicacion", Entidad.IdAplicacion));

            return SeguridadMetEjecucionNonQuery(_Update, Parametros, CommandType.Text);
        }

        public int SeguridadMetRemover(ClsAsigAppPerf Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_idRol", Entidad.IdRol));
            Parametros.Add(new OdbcParameter("p_idModulo", Entidad.IdModulo));
            Parametros.Add(new OdbcParameter("p_idAplicacion", Entidad.IdAplicacion));

            return SeguridadMetEjecucionNonQuery(_Delete, Parametros, CommandType.Text);
        }

        public IEnumerable<ClsAsigAppPerf> SeguridadMetObtenerTodos()
        {
            var ListaAsigAppPerf = new List<ClsAsigAppPerf>();
            var TablaDatos = SeguridadMetEjecucionConsulta(_SelectAll, CommandType.Text);
            foreach (DataRow Fila in TablaDatos.Rows)
            {
                var AsigPerf = new ClsAsigAppPerf();
                AsigPerf.IdRol = Convert.ToInt32(Fila[0]);
                AsigPerf.IdModulo = Convert.ToInt32(Fila[1]);
                AsigPerf.IdAplicacion = Convert.ToInt32(Fila[2]);
                AsigPerf.DerInsertarRolModuloAplicacion = Convert.ToBoolean(Fila[3]);
                AsigPerf.DerEditarRolModuloAplicacion = Convert.ToBoolean(Fila[4]);
                AsigPerf.DerEliminarRolModuloAplicacion = Convert.ToBoolean(Fila[5]);
                AsigPerf.DerImprimirRolModuloAplicacion = Convert.ToBoolean(Fila[6]);
                AsigPerf.CreatedAt = Convert.ToDateTime(Fila[7]);
                AsigPerf.UpdatedAt = Convert.ToDateTime(Fila[8]);
                ListaAsigAppPerf.Add(AsigPerf);
            }
            TablaDatos.Clear();
            TablaDatos = null;
            return ListaAsigAppPerf;
        }

        public DataTable SeguridadMetObtenerRoles()
        {
            return SeguridadMetEjecucionConsulta("SELECT idRol, nombreRol FROM tblRol", CommandType.Text);
        }

        public DataTable SeguridadMetObtenerModulos()
        {
            return SeguridadMetEjecucionConsulta("SELECT idModulo, nombreModulo FROM tblModulo", CommandType.Text);
        }

        public DataTable SeguridadMetObtenerAplicaciones()
        {
            return SeguridadMetEjecucionConsulta("SELECT idAplicacion, nombreAplicacion FROM tblAplicacion", CommandType.Text);
        }
    }
}