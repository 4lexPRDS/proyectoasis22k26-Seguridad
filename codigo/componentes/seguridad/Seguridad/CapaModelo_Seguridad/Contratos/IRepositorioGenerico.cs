using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//aca iran los metodos obligatorios para toda aquella clase 
//que tenga herencia de la interfaz
namespace CapaModelo_Seguridad.Contratos
{
    public interface IRepositorioGenerico<Entidad> where Entidad : class
    {
        //aqui ponemos los metodos
        int SeguridadMetAgregar(Entidad Entidad);           // Agregar 
        int SeguridadMetEditar(Entidad Entidad);            // Editar
        int SeguridadMetRemover(Entidad Entidad);           // Eliminar
        IEnumerable<Entidad> SeguridadMetObtenerTodos();    // Listar los datos
    }
}