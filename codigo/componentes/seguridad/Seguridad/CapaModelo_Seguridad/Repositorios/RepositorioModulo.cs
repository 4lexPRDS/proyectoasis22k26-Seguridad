using CapaModelo_Seguridad.Contratos;
using CapaModelo_Seguridad.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo_Seguridad.Repositorios
{
    public class RepositorioModulo : Sentencias, IRepositorioGenerico<Modulo>
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        public RepositorioModulo()
        {
            selectAll = "SELECT idModulo, nombreModulo, descripcionModulo, is_active FROM tblModulo";
            insert = "INSERT INTO tblModulo (nombreModulo, descripcionModulo, is_active) VALUES (?, ?, ?)";
            update = "UPDATE tblModulo SET nombreModulo=?, descripcionModulo=?, is_active=? WHERE idModulo=?";

            // SE CAMBIÓ A BORRADO FÍSICO REAL:
            delete = "DELETE FROM tblModulo WHERE idModulo=?";
        }

        public int Agregar(Modulo entidad)
        {
            var _parametros = new List<OdbcParameter>
            {
                new OdbcParameter("p_nombreModulo", entidad.nombreModulo),
                new OdbcParameter("p_descripcionModulo", entidad.descripcionModulo),
                new OdbcParameter("p_is_active", entidad.is_active ? 1 : 0)
            };
            return EjecucionNonQuery(insert, _parametros, CommandType.Text);
        }

        public int Editar(Modulo entidad)
        {
            var _parametros = new List<OdbcParameter>
            {
                new OdbcParameter("p_nombreModulo", entidad.nombreModulo),
                new OdbcParameter("p_descripcionModulo", entidad.descripcionModulo),
                new OdbcParameter("p_is_active", entidad.is_active ? 1 : 0),
                new OdbcParameter("p_idModulo", entidad.idModulo)
            };
            return EjecucionNonQuery(update, _parametros, CommandType.Text);
        }

        public int Remover(Modulo entidad)
        {
            var _parametros = new List<OdbcParameter>
            {
                new OdbcParameter("p_idModulo", entidad.idModulo)
            };
            return EjecucionNonQuery(delete, _parametros, CommandType.Text);
        }

        public IEnumerable<Modulo> GetAll()
        {
            var lstModulos = new List<Modulo>();
            var tblTabla = EjecucionConsulta(selectAll, CommandType.Text);

            foreach (DataRow row in tblTabla.Rows)
            {
                var modulo = new Modulo
                {
                    idModulo = Convert.ToInt32(row[0]),
                    nombreModulo = row[1].ToString(),
                    descripcionModulo = row[2] != DBNull.Value ? row[2].ToString() : "",
                    is_active = Convert.ToBoolean(row[3])
                };
                lstModulos.Add(modulo);
            }
            return lstModulos;
        }

        public DataTable GetModulosTabla()
        {
            return EjecucionConsulta(selectAll, CommandType.Text);
        }
    }
}