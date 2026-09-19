using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaControlador_Navegador;
using CapaEntidades_Navegador;

namespace CapaVista_Navegador
{
    // Insertar, Modificar, Eliminar, Guardar y los mensajes de confirmacion/error, todo junto
    public class ClsCrudAcciones
    {
        private ClsCtrlRegistro _CtrlRegistro = new ClsCtrlRegistro();

        public bool NavegadorFuncConfirmarAccion(string NavegadorLblTitulo, string Mensaje)
        {
            return MessageBox.Show(Mensaje, NavegadorLblTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private string NavegadorFuncResumenDatos(Dictionary<string, string> Datos)
        {
            string Resumen = "";

            foreach (KeyValuePair<string, string> Dato in Datos)
                Resumen += Dato.Key + ": " + Dato.Value + "\n";

            return Resumen;
        }

        // Inserta o actualiza segun el modo, validando los campos antes de guardar
        public bool NavegadorMetGuardar(string Tabla, List<ClsColumnaInfo> ClsEsquema, Dictionary<string, string> DatosFormulario,
            bool ModoModificar, Dictionary<string, string> PkOriginal, out string Mensaje)
        {
            Mensaje = "";

            Dictionary<string, string> Datos = new Dictionary<string, string>();

            foreach (ClsColumnaInfo Col in ClsEsquema)
            {
                if (!DatosFormulario.ContainsKey(Col.Nombre))
                    continue;

                if (!ModoModificar && Col.EsAutoincremento)
                    continue;

                if (ModoModificar && Col.EsPK)
                    continue;

                string Valor = DatosFormulario[Col.Nombre];

                if (string.IsNullOrWhiteSpace(Valor))
                {
                    if (!Col.Nullable)
                    {
                        Mensaje = "El campo '" + Col.Nombre + "' es obligatorio.";
                        return false;
                    }

                    continue;
                }

                Datos[Col.Nombre] = Valor;
            }

            List<string> Errores = _CtrlRegistro.NavegadorFuncValidarRegistro(Datos, Tabla);

            if (Errores.Count > 0)
            {
                Mensaje = string.Join("\n", Errores);
                return false;
            }

            if (!ModoModificar)
                return NavegadorMetInsertar(Tabla, ClsEsquema, Datos, out Mensaje);

            return NavegadorMetModificar(Tabla, Datos, PkOriginal, out Mensaje);
        }

        private bool NavegadorMetInsertar(string Tabla, List<ClsColumnaInfo> ClsEsquema, Dictionary<string, string> Datos, out string Mensaje)
        {
            Mensaje = "";

            List<string> PkCampos = new List<string>();
            List<string> PkValores = new List<string>();

            foreach (ClsColumnaInfo Col in ClsEsquema)
            {
                if (!Col.EsPK) continue;

                string Valor;

                if (Datos.TryGetValue(Col.Nombre, out Valor))
                {
                    PkCampos.Add(Col.Nombre);
                    PkValores.Add(Valor);
                }
            }

            if (PkCampos.Count > 0 && _CtrlRegistro.NavegadorFuncExisteLlavePrimaria(Tabla, PkCampos.ToArray(), PkValores.ToArray()))
            {
                Mensaje = "Ya existe un registro con esta llave primaria (" +
                    string.Join(", ", PkCampos) + " = " + string.Join(", ", PkValores) + ").";
                return false;
            }

            if (!NavegadorFuncConfirmarAccion("Confirmar ingreso",
                "¿Desea ingresar el siguiente registro en la tabla '" + Tabla + "'?\n\n" + NavegadorFuncResumenDatos(Datos)))
                return false;

            return _CtrlRegistro.NavegadorFuncInsertarRegistro(Tabla, Datos);
        }

        private bool NavegadorMetModificar(string Tabla, Dictionary<string, string> Datos, Dictionary<string, string> ClavesPrimarias, out string Mensaje)
        {
            Mensaje = "";

            if (ClavesPrimarias == null || ClavesPrimarias.Count == 0)
            {
                Mensaje = "No se encontró la llave primaria del registro seleccionado.";
                return false;
            }

            if (Datos.Count == 0)
            {
                Mensaje = "No hay campos disponibles para Modificar.";
                return false;
            }

            if (!NavegadorFuncConfirmarAccion("Confirmar modificación",
                "¿Desea guardar los cambios en la tabla '" + Tabla + "'?\n\n" + NavegadorFuncResumenDatos(Datos)))
                return false;

            return _CtrlRegistro.NavegadorFuncActualizarRegistro(Tabla, Datos, ClavesPrimarias);
        }

        public bool NavegadorMetEliminar(string Tabla, Dictionary<string, string> ClavesPrimarias, out string Mensaje)
        {
            Mensaje = "";

            if (ClavesPrimarias == null || ClavesPrimarias.Count == 0)
            {
                Mensaje = "La tabla no tiene una llave primaria detectable.";
                return false;
            }

            foreach (KeyValuePair<string, string> Clave in ClavesPrimarias)
            {
                if (string.IsNullOrWhiteSpace(Clave.Value))
                {
                    Mensaje = "No se pudo obtener el valor de la llave primaria del registro seleccionado.";
                    return false;
                }
            }

            if (!NavegadorFuncConfirmarAccion("Confirmar eliminación",
                "¿Desea eliminar el registro seleccionado de la tabla '" + Tabla + "'?"))
                return false;

            return _CtrlRegistro.NavegadorFuncEliminarRegistro(Tabla, ClavesPrimarias);
        }

        // Traduce errores tecnicos del motor de BD a mensajes que el Usuario entienda
        public string NavegadorFuncMensajeAmigable(Exception Excepcion)
        {
            string TextoMinusculas = (Excepcion.Message ?? "").ToLowerInvariant();

            if (TextoMinusculas.Contains("foreign key") || TextoMinusculas.Contains("fk_") || TextoMinusculas.Contains("reference constraint"))
                return "El registro no puede guardarse o eliminarse porque existe una relación de llave foránea.";

            if (TextoMinusculas.Contains("duplicate entry") || TextoMinusculas.Contains("duplicate key") ||
                TextoMinusculas.Contains("unique constraint") || TextoMinusculas.Contains("violation of unique") ||
                TextoMinusculas.Contains("violation of primary key"))
                return "Ya existe un registro con el mismo valor en un campo único.";

            if (TextoMinusculas.Contains("cannot be null") || TextoMinusculas.Contains("null value") ||
                TextoMinusculas.Contains("not-null constraint") || TextoMinusculas.Contains("insert the value null"))
                return "Hay un campo obligatorio que no puede quedar vacío.";

            if (TextoMinusculas.Contains("data too long") || TextoMinusculas.Contains("truncat") ||
                TextoMinusculas.Contains("string or binary data would be truncated"))
                return "Uno de los valores ingresados es demasiado largo para el campo correspondiente.";

            if ((TextoMinusculas.Contains("incorrect") && TextoMinusculas.Contains("value")) ||
                TextoMinusculas.Contains("conversion failed") || TextoMinusculas.Contains("invalid input syntax"))
                return "Uno de los valores ingresados tiene un formato incorrecto para su campo.";

            return Excepcion.Message;
        }
    }
}