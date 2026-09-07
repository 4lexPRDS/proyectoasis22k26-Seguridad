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
    public class RepositorioAsigAppPerf : Sentencias, IRepositorioAsigAppPerf
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        public RepositorioAsigAppPerf()
        {
            //esto debe estar igual a la base para que haga match tambein 
            selectAll = "SELECT * FROM tblRolModuloAplicacion";
            insert = "INSERT INTO tblRolModuloAplicacion VALUES (?, ?, ?, ?, ?, ?, ?, DEFAULT, DEFAULT)";
            update = "UPDATE tblRolModuloAplicacion SET derInsertarRolModuloAplicacion=?, derEditarRolModuloAplicacion=?, derEliminarRolModuloAplicacion=?, derImprimirRolModuloAplicacion=? WHERE idRol=? AND idModulo=? AND idAplicacion=?";
            delete = "DELETE FROM tblRolModuloAplicacion WHERE idRol=? AND idModulo=? AND idAplicacion=?";
        }

        public int Agregar(AsigAppPerf entidad)
        {
            var _parametros = new List<OdbcParameter>();
            _parametros.Add(new OdbcParameter("p_idRol", entidad.idRol));
            _parametros.Add(new OdbcParameter("p_idModulo", entidad.idModulo));
            _parametros.Add(new OdbcParameter("p_idAplicacion", entidad.idAplicacion));
            _parametros.Add(new OdbcParameter("p_derInsertar", entidad.derInsertarRolModuloAplicacion));
            _parametros.Add(new OdbcParameter("p_derEditar", entidad.derEditarRolModuloAplicacion));
            _parametros.Add(new OdbcParameter("p_derEliminar", entidad.derEliminarRolModuloAplicacion));
            _parametros.Add(new OdbcParameter("p_derImprimir", entidad.derImprimirRolModuloAplicacion));

            return EjecucionNonQuery(insert, _parametros, CommandType.Text);
        }

        public int Editar(AsigAppPerf entidad)
        {
            var _parametros = new List<OdbcParameter>();
            _parametros.Add(new OdbcParameter("p_derInsertar", entidad.derInsertarRolModuloAplicacion));
            _parametros.Add(new OdbcParameter("p_derEditar", entidad.derEditarRolModuloAplicacion));
            _parametros.Add(new OdbcParameter("p_derEliminar", entidad.derEliminarRolModuloAplicacion));
            _parametros.Add(new OdbcParameter("p_derImprimir", entidad.derImprimirRolModuloAplicacion));
            _parametros.Add(new OdbcParameter("p_idRol", entidad.idRol));
            _parametros.Add(new OdbcParameter("p_idModulo", entidad.idModulo));
            _parametros.Add(new OdbcParameter("p_idAplicacion", entidad.idAplicacion));

            return EjecucionNonQuery(update, _parametros, CommandType.Text);
        }

        public int Remover(AsigAppPerf entidad)
        {
            var _parametros = new List<OdbcParameter>();
            _parametros.Add(new OdbcParameter("p_idRol", entidad.idRol));
            _parametros.Add(new OdbcParameter("p_idModulo", entidad.idModulo));
            _parametros.Add(new OdbcParameter("p_idAplicacion", entidad.idAplicacion));

            return EjecucionNonQuery(delete, _parametros, CommandType.Text);
        }

        public IEnumerable<AsigAppPerf> GetAll()
        {
            var lstAsigAppPerf = new List<AsigAppPerf>();
            var tblTabla = EjecucionConsulta(selectAll, CommandType.Text);
            foreach (DataRow row in tblTabla.Rows)
            {
                var asigAppPerf = new AsigAppPerf();
                asigAppPerf.idRol = Convert.ToInt32(row[0]);
                asigAppPerf.idModulo = Convert.ToInt32(row[1]);
                asigAppPerf.idAplicacion = Convert.ToInt32(row[2]);
                asigAppPerf.derInsertarRolModuloAplicacion = Convert.ToBoolean(row[3]);
                asigAppPerf.derEditarRolModuloAplicacion = Convert.ToBoolean(row[4]);
                asigAppPerf.derEliminarRolModuloAplicacion = Convert.ToBoolean(row[5]);
                asigAppPerf.derImprimirRolModuloAplicacion = Convert.ToBoolean(row[6]);
                asigAppPerf.createdAt = Convert.ToDateTime(row[7]);
                asigAppPerf.updatedAt = Convert.ToDateTime(row[8]);
                lstAsigAppPerf.Add(asigAppPerf);
            }
            tblTabla.Clear();
            tblTabla = null;
            return lstAsigAppPerf;
        }

        public DataTable GetRoles()
        {
            return EjecucionConsulta("SELECT idRol, nombreRol FROM tblRol", CommandType.Text);
        }

        public DataTable GetModulos()
        {
            return EjecucionConsulta("SELECT idModulo, nombreModulo FROM tblModulo", CommandType.Text);
        }

        public DataTable GetAplicaciones()
        {
            return EjecucionConsulta("SELECT idAplicacion, nombreAplicacion FROM tblAplicacion", CommandType.Text);
        }

    }

}