using System;
using System.Text.RegularExpressions;

namespace CapaModelo_Navegador
{
    // Evita que se cuele algo raro dentro de un nombre de tabla o Columna
    public static class ClsValidaciones
    {
        public static void NavegadorMetValidarIdentificador(string Identificador)
        {
            if (string.IsNullOrWhiteSpace(Identificador) || !Regex.IsMatch(Identificador, @"^[A-Za-z0-9_$.]+$"))
                throw new ArgumentException("El nombre de tabla o Columna no es válido.");
        }
    }
}