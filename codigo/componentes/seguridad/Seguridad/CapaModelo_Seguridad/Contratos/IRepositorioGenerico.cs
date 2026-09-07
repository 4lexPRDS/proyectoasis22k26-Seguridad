using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//aca iran los metodos obligatorios para toda aquella clase 
//que tenga herencia de la interfaz

namespace CapaModelo_Seguridad.Contratos
{
    public interface IRepositorioGenerico<Entity> where Entity : class
    {
        //aqui ponemos los metodos
        int Agregar(Entity entidad); // Agregar 
        int Editar(Entity entidad); //Editar
        int Remover(Entity entidad); // Eliminar
        IEnumerable<Entity> GetAll(); // Listar los datos
    }
}
