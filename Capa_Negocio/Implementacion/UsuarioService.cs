using Capa_Datos.Interfaces;
using Capa_Entidad;
using Capa_Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio.Implementacion
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IGenericRepositorio<Usuario> _repositorio;




        public UsuarioService(IGenericRepositorio<Usuario> repositorio)
        {
            _repositorio = repositorio;
        }




        public async Task<bool> Crear(Usuario entidad)
        {
            try
            {
                bool flag = true;
                bool status;

                if (entidad.Nombre.Length == 0 && entidad.Contrasena.Length == 0)
                {
                    flag = false;
                }
                if (flag)
                {
                    status = await _repositorio.Crear(entidad);
                }
                else
                {
                    throw new TaskCanceledException("Valide las credenciales.");
                }
                return status;
            }
            catch (Exception)
            {

                throw;
            }

        }




        public Task<bool> editar(Usuario entidad)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Usuario>> Listar()
        {
           IQueryable<Usuario> lista =  await  _repositorio.Listar();
            return lista.ToList();
        }

        public Task<Usuario> Obtener(int id)
        {
            throw new NotImplementedException();
        }
    }
}
