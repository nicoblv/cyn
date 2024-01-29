using Invitacion.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using System.Diagnostics;

namespace Invitacion.Controllers
{
    public class HomeController : Controller
    {
        private readonly Email email;
        private readonly IActionContextAccessor _actionContextAccessor;
        private readonly IUrlHelperFactory _urlHelperFactory;

        public HomeController(IUrlHelperFactory urlHelperFactory, IActionContextAccessor actionContextAccessor)
        {
            email = new Email();
			_urlHelperFactory = urlHelperFactory;
            _actionContextAccessor = actionContextAccessor;
        }

        public IActionResult Index()
        {
            var urlHelper = _urlHelperFactory.GetUrlHelper(_actionContextAccessor.ActionContext);
            var returnUrl = urlHelper.Action("Invitacion", "Home", null, Request.Scheme);
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
        [Route("Invitacion")]
        [HttpPost]
        public IActionResult Invitacion()
        {
			string code = string.IsNullOrEmpty(HttpContext.Request.Form["inputCode"]) ? "CYN" : HttpContext.Request.Form["inputCode"];
            int cantidad = 0;
            string codigo = code.Trim().ToUpper();
            int confirmado = 0;

            // UN INVITADO
            if (codigo == "WZFY")
            {
                ViewBag.Primero = "Anabel Miño C.";
                cantidad = 1;
            }
            else if (codigo == "EHLC")
            {
                ViewBag.Primero = "Edgard Salvatierra G.";
                cantidad = 1;
            }
            else if(codigo == "CRSX")
            {
                ViewBag.Primero = "Emiliano Soto C.";
                cantidad = 1;
            }
            else if (codigo == "YZPR")
            {
                ViewBag.Primero = "Tavita Castillo C.";
                cantidad = 1;
                confirmado = 1;
            }
            else if (codigo == "NUJV")
            {
                ViewBag.Primero = "Nicolás Arellano R.";
                cantidad = 1;
                confirmado = 1;
            }
            else if (codigo == "GQFH")
            {
                ViewBag.Primero = "Lucas Gajardo C.";
                cantidad = 1;
                confirmado = 1;
            }
            else if (codigo == "EAYA")
            {
                ViewBag.Primero = "Fernanda Salas";
                cantidad = 1;
                confirmado = 1;
            }
            else if (codigo == "SAVS")
            {
                ViewBag.Primero = "Ricardo Saldivia";
                cantidad = 1;
            }
            else if (codigo == "VNXH")
            {
                ViewBag.Primero = "Nicole Benavente";
                cantidad = 1;
            }
            else if (codigo == "YBBE")
            {
                ViewBag.Primero = "Sophie Roeckel";
                cantidad = 1;
                confirmado = 1;
            }
            else if (codigo == "SZXX")
            {
                ViewBag.Primero = "René Espinoza";
                cantidad = 1;
                confirmado = 1;
            }
            else if (codigo == "UVSR")
            {
                ViewBag.Primero = "Nicolás Oliva";
                cantidad = 1;
            }
            else if (codigo == "RMCZ")
            {
                ViewBag.Primero = "Felipe Silva";
                cantidad = 1;
                confirmado = 1;
            }
            else if (codigo == "PGQN")
            {
                ViewBag.Primero = "Felipe Hinojosa P.";
                cantidad = 1;
                confirmado = 1;
            }
            else if (codigo == "VTDR")
            {
                ViewBag.Primero = "Matías Baeza S.";
                cantidad = 1;
            }
            else if (codigo == "JWBU")
            {
                ViewBag.Primero = "Andres Fleming R.";
                cantidad = 1;
            }
            else if (codigo == "EKKW")
            {
                ViewBag.Primero = "Felipe Saavedra";
                cantidad = 1;
                confirmado = 1;
            }
            else if (codigo == "XDTJ")
            {
                ViewBag.Primero = "Nayadeth Fuentealba";
                cantidad = 1;
            }
            else if (codigo == "EWBJ")
            {
                ViewBag.Primero = "Grace Fuentealba";
                cantidad = 1;
            }
            else if (codigo == "QTGJ")
            {
                ViewBag.Primero = "Bárbara Avilés";
                cantidad = 1;
                confirmado = 1;

            }
            else if (codigo == "EAYG")
            {
                ViewBag.Primero = "Catalina Cabrera";
                cantidad = 1;
            }
            else if (codigo == "UTWU")
            {
                ViewBag.Primero = "Marta Concha";
                cantidad = 1;
            }
            else if (codigo == "FEEH")
            {
                ViewBag.Primero = "Macarena Suazo";
                cantidad = 1;
            }
            else if (codigo == "EYCG")
            {
                ViewBag.Primero = "Bastian Garate S.";
                cantidad = 1;
            }
            // DOS INVITADO
            else if (codigo == "VGCX")
			{
				ViewBag.Primero = "Valentina Zapata";
				ViewBag.Segundo = "Benjamin Ciapa";
				cantidad = 2;
                confirmado = 1;
            }
			else if (codigo == "RYFF")
            {
                ViewBag.Primero = "Sebastián Fernández R.";
                ViewBag.Segundo = "Natalia Osores C.";
                cantidad = 2;
                confirmado = 1;
            }
            else if (codigo == "AKTT")
            {
                ViewBag.Primero = "Natalia Hernández";
                ViewBag.Segundo = "Hernán Carrillo";
                cantidad = 2;
                confirmado = 1;
            }
            else if (codigo == "ZTCN")
            {
                ViewBag.Primero = "Daniel Miño C.";
                ViewBag.Segundo = "Margarita Amestica H.";
                cantidad = 2;
            }
            else if (codigo == "HGST")
            {
                ViewBag.Primero = "Jimena Hinojosa V.";
                ViewBag.Segundo = "Alberto Wentelemn";
                cantidad = 2;
            }
            else if (codigo == "TKEN")
            {
                ViewBag.Primero = "Juan Pablo Bravo S.";
                ViewBag.Segundo = "Darma Arredondo";
                cantidad = 2;
            }
            else if (codigo == "TGGU")
            {
                ViewBag.Primero = "Juan Angel Sandoval";
                ViewBag.Segundo = "Carmen Suazo";
                cantidad = 2;
                confirmado = 1;
            }
            else if (codigo == "XWCT")
            {
                ViewBag.Primero = "Margot Concha";
                ViewBag.Segundo = "Carlos Cisterna";
                cantidad = 2;
            }
            else if (codigo == "NAWT")
            {
                ViewBag.Primero = "María José Meneses";
                ViewBag.Segundo = "Karol Padilla";
                cantidad = 2;
            }
            else if (codigo == "SRSZ")
            {
                ViewBag.Primero = "Javiera Avilés";
                ViewBag.Segundo = "Nicolás de Nordenflicht";
                cantidad = 2;
                confirmado = 1;
            }
            else if (codigo == "WFKD")
            {
                ViewBag.Primero = "Carlos Aravena C.";
                ViewBag.Segundo = "Johanna Galvez M.";
                cantidad = 2;
                confirmado = 1;
            }
            else if (codigo == "EHYB")
            {
                ViewBag.Primero = "Pablo Albornoz S.";
                ViewBag.Segundo = "Eliana Concha E.";
                cantidad = 2;
                confirmado = 1;
            }
            else if (codigo == "FSXW")
            {
                ViewBag.Primero = "Jocelyn Cartes S.";
                ViewBag.Segundo = "Jonathan Masaur P.";
                cantidad = 2;
                confirmado = 1;
            }
            else if (codigo == "HJDD")
            {
                ViewBag.Primero = "Gustavo González S.";
                ViewBag.Segundo = "Yessica Toledo";
                cantidad = 2;
            }
            else if (codigo == "PQDE")
            {
                ViewBag.Primero = "Thaís Espinoza";
                ViewBag.Segundo = "Italo Reyes";
                cantidad = 2;
                confirmado = 1;
            }
            else if (codigo == "WRCY")
            {
                ViewBag.Primero = "Janelore Muñoz";
                ViewBag.Segundo = "Rodrigo Concha";
                cantidad = 2;
                confirmado = 1;
            }
            else if (codigo == "BCXK")
            {
                ViewBag.Primero = "Fernanda Salvatierra G.";
                ViewBag.Segundo = "Thomas González M.";
                cantidad = 2;
            }
            else if (codigo == "FQXU")
            {
                ViewBag.Primero = "Alexis Obando V.";
                ViewBag.Segundo = "Rumar Arias S.";
                cantidad = 2;
                confirmado = 1;
            }
            else if (codigo == "SZRD")
            {
                ViewBag.Primero = "Gabriel Sandoval V.";
                ViewBag.Segundo = "Johanna Fuentealba C.";
                cantidad = 2;
                confirmado = 1;
            }
            else if (codigo == "KSYP")
            {
                ViewBag.Primero = "Jose Sandoval F.";
                ViewBag.Segundo = "Krischna Zárate";
                cantidad = 2;
                confirmado = 1;
            }
            else if (codigo == "BNGS")
            {
                ViewBag.Primero = "Dante Miño C.";
                ViewBag.Segundo = "Paola González";
                cantidad = 2;
                confirmado = 1;
            }
            else if (codigo == "EUCJ")
            {
                ViewBag.Primero = "Antonella Hinojosa C.";
                ViewBag.Segundo = "Lucas Cisternas A.";
                cantidad = 2;
                confirmado = 1;
            }
            else if (codigo == "CYMG")
            {
                ViewBag.Primero = "Diego González S.";
                ViewBag.Segundo = "Rocío Gómez";
                cantidad = 2;
                confirmado = 1;
            }
            else if (codigo == "QANV")
            {
                ViewBag.Primero = "Julián Valderrama";
                ViewBag.Segundo = "Nicole Caamaño";
                cantidad = 2;
                confirmado = 1;
            }
            else if (codigo == "SREE")
            {
                ViewBag.Primero = "Claudia Suazo";
                ViewBag.Segundo = "Eugenio González";
                cantidad = 2;
                confirmado = 1;
            }
            else if (codigo == "EXFR")
            {
                ViewBag.Primero = "María Suazo F.";
                ViewBag.Segundo = "Pedro Ortíz";
                cantidad = 2;
            }
            else if (codigo == "WSXD")
            {
                ViewBag.Primero = "Monica Suazo";
                ViewBag.Segundo = "Miguel Rodríguez";
                cantidad = 2;
            }
            else if (codigo == "UJZW")
            {
                ViewBag.Primero = "Benjamín Henriquez R.";
                ViewBag.Segundo = "Vianny Muñoz F.";
                cantidad = 2;
            }
            // TRES INVITADOS
            else if (codigo == "RHMN")
            {
                ViewBag.Primero = "Carolina Cartes S.";
                ViewBag.Segundo = "Nicanor Hinojosa V.";
                ViewBag.Tercero = "Reneignacio Hinojosa C.";
                cantidad = 3;
                confirmado = 1;
            }
            else if (codigo == "CNXZ")
            {
                ViewBag.Primero = "Patricia Sandoval";
                ViewBag.Segundo = "Jorge Avilés";
                ViewBag.Tercero = "José Tomás Avilés S.";
                cantidad = 3;
                confirmado = 1;
            }
            else if (codigo == "EXXG")
            {
                ViewBag.Primero = "Sandra Concha";
                ViewBag.Segundo = "Erwin Escobar";
                ViewBag.Tercero = "Martina Escobar";
                cantidad = 3;
                confirmado = 1;
            }
			else if (codigo == "TAZB")
			{
				ViewBag.Primero = "Angela Sandoval";
				ViewBag.Segundo = "Rodolfo Rivera";
				ViewBag.Tercero = "Amaro Rivera";
				cantidad = 3;
                confirmado = 1;
            }
			// CUATRO INVITADOS
			else if (codigo == "FNDB")
            {
                ViewBag.Primero = "María Sandoval";
                ViewBag.Segundo = "Jaime Quiñónez";
                ViewBag.Tercero = "Ignacia Quiñónez";
                ViewBag.Cuarto = "Alonso Quiñónez";
                cantidad = 4;
            }
            else if (codigo == "ADCU")
            {
                ViewBag.Primero = "Richard Cartes S.";
                ViewBag.Segundo = "Mabel Vega H.";
                ViewBag.Tercero = "María Jesús Cartes V.";
                cantidad = 3;
            }
            else if(codigo == "CYN")
            {
                return RedirectToAction("Error");
            }
            else
            {
                return RedirectToAction("Error");
			}

            ViewBag.Cantidad = cantidad;
            ViewBag.Confirmado = confirmado;
            ViewBag.Code = codigo.ToUpper();

            return View();
        }
        [HttpGet]
        public ActionResult Validar(string mensaje, string confirmacion, string primero, string segundo, string tercero, string cuarto, string cantidad, string codeOu)
        {
            if(segundo == null)
            {
                cantidad = "1";
            }
            else if(tercero == null)
            {
                cantidad = "2";
            }
            else if(cuarto == null)
            {
                cantidad = "3";
            }

            email.EnviarEmail(primero, segundo, tercero, cuarto, confirmacion, mensaje, int.Parse(cantidad), codeOu);

            if(confirmacion == "NoAsistire")
            {
				return Json(new { data = true, responseText = "Lamentamos que no puedas asistir." });
			}
            return Json(new { data = true, responseText = "Te esperamos!!" });
        }
        public IActionResult Error()
        {
			var urlHelper = _urlHelperFactory.GetUrlHelper(_actionContextAccessor.ActionContext);
			var returnUrl = urlHelper.Action("Invitacion", "Home", null, Request.Scheme);
			ViewBag.ReturnUrl = returnUrl;
			return View();
        }
    }
}