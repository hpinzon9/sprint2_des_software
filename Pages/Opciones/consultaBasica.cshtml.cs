using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace vistacuidadop.App.frotend.Pages
{
    public class consultaBasicaModel : PageModel
    {
        public string[] cerditoUno = { "1", "Porky", "Café", "Cerdo vietnamita", "Berkshire", "1005894644", "1005245123" };
        public string[] cerditoDos = { "2", "Babe", "Rosado", "Large white", "Spotted Poland", "134250054", "1005245123" };
        public string[] cerditoTres = { "3", "Bambi", "Gris y negro", "Spotted Poland", "Duroc Jersey", "1033456256", "100334785" };
        public string[]? cerditoBuscado;
        public List<string[]> listaCerditos = new List<string[]>();
        public IActionResult OnGet(string id)
        {
            if (id == null)
            {
                cerditoBuscado = null;
                return Page();
            }
            else
            {
                listaCerditos.Add(cerditoUno);
                listaCerditos.Add(cerditoDos);
                listaCerditos.Add(cerditoTres);
                cerditoBuscado = BuscarCerdito(id);
                return Page();
            }

        }

        public string[] BuscarCerdito(string id)
        {
            foreach (var cerdito in listaCerditos)
            {
                if (cerdito[0] == id)
                {
                    return cerdito;
                }
            }
            return new string[1];
        }
    }
}
