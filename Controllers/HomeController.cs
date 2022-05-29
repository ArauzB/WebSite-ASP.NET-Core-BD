using CRUDCORE.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CRUDCORE.Datos;
using CRUDCORE.Models;




namespace CRUDCORE.Controllers
{
    
    
    public class HomeController : Controller 
    
    {
        
        CineDatos _CineDatos = new CineDatos();
        
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
          public IActionResult Peliculas()
        {
            //LA VISTA MOSTRARÁ UNA LISTA DE CONTACTOS
            var oLista = _CineDatos.ListarPelicula();

            return View(oLista);
        }

        public IActionResult Series()
        {
            //LA VISTA MOSTRARÁ UNA LISTA DE CONTACTOS
            var oLista = _CineDatos.ListarSerie();

            return View(oLista);
        }

        public IActionResult Juegos()
        {
            //LA VISTA MOSTRARÁ UNA LISTA DE CONTACTOS
            var oLista = _CineDatos.ListarJuego();

            return View(oLista);
        }

        

        public IActionResult ListarEdit()
        {
            //LA VISTA MOSTRARÁ UNA LISTA DE CONTACTOS
            var oLista = _CineDatos.Listar();

            return View(oLista);
        }

        public IActionResult Index()
        
        {
            
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
        


        public IActionResult Guardar()
        {
            //METODO SOLO DEVUELVE LA VISTA
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(CineModel oContacto)
        {
            //METODO RECIBE EL OBJETO PARA GUARDARLO EN BD
            if (!ModelState.IsValid)
                return View();


            var respuesta = _CineDatos.Guardar(oContacto);

            if (respuesta)
                return RedirectToAction("ListarEdit");
            else 
                return View();
        }


    

        public IActionResult Editar(int ID)
        {
            //METODO SOLO DEVUELVE LA VISTA
            var ocontacto = _CineDatos.Obtener(ID);
            return View(ocontacto);
        }

        [HttpPost]
        public IActionResult Editar(CineModel oContacto)
        {
            if (!ModelState.IsValid)
                return View();


            var respuesta = _CineDatos.Editar(oContacto);

            if (respuesta)
                return RedirectToAction("ListarEdit");
            else
                return View();
        }


        public IActionResult View(int ID)
        {
            //METODO SOLO DEVUELVE LA VISTA
            var ocontacto = _CineDatos.Obtener(ID);
            return View(ocontacto);
        }

        public IActionResult Eliminar(int ID)
        {
            //METODO SOLO DEVUELVE LA VISTA
            var ocontacto = _CineDatos.Obtener(ID);
            return View(ocontacto);
        }

        [HttpPost]
        public IActionResult Eliminar(CineModel oContacto)
        {
  
            var respuesta = _CineDatos.Eliminar(oContacto.ID);

            if (respuesta)
                return RedirectToAction("ListarEdit");
            else
                return View();
        }






    
        
        
        
        
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}