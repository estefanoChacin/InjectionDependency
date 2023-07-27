using Capa_Datos.Context;
using Capa_Datos.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Implementacion
{
    public class GenericRepositorio<T> : IGenericRepositorio<T> where T : class
    {
        private readonly ProductosContext _context;

        string toto;
        private string estaVariableGITHUB = "esta variable fue creada desde github"

        public GenericRepositorio(ProductosContext context)
        {
            _context = context;
        }




        public async Task<bool> Crear(object entidad)
        {
            try
            {
                 _context.AddAsync(entidad);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }




        public async Task<bool> editar(object entidad)
        {
            try
            {
                _context.Update(entidad);
                await (_context.SaveChangesAsync());
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }



        public async Task<bool> Eliminar(object entidad)
        {
            try
            { 
                _context.Remove(entidad);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }



        public async Task<IQueryable<T>> Listar(Expression<Func<T, bool>> filtro = null)
        {
            try
            {
                IQueryable<T> lista = filtro == null ? _context.Set<T>(): _context.Set<T>().Where(filtro);
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }



        public async Task<T> Obtener(Expression<Func<T, bool>> filtro = null)
        {
            try
            {
                T entidad = await _context.Set<T>().FirstOrDefaultAsync(filtro);
                return entidad;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
