using BusProject2023Students.DTO;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BusProject2023Students.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {

        public BusData busData = new BusData();
        public string Output { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            if (busData.Age <= busData.lowerAgeDiscount || busData.Age > busData.UpperAgeDiscount)
            {

                busData.Ash = busData.Ash - (busData.Ash * busData.Discount);
                busData.Tim = busData.Tim - (busData.Tim * busData.Discount);
                Output = "Discount  " + busData.Ash;
            }
            else
            {
                Output = "full fare";

            }

        }
    }
}