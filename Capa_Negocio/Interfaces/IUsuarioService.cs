using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio.Interfaces
{
    public interface IUsuarioService
    {
        Task<Usuario> Obtener(int id);
        Task<List<Usuario>> Listar();
        Task<bool> Crear(Usuario entidad);
        Task<bool> editar(Usuario entidad);
        Task<bool> Eliminar(int id);
    }
}
