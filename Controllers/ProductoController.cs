using Microsoft.AspNetCore.Mvc;
using formulario1.Models;
namespace formulario1.Controllers
{
    public class ProductoController:Controller
    {
        public IActionResult Index()
        {
            return View();
        } 

        [HttpPost]
         public IActionResult Calcular (Producto objProducto)
        {
                double monto=0.0;
                //total=0.0
            ViewData["Message"] = "Sin resultado";
            if(((long)objProducto.precio)>0){
                monto = objProducto.precio*objProducto.cantidad*1.18;
                //total=subtotal*1.18;
                ViewData["Message"] = "El monto a pagar es "+ monto;
            
             return View("Index");
             }else {
                 ViewData["Message"] = "Ingresar precio y cantidad";
             }
              return View("Index");  

         }



       //&(long)objProducto.cantidad
 
     }
}      