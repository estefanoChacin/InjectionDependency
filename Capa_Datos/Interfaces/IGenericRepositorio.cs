using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Interfaces
{
    public interface IGenericRepositorio<T>
    {
        Task<T> Obtener(Expression<Func<T, bool>> filtro = null);
        Task<IQueryable<T>> Listar(Expression<Func<T, bool>> filtro = null);
        Task<bool> Crear(object entidad);
        Task<bool> editar(object entidad);
        Task<bool> Eliminar(object entidad);


    }
}
