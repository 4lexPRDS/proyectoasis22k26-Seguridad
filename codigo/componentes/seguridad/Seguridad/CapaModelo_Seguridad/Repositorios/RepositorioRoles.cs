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
    public class RepositorioRoles : Sentencias, IRepositorioRoles
    {
        private string selectAll;
        private string Insert;
        private string Update;
        private string Delete;
        public RepositorioRoles()
        {
            selectAll = "Select * FROM tblRol";
            Insert = "INSERT INTO tblRol (nombreRol, descripcionRol, is_active) values (?, ?, ?)";
            Update = "UPDATE tblRol SET nombreRol=?, descripcionRol=?, is_active=? WHERE idRol=?";
            Delete = "DELETE FROM tblRol WHERE idRol=?";
        }

        public int Agregar(Roles entidad)
        {
            var _Parametros = new List<OdbcParameter>();

            _Parametros.Add(new OdbcParameter("P_nombreRol", entidad.nombreRol));
            _Parametros.Add(new OdbcParameter("P_descripcionRol", entidad.descripcionRol));
            _Parametros.Add(new OdbcParameter("P_is_active", entidad.is_active));
            return EjecucionNonQuery(Insert, _Parametros, CommandType.Text);
        }

        public int Editar(Roles entidad)
        {
            var _Parametros = new List<OdbcParameter>();
            _Parametros.Add(new OdbcParameter("P_nombreRol", entidad.nombreRol));
            _Parametros.Add(new OdbcParameter("P_descripcionRol", entidad.descripcionRol));
            _Parametros.Add(new OdbcParameter("P_is_active", entidad.is_active));
            _Parametros.Add(new OdbcParameter("P_idRol", entidad.idRol));
            return EjecucionNonQuery(Update, _Parametros, CommandType.Text);
        }

        public int Remover(Roles entidad)
        {
            var _Parametros = new List<OdbcParameter>();
            _Parametros.Add(new OdbcParameter("P_idRol", entidad.idRol));
            return EjecucionNonQuery(Delete, _Parametros, CommandType.Text);
        }



        public IEnumerable<Roles> GetAll()
        {
            var lstRoles = new List<Roles>();
            var TblTabla = EjecucionConsulta(selectAll, CommandType.Text);
            foreach (DataRow row in TblTabla.Rows)
            {
                var roles = new Roles();
                roles.idRol = Convert.ToInt32(row[0]);
                roles.nombreRol = row[1].ToString();
                roles.descripcionRol = row[2].ToString();
                roles.is_active = Convert.ToBoolean(row[3]);
                roles.created_at = Convert.ToDateTime(row[4]);
                roles.updated_at = Convert.ToDateTime(row[5]);
                lstRoles.Add(roles);
            }
            TblTabla.Clear();
            TblTabla = null;
            return lstRoles;
        }
    }
}
