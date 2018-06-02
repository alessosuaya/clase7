using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Clase7_1.Pages
{
    public class IndexModel : PageModel
    {

        public double? resultado;
        public string msnerror;
       
        public void OnGet(double numero1,string operacion, double numero2)
        {
           
            if (numero1 != 0 || numero2 != 0)
            {


                switch (operacion)
                {


                    case "suma": resultado = (numero1 + numero2); break;
                    case "resta": resultado = (numero1 - numero2); break;
                    case "multi": resultado = (numero1 * numero1); break;
                    case "divi":
                        if (numero2 != 0)
                        {
                            resultado = numero1 / numero2;
                        }
                        else
                        {   msnerror = "NO SE PUEDE DIVIDIR POR CERO";
                            resultado = null;
                        };break;
                        case "pote": resultado = Math.Pow(numero1, numero2); break;
                        case "expo": resultado = Math.Exp(numero1); break;
                        case "radi": resultado = Math.Sqrt(numero1); break;
                    
                    }
                
                
            }

        }

        public ActionResult OnPost()
        {
            //Obtiene los valores del formulario, segun name
            var n1 =Request.Form["numero1"];
            var n2 =Request.Form["numero2"];
            var opc = Request.Form["operacion"];
                       //Redirecciona Al GET con los parametros que enviamos
            return Redirect("Index?numero1=" + n1 +"&operacion="+ opc +"&numero2=" + n2);

        }
    }
}
