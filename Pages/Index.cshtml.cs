using BusProject2023Students.DTO;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BusProject2023Students.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {

        public BusData busData { get; set; }


        public void OnGet()
        {

        }

        public void OnPost()
        {


        }
    }
}