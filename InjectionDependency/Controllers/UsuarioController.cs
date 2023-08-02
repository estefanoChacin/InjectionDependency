using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Capa_Datos.Context;
using Capa_Negocio.Interfaces;
using Capa_Entidad;
using Capa_Dependencia;


namespace Inyeccion_Dependencia.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _usuarioServices;
        private string otraVaraible = "esta variable tambien fue creada desde github";
        private string preubas = string.Empty;
        private string otra  = string.Empty;
        private string otra22 = string.Empty;


        public UsuarioController(IUsuarioService usuarioServices)
        {
            _usuarioServices = usuarioServices;
        }



        // GET: UsuarioController
        public async Task<ActionResult> Index()
        {
            List<Usuario> lista = await _usuarioServices.Listar();

            return View(lista);
        }

        // GET: UsuarioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsuarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Usuario usuario)
        {
            try
            {
                bool status = await  _usuarioServices.Crear(usuario);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult metodoDesdeOtraRama() 
        {
            return View();
        }
    }
}
