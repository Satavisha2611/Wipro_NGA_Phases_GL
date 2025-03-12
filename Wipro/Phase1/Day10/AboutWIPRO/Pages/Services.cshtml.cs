using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WIPRO.ModelPages;

namespace AboutWIPRO.Pages
{
    public class ServicesModel : PageModel
    {
        public List<string> service= new List<string>();
        public void OnGet()
        {
            Services ser1 = new Services("Consultancy");
            Services ser2 = new Services("Cloud Services");
            Services ser3 = new Services("Careers");

            service.Add(ser1.Service);
            service.Add(ser2.Service);
            service.Add(ser3.Service);
        }
    }
}
