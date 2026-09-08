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
    public class RepositorioEmpleado : Sentencias, IRepositorioEmpleado
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        public RepositorioEmpleado()
        {
            //esto debe estar igual a la base para que haga match tambein 
            selectAll = "SELECT * FROM tblEmpleado";
            insert = "INSERT INTO tblEmpleado VALUES (DEFAULT, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, DEFAULT, DEFAULT, DEFAULT)";
            update = "UPDATE tblEmpleado SET codigoEmpleado=?, dpiEmpleado=?, nitEmpleado=?, nombresEmpleado=?, apellidosEmpleado=?, puestoEmpleado=?, generoEmpleado=?, fechaNacimientoEmpleado=?, fechaContratacionEmpleado=?, telefonoEmpleado=?, correoEmpleado=? WHERE idEmpleado=?";
            delete = "DELETE FROM tblEmpleado WHERE idEmpleado=?";
        }

        public int Agregar(Empleado entidad)
        {
            var _parametros = new List<OdbcParameter>();
            _parametros.Add(new OdbcParameter("p_codigoEmpleado", entidad.codigoEmpleado));
            _parametros.Add(new OdbcParameter("p_dpiEmpleado", entidad.dpiEmpleado));
            _parametros.Add(new OdbcParameter("p_nitEmpleado", entidad.nitEmpleado));
            _parametros.Add(new OdbcParameter("p_nombresEmpleado", entidad.nombresEmpleado));
            _parametros.Add(new OdbcParameter("p_apellidosEmpleado", entidad.apellidosEmpleado));
            _parametros.Add(new OdbcParameter("p_puestoEmpleado", entidad.puestoEmpleado));
            _parametros.Add(new OdbcParameter("p_generoEmpleado", entidad.generoEmpleado));
            _parametros.Add(new OdbcParameter("p_fechaNacimientoEmpleado", entidad.fechaNacimientoEmpleado));
            _parametros.Add(new OdbcParameter("p_fechaContratacionEmpleado", entidad.fechaContratacionEmpleado));
            _parametros.Add(new OdbcParameter("p_telefonoEmpleado", entidad.telefonoEmpleado));
            _parametros.Add(new OdbcParameter("p_correoEmpleado", entidad.correoEmpleado));

            return EjecucionNonQuery(insert, _parametros, CommandType.Text);
        }

        public int Editar(Empleado entidad)
        {
            var _parametros = new List<OdbcParameter>();
            _parametros.Add(new OdbcParameter("p_codigoEmpleado", entidad.codigoEmpleado));
            _parametros.Add(new OdbcParameter("p_dpiEmpleado", entidad.dpiEmpleado));
            _parametros.Add(new OdbcParameter("p_nitEmpleado", entidad.nitEmpleado));
            _parametros.Add(new OdbcParameter("p_nombresEmpleado", entidad.nombresEmpleado));
            _parametros.Add(new OdbcParameter("p_apellidosEmpleado", entidad.apellidosEmpleado));
            _parametros.Add(new OdbcParameter("p_puestoEmpleado", entidad.puestoEmpleado));
            _parametros.Add(new OdbcParameter("p_generoEmpleado", entidad.generoEmpleado));
            _parametros.Add(new OdbcParameter("p_fechaNacimientoEmpleado", entidad.fechaNacimientoEmpleado));
            _parametros.Add(new OdbcParameter("p_fechaContratacionEmpleado", entidad.fechaContratacionEmpleado));
            _parametros.Add(new OdbcParameter("p_telefonoEmpleado", entidad.telefonoEmpleado));
            _parametros.Add(new OdbcParameter("p_correoEmpleado", entidad.correoEmpleado));
            _parametros.Add(new OdbcParameter("p_idEmpleado", entidad.idEmpleado));

            return EjecucionNonQuery(update, _parametros, CommandType.Text);
        }

        public int Remover(Empleado entidad)
        {
            var _parametros = new List<OdbcParameter>();
            _parametros.Add(new OdbcParameter("p_idEmpleado", entidad.idEmpleado));

            return EjecucionNonQuery(delete, _parametros, CommandType.Text);
        }

        public IEnumerable<Empleado> GetAll()
        {
            var lstEmpleado = new List<Empleado>();
            var tblTabla = EjecucionConsulta(selectAll, CommandType.Text);
            foreach (DataRow row in tblTabla.Rows)
            {
                var empleado = new Empleado();
                empleado.idEmpleado = Convert.ToInt32(row[0]);
                empleado.codigoEmpleado = row[1].ToString();
                empleado.dpiEmpleado = row[2].ToString();
                empleado.nitEmpleado = row[3] == DBNull.Value ? null : row[3].ToString();
                empleado.nombresEmpleado = row[4].ToString();
                empleado.apellidosEmpleado = row[5].ToString();
                empleado.puestoEmpleado = row[6].ToString();
                empleado.generoEmpleado = row[7].ToString();
                empleado.fechaNacimientoEmpleado = Convert.ToDateTime(row[8]);
                empleado.fechaContratacionEmpleado = Convert.ToDateTime(row[9]);
                empleado.telefonoEmpleado = row[10] == DBNull.Value ? null : row[10].ToString();
                empleado.correoEmpleado = row[11] == DBNull.Value ? null : row[11].ToString();
                empleado.isActive = Convert.ToBoolean(row[12]);
                empleado.createdAt = Convert.ToDateTime(row[13]);
                empleado.updatedAt = Convert.ToDateTime(row[14]);
                lstEmpleado.Add(empleado);
            }
            tblTabla.Clear();
            tblTabla = null;
            return lstEmpleado;
        }
    }
}