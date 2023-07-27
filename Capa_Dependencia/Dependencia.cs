using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Configuration;
using Capa_Datos.Context;
using Capa_Datos.Implementacion;
using Capa_Datos.Interfaces;
using Capa_Negocio.Implementacion;
using Capa_Negocio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Capa_Dependencia
{
    public static  class Dependencia
    {
        public static void InyectarDependencia(this IServiceCollection services, IConfiguration configuracion)
        {
            services.AddDbContext<ProductosContext>(option =>
            {
                option.UseSqlServer(configuracion.GetConnectionString("conexion"));
            });
            services.AddTransient(typeof(IGenericRepositorio<>), typeof(GenericRepositorio<>));
            services.AddScoped<IUsuarioService, UsuarioService>();
        }
    }
}