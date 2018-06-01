using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Clase7_1.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            var fechaDeHoy = DateTime.Today;
            var fechaAComparar = new DateTime(2018, 04, 15);

            if (fechaDeHoy > fechaAComparar)
            {
                Message = "La fecha de hoy es mayor a" + fechaAComparar.ToLongDateString();

            }
            else
            {
                Message = "La fecha de hoy es menor a " + fechaAComparar.ToLongDateString();
            }            
        }
    }
}
