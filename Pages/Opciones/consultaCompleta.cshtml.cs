using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace vistacuidadop.App.frotend.Pages
{
    public class consultaCompletaModel : PageModel
    {

        public string[] cerditoUno = { "1", "Porky", "Café", "Cerdo vietnamita", "Berkshire", "1005894644", "1005245123" };
        public string[] cerditoDos = { "2", "Babe", "Rosado", "Large white", "Spotted Poland", "134250054", "1005245123" };
        public string[] cerditoTres = { "3", "Bambi", "Gris y negro", "Spotted Poland", "Duroc Jersey", "10334562", "100334785" };
        public List<string[]> listaCerditos = new List<string[]>();
        public void OnGet()
        {
            listaCerditos.Add(cerditoUno);
            listaCerditos.Add(cerditoDos);
            listaCerditos.Add(cerditoTres);
        }
    }
}

